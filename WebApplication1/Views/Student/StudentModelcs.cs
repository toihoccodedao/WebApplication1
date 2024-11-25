using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class StudentModel
    {
        [Required]
        [StringLength(10, ErrorMessage = "MSSV must be 10 characters or less.")]
        public string MSSV { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Họ tên must be 50 characters or less.")]
        public string HoTen { get; set; }

        [Required]
        [Range(0, 10, ErrorMessage = "Điểm TB must be between 0 and 10.")]
        public float DiemTB { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Chuyên ngành must be 50 characters or less.")]
        public string ChuyenNganh { get; set; }
    }
}