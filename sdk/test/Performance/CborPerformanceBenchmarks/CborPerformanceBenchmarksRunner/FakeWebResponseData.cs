using Amazon.Runtime.Internal.Transform;
using System.Net;


public class FakeWebResponseData : IWebResponseData
{
    public FakeWebResponseData()
    {
        this.ContentType = "application/json";
        this.StatusCode = HttpStatusCode.OK;
        this.IsSuccessStatusCode = true;
        this.Headers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        this.EventHeaders = new Dictionary<string, IEventStreamHeader>();
    }

    public Dictionary<string, string> Headers { get; set; }

    public string ContentType { get; set; }

    public HttpStatusCode StatusCode { get; set; }

    public bool IsSuccessStatusCode { get; set; }

    public Dictionary<string, IEventStreamHeader> EventHeaders {get; set;}

    public string[] GetHeaderNames()
    {
        return Headers.Keys.ToArray();
    }

    public bool IsHeaderPresent(string headerName)
    {
        return this.Headers.ContainsKey(headerName);
    }

    public string GetHeaderValue(string headerName)
    {
        if (this.Headers.ContainsKey(headerName))
            return this.Headers[headerName];
        else
            return null;
    }

    public IEventStreamHeader GetEventStreamHeader(string headerName)
    {
        if (EventHeaders.ContainsKey(headerName))
            return EventHeaders[headerName];
        return null;
    }

    public bool IsEventHeaderPresent(string headerName)
    {
        return EventHeaders.ContainsKey(headerName);
    }

    public long ContentLength { get; set; }


    public IHttpResponseBody ResponseBody
    {
        get
        {
            return new HttpResponseBody();
        }
    }
}

public class HttpResponseBody : IHttpResponseBody
{
    private MemoryStream emptyMemoryStream;

    public HttpResponseBody()
    {
        emptyMemoryStream = new MemoryStream();
    }
    public void Dispose()
    {
        emptyMemoryStream.Dispose();
    }

    public Stream OpenResponse()
    {
        return emptyMemoryStream;
    }

    public Task<Stream> OpenResponseAsync()
    {
        throw new NotImplementedException();
    }
}