using System.Collections.Generic;
using DomainModel;

namespace DataAccessLayer
{
    public interface IRepository
    {
        IEnumerable<Annotation> GetAnnotions();
    }
}