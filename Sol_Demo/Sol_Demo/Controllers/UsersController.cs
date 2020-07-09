using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sol_Demo.Models;

namespace Sol_Demo.Controllers
{
    [Produces("application/json")]
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        #region Private Method

        private Task<IEnumerable<UserModel>> GetUserDataAsync()
        {
            var userList = new List<UserModel>();

            userList.Add(new UserModel() { FirstName = "Kishor", LastName = "Naik" });
            userList.Add(new UserModel() { FirstName = "Yogesh", LastName = "Naik" });
            userList.Add(new UserModel() { FirstName = "Eshaan", LastName = "Naik" });

            return Task.FromResult<IEnumerable<UserModel>>(userList);
        }

        #endregion Private Method

        #region Public Endpoint

        // http://localhost:34309/api/users/getuserdata
        [HttpPost("getuserdata")]
        [ResponseCache(CacheProfileName = "Default-Cache")]
        public async Task<IActionResult> GetUserDataEndPointAsync()
        {
            var data = await this.GetUserDataAsync();

            return base.Ok((Object)data);
        }

        #endregion Public Endpoint
    }
}