#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NguyenTrongNgoc.Models;

namespace NguyenTrongNgoc.Pages_Comments
{
    public class IndexModel : PageModel
    {
        private readonly Data _context;

        public IndexModel(Data context)
        {
            _context = context;
        }

        public IList<Comments> Comments { get;set; }

        public async Task OnGetAsync()
        {
            Comments = await _context.Comments.ToListAsync();
        }
    }
}
