using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_01.Models
{
    public class VisualInterfaces
    {
        public static string PrimerMenu(){
            Console.Write(@$"
                        BIENVENIDO!!
                
        Que tipo de usuario deseas gestionar?

            1. Usuario

            2. Conductor
            
            ==> ");

            return Console.ReadLine();
        }
    }
}