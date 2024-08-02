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
            int year = 0;
            int month = 0;
            int day = 0;
            DateOnly birthDate;
            string email;
            string phoneNumber;
            string address;
            string membershipLevel;
            string preferredPaymentMethod;


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

            string sYear;
            do
            {
                Console.Write("     Año: ");
                sYear = Console.ReadLine();

                if (!Settings.ValidateInt(sYear))
                {
                    year = Convert.ToInt16(sYear);
                }
                else
                {
                    VisualInterfaces.ShowIntErrorMessage();
                }

            } while (Settings.ValidateInt(sYear));

            string sMonth;
            do
            {
                Console.Write("     Mes: ");
                sMonth = Console.ReadLine();

                if (!Settings.ValidateInt(sMonth))
                {
                    month = Convert.ToInt16(sMonth);
                }
                else
                {
                    VisualInterfaces.ShowIntErrorMessage();
                }
            } while (Settings.ValidateInt(sMonth));

            string sDay;
            do
            {
                Console.Write("     Dia: ");
                sDay = Console.ReadLine();

                if (!Settings.ValidateInt(sDay))
                {
                    day = Convert.ToInt16(sDay);
                }
                else
                {
                    VisualInterfaces.ShowIntErrorMessage();
                }

            } while (Settings.ValidateInt(sDay));

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

            // Nivel de suscripcion

            do
            {
                Console.Write("Ingrese el nivel de suscripcion: ");
                membershipLevel = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(membershipLevel));


            // Metodo de pago

            do
            {
                Console.Write("Que metodo de pago prefiere?: ");
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
            int year = 0;
            int month = 0;
            int day = 0;
            DateOnly birthDate;
            string email;
            string phoneNumber;
            string address;
            string licenseNumber;
            string licenseCategory;
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

            string sYear;
            do
            {
                Console.Write("     Año: ");
                sYear = Console.ReadLine();

                if (!Settings.ValidateInt(sYear))
                {
                    year = Convert.ToInt16(sYear);
                }
                else
                {
                    VisualInterfaces.ShowIntErrorMessage();
                }

            } while (Settings.ValidateInt(sYear));

            string sMonth;
            do
            {
                Console.Write("     Mes: ");
                sMonth = Console.ReadLine();

                if (!Settings.ValidateInt(sMonth))
                {
                    month = Convert.ToInt16(sMonth);
                }
                else
                {
                    VisualInterfaces.ShowIntErrorMessage();
                }
            } while (Settings.ValidateInt(sMonth));

            string sDay;
            do
            {
                Console.Write("     Dia: ");
                sDay = Console.ReadLine();

                if (!Settings.ValidateInt(sDay))
                {
                    day = Convert.ToInt16(sDay);
                }
                else
                {
                    VisualInterfaces.ShowIntErrorMessage();
                }

            } while (Settings.ValidateInt(sDay));

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

            do
            {
                Console.Write("Ingrese los años de experiencia conduciendo: ");
                sDrivingExperience = Console.ReadLine();

                if (!Settings.ValidateInt(sDrivingExperience))
                {
                    drivingExperience = Convert.ToInt16(sDrivingExperience);
                }
                else
                {
                    VisualInterfaces.ShowIntErrorMessage();
                }

            } while (Settings.ValidateInt(sDrivingExperience));

            var driver = new Driver(name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, address, licenseNumber, licenseCategory, drivingExperience);

            return driver;
        }
    }
}