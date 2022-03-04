using System.Collections.Generic;

namespace MehanikASP.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string Znamka { get; set; }
        public string Model { get; set; }
        public string Letnik { get; set; }
        public string VIN { get; set; }
        public string kW { get; set; }
        public string TipMotorja { get; set; }
        public string RegOzn { get; set; }
        public ICollection<Service> Servisi { get; set; }
        public int StrankaId { get; set; }
        public Customer Stranka { get; set; }
    }
}
