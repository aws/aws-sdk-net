using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.IO;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;

namespace AWSSDK_DotNet.CommonTest.Utils
{
    public abstract class Servlet : IDisposable
    {
        // Private members
        private static HashSet<int> _usedPorts = new HashSet<int>();
        [ThreadStatic]
        private static Random _random;

        private HttpListener _listener;
        private bool _shouldStop = false;
        private Thread _thread = null;

        // Properties
        public int Port { get; private set; }
        public string Path { get; private set; }
        public bool Debug { get; set; }
        public bool RethrowExceptions { get; set; }
        public TimeSpan StreamDelays { get; set; }
        public uint ResponseBatchSize { get; set; }
        public Uri Url
        {
            get
            {
                return new Uri("http://localhost:" + Port + Path);
            }
        }
        public string ServiceURL
        {
            get
            {
                return Url.AbsoluteUri;
            }
        }

        // Public methods
        public void Stop()
        {
            _shouldStop = true;
        }

        // Static methods
        public static int NextAvailablePort
        {
            get
            {
                return _usedPorts.Max() + 1;
            }
        }

        // Constructor

        public Servlet()
            : this(FindFreePort()) { }

        public Servlet(int port)
            : this(port, "/") { }

        public Servlet(string path)
            : this(FindFreePort(), path) { }

        public Servlet(int port, string path)
        {
            if (_usedPorts.Contains(port))
                throw new ArgumentException("Port already being used by servlet");

            Path = path;
            Port = port;
            _usedPorts.Add(port);

            StreamDelays = TimeSpan.Zero;
            ResponseBatchSize = 256;

            _listener = new HttpListener();
            _listener.Prefixes.Add(Url.ToString());

            _thread = new Thread(new ThreadStart(StartServlet));
            _thread.IsBackground = true;
            _thread.Name = "Servlet " + Port;
            _thread.Start();
        }

        private static int FindFreePort()
        {
            for (int i = 0; i < 10; i++)
            {
                int port = RandomPort();
                if (!_usedPorts.Contains(port) && !IsBusy(port))
                    return port;
            }
            throw new InvalidOperationException("Unable to find a free port after 10 tries");
        }
        private static int RandomPort()
        {
            if (_random == null)
                _random = new Random((int)DateTime.UtcNow.Ticks);
            return _random.Next(10000, 11000);
        }

        private static bool IsBusy(int port)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
                ProtocolType.Tcp);
            try
            {
                socket.SetSocketOption(SocketOptionLevel.Socket,
                    SocketOptionName.ExclusiveAddressUse, true);
                socket.Bind(new IPEndPoint(IPAddress.Any, port));
                socket.Listen(5);
                return false;
            }
            catch { return true; }
            finally { if (socket != null) socket.Close(); }
        }

        private void HttpWebListenerCallback(IAsyncResult result)
        {
            HttpListener listener = result.AsyncState as HttpListener;
            HttpListenerContext context;

            try{
                context = listener.EndGetContext(result);
            } catch(Exception){
                // HttpListener.Close() fires the callback for the final time for whatever reason.
                // Just handle it gracefully.
                return;
            }

            if (Debug)
            {
                Console.WriteLine(DateTime.UtcNow.ToString() + "Handling request");
                Console.WriteLine("\tRequest url - " + context.Request.Url);
                Console.WriteLine("\tHost address - " + context.Request.UserHostAddress);
                Console.WriteLine("\tServlet type - " + this.GetType().FullName);
            }

            try
            {
                HandleRequest(context);
            }
            catch (Exception e)
            {
                string exceptionText = e.ToString();
                if (Debug)
                {
                    Console.WriteLine("Exception encountered: " + exceptionText);
                }
                if (RethrowExceptions)
                {
                    throw;
                }
                WriteResponse(context.Response, exceptionText);
            }
            try
            {
                context.Response.OutputStream.Close();
            }
            catch { }
        }

        private void StartServlet()
        {
            _listener.Start();
            while (!_shouldStop )
            {
                var asyncResult = _listener.BeginGetContext(HttpWebListenerCallback, _listener);
                asyncResult.AsyncWaitHandle.WaitOne(100);
            }
            _listener.Stop();
        }

        protected virtual void HandleRequest(HttpListenerContext context)
        {
        }

        protected void WriteResponse(HttpListenerResponse response, string content)
        {
            WriteResponse(response, content, 200);
        }
        protected void WriteResponse(HttpListenerResponse response, string content, int status)
        {
            WriteResponse(response, content, status, null);
        }
        protected void WriteResponse(HttpListenerResponse response, string content, int status, IDictionary<string, string> headers)
        {
            if (headers != null)
            {
                foreach (var kvp in headers)
                {
                    string name = kvp.Key;
                    string value = kvp.Value;
                    if (string.Equals(name, "Content-Length", StringComparison.OrdinalIgnoreCase))
                        response.ContentLength64 = long.Parse(value, CultureInfo.InvariantCulture);
                    else
                        response.Headers[kvp.Key] = kvp.Value;
                }
            }

            response.StatusCode = status;
            byte[] responseBytes = Encoding.UTF8.GetBytes(content);

            using (response.OutputStream)
            using (MemoryStream stream = new MemoryStream(responseBytes))
            {
                response.OutputStream.Write(responseBytes, 0, responseBytes.Length);
            }
        }
        protected virtual void Cleanup()
        {
        }

        #region IDisposable Members

        public virtual void Dispose()
        {
            Stop();
            _thread.Join();
            Cleanup();
            _usedPorts.Remove(Port);
        }

        #endregion
    }

    public class ErrorServlet : Servlet
    {
        public int StatusCode { get; set; }
        public string Response { get; set; }

        public ErrorServlet(int statusCode)
            : base()
        {
            StatusCode = statusCode;
        }
        public ErrorServlet(int port, int statusCode)
            : base(port)
        {
            StatusCode = statusCode;
        }
        public ErrorServlet()
            : this(500)
        {
        }

        protected override void HandleRequest(HttpListenerContext context)
        {
            if (Debug)
            {
                Console.WriteLine(context.Request.Url);
                Console.WriteLine("Headers:");
                foreach (var headerName in context.Request.Headers.AllKeys)
                {
                    Console.WriteLine(headerName + ": " + context.Request.Headers[headerName]);
                }
            }
            context.Response.StatusCode = StatusCode;

            if (!string.IsNullOrEmpty(Response))
            {
                var bytes = UTF8Encoding.UTF8.GetBytes(Response);
                context.Response.OutputStream.Write(bytes, 0, bytes.Length);
            }
        }
    }

    public class DebugServlet : Servlet
    {
        public delegate object OnRequestHandler(HttpListenerRequest request);

        public event OnRequestHandler OnRequest;
        public object DebugData { get; set; }

        protected override void HandleRequest(HttpListenerContext context)
        {
            if (OnRequest != null)
                DebugData = OnRequest(context.Request);
        }
    }

    public class ResponseTestServlet : Servlet
    {
        public ResponseTestServlet()
            : this("/") {}

        public ResponseTestServlet(string path)
            : base(path)
        {
            StatusCode = 200;
            Headers = new Dictionary<string, string>();
        }

        private string _response;

        public string Response
        {
            get { return _response; }
            set
            {
                _response = value;
                Headers["Content-Length"]
                    = (_response == null ? 0 : _response.Length).ToString(CultureInfo.InvariantCulture);
            }
        }

        public int StatusCode { get; set; }
        public Dictionary<string, string> Headers { get; set; }

        protected override void HandleRequest(HttpListenerContext context)
        {
            WriteResponse(context.Response, Response, StatusCode, Headers);
        }
    }

    public class MultipleResponseServlet : Servlet
    {
        public MultipleResponseServlet() : base() { }

        [DebuggerDisplay("{" + nameof(StatusCode) + "} - {" + nameof(Contents) + "}")]
        public class Response
        {
            public int StatusCode { get; set; }
            public string Contents { get; set; }
            public Dictionary<string, string> Headers { get; set; }

            public Response()
            {
                StatusCode = 200;
                Headers = new Dictionary<string, string>();
            }
        }
        public delegate Response RequestHandler(string path);
        public event RequestHandler OnRequest;

        protected override void HandleRequest(HttpListenerContext context)
        {
            var response = OnRequest(context.Request.RawUrl);
            WriteResponse(context.Response, response.Contents, response.StatusCode, response.Headers);
        }

        public Response ErrorResponse(string path)
        {
            return new Response { StatusCode = 404 };
        }
    }
}
