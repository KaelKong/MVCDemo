﻿using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MyDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<UserConfig> UserConfig { get; set; }

        public MyDbContext() : base("DefaultConnection")
        {

        }
    }
}
