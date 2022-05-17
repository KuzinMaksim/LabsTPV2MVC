using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LabsTPV2._3.Models
{
    public class ParishionerModel
    {
        [Required]
        public int ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public string Adress { get; set; }

        public bool Sex { get; set; }

    }
}
