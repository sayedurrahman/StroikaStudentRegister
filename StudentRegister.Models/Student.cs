﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentRegister.Models.BaseModels;

namespace StudentRegister.Models
{
    public class Student : Person
    {
        public DateTime DateOfBirth { get; set; }
    }
}
