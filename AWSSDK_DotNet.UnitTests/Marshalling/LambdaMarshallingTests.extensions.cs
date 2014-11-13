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

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{    
    public partial class LambdaMarshallingTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lambda")]
        public void AddEventSourceMarshallTestForDataTypeCustomization()
        {
            var operation = service_model.FindOperation("AddEventSource");

            var request = InstantiateClassGenerator.Execute<AddEventSourceRequest>();
            var marshaller = new AddEventSourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("AddEventSource", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();

            // The service returns IsActive as a string and it's unmarshalled as a bool to set the 
            // AddEventSourceResponse.IsActive bool property.
            if (payloadResponse.Contains("\"IsActive\"     : true"))
                payloadResponse = payloadResponse.Replace("\"IsActive\"     : true", "\"IsActive\"     : \"true\"");
            else
                throw new InvalidOperationException("Could not replace json in sample response");

            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = AddEventSourceResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as AddEventSourceResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }


    }
}