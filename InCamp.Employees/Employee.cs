using System;
using System.Collections.Generic;
using System.Text;

namespace InCamp.Employees
{
    public class Employee
    {
        public string Name { get; set; }
        public List<WorkTime> WorkTimes = new List<WorkTime>();
    }
}
