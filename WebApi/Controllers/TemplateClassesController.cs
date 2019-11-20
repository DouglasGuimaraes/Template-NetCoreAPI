using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Repository.Context;
using Repository.Repositories;

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
