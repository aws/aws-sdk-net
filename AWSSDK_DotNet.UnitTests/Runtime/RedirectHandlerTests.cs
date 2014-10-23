using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using System.IO;
using AWSSDK_DotNet35.UnitTests;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Util;
using System.Threading;
using System.Net;
using System.Reflection;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace AWSSDK.UnitTests
{
    [TestClass()]
    public class RedirectHandlerTests : RuntimePipelineTestBase<RedirectHandler>
    {
        const string RedirectLocation = "http://redirect.s3.amazonaws.com/";

        [ClassInitialize]
        public static void Initialize(TestContext t)
        {
            Handler = new RedirectHandler();
            RuntimePipeline.AddHandler(Handler);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestRedirect()
        {
            var context = CreateTestContext();
            var httpResponse = context.ResponseContext.HttpResponse;
            Tester.Reset();
            Tester.Action2 = (callCount, executionContext) =>
            {
                if (callCount == 1)
                {
                    executionContext.ResponseContext.HttpResponse = new HttpWebRequestResponseData(
                        HttpWebResponseHelper.Create(HttpStatusCode.TemporaryRedirect,
                                new WebHeaderCollection { { "location", RedirectLocation } }));
                }
                else
                {
                    executionContext.ResponseContext.HttpResponse = httpResponse;
                }
            };
            Tester.Validate = (int callCount) =>
            {
                if (callCount == 2)
                {
                    Assert.AreEqual(RedirectLocation, context.RequestContext.Request.Endpoint.AbsoluteUri);
                }
            };

            RuntimePipeline.InvokeSync(context);
            Assert.AreEqual(2, Tester.CallCount);
        }


#if BCL45

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async45")]
        public async Task TestRedirectAsync()
        {
            var context = CreateTestContext();
            var httpResponse = context.ResponseContext.HttpResponse;
            Tester.Reset();
            Tester.Action2 = (callCount, executionContext) =>
            {
                if (callCount == 1)
                {
                    executionContext.ResponseContext.HttpResponse = new HttpWebRequestResponseData(
                        HttpWebResponseHelper.Create(HttpStatusCode.TemporaryRedirect,
                                new WebHeaderCollection { { "location", RedirectLocation } }));
                }
                else
                {
                    executionContext.ResponseContext.HttpResponse = httpResponse;
                }
            };
            Tester.Validate = (int callCount) =>
            {
                if (callCount == 2)
                {
                    Assert.AreEqual(RedirectLocation, context.RequestContext.Request.Endpoint.AbsoluteUri);
                }
            };

            await RuntimePipeline.InvokeAsync<AmazonWebServiceResponse>(context);
            Assert.AreEqual(2, Tester.CallCount);
        }

#elif !BCL45 && BCL

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async35")]
        public void TestRedirectAsync()
        {
            var context = CreateAsyncTestContext();        
            var httpResponse = context.ResponseContext.HttpResponse;
            Tester.Reset();
            Tester.Action2 = (callCount, executionContext) =>
            {
                if (callCount == 1)
                {
                    executionContext.ResponseContext.HttpResponse = new HttpWebRequestResponseData(
                        HttpWebResponseHelper.Create(HttpStatusCode.TemporaryRedirect,
                                new WebHeaderCollection { { "location", RedirectLocation } }));
                }
                else
                {
                    executionContext.ResponseContext.HttpResponse = httpResponse;
                }
            };
            Tester.Validate = (int callCount) =>
            {
                if (callCount == 2)
                {
                    Assert.AreEqual(RedirectLocation, context.RequestContext.Request.Endpoint.AbsoluteUri);
                }
            };

            var asyncResult = RuntimePipeline.InvokeAsync(context);
            asyncResult.AsyncWaitHandle.WaitOne();
            Assert.AreEqual(2, Tester.CallCount);
        }

#endif

    }

    public class HttpWebResponseHelper
    {
        public static HttpWebResponse Create(HttpStatusCode statusCode, WebHeaderCollection headers)
        {
            var type = typeof(HttpWebResponse);
            var assembly = Assembly.GetAssembly(type);
            var obj = assembly.CreateInstance("System.Net.HttpWebResponse");

            var statusFieldInfo = type.GetField("m_StatusCode",
                BindingFlags.NonPublic | BindingFlags.Instance);
            var headersFieldInfo = type.GetField("m_HttpResponseHeaders",
                BindingFlags.NonPublic | BindingFlags.Instance);

            statusFieldInfo.SetValue(obj, statusCode);
            headersFieldInfo.SetValue(obj, headers);

            return obj as HttpWebResponse;
        }
    }
}
