namespace publicTransformation_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] routes = { "Station A", "Station B", "Station C" , "Station D" };
            Car car01 = new Car(routes, "Car 01", 150, "Red");

            car01.Move();
            car01.Horn();
            car01.goToNextStation();
            car01.DoorManager();
            car01.Brake();
            car01.goToNextStation();
            car01.DoorManager();
            car01.goToNextStation();
            car01.goToNextStation();
            car01.goToNextStation();
            /*
            Bus bus01 = new Bus(routes, "Bus 01", 80, "Blue");
            bus01.Horn();
            bus01.Move();
            bus01.goToNextStation();
            bus01.DoorManager();
            bus01.Brake();
            bus01.goToNextStation();
            bus01.DoorManager();

            Train train01 = new Train(routes, "Train 01", 200, "Green");
            train01.Horn();
            train01.Move();
            train01.goToNextStation();
            train01.DoorManager();
            train01.Brake();
            train01.goToNextStation();
            train01.DoorManager();
            */
            Console.ReadKey();
        }
    }
}
