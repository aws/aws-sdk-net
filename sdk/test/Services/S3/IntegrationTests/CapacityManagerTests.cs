/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Xml;
using System.Threading;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime.Internal;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using System.IO;

using AWSSDK_DotNet.IntegrationTests.Utils;
using AWSSDK_DotNet.CommonTest.Utils;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Integration Test class for Capacity Manager test on S3 ListObject operation.
    /// </summary>
    
    [TestClass]
    public class CapacityManagerTests
    {
        public static int requestCount;
        [TestMethod]
        [TestCategory("S3")]
        /// <summary>
        /// Background Info:- Each retry request requires 5 capacity. On successful retry response 5 would be put back into the
        /// capacity. On a successful response which is not a retry request 1 is added to the capacity. The capacity has a max cap 
        /// that is not exceeded.
        /// Dependency:- This test depends on the file ListObjectsResponse.xml which contains a sample success ListObject response.
        /// This Integration test works in three phases.
        /// Phase 1. Keeping in mind that we can make a 100 requests with the current set configurations, 500 requests are made
        /// to a mock servlet which returns back a 500 error which leads to 500 retry requests. As the capacity can only handle 
        /// a 100, this leads to the capacity getting depleted. An assert proves the number of retry requests that was made.
        /// Phase 2. With the capacity completely entry, phase 2 makes 500 requests for which the mock servlet returns a success
        /// response. This puts back enough capacity to make a 100 retry requests.
        /// Phase 3. Phase 1 is repeated again with an assert to prove that Phase 2 added the said capacity.
        /// </summary>
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
                        var xmlDoc = UtilityMethods.GetResourceText("ListObjectsResponse.xml");
                        XmlDocument myxml = new XmlDocument();
                        myxml.LoadXml(xmlDoc);
                        string contents = myxml.InnerXml;
                        return new MultipleResponseServlet.Response
                        {
                            Contents = contents,
                            Headers = new Dictionary<string, string>(),
                            StatusCode = 200
                        };
                    }
                };
                string server = "http://localhost:" + servlet.Port;
                using (var client = new AmazonS3Client(new AmazonS3Config 
                { 
                    ServiceURL = server,
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
                        Assert.AreEqual(retryRequests * 2, requestCount - extraRequests);
                    }
                    continue;
                }
            }
        }
    }
}