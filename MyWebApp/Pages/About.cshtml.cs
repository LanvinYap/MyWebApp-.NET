using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages
{
    public class AboutModel : PageModel
    {
        public string? About { get; set; }
        public List<EducationEntry> Education { get; set; } = new();
        public List<ExperienceEntry> Experiences { get; set; } = new();

        public void OnGet()
        {
            About =
                "Hello this is my first web application with ASP.NET Core and Visual Studio Code.";

            Education = new List<EducationEntry>
            {
                new EducationEntry
                {
                    Title = "Singapore Institute of Management, Singapore (2022 - 2024 Jun)",
                    Descriptions = new List<string>
                    {
                        "Bachelor of Science (Honours) in Computer Science (Web and Mobile Development), University of London"
                    }
                },
                new EducationEntry
                {
                    Title = "Republic Polytechnic, Singapore (2018 - 2021 April)",
                    Descriptions = new List<string> { "Diploma in Mobile Software Development" }
                }
            };

            Experiences = new List<ExperienceEntry>
            {
                new ExperienceEntry
                {
                    Title =
                        "Sindcon (Singapore) IoT Technology - On-Site Support Engineer (October 2024 - January 2025)",
                    Descriptions = new List<string>
                    {
                        "Configured, tested, and deployed IoT devices.",
                        "Conducted battery and sensor performance testing.",
                        "On-site technical support in Indonesia and Singapore.",
                        "Firmware Upgrades and over-the-air (OTA) testing for IoT devices.",
                        "Gained proficiency in MQTT protocols.",
                        "Prepared devices and materials for exhibitions, customer orders, and field deployments."
                    }
                },
                new ExperienceEntry
                {
                    Title = "Virtual Assistant for CET Scheduling (Internship) - 2020",
                    Descriptions = new List<string>
                    {
                        "Developed a Chatbot using DialogFlow to automate booking reminders and confirmation processes, reducing workload for School of Infocom Staff and minimizing errors.",
                        "Collaborated with a team of 3 members.",
                        "Key responsibilities included training the Chatbot to recognize input phrases, responding to queries in various formats (text, audio, image), and configuring web APIs to fetch data from third-party sources like Google Spreadsheet.",
                        "Successfully integrated the Chatbot into Google Assistant, enhancing its accessibility and usability."
                    }
                },
                new ExperienceEntry
                {
                    Title = "Japan Home - Sales Assistant (2018 - 2022)",
                    Descriptions = new List<string>
                    {
                        "Operated the cashier system.",
                        "Calculated total prices and provided correct change to customers."
                    }
                }
            };
        }

        public class EducationEntry
        {
            public string Title { get; set; } = string.Empty;
            public List<string> Descriptions { get; set; } = new();
        }

        public class ExperienceEntry
        {
            public string Title { get; set; } = string.Empty;
            public List<string> Descriptions { get; set; } = new();
        }
    }
}
