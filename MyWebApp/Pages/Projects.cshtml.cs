using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages
{
    public class ProjectsModel : PageModel
    {
        public List<Project> Projects { get; set; } = new();

        public void OnGet()
        {
            Projects = new List<Project>
            {
                new Project
                {
                    Title = "Word-Based Game (Final Year Project) - 2024",
                    Description = "Mobile word-based game with two engaging modes.",
                    Details = new List<string>
                    {
                        "Utilizing React Native.",
                        "Designed intuitive user interfaces using HTML, CSS, and wireframes created with Figma.",
                        "Emploted Firebase for data mangement and synchronization.",
                        "Features including Login, Registration, Leaderboard, and Settings."
                    },
                    Link = "https://youtu.be/LDVmOHjEJWE"
                },
                new Project
                {
                    Title = "eLearning Website Application - 2024",
                    Description =
                        "eLearning platform with authentication, authorization, and real-time communication.",
                    Details = new List<string>
                    {
                        "Using Python with Django web framework.",
                        "Managed courses and facilitated seamless interaction between students and teachers.",
                        "Designed intuitive user interfaces with HTML, CSS, and JavaScript."
                    },
                    Link = "https://youtu.be/I7TCJIe_GP4"
                },
                new Project
                {
                    Title = "RESTful Web Service - 2024",
                    Description = "RESTful web service with six endpoints.",
                    Details = new List<string>
                    {
                        "Using Python with Django framework.",
                        "Designed intuitive user interfaces with HTMl, CSS, and JavaScript."
                    },
                    Link = "https://youtu.be/PsAzeE_Ta_o"
                },
                new Project
                {
                    Title = "Online Quiz Application - 2023",
                    Description = "An interactive quiz application.",
                    Details = new List<string>
                    {
                        "Using React Native and Node.js for API management.",
                        "Utilized Figma for wireframing to streamline development."
                    },
                    Link = "https://youtu.be/8KsQtskMN1U"
                },
                new Project
                {
                    Title = "Smart Home Web Application - 2022",
                    Description =
                        "Smart home web application for monitoring and controlling devices.",
                    Details = new List<string>
                    {
                        "Using Visual Studio Code and Node.js.",
                        "Integrated MySQL for data management and querying."
                    },
                    Link = "https://youtu.be/9UjCFk6U0cE"
                },
                new Project
                {
                    Title = "Meetups Application - 2022",
                    Description = "Android application for organizing and participating in events.",
                    Details = new List<string>
                    {
                        "Using Flutter.",
                        "Played a key role in UI design and development within a collaborative team environment."
                    },
                    Link = "-"
                },
                new Project
                {
                    Title = "DJ Application - 2022",
                    Description =
                        "Feature-rich DJ application with audio loading, mixing, and track.",
                    Details = new List<string>
                    {
                        "Using Visual Studio Code and JUCE framework.",
                        "Cross-platform compatibility and audio processing using JUCE."
                    },
                    Link = "-"
                },
                new Project
                {
                    Title = "Parent Chat (Final Year Project) - 2019",
                    Description =
                        "Led a team of 3 in developing a chatbot for Anglo-Chinese School (junior) to streamline communication during Home-Based Learning.",
                    Details = new List<string>
                    {
                        "Developed the Chatbot using DialogFlow.",
                        "Designing and implementing a response template for Facebook Messenger.",
                        "Configuring web APIs to fetch data from third-party sources like Goole Spreadsheet and Firebase."
                    },
                    Link = "-"
                },
                new Project
                {
                    Title = "MRT Quiz - 2019",
                    Description =
                        "5 pages projects to allow users to learn Singapore MRT Stations through a quiz.",
                    Details = new List<string> { "Develop with Android Studio (Java) and SQLite." },
                    Link = "-"
                },
                new Project
                {
                    Title = "Push Up Tracking (Mobile Application) - 2019",
                    Description =
                        "5 pages project to allow users to save, track and share their push up number.",
                    Details = new List<string> { "Develop with Android Studio (Java) and SQLite." },
                    Link = "-"
                },
                new Project
                {
                    Title = "MRT Information - 2019",
                    Description = "7 pages UI prototype based on requirement.",
                    Details = new List<string>
                    {
                        "Allow users to check MRT arrive time, MRT information, travel time, and fare."
                    },
                    Link = "-"
                },
                new Project
                {
                    Title = "Donation - 2019",
                    Description = "16 pages UI prototype.",
                    Details = new List<string>
                    {
                        "Encourage users to donate money to organizations."
                    },
                    Link = "-"
                }
            };
        }

        public class Project
        {
            public string Title { get; set; } = string.Empty;
            public string Description { get; set; } = string.Empty;
            public List<string> Details { get; set; } = new();
            public string Link { get; set; } = string.Empty;
        }
    }
}
