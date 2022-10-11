using SSRS;
using SSRS.Requests;
using System;

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

            CreateFolder(url, userName, password, domain);
            CreateSubFolder(url, userName, password, domain);
        }

        private static void CreateFolder(string url, string userName, string password, string domain)
        {
            using var client = new SSRSClient(url, userName, password, domain);

            var request = new CreateFolderRequest
            {
                CreateFolder = new CreateFolder
                {
                    Parent = "/",
                    Folder = "foo"
                }
            };

            var result = client.CreateFolder(request);
        }

        private static void CreateSubFolder(string url, string userName, string password, string domain)
        {
            using var client = new SSRSClient(url, userName, password, domain);

            var request = new CreateFolderRequest
            {
                CreateFolder = new CreateFolder
                {
                    Parent = "/foo",
                    Folder = "bar"
                }
            };

            var result = client.CreateFolder(request);
        }
    }
}