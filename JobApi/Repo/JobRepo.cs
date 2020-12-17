using JobApi.Model;
using JobApi.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace JobApi.Repo 
{
    public interface IJobRepo
    {
        JobList[] GetJobData();
    }

    public class JobRepo: IJobRepo
    {
        public JobRepo() {}

        public JobList[] GetJobData()
        {
            StreamReader sr = System.IO.File.OpenText("data.json");
            string jsonWordTemplate = sr.ReadToEnd();
            var data = JsonConvert.DeserializeObject<JobList[]>(jsonWordTemplate);
            return data;
        }
    }
}