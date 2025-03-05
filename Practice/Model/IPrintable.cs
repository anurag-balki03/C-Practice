namespace Practice.Model
{
    interface IPrintable
    {
        void PrintDetails();
    }

    interface ISerializable
    {
        void Record();
    }

    public class Report : IPrintable, ISerializable
    {
        public void PrintDetails()
        {
            Console.WriteLine("The printable statements.");
        }
        public void Record()
        {
            Console.WriteLine("The details have been added to records Successfully.");
        }
    }
}
