using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_01.Models
{
    public class Storage
    {
        public static List<Driver> DriverList {get; set;} = new List<Driver>();
        public static List<Vehicle> VehicleList {get; set;} = new List<Vehicle>();
        public static List<Customer> CustomerList {get; set;} = new List<Customer>();
    }
}