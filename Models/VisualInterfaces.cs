using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Simulacro_01.Models
{
    public class VisualInterfaces
    {
        public static string ShowFirstMenu(){
            Console.Write(@$"
                        BIENVENIDO!!
                
        Que tipo de usuario deseas gestionar?

            1. Cliente

            2. Conductor

            3. Vehiculo

            0. Salir
            
            ==> ");

            return Console.ReadLine();
        }

        public static string ShowCustomerMenu(){
            Console.Write(@$"
                        CLIENTE!!
            
            Que gestion deseas hacer?

                1. Crear cliente
                2. Mostrar todos los clientes
                3. Mostrar todos los clientes que tengan mas de 30 años
                4. Mostrar todos los clientes que prefieran pagar con tarjeta de credito
                5. Eliminar cliente
                6. Actualizar cliente
                
                0. Salir
              ==> ");

            return Console.ReadLine();
        }

        public static string ShowDriverMenu(){
            Console.Write(@$"
                        CONDUCTOR!!
            
            Que gestion deseas hacer?

                1. Crear conductor
                2. Mostrar todos los conductores
                3. Mostrar todos los conductores que tengan mas de 30 años
                4. Mostrar los conductores ordenados por su experiencia
                5. Mostrar los conductores con licencia de tipo 'A2'
                6. Eliminar conductor
                7. Actualizar conductor
                
                0. Salir
              ==> ");

            return Console.ReadLine();
        }

        public static string ShowVehicleMenu(){
            Console.Write(@"
                        VEHICULO!!
            
            Que gestion deseas hacer?

                1. Crear vehiculo
                2. Mostrar vehiculos
                3. Eliminar vehiculo

                0. Salir
            
              ==> ");
            return Console.ReadLine();
        }

        public static void ShowIntErrorMessage(){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: Debes ingresar un numero!!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void ShowEmailErrorMessage(){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: Debes ingresar un email valido!!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ShowVehicleTypeErrorMessage(){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: Debes ingresar un vehiculo valido!!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ShowFooter(){
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Presiona cualquier tecla...");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ShowDefault(){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Opcion no valida!!");
            Console.WriteLine("Presiona cualquier tecla...");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ShowErrorFind(string prompt){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: No se encontro ese {prompt}!!");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}