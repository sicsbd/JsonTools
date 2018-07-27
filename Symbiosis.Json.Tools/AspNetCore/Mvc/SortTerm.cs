using Microsoft.AspNetCore.Mvc.Abstractions;

namespace Microsoft.AspNetCore.Mvc
{
	public class SortTerm
		 : QueryOptionsTerm
	{
		public bool Descending { get; set; }
	}
}
