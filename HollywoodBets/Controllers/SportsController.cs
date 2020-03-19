using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HollywoodBets.Models;
using Microsoft.AspNetCore.Mvc;

namespace HollywoodBets.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SportsController : Controller
    {
        public static List<SportsTree> SportsList = Sports();
        public static List<SportsTree> Sports()
        {
            SportsList = new List<SportsTree>
            {
                new SportsTree(1, "Betgames Africa", "https://new.hollywoodbets.net/assets/images/icons/Betgames.svg"),
                new SportsTree(2, "Live In-Play","https://new.hollywoodbets.net/assets/images/icons/live-in-play.svg"),
                new SportsTree(3, "Sport Exotics","https://new.hollywoodbets.net/assets/images/icons/sport-exotics.svg")
            };
            return SportsList;
        }

        [HttpGet]
        public IEnumerable<SportsTree> Get()
        {
  
            return Sports().ToArray();
        }
       
    }
}