using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_9
{
    public class Programming : Discipline, IHavePractice
    {
        //public new string NameDiscipline { get; set; }
        public Programming(string nameDiscipline) 
        {
            NameDiscipline = nameDiscipline;
        }
        public int PracticeCount { get; set; }
        public override string Check(Student student)
        {
            string itog = " ";

            if (student.Practices[this] >= PracticeCount)
            {
                itog = "Получает достаточный балл на итоговой аттестации и может рассчитывать на автомат";
            }
            else
            {
                itog = "Не получает достаточный балл на итоговой аттестации и может не рассчитывать на автомат";
            }
            return itog;
        }
    }
}
