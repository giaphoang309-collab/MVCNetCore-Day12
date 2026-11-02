using Microsoft.AspNetCore.Mvc;
using Lab05.Data;

namespace Lab05.ViewComponents
{
    public class MajorViewComponent : ViewComponent
    {
        private readonly SchoolContext db;

        public MajorViewComponent(SchoolContext context)
        {
            db = context;
        }

        public IViewComponentResult Invoke()
        {
            var majors = db.Majors.ToList();
            return View("Default", majors);
        }
    }
}