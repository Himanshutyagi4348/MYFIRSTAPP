using MYFIRSTAPP.Context;
using MYFIRSTAPP.Models;

namespace MYFIRSTAPP.Repository
{
    public class SQLRepository : Iemployeerepository
    {
        private readonly  Appdbcontext _appdbcontext;
  
        public SQLRepository(Appdbcontext appdbcontext)
        {
            _appdbcontext = appdbcontext;
        }

        public void addemployee(Employee emp)
        {
            _appdbcontext.employees.Add(emp);
            _appdbcontext.SaveChanges();
        }

        public void deleteemp(int id)
        {

            foreach (Employee emp in _appdbcontext.employees)
            {
                if (emp.Id == id)
                {
                    _appdbcontext.employees.Remove(emp);
                }
            }
            _appdbcontext.SaveChanges();

        }

        public List<Employee> getallemp()
        {
            return _appdbcontext.employees.ToList();
        }

        public Employee GetEmployeebyid(int id)
        {

            Employee _employee = new Employee();
            foreach (Employee emp in _appdbcontext.employees)
            {
                if (emp.Id == id)
                    _employee = emp;
            }
            return _employee;

        }

        public void updateemp(Employee emp)
        {
            foreach (Employee empl in _appdbcontext.employees)
            {
                if (empl.Id == emp.Id)
                {
                    empl.Name = emp.Name;
                    empl.Salary = emp.Salary;
                    empl.city = emp.city;
                    _appdbcontext.employees.Update(empl);
                }


            }
            _appdbcontext.SaveChanges();

        }
    }
}
