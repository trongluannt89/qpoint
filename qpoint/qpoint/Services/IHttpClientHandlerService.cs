using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;


namespace qpoint.Services
{
    public interface IHttpClientHandlerService
    {
        HttpClientHandler GetInsecureHandler();
    }
}
