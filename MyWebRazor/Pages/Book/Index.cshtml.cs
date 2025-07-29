using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyWebRazor.DAL;
using MyWebRazor.Model;

namespace MyWebRazor.Pages.Book
{
    public class IndexModel : PageModel
    {
            private readonly MyAppDBContext _context;

        public IndexModel(MyAppDBContext context)
        {
            _context = context;
        }

        public IList<Books> Books { get; set; }
        public async Task OnGet()
        {
            Books = await _context.Books.ToListAsync();
        }
    }
}
