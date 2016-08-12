using System;
using System.Net;

namespace Amazon.Runtime.Internal.Util
{
    public class WebProxy : IWebProxy
    {

        public WebProxy(string proxyUri)
        : this(new Uri(proxyUri))
        {
        }

        public WebProxy(Uri proxyUri)
        {
            this.ProxyUri =  proxyUri;
        }

        public WebProxy(string proxyHost, int proxyPort): this(new Uri("http://"+ proxyHost + ":" + proxyPort))
        {
        }

        public Uri ProxyUri { get; set; }

        public ICredentials Credentials { get; set; }

        public Uri GetProxy(Uri destination)
        {
            return this.ProxyUri;
        }


        public bool IsBypassed(Uri host)
        {
            return false; /* Proxy all requests */
        }


    }
}