using System;
using System.Linq;
using Ict2017.Common;
using Ict2017.Common.Models;

namespace Microsoft.AspNetCore.Hosting
{
    public class IctSeeder : ISeeder<IctDbContext>
    {
        public void Seed(IctDbContext dbContext)
        {
            if (!dbContext.Assets.Any(x => x.Type == AssetType.Image))
            {
                var images = Enumerable
                    .Range(0, 15)
                    .Select(i => new Asset
                    {
                        Location = $"/images/image{i}.jpg",
                        Name = $"image{i}",
                        Type = AssetType.Image
                    });
                dbContext.AddRange(images);
            }

            if (!dbContext.Presentations.Any())
            {
                var startTime = new DateTime(2017, 10, 12, 7, 0, 0, DateTimeKind.Utc);

                (DateTime start, DateTime end)[] timeGroups = new(DateTime, DateTime)[]
                {
                    (startTime, startTime.AddMinutes(50)),
                    (startTime.AddMinutes(60), startTime.AddMinutes(110)),
                    (startTime.AddMinutes(120), startTime.AddMinutes(170))
                };

                var presentations = new Presentation[]
                {
                    new Presentation {
                        Title = "Building Mobile Apps like a pro",
                        Description = "Short dive into techniques and technologies used by professional mobile developers allowing delivery of complex and pretty applications",
                        Start = timeGroups[0].start,
                        End = timeGroups[0].end,
                        Presenter = new Presenter {
                            Forename = "Mihail",
                            Surname = "Bohnearschi",
                        },
                    },
                    new Presentation {
                        Title = "Test Automation as a part of Continuous Integration",
                        Description = "Benefits of Continuous Integration. How is Test Automation organized within CI. Implementation practices and challenges.",
                        Start = timeGroups[0].start,
                        End = timeGroups[0].end,
                        Presenter = new Presenter {
                            Forename = "Vladimir",
                            Surname = "Primac",
                        },
                    },
                    new Presentation {
                        Title = "The future of the WEB",
                        Description = "20 years ago it sounded fantastic and looked weird, 10 years ago it was filled by colors and became a part of our live, now it looks amazing and grows like a Tipsy... What is the future of the WEB?",
                        Start = timeGroups[0].start,
                        End = timeGroups[0].end,
                        Presenter = new Presenter {
                            Forename = "Artiom",
                            Surname = "Matusenco",
                        },
                    },
                    new Presentation {
                        Title = "Intensive .NET Internship trainings with senior software engineers",
                        Description = @"# Internship from senior .NET developers
# C#, SOLID, Design Patterns, Unit Testing, ORM, SQL, ASP.NET MVC
# How to become an intern in Amdaris?",
                        Start = timeGroups[0].start,
                        End = timeGroups[0].end,
                        Presenter = new Presenter {
                            Forename = "Oleg",
                            Surname = "Lucas",
                        },
                    },
                    new Presentation {
                        Title = "How to work smarter and live better",
                        Description = "The best tools available to ease your day to day tasks and get you to the result faster. The experience of working in a global IT company, skills that are appreciated and working with cross-functional teams in different continents.",
                        Start = timeGroups[0].start,
                        End = timeGroups[0].end,
                        Presenter = new Presenter {
                            Forename = "Adriana",
                            Surname = "Mosnoi",
                        },
                    },
                    new Presentation {
                        Title = "Software architecture: monolith to microservices",
                        Description = @"Both type architectures advantages and drawbacks. 
Transition from monolith to microservices architecture based on real experience.
Organisation of processes and tools for development.",
                        Start = timeGroups[1].start,
                        End = timeGroups[1].end,
                        Presenter = new Presenter {
                            Forename = "Marius",
                            Surname = "T",
                        },
                    },
                    new Presentation {
                        Title = "Containerized Single Page Applications with .NET backend",
                        Description = @"# De ce e timpul să uităm de MVC și în ce direcție se mișcă Web-ul
# Alegem soluția pentru front-end
# Demo Angular/Demo ASP.NET Core
# Ce soluții există pentru back-end
# Docker în development și production
# Demo Angular + ASP.NET Core + Docker",
                        Start = timeGroups[1].start,
                        End = timeGroups[1].end,
                        Presenter = new Presenter {
                            Forename = "Marian",
                            Surname = "Bejenari",
                        },
                        Asset = new Asset {
                            Type = AssetType.Document,
                            Location = "/docs/containerized_spa.pptx",
                            Name = "containerized_spa.pptx"
                        }
                    },
                    new Presentation {
                        Title = "Fast mobile development - React-Native",
                        Description = @"React-Native is a solution offered by Facebook to build mobile native applications for the most popular platforms such as Android, IOS, WP.
If you want to know the latest tendencies or the ways to develop native, cross-platform or hybrid application, then let’s begin the discussion!",
                        Start = timeGroups[1].start,
                        End = timeGroups[1].end,
                        Presenter = new Presenter {
                            Forename = "Maxim",
                            Surname = "G",
                        },
                    },
                    new Presentation {
                        Title = "IRP for Cloud: despre cloud-ul public, optimizarea rutelor, big business și nu numa",
                        Description = @"nteresat de cloud computing, optimizarea rețelelor și dezvoltarea unui serviciu care îmbunătățește rutarea cloudului public, cum ar fi AWS sau Microsoft Azure? Află cum IRPFC, cea mai bună tehnologie de optimizare a rutării cloud-ului public, dezvoltată de moldoveni, revoluționează performanța aplicațiilor găzduite de AWS.",
                        Start = timeGroups[1].start,
                        End = timeGroups[1].end,
                        Presenter = new Presenter {
                            Forename = "Maxim",
                            Surname = "Iangolo",
                        },
                    },
                    new Presentation {
                        Title = "Increasing Software Quality with Functional Test Automation",
                        Description = @"# Continuous Testing in Agile Software Development
# Test Automation Pyramid
# Selenium WebDriver is your friend
# Prioritize the testing
# Using Page Object Model for creating a robust automation framework",
                        Start = timeGroups[1].start,
                        End = timeGroups[1].end,
                        Presenter = new Presenter {
                            Forename = "Anton",
                            Surname = "Smaghin",
                        },
                    },
                    new Presentation {
                        Title = "A roadmap to becoming a Front-End Developer in 2017",
                        Description = @"Front End Developer is one of the hottest jobs in the market.
# where to start and what are the core skills you need to possess;
# how to be the best candidate for a Front-End development job;",
                        Start = timeGroups[2].start,
                        End = timeGroups[2].end,
                        Presenter = new Presenter {
                            Forename = "Maxim",
                            Surname = "Andrieș",
                        },
                    },
                    new Presentation {
                        Title = "Introduction in Performance Testing. What, How and Why?",
                        Description = @"Seeing Software through the eyes of a performance engineer. We'll analyze who and how is affected by performance while trying to understand how much objectivity is there in it. Also we'll have a look at the diversity of areas that are involved in performance analysis.",
                        Start = timeGroups[2].start,
                        End = timeGroups[2].end,
                        Presenter = new Presenter {
                            Forename = "Vadim ",
                            Surname = "Josan",
                        },
                    },
                    new Presentation {
                        Title = "Beyond \"Hello World!",
                        Description = @"What makes a good engineer - good, which way to go and what pitfalls to avoid, all this and much more.",
                        Start = timeGroups[2].start,
                        End = timeGroups[2].end,
                        Presenter = new Presenter {
                            Forename = "Vadim ",
                            Surname = "Rihlea",
                        },
                    },
                    new Presentation {
                        Title = "Unmasking the AM Engineer",
                        Description = @"Dorești să afli cum arată o zi din viața unui inginer in Managementul Aplicatiilor? 
Vino să cunoști care sunt activitățile și provocarile tehnice zilnice ale unui profesionist IT!
KEEP CALM and JOIN US! ",
                        Start = timeGroups[2].start,
                        End = timeGroups[2].end,
                        Presenter = new Presenter {
                            Forename = "Elvira",
                            Surname = "Parpalac",
                        },
                    },
                    new Presentation {
                        Title = "If you blink, you’ll miss it",
                        Description = @"Be the architect of your career path in the fast-pacing world of today. Familiarize yourself with the opportunities of the Enterprise edition",
                        Start = timeGroups[2].start,
                        End = timeGroups[2].end,
                        Presenter = new Presenter {
                            Forename = "Ștefan",
                            Surname = "Cotoneț",
                        },
                    },
                };
                dbContext.AddRange(presentations);
            }
            dbContext.SaveChanges();
        }
    }
}
