using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Simulacro_01.Models
{
    public class Settings
    {

        public static string ValidateString(string prompt)
        {
            string aValidar;

            do
            {
                Console.Write(prompt);
                aValidar = Console.ReadLine() ?? " ";

            } while (string.IsNullOrWhiteSpace(aValidar));

            return aValidar;
        }
        public static byte ValidateByte(string prompt)
        {
            while (true){
                Console.Write(prompt);
                string sAvalidar = Console.ReadLine() ?? string.Empty;

                byte result;
                if (byte.TryParse(sAvalidar, out result)){
                    return result;
                } else {
                    VisualInterfaces.ShowIntErrorMessage();
                }
            }
        }

        public static int ValidateInt(string prompt)
        {
            while (true){
                Console.Write(prompt);
                string sAvalidar = Console.ReadLine() ?? string.Empty;

                int result;
                if (int.TryParse(sAvalidar, out result)){
                    return result;
                } else {
                    VisualInterfaces.ShowIntErrorMessage();
                }
            }
        }
        

        // otra forma para hacer la validacion en un entero

        public static int ValInt(string prompt)
        {
            Console.Write(prompt);

            int input;
            while (!int.TryParse((Console.ReadLine() ?? string.Empty).AsSpan(), out input))
            {
                VisualInterfaces.ShowIntErrorMessage();
                Console.Write(prompt);
            }
            return input;
        }

        public static bool ValidateEmail(string email)
        {
            try
            {
                var val = new System.Net.Mail.MailAddress(email);
                bool validate = val.Address == email;
                return !validate;

            }
            catch
            {
                VisualInterfaces.ShowEmailErrorMessage();
                return true;
            }


        }

        public static bool ValidateVehicleType(string input)
        {
            string[] Tipos = ["carro", "moto", "camioneta", "microbus"];

            if (Tipos.Contains(input))
            {
                return false;
            }
            else
            {
                VisualInterfaces.ShowVehicleTypeErrorMessage();
                return true;
            }

        }
    }
}