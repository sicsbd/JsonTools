﻿using System;
using System.Linq.Expressions;

namespace Microsoft.AspNetCore.Mvc.Infrastructure
{
	using Abstractions;

	public class DecimalToIntSearchExpressionProvider : ComparableSearchExpressionProvider
    {
        public override ConstantExpression GetValue(string input)
        {
            if (!decimal.TryParse(input, out var dec))
                throw new ArgumentException("Invalid search value.");

            var places = BitConverter.GetBytes(decimal.GetBits(dec)[3])[2];
            if (places < 2) places = 2;
            var justDigits = (int)(dec * (decimal)Math.Pow(10, places));

            return Expression.Constant(justDigits);
        }
    }
}
