using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace News.Infrastructure.Network
{
    public class FetchFromEndPoint
    {
        List<RequestHeader> _requestHeaderText;
        string _endpoint;

        public FetchFromEndPoint(string endpoint)
        {
            _endpoint = endpoint;
        }

        public void AddHeader(RequestHeader requestHeader)
        {
            if (_requestHeaderText == null) _requestHeaderText = new List<RequestHeader>();
            _requestHeaderText.Add(requestHeader);
        }

        public async Task<string> ExecuteRequest()
        {
           
            using (HttpClient client = new HttpClient())
            {
                if(_requestHeaderText != null)
                {
                    foreach (RequestHeader header in _requestHeaderText)
                    {
                        client.DefaultRequestHeaders.Add(header.header, header.value);
                    }
                }
                
                using (HttpResponseMessage res = await client.GetAsync(_endpoint))
                {
                    using (HttpContent content = res.Content)
                    {
                        string endpointData = await content.ReadAsStringAsync();   
                        return endpointData ?? string.Empty;

                    }
                }
            }
        }
    }
}



