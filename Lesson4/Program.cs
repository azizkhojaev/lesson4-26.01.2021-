using System;

namespace Lesson4
{
    class Homework1
    {
        public void Task1()
        {
            Console.Write("Enter first side of Rectangle ");
            var a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second side of Rectangle ");
            var b = Convert.ToDouble(Console.ReadLine());

            var rectangle = new Rectangle(Side1: a, Side2: b);

            Console.WriteLine("Area of Rectangle is " + rectangle.Area);
            Console.WriteLine("Perimeter of Rectangle is " + rectangle.Perimeter);

        }
        public void Task2()
        {
            Console.Write("Enter you Book name " );
            var name = Console.ReadLine();
            Console.Write("Enter Author of the book ");
            var author = Console.ReadLine();
            Console.Write("Enter a Content for your book " );
            var content = Console.ReadLine();

            var Book = new Book(nameofbook: name, authorofbook: author, contentbook: content);
            Book.ShowBookInformation(); 
        }
        public void Task3()
        {
            var person = new Person(); 
            Console.WriteLine("We have made Class Person ");
            Console.Write("Enter Persons full name: ");
            person.pname = Console.ReadLine();
            Console.Write("Enter Persons age: ");
            person.page = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Persons gender: ");
            person.pgender = Console.ReadLine();
            Console.Write("Enter Persons Weight: ");
            person.pweight = Convert.ToInt32(Console.ReadLine());
            person.PersonShow(); 
        }


    }
    class Homework2
    {
        public void Task1()
        {
            Console.Write("What is value of USD for 10 somoni " );
            var USD = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is value of RUS for 10 somoni ");
            var RUS = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is value of EUR for 10 somoni ");
            var EUR = Convert.ToDouble(Console.ReadLine());

            var converter = new Converter(Usd: USD, Rus: RUS, Eur: EUR);

            Console.Write("enter your amount of money ");
            var money = Convert.ToDouble(Console.ReadLine());
            money /= 10;
            Console.Write("Enter your currency [RUS, EUR, USD, TJS] ");
            var s1 = Console.ReadLine();
            Console.Write("TO which currency you want to change your money [RUS, EUR, USD, TJS] ");
            var s2 = Console.ReadLine();

            if (s1 == "TJS" && s2 == "RUS")
                converter.TJStoRUS(money);
            else if (s1 == "TJS" && s2 == "USD")
                converter.TJStoUSD(money);
            else if (s1 == "TJS" && s2 == "EUR")
                converter.TJStoEUR(money);
            else if (s1 == "USD" && s2 == "TJS")
                converter.USDtoTJS(money);
            else if (s1 == "EUR" && s2 == "TJS")
                converter.EURtoTJS(money);
            else if (s1 == "RUS" && s2 == "TJS")
                converter.RUStoTJS(money);
            else
                Console.WriteLine("We are sorry we can't convert you money! [:waint for updates:] ");
           


        }
        public void Task2()
        {
            Console.Write("enter your Emploer name ");
            var ename = Console.ReadLine();
            Console.Write("Enter you Emploer surname ");
            var esurname = Console.ReadLine();
            Console.Write("Enter you Emploer position name " );
            var eposition = Console.ReadLine();
            Console.Write("Enter you Emploer position rank 1 to 5 ");
            var epositionrank = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter you Emploer experience in year ");
            var experience = Convert.ToInt32(Console.ReadLine());

            var emploee = new Emploee(Name: ename, Surname: esurname, Position: eposition, PositionRank: epositionrank, Experience: experience);
            emploee.ShowSalary(); 

        }
        
    }
    
   
    class Program
    {
        static void Main(string[] args)
        {
            var DZ1 = new Homework1();
            var DZ2 = new Homework2(); 

            DZ1.Task2();

            //DZ2.Task2(); 
            

        }
    }


    class Rectangle
    {
        public double side1 { get; set;}
        public double side2 { get; set;}
        public double Area
        {
            get
            {
                return AreaCalculator(); 
            }
        }
        public double Perimeter
        {
            get
            {
                return PerimeterCalculator(); 
            }
        }

        public Rectangle(double Side1, double Side2)
        {
            side1 = Side1;
            side2 = Side2;
        }

        public double AreaCalculator()
        {
            var A = side1 * side2;
            return A;
        }
        public double PerimeterCalculator()
        {
            var P = (side1 + side2) * 2;
            return P;
        }
    }
    class Book
    {
        NameofBook NameofBook = new NameofBook();
        Author Author = new Author();
        Content Content = new Content();
        public Book(string nameofbook, string authorofbook, string contentbook)
        {            
            NameofBook.bookname = nameofbook;            
            Author.authorofbook = authorofbook;           
            Content.content = contentbook;
        }
        public void ShowBookInformation()
        {
            NameofBook.NameShow();
            Author.AuthorShow();
            Content.ContentShow(); 
        }


       
    }
    class NameofBook
    {
        public string bookname { get; set; }

        public void NameShow()
        {
            Console.Write("Book name : ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(bookname);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
    class Author
    {
        public string authorofbook { get; set; }
        public void AuthorShow()
        {
            Console.Write("Author is : ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(authorofbook);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class Content
    {
        public string content { get; set; }
        public void ContentShow()
        {
            Console.WriteLine("Content : ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("         "+content);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class Converter
    {
        public double usd { get; set; }
        public double rus { get; set; }
        public double eur { get; set; }

        public Converter(double Usd, double Rus, double Eur)
        {
            usd = Usd;
            rus = Rus;
            eur = Eur; 
        }

        public void TJStoUSD(double x)
        {
            var ans = x*usd;
            Console.WriteLine(x+ " somoni = "+ ans+ " Dollar");
        }
        public void TJStoRUS(double x)
        {
            var ans = x * rus;
            Console.WriteLine(x + " somoni = " + ans + " Rubles");

        }
        public void TJStoEUR(double x)
        {
            var ans = x * eur;
            Console.WriteLine(x + " Somoni = " + ans + " EURO");

        }
        public void USDtoTJS(double x)
        {
            var ans = x / 10;
            ans *= usd; 
            Console.WriteLine(x + " Dollar = " + ans + " Somoni");
        }
        public void RUStoTJS(double x)
        {
            var ans=x/10;
            ans *= rus; 

            Console.WriteLine(x + " Rubles = " + ans + " Somoni");
        }
        public void EURtoTJS(double x)
        {
            var ans = x/10;
            ans *= eur; 
            Console.WriteLine(x + " EURO = " + ans + " Somoni");
        }
    }
    class Emploee
    {
        public string  name  { get; set; }
        public string  surname  { get; set; }
        public string  position { get; set; }
        public int positionrank { get; set; }
        public int experience { get; set; }
        public Emploee (string Name , string Surname, string Position, int PositionRank, int Experience)
        {
            name = Name;
            surname = Surname;
            position = Position;
            positionrank = PositionRank;
            experience = Experience; 
        }
        public double SalaryCounter()
        {
            var salary = 2000.0; // its minimun amount money everyone will achive; 
        
            if (positionrank > 0 && positionrank < 6)
                salary += 500 * positionrank;  // one step is 500 $

            if (experience > 2 && experience < 5)
                salary += 400;
            if (experience > 4 && experience < 8)
                salary += 800;
            else if (experience > 7)
                salary += 1000;

            return salary; 

        }
        public double TaxPansion()
        {
            var tax = SalaryCounter();
            tax = (tax * 14) / 100; 
            return tax;
        }
        public void ShowSalary()
        {
            Console.WriteLine(surname+ " " +name +" is a "+ position+"!");
            Console.WriteLine(name + " your salary is " + SalaryCounter()+ "$" ); 
            Console.WriteLine("You have to pay 14% tax it will be "+TaxPansion() + "$");
            var salary = SalaryCounter()- TaxPansion();
            Console.WriteLine("Salar " + SalaryCounter() + " - Tax and Pansion found " + TaxPansion()+ " = " + salary +"$");
            Console.WriteLine("You will be payed  " + salary + "$");
        }

    }
    class Person
    {
        public string pname;
        public int page;
        public string pgender;
        public int pweight;

        public void PersonShow()
        {
            Console.WriteLine(pname +" is "+page+" years old. ");

            Console.WriteLine(pname + " is "+pgender+" and He/She is "+pweight+"KG");
        }
    }


 
}
