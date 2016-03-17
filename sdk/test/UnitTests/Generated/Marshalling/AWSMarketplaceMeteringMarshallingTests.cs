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

/*
 * Do not modify this file. This file is generated from the meteringmarketplace-2016-01-14.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.AWSMarketplaceMetering;
using Amazon.AWSMarketplaceMetering.Model;
using Amazon.AWSMarketplaceMetering.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class AWSMarketplaceMeteringMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("meteringmarketplace-2016-01-14.normal.json", "");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSMarketplaceMetering")]
        public void MeterUsageMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<MeterUsageRequest>();
            var marshaller = new MeterUsageRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<MeterUsageRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("MeterUsage").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = MeterUsageResponseUnmarshaller.Instance.Unmarshall(context)
                as MeterUsageResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

            }
}