using Booker.Api.Logic;
using Microsoft.AspNetCore.Mvc;
using NumberConversionServiceReference;
using static Booker.Api.Logic.SoapCallLogic;
using static NumberConversionServiceReference.NumberConversionSoapTypeClient;

namespace Booker.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SoapController : ControllerBase
    {

        private readonly ILogger<SoapController> _logger;

        public SoapController(ILogger<SoapController> logger)
        {
            _logger = logger;
        }

        [HttpPost("{payload}")]
        public Task<SoapResponse> PostNumberToWordsViaSoap([FromRoute] int payload)
        {
            SoapCallLogic scl = new SoapCallLogic();
            var response = scl.TrySoapCallAsync(payload);
            return response;
        }
    }
}
