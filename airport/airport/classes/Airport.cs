

namespace airport.classes
{
    class Airport
    {
        public List<Terminal> Terminals { get; set; } = new List<Terminal>();

        public void AddTerminal(Terminal terminal)
        {
            Terminals.Add(terminal);
        }
    }
}
