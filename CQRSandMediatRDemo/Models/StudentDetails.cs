using System.ComponentModel.DataAnnotations;

namespace CQRSandMediatRDemo.Models
{
    public class StudentDetails
    {
        [Key]
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentAddress { get; set; }
        public int StudentAge { get; set; }
    }
}
