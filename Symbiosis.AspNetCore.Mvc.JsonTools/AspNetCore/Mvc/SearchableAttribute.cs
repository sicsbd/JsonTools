using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;

namespace Microsoft.AspNetCore.Mvc
{
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	public class SearchableAttribute 
		: Attribute
	{
		public string EntityProperty { get; set; }

		public ISearchExpressionProvider ExpressionProvider { get; set; }
		    = new DefaultSearchExpressionProvider();
	}
}
