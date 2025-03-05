namespace Practice.Model
{
    class Calculator
    {
        public void Add(int x, int y)
        {
            Console.WriteLine($"Sum of two integers : {x+y}");
        }
        public void Add(int x, int y, int z)
        {
            Console.WriteLine($"Sum of three integers : {x+y+z}");
        }
        public void Add(float x, float y)
        {
            Console.WriteLine($"Sum of two float values : {x+y}");
        }
    }
}
