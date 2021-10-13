using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDDWebApi.Presentation.Controllers
{
   
        [ApiController]
        //[Authorize]
        [Route("api/[controller]/[action]")]
        public class MainController : ControllerBase
        {
            public IActionResult Ok<T>(IEnumerable<T> value)
            {
                
                if (!value.Any())
                {
                    return NoContent();
                }
                else
                {
                    return base.Ok(value);
                }
            }
        }
    }

