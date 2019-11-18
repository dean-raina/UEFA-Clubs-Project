using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ClubPortal.Models;

namespace ClubPortal.DAL
{
    public class ClubInitialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<ClubContext>
    {
        protected override void Seed(ClubContext context)
        {
            var clubs = new List<Club>
            {
                new Club{ID=2610,Name="Olympiacos",Country="Greece",Eliminated=true,ImgURL="http://img.uefa.com/imgml/TP/teams/logos/70x70/52919.png",ClubURL = "https://www.uefa.com/teamsandplayers/teams/club=52919/profile/index.html"},
                new Club{ID=7889,Name="Liverpool",Country="England",Eliminated=true},
                new Club{ID=50004,Name="Grasshoppers",Country="Switzerland",Eliminated=true},
                new Club{ID=50023,Name="Monaco",Country="France",Eliminated=false},
                new Club{ID=50030,Name="Salzburg",Country="Austria",Eliminated=true},
                new Club{ID=50033,Name="Sparta Praha",Country="Czech Republic",Eliminated=true},
                new Club{ID=50037,Name="Bayern",Country="Germany",Eliminated=false},
                new Club{ID=50050,Name="Celtic",Country="Scotland",Eliminated=true},
                new Club{ID=50051,Name="Real Madrid",Country="Spain",Eliminated=false},
                new Club{ID=50052,Name="HJK",Country="Finland",Eliminated=true},
                new Club{ID=50064,Name="Porto",Country="Portugal",Eliminated=false},
                new Club{ID=50065,Name="Steaua",Country="Romania",Eliminated=true},
                new Club{ID=50067,Name="Galatasaray",Country="Turkey",Eliminated=true},
                new Club{ID=50074,Name="Anderlecht",Country="Belgium",Eliminated=true},
                new Club{ID=50080,Name="Barcelona",Country="Spain",Eliminated=false},
                new Club{ID=50084,Name="Panathinaikos",Country="Greece",Eliminated=true},
                new Club{ID=50109,Name="Leverkusen",Country="Germany",Eliminated=false},
                new Club{ID=50118,Name="APOEL",Country="Cyprus",Eliminated=true},
                new Club{ID=50124,Name="Atlético",Country="Spain",Eliminated=false},
                new Club{ID=50125,Name="Athletic",Country="Spain",Eliminated=true},
                new Club{ID=50133,Name="St Patrick's",Country="Republic of Ireland",Eliminated=true},
                new Club{ID=50136,Name="Napoli",Country="Italy",Eliminated=true},
                new Club{ID=50137,Name="Roma",Country="Italy",Eliminated=true},
                new Club{ID=50139,Name="Juventus",Country="Italy",Eliminated=false},
                new Club{ID=50143,Name="Ajax",Country="Netherlands",Eliminated=true},
                new Club{ID=50146,Name="Legia",Country="Poland",Eliminated=true},
                new Club{ID=50147,Name="Benfica",Country="Portugal",Eliminated=true},
                new Club{ID=50149,Name="Sporting",Country="Portugal",Eliminated=true},
                new Club{ID=50152,Name="Malmö",Country="Sweden",Eliminated=true},
                new Club{ID=50157,Name="Beşiktaş",Country="Turkey",Eliminated=true},
                new Club{ID=50158,Name="Dnipro",Country="Ukraine",Eliminated=true},
                new Club{ID=50162,Name="Partizan",Country="Serbia",Eliminated=true},
                new Club{ID=50164,Name="Dinamo Zagreb",Country="Croatia",Eliminated=true},
                new Club{ID=52165,Name="Standard Liège",Country="Belgium",Eliminated=true},
                new Club{ID=52280,Name="Arsenal",Country="England",Eliminated=false},
                new Club{ID=52307,Name="KR",Country="Iceland",Eliminated=true},
                new Club{ID=52641,Name="Valletta",Country="Malta",Eliminated=true},
                new Club{ID=52705,Name="Dinamo Tbilisi",Country="Georgia",Eliminated=true},
                new Club{ID=52707,Name="Shakhtar Donetsk",Country="Ukraine",Eliminated=false},
                new Club{ID=52709,Name="København",Country="Denmark",Eliminated=true},
                new Club{ID=52747,Name="Paris",Country="France",Eliminated=false},
                new Club{ID=52749,Name="Feyenoord",Country="Netherlands",Eliminated=true},
                new Club{ID=52758,Name="Dortmund",Country="Germany",Eliminated=false},
                new Club{ID=52797,Name="Slovan Bratislava",Country="Slovakia",Eliminated=true},
                new Club{ID=52800,Name="AEL",Country="Cyprus",Eliminated=true},
                new Club{ID=52826,Name="Zenit",Country="Russia",Eliminated=true},
                new Club{ID=52914,Name="Chelsea",Country="England",Eliminated=false},
                new Club{ID=52919,Name="Man. City",Country="England",Eliminated=false},
                new Club{ID=52958,Name="Debrecen",Country="Hungary",Eliminated=true},
                new Club{ID=52991,Name="Cliftonville",Country="Northern Ireland",Eliminated=true},
                new Club{ID=54186,Name="AaB",Country="Denmark",Eliminated=true},
                new Club{ID=54266,Name="CSKA Moskva",Country="Russia",Eliminated=true},
                new Club{ID=57388,Name="Schalke",Country="Germany",Eliminated=false},
                new Club{ID=57477,Name="M. Tel-Aviv",Country="Israel",Eliminated=true},
                new Club{ID=57485,Name="Strømsgodset",Country="Norway",Eliminated=true},
                new Club{ID=57490,Name="Maribor",Country="Slovenia",Eliminated=true},
                new Club{ID=59025,Name="HB",Country="Faroe Islands",Eliminated=true},
                new Club{ID=59028,Name="Dudelange",Country="Luxembourg",Eliminated=true},
                new Club{ID=59856,Name="Basel",Country="Switzerland",Eliminated=false},
                new Club{ID=60457,Name="TNS",Country="Wales",Eliminated=true},
                new Club{ID=60609,Name="Qarabağ",Country="Azerbaijan",Eliminated=true},
                new Club{ID=62180,Name="FC Santa Coloma",Country="Andorra",Eliminated=true},
                new Club{ID=64114,Name="Skënderbeu",Country="Albania",Eliminated=true},
                new Club{ID=64359,Name="Ventspils",Country="Latvia",Eliminated=true},
                new Club{ID=64508,Name="La Fiorita",Country="San Marino",Eliminated=true},
                new Club{ID=66168,Name="BATE",Country="Belarus",Eliminated=true},
                new Club{ID=69601,Name="Rabotnicki",Country="FYR Macedonia",Eliminated=true},
                new Club{ID=69606,Name="Sheriff",Country="Moldova",Eliminated=true},
                new Club{ID=73390,Name="Zrinjski",Country="Bosnia and Herzegovina",Eliminated=true},
                new Club{ID=73936,Name="Sutjeska",Country="Montenegro",Eliminated=true},
                new Club{ID=75797,Name="LOSC",Country="France",Eliminated=true},
                new Club{ID=77482,Name="Levadia",Country="Estonia",Eliminated=true},
                new Club{ID=77866,Name="Banants",Country="Armenia",Eliminated=true},
                new Club{ID=79973,Name="Aktobe",Country="Kazakhstan",Eliminated=true},
                new Club{ID=2602334,Name="Žalgiris",Country="Lithuania",Eliminated=true},
                new Club{ID=2603104,Name="Ludogorets",Country="Bulgaria",Eliminated=true},
                new Club{ID=2605572,Name="Lincoln",Country="Gibraltar",Eliminated=true}
            };

            clubs.ForEach(s => context.Clubs.Add(s));
            context.SaveChanges();
        }
    }
}