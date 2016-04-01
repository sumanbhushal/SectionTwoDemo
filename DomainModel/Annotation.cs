using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Annotation
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int CommentId { get; set; }
        public string AnnotationDescription { get; set; }
        public DateTime AnnotationCreateDate { get; set; }
    }
}
