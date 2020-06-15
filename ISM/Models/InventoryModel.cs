using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
// This model is the front end model used to pass parameters to the asset addition form. This model is NOT the same as the other InventoryModel for the back end under DataLibrary.
namespace ISM.Models
{
    public class InventoryModel
    {
        [Display(Name = "Manufacturer")]
        [Required(ErrorMessage = "Enter a manufacturer")]
        public string Manufacturer{ get; set;}
        [Display(Name = "Serial Number")]
        public string SerialNumber { get; set; }
        
        [StringLength(17, MinimumLength = 17, ErrorMessage = "17 characters required for MAC Address")]
        [Display(Name = "Mac Address")]
        public string MacAddress { get; set; }
        [Display(Name = "Assigned User")]
        [Range(100000,999999, ErrorMessage = "Enter a valid Employee ID")]
        [Required(ErrorMessage = "Enter the Employee ID")]
        public int AssignedUser { get; set; }
        [Display(Name = "Agent Entered")]
        
        public string EnteredAgent { get; set; }
        [Display(Name = "Agent Check Out Authorization")]
        public string AgentCheckOut { get; set; }

    }
}