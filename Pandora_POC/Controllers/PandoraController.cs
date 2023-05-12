using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using Pandora_POC.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pandora_POC.Controllers
{
    [ApiController]
    public class PandoraController : ControllerBase
    {
        private readonly IJsonSchemaValidator _schemaValidator;

        public PandoraController(IJsonSchemaValidator schemaValidator)
        {
            _schemaValidator = schemaValidator;
        }

        [Route("pandora/asset")]
        [HttpPost]
        public async Task<IActionResult> CreateAsset([FromBody] JObject request)
        {
            string input = Convert.ToString(request);
            var validateResponse = _schemaValidator.ValidateInputAndOutput(input);

            return StatusCode(Convert.ToInt32(401), null);
        }

    }
}
