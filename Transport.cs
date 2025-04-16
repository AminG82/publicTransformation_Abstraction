using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publicTransformation_Abstraction
{
    public abstract class Transport
    {
        public string? Name { get; set; }
        public int? MaxSpeed { get; set; }
        public string? Color { get; set; }
        public string[]? Routes { get; set; }
        public int RouteIndex { get; set; } = 0;
        public void Horn()
        {
            Console.WriteLine("Beep Beep!");
        }
        public abstract void Move();
        public void Brake()
        {
            Console.WriteLine($"The {Name} is braking.");
        }
        public abstract void goToNextStation();
    }
}
