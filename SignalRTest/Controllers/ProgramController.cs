using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SignalRTest.Models;
using Newtonsoft.Json;

namespace SignalRTest.Controllers
{
    public class ProgramController : Controller
    {
        // GET: Program
        public ActionResult Index()
        {
            return View();
        }

        // GET: Program
        
        public ActionResult GetList()
        {
            HSBCPSEntities _entities = new HSBCPSEntities();

            IList<tbl_Program> tblProgramList = _entities.tbl_Program.OrderBy(x=>x.Name).ToList();

            string jsonResult = JsonConvert.SerializeObject(tblProgramList);

            DataTableResponse aa = new DataTableResponse
            {
                recordsTotal = tblProgramList.Count(),
                recordsFiltered = 10,
                data = tblProgramList.Take(10).ToArray()
            };

            return Json(aa, JsonRequestBehavior.AllowGet);
        }


        public class DataTableResponse
        {
            public int draw { get; set; }
            public long recordsTotal { get; set; }
            public int recordsFiltered { get; set; }
            public object[] data { get; set; }
            public string error { get; set; }
        }
    }
}