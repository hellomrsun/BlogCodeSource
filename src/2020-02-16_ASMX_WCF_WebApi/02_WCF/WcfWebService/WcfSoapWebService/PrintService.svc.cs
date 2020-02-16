namespace WcfSoapWebService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“PrintService”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 PrintService.svc 或 PrintService.svc.cs，然后开始调试。
    public class PrintService : IPrintService
    {
        public Name GetFullName(string firstName, string lastName)
        {
            return new Name
            {
                FirstName = firstName,
                LastName = lastName
            };
        }
    }
}
