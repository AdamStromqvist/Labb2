﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOSU2_Test.EntetiesLayer
{

//Attributes for the entity Employee
    public class Employee
    {
        public int Id { get; set; }  // Unique employment identifier
        public string Username { get; set; } // Username to Employee
        public string NameEmployee { get; set; } // Name of the employee
        public string Profession { get; set; }   // Profession or job title
        public string Password { get; set; }    // Employee's password (for authentication)
        public string Specialization { get; set; } // Specialization (if applicable)
    }
}
