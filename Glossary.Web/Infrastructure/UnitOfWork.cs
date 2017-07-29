using System;
using Glossary.Web.Infrastructure.Repository;

namespace Glossary.Web.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IGlossaryTermRepository GlossaryTermRepository { get; private set; }

        public void Complete()
        {
            _context.SaveChanges();
        }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            GlossaryTermRepository = new GlossaryTermRepository(context);
        }
    }

    
}