using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.InheritanceInterfaceAbstraction.Student
{
    internal class DailyStudent : Person
    {

        public DailyStudent(string name, string lastName, int age, int personalID, bool daily) 
            : base(name,lastName,age,personalID, daily)
        {
        }


    }
}
