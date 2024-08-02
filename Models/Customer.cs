using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_01.Models
{
    public class Customer : User
    {
        public string MembershipLevel { get; set; }
        public string PreferredPaymentMethod { get; set; }
        public Customer(string _name, string _lastName, string _typeDocument, string _identificationNumber, DateOnly _birthDate, string _email, string _phoneNumber, string _address, string _membershipLevel, string _preferredPaymentMethod) : base(_name, _lastName, _typeDocument, _identificationNumber, _birthDate, _email, _phoneNumber, _address)
        {
            this.MembershipLevel = _membershipLevel.Trim();
            this.PreferredPaymentMethod = _preferredPaymentMethod.Trim().ToLower();
        }
        public void UpdateMembershipLevel(){
            MembershipLevel +=1;
        }
    }
}