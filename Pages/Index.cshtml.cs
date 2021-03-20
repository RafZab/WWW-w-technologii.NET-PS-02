using AdressBook.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace AdressBook.Pages

{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public Address Address { get; set; }
        public List<Address> AddressList { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "User";
            }
            
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var SessionAddressListJSON = HttpContext.Session.GetString("SessionAddresses");
           
            if (SessionAddressListJSON == null)
                AddressList = new List<Address>();
            else
                AddressList = JsonConvert.DeserializeObject<List<Address>>(SessionAddressListJSON);

            AddressList.Add(Address);
            HttpContext.Session.SetString("SessionAddresses",JsonConvert.SerializeObject(AddressList));
            return RedirectToPage("./Address");
        }
    }
}
