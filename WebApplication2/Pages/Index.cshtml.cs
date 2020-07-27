using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;

namespace WebApplication2.Pages
{
    public class IndexModel : PageModel
    {
        public string Date { get; set; }
           
        public void OnGet()
        {
            Date = DateTime.Now.ToString();
        }
    }
}
