using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediClinic.Models
{
    public class PatientRecord
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientRecordID { get; set; }

        [Required]
        [DisplayName("FullName")]
        public string PatientFullname { get; set; }

        [Required(ErrorMessage = "Your ID No must contain 13 digits")]
        [StringLength(13)]
        [DisplayName("ID Number")]
        public string PatientIDNumber { get; set; }

        [Required(ErrorMessage = "Provide the prescription")]
        [DisplayName("Prescription")]
        public string PatientPrescription { get; set; }


        [Required(ErrorMessage = "Provide the age of the patient")]
        [DisplayName("Age")]
        public int PatientAge { get; set; }
    }
}