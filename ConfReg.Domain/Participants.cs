using System.ComponentModel.DataAnnotations;
using ConfReg.Domain.CustomAttributes;

namespace ConfReg.Domain
{
    public class Participants
    {
        public int Id { get; set; }

        public string Degree { get; set; }

        [Required(ErrorMessage = "Šis laukas yra privalomas")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Šis laukas yra privalomas")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Šis laukas yra privalomas")]
        public string Institution { get; set; }

        [Required(ErrorMessage = "Šis laukas yra privalomas")]
        [ContainsChar('@', ErrorMessage = "Neteisingas el. pašto formatas")]
        [ContainsChar('.', ErrorMessage = "Neteisingas el. pašto formatas")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Šis laukas yra privalomas")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Šis laukas yra privalomas")]
        public string AnnName { get; set; }

        [Required(ErrorMessage = "Šis laukas yra privalomas")]
        public string AnnAuthorsAndAff { get; set; }

        [Required(ErrorMessage = "Šis laukas yra privalomas")]
        [MaxWords(400, ErrorMessage = "Santrauka negali viršyti 400 žodžių")]
        public string AnnSummary { get; set; }

        public RoomType RoomType { get; set; }

        public AccPerson AccPerson { get; set; }

        public string InvoiceReq { get; set; }
    }
}
