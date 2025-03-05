namespace Practice.Model
{
    class Student
    {
        private int _RollNumber { get; set; }
        private string? _Name { get; set; }
        public void GetDetails()
        {
            Console.Write("Enter Roll Number of the student : ");
            int Roll = int.Parse(Console.ReadLine());
            Console.Write("Enter the name of the student : ");
            string? NameA = Console.ReadLine();
            if (Roll <= 0 || NameA.Length<=0)
            {
                Console.WriteLine("enter the valid Input!!");
            }
            else
            {
                _RollNumber = Roll;
                _Name = NameA;
                Console.WriteLine($"Roll Number : {_RollNumber} \nName : {_Name}");
            }
   
        }
    }
}
