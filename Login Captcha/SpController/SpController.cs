using Login_Captcha.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Login_Captcha.SpController
{
    public class SpController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SpController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.wenders.FromSqlRaw("exec spGetAllWenderList").ToList();

            var tz = TimeZoneInfo.GetSystemTimeZones().FirstOrDefault(t => t.BaseUtcOffset == DateTimeOffset.Now.Offset);

            return View(data);
        }
    }
}
