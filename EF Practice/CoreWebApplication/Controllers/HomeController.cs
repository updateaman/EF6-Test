using System.Threading.Tasks;
using CoreWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserDbContext _context;

        public HomeController()
        {
            _context = new UserDbContext();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id,
            [Bind(
                "FirstName,LastName,BirthDate,ProfilePhoto,Interests,AboutMe,Address")]
            UserProfile userProfile)
        {
            if (id != userProfile.Id)
            {
                return NotFound();
            }

            _context.Update(userProfile);
            await _context.SaveChangesAsync();
            
            return Ok();
        }
    }
}
