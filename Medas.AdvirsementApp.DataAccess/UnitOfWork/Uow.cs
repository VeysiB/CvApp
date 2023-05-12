using Medas.AdvirsementApp.DataAccess.Contexts;
using Medas.AdvirsementApp.DataAccess.Interfaces;
using Medas.AdvirsementApp.DataAccess.Repositories;
using Medas.AdvirsementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medas.AdvirsementApp.DataAccess.UnitOfWork
{
    public class Uow: IUow
    {
        private readonly AdvertisementContext _context;

        public Uow(AdvertisementContext context)
        {
            _context = context;
        }
        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(_context);
        }
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
