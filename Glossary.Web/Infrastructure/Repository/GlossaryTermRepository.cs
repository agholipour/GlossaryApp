using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glossary.Model;

namespace Glossary.Web.Infrastructure.Repository
{
    public class GlossaryTermRepository : IGlossaryTermRepository
    {
        private readonly IApplicationDbContext _context;
        public GlossaryTermRepository(IApplicationDbContext context)
        {
            _context = context;
        }
        public GlossaryTerm GetGlossaryTerm(int termId)
        {
            return _context.Glossary.SingleOrDefault(x => x.Id ==termId);
        }

        public IEnumerable<GlossaryTerm> GetGlossaryTermByTerm(string searchTerm = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GlossaryTerm> GetGlossaryTerms()
        {
            return _context.Glossary.OrderBy(x => x.Term).ToList();
        }

        public void Add(GlossaryTerm glossaryTerm)
        {
            _context.Glossary.Add(glossaryTerm);
        }

        public void Remove(GlossaryTerm glossaryTerm)
        {
             _context.Glossary.Remove(glossaryTerm);
        }
    }
}