using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_end.DTOs
{
    public class NewDayDTO
    {
        public int? ProjectId {get; set;} // forms relationship in db thru entity framework

        public int Id { get; set; }
        public int TimeSpent { get; set; }
        public DateTime When {get; set; } = DateTime.Now;
    }
}