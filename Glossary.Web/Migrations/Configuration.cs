using Glossary.Model;
using System.Data.Entity.Migrations;
using Glossary.Web.Infrastructure;

namespace Glossary.Web.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            context.Glossary.AddOrUpdate(
              p => p.Term ,
              new GlossaryTerm() { Term = "abyssal plain", Definition = "The ocean floor offshore from the continental margin, usually very flat with a slight slope." },
              new GlossaryTerm() { Term = "accrete", Definition = "v. To add terranes (small land masses or pieces of crust) to another, usually larger, land mass." },
              new GlossaryTerm() { Term = "alkaline", Definition = "Term pertaining to a highly basic, as opposed to acidic, subtance. For example, hydroxide or carbonate of sodium or potassium." }
            );
        }
    }
}
