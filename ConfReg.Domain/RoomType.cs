using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfReg.Domain
{
    public enum RoomType
    {
        [Display(Name = "Kambarys nereikalingas")]
        None,
        [Display(Name = "Vienvietis")]
        Single,
        [Display(Name = "Dvivietis")]
        Double,
        [Display(Name = "Trivietis")]
        Triple,
        [Display(Name = "Keturvietis")]
        Quad
    }
}
