using GenericRepo.Entities.Concrete;
using GenericRepo.Models;
using GenericRepo.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GenericRepo.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository studentRepository;
        private readonly ISchoolRepository schoolRepository;

        public StudentController(
            IStudentRepository studentRepository,
            ISchoolRepository schoolRepository
        )
        {
            this.schoolRepository = schoolRepository;
            this.studentRepository = studentRepository;
        }

        public IActionResult Index()
        {
            List<Student> students = studentRepository.GetAllIncludedSchool().ToList();
            return View(students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            List<School> schools = schoolRepository.GetAll().ToList();
            StudentCreateVM std = new StudentCreateVM();
            std.Schools = new SelectList(schools, "Id", "Name");
            return View(std);
        }

        [HttpPost]
        public IActionResult Create(StudentCreateVM std)
        {
            Student student = new Student()
            {
                Name = std.Name,
                SchoolId = std.SchoolId,
                ClassName = std.ClassName
            };
            studentRepository.Add(student);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            List<School> schools = schoolRepository.GetAll().ToList();
            Student std = studentRepository.GetById(id);
            StudentUpdateVM student = new StudentUpdateVM()
            {
                Id = id,
                Name = std.Name,
                ClassName = std.ClassName,
                Schools = new SelectList(schools, "Id", "Name")
            };

            return View(student);
        }

        [HttpPost]
        public IActionResult Update(StudentUpdateVM std)
        {
            Student student = studentRepository.GetById(std.Id);
            student.Name = std.Name;
            student.ClassName = std.ClassName;
            student.SchoolId = std.SchoolId;

            studentRepository.Update(student);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Student student = studentRepository.GetById(id);
            studentRepository.Delete(student);
            return RedirectToAction("Index");
        }
    }
}
