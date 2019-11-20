using Models.Entities;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public class TemplateClassRepository : EFCoreRepository<TemplateClass, AppDbContext>
    {
        public TemplateClassRepository(AppDbContext context) : base(context)
        {
        }
    }
}
