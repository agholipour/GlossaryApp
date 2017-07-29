using Glossary.Web.Infrastructure.Repository;

namespace Glossary.Web.Infrastructure
{
    public interface IUnitOfWork
    {
        IGlossaryTermRepository GlossaryTermRepository { get; }
        void Complete();
    }
}
