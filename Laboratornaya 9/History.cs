using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_9
{
    public class History : Discipline, IHavePractice, IHaveFinalControll, IHaveAngryTeacher
    {
        public History(string nameDiscipline) 
        {
            NameDiscipline = nameDiscipline;
        }
        public int PracticeCount { get; set; }
        public int PassingScore { get; set; }
        public int angryTeacher {  get; set; }   
        public override string Check(Student student)
        {
            string itog = " ";
            if (angryTeacher == 1)
            {
                itog = "Этот препод не даёт автоматов!";
            }
            return itog;
        }
    }
}
