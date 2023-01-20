using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace MakeOutboundCall.Controllers
{
    [Route("/connect")]
    [ApiController]
    public class FreeClimbController : ControllerBase
    {

        [HttpPost]
        public ActionResult CallConnect()
        {
            // Debug.WriteLine(request.Status);
            // Create an empty PerCL script container
            PerclScript script = new PerclScript(new List<PerclCommand>());
            Say say = new Say("You just got called by the C sharp S D K!");
            Debug.WriteLine(say.ToJson());

            script.Commands.Add(say);
            // Convert PerCL container to JSON and append to response
            return Content(script.ToJson(), "application/json");
        }
    }
}