#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NguyenTrongNgoc.Models;

namespace NguyenTrongNgoc.Pages_Comment
{
    public class IndexModel : PageModel
    {
        private readonly DataComment _context;

        public IndexModel(DataComment context)
        {
            _context = context;
        }

        public IList<comment> Comment { get;set; }

        public async Task OnGetAsync()
        {
            Comment = await _context.comment.ToListAsync();
        }
    }
}
