using SSRS;
using SSRS.Requests;

namespace Example
{
    internal class Program
    {
        static void Main()
        {
            var url = "http://example.com/ReportServer/ReportService2010.asmx";
            var userName = "{user}";
            var password = "{password}";
            var domain = "{domain}";

            using var client = new SSRSClient(url, userName, password, domain);

            //var request1 = new IsSSLRequiredRequest
            //{
            //    IsSSLRequired = new object()
            //};
            //var response1 = client.IsSSLRequired(request1);

            //var request2 = new GetItemTypeRequest
            //{
            //    GetItemType = new GetItemType
            //    {
            //        ItemPath = "/MyReport"
            //    }
            //};
            //var response2 = client.GetItemType(request2);

            var request3 = new GetSystemPropertiesRequest
            {
                GetSystemProperties = new GetSystemProperties
                {
                    Properties = new GetSystemPropertiesProperties
                    {
                        Property = new GetSystemPropertiesPropertiesProperty
                        {
                            Name = "SharePointIntegrated"
                        }
                    }
                }
            };
            var response3 = client.GetSystemProperties(request3);
        }
    }
}