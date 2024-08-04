using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_01.Models
{
    public class Storage
    {
        public static List<Driver> DriverList { get; set; } = new List<Driver>();
        public static List<Vehicle> VehicleList { get; set; } = new List<Vehicle>();
        public static List<Customer> CustomerList { get; set; } = new List<Customer>();

        // ------------------- Create -------------------------------

        public static Driver AddDriver()
        {
            var driver = Admin.CreateDriver();
            DriverList.Add(driver);
            return driver;
        }
        public static Customer AddCustomer()
        {
            var customer = Admin.CreateCustomer();
            CustomerList.Add(customer);
            return customer;
        }
        public static Vehicle AddVehicle()
        {
            int _id = VehicleList.Count()+1;
            var vehicle = Admin.CreateVehicle(_id);
            VehicleList.Add(vehicle);
            return vehicle;
        }

        // ------------------------ Show ---------------------
        public static void ShowAllDrivers()
        {
            DriverList.ForEach(d =>
            {
                d.ShowDriver();
            });
        }
        public static void ShowAllCustomers()
        {
            CustomerList.ForEach(c =>
            {
                c.ShowCostumer();
            });
        }
        public static void ShowAllVehicles()
        {
            VehicleList.ForEach(v =>
            {
                v.ShowVehicle();
            });
        }


        // ----------------------------- Clientes --------------------------

        // --------------- Filtros 
        public static void ShowCostumerGretaerThan30()
        {
            CustomerList.FindAll(c => c.GetAge() > 30)
            .ToList()
            .ForEach(c => c.ShowCostumer());
        }
        public static void ShowCostumerPreferCredit()
        {
            CustomerList.FindAll(c => c.PreferredPaymentMethod == "credit card")
            .ToList()
            .ForEach(c => c.ShowCostumer());
        }

        // ---------------- Crud
        public static void DeleteCostumer()
        {
            string documentNumber;
            do
            {
                Console.Write("Ingrese el numero de documento: ");
                documentNumber = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(documentNumber));

            if (CustomerList.Any(c => c.IdentificationNumberPublic == documentNumber))
            {
                var customer = CustomerList.Find(c => c.IdentificationNumberPublic == documentNumber);
                CustomerList.Remove(customer);
            }
            else
            {
                VisualInterfaces.ShowErrorFind("cliente");
            }

        }
        public static void UpdateCostumer()
        {
            string documentNumber;
            do
            {
                Console.Write("Ingrese el numero de documento: ");
                documentNumber = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(documentNumber));

            if (CustomerList.Any(c => c.IdentificationNumberPublic == documentNumber))
            {
                var customer = CustomerList.Find(c => c.IdentificationNumberPublic == documentNumber);
                int index = CustomerList.IndexOf(customer);

                var newCustomer = Admin.CreateCustomer();

                CustomerList[index] = newCustomer;
            }
            else
            {
                VisualInterfaces.ShowErrorFind("cliente");
            }
        }


        // ----------------------------- Conductores --------------------------

        // ---------- Filtros

        public static void ShowDriverGreaterThan30()
        {
            DriverList.FindAll(d => d.GetAge() > 30)
            .ToList()
            .ForEach(d => d.ShowDriver());
        }

        public static void ShowDriverByExperience()
        {
            DriverList.OrderByDescending(d => d.DrivingExperience)
            .ToList()
            .ForEach(d => d.ShowDriver());
        }

        public static void ShowDriversWithA2()
        {
            DriverList.FindAll(d => d.LicenseCategory == "A2")
            .ToList()
            .ForEach(d => d.ShowDriver());
        }

        // ------------ Crud

        public static void DeleteDriver()
        {
            string documentNumber;

            do
            {
                Console.Write("Ingrese el numero de documento: ");
                documentNumber = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(documentNumber));

            if (DriverList.Any(d => d.IdentificationNumberPublic == documentNumber))
            {
                var driver = DriverList.Find(d => d.IdentificationNumberPublic == documentNumber);

                DriverList.Remove(driver);
            }
            else
            {
                VisualInterfaces.ShowErrorFind("conductor");
            }
        }

        public static void UpdateDriver()
        {
            string documentNumber;
            do
            {
                Console.Write("Ingrese el numero de documento: ");
                documentNumber = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(documentNumber));

            if (DriverList.Any(d => d.IdentificationNumberPublic == documentNumber)){
                var driver = DriverList.Find(d => d.IdentificationNumberPublic == documentNumber);
                int index = DriverList.IndexOf(driver);

                var newDriver = Admin.CreateDriver();

                DriverList[index] = newDriver;
            } else {
                VisualInterfaces.ShowErrorFind("conductor");
            }
        }

        // ---------------------------- Vehiculos ----------------------

        public static void DeleteVehicle(){
            var vehicleInstance = VehicleList.First();
            int idDelete = Settings.ValInt("Ingrese el id del vehiculo a eliminar: ");
            vehicleInstance.DeleteVehicle(idDelete);
        }
    }
}