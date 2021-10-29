using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoredPrecedure.Data;
using StoredPrecedure.Models;

namespace StoredPrecedure.Controllers
{
    public class EmployeeController : Controller
    {
        public StoredProcedureDBContext _context;

        public EmployeeController(StoredProcedureDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IEnumerable<Employee> SearchResult()
        {
            var result = _context.Employee
                .FromSqlRaw<Employee>("spSearchEmployees")
                .ToList();

            return result;
        }
    }
}
