using System.Collections.Generic;
using System.Linq;

namespace Microsoft.AspNetCore.Mvc.Abstractions
{
	public interface IQueryStringOptionsProcessor<T, TEntity, TTerm>
		  where TTerm : QueryOptionsTerm, new()
	{
		void SetQuery(string[] query);

		IEnumerable<TTerm> GetAllTerms();
		IEnumerable<TTerm> GetValidTerms();
		IQueryable<TEntity> Apply(IQueryable<TEntity> query);
	}
}
