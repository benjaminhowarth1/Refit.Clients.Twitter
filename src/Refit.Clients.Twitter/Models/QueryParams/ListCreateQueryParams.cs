﻿using System;

namespace Refit.Clients.Twitter.Models.QueryParams
{

	public class ListCreateQueryParams
	{
		private ListMode _mode;

		[AliasAs("name")]
		public string Name { get; set; }

		[AliasAs("mode")]
		public string Mode
		{
			get => this._mode.ToString().ToLower();
			set => Enum.TryParse(value, out this._mode);
		}

		[AliasAs("description")]
		public string Description { get; set; }
	}
}
