using System.ComponentModel.DataAnnotations.Schema;

namespace StudentAPI.Models
{
    [Table("student")]
    public class StudentDetail
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string? Name { get; set; } = null!;
        [Column("rollnumber")]
        public string? RollNumber { get; set; } = null!;
        [Column("country")]
        public string? Country { get; set; }
    }
}
