using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GenericRepo.Models;

public class StudentUpdateVM
{
    public int Id { get; set; }
    public string ClassName { get; set; }
    public int? SchoolId { get; set; }
    public string Name { get; set; }
    public SelectList Schools { get; set; }
}
