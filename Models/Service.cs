using System;

namespace MehanikASP.Models
{
    public class Service
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public int Kilometri { get; set; }
        public bool OljniFilter { get; set; }
        public bool ZracniFilter { get; set; }
        public bool FilterGoriva { get; set; }
        public bool FilterKabine { get; set; }
        public string Opombe { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        
        
    }
}
