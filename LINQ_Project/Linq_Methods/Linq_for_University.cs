using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Project.Linq_Methods
{
    public class Linq_for_University
    {
        public List<University> GetAll()
        {
            List<University> list = new List<University>()
            {
                new University { Id = 1, Name = "Harvard", Location = "USA", Students  =
                new List<Students>() {
                    new Students() { Id = 1, Age = 27,  FirstName = "Asadulloh", LastName = "Tojiyev", isBudget = true },
                    new Students() { Id = 2, Age = 20, FirstName = "Elyorbek", LastName = "Temirov", isBudget = true },
                    new Students() { Id = 3, Age = 23, FirstName = "Hayotillo", LastName = "Tursunboyev", isBudget = false },
                    new Students() { Id = 4, Age = 40, FirstName = "Tohirjon", LastName = "Odilov", isBudget = false },
                } },
                new University { Id = 2, Name = "MIT", Location = "Massachusets", Students  =
                new List<Students>() {
                    new Students() { Id = 1, Age = 30, FirstName = "John", LastName = "Doe", isBudget = true },
                    new Students() { Id = 2, Age = 17, FirstName = "John", LastName = "Smith", isBudget = false },
                    new Students() { Id = 3, Age = 20, FirstName = "Muhammad Abdulloh", LastName = "Ummataliyev", isBudget = true },
                    new Students() { Id = 4, Age = 31, FirstName = "Ibrohim", LastName = "Qosimov", isBudget = false },
                } },

            };

            return list;
        }

        public IEnumerable<string> GetAllUniversity()
        {
            var universities = GetAll().Select(x => x.Name);

            return universities;
        }

        public IEnumerable<University> GetUniversityByName(string name)
        {
            var universities = GetAll().Select(x => x).Where(z => z.Name == name);

            return universities;
        }

        public IEnumerable<Students> GetUniversityByNameWithBudget()
        {
            var result = GetAll().Where(x => x.Name == "Harvard").SelectMany(x => x.Students).Where(z => z.isBudget == false);

            return result;
        }

    }
}
