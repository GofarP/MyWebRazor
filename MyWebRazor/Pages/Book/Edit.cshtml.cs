using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyWebRazor.DAL;
using MyWebRazor.Model;

namespace MyWebRazor.Pages.Book
{
    public class EditModel : PageModel
    {
        private readonly MyAppDBContext _context;

        public EditModel(MyAppDBContext context)
        {
            _context = context;
        }

        [BindProperty]

        public Books Books {get; set;}= default!;

		public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return RedirectToPage("");
            }

            var book = await _context.Books.FirstOrDefaultAsync(b=>b.id == id);

            if (book == null)
            {
                return RedirectToPage("./Index");
            }
            Books = book;

            return Page();
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Update(Books);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }


    }
}
