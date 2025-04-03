using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OpenDoor.DbContexts;
using OpenDoor.Entitty;
using OpenDoorApi.Request;
using OpenDoorApi.Response;

namespace OpenDoorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Applicant : Controller
    {

        private AppDbContext _dbContext;

        public Applicant(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddApplicantAsync(ApplicantRequest request)
        {
            await _dbContext.Applicants.AddAsync(new ApplicantEntity(request.Name));
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> AllApplicantAsync()
        {
            var response = await _dbContext.Applicants
                .OrderByDescending(n => n.Id)
                .Select(n => new { n.Id, n.Name, n.DateTime })
                .ToListAsync();

            return Ok(response);
        }
    }
}
