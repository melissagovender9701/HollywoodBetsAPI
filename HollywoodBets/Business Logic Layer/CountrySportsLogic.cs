using HollywoodBets.DataAccessLayer;
using HollywoodBets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HollywoodBets.Business_Logic_Layer
{
    public class CountrySportsLogic
    {
        public static List<SportsTree> SportsList { get; set; }
        public static List<CountryTree> CounrtyList { get; set; }
        public static List<CountrySportsTree> CountrySportsList { get; set; }

        public CountrySportsLogic()
        {
            this.Sports();
            this.Countries();
            CountrySports();
        }

        public List<SportsTree> Sports()
        {
            SportsList = new List<SportsTree>
            {
                new SportsTree(1, "Betgames Africa", "https://new.hollywoodbets.net/assets/images/icons/Betgames.svg"),
                new SportsTree(2, "Live In-Play","https://new.hollywoodbets.net/assets/images/icons/live-in-play.svg"),
                new SportsTree(3, "Sport Exotics","https://new.hollywoodbets.net/assets/images/icons/sport-exotics.svg"),
                new SportsTree(4, "Horse Racing","https://new.hollywoodbets.net/assets/images/icons/horse-racing.svg"),
                new SportsTree(5, "Soccer","https://new.hollywoodbets.net/assets/images/icons/soccer.svg"),
                new SportsTree(6, "Lucky Numbers","https://new.hollywoodbets.net/assets/images/icons/lucky-numbers.svg"),
                new SportsTree(7, "Tennis","https://new.hollywoodbets.net/assets/images/icons/tennis.svg"),
                new SportsTree(8, "Rugby","https://new.hollywoodbets.net/assets/images/icons/rugby.svg"),
                new SportsTree(9, "Cricket","https://new.hollywoodbets.net/assets/images/icons/cricket.svg"),
                new SportsTree(10, "Golf","https://new.hollywoodbets.net/assets/images/icons/golf.svg"),
                new SportsTree(11, "American Football","https://new.hollywoodbets.net/assets/images/icons/american-football.svg"),
                new SportsTree(12, "Aussie Rules","https://new.hollywoodbets.net/assets/images/icons/aussie-rules.svg"),
                new SportsTree(13, "Badminton","https://new.hollywoodbets.net/assets/images/icons/badminton.svg"),
                new SportsTree(14, "Bandy","https://new.hollywoodbets.net/assets/images/icons/bandy.svg"),
                new SportsTree(15, "Baseball","https://new.hollywoodbets.net/assets/images/icons/baseball.svg"),
                new SportsTree(16, "Basketball","https://new.hollywoodbets.net/assets/images/icons/basketball.svg"),
                new SportsTree(17, "Boxing","https://new.hollywoodbets.net/assets/images/icons/boxing.svg"),
                new SportsTree(18, "Cycling","https://new.hollywoodbets.net/assets/images/icons/cycling.svg"),
                new SportsTree(19, "Darts","https://new.hollywoodbets.net/assets/images/icons/darts.svg"),
                new SportsTree(20, "Floorball","https://new.hollywoodbets.net/assets/images/icons/floorball.svg"),
                new SportsTree(21, "Futsal","https://new.hollywoodbets.net/assets/images/icons/futsal.svg"),
                new SportsTree(22, "Handball","https://new.hollywoodbets.net/assets/images/icons/handball.svg"),
                new SportsTree(23, "Ice Hockey","https://new.hollywoodbets.net/assets/images/icons/ice-hockey.svg"),
                new SportsTree(24, "MMA","https://new.hollywoodbets.net/assets/images/icons/mma.svg"),
                new SportsTree(25, "Motorsport","https://new.hollywoodbets.net/assets/images/icons/motorsport.svg"),
                new SportsTree(26, "Netball","https://new.hollywoodbets.net/assets/images/icons/soccer.svg"),
                new SportsTree(27, "Snooker","https://new.hollywoodbets.net/assets/images/icons/snooker.svg"),
                new SportsTree(28, "Squash","https://new.hollywoodbets.net/assets/images/icons/snooker.svg"),
                new SportsTree(29, "Volleyball","https://new.hollywoodbets.net/assets/images/icons/volleyball.svg")
            };
            return SportsList;
        }

        public List<CountryTree> Countries()
        {
            CounrtyList = new List<CountryTree>
            {
             new CountryTree(1, "Afghanistan", "https://cdn.countryflags.com/thumbs/afghanistan/flag-400.png"),
             new CountryTree(2, "Albania", "https://cdn.countryflags.com/thumbs/albania/flag-400.png"),
             new CountryTree(3, "Algeria", "https://cdn.countryflags.com/thumbs/algeria/flag-400.png"),
             new CountryTree(5, "Andorra", "https://cdn.countryflags.com/thumbs/andorra/flag-400.png"),
             new CountryTree(6, "Angola", "https://cdn.countryflags.com/thumbs/angola/flag-400.png"),
             new CountryTree(7, "Antigua and Barbuda", "https://cdn.countryflags.com/thumbs/antigua-and-barbuda/flag-400.png"),
             new CountryTree(8, "Argentina", "https://cdn.countryflags.com/thumbs/argentina/flag-400.png"),
             new CountryTree(9, "Armenia", "https://cdn.countryflags.com/thumbs/armenia/flag-400.png"),
             new CountryTree(10, "Australia", "https://cdn.countryflags.com/thumbs/australia/flag-400.png"),
             new CountryTree(11, "Austria", "https://cdn.countryflags.com/thumbs/austria/flag-400.png"),
             new CountryTree(12, "Azerbaijan", "https://cdn.countryflags.com/thumbs/azerbaijan/flag-400.png"),
             new CountryTree(13, "Bahamas", "https://cdn.countryflags.com/thumbs/bahamas/flag-400.png"),
             new CountryTree(14, "Bahrain", "https://cdn.countryflags.com/thumbs/bahrain/flag-400.png")
            };
            return CounrtyList;
        }

        public static List<CountrySportsTree> CountrySports()
        {
            CountrySportsList = new List<CountrySportsTree>
            {
                new CountrySportsTree(5, 1),
                new CountrySportsTree(5, 2),
                new CountrySportsTree(5, 3),
            };
            return CountrySportsList;
        }

        public static CountryTree GetCountryByID(long id)
        {
            for(int i =0; i < CountrySportsLogic.CounrtyList.Count; i++)
            {
                if(CounrtyList[i].id == id)
                {
                    return CounrtyList[i];
                }
            }
            return new CountryTree();
        }
    }
}
