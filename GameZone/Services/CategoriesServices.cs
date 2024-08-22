
namespace GameZone.Services
{
    public class CategoriesServices : ICategoriesServices
    {
        private readonly ApplicationDbContext _context;

        public CategoriesServices(ApplicationDbContext context)
        {
            _context = context;
        }


        public IEnumerable<SelectListItem> GetSelectList()
        {
            return _context.Categories.Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name })
           .OrderBy(c => c.Text)
           .AsNoTracking() // improve performance because entityframework will not track Categories after selection from db 
           .ToList();

        }
    }
}
