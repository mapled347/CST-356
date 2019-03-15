using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Database.Entities
{
    [Table("student")]
    public class Student
    {
        [Column("student_id")]
        [Key]
        public long StudentId { get; set; }
        [Column("email_address")]
        public string EmailAddress { get; set; }

        public bool Special { get; set; }

}
}
