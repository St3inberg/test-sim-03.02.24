

namespace airport.classes
{
    class Gate
    {
        public int Number { get; set; }
        public Plane Plane { get; set; }

        public Gate(int number)
        {
            Number = number;
        }
    }
}
