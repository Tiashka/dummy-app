using Booker.Api.Logic;
using Microsoft.AspNetCore.Mvc;
using NumberConversionServiceReference;
using static Booker.Api.Logic.SoapCallLogic;
using static NumberConversionServiceReference.NumberConversionSoapTypeClient;

namespace Booker.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SoapEndpointsConsumerController : ControllerBase
    {

        private readonly ILogger<SoapEndpointsConsumerController> _logger;

        public SoapEndpointsConsumerController(ILogger<SoapEndpointsConsumerController> logger)
        {
            _logger = logger;
        }

        [HttpPost("/PostNumberToWordsViaSoap/{number}")]
        public Task<SoapResponse> PostNumberToWordsViaSoap([FromRoute] int number)
        {
            SoapCallLogic scl = new SoapCallLogic();
            var response = scl.MakeSoapCallAsync(number);
            return response;
        }
    }
}
