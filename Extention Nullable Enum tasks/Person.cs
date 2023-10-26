using Extention_Nullable_Enum_tasks.Helpers.BaseExtentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extention_Nullable_Enum_tasks
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person(string name,string surname)
        {
            Name = name;
            Surname = surname;  
        }

    }
}
