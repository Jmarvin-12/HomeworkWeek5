using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkWeek5.Logic
{
    public class ParameterTypes
    {

        public static List<Vehicle> vehicles = new List<Vehicle>();

        public float CalculateArea(float num1, float num2)
        {

            float res;

            res = (num1 * num2) / 2;

            return res;
        }


        public List<Vehicle> CreateVehicle(string modelo, int year, string color, int llantas)
        {
            Vehicle vehicle = new Vehicle();
            string category;

            if (llantas == 2 || llantas == 3)
            {
                category = "Motocicleta";
            }
            else if (llantas == 4)
            {
                category = "Automovil liviano";
            }
            else if (llantas > 4 && llantas <= 42)
            {
                category = "Camion";
            }
            else
            {
                category = "A saber, nave ovni quiza.";
            }

            vehicles.Add(new Vehicle(modelo, year, color, category));

            return vehicles;
        }

    }

    public class Vehicle
    {
        public string Id { get; set; }
        public string Model { get; set; }
        public int year { get; set; }
        public string color { get; set; }
        public string category { get; set; }
        public DateTime EntryDate { get; set; }

        public Vehicle() { }

        public Vehicle(string? Model, int? year, string? color, string? category)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Model = Model;
            this.year = (int)year;
            this.color = color;
            this.category = category;
            this.EntryDate = DateTime.Now;
        }


    }
}
