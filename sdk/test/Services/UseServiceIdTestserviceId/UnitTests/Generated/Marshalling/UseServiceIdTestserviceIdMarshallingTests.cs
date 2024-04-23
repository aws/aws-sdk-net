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
 * Do not modify this file. This file is generated from the use-service-id-2022-07-12.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.UseServiceIdTestserviceId;
using Amazon.UseServiceIdTestserviceId.Model;
using Amazon.UseServiceIdTestserviceId.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class UseServiceIdTestserviceIdMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("use-service-id-test");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("UseServiceIdTestserviceId")]
        public void NoPayloadMarshallTest()
        {
            var operation = service_model.FindOperation("NoPayload");

            var request = InstantiateClassGenerator.Execute<NoPayloadRequest>(operation);
            var marshaller = new NoPayloadRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("NoPayload", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = NoPayloadResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as NoPayloadResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}