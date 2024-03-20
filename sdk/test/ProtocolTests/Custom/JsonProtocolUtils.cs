using Amazon.Runtime.Internal;
using AWSSDK.ProtocolTests.Utils;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceClientGenerator;
namespace AWSSDK.ProtocolTests.Utils
{
    internal static class JsonProtocolUtils
    {
        public static void AssertBody(IRequest actualRequest, string expectedBody )
        {
            string actualBody;
            if (actualRequest.ContentStream != null)
            {
                actualBody = ProtocolTestUtils.GetContentStreamBody(actualRequest.ContentStream);
                Assert.AreEqual(actualBody, expectedBody);
            }

            else
            {
                actualBody = Encoding.UTF8.GetString(actualRequest.Content);
                //if the body is just a raw string and not a json document, just compare the two strings
                if (!actualBody.StartsWith("{"))
                {
                    Assert.AreEqual(expectedBody,actualBody);
                    return;
                }
                JObject actualJObj = JsonConvert.DeserializeObject<JObject>(actualBody);
                JObject expectedJObj = JsonConvert.DeserializeObject<JObject>(expectedBody);
                Assert.IsTrue(JObject.DeepEquals(expectedJObj, actualJObj));
            }
        }
    }
}
