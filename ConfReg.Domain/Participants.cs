using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfReg.Domain
{
    public class Participants
    {
        public int Id { get; set; }
        public Degree Degree { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Institution { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string AnnName { get; set; }
        public string AnnAuthorsAndAff { get; set; }
        public string AnnSummary { get; set; }
        public RoomType RoomType { get; set; }
        public AccPerson AccPerson { get; set; }
        public InvoiceReq InvoiceReq { get; set; }
    }
}
