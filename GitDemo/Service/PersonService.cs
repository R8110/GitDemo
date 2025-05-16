using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitDemo.Model;

namespace GitDemo.Service
{
    public class PersonService
    {
        public int CalculateAge(Person person)
        {
            if (person == null)
                throw new ArgumentNullException(nameof(person));

            var today = DateTime.Today;
            var age = today.Year - person.DateOfBirth.Year;
            if (person.DateOfBirth.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}
