using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TraderService.Models;

namespace TraderService.Controllers
{
    public class TraderTaskController : ApiController
    {
        [Route("/api/tasks/all")]
        [HttpGet]
        public async IEnumerable<TraderTask> GetAllTraderTasks() { 
            return await 
        }
    }
}
