using JobApi.Model;
using JobApi.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Docs.Samples;
using System.IO;
using JobApi;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace JobApi.Service 
{
    public interface IJobService
    {
        Task<IEnumerable<JobList>> GetJobs(JobFilter filter);
        Task<JobList> GetJob(int id);
        Task<JobList> CreateJob(JobList job);
        Task UpdateJob(int id, JobList job);
        Task DeleteJob(int id);
    }

    public class JobService: IJobService
    {
        private readonly IJobRepo _jobRepo;
        public JobService(IJobRepo jobRepo)
        {
            _jobRepo = jobRepo;
        }

        public async Task<IEnumerable<JobList>> GetJobs(JobFilter filter)
        {

            var jobs = await _jobRepo.GetJobs(filter);

            return jobs;
        }

        public async Task<JobList> GetJob(int id)
        {
            var job = await _jobRepo.GetJob(id);
            return job;
        }

        public async Task<JobList> CreateJob(JobList job)
        {
            var res = await _jobRepo.CreateJob(job);
            return res;
        }

        public async Task UpdateJob(int id, JobList job)
        {
            job.ID = id;
            await _jobRepo.UpdateJob(job);
        }

        public async Task DeleteJob(int id)
        {
            await _jobRepo.DeleteJob(id);
        }
        
    }
}