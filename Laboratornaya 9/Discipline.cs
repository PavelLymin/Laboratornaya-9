using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_9
{
    public abstract class Discipline
    {
        public string NameDiscipline { get; set; }

        public Student student { get; set; } 

        public abstract string Check(Student student);

    }
}
