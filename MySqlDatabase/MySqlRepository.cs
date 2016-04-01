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

        /*----------------------
            Annotation
        ----------------------*/
        public IEnumerable<Annotation> GetAnnotions()
        {
            using (var database = new StackOverflowContext())
            {
                return database.Annotations.Take(5).ToList();
            }
        }

        public Annotation FindAnnotationById(int id)
        {
            using (var database = new StackOverflowContext())
            {
                return database.Annotations.FirstOrDefault(a => a.Id == id);
            }
            {
                
            }
        }

        /*----------------------
            Posts
        ----------------------*/

        public IEnumerable<Post> GetPosts()
        {
            using (var dbPost = new StackOverflowContext())
            {
                return dbPost.Posts
                    .OrderBy(p => p.Id)
                    .Take(20)
                    .ToList();

            }
        }
    }
}

