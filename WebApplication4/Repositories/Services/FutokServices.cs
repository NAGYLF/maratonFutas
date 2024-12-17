using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;
using WebApplication4.Repositories.Interfaces;
using static WebApplication4.Models.Dto;

namespace WebApplication4.Repositories.Services
{
    public class FutokServices : FutokInterface
    {
        private readonly MaratonvaltoContext _context;

        public FutokServices(MaratonvaltoContext context)
        {
            _context = context;
        }

        public async Task<List<GetFemaleDto>> AllFemaleRunners()
        {
            var female = await _context.Futoks
                .Where(futo => futo.Ffi == false)
                .OrderBy(futo=>futo.Fnev)
                .Select(futo => new GetFemaleDto(futo.Fnev,futo.Szulev))
                .ToListAsync();

            return female;
        }

        public async Task<List<Futok>> AllRunners()
        {
            var runners = await _context.Futoks.ToListAsync();
            return runners;
        }

        public async Task<Futok> ById(int id)
        {
            var runner = await _context.Futoks.FirstOrDefaultAsync(runner => runner.Fid == id);
            return runner;
        }

        public async Task<Futok> RunnerWithAllData(int id)
        {
            var runner = await _context.Futoks.Include(Futo => Futo.Eredmenyeks).FirstOrDefaultAsync(futo => futo.Fid == id);
            return runner;
        }

        
    }
}
