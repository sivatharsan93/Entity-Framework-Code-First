﻿using System.ComponentModel.DataAnnotations;

namespace StudentDatabaseApp
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
