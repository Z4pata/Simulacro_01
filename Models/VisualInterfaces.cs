using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_01.Models
{
    public class VisualInterfaces
    {
        public static string ShowFirstMenu(){
            Console.Write(@$"
                        BIENVENIDO!!
                
        Que tipo de usuario deseas gestionar?

            1. Usuario

            2. Conductor
            
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
    }
}