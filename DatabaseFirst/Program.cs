using DatabaseFirst.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Example01
            //using NorthwindDbContexts dbContexts = new NorthwindDbContexts();
            //var ProductsName = dbContexts.Products.ToList();
            //foreach (var item in ProductsName)
            //    Console.WriteLine(item.ProductName);


            //using MyNorthwindDbContext dbContexts = new MyNorthwindDbContext();
            //var employees = dbContexts.Employees.ToList();
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine($"Employee ID: {employee.EmployeeId}, Name: {employee.FirstName} {employee.LastName}");
            //} 
            #endregion



            using MyNorthwindDbContext dbContext = new MyNorthwindDbContext();

            #region Select Statment
            //var Result = dbContext.Products.FromSqlRaw("Select * From Products where CategoryId=1");
            //int CatId = 1;
            // Result = dbContext.Products.FromSqlInterpolated($"Select * From Products where CategoryId={CatId}");

            //foreach (var item in Result)
            //    Console.WriteLine(item.ProductName); 
            #endregion

            #region DML
            //var Result = dbContext.Database.ExecuteSqlRaw("update  Products set ProductName='Coffee' where ProductID = 1 ");
            //Console.WriteLine(Result);


            //Result = dbContext.Database.ExecuteSqlInterpolated($"delete from Products where ProductID =90");
            //Console.WriteLine(Result);
            #endregion


            MyNorthwindDbContextProcedures dbContextProcedures = new MyNorthwindDbContextProcedures(dbContext);
           var custOrders = dbContextProcedures.CustOrderHistAsync("ALFKI").Result;
        }
    }
}
