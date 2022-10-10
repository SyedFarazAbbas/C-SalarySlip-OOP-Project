// Class Inheritance, Polymorphism ( Dynamic Polymorphism ) and Encapsulation have been used in this Program. 
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
            while (check) // While Loop will check whether correct number has been pressed or not
            {
                try
                {
                    Console.Write("Kindly Tell us your Designation by pressing corresponding number: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    if (a == 1)
                    {
                        SalarySlip s = new EngineerSalary(); // Creating EngineerSalary object.
                        Console.WriteLine(s.GetSalary());
                        Console.ReadLine();
                        break; // Terminate the Loop.
                    }
                    if (a == 2)
                    {
                        SalarySlip s = new ManagerSalary(); // Creating ManagerSalary object.
                        Console.WriteLine(s.GetSalary());
                        Console.ReadLine();
                        break; // Terminate the Loop.
                    }
                    if (a == 3)
                    {
                        SalarySlip s = new HrSalary();    // Creating HrSalary object.
                        Console.WriteLine(s.GetSalary());
                        Console.ReadLine();
                        break; // Terminate the Loop.
                    }
                    if (a != 1 && a != 2 && a != 3)
                    {
                        Console.WriteLine("Enter valid number PLEASE");
                    }

                }
                catch (System.Exception ) // It will handle error. if string is entered
                {
                    Console.WriteLine("You are either entering character, Special Character or string. Kindly Enter 1 0r 2 0r 3 number.");
                    
                    
                    
                    
                }
                

            }
            
            

            
        }
    }
    public class SalarySlip // Parent Class or Base Class.
    {
        public int baseSalary = 1500*12; // Making it for annual
        public virtual string GetSalary() // Virtual Method
        {
            return "Salaries";
            

        }
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
            return " The Annual Gross salary of Manager is " + Gsalary + " and Annual Net Salary is netSalary " + netSalary; // Result
            
            
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
