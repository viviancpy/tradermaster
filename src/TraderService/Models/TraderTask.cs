using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TraderService.Models
{
    public sealed class TraderTask
    {
        public int TaskId { get; set; }
        public int RequestMemberId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}