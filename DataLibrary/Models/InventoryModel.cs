using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This model is used to connect from Front end to Back end, and is not the same as the Inventory Model on the front end. 
namespace DataLibrary.Models
{
    public class InventoryModel
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string SerialNumber { get; set; }
        public string MacAddress { get; set; }
        public int AssignedUser { get; set; }
        public string EnteredAgent { get; set; }
        public string AgentCheckOut { get; set; }
    }
}
