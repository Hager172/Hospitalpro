using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first.models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Specialization { get; set; } = string.Empty;

        public string ContactInfo { get; set; } = string.Empty;
        public string Schedule { get; set; } = string.Empty;

        // تحديد المفتاح الأجنبي بشكل واضح
        public int? UsersmemberId { get; set; }

        [ForeignKey("UsersmemberId")]
        public Usersmember? Usersmember { get; set; }

        // العلاقة M:N مع Patient عبر الجدول الوسيط
        public List<DoctorPatient> DoctorPatients { get; set; } = new();
    }

}
