using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages
{
    public class ProjectsModel : PageModel
    {
        public string? About { get; set; }

        public void OnGet()
        {
            About =
                "Hello this is my first web application with ASP.NET Core and Visual Studio Code.";
        }
    }
}
