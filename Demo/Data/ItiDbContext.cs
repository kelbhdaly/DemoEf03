using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Demo.Contexts;
using Demo.Models;

namespace Demo.Data
{
    internal static class ItiDbContext
    {
        public static bool DataSeeding(ItiDb db)
        {
            try
            {
                if (!db.Employees.Any())
                {
                    var employeeData = File.ReadAllText("Files\\employees.json");
                    var Employees = JsonSerializer.Deserialize<List<Employee>>(employeeData);

                    if (Employees?.Count > 0)
                    {

                        //foreach (var employee in Employees)
                        //{
                        //    db.Employees.AddRange(employee);
                        //}

                        db.Employees.AddRange(Employees);
                        db.SaveChanges();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
