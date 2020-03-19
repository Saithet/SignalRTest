using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

using SignalRTest.Models;
using System.Data;

namespace SignalRTest
{
    public class ConnectHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
        public void UpdateList(string updateID)
        {
            Guid _updatedID = Guid.Parse(updateID);
            HSBCPSEntities _entities = new HSBCPSEntities();
            tbl_Program tblProgram = _entities.tbl_Program.Where(x => x.ID == _updatedID).Single();
            if (tblProgram.Active == true)
            {
                tblProgram.Active = false;
            }
            else
            {
                tblProgram.Active = true;
            }

            _entities.Entry(tblProgram).State = EntityState.Modified;
            _entities.SaveChanges();


            Clients.All.UpdateList();
        }
    }
}