using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User.Api.Entities;

namespace User.Api.Repositories.IRepositories
{
    public interface IParamedicRepository
    {
        Task<Paramedic> PostParamedic(Paramedic paramedic);
        Task<bool> UpdateParamedic(Paramedic paramedic);
        Task<bool> DeleteParamedic(Paramedic paramedic);
        List<Paramedic> GetParamedics();
        Paramedic GetParamedicById(int id);


    }
}
