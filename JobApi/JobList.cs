using System;

namespace JobApi
{
    public class JobList
    {
        public int id { get; set; }
        public bool isActive { get; set; }
        public string title { get; set; }
        public string location { get; set; }
        public string industry { get; set; }
        public string picture { get; set; }
        public string company { get; set; }
        public string email { get; set; }
        public string jobDesc { get; set; }
        public DateTime postedOn { get; set; }
    }
}
