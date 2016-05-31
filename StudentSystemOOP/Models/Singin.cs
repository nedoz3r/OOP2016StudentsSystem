using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSystem.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace StudentSystem.Models
{
    public class Singin : BaceModel
    {
        [Required]
        [DisplayName("Парола")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DisplayName("Име")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("Име")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Фамилия")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("E-майл")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Ден")]
        public DateTime Day { get; set; }

        [Required]
        [DisplayName("Месец")]
        public Mounth Mounth { get; set; }

        [Required]
        [DisplayName("Година")]
        public DateTime Year { get; set; }

        [Required]
        [DisplayName("Пол")]
        public Gender Gender { get; set; }

        [Required]
        [DisplayName("Телефон")]
        public long Mobile { get; set; }

        [Required]
        [DisplayName("Активационнен код")]
        public int ActivationCode { get; set; }

    }
}
