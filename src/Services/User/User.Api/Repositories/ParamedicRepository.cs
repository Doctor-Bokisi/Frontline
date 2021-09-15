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

        public async Task<Paramedic> DeleteParamedic(int Id)
        {
            var result = await _context.Paramedics.FirstOrDefaultAsync(p => p.Id == Id);

            if (result != null)
            {
                _context.Paramedics.Remove(result);
                await _context.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public Paramedic GetParamedicById(int id)
        {
            return _context.Paramedics.FirstOrDefault(p => p.Id == id);
        }

        public async Task<List<Paramedic>> GetParamedics()
        {
            return await _context.Paramedics.ToListAsync();
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
            try
            {
                var data = await _context.Paramedics.FirstOrDefaultAsync(e => e.Id == paramedic.Id);

                if (data != null)
                {
                    _context.Paramedics.Update(data);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
