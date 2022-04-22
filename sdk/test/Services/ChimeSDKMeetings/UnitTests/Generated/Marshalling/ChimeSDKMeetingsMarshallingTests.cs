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
 * Do not modify this file. This file is generated from the chime-sdk-meetings-2021-07-15.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.ChimeSDKMeetings;
using Amazon.ChimeSDKMeetings.Model;
using Amazon.ChimeSDKMeetings.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class ChimeSDKMeetingsMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("chime-sdk-meetings");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void BatchCreateAttendeeMarshallTest()
        {
            var operation = service_model.FindOperation("BatchCreateAttendee");

            var request = InstantiateClassGenerator.Execute<BatchCreateAttendeeRequest>();
            var marshaller = new BatchCreateAttendeeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("BatchCreateAttendee", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = BatchCreateAttendeeResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as BatchCreateAttendeeResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void BatchCreateAttendee_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchCreateAttendee");

            var request = InstantiateClassGenerator.Execute<BatchCreateAttendeeRequest>();
            var marshaller = new BatchCreateAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchCreateAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("BadRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","BadRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = BatchCreateAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void BatchCreateAttendee_ForbiddenExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchCreateAttendee");

            var request = InstantiateClassGenerator.Execute<BatchCreateAttendeeRequest>();
            var marshaller = new BatchCreateAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchCreateAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ForbiddenException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ForbiddenException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = BatchCreateAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void BatchCreateAttendee_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchCreateAttendee");

            var request = InstantiateClassGenerator.Execute<BatchCreateAttendeeRequest>();
            var marshaller = new BatchCreateAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchCreateAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","LimitExceededException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = BatchCreateAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void BatchCreateAttendee_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchCreateAttendee");

            var request = InstantiateClassGenerator.Execute<BatchCreateAttendeeRequest>();
            var marshaller = new BatchCreateAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchCreateAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = BatchCreateAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void BatchCreateAttendee_ServiceFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchCreateAttendee");

            var request = InstantiateClassGenerator.Execute<BatchCreateAttendeeRequest>();
            var marshaller = new BatchCreateAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchCreateAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceFailureException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceFailureException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = BatchCreateAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void BatchCreateAttendee_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchCreateAttendee");

            var request = InstantiateClassGenerator.Execute<BatchCreateAttendeeRequest>();
            var marshaller = new BatchCreateAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchCreateAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceUnavailableException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceUnavailableException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = BatchCreateAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void BatchCreateAttendee_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchCreateAttendee");

            var request = InstantiateClassGenerator.Execute<BatchCreateAttendeeRequest>();
            var marshaller = new BatchCreateAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchCreateAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = BatchCreateAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void BatchCreateAttendee_UnauthorizedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchCreateAttendee");

            var request = InstantiateClassGenerator.Execute<BatchCreateAttendeeRequest>();
            var marshaller = new BatchCreateAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchCreateAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnauthorizedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = BatchCreateAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void BatchCreateAttendee_UnprocessableEntityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchCreateAttendee");

            var request = InstantiateClassGenerator.Execute<BatchCreateAttendeeRequest>();
            var marshaller = new BatchCreateAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchCreateAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnprocessableEntityException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnprocessableEntityException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = BatchCreateAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void CreateAttendeeMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAttendee");

            var request = InstantiateClassGenerator.Execute<CreateAttendeeRequest>();
            var marshaller = new CreateAttendeeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateAttendee", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = CreateAttendeeResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as CreateAttendeeResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void CreateAttendee_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAttendee");

            var request = InstantiateClassGenerator.Execute<CreateAttendeeRequest>();
            var marshaller = new CreateAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("BadRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","BadRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void CreateAttendee_ForbiddenExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAttendee");

            var request = InstantiateClassGenerator.Execute<CreateAttendeeRequest>();
            var marshaller = new CreateAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ForbiddenException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ForbiddenException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void CreateAttendee_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAttendee");

            var request = InstantiateClassGenerator.Execute<CreateAttendeeRequest>();
            var marshaller = new CreateAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","LimitExceededException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void CreateAttendee_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAttendee");

            var request = InstantiateClassGenerator.Execute<CreateAttendeeRequest>();
            var marshaller = new CreateAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void CreateAttendee_ServiceFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAttendee");

            var request = InstantiateClassGenerator.Execute<CreateAttendeeRequest>();
            var marshaller = new CreateAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceFailureException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceFailureException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void CreateAttendee_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAttendee");

            var request = InstantiateClassGenerator.Execute<CreateAttendeeRequest>();
            var marshaller = new CreateAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceUnavailableException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceUnavailableException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void CreateAttendee_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAttendee");

            var request = InstantiateClassGenerator.Execute<CreateAttendeeRequest>();
            var marshaller = new CreateAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void CreateAttendee_UnauthorizedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAttendee");

            var request = InstantiateClassGenerator.Execute<CreateAttendeeRequest>();
            var marshaller = new CreateAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnauthorizedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void CreateAttendee_UnprocessableEntityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAttendee");

            var request = InstantiateClassGenerator.Execute<CreateAttendeeRequest>();
            var marshaller = new CreateAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnprocessableEntityException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnprocessableEntityException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void CreateMeetingMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMeeting");

            var request = InstantiateClassGenerator.Execute<CreateMeetingRequest>();
            var marshaller = new CreateMeetingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateMeeting", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = CreateMeetingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as CreateMeetingResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void CreateMeeting_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMeeting");

            var request = InstantiateClassGenerator.Execute<CreateMeetingRequest>();
            var marshaller = new CreateMeetingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateMeeting", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("BadRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","BadRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateMeetingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void CreateMeeting_ForbiddenExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMeeting");

            var request = InstantiateClassGenerator.Execute<CreateMeetingRequest>();
            var marshaller = new CreateMeetingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateMeeting", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ForbiddenException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ForbiddenException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateMeetingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void CreateMeeting_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMeeting");

            var request = InstantiateClassGenerator.Execute<CreateMeetingRequest>();
            var marshaller = new CreateMeetingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateMeeting", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","LimitExceededException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateMeetingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void CreateMeeting_ServiceFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMeeting");

            var request = InstantiateClassGenerator.Execute<CreateMeetingRequest>();
            var marshaller = new CreateMeetingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateMeeting", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceFailureException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceFailureException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateMeetingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void CreateMeeting_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMeeting");

            var request = InstantiateClassGenerator.Execute<CreateMeetingRequest>();
            var marshaller = new CreateMeetingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateMeeting", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceUnavailableException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceUnavailableException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateMeetingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void CreateMeeting_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMeeting");

            var request = InstantiateClassGenerator.Execute<CreateMeetingRequest>();
            var marshaller = new CreateMeetingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateMeeting", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateMeetingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void CreateMeeting_UnauthorizedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMeeting");

            var request = InstantiateClassGenerator.Execute<CreateMeetingRequest>();
            var marshaller = new CreateMeetingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateMeeting", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnauthorizedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateMeetingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void CreateMeetingWithAttendeesMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMeetingWithAttendees");

            var request = InstantiateClassGenerator.Execute<CreateMeetingWithAttendeesRequest>();
            var marshaller = new CreateMeetingWithAttendeesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateMeetingWithAttendees", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = CreateMeetingWithAttendeesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as CreateMeetingWithAttendeesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void CreateMeetingWithAttendees_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMeetingWithAttendees");

            var request = InstantiateClassGenerator.Execute<CreateMeetingWithAttendeesRequest>();
            var marshaller = new CreateMeetingWithAttendeesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateMeetingWithAttendees", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("BadRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","BadRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateMeetingWithAttendeesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void CreateMeetingWithAttendees_ForbiddenExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMeetingWithAttendees");

            var request = InstantiateClassGenerator.Execute<CreateMeetingWithAttendeesRequest>();
            var marshaller = new CreateMeetingWithAttendeesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateMeetingWithAttendees", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ForbiddenException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ForbiddenException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateMeetingWithAttendeesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void CreateMeetingWithAttendees_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMeetingWithAttendees");

            var request = InstantiateClassGenerator.Execute<CreateMeetingWithAttendeesRequest>();
            var marshaller = new CreateMeetingWithAttendeesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateMeetingWithAttendees", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","LimitExceededException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateMeetingWithAttendeesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void CreateMeetingWithAttendees_ServiceFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMeetingWithAttendees");

            var request = InstantiateClassGenerator.Execute<CreateMeetingWithAttendeesRequest>();
            var marshaller = new CreateMeetingWithAttendeesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateMeetingWithAttendees", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceFailureException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceFailureException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateMeetingWithAttendeesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void CreateMeetingWithAttendees_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMeetingWithAttendees");

            var request = InstantiateClassGenerator.Execute<CreateMeetingWithAttendeesRequest>();
            var marshaller = new CreateMeetingWithAttendeesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateMeetingWithAttendees", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceUnavailableException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceUnavailableException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateMeetingWithAttendeesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void CreateMeetingWithAttendees_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMeetingWithAttendees");

            var request = InstantiateClassGenerator.Execute<CreateMeetingWithAttendeesRequest>();
            var marshaller = new CreateMeetingWithAttendeesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateMeetingWithAttendees", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateMeetingWithAttendeesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void CreateMeetingWithAttendees_UnauthorizedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMeetingWithAttendees");

            var request = InstantiateClassGenerator.Execute<CreateMeetingWithAttendeesRequest>();
            var marshaller = new CreateMeetingWithAttendeesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateMeetingWithAttendees", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnauthorizedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateMeetingWithAttendeesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void DeleteAttendeeMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAttendee");

            var request = InstantiateClassGenerator.Execute<DeleteAttendeeRequest>();
            var marshaller = new DeleteAttendeeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteAttendee", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void DeleteAttendee_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAttendee");

            var request = InstantiateClassGenerator.Execute<DeleteAttendeeRequest>();
            var marshaller = new DeleteAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("BadRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","BadRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void DeleteAttendee_ForbiddenExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAttendee");

            var request = InstantiateClassGenerator.Execute<DeleteAttendeeRequest>();
            var marshaller = new DeleteAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ForbiddenException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ForbiddenException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void DeleteAttendee_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAttendee");

            var request = InstantiateClassGenerator.Execute<DeleteAttendeeRequest>();
            var marshaller = new DeleteAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void DeleteAttendee_ServiceFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAttendee");

            var request = InstantiateClassGenerator.Execute<DeleteAttendeeRequest>();
            var marshaller = new DeleteAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceFailureException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceFailureException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void DeleteAttendee_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAttendee");

            var request = InstantiateClassGenerator.Execute<DeleteAttendeeRequest>();
            var marshaller = new DeleteAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceUnavailableException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceUnavailableException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void DeleteAttendee_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAttendee");

            var request = InstantiateClassGenerator.Execute<DeleteAttendeeRequest>();
            var marshaller = new DeleteAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void DeleteAttendee_UnauthorizedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAttendee");

            var request = InstantiateClassGenerator.Execute<DeleteAttendeeRequest>();
            var marshaller = new DeleteAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnauthorizedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void DeleteMeetingMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMeeting");

            var request = InstantiateClassGenerator.Execute<DeleteMeetingRequest>();
            var marshaller = new DeleteMeetingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteMeeting", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void DeleteMeeting_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMeeting");

            var request = InstantiateClassGenerator.Execute<DeleteMeetingRequest>();
            var marshaller = new DeleteMeetingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteMeeting", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("BadRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","BadRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteMeetingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void DeleteMeeting_ForbiddenExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMeeting");

            var request = InstantiateClassGenerator.Execute<DeleteMeetingRequest>();
            var marshaller = new DeleteMeetingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteMeeting", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ForbiddenException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ForbiddenException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteMeetingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void DeleteMeeting_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMeeting");

            var request = InstantiateClassGenerator.Execute<DeleteMeetingRequest>();
            var marshaller = new DeleteMeetingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteMeeting", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteMeetingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void DeleteMeeting_ServiceFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMeeting");

            var request = InstantiateClassGenerator.Execute<DeleteMeetingRequest>();
            var marshaller = new DeleteMeetingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteMeeting", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceFailureException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceFailureException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteMeetingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void DeleteMeeting_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMeeting");

            var request = InstantiateClassGenerator.Execute<DeleteMeetingRequest>();
            var marshaller = new DeleteMeetingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteMeeting", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceUnavailableException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceUnavailableException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteMeetingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void DeleteMeeting_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMeeting");

            var request = InstantiateClassGenerator.Execute<DeleteMeetingRequest>();
            var marshaller = new DeleteMeetingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteMeeting", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteMeetingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void DeleteMeeting_UnauthorizedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMeeting");

            var request = InstantiateClassGenerator.Execute<DeleteMeetingRequest>();
            var marshaller = new DeleteMeetingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteMeeting", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnauthorizedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteMeetingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void GetAttendeeMarshallTest()
        {
            var operation = service_model.FindOperation("GetAttendee");

            var request = InstantiateClassGenerator.Execute<GetAttendeeRequest>();
            var marshaller = new GetAttendeeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetAttendee", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = GetAttendeeResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetAttendeeResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void GetAttendee_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetAttendee");

            var request = InstantiateClassGenerator.Execute<GetAttendeeRequest>();
            var marshaller = new GetAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("BadRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","BadRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void GetAttendee_ForbiddenExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetAttendee");

            var request = InstantiateClassGenerator.Execute<GetAttendeeRequest>();
            var marshaller = new GetAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ForbiddenException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ForbiddenException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void GetAttendee_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetAttendee");

            var request = InstantiateClassGenerator.Execute<GetAttendeeRequest>();
            var marshaller = new GetAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void GetAttendee_ServiceFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetAttendee");

            var request = InstantiateClassGenerator.Execute<GetAttendeeRequest>();
            var marshaller = new GetAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceFailureException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceFailureException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void GetAttendee_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetAttendee");

            var request = InstantiateClassGenerator.Execute<GetAttendeeRequest>();
            var marshaller = new GetAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceUnavailableException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceUnavailableException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void GetAttendee_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetAttendee");

            var request = InstantiateClassGenerator.Execute<GetAttendeeRequest>();
            var marshaller = new GetAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void GetAttendee_UnauthorizedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetAttendee");

            var request = InstantiateClassGenerator.Execute<GetAttendeeRequest>();
            var marshaller = new GetAttendeeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetAttendee", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnauthorizedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetAttendeeResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void GetMeetingMarshallTest()
        {
            var operation = service_model.FindOperation("GetMeeting");

            var request = InstantiateClassGenerator.Execute<GetMeetingRequest>();
            var marshaller = new GetMeetingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetMeeting", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = GetMeetingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetMeetingResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void GetMeeting_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetMeeting");

            var request = InstantiateClassGenerator.Execute<GetMeetingRequest>();
            var marshaller = new GetMeetingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetMeeting", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("BadRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","BadRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetMeetingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void GetMeeting_ForbiddenExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetMeeting");

            var request = InstantiateClassGenerator.Execute<GetMeetingRequest>();
            var marshaller = new GetMeetingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetMeeting", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ForbiddenException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ForbiddenException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetMeetingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void GetMeeting_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetMeeting");

            var request = InstantiateClassGenerator.Execute<GetMeetingRequest>();
            var marshaller = new GetMeetingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetMeeting", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetMeetingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void GetMeeting_ServiceFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetMeeting");

            var request = InstantiateClassGenerator.Execute<GetMeetingRequest>();
            var marshaller = new GetMeetingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetMeeting", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceFailureException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceFailureException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetMeetingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void GetMeeting_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetMeeting");

            var request = InstantiateClassGenerator.Execute<GetMeetingRequest>();
            var marshaller = new GetMeetingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetMeeting", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceUnavailableException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceUnavailableException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetMeetingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void GetMeeting_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetMeeting");

            var request = InstantiateClassGenerator.Execute<GetMeetingRequest>();
            var marshaller = new GetMeetingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetMeeting", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetMeetingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void GetMeeting_UnauthorizedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetMeeting");

            var request = InstantiateClassGenerator.Execute<GetMeetingRequest>();
            var marshaller = new GetMeetingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetMeeting", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnauthorizedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetMeetingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void ListAttendeesMarshallTest()
        {
            var operation = service_model.FindOperation("ListAttendees");

            var request = InstantiateClassGenerator.Execute<ListAttendeesRequest>();
            var marshaller = new ListAttendeesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListAttendees", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = ListAttendeesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as ListAttendeesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void ListAttendees_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListAttendees");

            var request = InstantiateClassGenerator.Execute<ListAttendeesRequest>();
            var marshaller = new ListAttendeesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListAttendees", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("BadRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","BadRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListAttendeesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void ListAttendees_ForbiddenExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListAttendees");

            var request = InstantiateClassGenerator.Execute<ListAttendeesRequest>();
            var marshaller = new ListAttendeesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListAttendees", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ForbiddenException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ForbiddenException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListAttendeesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void ListAttendees_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListAttendees");

            var request = InstantiateClassGenerator.Execute<ListAttendeesRequest>();
            var marshaller = new ListAttendeesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListAttendees", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListAttendeesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void ListAttendees_ServiceFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListAttendees");

            var request = InstantiateClassGenerator.Execute<ListAttendeesRequest>();
            var marshaller = new ListAttendeesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListAttendees", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceFailureException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceFailureException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListAttendeesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void ListAttendees_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListAttendees");

            var request = InstantiateClassGenerator.Execute<ListAttendeesRequest>();
            var marshaller = new ListAttendeesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListAttendees", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceUnavailableException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceUnavailableException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListAttendeesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void ListAttendees_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListAttendees");

            var request = InstantiateClassGenerator.Execute<ListAttendeesRequest>();
            var marshaller = new ListAttendeesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListAttendees", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListAttendeesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void ListAttendees_UnauthorizedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListAttendees");

            var request = InstantiateClassGenerator.Execute<ListAttendeesRequest>();
            var marshaller = new ListAttendeesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListAttendees", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnauthorizedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListAttendeesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void StartMeetingTranscriptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartMeetingTranscription");

            var request = InstantiateClassGenerator.Execute<StartMeetingTranscriptionRequest>();
            var marshaller = new StartMeetingTranscriptionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("StartMeetingTranscription", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void StartMeetingTranscription_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartMeetingTranscription");

            var request = InstantiateClassGenerator.Execute<StartMeetingTranscriptionRequest>();
            var marshaller = new StartMeetingTranscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartMeetingTranscription", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("BadRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","BadRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StartMeetingTranscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void StartMeetingTranscription_ForbiddenExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartMeetingTranscription");

            var request = InstantiateClassGenerator.Execute<StartMeetingTranscriptionRequest>();
            var marshaller = new StartMeetingTranscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartMeetingTranscription", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ForbiddenException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ForbiddenException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StartMeetingTranscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void StartMeetingTranscription_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartMeetingTranscription");

            var request = InstantiateClassGenerator.Execute<StartMeetingTranscriptionRequest>();
            var marshaller = new StartMeetingTranscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartMeetingTranscription", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","LimitExceededException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StartMeetingTranscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void StartMeetingTranscription_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartMeetingTranscription");

            var request = InstantiateClassGenerator.Execute<StartMeetingTranscriptionRequest>();
            var marshaller = new StartMeetingTranscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartMeetingTranscription", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StartMeetingTranscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void StartMeetingTranscription_ServiceFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartMeetingTranscription");

            var request = InstantiateClassGenerator.Execute<StartMeetingTranscriptionRequest>();
            var marshaller = new StartMeetingTranscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartMeetingTranscription", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceFailureException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceFailureException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StartMeetingTranscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void StartMeetingTranscription_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartMeetingTranscription");

            var request = InstantiateClassGenerator.Execute<StartMeetingTranscriptionRequest>();
            var marshaller = new StartMeetingTranscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartMeetingTranscription", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceUnavailableException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceUnavailableException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StartMeetingTranscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void StartMeetingTranscription_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartMeetingTranscription");

            var request = InstantiateClassGenerator.Execute<StartMeetingTranscriptionRequest>();
            var marshaller = new StartMeetingTranscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartMeetingTranscription", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StartMeetingTranscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void StartMeetingTranscription_UnauthorizedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartMeetingTranscription");

            var request = InstantiateClassGenerator.Execute<StartMeetingTranscriptionRequest>();
            var marshaller = new StartMeetingTranscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartMeetingTranscription", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnauthorizedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StartMeetingTranscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void StartMeetingTranscription_UnprocessableEntityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartMeetingTranscription");

            var request = InstantiateClassGenerator.Execute<StartMeetingTranscriptionRequest>();
            var marshaller = new StartMeetingTranscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartMeetingTranscription", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnprocessableEntityException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnprocessableEntityException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StartMeetingTranscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void StopMeetingTranscriptionMarshallTest()
        {
            var operation = service_model.FindOperation("StopMeetingTranscription");

            var request = InstantiateClassGenerator.Execute<StopMeetingTranscriptionRequest>();
            var marshaller = new StopMeetingTranscriptionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("StopMeetingTranscription", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void StopMeetingTranscription_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StopMeetingTranscription");

            var request = InstantiateClassGenerator.Execute<StopMeetingTranscriptionRequest>();
            var marshaller = new StopMeetingTranscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StopMeetingTranscription", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("BadRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","BadRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StopMeetingTranscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void StopMeetingTranscription_ForbiddenExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StopMeetingTranscription");

            var request = InstantiateClassGenerator.Execute<StopMeetingTranscriptionRequest>();
            var marshaller = new StopMeetingTranscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StopMeetingTranscription", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ForbiddenException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ForbiddenException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StopMeetingTranscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void StopMeetingTranscription_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StopMeetingTranscription");

            var request = InstantiateClassGenerator.Execute<StopMeetingTranscriptionRequest>();
            var marshaller = new StopMeetingTranscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StopMeetingTranscription", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StopMeetingTranscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void StopMeetingTranscription_ServiceFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StopMeetingTranscription");

            var request = InstantiateClassGenerator.Execute<StopMeetingTranscriptionRequest>();
            var marshaller = new StopMeetingTranscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StopMeetingTranscription", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceFailureException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceFailureException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StopMeetingTranscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void StopMeetingTranscription_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StopMeetingTranscription");

            var request = InstantiateClassGenerator.Execute<StopMeetingTranscriptionRequest>();
            var marshaller = new StopMeetingTranscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StopMeetingTranscription", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceUnavailableException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceUnavailableException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StopMeetingTranscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void StopMeetingTranscription_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StopMeetingTranscription");

            var request = InstantiateClassGenerator.Execute<StopMeetingTranscriptionRequest>();
            var marshaller = new StopMeetingTranscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StopMeetingTranscription", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StopMeetingTranscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void StopMeetingTranscription_UnauthorizedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StopMeetingTranscription");

            var request = InstantiateClassGenerator.Execute<StopMeetingTranscriptionRequest>();
            var marshaller = new StopMeetingTranscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StopMeetingTranscription", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnauthorizedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnauthorizedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StopMeetingTranscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ChimeSDKMeetings")]
        public void StopMeetingTranscription_UnprocessableEntityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StopMeetingTranscription");

            var request = InstantiateClassGenerator.Execute<StopMeetingTranscriptionRequest>();
            var marshaller = new StopMeetingTranscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StopMeetingTranscription", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnprocessableEntityException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnprocessableEntityException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StopMeetingTranscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}