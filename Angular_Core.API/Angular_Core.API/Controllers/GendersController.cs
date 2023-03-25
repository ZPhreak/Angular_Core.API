using Angular_Core.API.DomainModels;
using Angular_Core.API.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Angular_Core.API.Controllers
{
    [ApiController]
    public class GendersController : Controller
    {
        private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;

        public GendersController(IStudentRepository student, IMapper mapper)
        {
            this.studentRepository = student;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllGeners()
        {
            var genderList = await studentRepository.GetGendersAsync();

            if (genderList == null || !genderList.Any())
            {
                return NotFound();
            }

            return Ok(mapper.Map<List<Gender>>(genderList));
        }
    }
}
