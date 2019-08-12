using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoEveProj.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        [DisplayName(" Full Name")]
        [Column(TypeName = "nvarchar(250)")]
        public string FullName { get; set; }

        [DisplayName("Employee Code")]
        [Column(TypeName = "nvarchar(10)")]
        public string EmpCode { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        
        public string Department { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Position { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Site Location")]
        public string SiteLocation { get; set; }
    }
}
