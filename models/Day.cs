using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_end.models
{
    public class Day
    {
        public int? ProjectId {get; set;} // forms relationship in db thru entity framework

        public Project? Project {get; set;}
        public int Id { get; set; }
        public int TimeSpent { get; set; }
        public DateTime When {get; set; } = DateTime.Now;
        //Note an ORM turns a database into objects, entity framework is the ORM for .NET
    }
}