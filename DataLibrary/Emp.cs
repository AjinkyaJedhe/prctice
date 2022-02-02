using System;

namespace DataLibrary
{
    //Entity class - represent table
    public class Emp
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public DateTime? HireDate { get; set; }
        public decimal? Salary { get; set; }
    }
}

