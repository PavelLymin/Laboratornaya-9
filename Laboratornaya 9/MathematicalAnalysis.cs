using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_9
{
    public class MathematicalAnalysis : Discipline, IHaveFinalControll
    {
        //public new string NameDiscipline { get; set; }
        public MathematicalAnalysis(string nameDiscipline)
        {
            NameDiscipline = nameDiscipline;
        }

        public int PassingScore { get; set; }

        public override string Check(Student student)
        {
            string itog = " "; 
            if (student.FinalControll[this] >= PassingScore)
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
