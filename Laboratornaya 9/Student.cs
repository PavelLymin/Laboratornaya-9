using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_9
{
    public class Student
    {
        public string Name { get; set; }

        public Student(string name)
        {
            name = Name;
        }
        public Dictionary<Discipline, int> Practices { get; set; }

        public Dictionary<Discipline, int> FinalControll { get; set; }

        public Student() 
        {
            Practices = new Dictionary<Discipline, int>();
            FinalControll = new Dictionary<Discipline, int>();
        }
    }
}
