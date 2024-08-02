using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_01.Models
{
    public class Vehicle
    {

        public int Id { get; set; }
        public string Plate { get; set; }
        public string Type { get; set; }
        public string EngineNumber { get; set; }
        public string SerialNumber { get; set; }
        public byte PeopleCapacity { get; set; }
        public Driver Owner { get; set; }
        public Vehicle(int _id, string _plate, string _type, string _engineNumber, string _serialNumber, byte _peopleCapacity, Driver _owner)
        {
            this.Id = _id;
            this.Plate = _plate.Trim().ToUpper();
            this.Type = _type.Trim().ToLower();
            this.EngineNumber = _engineNumber.Trim();
            this.SerialNumber = _serialNumber.Trim();
            this.PeopleCapacity = _peopleCapacity;
            this.Owner = _owner;
        }
        public void DeleteVehicle(int id){
            
        }
    }
}