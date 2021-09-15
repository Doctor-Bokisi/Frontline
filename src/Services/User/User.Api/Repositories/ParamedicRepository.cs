using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User.Api.Data;
using User.Api.Entities;
using User.Api.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace User.Api.Repositories
{
    public class ParamedicRepository : IParamedicRepository
    {
        readonly private UserDbContext _context;
        public ParamedicRepository(UserDbContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteParamedic(Paramedic paramedic)
        {
            _context.Paramedics.Remove(paramedic);
            await _context.SaveChangesAsync();
            return true;
        }

        public Paramedic GetParamedicById(int id)
        {
            return _context.Paramedics.FirstOrDefault(p => p.Id == id);
        }

        public List<Paramedic> GetParamedics()
        {
            return _context.Paramedics.ToList();
        }

        public async Task<Paramedic> PostParamedic(Paramedic paramedic)
        {
            if (paramedic == null)
            {
                throw new NotImplementedException();
            }

            var result = await _context.Paramedics.AddAsync(paramedic);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<bool> UpdateParamedic(Paramedic paramedic)
        {
            _context.Paramedics.Update(paramedic);
             await _context.SaveChangesAsync();
            return true;
        }
    }
}
