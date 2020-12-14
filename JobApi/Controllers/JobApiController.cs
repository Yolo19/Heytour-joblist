using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using JobApi;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using JobApi.Model;
using JobApi.Service;
using System.Threading.Tasks;

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
            // return jobs.ToList();
        }
    }
}