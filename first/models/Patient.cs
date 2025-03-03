using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first.models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int Age { get; set; }

        [Required]
        public string Gender { get; set; } = string.Empty;

        public string ContactInfo { get; set; } = string.Empty;
        public string MedicalHistory { get; set; } = string.Empty;

        // العلاقة M:N مع Doctor عبر الجدول الوسيط
        public List<DoctorPatient> DoctorPatients { get; set; } = new();
    }
}
