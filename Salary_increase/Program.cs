using System;

namespace Salary_increase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary;

            Console.Write("Enter your salary:");
            salary = Convert.ToDouble(Console.ReadLine());

            if (salary < 0)
                Console.WriteLine("The salary can not be a negative number!");

            else if (salary <= 200)
                Console.WriteLine("You didn't get any raise in your salary, so your salary is: {0}", salary);

            else if (salary <= 400)
            {
                salary *= 1.2;
                Console.WriteLine("You got a 20% raise in your salary, so your salary is: {0}", salary);
            }

            else if (salary <= 600)
            {
                salary *= 1.3;
                Console.WriteLine("You got a 30% raise in your salary, so your salary is: {0}", salary);
            }
            else
            {
                salary *= 1.4;
                Console.WriteLine("You got a 40% raise in your salary, so your salary is: {0}", salary);
            }

            Console.ReadKey();
        }
    }
}
