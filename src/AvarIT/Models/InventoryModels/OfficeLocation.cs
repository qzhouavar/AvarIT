using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AvarIT.Models.InventoryModels
{
    public class OfficeLocation
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<ComputerCase> ComputerCases { get; set; }
    }
}
