using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfReg.Domain
{
    public class Participants
    {
        public int Id { get; set; }

        public Degree Degree { get; set; }

        [Required(ErrorMessage = "Šis laukas yra privalomas")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Šis laukas yra privalomas")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Šis laukas yra privalomas")]
        public string Institution { get; set; }

        [Required(ErrorMessage = "Šis laukas yra privalomas")]
        
        public string Email { get; set; }

        //public bool ConfirmedEmail { get; set; }

        [Required(ErrorMessage = "Šis laukas yra privalomas")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Šis laukas yra privalomas")]
        public string AnnName { get; set; }

        [Required(ErrorMessage = "Šis laukas yra privalomas")]
        public string AnnAuthorsAndAff { get; set; }

        [Required(ErrorMessage = "Šis laukas yra privalomas")]
        [StringLength(400, ErrorMessage ="Santrauka turi būti ne ilgesnė kaip 400 simbolių")]
        public string AnnSummary { get; set; }

        public RoomType RoomType { get; set; }

        public AccPerson AccPerson { get; set; }

        public string InvoiceReq { get; set; }
    }
}
