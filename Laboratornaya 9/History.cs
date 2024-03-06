using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_9
{
    public class History : Discipline, IHavePractice, IHaveFinalControll, IHaveAngryTeacher
    {
        //public new string NameDiscipline { get; set; }
        public History(string nameDiscipline) 
        {
            NameDiscipline = nameDiscipline;
        }
        public int PracticeCount { get; set; }
        public int PassingScore { get; set; }
        public int angryTeacher {  get; set; }   
        public override string Check(Student student)
        {
            //foreach (var pr in student.Practices)
            //{
            //    foreach (var contr in student.FinalControll)
            //    {
            //        if (pr.Value >= PracticeCount && contr.Value >= PassingScore)
            //        {
            //            itog = "Получает достаточный балл на итоговой аттестации и может рассчитывать на автомат";
            //        }
            //        else if ((pr.Value < 2 && contr.Value < 65) || (pr.Value < 2 || contr.Value < 65))
            //        {
            //            itog = "Не получает достаточный балл на итоговой аттестации и не может рассчитывать на автомат";
            //        }
            //        break;
            //    }
            //}
            string itog = " ";
            if (angryTeacher == 1)
            {
                itog = "Этот препод не даёт автоматов!";
            }
            return itog;
        }
    }
}
