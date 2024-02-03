
using airport.classes; // Ensure this using directive is added to reference the Plane class correctly

namespace airport
{
    class Program
    {
        static async Task Main(string[] args) // Note the Main method is now an async Task
        {
            var airport = new Airport();

            Console.WriteLine("Welcome to the Airport Simulation!");

            // Create Terminal
            Console.Write("Enter the number of terminals to create: ");
            int terminalCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < terminalCount; i++)
            {
                var terminal = new Terminal(i + 1);
                airport.AddTerminal(terminal);

                // Create Gates
                Console.Write($"Enter the number of gates for Terminal {i + 1}: ");
                int gateCount = int.Parse(Console.ReadLine());
                for (int j = 0; j < gateCount; j++)
                {
                    var gate = new Gate(j + 1);
                    terminal.AddGate(gate);

                    // Assign Plane to Gate
                    Console.Write($"Enter the name of the plane for Gate {j + 1} in Terminal {i + 1}: ");
                    string planeName = Console.ReadLine();
                    gate.Plane = new Plane(planeName);
                }
            }

            // Initiate Takeoff
            Console.WriteLine("Would you like to start a takeoff procedure? (yes/no)");
            string response = Console.ReadLine().ToLower();
            if (response == "yes")
            {
                // Simplified: Assume takeoff from the first plane in the first gate of the first terminal
                if (airport.Terminals.Count > 0 && airport.Terminals[0].Gates.Count > 0 && airport.Terminals[0].Gates[0].Plane != null)
                {
                    await airport.Terminals[0].Gates[0].Plane.StartTakeoffProcedure(); // Await the asynchronous operation
                }
            }
        }
    }
}
