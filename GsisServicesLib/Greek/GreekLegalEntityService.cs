using GsisServicesLib.GreekLegalEntityInfoService;
using System;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Threading.Tasks;


namespace GsisServicesLib.Greek
{

    /// <summary>
    /// 
    /// </summary>
    public class GreekLegalEntityInfoInvoker : IGreekLegalEntityInfoInvoker
    {
        public GreekLegalEntityInfoInvoker()
        {

        }

     
        public RgWsPublicClient GetNewConfiguredServiceClient(string userName, string password, string vatNumberIssuer, string searchForVatNumber)
        {
            EndpointAddress endpointAdress = new EndpointAddress("https://www1.gsis.gr:443/webtax2/wsgsis/RgWsPublic/RgWsPublicPort");

            BasicHttpBinding binding = new BasicHttpBinding();
            binding.Security.Mode = BasicHttpSecurityMode.Transport;
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
            binding.Security.Transport.ProxyCredentialType = HttpProxyCredentialType.None;
            binding.Security.Message.ClientCredentialType = BasicHttpMessageCredentialType.UserName;
            binding.Security.Message.AlgorithmSuite = SecurityAlgorithmSuite.Default;


            var gsisService = new RgWsPublicClient(binding, endpointAdress);

            gsisService.Endpoint.Behaviors.Add(new InspectorBehavior(new ClientInspector(new SecurityHeader(userName, password))));

            return gsisService;
        }

        /// <summary>
        /// Call the gsis web service and returns info about a legal entity.
        /// </summary>
        public RgWsPublicBasicRtUser GetLegalEntityInfo(string userName, string password, string vatNumberIssuer, string searchForVatNumber)
        {
            try
            {

                RgWsPublicClient gsisService = GetNewConfiguredServiceClient(userName, password, vatNumberIssuer, searchForVatNumber);

                var rgWsPublicInputRt_in = new RgWsPublicInputRtUser
                {
                    afmCalledBy = vatNumberIssuer,
                    afmCalledFor = searchForVatNumber
                };
               
                var RgWsPublicBasicRt_out = new RgWsPublicBasicRtUser();
                var arrayOfRgWsPublicFirmActRt_out = new RgWsPublicFirmActRtUserArray();
                var pCallSeqId_out = 0m;
                var pErrorRec_out = new GenWsErrorRtUser();


                gsisService.rgWsPublicAfmMethod(rgWsPublicInputRt_in, ref RgWsPublicBasicRt_out, ref arrayOfRgWsPublicFirmActRt_out, ref pCallSeqId_out,ref pErrorRec_out);

                if (pErrorRec_out != null && !string.IsNullOrEmpty(pErrorRec_out.errorCode))
                {
                    throw new ApplicationException($"Error code: {pErrorRec_out.errorCode}, Error Description: {pErrorRec_out.errorDescr}");
                }

                return RgWsPublicBasicRt_out;
            }
            catch (Exception)
            {
                throw;
            }

        }


        /// <summary>
        /// Call the gsis web service and returns info about a legal entity.
        /// </summary>
        public async Task<RgWsPublicBasicRtUser> GetLegalEntityInfoAsync(string userName, string password, string vatNumberIssuer, string searchForVatNumber)
        {
            try
            {

                RgWsPublicClient gsisService = GetNewConfiguredServiceClient(userName, password, vatNumberIssuer, searchForVatNumber);
            
                var rgWsPublicInputRt_in = new RgWsPublicInputRtUser
                {
                    afmCalledBy = vatNumberIssuer,
                    afmCalledFor = searchForVatNumber
                };

                var request = new rgWsPublicAfmMethodRequest
                {
                    RgWsPublicInputRt_in = rgWsPublicInputRt_in
                };

                var response = await gsisService.rgWsPublicAfmMethodAsync(request);

                if (response.pErrorRec_out != null && !string.IsNullOrEmpty(response.pErrorRec_out.errorCode))
                {
                    throw new GreekLegalEntityServiceException($"Error code: {response.pErrorRec_out.errorCode}, Error Description: {response.pErrorRec_out.errorDescr}");
                }

                return response.RgWsPublicBasicRt_out;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}

