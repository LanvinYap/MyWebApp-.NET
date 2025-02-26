using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

public class IndexModel : PageModel
{
    public string? About { get; set; }
    public string? Objective { get; set; }
    public List<string> Skills { get; set; } = new(); // Ensure it is never null

    public void OnGet()
    {
        Objective =
            "Hardworking and tech passion person with web and mobile / PC apps development experience, problem analysis and solving skills, looking forward to gaining a full-time position to expand my potential while making contributions";

        Skills = new List<string>
        {
            "Proficient in Programming Languages: Java, HTML, Python, C#, C++ and JavaScript.",
            "Development Environments: Android Studio, Visual Studio Code, Eclipse, and Xcode.",
            "Software Debugging: Visual Studio Code, Eclipse, and Jupyter Notebook.",
            "Web Development: Django, Django REST framework, and Node.js.",
            "Managed databases using SQLite and Firebase.",
            "Led branch creation, code commits, and pushes on GitHub.",
            "Optimized chatbot functionality with DialogFlow.",
            "Utilized draw.io and Figma to create diagrams and wireframes.",
            "Experience in problem analysis and problem-solving.",
            "Tools and Platforms: Excel, PowerPoint, MQTT, and LoRaWAN."
        };
    }
}
