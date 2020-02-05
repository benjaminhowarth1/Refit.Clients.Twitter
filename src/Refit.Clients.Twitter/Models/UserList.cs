﻿// <copyright file="UserList.cs" company="Benjamin Howarth &amp; contributors">
// Copyright (c) Benjamin Howarth &amp; contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Refit.Clients.Twitter.Models
{
	using System;
	using Newtonsoft.Json;

	public class UserList
	{
		public ulong ID { get; set; }

		[JsonProperty("id_str")]
		public string IDString { get; set; }

		public string Name { get; set; }

		public string Uri { get; set; }

		public int SubscriberCount { get; set; }

		public int MemberCount { get; set; }

		public string Mode { get; set; }

		public string Description { get; set; }

		public string Slug { get; set; }

		public string FullName { get; set; }

		public DateTime CreatedAt { get; set; }

		public bool Following { get; set; }

		public User User { get; set; }
	}
}
