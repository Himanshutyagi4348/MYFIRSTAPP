using MYFIRSTAPP.Models;

namespace MYFIRSTAPP.Repository
{
    public class EmployeeRepository : Iemployeerepository
    {
        static List<Employee> employees = new List<Employee>();
        static EmployeeRepository()
        {
            Employee obj = new Employee();
            obj.Id = 0;
            obj.Name = "himanshu";
            obj.Salary = 5000;
            obj.city = "saharanpur";

            employees.Add(obj);
            employees.Add(new Employee()
            {
                Id = 1,
                Name = "tyagi",
                Salary = 3000,
                city = "dehradun"
            });
            employees.Add(new Employee()
            {
                Id = 2,
                Name = "nitin",
                Salary = 4000,
                city = "chandigarh"
            });
        }
        public void addemployee(Employee emp)
        {
            employees.Add(emp);
        }

        public void deleteemp(int id)
        {
            foreach (Employee emp in employees)
            {
                if (emp.Id == id)
                {
                    employees.Remove(emp);

                }
            }
        }

      

        public List<Employee> getallemp()
        {
            return employees;

        }

      

      

        public Employee GetEmployeebyid(int id)
        {
            //linq-->language integrated query
            Employee _employee = new Employee();
            foreach (Employee emp in employees)
            {
                if (emp.Id == id)
                    _employee = emp;
            }
            return _employee;
        }
        public void updateemp(Employee emp)
        {

            foreach (Employee empl in employees)
            {
                if (empl.Id == emp.Id)
                {
                    empl.Name = emp.Name;
                    empl.Salary = emp.Salary;
                    empl.city = emp.city;
                }


            }
        }
    }
}
