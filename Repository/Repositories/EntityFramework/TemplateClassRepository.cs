using Models.Entities;
using Repository.Context;
using Repository.Repositories.EntityFramework.Base;

namespace Repository.Repositories.EntityFramework
{
    public class TemplateClassRepository : EFCoreRepository<TemplateClass, AppDbContext>
    {
        public TemplateClassRepository(AppDbContext context) : base(context)
        {
        }
    }
}
