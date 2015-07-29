using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCDealershipProject.ViewModels
{
    public class InventoryGroup
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int VehicleCount { get; set; }
    }
}