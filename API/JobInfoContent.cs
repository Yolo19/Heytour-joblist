using Microsoft.EntityFrameworkCore;

namespace JobApi.Models
{
    public class JobInfoContent : DbContext
    {
        public JobInfoContent(DbContextOptions<JobInfoContent> options)
            : base(options)
        {
        }

        public DbSet<JobInfoItem> JobInfoItems { get; set; }
    }
}