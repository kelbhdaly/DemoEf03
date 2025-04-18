using Inheritance.Contexts;
using Inheritance.Models;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using MyCompanyDbContext dbContext = new MyCompanyDbContext();

            #region Iheritance Mapping
            //FulltimeEmployee fulltimeEmployee = new FulltimeEmployee()
            //{
            //    Name = "Soha",
            //    Age = 25,
            //    Address = "Cairo",
            //    Salary = 20_000,
            //    StartDate = DateTime.Now,
            //};
            //ParttimeEmployee parttimeEmployee = new ParttimeEmployee()
            //{
            //    Name = "Amr",
            //    Age = 30,
            //    Address = "Giza",
            //    HourRate = 100,
            //    CountOfHours = 30
            //};

            ////dbContext.Employees.Add(fulltimeEmployee); // Understand Will Add In Table FullTimeEmployee
            ////dbContext.FulltimeEmployees.Add(fulltimeEmployee); // Understand Will Add In Table FullTimeEmployee
            //dbContext.Add(fulltimeEmployee); // Understand Will Add In Table FullTimeEmployee
            //dbContext.Add(parttimeEmployee); // Understand Will Add In Table parttimeEmployee

            //dbContext.SaveChanges();


            //var Employees = from E in dbContext.Employees
            //                select E;
            //if (Employees is not null)
            //{

            //    foreach (var item in Employees.OfType<FulltimeEmployee>())
            //    {
            //        Console.WriteLine($"{item.Name} : {item.Address} : {item.Salary}");


            //    }
            //    Console.WriteLine("=============================");

            //    foreach (var item in Employees.OfType<ParttimeEmployee>())
            //    {
            //        Console.WriteLine($"{item.Name} : {item.Address} : {item.HourRate}");


            //    }
            //} 


            //var FTEmployee = dbContext.FulltimeEmployees.FirstOrDefault();
            //if (FTEmployee is not null)
            //{
            //    Console.WriteLine($"{FTEmployee.Name} :: {FTEmployee.Age} :: {FTEmployee.Address}  ");
            //}

            //var PTEmployee = (from BTE in dbContext.ParttimeEmployees
            //                                          select BTE).FirstOrDefault();

            //if (PTEmployee is not null)
            //{
            //    Console.WriteLine($"{PTEmployee.Name} :: {PTEmployee.Age} :: {PTEmployee.Address}  ");
            //}
            #endregion

            #region Local


            //var employee = dbContext.Employees.First();
            //if (employee != null)
            //{
            //    Console.WriteLine(employee.Age);
            //    employee.Age = null; 
            //    Console.WriteLine(employee.Age);
            //}


            //var Result = dbContext.Employees.Local.Any(E=>E.Age ==null);
            //Console.WriteLine(Result); //False
            #endregion


        }
    }
}
