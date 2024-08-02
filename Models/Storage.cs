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

        public static Driver AddDriver(){
            var driver = Admin.CreateDriver();
            DriverList.Add(driver);
            return driver;
        }
        public static Customer AddCustomer(){
            var customer = Admin.CreateCustomer();
            CustomerList.Add(customer);
            return customer;
        }
    }
}