using LINQ_Project.Linq_Methods;

namespace LINQ_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Linq_for_University data = new Linq_for_University();
            //foreach (var item in data.GetCenterByName("Najot Ta'lim"))
            //{
            //    var empoyees = item.Employees.Select(x => x).Where(z => z.Experience > 5);
            //    Console.WriteLine(item.Name);
            //    foreach(var employee in empoyees)
            //    {
            //        Console.WriteLine(employee.FirstName + " " + employee.LastName);
            //    }
            //}

            foreach (var item in data.GetUniversityByNameWithBudget())
            {
                Console.WriteLine(item.FirstName + " " + item.isBudget);
            }


        }
    }
}