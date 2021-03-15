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
        public string Street { get; set; }

        [Display(Name = "Zip code")]
        public string ZipCode { get; set; }
        public string City { get; set; }
        public int Number { get; set; }
    }
}
