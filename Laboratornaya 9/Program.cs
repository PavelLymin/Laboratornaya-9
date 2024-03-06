using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Laboratornaya_9
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Discipline> disciplines = new List<Discipline>();
            Programming discipline1 = new Programming("Программирование");
            MathematicalAnalysis discipline2 = new MathematicalAnalysis("Математический анализ");
            History discipline3 = new History("История");
            disciplines.Add(discipline1);
            disciplines.Add(discipline2);
            disciplines.Add(discipline3);

            List<Student> students = new List<Student>();
            Student student1 = new Student 
            { 
                Name = "Артемий", 
                Practices = new Dictionary<Discipline, int> 
                { 
                    { disciplines[0], 10 } 
                },
                FinalControll = new Dictionary<Discipline, int>
                {
                    { disciplines[1], 10 }
                }
            };
            Student student2 = new Student
            {
                Name = "Екатерина",
                Practices = new Dictionary<Discipline, int>
                {
                    { disciplines[0], 10 }                    
                },
                FinalControll = new Dictionary<Discipline, int>
                {
                    { disciplines[1], 10 }
                }
            };
            Student student3 = new Student
            {
                Name = "Александр",
                Practices = new Dictionary<Discipline, int>
                {
                    { disciplines[0], 10 }
                },
                FinalControll = new Dictionary<Discipline, int> 
                {
                    { disciplines[1], 8 }
                }
            };
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            discipline1.PracticeCount = 10;
            discipline2.PassingScore = 10;
            discipline3.PassingScore = 5;
            discipline3.PracticeCount = 10;
            discipline3.angryTeacher = 1;

        
            foreach (var discipline in disciplines)
            {
                Console.WriteLine(discipline.NameDiscipline);
                Console.WriteLine("---------------------");
                foreach (var stut in students)
                {
                    if (discipline is IHaveAngryTeacher)
                    {
                        Console.WriteLine(discipline.Check(stut));
                        break;
                    }
                    else
                    {
                        Console.WriteLine(stut.Name);
                        Console.WriteLine(discipline.Check(stut));
                    }
                   

                }
                Console.WriteLine();
            }
        }
    }
}
