using System.Data.Entity;
using Glossary.Model;

namespace Glossary.Web.Infrastructure
{
    public interface IApplicationDbContext
    {
         DbSet<GlossaryTerm> Glossary { get; set; }
    }
}
