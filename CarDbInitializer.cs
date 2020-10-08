using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CarDbInitializer : DropCreateDatabaseAlways<CarContext>
    {
        protected override void Seed(CarContext db)
        {
            db.Cars.Add(new Car { Corporation = "Renault", Model = "Megane", Price = 220000 });
            db.Cars.Add(new Car { Corporation = "Volkswagen", Model = "Passat", Price = 150000 });
            db.Cars.Add(new Car { Corporation = "Горьковскмй автомобильный завод", Model = "ГАЗ-69", Price = 180000 });
            base.Seed(db);
        }
    }
}