using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSharpFikalista.Startup))]
namespace CSharpFikalista
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
