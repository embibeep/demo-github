#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NguyenTrongNgoc.Models;

namespace NguyenTrongNgoc.Pages_News
{
    public class DetailsModel : PageModel
    {
        private readonly Data _context;

        public DetailsModel(Data context)
        {
            _context = context;
        }

        public News News { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            News = await _context.News.FirstOrDefaultAsync(m => m.ID == id);

            if (News == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}