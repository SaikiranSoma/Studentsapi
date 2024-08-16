using System.ComponentModel.DataAnnotations;

namespace StudentApi.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        public string name {  get; set; }
    }
}
