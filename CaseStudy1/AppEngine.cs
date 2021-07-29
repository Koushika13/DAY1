using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy1
{
    interface AppEngine
    {
        public void introduce(Course course);
        public void register(Student student);
        public List<Student> ListOfStudents();
        public void enroll(Student student, Course course);
        public List<Enroll> ListOfEnrollments();

    }
}
