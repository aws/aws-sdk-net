#if !NETFRAMEWORK
using Amazon.Util;
using AWSSDK_DotNet.CommonTest.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    [TestClass]
    [TestCategory("Core")]
    public class AWSSDKUtilsHttpRequestTests
    {
        private static readonly TimeSpan Timeout = TimeSpan.FromSeconds(5);

        [TestMethod]
        public async Task ExecuteHttpRequest_SequentialRequests_ShareOneConnection()
        {
            using (var servlet = new RecordingServlet())
            {
                for (var i = 0; i < 3; i++)
                {
                    Assert.AreEqual("ok", AWSSDKUtils.ExecuteHttpRequest(servlet.Url, "GET", null, Timeout, null, null));
                    Assert.AreEqual("ok", await AWSSDKUtils.ExecuteHttpRequestAsync(servlet.Url, "PUT", "body", Timeout, null, null));
                }

                Assert.AreEqual(6, servlet.Requests.Count);
                Assert.AreEqual(1, servlet.Requests.Select(r => r.RemoteEndPoint).Distinct().Count());
            }
        }

        [TestMethod]
        public void ExecuteHttpRequest_ResponseSetsCookie_NextRequestSendsNoCookie()
        {
            using (var servlet = new RecordingServlet())
            {
                AWSSDKUtils.ExecuteHttpRequest(servlet.Url, "GET", null, Timeout, null, null);
                AWSSDKUtils.ExecuteHttpRequest(servlet.Url, "GET", null, Timeout, null, null);

                Assert.AreEqual(2, servlet.Requests.Count);
                Assert.IsTrue(servlet.Requests.All(r => r.Cookie == null));
            }
        }

        private sealed class RecordingServlet : Servlet
        {
            public ConcurrentQueue<(string RemoteEndPoint, string Cookie)> Requests { get; } = new ConcurrentQueue<(string, string)>();

            protected override void HandleRequest(HttpListenerContext context)
            {
                Requests.Enqueue((context.Request.RemoteEndPoint.ToString(), context.Request.Headers["Cookie"]));
                WriteResponse(context.Response, "ok", 200, new Dictionary<string, string> { ["Set-Cookie"] = "session=1; Path=/" });
            }
        }
    }
}
#endif
