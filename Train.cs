using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publicTransformation_Abstraction
{
    internal class Train : Transport
    {
        public Train(string[] routes, string name, int maxspeed, string color)
        {
            Routes = routes;
            Name = name;
            MaxSpeed = maxspeed;
            Color = color;
        }
        public override void Move()
        {
            Console.WriteLine($"The {Name} is moving at a speed of {MaxSpeed} km/h.");
        }
        public override void goToNextStation()
        {
            Console.WriteLine($"The next station is {Routes[++RouteIndex]}");
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
