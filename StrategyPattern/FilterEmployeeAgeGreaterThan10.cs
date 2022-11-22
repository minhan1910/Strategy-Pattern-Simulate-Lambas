namespace StrategyPattern
{
    public class FilterEmployeeAgeGreaterThan10 : IEmployeeFilterable
    {
        public bool filter(Employee employee)
        {
            return employee.Age > 10;
        }
    }
}