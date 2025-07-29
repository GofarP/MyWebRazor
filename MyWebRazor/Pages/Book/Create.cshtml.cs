using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebRazor.DAL;
using MyWebRazor.Model;

namespace MyWebRazor.Pages.Book
{
    public class CreateModel : PageModel
    {

        private readonly MyAppDBContext _context;

        public CreateModel(MyAppDBContext context)
        {
			_context = context;
		}

        public IActionResult onGet()
        {
            return Page();
        }

        [BindProperty]
        public Books Book { get; set; } = default;

          public async Task<IActionResult> OnPostAsync()
        {
			if (!ModelState.IsValid)
            {
				return Page();
			}

			_context.Books.Add(Book);
			await _context.SaveChangesAsync();

			return RedirectToPage("./Index");
		}
        
    }
}
