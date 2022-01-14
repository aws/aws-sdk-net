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
 * Do not modify this file. This file is generated from the kinesis-video-media-2017-09-30.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.KinesisVideoMedia;
using Amazon.KinesisVideoMedia.Model;
using Amazon.KinesisVideoMedia.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class KinesisVideoMediaMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("kinesis-video-media");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("KinesisVideoMedia")]
        public void GetMediaMarshallTest()
        {
            var operation = service_model.FindOperation("GetMedia");

            var request = InstantiateClassGenerator.Execute<GetMediaRequest>();
            var marshaller = new GetMediaRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetMedia", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetMediaResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetMediaResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("KinesisVideoMedia")]
        public void GetMedia_ClientLimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetMedia");

            var request = InstantiateClassGenerator.Execute<GetMediaRequest>();
            var marshaller = new GetMediaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetMedia", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ClientLimitExceededException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ClientLimitExceededException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetMediaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("KinesisVideoMedia")]
        public void GetMedia_ConnectionLimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetMedia");

            var request = InstantiateClassGenerator.Execute<GetMediaRequest>();
            var marshaller = new GetMediaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetMedia", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConnectionLimitExceededException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ConnectionLimitExceededException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetMediaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("KinesisVideoMedia")]
        public void GetMedia_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetMedia");

            var request = InstantiateClassGenerator.Execute<GetMediaRequest>();
            var marshaller = new GetMediaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetMedia", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidArgumentException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetMediaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("KinesisVideoMedia")]
        public void GetMedia_InvalidEndpointExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetMedia");

            var request = InstantiateClassGenerator.Execute<GetMediaRequest>();
            var marshaller = new GetMediaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetMedia", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidEndpointException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidEndpointException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetMediaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("KinesisVideoMedia")]
        public void GetMedia_NotAuthorizedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetMedia");

            var request = InstantiateClassGenerator.Execute<GetMediaRequest>();
            var marshaller = new GetMediaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetMedia", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotAuthorizedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotAuthorizedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetMediaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("KinesisVideoMedia")]
        public void GetMedia_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetMedia");

            var request = InstantiateClassGenerator.Execute<GetMediaRequest>();
            var marshaller = new GetMediaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetMedia", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceNotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetMediaResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}