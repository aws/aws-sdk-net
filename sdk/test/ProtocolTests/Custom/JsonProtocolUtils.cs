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
                Assert.AreEqual(expectedBody, actualBody);
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
