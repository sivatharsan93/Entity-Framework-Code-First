﻿using System.Data.Entity;

namespace StudentDatabaseApp
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
