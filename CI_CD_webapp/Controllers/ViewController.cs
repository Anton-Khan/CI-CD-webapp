using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CI_CD_webapp
{
    [Route("")]
    
    public class ViewController : ControllerBase
    {
        private readonly IViewRepository _viewRepo;

        public ViewController(IViewRepository viewRepository)
        {
            _viewRepo = viewRepository;
        }

        [HttpGet]
        public IActionResult GetHi()
        {
            var greeting = _viewRepo.getGreeting();
            return Ok(greeting);
        }

        [HttpGet]
        [Route("{name}")]
        public IActionResult GetHi([FromRoute] string name)
        {
            var greeting = _viewRepo.GreetMe(name);
            return Ok(greeting);
        }

    }
}
