using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvarIT.Models.InventoryModels
{
    public class ComputerCase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Avar Tag Number")]
        public int ID { get; set; }


        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        public int BrandId { get; set; }
        [ForeignKey("BrandId")]
        public virtual Brand Brand { get; set; }


        [Display(Name = "Machine Name")]
        public string MachineName { get; set; }

        [Display(Name = "Office Location")]
        public string OfficeLocation{ get; set; }

        [Display(Name = "Serial Number")]
        public string SerialNumber { get; set; }

        [Display(Name = "Model Series")]
        public string ModelSeries { get; set; }

        [Display(Name = "Model No")]
        public string ModelNo { get; set; }

        [Display(Name = "Screen Size (Laptop)")]
        public string LaptopScreenSize { get; set; }

        [Display(Name = "CPU Type")]
        public string CPUType { get; set; }

        [Display(Name = "CPU Frequency")]
        public string CPUFrequency { get; set; }

        [Display(Name = "Memory size")]
        public string MemorySize { get; set; }

        [Display(Name = "HDD size")]
        public string HDDSize { get; set; }

        [Display(Name = "OEM Operating System")]
        public string OEMOperatingSystem { get; set; }
     

        [Display(Name = "OEM License")]
        public string OEMLicense { get; set; }

        [Display(Name = "Upgraded To")]
        public string UpgradedTo{ get; set; }

        [Display(Name = "Upgrade License")]
        public string UpgradeLicense { get; set; }

        [Display(Name = "LAN MAC")]
        public string LANMAC { get; set; }

        [Display(Name = "WLAN MAC")]
        public string WLANMAC { get; set; }

        [Display(Name = "Order No")]
        public string OrderNo{ get; set; }


        [Display(Name = "Purchase Date")]
        [DataType(DataType.Date)]
        public DateTime? PurchaseDate  { get; set; }

        public string Warranty { get; set; }

        [DataType(DataType.Currency)]
        public decimal? Cost { get; set; }

        [DataType(DataType.MultilineText)]
        public string Note { get; set; }

      
        public bool Retired { get; set; }

    }
}
