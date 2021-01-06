using JobApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JobApi.Repo 
{
    public interface IJobRepo
    {
        Task<IEnumerable<JobList>> GetJobs(JobFilter filter);
        Task<IEnumerable<JobList>> GetJobsByTitle(string title);
        Task<JobList> GetJob(int id);
        Task<JobList> CreateJob(JobList job);
        Task UpdateJob(JobList job);
        Task DeleteJob(int id);
    }

    public class JobRepo: IJobRepo
    {
        private readonly JobDbContext _jobDbContext;
        public JobRepo(JobDbContext jobDbContext) {
            _jobDbContext = jobDbContext;
        }

        public async Task<IEnumerable<JobList>> GetJobs(JobFilter filter)
        {
            var query =  _jobDbContext.JobList
                .Where(j => j.IsActive == filter.IsActive);

            if (filter.PostedOn != default)
            {
                query.Where(j => j.PostedOn > filter.PostedOn);
            }

            if (!string.IsNullOrWhiteSpace(filter.Title))
            {
                query.Where(j => j.Title.Contains(filter.Title));
            }

            var jobs = await query.ToListAsync();

            return jobs;
        }

        public async Task<IEnumerable<JobList>> GetJobsByTitle(string title)
        {
            var jobs = await _jobDbContext.JobList
                .Where(j => j.Title.Contains(title) && j.IsActive == true)
                .ToListAsync();

            return jobs;
        }

        public async Task<JobList> GetJob(int id)
        {
            var job = await _jobDbContext.JobList.FindAsync(id);

            return job;
        }
        public async Task<JobList> CreateJob(JobList job)
        {
            _jobDbContext.JobList.Add(job);
            
            await _jobDbContext.SaveChangesAsync();

            return job;
        }
        public async Task UpdateJob(JobList job)
        {
            _jobDbContext.Entry(job).State = EntityState.Modified;
            await _jobDbContext.SaveChangesAsync();
        }

        public async Task DeleteJob(int id)
        {
            var job = await GetJob(id);

            _jobDbContext.Remove(job);
            await _jobDbContext.SaveChangesAsync();
        }
    }
}