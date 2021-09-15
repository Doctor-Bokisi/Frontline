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

        [HttpPost]
        public ActionResult<bool> PostParamedic([FromBody] Paramedic paramedic)
        {
            if (ModelState.IsValid)
            {
                _repo.PostParamedic(paramedic);
                return StatusCode(201);
            }

            else return StatusCode(400);
        }

        [HttpPut]
        public ActionResult<bool> UpdateParamedic([FromBody] Paramedic paramedic)
        {
            if (paramedic != null)
            {
                _repo.UpdateParamedic(paramedic);
                return Ok(paramedic);
            }

            return StatusCode(400);
        }

        [HttpDelete]
        public ActionResult DeleteParamedic(Paramedic paramedic)
        {
            var ObjectToPass = _repo.GetParamedicById(paramedic.Id);
            _repo.DeleteParamedic(ObjectToPass);
            return Ok();
        }
    }
}
