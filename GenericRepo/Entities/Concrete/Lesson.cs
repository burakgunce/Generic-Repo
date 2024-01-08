using GenericRepo.Entities.Abstract;

namespace GenericRepo.Entities.Concrete
{
    public class Lesson : BaseEntity
    {
        public Lesson()
        {
            //Students = new HashSet<Student>();
        }
        public int Credit { get; set; }
        public int SchoolId { get; set; }
        public School School { get; set; }
        //public ICollection<Student> Students { get; set; }
        public ICollection<StudentLesson> StudentLessons { get; set; }
    }
}
