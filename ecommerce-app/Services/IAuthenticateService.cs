using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.Controllers
{
    public interface IAuthenticateService
    {
        string Authenticate(string username, string password);
    }
}
