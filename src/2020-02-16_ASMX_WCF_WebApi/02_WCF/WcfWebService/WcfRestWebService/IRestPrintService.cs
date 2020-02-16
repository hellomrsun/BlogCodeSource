using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfRestWebService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IRestPrintService”。
    [ServiceContract]
    public interface IRestPrintService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/GetFullName", ResponseFormat = WebMessageFormat.Json)]
        string GetFullName();

        [OperationContract]
        [WebInvoke(UriTemplate = "/PostName/{firstName}/{lastName}", Method = "POST")]
        string PostNameInfo(string firstName, string lastName);
    }
}
