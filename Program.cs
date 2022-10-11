// Class Inheritance, Polymorphism ( Dynamic Polymorphism ), Abstraction and Encapsulation have been used in this Program. 
using System;
namespace MyNamespace
{
    public class MainProgram // Main Class that creates Objects 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Calculating Gross Salary Using OOP Concepts."); // Introduction of program.
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("-->\t 'WELCOME to Salary Calculate Software'\t <--");
            Console.WriteLine();

            Console.WriteLine("If your Engineer Press '1' on Keyboard"); // For user info
            Console.WriteLine("If your Manager Press '2' on Keyboard"); // For user info
            Console.WriteLine("If your HR Press '3' on Keyboard"); // For user info
            Console.WriteLine();
            bool check = true; // Defining variable.
            while (true) // While loop for multiple Use.
            {
                while (check) // While Loop will check whether correct number has been pressed or not
                {
                    try
                    {
                        Console.Write("Kindly Tell us your Designation by pressing corresponding number And Click 4 for exit: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        if (a == 1)
                        {
                            SalarySlip engineer = new EngineerSalary(); // Creating EngineerSalary object.
                            Console.WriteLine(engineer.GetSalary());
                            //Console.ReadLine();
                            break; // Terminate the Loop.
                        }
                        if (a == 2)
                        {
                            SalarySlip manager = new ManagerSalary(); // Creating ManagerSalary object.
                            Console.WriteLine(manager.GetSalary());
                            //Console.ReadLine();
                            break; // Terminate the Loop.
                        }
                        if (a == 3)
                        {
                            SalarySlip hr = new HrSalary();    // Creating HrSalary object.
                            Console.WriteLine(hr.GetSalary());
                            //Console.ReadLine();
                            break; // Terminate the Loop.
                        }
                        if (a != 1 && a != 2 && a != 3 && a != 4)
                        {
                            Console.WriteLine("Enter valid number PLEASE");
                        }
                        if (a == 4)
                        {
                            Console.WriteLine("Software has been closed Successfully!!!");
                            check = false;

                        }
                        //break; // Terminating First While loop to exit 

                    }
                    catch (System.Exception) // It will handle error. if string is entered
                    {
                        Console.WriteLine("You are either entering character, Special Character or string. Kindly Enter 1 0r 2 0r 3 number.");
                    }
                }
            }
        }
    }
 abstract public class SalarySlip // Parent Class or Base Class.
    {
        public int baseSalary = 1500*12; // Making it for annual
        abstract public string GetSalary(); // Virtual Method
      
    }
    public class EngineerSalary : SalarySlip  // Child Class ( Class inheritance).
    {
        private int annuallyPaid = 7000;
        public override string GetSalary() // Dynamic Polymorphism.
        {
            int Esalary = baseSalary + annuallyPaid;
            return "Annual Gross Salary of Engineer is $ " + Esalary; // Result
            
        }
        
    }
    public class ManagerSalary : SalarySlip // Child Class ( Class inheritance).
    {
        private int fuel = 250*12; // Making it for annual
        private int medical = 1000*12; // Making it for annual
        public override string GetSalary() //  Dynamic Polymorphism.
        {
            int Gsalary = baseSalary+ fuel + medical;
            int taxDeduct = Gsalary * 17/100;
            int netSalary = Gsalary - taxDeduct;
            return " The Annual Gross salary of Manager is $" + Gsalary + " and Annual Net Salary is netSalary $" + netSalary; // Result
            
            
        }
    }
    public class HrSalary : SalarySlip // Child Class ( Class inheritance).
    {
        private int fuel = 150*12; // Making it for annual
        private int medical = 800*12; // Making it for annual
        public override string GetSalary() // Dynamic Polymorphism.
        {
            int salaryHr = baseSalary + fuel + medical;
            int telephonic = (fuel + medical) * 10/100;
            int HrTotalSalary = salaryHr +telephonic;
            return " Total annual Gross Salary of HR is $ "+HrTotalSalary;  // Result

            
        }
    }
}
---------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class Candidate
    {
        public string name;
        public double cgpa;
        int age;
        string city;
        int num;
        

        public Candidate(string Name, double Cgpa, int Age, string City, int Num)
        {
            name = Name;
            cgpa = Cgpa;
            age = Age;
            city = City;
            num = Num;

        }
        public string getInfo()
        {
            
            return ("Name of Candidate is: "+name +". Cgpa is: "+ cgpa +". Age of Candidate is: " +age+" "+". Candidate resides in "+city+ "Score of Candidate "+num );

        }
        



    }
    public class Document
    {

    }
    class Program
    {
        static public void Main(string[] args)
        {
            List<Candidate> list = new List<Candidate>();
            List<String> list2 = new List<string>();
            Dictionary<string, double> cgpaNames = new Dictionary<string, double>();
            int count = 0;
            int count2 = 0; 
            while (count<2)
            {
                Console.Write("Enter your Name: ");
                string n = Console.ReadLine();
                Console.Write("Enter your CGPA: ");
                double c = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter your Age: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter your City: ");
                string cc = Console.ReadLine();
                Random rnd = new Random();
                int nm = rnd.Next(1,100);

                Candidate x = new Candidate(n, c, a, cc,nm);
                Console.WriteLine(x.getInfo());
                count += 1;
                list.Add(x);
                //

            }
            for ( count2 = 0; count2 < 2; count2++ )
            {

                //Console.WriteLine(list[count2].name);
                
                cgpaNames.Add(list[count2].name,list[count2].cgpa);
               
                //if (list[count2].cgpa >= 3)
                //{
                 //   list2.Add(list[count2].name);
                //}




            }
            foreach (KeyValuePair<string, double> z in cgpaNames)
            {
                if (z.Value >= 3)
                {
                    list2.Add(z.Key);

                };

            }
            
            for (int j = 0; j < list2.Count; j++)
            {

              Console.WriteLine(list2[j]);
           }
           Console.ReadLine();



            


        }
    }
}
