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
        Task<JobList[]> GetJobData();
        public List<JobList> GetJobDataById(int id);
        // public List<JobList> GetJobs(bool? isActive, DateTime postedOn);
        public List<JobList> GetJobByIsActive(bool isActive);
        public List<JobList> GetJobByPostedOn(DateTime postedOn);
       
    
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


        public List<JobList> GetJobDataById(int id)
        {
            var data =  _JobRepo.GetJobData();
            var result = data.Where(x => x.ID == id).ToList();
            return result;
        }   

        // public  List<JobList> GetJobs([FromQuery]bool? isActive, [FromQuery]DateTime postedOn) 
        // {
        //     var result =  _JobRepo.GetJobData();
        //     var data =  _JobRepo.GetJobData().ToList();
        //     // var data = result.Where(x=>x.IsActive == isActive || x.PostedOn == postedOn).ToList();
        //     if (isActive!=null)
                
        //         { 
        //             var result1 = result.Where(x => x.IsActive == isActive).ToList();
        //             return result1; 
        //         }
                
        //     if (postedOn!=null)
        //         {
        //             var result2 = result.Where(x => x.PostedOn == postedOn).ToList();
        //             return  result2;
        //         }
        //     return data;
        // }
        public  List<JobList> GetJobByIsActive([FromQuery]bool isActive) 
        {
            var result =  _JobRepo.GetJobData();
            var data = result.Where(x=>x.IsActive == isActive).ToList();
            return data;
        }
        public  List<JobList> GetJobByPostedOn([FromQuery]DateTime postedOn) 
        {
            var result =  _JobRepo.GetJobData();
            var data = result.Where(x=>x.PostedOn == postedOn).ToList();
            return data;
        }
    }
}