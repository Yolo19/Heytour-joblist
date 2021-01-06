using JobApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsAPI.Service
{
    public class JobResponse
    {
        public bool Success { get; private set; }
        public string Message { get; private set; }
        public JobList Job { get; private set; }

        private JobResponse(bool success, string message, JobList job)
        {
            Job = job;
            Success = success;
            Message = message;
        }

        public JobResponse(JobList job) : this(true, string.Empty, job) { }

        public JobResponse(string message) : this(false, message, null) { }
    }
}