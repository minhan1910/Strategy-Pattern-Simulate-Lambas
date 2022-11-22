namespace StrategyPattern
{
    public class EmployeeProcessor
    {
        List<Employee> emps;
        public EmployeeProcessor(List<Employee> emps) 
        {
            this.emps = emps;
        }

        public List<Employee> GetAllEmployeesFilterBy(IEmployeeFilterable employeeFilter)
        {
            var employeesFilterd = new List<Employee>();

            foreach (var employee in emps)
            {
                if (employeeFilter.filter(employee))
                {
                    employeesFilterd.Add(employee);
                }
            }

            return employeesFilterd;
        }
    }
}