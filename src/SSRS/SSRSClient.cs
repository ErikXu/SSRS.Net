using RestSharp;
using SSRS.Requests;
using SSRS.Results;
using System.Net;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace SSRS
{
    public class SSRSClient : IDisposable
    {
        public string? Url { get; private set; }

        public string? UserName { get; private set; }

        public string? Password { get; private set; }

        public string? Domain { get; private set; }

        private readonly RestClient _client;

        public SSRSClient(string url, string userName, string password) : this(url, userName, password, string.Empty)
        {

        }

        public SSRSClient(string url, string userName, string password, string domain)
        {
            Url = url;
            UserName = userName;
            Password = password;
            Domain = domain;

            var credentials = new NetworkCredential(userName, password, domain);

            var options = new RestClientOptions(url)
            {
                UseDefaultCredentials = false,
                Credentials = credentials
            };

            _client = new RestClient(options);
        }

        public CreateFolderResult? CreateFolder(CreateFolderRequest request)
        {
            return Call<CreateFolderRequest, CreateFolderResult>(request, "CreateFolder");
        }

        public IsSSLRequiredResult? IsSSLRequired(IsSSLRequiredRequest request)
        {
            return Call<IsSSLRequiredRequest, IsSSLRequiredResult>(request, "IsSSLRequired");
        }

        public GetSystemPropertiesResult? GetSystemProperties(GetSystemPropertiesRequest request)
        {
            return Call<GetSystemPropertiesRequest, GetSystemPropertiesResult>(request, "GetSystemProperties");
        }

        public GetItemTypeResult? GetItemType(GetItemTypeRequest request)
        {
            return Call<GetItemTypeRequest, GetItemTypeResult>(request, "GetItemType");
        }

        public TResult? Call<TRequest, TResult>(TRequest request, string action)
        {
            var xmlRequest = new XmlRequest<TRequest>
            {
                Body = request
            };
            
            var restRequest = new RestRequest
            {
                Method = Method.Post,
                Resource = Url
            };

            restRequest.AddHeader("SOAPAction", $"http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer/{action}");

            var content = ObjectToXml(xmlRequest);
            restRequest.AddBody(content, "text/xml");

            var resResponse = _client.Execute(restRequest);
            if (!resResponse.IsSuccessful)
            {
                throw new Exception(resResponse.Content);
            }

            var response = XmlToObject<XmlRequest<TResult>>(resResponse.Content);
            return response.Body;
        }

        private static string ObjectToXml<TRequest>(TRequest request)
        {
            using (var writer = new Utf8StringWriter())
            {
                var serializer = new XmlSerializer(typeof(TRequest));
                serializer.Serialize(writer, request);
                return writer.ToString();
            }
        }

        private static TResponse XmlToObject<TResponse>(string xml)
        {
            var rawXML = XDocument.Parse(xml);
            using (var reader = rawXML.CreateReader(ReaderOptions.None))
            {
                var serializer = new XmlSerializer(typeof(TResponse));
                return (TResponse)serializer.Deserialize(reader);
            }
        }

        public void Dispose()
        {
            if (_client != null)
            {
                _client.Dispose();
            }
        }
    }

    public class Utf8StringWriter : StringWriter
    {
        public override Encoding Encoding => Encoding.UTF8;
    }
}
