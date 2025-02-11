using System.Collections.Generic;
using Tasks.HelpClasses;

namespace Tasks
{
    public class Task4
    {
        /*
         * Desenvolva um método que retorne todos os estudantes do Repositório que nasceram em 2020      
         * Dica: A classe Repository possui as informções dos Students
         */
        public static List<Student> GetStudentsByBirth() 
        {
       
        List<Student> students = Repository.GetStudents();

        
        return students.Where(s => s.BirthDate.Year == 2020).ToList();
     }
    }
}
