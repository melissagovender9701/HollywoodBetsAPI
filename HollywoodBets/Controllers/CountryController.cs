using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HollywoodBets.Business_Logic_Layer;
using HollywoodBets.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HollywoodBets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : Controller
    {
        [HttpGet]
        public IEnumerable<CountryTree> Get(int? id)
        {
            return GetCountryBySport(id).ToArray();
        }
        private List<CountryTree> GetCountryBySport(int? sportId)
        {
            List<CountryTree> countries = new List<CountryTree>();

            foreach(var list in CountrySportsLogic.CountrySportsList)
            {
                if(list.sportsId == sportId)
                {
                    countries.Add(CountrySportsLogic.GetCountryByID(list.countryId));
                }
            }

            return countries;
        }
    }
}