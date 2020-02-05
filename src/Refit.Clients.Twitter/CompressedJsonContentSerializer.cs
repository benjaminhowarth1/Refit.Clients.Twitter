﻿// <copyright file="CompressedJsonContentSerializer.cs" company="Benjamin Howarth &amp; contributors">
// Copyright (c) Benjamin Howarth &amp; contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Refit.Clients
{
	public class CompressedJsonContentSerializer : IContentSerializer
	{
		private readonly Lazy<JsonSerializerSettings> _jsonSerializerSettings;

		public CompressedJsonContentSerializer(JsonSerializerSettings jsonSerializerSettings)
		{
			_jsonSerializerSettings = new Lazy<JsonSerializerSettings>(() =>
			{
				if (jsonSerializerSettings == null)
				{
					if (JsonConvert.DefaultSettings == null)
					{
						return new JsonSerializerSettings();
					}

					return JsonConvert.DefaultSettings();
				}

				return jsonSerializerSettings;
			});
		}

		/// <inheritdoc/>
		public async Task<HttpContent> SerializeAsync<T>(T item)
		{
			var content = new StringContent(JsonConvert.SerializeObject(item, _jsonSerializerSettings.Value), Encoding.UTF8, "application/json");
			return await Task.FromResult((HttpContent)content);
		}

		/// <inheritdoc/>
		public async Task<T> DeserializeAsync<T>(HttpContent content)
		{
			var serializer = JsonSerializer.Create(_jsonSerializerSettings.Value);

			if (content == null) return default(T);

			using (var stream = await content.ReadAsStreamAsync().ConfigureAwait(false))
			{
				if (content.Headers.ContentEncoding.Any(x => x == "gzip"))
				{
					using (var decompressed = new GZipStream(stream, CompressionMode.Decompress))
					{
						return await ReadStreamToObject<T>(decompressed, serializer)
							.ConfigureAwait(false);
					}
				}
				else if (content.Headers.ContentEncoding.Any(x => x == "deflate"))
				{
					using (var decompressed = new DeflateStream(stream, CompressionMode.Decompress))
					{
						return await ReadStreamToObject<T>(decompressed, serializer)
							.ConfigureAwait(false);
					}
				}
				else
				{
					return await ReadStreamToObject<T>(stream, serializer);
				}
			}
		}

		private async Task<T> ReadStreamToObject<T>(Stream stream, JsonSerializer serializer)
		{
			using (var reader = new StreamReader(stream))
			{
				using (var jsonTextReader = new JsonTextReader(reader))
				{
					return serializer.Deserialize<T>(jsonTextReader);
				}
			}
		}
	}
}
