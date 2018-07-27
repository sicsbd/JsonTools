using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Microsoft.AspNetCore.Mvc
{
	using Abstractions;

	public class SearchOptions<T, TEntity> 
		: QueryStringOptions<T,TEntity, SearchOptionsProcessor<T,TEntity>, SearchTerm>
	{
		public string[] Search { get; set; }

		public SearchOptions()
		{
			_processor = new SearchOptionsProcessor<T, TEntity>();
			_processor.SetQuery(Search);
		}

		public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			var validTerms = _processor.GetValidTerms().Select(x => x.Name);
			var invalidTerms = _processor.GetAllTerms().Select(x => x.Name)
			    .Except(validTerms, StringComparer.OrdinalIgnoreCase);

			foreach (var term in invalidTerms)
			{
				yield return new ValidationResult(
				    $"Invalid search term '{term}'.",
				    new[] { nameof(Search) });
			}
		}
	}
}
