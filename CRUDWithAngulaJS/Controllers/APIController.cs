using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUDWithAngulaJS.Controllers
{
    public class APIController : ApiController
    {
        [HttpGet]
        public object GetTradeList()
        {
            var tradArray = new[] {
                                    new { name = "Trade 1", id = 1 },
                                    new { name = "Trade 2", id = 2 },
                                    new { name = "Trade 3", id = 3 }
                                  };
            return Json(tradArray.ToList());
        }
        [HttpGet]
        public object GetLevelList()
        {
            var levelArray = new[] {
                                    new { name = "Level 1", id = 1 ,tradId=1},
                                    new { name = "Level 2", id = 2 ,tradId=1},
                                    new { name = "Level 3", id = 3 ,tradId=1},
                                    new { name = "Level 1", id = 1 ,tradId=2},
                                    new { name = "Level 2", id = 2 ,tradId=2},
                                    new { name = "Level 3", id = 3 ,tradId=3},
                                    new { name = "Level 4", id = 4 ,tradId=3}
                                  };
            return Json(levelArray.ToList());
        }
    }
}
