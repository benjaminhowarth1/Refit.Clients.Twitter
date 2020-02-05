﻿// <auto-generated />
using System;
using System.Net.Http;
using System.Collections.Generic;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

#pragma warning disable
namespace RefitInternalGenerated
{
	[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
	[AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
	sealed class PreserveAttribute : Attribute
	{

		//
		// Fields
		//
		public bool AllMembers;

		public bool Conditional;
	}
}
#pragma warning restore

namespace Refit.Clients.Twitter
{
	using RefitInternalGenerated;
	using System.Runtime.CompilerServices;
	using System.Threading.Tasks;
	using Refit;
	using Refit.Clients.Twitter.Models;
	using Refit.Clients.Twitter.Models.QueryParams;

	/// <inheritdoc />
	[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[Preserve]
	[global::System.Reflection.Obfuscation(Exclude=true)]
	partial class AutoGeneratedILists : ILists
	{
		/// <inheritdoc />
		public HttpClient Client { get; protected set; }
		readonly IRequestBuilder requestBuilder;

		/// <inheritdoc />
		public AutoGeneratedILists(HttpClient client, IRequestBuilder requestBuilder)
		{
			Client = client;
			this.requestBuilder = requestBuilder;
		}

		/// <inheritdoc />
		Task<IEnumerable<UserList>> ILists.GetLists(IDOrScreenNameQueryParams queryParams)
		{
			var arguments = new object[] { queryParams };
			var func = requestBuilder.BuildRestResultFuncForMethod("GetLists", new Type[] { typeof(IDOrScreenNameQueryParams) });
			return (Task<IEnumerable<UserList>>)func(Client, arguments);
		}

		/// <inheritdoc />
		Task<ListMembers> ILists.GetMembers(ListMembersQueryParams queryParams)
		{
			var arguments = new object[] { queryParams };
			var func = requestBuilder.BuildRestResultFuncForMethod("GetMembers", new Type[] { typeof(ListMembersQueryParams) });
			return (Task<ListMembers>)func(Client, arguments);
		}

		/// <inheritdoc />
		Task<User> ILists.ShowMember(ListMemberQueryParams queryParams)
		{
			var arguments = new object[] { queryParams };
			var func = requestBuilder.BuildRestResultFuncForMethod("ShowMember", new Type[] { typeof(ListMemberQueryParams) });
			return (Task<User>)func(Client, arguments);
		}

		/// <inheritdoc />
		Task<ListMemberships> ILists.GetMemberships(ListMembershipQueryParams queryParams)
		{
			var arguments = new object[] { queryParams };
			var func = requestBuilder.BuildRestResultFuncForMethod("GetMemberships", new Type[] { typeof(ListMembershipQueryParams) });
			return (Task<ListMemberships>)func(Client, arguments);
		}

		/// <inheritdoc />
		Task<ListMemberships> ILists.GetOwnerships(ListMembershipQueryParams queryParams)
		{
			var arguments = new object[] { queryParams };
			var func = requestBuilder.BuildRestResultFuncForMethod("GetOwnerships", new Type[] { typeof(ListMembershipQueryParams) });
			return (Task<ListMemberships>)func(Client, arguments);
		}

		/// <inheritdoc />
		Task<UserList> ILists.ShowList(ListIDOrSlugQueryParams queryParams)
		{
			var arguments = new object[] { queryParams };
			var func = requestBuilder.BuildRestResultFuncForMethod("ShowList", new Type[] { typeof(ListIDOrSlugQueryParams) });
			return (Task<UserList>)func(Client, arguments);
		}

		/// <inheritdoc />
		Task<IEnumerable<Tweet>> ILists.GetStatuses(ListStatusQueryParams queryParams)
		{
			var arguments = new object[] { queryParams };
			var func = requestBuilder.BuildRestResultFuncForMethod("GetStatuses", new Type[] { typeof(ListStatusQueryParams) });
			return (Task<IEnumerable<Tweet>>)func(Client, arguments);
		}

		/// <inheritdoc />
		Task<ListMembers> ILists.GetSubscribers(ListIDOrSlugCursorQueryParams queryParams)
		{
			var arguments = new object[] { queryParams };
			var func = requestBuilder.BuildRestResultFuncForMethod("GetSubscribers", new Type[] { typeof(ListIDOrSlugCursorQueryParams) });
			return (Task<ListMembers>)func(Client, arguments);
		}

		/// <inheritdoc />
		Task<User> ILists.ShowSubscribers()
		{
			var arguments = new object[] {  };
			var func = requestBuilder.BuildRestResultFuncForMethod("ShowSubscribers", new Type[] {  });
			return (Task<User>)func(Client, arguments);
		}

		/// <inheritdoc />
		Task<ListMemberships> ILists.GetSubscriptions(CountCursorQueryParams queryParams)
		{
			var arguments = new object[] { queryParams };
			var func = requestBuilder.BuildRestResultFuncForMethod("GetSubscriptions", new Type[] { typeof(CountCursorQueryParams) });
			return (Task<ListMemberships>)func(Client, arguments);
		}

		/// <inheritdoc />
		Task<UserList> ILists.CreateList(ListCreateQueryParams createParams)
		{
			var arguments = new object[] { createParams };
			var func = requestBuilder.BuildRestResultFuncForMethod("CreateList", new Type[] { typeof(ListCreateQueryParams) });
			return (Task<UserList>)func(Client, arguments);
		}

		/// <inheritdoc />
		Task<UserList> ILists.DeleteList(ListIDOrSlugQueryParams destroyParams)
		{
			var arguments = new object[] { destroyParams };
			var func = requestBuilder.BuildRestResultFuncForMethod("DeleteList", new Type[] { typeof(ListIDOrSlugQueryParams) });
			return (Task<UserList>)func(Client, arguments);
		}

		/// <inheritdoc />
		Task ILists.CreateListMember()
		{
			var arguments = new object[] {  };
			var func = requestBuilder.BuildRestResultFuncForMethod("CreateListMember", new Type[] {  });
			return (Task)func(Client, arguments);
		}

		/// <inheritdoc />
		Task ILists.CreateAllListMembers()
		{
			var arguments = new object[] {  };
			var func = requestBuilder.BuildRestResultFuncForMethod("CreateAllListMembers", new Type[] {  });
			return (Task)func(Client, arguments);
		}

		/// <inheritdoc />
		Task ILists.DeleteListMember()
		{
			var arguments = new object[] {  };
			var func = requestBuilder.BuildRestResultFuncForMethod("DeleteListMember", new Type[] {  });
			return (Task)func(Client, arguments);
		}

		/// <inheritdoc />
		Task ILists.DeleteAllListMembers()
		{
			var arguments = new object[] {  };
			var func = requestBuilder.BuildRestResultFuncForMethod("DeleteAllListMembers", new Type[] {  });
			return (Task)func(Client, arguments);
		}

		/// <inheritdoc />
		Task ILists.CreateListSubscriber()
		{
			var arguments = new object[] {  };
			var func = requestBuilder.BuildRestResultFuncForMethod("CreateListSubscriber", new Type[] {  });
			return (Task)func(Client, arguments);
		}

		/// <inheritdoc />
		Task ILists.DeleteListSubscriber()
		{
			var arguments = new object[] {  };
			var func = requestBuilder.BuildRestResultFuncForMethod("DeleteListSubscriber", new Type[] {  });
			return (Task)func(Client, arguments);
		}

		/// <inheritdoc />
		Task<UserList> ILists.UpdateList(UpdateListQueryParams list)
		{
			var arguments = new object[] { list };
			var func = requestBuilder.BuildRestResultFuncForMethod("UpdateList", new Type[] { typeof(UpdateListQueryParams) });
			return (Task<UserList>)func(Client, arguments);
		}
	}
}
