using System;
using System.ComponentModel.DataAnnotations;

namespace MehanikASP.Models
{
    public class Service
    {
        public int Id { get; set; }


        [Required]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
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
