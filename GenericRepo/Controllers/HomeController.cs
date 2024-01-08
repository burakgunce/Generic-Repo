using GenericRepo.Entities.Concrete;
using GenericRepo.Models;
using GenericRepo.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GenericRepo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository studentRepository;
        private readonly IRepository<School> schoolRepository;

        public HomeController(IStudentRepository studentRepository, IRepository<School> schoolRepository)
        {
            this.studentRepository = studentRepository;
            this.schoolRepository = schoolRepository;
        }

        public IActionResult Index()
        {
            //List<Student> students = studentRepository.GetAll().ToList();
            List<Student> students = studentRepository.GetAllIncludedSchool().ToList();
            return View(students);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //school controller ekle

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}