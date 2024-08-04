using Simulacro_01.Models;
Console.Clear();

// Agregar Conductor
Storage.DriverList.Add(new Driver("Juan", "Estrada", "sa", "1", new DateOnly(2000, 1, 10), "sda", "sad", "sad", "asd", "B2", 12));
Storage.DriverList.Add(new Driver("Andres", "Naranjo", "CC", "2", new DateOnly(2007, 2, 9), "sda", "sad", "sad", "asd", "b2", 12));
Storage.DriverList.Add(new Driver("Leison", "Mosquera", "TI", "3", new DateOnly(1998, 8, 1), "sda", "sad", "sad", "asd", "a2", 12));
Storage.DriverList.Add(new Driver("Andres", "Cano", "Pass", "4", new DateOnly(2002, 1, 30), "sda", "sad", "sad", "asd", "a2", 12));


// Agregar vehiculo

Storage.VehicleList.Add(new Vehicle(2, "23D", "moto", "2123", "12332", 2, new Driver("Juan", "Estrada", "sa", "1", new DateOnly(2000, 1, 10), "sda", "sad", "sad", "asd", "B2", 12)));
Storage.VehicleList.Add(new Vehicle(2, "23D", "moto", "2123", "12332", 2, new Driver("Andres", "Naranjo", "CC", "2", new DateOnly(2007, 2, 9), "sda", "sad", "sad", "asd", "b2", 12)));
Storage.VehicleList.Add(new Vehicle(2, "23D", "moto", "2123", "12332", 2, new Driver("Leison", "Mosquera", "TI", "3", new DateOnly(1998, 8, 1), "sda", "sad", "sad", "asd", "a2", 12)));
Storage.VehicleList.Add(new Vehicle(2, "23D", "moto", "2123", "12332", 2, new Driver("Andres", "Cano", "Pass", "4", new DateOnly(2002, 1, 30), "sda", "sad", "sad", "asd", "a2", 12)));

// Agregar cliente

Storage.CustomerList.Add(new Customer("Alice", "Smith", "Passport", "A1234567", new DateOnly(1990, 5, 15), "alice.smith@example.com", "+1234567890", "123 Elm Street, Springfield", "Gold", "credit card"));
Storage.CustomerList.Add(new Customer("Bob", "Johnson", "Driver's License", "B2345678", new DateOnly(1985, 8, 22), "bob.johnson@example.com", "+2345678901", "456 Oak Avenue, Springfield", "Silver", "debit card"));
Storage.CustomerList.Add(new Customer("Charlie", "Williams", "ID Card", "C3456789", new DateOnly(1978, 2, 10), "charlie.williams@example.com", "+3456789012", "789 Pine Road, Springfield", "Bronze", "cash"));
Storage.CustomerList.Add(new Customer("Diana", "Brown", "Passport", "D4567890", new DateOnly(1992, 11, 5), "diana.brown@example.com", "+4567890123", "101 Maple Street, Springfield", "Gold", "credit card"));


while (true)
{
    Console.Clear();
    string opc = VisualInterfaces.ShowFirstMenu();
    switch (opc)
    {
        // Parte de clientes
        case "1":
            bool cFlag = true;
            while (cFlag)
            {
                Console.Clear();
                string cOpc = VisualInterfaces.ShowCustomerMenu();
                switch (cOpc)
                {
                    case "1":
                        Storage.AddCustomer();
                        VisualInterfaces.ShowFooter();
                        break;
                    case "2":
                        Storage.ShowAllCustomers();
                        VisualInterfaces.ShowFooter();
                        break;
                    case "3":
                        Storage.ShowCostumerGretaerThan30();
                        VisualInterfaces.ShowFooter();
                        break;

                    case "4":
                        Storage.ShowCostumerPreferCredit();
                        VisualInterfaces.ShowFooter();
                        break;

                    case "5":
                        Storage.DeleteCostumer();
                        VisualInterfaces.ShowFooter();
                        break;

                    case "6":
                        Storage.UpdateCostumer();
                        VisualInterfaces.ShowFooter();
                        break;

                    case "0":
                        cFlag = false;
                        break;

                    default:
                        VisualInterfaces.ShowDefault();
                        break;
                }
            }
            break;

        // Parte de los conductores
        case "2":
            bool dFlag = true;
            while (dFlag){
                Console.Clear();
                string dOpc = VisualInterfaces.ShowDriverMenu();
                switch (dOpc){
                    case "1":
                        Storage.AddDriver();
                        VisualInterfaces.ShowFooter();
                        break;

                    case "2":
                        Storage.ShowAllDrivers();
                        VisualInterfaces.ShowFooter();
                        break;

                    case "3":
                        Storage.ShowDriverGreaterThan30();
                        VisualInterfaces.ShowFooter();
                        break;

                    case "4":
                        Storage.ShowDriverByExperience();
                        VisualInterfaces.ShowFooter();
                        break;

                    case "5":
                        Storage.ShowDriversWithA2();
                        VisualInterfaces.ShowFooter();
                        break;

                    case "6":
                        Storage.DeleteCostumer();
                        VisualInterfaces.ShowFooter();
                        break;

                    case "7":
                        Storage.UpdateCostumer();
                        VisualInterfaces.ShowFooter();
                        break;

                    case "0":
                        dFlag = false;
                        break;

                    default:
                        VisualInterfaces.ShowDefault();
                        break;
                }
            }
            break;

        // Parte de los vehiculos
        case "3":
            bool vFlag = true;
            while (vFlag){
                var vOpc = VisualInterfaces.ShowVehicleMenu();
                switch (vOpc){
                    case "1":
                        Storage.AddVehicle();
                        VisualInterfaces.ShowFooter();
                        break;

                    case "2":
                        Storage.ShowAllVehicles();
                        VisualInterfaces.ShowFooter();
                        break;

                    case "3":
                        Storage.DeleteVehicle();
                        VisualInterfaces.ShowFooter();
                        break;

                    case "0":
                        vFlag =false;
                        break;

                    default:
                        VisualInterfaces.ShowDefault();
                        break;
                }
            }
            break;
        case "0":
            return;
        default:
            VisualInterfaces.ShowDefault();
            break;
    }
}
