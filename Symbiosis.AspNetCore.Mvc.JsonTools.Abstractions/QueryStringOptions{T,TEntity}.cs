using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Microsoft.AspNetCore.Mvc.Abstractions
{
	public abstract class QueryStringOptions<T, TEntity, TOptionsProcessor, TTerm>
		 : IValidatableObject
		where TOptionsProcessor : class, IQueryStringOptionsProcessor<T, TEntity, TTerm>, new()
		where TTerm : QueryOptionsTerm, new()
	{
		protected TOptionsProcessor _processor { get; set; }

		public string[] _queryStrings { get; protected set; }
		public abstract IEnumerable<ValidationResult> Validate(ValidationContext validationContext);

		public virtual IQueryable<TEntity> Apply(IQueryable<TEntity> query) 
			=> _processor.Apply(query);
	}
}
