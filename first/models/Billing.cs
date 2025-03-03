using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first.models
{
    public class Billing
    {
        [Key]
        public int BillingId { get; set; }

        [Required]
        [ForeignKey("Patient")]
        public int PatientId { get; set; }

        [ForeignKey("Appointment")]
        public int? AppointmentId { get; set; } // Nullable إذا كانت بعض الفواتير غير مرتبطة بمواعيد

        [Required]
        public decimal TotalAmount { get; set; }

        [Required]
        public decimal PaidAmount { get; set; }

        [NotMapped] // لا يتم تخزينه في قاعدة البيانات لأنه محسوب
        public decimal OutstandingBalance => TotalAmount - PaidAmount;

        [Required]
        public PaymentStatus PaymentStatus { get; set; } = PaymentStatus.Pending; // Enum

        public DateTime? PaymentDate { get; set; } // Nullable لأن الدفع قد لا يكون قد تم بعد

        // العلاقات
        public Patient Patient { get; set; } = null!;
        public Appointment? Appointment { get; set; } // Nullable عند الحاجة
    }

    // تعريف Enum لحالة الدفع
    public enum PaymentStatus
    {
        Pending,
        Paid
    }
}
