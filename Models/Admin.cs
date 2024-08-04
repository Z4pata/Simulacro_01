using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_01.Models
{
    public class Admin
    {
        public static Customer CreateCustomer()
        {
            string name;
            string lastName;
            string typeDocument;
            string identificationNumber;
            DateOnly birthDate;
            string email;
            string phoneNumber;
            string address;
            string membershipLevel;
            string preferredPaymentMethod;
            // Les tengo que dar un valor ya que al hacer las validaciones me da un error de que la variable no tiene contenido
            int year = 0;
            int month = 0;
            int day = 0;

            // Nombre

            do
            {
                Console.Write("Ingrese el nombre (No debe estar vacio): ");
                name = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(name));

            // Apellido

            do
            {
                Console.Write("Ingrese el apellido (No debe estar vacio): ");
                lastName = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(lastName));

            // Tipo documento

            do
            {
                Console.Write("Ingrese el tipo de documento (No debe estar vacio): ");
                typeDocument = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(typeDocument));

            // Numero documento

            do
            {
                Console.Write("Ingrese el numero de documento (No debe estar vacio): ");
                identificationNumber = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(identificationNumber));


            // Nacimiento

            Console.WriteLine("Fecha de Nacimiento: ");

            year = Settings.ValidateInt("Año: ");
            month = Settings.ValidateInt("Mes: ");
            day = Settings.ValidateInt("Dia: ");

            birthDate = new DateOnly(year, day, month);

            // Correo

            do
            {
                Console.Write("Ingrese el correo: ");
                email = Console.ReadLine() ?? "";

            } while (Settings.ValidateEmail(email));

            // Numero de telefono

            do
            {
                Console.Write("Ingrese el numero de telefono: ");
                phoneNumber = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(phoneNumber));

            // Direccion

            do
            {
                Console.Write("Ingrese la direccion: ");
                address = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(address));

            // Nivel de suscripcion

            do
            {
                Console.Write("Ingrese el nivel de suscripcion: ");
                membershipLevel = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(membershipLevel));


            // Metodo de pago

            do
            {
                Console.Write("Que metodo de pago prefiere? (credit card o debit card): ");
                preferredPaymentMethod = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(preferredPaymentMethod));

            var customer = new Customer(name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, address, membershipLevel, preferredPaymentMethod);

            return customer;
        }

        public static Driver CreateDriver()
        {
            string name;
            string lastName;
            string typeDocument;
            string identificationNumber;
            DateOnly birthDate;
            string email;
            string phoneNumber;
            string address;
            string licenseNumber;
            string licenseCategory;
            // Les tengo que dar un valor ya que al hacer las validaciones me da un error de que la variable no tiene contenido
            int year = 0;
            int month = 0;
            int day = 0;
            int drivingExperience = 0;


            // Nombre

            do
            {
                Console.Write("Ingrese el nombre (No debe estar vacio): ");
                name = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(name));

            // Apellido

            do
            {
                Console.Write("Ingrese el apellido (No debe estar vacio): ");
                lastName = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(lastName));

            // Tipo documento

            do
            {
                Console.Write("Ingrese el tipo de documento (No debe estar vacio): ");
                typeDocument = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(typeDocument));

            // Numero documento

            do
            {
                Console.Write("Ingrese el numero de documento (No debe estar vacio): ");
                identificationNumber = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(identificationNumber));


            // Nacimiento

            Console.WriteLine("Fecha de Nacimiento: ");

            year = Settings.ValidateInt("Año: ");
            month = Settings.ValidateInt("Mes: ");
            day = Settings.ValidateInt("Dia: ");

            birthDate = new DateOnly(year, day, month);

            // Correo

            do
            {
                Console.Write("Ingrese el correo: ");
                email = Console.ReadLine();

            } while (Settings.ValidateEmail(email));

            // Numero de telefono

            do
            {
                Console.Write("Ingrese el numero de telefono: ");
                phoneNumber = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(phoneNumber));

            // Direccion

            do
            {
                Console.Write("Ingrese la direccion: ");
                address = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(address));

            // Numero de licencia

            do
            {
                Console.Write("Ingrese el numero de licencia: ");
                licenseNumber = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(licenseNumber));

            // Categoria de licencia

            do
            {
                Console.Write("Que tipo de licencia es? (Solo: A2 O B2): ");
                licenseCategory = Console.ReadLine().ToUpper();
            } while (string.IsNullOrWhiteSpace(licenseCategory) || !licenseCategory.Equals("A2") || licenseCategory.Equals("B2"));

            // Años de experiencia

            string sDrivingExperience;

            drivingExperience = Settings.ValidateInt("Ingrese los años de experiencia conduciendo: ");

            var driver = new Driver(name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, address, licenseNumber, licenseCategory, drivingExperience);

            return driver;
        }

        public static Vehicle CreateVehicle(int _id)
        {
            string plate;
            string type;
            string engineNumber;
            string serialNumber;
            byte peopleCapacity;
            // Les tengo que dar un valor ya que al hacer las validaciones me da un error de que la variable no tiene contenido
            Driver owner = new Driver("sa", "sad", "sa", "ad", new DateOnly(202, 1, 10), "sda", "sad", "sad", "asd", "sda", 12);

            // Placa

            do
            {
                Console.Write("Ingrese el numero de placa: ");
                plate = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(plate));

            // tipo de carro

            do
            {
                Console.WriteLine(@"    Tipo de Vehiculo");
                Console.Write(@$"
                - Carro
                - Moto
                - Camioneta
                - Microbus
                
                => ");
                type = Console.ReadLine().ToLower();
            } while (Settings.ValidateVehicleType(type));

            // Numero del motor

            do
            {
                Console.Write("Ingrese el numero del motor: ");
                engineNumber = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(engineNumber));

            // Numero de serie

            do
            {
                Console.Write("Ingrese el numero de serie: ");
                serialNumber = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(serialNumber));

            // Capacidad del vehiculo

            peopleCapacity = Settings.ValidateByte("Cuantas personas caben?: ");

            // Dueño del vehiculo
            bool flag = true;
            while (flag)
            {
                string idOwner;
                do
                {
                    Console.Write("Ingrese el numero de identificacion del dueño: ");
                    idOwner = Console.ReadLine();

                } while (string.IsNullOrWhiteSpace(idOwner));

                if (Storage.DriverList.Any(d => d.IdentificationNumberPublic == idOwner))
                {
                    owner = Storage.DriverList.FirstOrDefault(d => d.IdentificationNumberPublic == idOwner);
                    flag = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No se encontró ningun conductor con esa identificacion!!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Crealo!!");
                    Console.ForegroundColor = ConsoleColor.White;

                    var driver = Storage.AddDriver();
                    owner = driver;
                    flag = false;
                }
            }

            var vehicle = new Vehicle(_id, plate, type, engineNumber, serialNumber, peopleCapacity, owner);

            return vehicle;

        }
    }
}