using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BorrowBook.Startup))]
namespace BorrowBook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
