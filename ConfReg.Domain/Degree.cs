using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfReg.Domain
{
    public enum Degree
    {
        [Display(Name = "")]
        Without,
        [Display(Name = "Dr.")]
        Doctor,
        [Display(Name = "Prof.")]
        Professor
    }
}
