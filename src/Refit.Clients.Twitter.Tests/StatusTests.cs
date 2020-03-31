﻿// <copyright file="StatusTests.cs" company="Benjamin Howarth &amp; contributors">
// Copyright (c) Benjamin Howarth &amp; contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Globalization;
using System.Threading.Tasks;
using NUnit.Framework;
using Refit.Clients.Twitter.Models.QueryParams;

namespace Refit.Clients.Twitter.Tests
{
	[TestFixture]
	public class StatusTests
	{
		private TwitterClient _client;
		private IStatuses _statuses;
		private string consumerKey;
		private string consumerSecret;
		private string accessToken;
		private string accessTokenSecret;

		[SetUp]
		public void Setup()
		{
            var config = LocalSecretConfiguration.GetConfig();
            consumerKey = config["Twitter-ConsumerKey"];
            consumerSecret = config["Twitter-ConsumerSecret"];
            accessToken = config["Twitter-AccessToken"];
            accessTokenSecret = config["Twitter-AccessTokenSecret"];
			_client = TwitterClient.Create(consumerKey, consumerSecret, accessToken, accessTokenSecret);
			_statuses = _client.Statuses;
		}

		[Test]
		public async Task Test_Statuses_Get()
		{
			ulong tweetId = 1101833311348031488;
			var tweet = await _statuses.Get(tweetId);
			Assert.IsNotNull(tweet);
		}

		[Test]
		[Explicit("Non-GET REST method, should only be tested against a dummy account ideally")]
		public async Task Test_Statuses_Post()
		{
			var newTweet = new TweetQueryParams() { Status = "Refit test post" };
			Assert.DoesNotThrowAsync(async () => await _statuses.Post(newTweet));
		}

		[Test]
		[Explicit("Non-GET REST method, should only be tested against a dummy account ideally")]
		public async Task Test_Statuses_PostWithMedia()
        {
            Assert.Fail();
			ulong mediaId = 0;
			using (var file = System.IO.File.OpenRead("test-image.png"))
			{
				var fileBytes = new byte[file.Length];
				file.Read(fileBytes, 0, fileBytes.Length);
				file.Close();
				Assert.DoesNotThrowAsync(async () => { mediaId = await _client.UploadService.Upload(fileBytes, "image/png"); });
			}

			var newTweet = new TweetQueryParams() { Status = "Refit media test", MediaIDs = mediaId.ToString(CultureInfo.DefaultThreadCurrentCulture) };
			Assert.DoesNotThrowAsync(async () => await _statuses.Post(newTweet));
		}
	}
}
