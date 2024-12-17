using WebApplication4.Models;
using static WebApplication4.Models.Dto;

namespace WebApplication4.Repositories.Interfaces
{
    public interface FutokInterface
    {
        Task<List<Futok>> AllRunners();

        Task<Futok> ById(int id);

        Task<Futok> RunnerWithAllData(int id);

        Task<List<GetFemaleDto>> AllFemaleRunners();
    }
}
