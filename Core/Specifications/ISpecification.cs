using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Specifications
{
    public interface ISpecification<T>
    {
         Expression<Func<T, bool>> Criteria {get;} // Criteria => for example where productType has one 
        List<Expression<Func<T, object>>> Includes {get;} //object is most genral thing used in C#
    }
}