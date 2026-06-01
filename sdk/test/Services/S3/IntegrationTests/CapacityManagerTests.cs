using Amazon.S3;
using AWSSDK_DotNet.CommonTest.Utils;
using System;
using System.Collections.Generic;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
#if NETFRAMEWORK
    [Trait("Category", "S3")]
    public class CapacityManagerTests
    {
        public static int requestCount;

        private const string ListObjectsResponseXml =
            @"<?xml version=""1.0"" encoding=""UTF-8""?>
<ListBucketResult xmlns=""http://s3.amazonaws.com/doc/2006-03-01/"">
    <Name>bucket</Name>
    <Prefix/>
    <Marker/>
    <MaxKeys>1000</MaxKeys>
    <IsTruncated>false</IsTruncated>
    <Contents>
        <Key>my-image.jpg</Key>
        <LastModified>2009-10-12T17:50:30.000Z</LastModified>
        <ETag>&quot;fba9dede5f27731c9771645a39863328&quot;</ETag>
        <Size>434234</Size>
        <StorageClass>STANDARD</StorageClass>
    </Contents>
</ListBucketResult>";

        /// <summary>
        /// Background Info:- Each retry request requires 5 capacity. On successful retry response 5 would be put back into the
        /// capacity. On a successful response which is not a retry request 1 is added to the capacity. The capacity has a max cap 
        /// that is not exceeded.
        /// Dependency: This test uses the ListObjectsResponseXml constant which contains a sample success ListObject response.
        /// This Integration test works in three phases.
        /// Phase 1. Keeping in mind that we can make a 100 requests with the current set configurations, 500 requests are made
        /// to a mock servlet which returns back a 500 error which leads to 500 retry requests. As the capacity can only handle 
        /// a 100, this leads to the capacity getting depleted. An assert proves the number of retry requests that was made.
        /// Phase 2. With the capacity completely entry, phase 2 makes 500 requests for which the mock servlet returns a success
        /// response. This puts back enough capacity to make a 100 retry requests.
        /// Phase 3. Phase 1 is repeated again with an assert to prove that Phase 2 added the said capacity.
        /// </summary>
        [Fact]
        public void S3CapacityManagerIntegrationTest()
        {
            int TotalRequests = 500;
            int RetryRequests = 100;
            int ExtraRequests = TotalRequests-RetryRequests;
            requestCount = 0;
            var retryFlag = true;

            using (MultipleResponseServlet servlet = new MultipleResponseServlet())
            {
                servlet.OnRequest += path =>
                {
                    requestCount++;
                    if (retryFlag)
                    {
                        return new MultipleResponseServlet.Response
                        {
                            Contents = "foo",
                            Headers = new Dictionary<string, string>(),
                            StatusCode = 500
                        };
                    }
                    else
                    {
                        return new MultipleResponseServlet.Response
                        {
                            Contents = ListObjectsResponseXml,
                            Headers = new Dictionary<string, string>(),
                            StatusCode = 200
                        };
                    }
                };

                using (var client = new AmazonS3Client(new AmazonS3Config 
                { 
                    ServiceURL = "http://localhost:" + servlet.Port,
                    MaxErrorRetry = 1
                }))
                {
                    retryFlag = true;
                    FailureRetryRequests(TotalRequests, RetryRequests, ExtraRequests, client);
                    retryFlag = false;
                    requestCount = 0;
                    for (int i = 0; i < TotalRequests; i++)
                    {
                        var response = client.ListObjects("CapacityManagerTests");
                    }
                    retryFlag = true;
                    requestCount = 0;
                    FailureRetryRequests(TotalRequests, RetryRequests, ExtraRequests, client);
                }
            }
        }

        private static void FailureRetryRequests(int totalRequests, int retryRequests, int extraRequests, AmazonS3Client client)
        {
            for (int i = 0; i < totalRequests; i++)
            {
                try
                {
                    var response = client.ListObjects("CapacityManagerTests");
                }
                catch (Exception)
                {
                    if (i == totalRequests - 1)
                    {
                        Assert.Equal(retryRequests * 2, requestCount - extraRequests);
                    }
                    continue;
                }
            }
        }
    }
#endif
}
