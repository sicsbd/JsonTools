using Microsoft.AspNetCore.Mvc.Abstractions;

namespace Microsoft.AspNetCore.Mvc
{
	public class SearchTerm
		 : QueryOptionsTerm
	{
		public string Operator { get; set; }


		public string Value { get; set; }

		public bool ValidSyntax { get; set; }

		public ISearchExpressionProvider ExpressionProvider { get; set; }
	}
}
