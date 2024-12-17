using WebApplication4.Models;

namespace WebApplication4.Repositories.Interfaces
{
    public interface EredmenyekInterface
    {
        Task<Eredmenyek> NewResult(Eredmenyek eredmenyek);
    }
}
