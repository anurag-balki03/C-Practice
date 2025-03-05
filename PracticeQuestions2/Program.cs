using PracticeQuestions2.Model;
namespace PracticeQuestions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car("Audi", "190");
            //Bike bike = new Bike("Suzuki", "130");                    //1.Vehicle

            //Car1 car = new Car1();
            //Bike1 bike = new Bike1();
            //Console.Write("Enter the car name : ");
            //string brand = Console.ReadLine();
            //Console.Write("Enter the car speed : ");
            //int speed = int.Parse(Console.ReadLine());
            //car.DisplayInfo(brand, speed);
            //Console.Write("Enter the bike name : ");
            //brand = Console.ReadLine();
            //Console.Write("Enter the bike speed : ");
            //speed = int.Parse(Console.ReadLine());
            //bike.DisplayInfo(brand, speed);                         //2.Vechiclee

            //Manager man = new Manager();                             //3.Employee

            //Cat cat = new Cat();
            //Dog dog = new Dog();                                     //4.Animal

            //Robot robot = new Robot();                               //5.Robot

            //SavingsAccount savings = new SavingsAccount();
            ////1.SimpleInterest 2.CoumpoundInterest
            //savings.CalculateInterest(1);
            //savings.CalculateInterest(2);                           //6.CALCULATE INTEREST


            //Duck duck = new Duck();                                   //7.Duck


            Student student = new Student("Alice", 20, 101);

            Person person = student;
            person.Display();

            Student downcastedStudent = (Student)person;
            downcastedStudent.Display();                            //8.UpCastDownCast

            //ElectronicProduct electric = new ElectronicProduct();
            //ClothingProduct Cloth = new ClothingProduct();           //9.ProductAndDiscount

            //SecuritySystem secure = new SecuritySystem();
            //secure.AuthenticateUser("From the base class Object");
            //Inher inher = new Inher();                                 //10.SecureSystem        
        }
    }
}
