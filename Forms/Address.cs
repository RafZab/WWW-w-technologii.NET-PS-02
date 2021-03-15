using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdressBook.Forms
{
    public class Address
    {   
        [Display(Name = "Your favorite street")]
        [StringLength(60, MinimumLength = 3), Required(ErrorMessage = "Pole jest obowiązkowe")]
        public string Street { get; set; }

        [Display(Name = "Zip code")]
        [StringLength(60, MinimumLength = 3), Required(ErrorMessage = "Pole jest obowiązkowe")]
        public string ZipCode { get; set; }

        [StringLength(60, MinimumLength = 3), Required(ErrorMessage = "Pole jest obowiązkowe")]
        public string City { get; set; }

        [StringLength(60, MinimumLength = 3), Required(ErrorMessage = "Pole jest obowiązkowe")]
        public string Number { get; set; }
    }
}
