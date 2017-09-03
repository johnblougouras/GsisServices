using GsisServicesLib.GreekLegalEntityInfoService;
using System.Threading.Tasks;


namespace GsisServicesLib.Greek
{

    public interface IGreekLegalEntityInfoInvoker
    {
        Task<RgWsPublicBasicRtUser> GetLegalEntityInfoAsync(string userName, string password, string vatNumberIssuer, string searchForVatNumber);

        RgWsPublicBasicRtUser GetLegalEntityInfo(string userName, string password, string vatNumberIssuer, string searchForVatNumber);
    }
}