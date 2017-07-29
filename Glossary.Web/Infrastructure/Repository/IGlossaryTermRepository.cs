using System.Collections.Generic;
using Glossary.Model;

namespace Glossary.Web.Infrastructure.Repository
{
    public interface IGlossaryTermRepository
    {
        GlossaryTerm GetGlossaryTerm(int termId);
        IEnumerable<GlossaryTerm> GetGlossaryTermByTerm(string searchTerm = null);
        IEnumerable<GlossaryTerm> GetGlossaryTerms();
        void Add(GlossaryTerm glossaryTerm);
        void Remove(GlossaryTerm glossaryTerm);
    }
}
