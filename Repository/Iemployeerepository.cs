using MYFIRSTAPP.Models;

namespace MYFIRSTAPP.Repository
{
    public interface Iemployeerepository
    {
        void addemployee(Employee emp);
        void deleteemp(int id);
        List<Employee> getallemp();
        Employee GetEmployeebyid(int id);
        void updateemp(Employee emp);






    }
}
