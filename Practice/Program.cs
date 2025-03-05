using Practice.Model;
using System.Reflection;


namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BankAccount BA = new BankAccount();
            //BA.Deposit();
            //BA.Withdraw();                                                                    //1.BankAccount

            //Student stud = new Student();
            //stud.GetDetails();                                                                //2.Student


            //Console.Write("Enter Title of the Book : ");
            //string Title = Console.ReadLine();
            //Console.Write("Enter name of the Author of the Book : ");
            //string Author = Console.ReadLine();
            //Console.Write("Enter ISBN Number of the Book : ");
            //string ISBN = Console.ReadLine();
            //Book book = new Book();
            //Book book1 = new Book(Title,Author);
            //Book book2 = new Book(Title, Author, ISBN);                                        //3.Book

            //Circle circle = new Circle();
            //Rectangle rectangle = new Rectangle();
            //circle.CalculateArea();
            //rectangle.CalculateArea();                                                            //4.Shape

            //Vehicle vehicle = new Vehicle();
            //Car car = new Car();
            //Bike bike = new Bike();
            //vehicle.Start();
            //car.Start();
            //bike.Start();                                                                         //5.Vehicle

            //Students std = new Students();
            //Teacher teach = new Teacher();
            //std.GetDetails(1);
            //teach.GetDetails(3);                                                                  //6.Person

            //Calculator calculate = new Calculator();
            //calculate.Add(2, 3);
            //calculate.Add(2, 3, 4);
            //float x = 3;
            //float y = 4;
            //calculate.Add(x, y);                                                                  //7.Calculator

            //MusicPlayer player = new MusicPlayer();
            //VideoPlayer player1 = new VideoPlayer();
            //player.Play();
            //player1.Play();                                                                       //8.IPlayable

            //Report report = new Report();
            //report.PrintDetails();
            //report.Record();                                                                          //9.Report

            //Admin A = new Admin("BOB", "admin");
            //Customer C = new Customer("ALICE", "customer");                                         //10.AccessControl

            //ComplexNumber c1 = new ComplexNumber(3, 4);
            //ComplexNumber c2 = new ComplexNumber(1, 2);
            //ComplexNumber result = c1 + c2;

            //Console.WriteLine($"The result of adding {c1} and {c2} is {result}");                  //11.OperatorOverloading

            //// Create original Department
            //Department original = new Department { Manager = new Manager { Name = "John" } };

            //// Perform Shallow Copy
            //Department shallowCopy = original.ShallowCopy();
            //// Perform Deep Copy
            //Department deepCopy = original.DeepCopy();

            //// Display original and copies
            //Console.WriteLine("Original Manager: " + original.Manager.Name);
            //Console.WriteLine("Shallow Copy Manager: " + shallowCopy.Manager.Name);
            //Console.WriteLine("Deep Copy Manager: " + deepCopy.Manager.Name);

            //// Modify original Manager's name
            //original.Manager.Name = "Jane";

            //// Display original and copies after modification
            //Console.WriteLine("\nAfter modifying original Manager's name:");
            //Console.WriteLine("Original Manager: " + original.Manager.Name);
            //Console.WriteLine("Shallow Copy Manager: " + shallowCopy.Manager.Name);
            //Console.WriteLine("Deep Copy Manager: " + deepCopy.Manager.Name);                                     //12.ShallowDeep


            //Bank.SetInterestRate(3.5);

            //// Create two bank objects
            //Bank bank1 = new Bank();
            //Bank bank2 = new Bank();

            //// Display the interest rate for both bank objects
            //Console.WriteLine($"Bank1 Interest Rate: {Bank.InterestRate}%");
            //Console.WriteLine($"Bank2 Interest Rate: {Bank.InterestRate}%");

            //// Change the interest rate using the static method
            //Bank.SetInterestRate(4.0);

            //// Display the updated interest rate for both bank objects
            //Console.WriteLine($"Updated Bank1 Interest Rate: {Bank.InterestRate}%");
            //Console.WriteLine($"Updated Bank2 Interest Rate: {Bank.InterestRate}%");//13.BankingSystem

            //SecuritySystem securitySystem = new SecuritySystem();
            //securitySystem.Activate();
            //securitySystem.Deactivate();                                                                      //14.SealedClass

            //// Create a new button instance
            //Button button = new Button();

            //// Subscribe to the OnClick event
            //button.OnClick += Button_OnClick;

            //// Simulate button click
            //button.Click();                                                                                    //15.Button uncomment other funtion at the bottom

            //IVehicle vehicle1 = VehicleFactory.GetVehicle("car");
            //vehicle1.Drive();

            //IVehicle vehicle2 = VehicleFactory.GetVehicle("bike");
            //vehicle2.Drive();                                                                             //16.FactoryPattern

            //ILogger logger = new FileLogger();
            //ILogger timestampLogger = new TimestampLogger(logger);
            //ILogger errorLogger = new ErrorCategorizationLogger(timestampLogger);

            //errorLogger.Log("This is a test log message.");                                                       //17.Ilogger

            //ConfigurationManager configManager = ConfigurationManager.Instance;
            //configManager.DisplayConfiguration();                                                           //18.singleton

            //var notificationService = new NotificationService();

            //var emailNotifier = new EmailNotifier();
            //var smsNotifier = new SMSNotifier();

            //notificationService.AddObserver(emailNotifier);
            //notificationService.AddObserver(smsNotifier);

            //notificationService.NotifyObservers("New message received!");

            //notificationService.RemoveObserver(emailNotifier);

            //notificationService.NotifyObservers("Another message received!");                                //19.Notification

            //ShoppingCart cart = new ShoppingCart();

            //Console.WriteLine("Enter total amount:");
            //decimal totalAmount = Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine("Choose discount type: 1. No Discount 2. Percentage Discount 3. Fixed Amount Discount");
            //int choice = Convert.ToInt32(Console.ReadLine());

            //switch (choice)
            //{
            //    case 1:
            //        cart.SetDiscountStrategy(new NoDiscount());
            //        break;
            //    case 2:
            //        Console.WriteLine("Enter percentage discount:");
            //        decimal percentage = Convert.ToDecimal(Console.ReadLine());
            //        cart.SetDiscountStrategy(new PercentageDiscount(percentage));
            //        break;
            //    case 3:
            //        Console.WriteLine("Enter fixed amount discount:");
            //        decimal fixedAmount = Convert.ToDecimal(Console.ReadLine());
            //        cart.SetDiscountStrategy(new FixedAmountDiscount(fixedAmount));
            //        break;
            //    default:
            //        Console.WriteLine("Invalid choice. No discount applied.");
            //        cart.SetDiscountStrategy(new NoDiscount());
            //        break;
            //}

            //decimal finalAmount = cart.CalculateTotal(totalAmount);
            //Console.WriteLine($"Final amount after discount: {finalAmount}");                                             //20DiscountScheme
        }
        //private static void Button_OnClick()
        //{
        //    Console.WriteLine("Button was clicked!");
        //}//15.Button
    }
}
