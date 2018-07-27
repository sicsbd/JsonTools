namespace Microsoft.AspNetCore.Mvc.Abstractions
{
	public abstract class QueryOptionsTerm
	{

		public string Name { get; set; }

		public string EntityName { get; set; }


		public bool Default { get; set; }
	}
}
