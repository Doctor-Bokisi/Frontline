using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User.Api.Entities;
using User.Api.Repositories.IRepositories;

namespace User.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParamedicController : ControllerBase
    {
        readonly private IParamedicRepository _repo;
        public ParamedicController(IParamedicRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Paramedic>> GetParamedics()
        {
            return Ok(_repo.GetParamedics());
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Paramedic>> GetSingleParamedic(int id)
        {
            return Ok(_repo.GetParamedicById(id));
        }
    }
}
