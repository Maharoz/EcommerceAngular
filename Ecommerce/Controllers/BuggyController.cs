using Ecommerce.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class BuggyController:BaseApiController
    {
        private readonly StoreContext _context;
        public BuggyController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet("notfound")]
        public ActionResult GetNotFoundRequest()
        {
            var thing = _context.Products.Find(42);
            if(thing == null)
            {
                return NotFound();
            }
            return Ok();
        }


        [HttpGet("servererror")]
        public ActionResult GetServerError()
        {
            var thing = _context.Products.Find(42);
            var thingsToReturn = thing.ToString();
            return Ok();
        }


        [HttpGet("badrequest")]
        public ActionResult GetBadRequest()
        {
            return GetBadRequest();
        }

        [HttpGet("badrequest/{id}")]
        public ActionResult GetNotFoundRequest(int id)
        {
            return GetBadRequest();
        }
    }
}
