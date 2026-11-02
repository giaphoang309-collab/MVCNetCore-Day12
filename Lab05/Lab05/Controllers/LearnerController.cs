using Lab05.Data;
using Lab05.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Lab05.Controllers
{

    public class LearnerController : Controller
    {
        private int pageSize = 3;

        public IActionResult Index(int? mid)
        {
            var learners = (IQueryable<Learner>)db.Learners.Include(m => m.Major);
            if (mid != null)
            {
                learners = (IQueryable<Learner>)db.Learners
                    .Where(l => l.MajorID == mid)
                    .Include(m => m.Major);
            }

            int pageNum = (int)Math.Ceiling(learners.Count() / (float)pageSize);
            ViewBag.pageNum = pageNum;

            var result = learners.Take(pageSize).ToList();
            return View(result);
        }

        private readonly SchoolContext db;

        public LearnerController(SchoolContext context)
        {
            db = context;
        }
        public IActionResult LearnerFilter(int? mid, string? keyword, int? pageIndex)
        {

            var learners = (IQueryable<Learner>)db.Learners;

            int page = (int)(pageIndex == null || pageIndex <= 0 ? 1 : pageIndex);

            if (mid != null)
            {
                learners = learners.Where(l => l.MajorID == mid);
                ViewBag.mid = mid;
            }

            if (!string.IsNullOrEmpty(keyword))
            {
                learners = learners.Where(l => l.FirstMidName.ToLower().Contains(keyword.ToLower()));
                ViewBag.keyword = keyword;
            }

            int pageNum = (int)Math.Ceiling(learners.Count() / (float)pageSize);
            ViewBag.pageNum = pageNum;

            var result = learners.Skip(pageSize * (page - 1))
                                 .Take(pageSize)
                                 .Include(m => m.Major)
                                 .ToList();

            return PartialView("LearnerTable", result);
        }

        public IActionResult Create()
        {
            ViewBag.Majors = new SelectList(db.Majors.ToList(), "MajorID", "MajorName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("FirstMidName,LastName,MajorID,EnrollmentDate")] Learner learner)
        {
            if (ModelState.IsValid)
            {
                db.Learners.Add(learner);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Majors = new SelectList(db.Majors.ToList(), "MajorID", "MajorName", learner.MajorID);
            return View(learner);
        }

        public IActionResult LearnerByMajorID(int mid)
        {
            var learners = db.Learners
                .Where(l => l.MajorID == mid)
                .Include(m => m.Major).ToList();
            return PartialView("LearnerTable", learners);
        }
    }
}