using System.Collections.Generic;

namespace MehanikASP.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Naslov { get; set; }
        public string Telefon { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
