using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using poc_webapi.data;
using Microsoft.AspNetCore.Cors;

namespace poc_webapi.Controllers
{
    [EnableCors("SiteCorsPolicy")]
    public class UserController : Controller
    {
        private UbcDbContext dbContext = null;

        public UserController(UbcDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        // GET api/user/all
        [HttpGet]
        [Route("api/[controller]/all")]
        public async Task<IActionResult> Get()
        {
            var users = await this.dbContext.PocUser.ToListAsync();
            return new ObjectResult(users);
        }
    }
}
