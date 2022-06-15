using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudUsingBlazor.Shared.Enums
{
    public enum Category
    {
        Books,
        Laptop,
        Television,
        [Display(Name = "Mobile Phones")]
        MobilePhones

    }
}
