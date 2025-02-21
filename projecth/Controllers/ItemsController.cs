using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projecth.Data;
using projecth.Models;

namespace projecth.Controllers
{
    public class ItemsController : Controller
    {
        private readonly Context _context;

        public ItemsController(Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var item = await _context.Items.ToListAsync();
            return View(item);
        }

        /*public IActionResult Overview()
        {
            var item = new Item() { Name="keyboard" };
            return View(item);
        }

        public IActionResult Edit(int itemId)
        {
            return Content("id= " + itemId);
        }*/
    }
}
