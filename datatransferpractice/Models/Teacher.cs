using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace datatransferpractice.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [Column ("TeacherName", TypeName = "varchar(100)")]
        public string Name { get; set; }
        [Column ("TeacherGender", TypeName = "varchar(20)")]
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}
