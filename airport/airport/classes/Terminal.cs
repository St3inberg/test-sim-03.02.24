


namespace airport.classes
{
    class Terminal
    {
        public int Number { get; set; }
        public List<Gate> Gates { get; set; } = new List<Gate>();

        public Terminal(int number)
        {
            Number = number;
        }

        public void AddGate(Gate gate)
        {
            Gates.Add(gate);
        }
    }
}
