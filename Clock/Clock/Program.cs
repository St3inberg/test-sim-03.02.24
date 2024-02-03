namespace Clock
{
    using System;
    using System.Diagnostics; // For Stopwatch
    using System.Threading.Tasks;

    namespace PlaneRunwaySimulation
    {
        class Program
        {
            static async Task Main(string[] args)
            {
                int totalSimulationTimeInSeconds = 3 + 2 + 5; // Sum of all phase durations
                Console.WriteLine("Simulation Loading Line:\n");

                // Start the loading line task
                var loadingTask = UpdateLoadingLine(totalSimulationTimeInSeconds, Console.CursorTop);

                // Move cursor below the loading line for the rest of the messages
                int descriptionCursorTop = Console.CursorTop + 1; // Reserve space for the loading line
                Console.SetCursorPosition(0, descriptionCursorTop);

                Console.WriteLine("\nPlane to Runway Simulation\n");

                // Simulate each phase
                await SimulatePhase("1. Moving to taxi queue", 3, descriptionCursorTop + 2);
                await SimulatePhase("2. In taxi queue", 2, descriptionCursorTop + 3);
                await SimulatePhase("3. Taxiing to runway", 5, descriptionCursorTop + 4);
                Console.SetCursorPosition(0, descriptionCursorTop + 5);
                Console.WriteLine("4. Takeoff initiated...");

                // Wait for the loading line to complete if it hasn't already
                await loadingTask;

                Console.SetCursorPosition(0, descriptionCursorTop + 6);
                Console.WriteLine("\nSimulation complete. Takeoff initiated.");
            }

            static async Task UpdateLoadingLine(int totalDuration, int cursorTop)
            {
                int totalDots = 50; // Total dots to represent 100% completion
                int dotDelay = (totalDuration * 1000) / totalDots; // Time per dot

                for (int i = 0; i < totalDots; i++)
                {
                    Console.SetCursorPosition(i, cursorTop);
                    Console.Write("▓");
                    await Task.Delay(dotDelay);
                }
            }

            static async Task SimulatePhase(string phaseName, int durationInSeconds, int cursorTop)
            {
                Console.SetCursorPosition(0, cursorTop);
                Console.WriteLine($"{phaseName}...");
                await Task.Delay(durationInSeconds * 1000); // Simulate the duration of the phase
            }
        }
    }





}
