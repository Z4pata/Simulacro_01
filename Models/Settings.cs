using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
                return true;
            }
        }

        public static bool ValidateEmail(string email)
        {
            string ValidFormat = new MailAddress(email).Address;

            if (ValidFormat == email)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}