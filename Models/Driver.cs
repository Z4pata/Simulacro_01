using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_01.Models
{
    public class Driver : User
    {

        public string LicenseNumber { get; set; }
        public string LicenseCategory { get; set; }
        public int DrivingExperience { get; set; }
        public Driver(string _name, string _lastName, string _typeDocument, string _identificationNumber, DateOnly _birthDate, string _email, string _phoneNumber, string _address, string _licenseNumber, string _licenseCategory, int _drivingExperience) : base(_name, _lastName, _typeDocument, _identificationNumber, _birthDate, _email, _phoneNumber, _address)
        {
            this.LicenseNumber = _licenseNumber.Trim();
            this.LicenseCategory = _licenseCategory.Trim().ToUpper();
            this.DrivingExperience = _drivingExperience;
        }
        public void UpdateLicenseCategory(string newCategory){
            LicenseCategory = newCategory;
        }
        public void AddExperience(int years){
            DrivingExperience += years;
        }

        public void ShowDriver(){
            ShowDetails();
            Console.WriteLine(@$"            Numero de licencia: {LicenseNumber}
            Categoria de la licencia: {LicenseCategory}
            Años de experiencia: {DrivingExperience}");
        }
    }
}