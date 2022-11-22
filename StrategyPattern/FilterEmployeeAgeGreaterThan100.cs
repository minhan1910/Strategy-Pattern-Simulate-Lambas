namespace StrategyPattern
{
    public class FilterEmployeeAgeGreaterThan100 : IEmployeeFilterable
    {
        public bool filter(Employee employee)
        {
            return employee.Age > 100;
        }
    }
}