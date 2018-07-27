using System.Collections.Generic;
using System.Linq.Expressions;

namespace Microsoft.AspNetCore.Mvc.Abstractions
{
	public interface ISearchExpressionProvider
	{
		IEnumerable<string> GetOperators();

		ConstantExpression GetValue(string input);

		Expression GetComparison(
		    MemberExpression left,
		    string op,
		    ConstantExpression right);
	}
}
