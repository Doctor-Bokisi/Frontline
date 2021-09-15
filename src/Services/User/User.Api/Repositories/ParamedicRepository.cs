using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User.Api.Entities;
using User.Api.Repositories.IRepositories;

namespace User.Api.Repositories
{
    public class ParamedicRepository : IParamedicRepository
    {
        public Task<Paramedic> postParamedic(Paramedic paramedic)
        {
            throw new NotImplementedException();
        }
    }
}
