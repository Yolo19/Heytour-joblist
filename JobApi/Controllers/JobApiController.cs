using System;
using System.Collections.Generic;
using System.Linq;
using JobApi;
using JobApi.Repo;
using Microsoft.AspNetCore.Mvc;
using JobApi.Model;
using JobApi.Service;
using System.Threading.Tasks;





namespace JobApi.Controllers
{
    [ApiController]
    [Route("api/jobs")]
    public class JobController : Controller
    {

        private readonly IJobService _jobService;
        public JobController(
            IJobService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet]
         public async Task<ActionResult<IEnumerable<JobList>>> GetJobs()
        {
            _ = DateTime.TryParse(HttpContext.Request.Query["postedon"].ToString(), out DateTime postedOn);

            var filter = new JobFilter
            {
                IsActive = HttpContext.Request.Query["isactive"].ToString() == "true",
                PostedOn = postedOn,
                Title = HttpContext.Request.Query["title"].ToString()
            };
                
            var jobs = await _jobService.GetJobs(filter);

            return jobs.ToList();
        }
        

        [HttpGet]
        [Route("{id}")]

        public async Task<ActionResult<JobList>> GetJob(int id)
        {
            var job = await _jobService.GetJob(id);

            return job;
        }

        [HttpPost]

        public async Task<ActionResult<JobList>> PostJob(JobList job)
        {
            var res = await _jobService.CreateJob(job);

            return res;
        }
        
        [HttpPut]
        [Route("{id}")]

        public async Task<ActionResult> PutJob(int id, JobList job)
        {
            await _jobService.UpdateJob(id, job);

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]

        public async Task<ActionResult> DeleteJob(int id)
        {
            await _jobService.DeleteJob(id);

            return NoContent();
        }
    }
}