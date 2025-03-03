using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first.models
{
    public class DoctorPatient
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }

        [Required]
        [ForeignKey("Patient")]
        public int PatientId { get; set; }

        // العلاقات
        public Doctor Doctor { get; set; } = null!;
        public Patient Patient { get; set; } = null!;
    }
}
