﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF_migration_dotnet1.Model
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Mobile { get; set; }
        public string City { get; set; }
    }

}
