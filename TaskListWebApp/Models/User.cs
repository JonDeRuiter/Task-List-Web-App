using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TaskListWebApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }

    public class DbUser : DbContext
    {
        //DbSet<User> Users { get; set; }

        public System.Data.Entity.DbSet<TaskListWebApp.Models.User> Users { get; set; }
    }
}