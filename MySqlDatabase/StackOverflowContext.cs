using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace MySqlDatabase
{
    public class StackOverflowContext : DbContext
    {
        public StackOverflowContext() : base("stackoverlfow")
        {
            
        }
        public DbSet<Annotation> Annotations { get; set; }
        public DbSet<Post> Posts { get; set; } 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /***************************************
                        Annotation
            ***************************************/
            modelBuilder.Entity<Annotation>().ToTable("annotation");
            modelBuilder.Entity<Annotation>().Property(a => a.Id).HasColumnName("annotationid");
            modelBuilder.Entity<Annotation>().Property(a => a.PostId).HasColumnName("postid");
            modelBuilder.Entity<Annotation>().Property(a => a.CommentId).HasColumnName("commentid");
            modelBuilder.Entity<Annotation>()
                .Property(a => a.AnnotationDescription)
                .HasColumnName("annotationdescription");
            modelBuilder.Entity<Annotation>()
                .Property(a => a.AnnotationCreateDate)
                .HasColumnName("annotationcreatedate");
            base.OnModelCreating(modelBuilder);


            /***************************************
                        Posts
            ***************************************/
            modelBuilder.Entity<Annotation>().ToTable("posts");
            modelBuilder.Entity<Annotation>().Property(a => a.Id).HasColumnName("id");
            base.OnModelCreating(modelBuilder);
        }
    }
}
