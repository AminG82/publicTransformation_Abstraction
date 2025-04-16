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
        internal abstract void OpenDoor();
        internal abstract void CloseDoor();
        public void Horn()
        {
            Console.WriteLine("Beep Beep!");
        }
        public abstract void Move();
        public void Brake()
        {
            Console.WriteLine($"The {Name} is braking.");
        }
        public  void goToNextStation()
        {
            if (RouteIndex < Routes.Length - 1)
            {
                Console.WriteLine($"The next station is {Routes[++RouteIndex]}");
            }
            else
            {
                Console.WriteLine("End of line!");
            }
        }

        public void DoorManager()
        {
            OpenDoor();
            Thread.Sleep(5000);
            CloseDoor();
        }
    }
}
