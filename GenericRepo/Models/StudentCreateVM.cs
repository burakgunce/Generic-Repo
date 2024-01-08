using Microsoft.AspNetCore.Mvc.Rendering;

namespace GenericRepo.Models
{
    public class StudentCreateVM
    {
        public string ClassName { get; set; }
        //public int? SchoolId { get; set; }
        public string Name { get; set; }
        public SelectList Schools { get; set; }
    }
}
