using System;
using System.Linq;
using MehanikASP.Models;
namespace MehanikASP.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Customers.Any())
            {
                return;   // DB has been seeded
            }

            var customers = new Customer[]
            {
            new Customer{Ime="Carson",Telefon="498789"},
            new Customer{Ime="Farstf",Telefon="1221221"}


            };
            foreach (Customer s in customers)
            {
                context.Customers.Add(s);
            }
            context.SaveChanges();

            var cars = new Car[]
            {
            new Car{Znamka="Audi",Letnik="2001"},
            new Car{Znamka="BMW",Letnik="2011"},


            };
            foreach (Car c in cars)
            {
                context.Cars.Add(c);
            }
            context.SaveChanges();

            var servisi = new Service[]
            {
            new Service{Kilometri=213,OljniFilter=true},
            new Service{Kilometri=16000,OljniFilter=false},


            };
            foreach (Service e in servisi)
            {
                context.Services.Add(e);
            }
            context.SaveChanges();
        }
    }
}
