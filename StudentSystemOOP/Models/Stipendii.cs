using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentSystem.Models
{
    public class Stipendii : BaceModel
    {
        private ICollection<Student> student;
        public Stipendii()
        {
            this.student = new HashSet<Student>();
        }

        [Required]
        [DisplayName("Срок")]
        public int Srok { get; set; }

        [Required]
        [DisplayName("Дата за подаване на документи")]
        [DataType(DataType.Date)]
        public DateTime StartData { get; set; }

        [Required]
        [DisplayName("Дата за край на приемане на документи")]
        [DataType(DataType.Date)]
        public DateTime DeadLine { get; set; }

        [Required]
        [DisplayName("Размер")]
        public int Size { get; set; }

        public virtual ICollection<Student> Student
        {
            get
            {
                return this.student;
            }
            set
            {
                this.student = value;
            }
        }
    }
}
