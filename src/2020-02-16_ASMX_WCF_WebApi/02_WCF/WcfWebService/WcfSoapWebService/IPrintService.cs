using System.ServiceModel;

namespace WcfSoapWebService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IPrintService”。
    [ServiceContract]
    public interface IPrintService
    {
        [OperationContract]
        Name GetFullName(string firstName, string lastName);
    }
}
