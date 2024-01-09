using TickZone.Data.Base;
using TickZone.Models;

namespace TickZone.Data.Services
{
    public class CinemaService: EntityBaseRepository<Cinema>,ICinemaService
    {
        public CinemaService(AppDbContext context) : base(context) { }

    }
}
