using GenericRepo.Entities.Concrete;
using GenericRepo.Repositories.Abstract;
using GenericRepo.Repositories.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepo.Controllers
{
    public class SchoolController : Controller
    {
        private readonly ISchoolRepository schoolRepository;

        public SchoolController(ISchoolRepository schoolRepository)
        {
            this.schoolRepository = schoolRepository;
        }

        public IActionResult Index()
        {
            List<School> schools = schoolRepository.GetAllWithStudents().ToList();
            return View(schools);
        }
        public IActionResult Create()
        {
            return View();
        }
        
    }
}
