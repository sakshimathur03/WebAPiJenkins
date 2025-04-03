using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Employee
    {
        [Key] 
        public int EmpId { get; set; }

        [Required]
        public string EmpName { get; set; }

        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Salary must be greater than 0")]
        public float Salary { get; set; }

        [Required]
        public string Dept { get; set; }
    }
}
