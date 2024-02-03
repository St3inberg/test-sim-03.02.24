
using System.Diagnostics; // For Stopwatch


namespace airport.classes
{
    class Plane
    {
        public string Name { get; set; }

        public Plane(string name)
        {
            Name = name;
        }

        public async Task StartTakeoffProcedure()
        {
            var stopwatch = new Stopwatch();

            Console.WriteLine($"{Name} is starting the takeoff procedure:");

            stopwatch.Start();
            await Task.Delay(1000); // Simulate delay for entering taxi queue
            stopwatch.Stop();
            Console.WriteLine($"1. Entering taxi queue (Elapsed time: {stopwatch.Elapsed.TotalSeconds} seconds)");

            stopwatch.Restart();
            await Task.Delay(2000); // Simulate delay for going to taxi
            stopwatch.Stop();
            Console.WriteLine($"2. Going to taxi (Elapsed time: {stopwatch.Elapsed.TotalSeconds} seconds)");

            stopwatch.Restart();
            await Task.Delay(1500); // Simulate delay for entering runway queue
            stopwatch.Stop();
            Console.WriteLine($"3. Entering runway queue (Elapsed time: {stopwatch.Elapsed.TotalSeconds} seconds)");

            stopwatch.Restart();
            await Task.Delay(3000); // Simulate delay for entering runway
            stopwatch.Stop();
            Console.WriteLine($"4. Entering runway (Elapsed time: {stopwatch.Elapsed.TotalSeconds} seconds)");

            stopwatch.Restart();
            await Task.Delay(2500); // Simulate delay for takeoff
            stopwatch.Stop();
            Console.WriteLine($"5. Takeoff (Elapsed time: {stopwatch.Elapsed.TotalSeconds} seconds)");

            Console.WriteLine("Takeoff procedure completed.");
        }
    }
}
