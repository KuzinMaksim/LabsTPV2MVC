using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LabsTPV2._3.Models
{
    public class ParishionerModel
    {
        [Required]
        [DisplayName("ID")]
        public int ID { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Surname")]
        public string Surname { get; set; }
        [DisplayName("BirthDate")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [DisplayName("Address")]
        public string Address { get; set; }
        [DisplayName("Sex")]
        public bool Sex { get; set; }

    }
}
