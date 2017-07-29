namespace Glossary.Model
{
    public class GlossaryTerm
    {
        public virtual int Id { get; set; }
        /// <summary>
        /// The term of reference
        /// </summary>
        public virtual string Term { get; set; }
        /// <summary>
        /// A  paragraph of text describing the meaning of the term.
        /// </summary>
        public virtual string Definition { get; set; }

        public void Modify(string term, string definition)
        {
            this.Term = term;
            this.Definition = definition;
        }
    }
}
