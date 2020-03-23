using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HollywoodBets.Models;
using Microsoft.AspNetCore.Mvc;
using HollywoodBets.Business_Logic_Layer;
namespace HollywoodBets.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SportsController : Controller
    {
        [HttpGet]
        public IEnumerable<SportsTree> Get()
        {
            var sports = new DataLogic();
            return sports.Sports().ToArray();
        }
    }
}