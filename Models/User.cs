using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_01.Models
{
    public class User
    {


        protected Guid Id { get; set; }
        protected string Name { get; set; }
        protected string LastName { get; set; }
        protected string TypeDocument { get; set; }
        protected string IdentificationNumber { get; set; }
        // -----------------------------------------------------------------
        public string IdentificationNumberPublic
        {
            get { return IdentificationNumber; }
            set { IdentificationNumber = IdentificationNumberPublic; }
        }
        // ------------------------------------------------------------------
        protected DateOnly BirthDate { get; set; }
        protected string Email { get; set; }
        protected string PhoneNumber { get; set; }
        protected string Address { get; set; }
        public User(string _name, string _lastName, string _typeDocument, string _identificationNumber, DateOnly _birthDate, string _email, string _phoneNumber, string _address)
        {
            this.Id = Guid.NewGuid();
            this.Name = _name.Trim().ToLower();
            this.LastName = _lastName.Trim().ToLower();
            this.TypeDocument = _typeDocument.Trim().ToUpper();
            this.IdentificationNumber = _identificationNumber.Trim();
            this.BirthDate = _birthDate;
            this.Email = _email.Trim();
            this.PhoneNumber = _phoneNumber.Trim();
            this.Address = _address.Trim();
        }

        protected void ShowDetails()
        {
            Console.WriteLine(@$"            ID: {Id}
            Nombre completo: {Name} {LastName}
            Tipo de documento: {TypeDocument}
            Numero de documento: {IdentificationNumber}
            Fecha de nacimiento: {BirthDate}
            Correo electronico: {Email}
            Numero de telefono: {PhoneNumber}
            Direccion: {Address}");
        }

        protected int CalculateAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }
        protected void ShowAge()
        {
            Console.WriteLine(CalculateAge());
        }

        public int GetAge(){
            return CalculateAge();
        }
    }
}