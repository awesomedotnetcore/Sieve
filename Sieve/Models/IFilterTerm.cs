﻿namespace Sieve.Models
{
    public interface IFilterTerm
    {
        string Filter { set; }
        string[] Names { get; }
        string Operator { get; }
        bool OperatorIsCaseInsensitive { get; }
        FilterOperator OperatorParsed { get; }
        string[] Values { get; }
    }
}
