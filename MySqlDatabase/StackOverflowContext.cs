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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Annotation>().ToTable("annotation");
            modelBuilder.Entity<Annotation>().Property(i => i.Id).HasColumnName("annotationid");
            base.OnModelCreating(modelBuilder);
        }
    }
}
