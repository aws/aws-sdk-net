/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Lambda;
using Amazon.Lambda.Model;
using Amazon.Lambda.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;
using Amazon;
using AWSSDK.UnitTests;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{    
    public partial class LambdaMarshallingTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lambda")]
        public void TestInvokeResponseBody()
        {
            var responseBody = "Process exited before completing request:TypeError: Object #<LambdaEventResponse> has no method 'write': at exports.handler (/var/task/helloworld.js:4:14)";
            var requestId = "fakerequ-esti-dfak-ereq-uestidfakere";

            using(var client = new Amazon.Lambda.AmazonLambdaClient(new Amazon.Runtime.AnonymousAWSCredentials(), RegionEndpoint.USEast1))
            {
                CustomResponses.SetResponse(client, responseBody, requestId, isOK: true);

                var response = client.Invoke(new InvokeRequest
                {
                    FunctionName = "TestFunction"
                });
                Assert.AreEqual(requestId, response.ResponseMetadata.RequestId);
                Assert.AreEqual(responseBody, Encoding.UTF8.GetString(response.Payload.ToArray()));
            }
        }
    }
}