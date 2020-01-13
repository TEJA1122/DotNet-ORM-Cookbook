using Recipes.Views;

namespace Recipes.Dapper.Views
{
    public class EmployeeClassification : IEmployeeClassification
    {
        public int EmployeeClassificationKey { get; set; }
        public string? EmployeeClassificationName { get; set; }
        public bool IsExempt { get; set; }
        public bool IsEmployee { get; set; }
    }
}