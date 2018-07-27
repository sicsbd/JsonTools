using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Microsoft.AspNetCore.Mvc
{
	using Abstractions;

	public class SortOptions<T, TEntity> :
		QueryStringOptions<T, TEntity, SortOptionsProcessor<T, TEntity>, SortTerm>
	{
		public string[] OrderBy { get; set; }

		public SortOptions()
		{
			_processor = new SortOptionsProcessor<T, TEntity>();
			_processor.SetQuery(OrderBy);
		}

		// ASP.NET Core calls this to validate the incoming parameters
		public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			var validTerms = _processor.GetValidTerms().Select(x => x.Name);

			var invalidTerms = _processor.GetAllTerms().Select(x => x.Name)
			    .Except(validTerms, StringComparer.OrdinalIgnoreCase);

			foreach (var term in invalidTerms)
			{
				yield return new ValidationResult(
				    $"Invalid sort term '{term}'.",
				    new[] { nameof(OrderBy) });
			}
		}
	}
}
