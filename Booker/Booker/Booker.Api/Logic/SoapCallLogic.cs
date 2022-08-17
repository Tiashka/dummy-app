using NumberConversionServiceReference;
using static NumberConversionServiceReference.NumberConversionSoapTypeClient;

namespace Booker.Api.Logic
{
    public class SoapCallLogic
    {
        public async Task<SoapResponse> TrySoapCallAsync(int payload)
        {
            EndpointConfiguration endpointConfig = new EndpointConfiguration();
            var soapClient = new NumberConversionSoapTypeClient(endpointConfig);
            var response = await soapClient.NumberToWordsAsync(Convert.ToUInt64(payload));
            return new SoapResponse()
            {
                responseWord = response.Body.NumberToWordsResult
            };
        }

        public class SoapResponse
        {
            public string responseWord { get; set; }
        }
    }
}
