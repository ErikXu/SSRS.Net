﻿using SSRS;
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

            CreateFolder(url, userName, password, domain);

            CreateSubFolder(url, userName, password, domain);

            CreateDataSource(url, userName, password, domain);
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

        private static void CreateDataSource(string url, string userName, string password, string domain)
        {
            using var client = new SSRSClient(url, userName, password, domain);

            var request = new CreateDataSourceRequest
            {
                CreateDataSource = new CreateDataSource
                {
                    DataSource = "MyDataSource",
                    Parent = "/foo/bar",
                    Overwrite = true,
                    Definition = new CreateDataSourceDefinition
                    {
                        Extension = "SQL",
                        ConnectString = "Data Source=xxx.xxx.xxx.xxx;Initial Catalog=MyDatabase",
                        UseOriginalConnectString = false,
                        OriginalConnectStringExpressionBased = false,
                        CredentialRetrieval = "Store",
                        WindowsCredentials = false,
                        ImpersonateUser = false,
                        UserName = "sa",
                        Password = "sa",
                        Enabled = true
                    }
                }
            };

            var result = client.CreateDataSource(request);
        }
    }
}