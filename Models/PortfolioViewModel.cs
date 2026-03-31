namespace AliPortfolio.Models
{
    public class PortfolioViewModel
    {
        public PersonalInfo Personal { get; set; } = new();
        public List<Skill> Skills { get; set; } = new();
        public List<Project> Projects { get; set; } = new();
        public List<Experience> Experiences { get; set; } = new();
        public Education Education { get; set; } = new();
    }

    public class PersonalInfo
    {
        public string Name { get; set; } = "";
        public string Title { get; set; } = "";
        public string Summary { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Location { get; set; } = "";
        public string LinkedIn { get; set; } = "";
        public string GitHub { get; set; } = "";
    }

    public class Skill
    {
        public string Category { get; set; } = "";
        public List<string> Items { get; set; } = new();
        public string Icon { get; set; } = "";
    }

    public class Project
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public List<string> Highlights { get; set; } = new();
        public List<string> Technologies { get; set; } = new();
    }

    public class Experience
    {
        public string Company { get; set; } = "";
        public string Role { get; set; } = "";
        public string Period { get; set; } = "";
        public string Location { get; set; } = "";
        public List<string> Responsibilities { get; set; } = new();
    }

    public class Education
    {
        public string Degree { get; set; } = "";
        public string University { get; set; } = "";
        public string Period { get; set; } = "";
        public string Location { get; set; } = "";
        public string Grade { get; set; } = "";
    }

    public static class PortfolioData
    {
        public static PortfolioViewModel GetData() => new()
        {
            Personal = new PersonalInfo
            {
                Name = "Ali Omer Aljawhi",
                Title = "Backend / .NET Developer",
                Summary = "Backend developer with strong experience in ASP.NET Core, Web APIs, and SQL Server. Skilled in building scalable systems using clean architecture, repository pattern, JWT authentication, and multi-tenant solutions. Passionate about performance optimization and system design.",
                Email = "alialjawhi0@gmail.com",
                Phone = "+966552701385",
                Location = "Riyadh, Saudi Arabia",
                LinkedIn = "https://www.linkedin.com/in/ali-aljawhi",
                GitHub = "https://github.com/alialjawhi"
            },
            Skills = new List<Skill>
            {
                new() { Category = "Backend", Icon = "server", Items = new() { "ASP.NET Core MVC", "ASP.NET Core Web API", "Entity Framework Core", "Clean Architecture", "SOLID Principles", "Repository & Service Pattern", "JWT Authentication", "Role-based Authorization", "Multi-Tenant Systems" } },
                new() { Category = "Database", Icon = "database", Items = new() { "SQL Server", "Database Design", "Query Optimization", "FK Constraints" } },
                new() { Category = "Frontend (Basic)", Icon = "layout", Items = new() { "HTML", "CSS", "JavaScript", "Bootstrap" } },
                new() { Category = "Tools & DevOps", Icon = "tool", Items = new() { "Git & GitHub", "REST APIs", "Swagger", "Docker", "Azure (Basic)", "AWS (Basic)", "Firebase FCM" } }
            },
            Projects = new List<Project>
            {
                new()
                {
                    Title = "Multi-Tenant Management System",
                    Description = "A robust tenant-aware backend system built with ASP.NET Core MVC, ensuring full data isolation and security across multiple tenants.",
                    Highlights = new() {
                        "Built tenant-aware backend using ASP.NET Core MVC",
                        "Implemented global query filters for tenant isolation",
                        "Designed secure JWT-based authentication",
                        "Optimized database relations and FK constraints"
                    },
                    Technologies = new() { "ASP.NET Core MVC", "JWT", "SQL Server", "EF Core", "Clean Architecture" }
                },
                new()
                {
                    Title = "Order & Delivery Management System",
                    Description = "A broker-based order management system connecting factories, companies, drivers, and customers with full order lifecycle management.",
                    Highlights = new() {
                        "Designed and developed a broker-based order system connecting factories, companies, drivers, and customers",
                        "Managed full order lifecycle with multiple statuses",
                        "Built backend APIs to support mobile applications for drivers",
                        "Applied Clean Architecture with Controller, Service, and Repository layers",
                        "Integrated Firebase Cloud Messaging (FCM) for real-time push notifications",
                        "Developed role-based access for companies, drivers, and customers",
                        "Designed SQL Server schema for products, orders, assignments, and tracking"
                    },
                    Technologies = new() { "ASP.NET Core MVC", "Web API", "Firebase FCM", "SQL Server", "EF Core", "Docker" }
                }
            },
            Experiences = new List<Experience>
            {
                new()
                {
                    Company = "Aljohi Group",
                    Role = ".NET Developer",
                    Period = "September 2023 – Present",
                    Location = "Riyadh, Saudi Arabia",
                    Responsibilities = new() {
                        "Developed backend logic using ASP.NET Core MVC",
                        "Designed REST APIs and database schemas",
                        "Applied clean architecture principles across projects"
                    }
                }
            },
            Education = new Education
            {
                Degree = "Bachelor's Degree",
                University = "Seiyun University",
                Period = "September 2019 – June 2023",
                Location = "Hadhramout, Yemen",
                Grade = "83%"
            }
        };
    }
}
