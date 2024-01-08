using GenericRepo.Entities.Abstract;

namespace GenericRepo.Entities.Concrete
{
    public class Student : BaseEntity
    {
        public Student()
        {
            //Lessons = new HashSet<Lesson>();
        }
        public string ClassName { get; set; }
        public int? SchoolId { get; set; }
        public School School { get; set; }
        //public ICollection<Lesson> Lessons { get; set; }
        public ICollection<StudentLesson> StudentLessons { get; set; }
        
    }
}
