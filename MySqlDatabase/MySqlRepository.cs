using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DomainModel;

namespace MySqlDatabase
{
    public class MySqlRepository : IRepository
    {
        public IEnumerable<Annotation> GetAnnotions()
        {
            using (var database = new StackOverflowContext())
            {
                return database.Annotations.Take(5).ToList();
            }
        }
    }
}
