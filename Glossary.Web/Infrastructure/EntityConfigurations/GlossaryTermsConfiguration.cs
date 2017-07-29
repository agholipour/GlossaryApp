using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Glossary.Model;

namespace Glossary.Web.Infrastructure.EntityConfigurations
{
    public class GlossaryTermsConfiguration : EntityTypeConfiguration<GlossaryTerm>
    {
        public GlossaryTermsConfiguration()
        {
            
            Property(g => g.Id)
                .IsRequired();

            Property(g => g.Term)
           .IsRequired().HasMaxLength(50);

            Property(g => g.Definition)
               .IsRequired().HasMaxLength(255);
        }
       
    }
}