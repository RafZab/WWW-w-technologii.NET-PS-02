using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using AdressBook.Forms;

namespace AdressBook.Pages
{
    public class AddressModel : PageModel
    {
        public Address Address { get; set; }

        public List<Address> AddressList { get; set; }


        public void OnGet()
        {
            var SessionAddressListJSON = HttpContext.Session.GetString("SessionAddresses");

            if (SessionAddressListJSON != null)
                AddressList = JsonConvert.DeserializeObject<List<Address>>(SessionAddressListJSON);
            else
            {
                AddressList = new List<Address>();
            }
        }
    }
}
