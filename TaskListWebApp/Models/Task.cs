using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TaskListWebApp.Models
{
    public class Task
    {
        
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool Completed { get; set; }

    }
    public class DbTask : DbContext
    {
        //DbSet<Task> Tasks { get; set; }

        public System.Data.Entity.DbSet<TaskListWebApp.Models.Task> Tasks { get; set; }
    }
}