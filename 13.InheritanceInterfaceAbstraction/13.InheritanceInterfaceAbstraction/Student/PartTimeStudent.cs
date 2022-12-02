using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.InheritanceInterfaceAbstraction.Student
{
    internal class PartTimeStudent : Person
    {
        private decimal Tuition;

        public PartTimeStudent(string name, string lastName, int age, int personalID, decimal tuition, bool daily)
            : base(name, lastName, age, personalID, daily)
        {
            Tuition = tuition;
        }


    }
}
