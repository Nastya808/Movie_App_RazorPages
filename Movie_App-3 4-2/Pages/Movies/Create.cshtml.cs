using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieApp.Data;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MovieApp.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly MovieContext _context;

        public CreateModel(MovieContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Movie Movie { get; set; }

        [BindProperty]
        public IFormFile? PosterFile { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (PosterFile != null && PosterFile.Length > 0)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");
                Directory.CreateDirectory(uploadsFolder); 

                var filePath = Path.Combine(uploadsFolder, Path.GetFileName(PosterFile.FileName));

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await PosterFile.CopyToAsync(fileStream);
                }

                Movie.Poster = $"/images/{Path.GetFileName(PosterFile.FileName)}";
            }

            _context.Movies.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
