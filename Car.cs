using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publicTransformation_Abstraction
{
    internal class Car : Transport
    {
        public Car(string[] routes , string name , int maxspeed , string color)
        {
            Routes = routes;
            Name = name;
            MaxSpeed = maxspeed;
            Color = color;
        }

        public override void Move()
        {
            Console.WriteLine($"The {Name} is moving from {Routes[RouteIndex]} at a speed of {MaxSpeed} km/h.");

        }
        internal override void OpenDoor()
        {
            Console.WriteLine("Door is Open");
        }

        internal override void CloseDoor()
        {
            Console.WriteLine("Door is Close");
        }
    }
}
