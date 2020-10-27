using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Repository.Repositories.EntityFramework;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemplateClassesController : BaseController<TemplateClass, TemplateClassRepository>
    {
        public TemplateClassesController(TemplateClassRepository repository) : base(repository)
        {
        }
    }
}
