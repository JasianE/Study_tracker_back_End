using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_end.models
{
    //One to many model here
    // Project will hold multiple "days" 
    // these "days" will store the amount of time studied for that "day
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Day> Days {get; set;} = new List<Day>();

    }
}