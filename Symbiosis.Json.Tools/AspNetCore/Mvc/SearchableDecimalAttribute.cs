﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Mvc
{
	using Infrastructure;

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class SearchableDecimalAttribute : SearchableAttribute
    {
        public SearchableDecimalAttribute()
        {
            ExpressionProvider = new DecimalToIntSearchExpressionProvider();
        }
    }
}
