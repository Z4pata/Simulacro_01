using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_01.Models
{
    public class Settings
    {
        public static bool ValidateByte(string input)
        {
            try
            {
                byte.Parse(input);
                return false;
            }
            catch
            {
                VisualInterfaces.IntErrorMessage();
                return true;
            }

        }

        public static bool ValidateInt(string input)
        {
            try
            {
                int.Parse(input);
                return false;
            } 
            catch
            {
                VisualInterfaces.IntErrorMessage();
                return true;
            }
        }
    }
}