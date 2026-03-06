using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MYFIRSTAPP.Models;
using MYFIRSTAPP.Repository;

namespace MYFIRSTAPP.Controllers
{
    public class EmployeeController1 : Controller
    {
        private readonly Iemployeerepository _employeerepository;

        public EmployeeController1(Iemployeerepository iemployeerepository)
        {
            _employeerepository = iemployeerepository;
            
        }
        // GET: EmployeeController1
        public ActionResult Index()
        {
            List<Employee> employees = _employeerepository.getallemp();
            return View(employees);
        }

        // GET: EmployeeController1/Details/5
        public ActionResult Details(int id)

        {
            Employee emp=_employeerepository.GetEmployeebyid(id);
            return View(emp);
        }

        // GET: EmployeeController1/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: EmployeeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee collection)
        {
            try
            {
                _employeerepository.addemployee(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController1/Edit/5
        public ActionResult Edit(int id)
        {
            Employee emp = _employeerepository.GetEmployeebyid(id);
            return View(emp);
        }

        // POST: EmployeeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee collection)
        {
            try
            {
                _employeerepository.updateemp(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController1/Delete/5
        public ActionResult Delete(int id)
        {
            Employee emp = _employeerepository.GetEmployeebyid(id);

            return View(emp);
        }

        // POST: EmployeeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _employeerepository.deleteemp(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
