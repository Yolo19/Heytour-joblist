using JobApi.Model;
using JobApi.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApi.Service 
{
    public interface IJobService
    {
        Task<JobList[]> GetJobData();
    }
    public class JobService: IJobService
    {
        private readonly IJobRepo _JobRepo;
        public JobService(IJobRepo jobRepo)
        {
            _JobRepo = jobRepo;
        }

        public async Task<JobList[]> GetJobData()
        {
            var jobs = await Task.Run(()=> _JobRepo.GetJobData());
            return jobs;
        }
    }
}