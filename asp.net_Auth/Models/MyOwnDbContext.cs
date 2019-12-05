using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace asp.net_Auth.Models
{
    public class MyOwnDbContext : DbContext
    {

        //enable-migrations -contexttypeName asp.net_Auth.Models.MyOwnDbContext -MigrationsDirectory MigrationsOwn добавляем пусть как миграции другого котекста
        public virtual DbSet<Bike> Bikes { get; set; }
        public virtual DbSet<Asdfs> Asdasf { get; set; }
        public MyOwnDbContext() : base("DefaultConnection")
        {

        }
    }
}