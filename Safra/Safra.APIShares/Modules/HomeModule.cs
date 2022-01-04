using Carter;
using Microsoft.AspNetCore.Http;

namespace Safra.APIShares.Modules
{
    public class HomeModule : CarterModule
    {
        public HomeModule()
        {
            Get("/",(req,res)=>res.WriteAsync("Olá Carter!"));
        }
    }
}
