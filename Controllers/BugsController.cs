using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BugReport.Services;
using BugReport.Models;
using System;

namespace BugReport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BugsController : ControllerBase
    {
        private readonly BugsService _bs;
        public BugsController(BugsService bs)
        {
            _bs = bs
        }

        [HttpGet]
        public ActionResult<IEnumerable<Bug>> Get()
        {
            try
            {
                return Ok(_bs.Get());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}


