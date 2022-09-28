using Students_Registry_DEMO.Models;

namespace Students_Registry_DEMO.Data_Center
{
    internal class Database
    {
        private List<StudentModel> _students = new List<StudentModel>();

        public StudentModel GetStudent(int id)
        {
            if (id > 0 && _students.Count > 0)
            {
                foreach (var student in _students)
                {
                    if (student.Id == id)
                    {
                        return student;
                    }
                }
            }
            return null;

        }

        public StudentModel RegCheck(string email, string password)
        {
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password) && _students.Count > 0)
            {
                foreach (var student in _students)
                {
                    if (student.Email == email && student.Password == password)
                    {
                        return student;
                    }
                }
            }
            return null;
        }


        public bool AddStudent(StudentModel student)
        {
            if (student != null)
            {
                _students.Add(student);
                return true;
            }
            return false;
        }

        public List<StudentModel> GetAllStudents()
        {
            if (_students.Count == 0)
            {
                
            }
            return _students;

        }

        public bool RemoveStudent(int id)
        {
            if (id > 0 && _students.Count > 0)
            {
                foreach (var student in _students)
                {
                    if (student.Id == id)
                    {
                        return _students.Remove(student);
                    }
                }
            }
            return false;

        }

        public void ClearDatabase()
        {
            _students.Clear();
        }

        public int NoOfStudent()
        {
            return _students.Count;
        }
    }

}
