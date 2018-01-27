using System.Threading.Tasks;
using CoreWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserDbContext _context;

        public HomeController(UserDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([FromBody]
            [Bind(
                "Id,FirstName,LastName,BirthDate,ProfilePhoto,Interests,AboutMe,Address")]
            UserProfile userProfile)
        {
            _context.Update(userProfile);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromRoute]string id, [FromBody]
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
