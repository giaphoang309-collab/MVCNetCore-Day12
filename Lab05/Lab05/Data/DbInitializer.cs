using Lab05.Models;
using System.Linq;

namespace Lab05.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            if (context.Majors.Any())
            {
                return;
            }

            var majors = new Major[]
            {
                new Major { MajorName = "IT" },
                new Major { MajorName = "Economics" },
                new Major { MajorName = "Mathematics" }
            };

            foreach (Major m in majors)
            {
                context.Majors.Add(m);
            }
            context.SaveChanges();
        }
    }
}