using Microsoft.EntityFrameworkCore;
using TickZone.Data.Base;
using TickZone.Models;

namespace TickZone.Data.Services
{


    public class ActorService : EntityBaseRepository<Actor>,IActorsServices
    {
        //private  AppDbContext _context;

        //contructor
        public ActorService(AppDbContext context) : base(context) { }
        






    }
}
