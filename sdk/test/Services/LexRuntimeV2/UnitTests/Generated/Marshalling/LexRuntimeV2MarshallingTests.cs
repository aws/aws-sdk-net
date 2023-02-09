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
 * Do not modify this file. This file is generated from the runtime.lex.v2-2020-08-07.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.LexRuntimeV2;
using Amazon.LexRuntimeV2.Model;
using Amazon.LexRuntimeV2.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class LexRuntimeV2MarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("runtime.lex.v2");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void DeleteSessionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSession");

            var request = InstantiateClassGenerator.Execute<DeleteSessionRequest>();
            var marshaller = new DeleteSessionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteSession", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = DeleteSessionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DeleteSessionResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void DeleteSession_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSession");

            var request = InstantiateClassGenerator.Execute<DeleteSessionRequest>();
            var marshaller = new DeleteSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteSession", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AccessDeniedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteSessionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void DeleteSession_ConflictExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSession");

            var request = InstantiateClassGenerator.Execute<DeleteSessionRequest>();
            var marshaller = new DeleteSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteSession", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ConflictException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteSessionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void DeleteSession_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSession");

            var request = InstantiateClassGenerator.Execute<DeleteSessionRequest>();
            var marshaller = new DeleteSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteSession", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServerException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalServerException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteSessionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void DeleteSession_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSession");

            var request = InstantiateClassGenerator.Execute<DeleteSessionRequest>();
            var marshaller = new DeleteSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteSession", request, internalRequest, service_model);

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
            var response = DeleteSessionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void DeleteSession_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSession");

            var request = InstantiateClassGenerator.Execute<DeleteSessionRequest>();
            var marshaller = new DeleteSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteSession", request, internalRequest, service_model);

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
            var response = DeleteSessionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void DeleteSession_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSession");

            var request = InstantiateClassGenerator.Execute<DeleteSessionRequest>();
            var marshaller = new DeleteSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteSession", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ValidationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteSessionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void GetSessionMarshallTest()
        {
            var operation = service_model.FindOperation("GetSession");

            var request = InstantiateClassGenerator.Execute<GetSessionRequest>();
            var marshaller = new GetSessionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetSession", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = GetSessionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetSessionResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void GetSession_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetSession");

            var request = InstantiateClassGenerator.Execute<GetSessionRequest>();
            var marshaller = new GetSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetSession", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AccessDeniedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetSessionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void GetSession_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetSession");

            var request = InstantiateClassGenerator.Execute<GetSessionRequest>();
            var marshaller = new GetSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetSession", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServerException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalServerException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetSessionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void GetSession_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetSession");

            var request = InstantiateClassGenerator.Execute<GetSessionRequest>();
            var marshaller = new GetSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetSession", request, internalRequest, service_model);

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
            var response = GetSessionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void GetSession_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetSession");

            var request = InstantiateClassGenerator.Execute<GetSessionRequest>();
            var marshaller = new GetSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetSession", request, internalRequest, service_model);

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
            var response = GetSessionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void GetSession_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetSession");

            var request = InstantiateClassGenerator.Execute<GetSessionRequest>();
            var marshaller = new GetSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetSession", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ValidationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetSessionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void PutSessionMarshallTest()
        {
            var operation = service_model.FindOperation("PutSession");

            var request = InstantiateClassGenerator.Execute<PutSessionRequest>();
            var marshaller = new PutSessionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutSession", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-messages","x-amz-lex-messages_Value"},
                    {"x-amz-lex-request-attributes","x-amz-lex-request-attributes_Value"},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-session-state","x-amz-lex-session-state_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = PutSessionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as PutSessionResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void PutSession_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutSession");

            var request = InstantiateClassGenerator.Execute<PutSessionRequest>();
            var marshaller = new PutSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PutSession", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-messages","x-amz-lex-messages_Value"},
                    {"x-amz-lex-request-attributes","x-amz-lex-request-attributes_Value"},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-session-state","x-amz-lex-session-state_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AccessDeniedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PutSessionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void PutSession_BadGatewayExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutSession");

            var request = InstantiateClassGenerator.Execute<PutSessionRequest>();
            var marshaller = new PutSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PutSession", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("BadGatewayException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-messages","x-amz-lex-messages_Value"},
                    {"x-amz-lex-request-attributes","x-amz-lex-request-attributes_Value"},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-session-state","x-amz-lex-session-state_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","BadGatewayException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PutSessionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void PutSession_ConflictExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutSession");

            var request = InstantiateClassGenerator.Execute<PutSessionRequest>();
            var marshaller = new PutSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PutSession", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-messages","x-amz-lex-messages_Value"},
                    {"x-amz-lex-request-attributes","x-amz-lex-request-attributes_Value"},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-session-state","x-amz-lex-session-state_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ConflictException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PutSessionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void PutSession_DependencyFailedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutSession");

            var request = InstantiateClassGenerator.Execute<PutSessionRequest>();
            var marshaller = new PutSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PutSession", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependencyFailedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-messages","x-amz-lex-messages_Value"},
                    {"x-amz-lex-request-attributes","x-amz-lex-request-attributes_Value"},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-session-state","x-amz-lex-session-state_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","DependencyFailedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PutSessionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void PutSession_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutSession");

            var request = InstantiateClassGenerator.Execute<PutSessionRequest>();
            var marshaller = new PutSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PutSession", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServerException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-messages","x-amz-lex-messages_Value"},
                    {"x-amz-lex-request-attributes","x-amz-lex-request-attributes_Value"},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-session-state","x-amz-lex-session-state_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalServerException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PutSessionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void PutSession_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutSession");

            var request = InstantiateClassGenerator.Execute<PutSessionRequest>();
            var marshaller = new PutSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PutSession", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-messages","x-amz-lex-messages_Value"},
                    {"x-amz-lex-request-attributes","x-amz-lex-request-attributes_Value"},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-session-state","x-amz-lex-session-state_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceNotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PutSessionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void PutSession_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutSession");

            var request = InstantiateClassGenerator.Execute<PutSessionRequest>();
            var marshaller = new PutSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PutSession", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-messages","x-amz-lex-messages_Value"},
                    {"x-amz-lex-request-attributes","x-amz-lex-request-attributes_Value"},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-session-state","x-amz-lex-session-state_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PutSessionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void PutSession_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutSession");

            var request = InstantiateClassGenerator.Execute<PutSessionRequest>();
            var marshaller = new PutSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PutSession", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-messages","x-amz-lex-messages_Value"},
                    {"x-amz-lex-request-attributes","x-amz-lex-request-attributes_Value"},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-session-state","x-amz-lex-session-state_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ValidationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PutSessionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void RecognizeTextMarshallTest()
        {
            var operation = service_model.FindOperation("RecognizeText");

            var request = InstantiateClassGenerator.Execute<RecognizeTextRequest>();
            var marshaller = new RecognizeTextRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("RecognizeText", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = RecognizeTextResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as RecognizeTextResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void RecognizeText_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RecognizeText");

            var request = InstantiateClassGenerator.Execute<RecognizeTextRequest>();
            var marshaller = new RecognizeTextRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("RecognizeText", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AccessDeniedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = RecognizeTextResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void RecognizeText_BadGatewayExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RecognizeText");

            var request = InstantiateClassGenerator.Execute<RecognizeTextRequest>();
            var marshaller = new RecognizeTextRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("RecognizeText", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("BadGatewayException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","BadGatewayException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = RecognizeTextResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void RecognizeText_ConflictExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RecognizeText");

            var request = InstantiateClassGenerator.Execute<RecognizeTextRequest>();
            var marshaller = new RecognizeTextRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("RecognizeText", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ConflictException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = RecognizeTextResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void RecognizeText_DependencyFailedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RecognizeText");

            var request = InstantiateClassGenerator.Execute<RecognizeTextRequest>();
            var marshaller = new RecognizeTextRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("RecognizeText", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependencyFailedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","DependencyFailedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = RecognizeTextResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void RecognizeText_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RecognizeText");

            var request = InstantiateClassGenerator.Execute<RecognizeTextRequest>();
            var marshaller = new RecognizeTextRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("RecognizeText", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServerException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalServerException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = RecognizeTextResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void RecognizeText_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RecognizeText");

            var request = InstantiateClassGenerator.Execute<RecognizeTextRequest>();
            var marshaller = new RecognizeTextRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("RecognizeText", request, internalRequest, service_model);

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
            var response = RecognizeTextResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void RecognizeText_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RecognizeText");

            var request = InstantiateClassGenerator.Execute<RecognizeTextRequest>();
            var marshaller = new RecognizeTextRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("RecognizeText", request, internalRequest, service_model);

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
            var response = RecognizeTextResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void RecognizeText_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RecognizeText");

            var request = InstantiateClassGenerator.Execute<RecognizeTextRequest>();
            var marshaller = new RecognizeTextRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("RecognizeText", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ValidationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = RecognizeTextResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void RecognizeUtteranceMarshallTest()
        {
            var operation = service_model.FindOperation("RecognizeUtterance");

            var request = InstantiateClassGenerator.Execute<RecognizeUtteranceRequest>();
            var marshaller = new RecognizeUtteranceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("RecognizeUtterance", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-input-mode","x-amz-lex-input-mode_Value"},
                    {"x-amz-lex-input-transcript","x-amz-lex-input-transcript_Value"},
                    {"x-amz-lex-interpretations","x-amz-lex-interpretations_Value"},
                    {"x-amz-lex-messages","x-amz-lex-messages_Value"},
                    {"x-amz-lex-recognized-bot-member","x-amz-lex-recognized-bot-member_Value"},
                    {"x-amz-lex-request-attributes","x-amz-lex-request-attributes_Value"},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-session-state","x-amz-lex-session-state_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = RecognizeUtteranceResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as RecognizeUtteranceResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void RecognizeUtterance_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RecognizeUtterance");

            var request = InstantiateClassGenerator.Execute<RecognizeUtteranceRequest>();
            var marshaller = new RecognizeUtteranceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("RecognizeUtterance", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-input-mode","x-amz-lex-input-mode_Value"},
                    {"x-amz-lex-input-transcript","x-amz-lex-input-transcript_Value"},
                    {"x-amz-lex-interpretations","x-amz-lex-interpretations_Value"},
                    {"x-amz-lex-messages","x-amz-lex-messages_Value"},
                    {"x-amz-lex-recognized-bot-member","x-amz-lex-recognized-bot-member_Value"},
                    {"x-amz-lex-request-attributes","x-amz-lex-request-attributes_Value"},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-session-state","x-amz-lex-session-state_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AccessDeniedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = RecognizeUtteranceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void RecognizeUtterance_BadGatewayExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RecognizeUtterance");

            var request = InstantiateClassGenerator.Execute<RecognizeUtteranceRequest>();
            var marshaller = new RecognizeUtteranceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("RecognizeUtterance", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("BadGatewayException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-input-mode","x-amz-lex-input-mode_Value"},
                    {"x-amz-lex-input-transcript","x-amz-lex-input-transcript_Value"},
                    {"x-amz-lex-interpretations","x-amz-lex-interpretations_Value"},
                    {"x-amz-lex-messages","x-amz-lex-messages_Value"},
                    {"x-amz-lex-recognized-bot-member","x-amz-lex-recognized-bot-member_Value"},
                    {"x-amz-lex-request-attributes","x-amz-lex-request-attributes_Value"},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-session-state","x-amz-lex-session-state_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","BadGatewayException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = RecognizeUtteranceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void RecognizeUtterance_ConflictExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RecognizeUtterance");

            var request = InstantiateClassGenerator.Execute<RecognizeUtteranceRequest>();
            var marshaller = new RecognizeUtteranceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("RecognizeUtterance", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-input-mode","x-amz-lex-input-mode_Value"},
                    {"x-amz-lex-input-transcript","x-amz-lex-input-transcript_Value"},
                    {"x-amz-lex-interpretations","x-amz-lex-interpretations_Value"},
                    {"x-amz-lex-messages","x-amz-lex-messages_Value"},
                    {"x-amz-lex-recognized-bot-member","x-amz-lex-recognized-bot-member_Value"},
                    {"x-amz-lex-request-attributes","x-amz-lex-request-attributes_Value"},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-session-state","x-amz-lex-session-state_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ConflictException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = RecognizeUtteranceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void RecognizeUtterance_DependencyFailedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RecognizeUtterance");

            var request = InstantiateClassGenerator.Execute<RecognizeUtteranceRequest>();
            var marshaller = new RecognizeUtteranceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("RecognizeUtterance", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependencyFailedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-input-mode","x-amz-lex-input-mode_Value"},
                    {"x-amz-lex-input-transcript","x-amz-lex-input-transcript_Value"},
                    {"x-amz-lex-interpretations","x-amz-lex-interpretations_Value"},
                    {"x-amz-lex-messages","x-amz-lex-messages_Value"},
                    {"x-amz-lex-recognized-bot-member","x-amz-lex-recognized-bot-member_Value"},
                    {"x-amz-lex-request-attributes","x-amz-lex-request-attributes_Value"},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-session-state","x-amz-lex-session-state_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","DependencyFailedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = RecognizeUtteranceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void RecognizeUtterance_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RecognizeUtterance");

            var request = InstantiateClassGenerator.Execute<RecognizeUtteranceRequest>();
            var marshaller = new RecognizeUtteranceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("RecognizeUtterance", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServerException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-input-mode","x-amz-lex-input-mode_Value"},
                    {"x-amz-lex-input-transcript","x-amz-lex-input-transcript_Value"},
                    {"x-amz-lex-interpretations","x-amz-lex-interpretations_Value"},
                    {"x-amz-lex-messages","x-amz-lex-messages_Value"},
                    {"x-amz-lex-recognized-bot-member","x-amz-lex-recognized-bot-member_Value"},
                    {"x-amz-lex-request-attributes","x-amz-lex-request-attributes_Value"},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-session-state","x-amz-lex-session-state_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalServerException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = RecognizeUtteranceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void RecognizeUtterance_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RecognizeUtterance");

            var request = InstantiateClassGenerator.Execute<RecognizeUtteranceRequest>();
            var marshaller = new RecognizeUtteranceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("RecognizeUtterance", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-input-mode","x-amz-lex-input-mode_Value"},
                    {"x-amz-lex-input-transcript","x-amz-lex-input-transcript_Value"},
                    {"x-amz-lex-interpretations","x-amz-lex-interpretations_Value"},
                    {"x-amz-lex-messages","x-amz-lex-messages_Value"},
                    {"x-amz-lex-recognized-bot-member","x-amz-lex-recognized-bot-member_Value"},
                    {"x-amz-lex-request-attributes","x-amz-lex-request-attributes_Value"},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-session-state","x-amz-lex-session-state_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceNotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = RecognizeUtteranceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void RecognizeUtterance_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RecognizeUtterance");

            var request = InstantiateClassGenerator.Execute<RecognizeUtteranceRequest>();
            var marshaller = new RecognizeUtteranceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("RecognizeUtterance", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-input-mode","x-amz-lex-input-mode_Value"},
                    {"x-amz-lex-input-transcript","x-amz-lex-input-transcript_Value"},
                    {"x-amz-lex-interpretations","x-amz-lex-interpretations_Value"},
                    {"x-amz-lex-messages","x-amz-lex-messages_Value"},
                    {"x-amz-lex-recognized-bot-member","x-amz-lex-recognized-bot-member_Value"},
                    {"x-amz-lex-request-attributes","x-amz-lex-request-attributes_Value"},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-session-state","x-amz-lex-session-state_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = RecognizeUtteranceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("LexRuntimeV2")]
        public void RecognizeUtterance_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RecognizeUtterance");

            var request = InstantiateClassGenerator.Execute<RecognizeUtteranceRequest>();
            var marshaller = new RecognizeUtteranceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("RecognizeUtterance", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-input-mode","x-amz-lex-input-mode_Value"},
                    {"x-amz-lex-input-transcript","x-amz-lex-input-transcript_Value"},
                    {"x-amz-lex-interpretations","x-amz-lex-interpretations_Value"},
                    {"x-amz-lex-messages","x-amz-lex-messages_Value"},
                    {"x-amz-lex-recognized-bot-member","x-amz-lex-recognized-bot-member_Value"},
                    {"x-amz-lex-request-attributes","x-amz-lex-request-attributes_Value"},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-session-state","x-amz-lex-session-state_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ValidationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = RecognizeUtteranceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}