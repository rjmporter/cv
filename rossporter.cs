using System;
using System.Collections.Generic;
using System.Linq;

namespace Career.SoftwareEngineering
{
    /// <summary>
    /// Ross Porter: Principal Software Engineer & Technical Lead.
    /// Specializing in SaaS scale, AI workflows, and Platform Modernization.
    /// </summary>
    public class RossPorter(IAppSettings appSettings) : IEngineeringLeader, IContributingEngineer, IMentor
    {
        public ContactInfo Contact => new ContactInfo 
        {
            Location = "Owosso, Michigan, USA",
            Email = appSettings.Secrets.Email,
            Phone = appSettings.Secrets.Phone,
            LinkedIn = "linkedin.com/in/rossporter"
        };

        public string Summary => "Principal Software Engineer and Technical Lead with over 15 years of industry tenure " +
                                 "designing and delivering scalable software systems across desktop, web, and cloud environments. " +
                                 "Expert in platform architecture, shared infrastructure, and AI-integrated systems serving millions of global users.";

        public Dictionary<string, string[]> CoreSkills => new List<string> 
        {
            { "Cloud", new[] { "Azure", "Kubernetes (AKS)", "Cloud-native architecture" } },
            { "Languages", new[] { "C#", "ASP.NET Core", "JavaScript/TypeScript", "C++", "Python" } },
            { "AI/ML", new[] { "OpenAI", "ElevenLabs", "Pipio", "Microsoft Cognitive Services", "GitHub Copilot" } },
            { "DevOps", new[] { "CI/CD", "Agile Metrics (Cycle-time, WIP)", "Incident Management" } },
            { "Architecture", new[] { "REST/OpenAPI", "I18n/L10n Modernization", "SaaS Licensing Systems" } }        };
        };

        public IEnumerable<Experience> GetWorkHistory()
        {
            yield return new Experience 
            {
                Company = "TechSmith Corporation",
                Role = "Principal Software Engineer, Lead - Platform / Infrastructure",
                Period = "March 2019 – Present",
                Highlights = new List<string> 
                {
                    "Managed modernization of cloud-native services serving millions of users globally.",
                    "Migrated 80% of legacy background workers to Kubernetes (AKS), increasing reliability by 25%.",
                    "Secured executive buy-in for platform-first strategies, reducing duplicated effort by 40%.",
                    "Integrated OpenAI and ElevenLabs for high-fidelity voice synthesis and AI-driven media automation.",
                    "Mentored 3 senior engineers into Technical Lead roles within a 24-month period.",
                    "Reduced feature lead time by 15% using Agile metrics and bottleneck identification."
                }
            };

            yield return new Experience 
            {
                Company = "TechSmith Corporation",
                Role = "Desktop Software Architect – Camtasia",
                Period = "November 2014 – May 2017",
                Highlights = new List<string> 
                {
                    "Modernized I18n/L10n in UI codebase, cutting language addition time from months to weeks.",
                    "Architected native desktop applications for Windows/Mac, bridging engineering and leadership.",
                    "Laid the groundwork for platform-oriented thinking through code reuse and consistency."
                }
            };

            yield return new Experience 
            {
                Company = "Pioneer State Mutual Insurance",
                Role = ".NET Applications Architect",
                Period = "June 2011 – August 2012",
                Highlights = new List<string> 
                {
                    "Deployed SOA for real-time rating systems and external data integrations.",
                    "Administered TFS implementation and defined team delivery standards."
                }
            };

            yield return new Experience 
            {
                Company = "HP Enterprise Services (HP / EDS)",
                Role = "Technology Consultant IV",
                Period = "January 2006 – November 2010",
                Highlights = new List<string> 
                {
                    "Technical lead for large-scale enterprise portals and public sector systems.",
                    "Contributed to global architecture practice for cross-project design consistency."
                }
            };
        }

        public string Education => "University of Michigan – English | " +
                                   "(Equivalent experience in CS/IT acquired through 15+ years of industry tenure)";
    }

    public struct ContactInfo { public string Location, Email, Phone, LinkedIn; }
    public record Experience { public string Company, Role, Period; public List<string> Highlights; }
}
