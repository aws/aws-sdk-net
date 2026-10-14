using System;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using AWSSDK_DotNet.CommonTest.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Regression test for https://github.com/aws/aws-sdk-net/issues/4534: once response headers are received,
    /// the cancellation token must still abort a body read that never completes.
    /// </summary>
    [TestClass]
    public class UnmarshallerCancellationTests
    {
        /// <summary>
        /// Sends the given status with the start of a ListBucketResult body, then holds the connection open without
        /// sending the rest until released.
        /// </summary>
        private class StalledBodyServlet : Servlet
        {
            private readonly ManualResetEventSlim _release = new ManualResetEventSlim(false);
            private readonly int _statusCode;

            public StalledBodyServlet(int statusCode)
            {
                _statusCode = statusCode;
            }

            public void Release()
            {
                _release.Set();
            }

            protected override void HandleRequest(HttpListenerContext context)
            {
                var partialBody = Encoding.UTF8.GetBytes(
                    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                    "<ListBucketResult xmlns=\"http://s3.amazonaws.com/doc/2006-03-01/\">" +
                    "<Name>bucket</Name><Contents><Key>a</Key>");

                context.Response.StatusCode = _statusCode;
                context.Response.ContentType = "application/xml";
                context.Response.SendChunked = true;
                context.Response.OutputStream.Write(partialBody, 0, partialBody.Length);
                context.Response.OutputStream.Flush();
                _release.Wait(TimeSpan.FromSeconds(10));
            }

            protected override void Cleanup()
            {
                _release.Dispose();
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public async Task CancellationIsHonoredWhenResponseBodyStalls()
        {
            await AssertCancelledAsync(200);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public async Task CancellationIsHonoredWhenErrorResponseBodyStalls()
        {
            await AssertCancelledAsync(500);
        }

        private static async Task AssertCancelledAsync(int statusCode)
        {
            using (var servlet = new StalledBodyServlet(statusCode))
            {
                var config = new AmazonS3Config
                {
                    ServiceURL = servlet.ServiceURL,
                    ForcePathStyle = true,
                    MaxErrorRetry = 0
                };

                using (var client = new AmazonS3Client(new BasicAWSCredentials("ACCESS", "SECRET"), config))
                using (var cts = new CancellationTokenSource(TimeSpan.FromMilliseconds(500)))
                {
                    var listTask = client.ListObjectsAsync(new ListObjectsRequest { BucketName = "bucket" }, cts.Token);
                    var completed = await Task.WhenAny(listTask, Task.Delay(TimeSpan.FromSeconds(5)));
                    servlet.Release();

                    if (completed != listTask)
                    {
                        Assert.Fail("ListObjectsAsync did not complete after the cancellation token was cancelled.");
                    }
                    await Assert.ThrowsExactlyAsync<TaskCanceledException>(() => listTask);
                }
            }
        }
    }
}
