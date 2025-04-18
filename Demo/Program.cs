using System.Linq;
using System.Text.RegularExpressions;
using Demo.Contexts;
using Demo.Data;
using Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ItiDb ItiDB = new ItiDb();

            #region DataSeeding

            #region DataSeedingManual
            //Department department = new Department()
            //{
            //    Name = "HR" , HiringDate= DateTime.Now
            //};

            //List<Department> departments = new List<Department>()
            //{
            //    new Department(){Name = "Iti" , HiringDate = new DateTime(2024 , 5 ,23)},
            //    new Department(){Name = "Development" , HiringDate = new DateTime(2025 , 1 ,23)}
            //};

            //ItiDbContext.Set<Department>().AddRange(departments);
            //ItiDbContext.SaveChanges();

            #endregion
            //Department department = new Department()
            //{

            //    Name = "Test",

            //};
            //ItiDB.Set<Department>().Add(department);
            //ItiDB.SaveChanges();
            #region Dynamic DataSeeding


            //bool Flag = ItiDbContext.DataSeeding(ItiDB);
            //if (Flag)
            //    Console.WriteLine("Done");
            //else
            //    Console.WriteLine("Not Added");

            #endregion




            #endregion



            #region Loading Related Data

            #region Example01
            //var Emp01 = ItiDB.Employees.FirstOrDefault(E => E.EmpId == 5);

            //if (Emp01 is not null)
            //{
            //    Console.WriteLine($"Employee Name:{Emp01.EmpName} ");
            //    Console.WriteLine($"Department Id:{Emp01.DepartmentId} ");
            //    var EmpDepartment = (from D in ItiDB.Set<Department>()
            //                         where D.DeptID == Emp01.DepartmentId
            //                         select D).FirstOrDefault();
            //    Console.WriteLine($"Department Name :{EmpDepartment?.Name} ");

            //}  
            #endregion

            #region Eager Loading
            //var Emp01WithDepartment = ItiDB.Employees.Include(E => E.Department).FirstOrDefault(E => E.EmpId == 6);

            //if (Emp01WithDepartment is not null)
            //{
            //    Console.WriteLine($"Employee Name:{Emp01WithDepartment.EmpName} ");
            //    Console.WriteLine($"Department Id:{Emp01WithDepartment.DepartmentId} ");

            //    Console.WriteLine($"Department Name :{Emp01WithDepartment.Department?.Name} ");

            //}



            //var EmployeeWithManger = ItiDB.Employees.Include(E => E.Department)
            //                                                                .ThenInclude(D =>D.Manager)
            //                                                                .FirstOrDefault(E => E.EmpId == 5);
            //if (EmployeeWithManger is not null)
            //{
            //    Console.WriteLine($"Employee Name:{EmployeeWithManger.EmpName} ");
            //    Console.WriteLine($"Department Id:{EmployeeWithManger.DepartmentId} ");

            //    Console.WriteLine($"Department Name :{EmployeeWithManger.Department?.Name} ");

            //}

            //var Employee = ItiDB.Employees.Include(E => E.Department)
            //    .Where(E => E.Department.Name == "HR")
            //    .Select(E => new
            //    {
            //        EmployeeName = E.EmpName,
            //        DepartmentName = E.Department.Name,
            //    });
            //if (Employee is not  null )
            //{
            //    foreach(var item in Employee)
            //        Console.WriteLine(item);
            //}

            #endregion

            #region Explicit Data Loading

            #region Example 1

            //var employee = ItiDB.Employees.FirstOrDefault(E => E.EmpId == 5);
            //if (employee is not null)
            //{
            //    Console.WriteLine($"Employee Name = {employee.EmpName} ");
            //    Console.WriteLine($"Department Id = {employee.DepartmentId} ");
            //    ItiDB.Entry(employee).Reference(E => E.Department).Load();
            //    Console.WriteLine($"Department Name = {employee.Department?.Name}");
            //}

            #endregion

            #region Example 2 

            //var Department01 = ItiDB.Set<Department>().FirstOrDefault(D => D.DeptID == 10);

            //if (Department01 != null)
            //{
            //    Console.WriteLine($"Department Name = {Department01.Name}");
            //    ItiDB.Entry(Department01).Collection(D => D.Employees).Query().Where(E=>E.Age >25).Load();
            //    foreach (var employee in Department01.Employees) 
            //    Console.WriteLine($"Employee Name = {employee.EmpName}");
            //}

            #endregion
            #endregion


            #region Lazy Data Loading

            //var emp = ItiDB.Employees.FirstOrDefault(E => E.EmpId == 5);
            //if (emp is not null)
            //{
            //    Console.WriteLine($"Employee Name ={emp.EmpName}");
            //    Console.WriteLine($"Department Id = {emp.DepartmentId} ");
            //       Console.WriteLine($"Department Name = {emp.Department?.Name}");
            //}
            #endregion
            #endregion



            #region Join Operators

            #region Inner Join - Join()

            #region Department That Has Employee
            //var Result = ItiDB.Set<Department>().Join(ItiDB.Employees
            //                                            , D => D.DeptID
            //                                            , E => E.DepartmentId
            //                                           , (D, E) => new
            //                                           {
            //                                               EmployeeId = E.EmpId,
            //                                               EmployeeName = E.EmpName,
            //                                               DepartmentId = D.DeptID,
            //                                               DepartmentName = D.Name
            //                                           });


            //var Result = from D in ItiDB.Set<Department>()
            //             join E in ItiDB.Employees
            //             on D.DeptID equals E.DepartmentId
            //             select
            //             new
            //             {
            //                 EmployeeId = E.EmpId,
            //                 EmployeeName = E.EmpName,
            //                 DepartmentId = D.DeptID,
            //                 DepartmentName = D.Name

            //             };

            //foreach (var item in Result)
            //{

            //    Console.WriteLine(item);
            //}

            #endregion


            #endregion


            #region Gruop Join ()
            //var Result = ItiDB.Set<Department>().GroupJoin(ItiDB.Employees,
            //                                           D => D.DeptID,
            //                                           E => E.DepartmentId,
            //                                           (D , Employees) => 
            //                                           new
            //                                           {
            //                                               Department = D,
            //                                               Employee = Employees
            //                                           }).Where(R=>R.Employee.Count() > 2);

            //var Result = from Dept in ItiDB.Set<Department>()
            //          join Emp in ItiDB.Employees
            //          on Dept.DeptID equals Emp.DepartmentId into Groups
            //          select new
            //          {
            //              Department = Dept,
            //              Employee = Groups
            //          } into Group 
            //          where Group.Employee.Count()>2
            //          select Group;





            //var Result = ItiDB.Set<Department>().GroupJoin(
            //                                                                    ItiDB.Employees,
            //                                                                    D => D.DeptID,
            //                                                                    E => E.DepartmentId,
            //                                                                    (D, E) => new
            //                                                                    {
            //                                                                        Department = D,
            //                                                                        Employee = E
            //                                                                    }).Where(R=>R.Employee.Count()>2);

            //Result = from D in ItiDB.Set<Department>()
            //         join E in ItiDB.Employees
            //         on D.DeptID equals E.DepartmentId into Groups
            //         select new
            //         {
            //             Department = D,
            //             Employee = Groups
            //         } into Group
            //         where Group.Employee.Count()>2
            //         select Group;




            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"DepartmentId = {item.Department.DeptID} , DepartmentName = {item.Department.Name} ");
            //    foreach (var emp in item.Employee)
            //    {
            //        Console.WriteLine($"==========={emp.EmpName}");
            //    }
            //}
            #endregion


            #region Left Outer Join ()
            #region Example 01
            //var Result = ItiDB.Set<Department>().GroupJoin(
            //                                       ItiDB.Employees,
            //                                       D => D.DeptID,
            //                                       E => E.DepartmentId,
            //                                       (Dept, Employees) => new
            //                                       {
            //                                           Department = Dept,
            //                                           Employees
            //                                       }
            //                                       ).Select(R => R.Department);
            //Result = from D in ItiDB.Set<Department>()
            //         join E in ItiDB.Employees
            //         on D.DeptID equals E.DepartmentId into EmployeeGroups
            //         select new
            //         {
            //             Department = D,
            //             Employees = EmployeeGroups
            //         } into Groups
            //         select Groups.Department;
            ////foreach (var item in Result)
            ////{
            ////    Console.WriteLine($"{item.Department.DeptID} , {item.Department.Name}");
            ////    foreach (var Emp in item.Employees)
            ////    {
            ////        Console.WriteLine($"{Emp.EmpName}");
            ////    }
            ////}

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"----------- {item.Name}");
            //} 
            #endregion

            #region Example 02
            //var Result = ItiDB.Set<Department>().GroupJoin(
            //                                      ItiDB.Employees,
            //                                      D => D.DeptID,
            //                                      E => E.DepartmentId,
            //                                      (D, E) => new
            //                                      {
            //                                          Department = D,
            //                                          Employees = E
            //                                      }).SelectMany(R => R.Employees);


            ////Result = from D in ItiDB.Set<Department>()
            ////         join E in ItiDB.Employees
            ////         on D.DeptID equals E.DepartmentId
            ////         into Employeegroup
            ////         select new
            ////         {
            ////             Department = D,
            ////             Employees = Employeegroup,
            ////         } into Groups
            ////         from Emp in Groups.Employees
            ////         select Emp; 
            #endregion

            #region Example 03 
            // var Result = ItiDB.Set<Department>().GroupJoin(
            //                                       ItiDB.Employees,
            //                                       D => D.DeptID,
            //                                       E => E.DepartmentId,
            //                                       (D, E) => new
            //                                       {
            //                                           Department = D,
            //                                           Employees = E
            //                                       }).SelectMany(R => R.Employees.DefaultIfEmpty(),
            //                                       (R, Emp) => new
            //                                       {
            //                                           DepartmentId = R.Department.DeptID,
            //                                           DepartmentName = R.Department.Name,
            //                                           EmployeeName = Emp != null ? Emp.EmpName : "No Employee"
            //                                       });

            //var  Result02 = from D in ItiDB.Set<Department>()
            //          join E in ItiDB.Employees
            //          on D.DeptID equals E.DepartmentId into EmployeeGroup
            //          select new
            //          {
            //              Department = D,
            //              Employees = EmployeeGroup.DefaultIfEmpty()
            //          } into Group
            //          from E in Group.Employees
            //          select new
            //          {
            //              DepartmentName = Group.Department.Name,
            //              DepartmentId = Group.Department.DeptID,
            //              EmployeeName = E != null ? E.EmpName : "No Employee"
            //          };

            // foreach (var item in Result02)
            // {
            //     Console.WriteLine($"{item}");
            // }

            #endregion

            #region Cross join

            var Result = from D in ItiDB.Set<Department>()
                         from e in ItiDB.Employees
                         select new
                         {
                             e.EmpName,
                             D.Name
                         };
            foreach (var item in Result)
            {
            Console.WriteLine(item);
                
            }
            #endregion
            #endregion

            #endregion
        }
    }
}
