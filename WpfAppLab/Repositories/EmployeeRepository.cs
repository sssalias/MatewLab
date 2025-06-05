using WpfAppLab.Models;

namespace WpfAppLab.Repositories
{
    internal static class EmployeeRepository
    {
        private static DBConfig _context;

        static EmployeeRepository()
        {
            _context = new DBConfig();
        }


        public static Employee? CreateEmployee(Employee employee, int JobTitleId)
        {
            JobTitle? jobTitle = JobTitleRepository.GetJobTitles(JobTitleId);
            if (jobTitle == null)
            {
                return null;
            }
            employee.JobTitleId = jobTitle.Id;
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public static List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }

        public static Employee? GetEmployees(int Id)
        {
            return _context.Employees.Find(Id);
        }
    }
}
