using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace AvarIT.Models.InventoryModels
{
    public class OperationSystem
    {   [Key]
        public int OSId { get; set; }
        public string OSName { get; set; }
        public virtual List<ComputerCase> ComputerCases { get; set; }
    }
}
