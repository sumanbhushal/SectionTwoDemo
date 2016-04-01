using System.Collections.Generic;
using DomainModel;

namespace DataAccessLayer
{
    public interface IRepository
    {
        /*----------------------
                Annotation
        ------------------------*/
        IEnumerable<Annotation> GetAnnotions();
        Annotation FindAnnotationById(int id);

        /*----------------------
                Posts
        ------------------------*/
        IEnumerable<Post> GetPosts();
    }
}