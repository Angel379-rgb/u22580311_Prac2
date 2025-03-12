using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u22580311_Prac2.Models;

namespace u22580311_Prac2.Controllers
{
    public class PeopleController:Controller
    {
        public ActionResult List()
        {
            var people = new List<People>
    {
        new People { StudentNumber = "u22580311", Name = "Angel", Surname = "Luthuli", Email = "u22580311@tuks.co.za", MyLink = "~/HTML/Angel.html" },
        new People { StudentNumber = "u2358732", Name = "Kamoghelo", Surname = "Morare", Email = "u2358732@tuks.co.za", MyLink = "~/HTML/Kamoghelo.html" },
        new People { StudentNumber = "u2412589", Name = "Kananelo", Surname = "Matighe", Email = "u2412589@tuks.co.za", MyLink = "~/HTML/Kananelo.html" },
        new People { StudentNumber = "u22781230", Name = "Nolubabalo", Surname = "Simkana", Email = "u22781230@tuks.co.za", MyLink = "~/HTML/Nolubabalo.html" },
        new People { StudentNumber = "u2368790", Name = "Richard", Surname = "Iyke", Email = "u2368790@tuks.co.za", MyLink = "~/HTML/Richard.html" }
    };

            return View(people);
        }
    }
}