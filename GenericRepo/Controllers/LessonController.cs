using GenericRepo.Entities.Concrete;
using GenericRepo.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepo.Controllers
{
    public class LessonController : Controller
    {
        ILessonRepository _lessonRepository;
        IStudentRepository _studentRepository;

        public LessonController(ILessonRepository lessonRepository, IStudentRepository studentRepository)
        {
            _lessonRepository = lessonRepository;
            _studentRepository = studentRepository;
        }

        public IActionResult Index()
        {
            //List<Lesson> lessons = _lessonRepository.GetAllLessonsWithStudents();
            List<Lesson> lessons = _lessonRepository.GetAll().ToList();
            return View(lessons);
        }

        public IActionResult ManageStudents(int id)
        {
            List<Student> students = _studentRepository.GetAllStudentsWithLesson();
            return View(students);
        }

        public IActionResult Add()
        {
            return View();
;        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult KickStudent(Student student)
        {
            
            return View();
        }

    }
}
