using GenericRepo.Entities.Abstract;

namespace GenericRepo.Entities.Concrete
{
    public class School : BaseEntity
    {
        public School()
        {
            Students = new HashSet<Student>();
            Lessons = new HashSet<Lesson>();
        }
        public string Address { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
    }
}
