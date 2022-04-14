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

/*
 * Do not modify this file. This file is generated from the bearer-token-auth-test-2022-03-21.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.BearerTokenAuthTest;
using Amazon.BearerTokenAuthTest.Model;
using Amazon.BearerTokenAuthTest.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class BearerTokenAuthTestMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("bearer-token-auth-test");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("BearerTokenAuthTest")]
        public void InheritBearerAuthOperationMarshallTest()
        {
            var operation = service_model.FindOperation("InheritBearerAuthOperation");

            var request = InstantiateClassGenerator.Execute<InheritBearerAuthOperationRequest>();
            var marshaller = new InheritBearerAuthOperationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("InheritBearerAuthOperation", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = InheritBearerAuthOperationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as InheritBearerAuthOperationResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("BearerTokenAuthTest")]
        public void OverrideAuthToSigV4OperationMarshallTest()
        {
            var operation = service_model.FindOperation("OverrideAuthToSigV4Operation");

            var request = InstantiateClassGenerator.Execute<OverrideAuthToSigV4OperationRequest>();
            var marshaller = new OverrideAuthToSigV4OperationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("OverrideAuthToSigV4Operation", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = OverrideAuthToSigV4OperationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as OverrideAuthToSigV4OperationResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}