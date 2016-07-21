using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace AvarIT.Models.InventoryModels
{
    public class Employee
    {
        
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }

        public virtual List<ComputerCase> ComputerCases { get; set; }
    }
}
