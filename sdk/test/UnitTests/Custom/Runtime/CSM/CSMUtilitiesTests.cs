using Amazon.Runtime.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AWSSDK.UnitTests.Runtime.CSM
{
    [TestClass]
    public class CSMUtilitiesTests
    {
        [TestMethod]
        [TestCategory("CSM")]
        public void TestGetApiNameFromRequestWithMapping()
        {
            var apiNameMapping = new Dictionary<string, string>(1)
            {
                {"PutBucket", "CreateBucket"}
            };

            var requestNameApiName = new Dictionary<string, string>(4)
            {
                { "PutBucketRequest", "CreateBucket" },
                { "ApiRequestRequest", "ApiRequest" },
                { "RequestApiRequest", "RequestApi" },
                { "RequestApirequest", string.Empty }
            };

            foreach (var requestName in requestNameApiName.Keys)
            {
                Assert.AreEqual(requestNameApiName[requestName], CSMUtilities.GetApiNameFromRequest(requestName, apiNameMapping, "foobar"));
            }
        }

        [TestMethod]
        [TestCategory("CSM")]
        public void TestGetApiNameFromRequest()
        {
            var apiNameMapping = new Dictionary<string, string>(0)
            {
            };

            var requestNameApiName = new Dictionary<string, string>(3)
            {
                { "ApiRequestRequest", "ApiRequest" },
                { "RequestApiRequest", "RequestApi" },
                { "RequestApirequest", string.Empty }
            };

            foreach (var requestName in requestNameApiName.Keys)
            {
                Assert.AreEqual(requestNameApiName[requestName], CSMUtilities.GetApiNameFromRequest(requestName, apiNameMapping, "foobar"));
            }
        }
    }
}
