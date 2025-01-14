using System.ComponentModel.DataAnnotations;

namespace datatransferpractice.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Gender is required.")]
        public Gender Gender { get; set; }
        [Required(ErrorMessage ="FirstName is Required")]
        public string firstName { get; set; }
        public string lastName { get; set; }

        [Required(ErrorMessage ="Address is Required")]
        public string Address { get; set; }
        public bool IsMarried { get; set; }

    }
    public enum Gender
    {
        Male,Female
    }
}
