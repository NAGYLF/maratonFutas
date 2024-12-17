using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;
using WebApplication4.Repositories.Interfaces;

namespace WebApplication4.Repositories.Services
{
    public class EredmenyekServices : EredmenyekInterface
    {
        private readonly MaratonvaltoContext _context;

        public EredmenyekServices(MaratonvaltoContext context)
        {
            _context = context;
        }

        public async Task<Eredmenyek> NewResult(Eredmenyek eredmenyek)
        {
            var eredmeny = new Eredmenyek
            {
                Futo = eredmenyek.Futo,
                Kor = eredmenyek.Kor,
                Ido = eredmenyek.Ido,
            };
            await _context.Eredmenyeks.AddAsync(eredmeny);
            await _context.SaveChangesAsync();
            return eredmeny;
        }
    }
}
