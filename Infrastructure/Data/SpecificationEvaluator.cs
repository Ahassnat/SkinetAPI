using System.Linq;
using Core.Entities;
using Core.Specifications;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class SpecificationEvaluator<TEntity> where TEntity : BaseEntity
    {
        public static IQueryable<TEntity> GetQurey(IQueryable<TEntity> inputQuery,
                                                ISpecification<TEntity> spec)
        {
            var query = inputQuery;

            if(spec != null)
            {
                query = query.Where(spec.Criteria);
            }
                // Aggregate => take the Include query of for Ex. type and brand then pass them to query
            query = spec.Includes.Aggregate(query, (current,include) => current.Include(include));
            return query;
        }
    }
}