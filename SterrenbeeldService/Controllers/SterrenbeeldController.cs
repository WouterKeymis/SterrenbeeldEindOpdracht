using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SterrenbeeldService.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SterrenbeeldService.Controllers
{
    [Route("sterrenbeelden")]
    [ApiController]
    public class SterrenbeeldController : ControllerBase
    {
        private ISterrenbeeldRepository repository;

        public SterrenbeeldController(ISterrenbeeldRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("{dag}-{maand}")]
        public ActionResult FindByDate(int dag, int maand)
        {
            if (dag < 1 || dag > 31)
            {
                return base.BadRequest(dag);
            }
            if (maand < 1 || maand > 12)
            {
                return base.BadRequest(maand);
            }

            return base.Ok(repository.getSterrenbeeld(dag, maand));
        }
    }
}
