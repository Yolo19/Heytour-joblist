using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using JobApi;
using JobApi.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using JobApi.Model;
using JobApi.Service;
using System.Threading.Tasks;
using Microsoft.Docs.Samples;




namespace JobApi.Controllers
{
    [ApiController]
    [Route("api/jobs")]
    public class JobController : ControllerBase
    {

        private readonly IJobService _jobService;

        public JobController(IJobService jobService)
        {
           _jobService = jobService;
        }
        

        [HttpGet]
        public async Task<JobList[]> GetJobData()
        {
            var jobs = await _jobService.GetJobData();
            return jobs;
        }

        [HttpGet("IsActive")]
         public  List<JobList> GetJobByIsActive(bool isActive)
        {
            var data =  _jobService.GetJobByIsActive(isActive);
            return data;
        }
        [HttpGet("PostedOn")]
         public  List<JobList> GetJobByPostedOn(DateTime postedOn)
        {
            var data =  _jobService.GetJobByPostedOn(postedOn);
            return data;
        }
        
        
        [HttpGet("{id=1}")]
        public List<JobList> GetJobDataById(int id)
        {
            var data =  _jobService.GetJobDataById(id);
            return data;
        }
    }
}