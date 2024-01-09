using Microsoft.EntityFrameworkCore;
using TickZone.Data.Base;
using TickZone.Models;

namespace TickZone.Data.Services
{
    public class ProducerService:EntityBaseRepository<Producer>,IProducerService
    {

        public ProducerService(AppDbContext context) : base(context) { }
        
        
    }
}
