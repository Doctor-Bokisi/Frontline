using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User.Api.Entities;

namespace User.Api.Repositories.IRepositories
{
    public interface IParamedicRepository
    {
        Task<Paramedic> postParamedic(Paramedic paramedic);
    }
}
