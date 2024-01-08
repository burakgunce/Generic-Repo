using GenericRepo.Entities.Concrete;
using GenericRepo.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepo.Controllers
{
    public class LessonController : Controller
    {
        ILessonRepository _lessonRepository;

        public LessonController(ILessonRepository lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }

        public IActionResult Index()
        {
            List<Lesson> lessons = _lessonRepository.GetAllLessonsWithStudents();
            return View(lessons);
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
