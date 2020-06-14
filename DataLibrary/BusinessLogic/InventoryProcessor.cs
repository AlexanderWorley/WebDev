using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class InventoryProcessor
    {
        public static int CreateAsset(string manufacturer, string serialNumber,
            string macAddress, int assignedUser, string enteredAgent, string agentCheckOut)
        {
            InventoryModel data = new InventoryModel
            {
                Manufacturer = manufacturer,
                SerialNumber = serialNumber,
                MacAddress = macAddress,
                AssignedUser = assignedUser,
                EnteredAgent = enteredAgent,
                AgentCheckOut = agentCheckOut
            };
            // SQL write statement
            string sql = @"insert into dbo.Inventory (Manufacturer, SerialNumber, MacAddress, AssignedUser, EnteredAgent, AgentCheckOut)
                            values (@Manufacturer, @SerialNumber, @MacAddress, @AssignedUser, @EnteredAgent, @AgentCheckOut);";
            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<InventoryModel> LoadInventory()
            {
            string sql = @"select Id, Manufacturer, SerialNumber, MacAddress, AssignedUser, EnteredAgent, AgentCheckOut
                            from dbo.Inventory;";
            return SqlDataAccess.LoadData<InventoryModel>(sql);

        }
    }

}
