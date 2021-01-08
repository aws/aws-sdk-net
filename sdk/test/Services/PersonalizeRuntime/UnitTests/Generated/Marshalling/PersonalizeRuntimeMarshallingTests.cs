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
 * Do not modify this file. This file is generated from the personalize-runtime-2018-05-22.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.PersonalizeRuntime;
using Amazon.PersonalizeRuntime.Model;
using Amazon.PersonalizeRuntime.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class PersonalizeRuntimeMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("personalize-runtime");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("PersonalizeRuntime")]
        public void GetPersonalizedRankingMarshallTest()
        {
            var operation = service_model.FindOperation("GetPersonalizedRanking");

            var request = InstantiateClassGenerator.Execute<GetPersonalizedRankingRequest>();
            var marshaller = new GetPersonalizedRankingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetPersonalizedRanking", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetPersonalizedRankingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetPersonalizedRankingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("PersonalizeRuntime")]
        public void GetPersonalizedRanking_InvalidInputExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetPersonalizedRanking");

            var request = InstantiateClassGenerator.Execute<GetPersonalizedRankingRequest>();
            var marshaller = new GetPersonalizedRankingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetPersonalizedRanking", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidInputException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidInputException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetPersonalizedRankingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("PersonalizeRuntime")]
        public void GetPersonalizedRanking_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetPersonalizedRanking");

            var request = InstantiateClassGenerator.Execute<GetPersonalizedRankingRequest>();
            var marshaller = new GetPersonalizedRankingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetPersonalizedRanking", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceNotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetPersonalizedRankingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("PersonalizeRuntime")]
        public void GetRecommendationsMarshallTest()
        {
            var operation = service_model.FindOperation("GetRecommendations");

            var request = InstantiateClassGenerator.Execute<GetRecommendationsRequest>();
            var marshaller = new GetRecommendationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetRecommendations", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetRecommendationsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetRecommendationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("PersonalizeRuntime")]
        public void GetRecommendations_InvalidInputExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetRecommendations");

            var request = InstantiateClassGenerator.Execute<GetRecommendationsRequest>();
            var marshaller = new GetRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetRecommendations", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidInputException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidInputException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("PersonalizeRuntime")]
        public void GetRecommendations_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetRecommendations");

            var request = InstantiateClassGenerator.Execute<GetRecommendationsRequest>();
            var marshaller = new GetRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetRecommendations", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceNotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}