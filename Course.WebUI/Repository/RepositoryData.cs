using Course.WebUI.Models;

namespace Course.WebUI.Repository
{
    public class RepositoryData
    {
        private static List<Student> _students=new List<Student>();

        public static List<Student> Students
        {
            get { return _students; }
        }


        public static void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public static void RemoveStudent(Student student)
        {
            _students.Remove(student);
        }
    }
}
