using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApi.Model
{
    public class JobList
    {
        public int ID { get; set; }
        public bool IsActive { get; set; }
        public string Title { get; set; } 
        public string Location { get; set; }
        public string Industry { get; set; }
        public string Picture { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string JobDesc { get; set; }
        public DateTime PostedOn { get; set; }
    }
}