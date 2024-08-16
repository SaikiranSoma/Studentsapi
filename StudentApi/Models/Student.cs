using System.ComponentModel.DataAnnotations;

namespace StudentApi.Models
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }=Guid.NewGuid();

        public string FirstName { get; set; } = "";

        public string LastName { get; set; } = "";

        public int age {  get; set; }


    }
}
