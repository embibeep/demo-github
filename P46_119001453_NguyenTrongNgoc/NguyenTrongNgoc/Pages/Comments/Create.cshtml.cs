#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NguyenTrongNgoc.Models;

namespace NguyenTrongNgoc.Pages_Comments
{
    public class CreateModel : PageModel
    {
        private readonly Data _context;

        public CreateModel(Data context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Comments Comments { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Comments.Add(Comments);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}