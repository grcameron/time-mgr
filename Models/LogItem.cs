using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace time_mgr.Models
{
    public class LogItemContext : DbContext
    {
        public DbSet<LogItem> LogItems { get; set; }        

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Data Source=blogging.db");
    }

    public class LogItem
    {
        public int Id { get; set; }        
    }
}