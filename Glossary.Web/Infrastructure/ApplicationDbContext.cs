using System;
using System.Data.Entity;
using Glossary.Model;
using Glossary.Web.Infrastructure.EntityConfigurations;

namespace Glossary.Web.Infrastructure
{
    public class ApplicationDbContext :DbContext, IApplicationDbContext
    {
        public DbSet<GlossaryTerm> Glossary { get; set; }

        public ApplicationDbContext():base("DefaultConnection")
        {
                
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GlossaryTermsConfiguration());
        }

    }
}