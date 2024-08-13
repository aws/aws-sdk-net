using Amazon.Runtime.Internal;
using System;
using System.Collections.Generic;
using Xunit;

namespace AWSSDK.CSMUtilitiesTests.NetFramework
{
    public class CSMUtilitiesTests
    {
        [Fact]
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

            foreach(var requestName in requestNameApiName.Keys)
            {
                Assert.Equal(requestNameApiName[requestName], CSMUtilities.GetApiNameFromRequest(requestName, apiNameMapping, "foobar"));
            }
        }

        [Fact]
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
                Assert.Equal(requestNameApiName[requestName], CSMUtilities.GetApiNameFromRequest(requestName, apiNameMapping, "foobar"));
            }
        }
    }
}
