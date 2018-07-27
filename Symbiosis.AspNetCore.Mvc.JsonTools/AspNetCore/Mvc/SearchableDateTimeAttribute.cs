﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Mvc
{
	using Infrastructure;

	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	public class SearchableDateTimeAttribute : SearchableAttribute
	{
		public SearchableDateTimeAttribute()
		{
			ExpressionProvider = new DateTimeSearchExpressionProvider();
		}
	}
}
