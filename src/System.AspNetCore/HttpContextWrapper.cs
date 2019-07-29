﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using Microsoft.AspNetCore.Http;
using Microsoft.Omex.System.Validation;
using Microsoft.Omex.System.Logging;

namespace Microsoft.Omex.System.AspNetCore
{
	/// <summary>
	/// Http context wrapper
	/// </summary>
	public class HttpContextWrapper
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="contextAccessor">Http context accessor</param>
		public static void Configure(IHttpContextAccessor contextAccessor)
		{
			s_contextAccessor = Code.ExpectsArgument(contextAccessor, nameof(contextAccessor), TaggingUtilities.ReserveTag(0x23857153 /* tag_97xft */));
		}


		/// <summary>
		/// The current http context
		/// </summary>
		public static HttpContext Current => s_contextAccessor?.HttpContext;


		/// <summary>
		/// Http context accessor
		/// </summary>
		private static IHttpContextAccessor s_contextAccessor;
	}
}
