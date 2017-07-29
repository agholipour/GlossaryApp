using Glossary.Web.Infrastructure;
using Owin;


namespace Glossary.Web
{
    public partial class Startup
    {
        public void ConfigureDbContext(IAppBuilder app)
        {
            app.CreatePerOwinContext(ApplicationDbContext.Create);
        }
    }
}