﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkCoreExample
{
    public class Student
    {
        [Key] // tell EF Core to make this primary key
        public int Id { get; set; }

        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string EmailAddress { get; set; }
    }
}
