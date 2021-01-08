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
 * Do not modify this file. This file is generated from the runtime.lex-2016-11-28.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Lex;
using Amazon.Lex.Model;
using Amazon.Lex.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class LexMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("runtime.lex");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
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
            var response = unmarshaller.Unmarshall(context)
                as DeleteSessionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void DeleteSession_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSession");

            var request = InstantiateClassGenerator.Execute<DeleteSessionRequest>();
            var marshaller = new DeleteSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteSession", request, internalRequest, service_model);

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
            var response = DeleteSessionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
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
        [TestCategory("Lex")]
        public void DeleteSession_InternalFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSession");

            var request = InstantiateClassGenerator.Execute<DeleteSessionRequest>();
            var marshaller = new DeleteSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteSession", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalFailureException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalFailureException"},
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
        [TestCategory("Lex")]
        public void DeleteSession_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSession");

            var request = InstantiateClassGenerator.Execute<DeleteSessionRequest>();
            var marshaller = new DeleteSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteSession", request, internalRequest, service_model);

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
            var response = DeleteSessionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void DeleteSession_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSession");

            var request = InstantiateClassGenerator.Execute<DeleteSessionRequest>();
            var marshaller = new DeleteSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteSession", request, internalRequest, service_model);

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
            var response = DeleteSessionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
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
            var response = unmarshaller.Unmarshall(context)
                as GetSessionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void GetSession_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetSession");

            var request = InstantiateClassGenerator.Execute<GetSessionRequest>();
            var marshaller = new GetSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetSession", request, internalRequest, service_model);

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
            var response = GetSessionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void GetSession_InternalFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetSession");

            var request = InstantiateClassGenerator.Execute<GetSessionRequest>();
            var marshaller = new GetSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetSession", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalFailureException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalFailureException"},
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
        [TestCategory("Lex")]
        public void GetSession_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetSession");

            var request = InstantiateClassGenerator.Execute<GetSessionRequest>();
            var marshaller = new GetSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetSession", request, internalRequest, service_model);

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
            var response = GetSessionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void GetSession_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetSession");

            var request = InstantiateClassGenerator.Execute<GetSessionRequest>();
            var marshaller = new GetSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetSession", request, internalRequest, service_model);

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
            var response = GetSessionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void PostContentMarshallTest()
        {
            var operation = service_model.FindOperation("PostContent");

            var request = InstantiateClassGenerator.Execute<PostContentRequest>();
            var marshaller = new PostContentRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PostContent", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amz-lex-active-contexts",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-active-contexts_Value"))},
                    {"x-amz-lex-alternative-intents",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-alternative-intents_Value"))},
                    {"x-amz-lex-bot-version","x-amz-lex-bot-version_Value"},
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-dialog-state","x-amz-lex-dialog-state_Value"},
                    {"x-amz-lex-input-transcript","x-amz-lex-input-transcript_Value"},
                    {"x-amz-lex-intent-name","x-amz-lex-intent-name_Value"},
                    {"x-amz-lex-message","x-amz-lex-message_Value"},
                    {"x-amz-lex-message-format","x-amz-lex-message-format_Value"},
                    {"x-amz-lex-nlu-intent-confidence",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-nlu-intent-confidence_Value"))},
                    {"x-amz-lex-sentiment","x-amz-lex-sentiment_Value"},
                    {"x-amz-lex-session-attributes",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-session-attributes_Value"))},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-slots",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-slots_Value"))},
                    {"x-amz-lex-slot-to-elicit","x-amz-lex-slot-to-elicit_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = PostContentResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PostContentResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void PostContent_BadGatewayExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PostContent");

            var request = InstantiateClassGenerator.Execute<PostContentRequest>();
            var marshaller = new PostContentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PostContent", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("BadGatewayException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amz-lex-active-contexts",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-active-contexts_Value"))},
                    {"x-amz-lex-alternative-intents",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-alternative-intents_Value"))},
                    {"x-amz-lex-bot-version","x-amz-lex-bot-version_Value"},
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-dialog-state","x-amz-lex-dialog-state_Value"},
                    {"x-amz-lex-input-transcript","x-amz-lex-input-transcript_Value"},
                    {"x-amz-lex-intent-name","x-amz-lex-intent-name_Value"},
                    {"x-amz-lex-message","x-amz-lex-message_Value"},
                    {"x-amz-lex-message-format","x-amz-lex-message-format_Value"},
                    {"x-amz-lex-nlu-intent-confidence",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-nlu-intent-confidence_Value"))},
                    {"x-amz-lex-sentiment","x-amz-lex-sentiment_Value"},
                    {"x-amz-lex-session-attributes",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-session-attributes_Value"))},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-slots",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-slots_Value"))},
                    {"x-amz-lex-slot-to-elicit","x-amz-lex-slot-to-elicit_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","BadGatewayException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PostContentResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void PostContent_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PostContent");

            var request = InstantiateClassGenerator.Execute<PostContentRequest>();
            var marshaller = new PostContentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PostContent", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("BadRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amz-lex-active-contexts",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-active-contexts_Value"))},
                    {"x-amz-lex-alternative-intents",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-alternative-intents_Value"))},
                    {"x-amz-lex-bot-version","x-amz-lex-bot-version_Value"},
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-dialog-state","x-amz-lex-dialog-state_Value"},
                    {"x-amz-lex-input-transcript","x-amz-lex-input-transcript_Value"},
                    {"x-amz-lex-intent-name","x-amz-lex-intent-name_Value"},
                    {"x-amz-lex-message","x-amz-lex-message_Value"},
                    {"x-amz-lex-message-format","x-amz-lex-message-format_Value"},
                    {"x-amz-lex-nlu-intent-confidence",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-nlu-intent-confidence_Value"))},
                    {"x-amz-lex-sentiment","x-amz-lex-sentiment_Value"},
                    {"x-amz-lex-session-attributes",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-session-attributes_Value"))},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-slots",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-slots_Value"))},
                    {"x-amz-lex-slot-to-elicit","x-amz-lex-slot-to-elicit_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","BadRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PostContentResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void PostContent_ConflictExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PostContent");

            var request = InstantiateClassGenerator.Execute<PostContentRequest>();
            var marshaller = new PostContentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PostContent", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amz-lex-active-contexts",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-active-contexts_Value"))},
                    {"x-amz-lex-alternative-intents",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-alternative-intents_Value"))},
                    {"x-amz-lex-bot-version","x-amz-lex-bot-version_Value"},
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-dialog-state","x-amz-lex-dialog-state_Value"},
                    {"x-amz-lex-input-transcript","x-amz-lex-input-transcript_Value"},
                    {"x-amz-lex-intent-name","x-amz-lex-intent-name_Value"},
                    {"x-amz-lex-message","x-amz-lex-message_Value"},
                    {"x-amz-lex-message-format","x-amz-lex-message-format_Value"},
                    {"x-amz-lex-nlu-intent-confidence",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-nlu-intent-confidence_Value"))},
                    {"x-amz-lex-sentiment","x-amz-lex-sentiment_Value"},
                    {"x-amz-lex-session-attributes",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-session-attributes_Value"))},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-slots",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-slots_Value"))},
                    {"x-amz-lex-slot-to-elicit","x-amz-lex-slot-to-elicit_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ConflictException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PostContentResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void PostContent_DependencyFailedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PostContent");

            var request = InstantiateClassGenerator.Execute<PostContentRequest>();
            var marshaller = new PostContentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PostContent", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependencyFailedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amz-lex-active-contexts",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-active-contexts_Value"))},
                    {"x-amz-lex-alternative-intents",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-alternative-intents_Value"))},
                    {"x-amz-lex-bot-version","x-amz-lex-bot-version_Value"},
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-dialog-state","x-amz-lex-dialog-state_Value"},
                    {"x-amz-lex-input-transcript","x-amz-lex-input-transcript_Value"},
                    {"x-amz-lex-intent-name","x-amz-lex-intent-name_Value"},
                    {"x-amz-lex-message","x-amz-lex-message_Value"},
                    {"x-amz-lex-message-format","x-amz-lex-message-format_Value"},
                    {"x-amz-lex-nlu-intent-confidence",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-nlu-intent-confidence_Value"))},
                    {"x-amz-lex-sentiment","x-amz-lex-sentiment_Value"},
                    {"x-amz-lex-session-attributes",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-session-attributes_Value"))},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-slots",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-slots_Value"))},
                    {"x-amz-lex-slot-to-elicit","x-amz-lex-slot-to-elicit_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","DependencyFailedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PostContentResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void PostContent_InternalFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PostContent");

            var request = InstantiateClassGenerator.Execute<PostContentRequest>();
            var marshaller = new PostContentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PostContent", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalFailureException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amz-lex-active-contexts",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-active-contexts_Value"))},
                    {"x-amz-lex-alternative-intents",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-alternative-intents_Value"))},
                    {"x-amz-lex-bot-version","x-amz-lex-bot-version_Value"},
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-dialog-state","x-amz-lex-dialog-state_Value"},
                    {"x-amz-lex-input-transcript","x-amz-lex-input-transcript_Value"},
                    {"x-amz-lex-intent-name","x-amz-lex-intent-name_Value"},
                    {"x-amz-lex-message","x-amz-lex-message_Value"},
                    {"x-amz-lex-message-format","x-amz-lex-message-format_Value"},
                    {"x-amz-lex-nlu-intent-confidence",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-nlu-intent-confidence_Value"))},
                    {"x-amz-lex-sentiment","x-amz-lex-sentiment_Value"},
                    {"x-amz-lex-session-attributes",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-session-attributes_Value"))},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-slots",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-slots_Value"))},
                    {"x-amz-lex-slot-to-elicit","x-amz-lex-slot-to-elicit_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalFailureException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PostContentResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void PostContent_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PostContent");

            var request = InstantiateClassGenerator.Execute<PostContentRequest>();
            var marshaller = new PostContentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PostContent", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amz-lex-active-contexts",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-active-contexts_Value"))},
                    {"x-amz-lex-alternative-intents",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-alternative-intents_Value"))},
                    {"x-amz-lex-bot-version","x-amz-lex-bot-version_Value"},
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-dialog-state","x-amz-lex-dialog-state_Value"},
                    {"x-amz-lex-input-transcript","x-amz-lex-input-transcript_Value"},
                    {"x-amz-lex-intent-name","x-amz-lex-intent-name_Value"},
                    {"x-amz-lex-message","x-amz-lex-message_Value"},
                    {"x-amz-lex-message-format","x-amz-lex-message-format_Value"},
                    {"x-amz-lex-nlu-intent-confidence",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-nlu-intent-confidence_Value"))},
                    {"x-amz-lex-sentiment","x-amz-lex-sentiment_Value"},
                    {"x-amz-lex-session-attributes",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-session-attributes_Value"))},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-slots",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-slots_Value"))},
                    {"x-amz-lex-slot-to-elicit","x-amz-lex-slot-to-elicit_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","LimitExceededException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PostContentResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void PostContent_LoopDetectedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PostContent");

            var request = InstantiateClassGenerator.Execute<PostContentRequest>();
            var marshaller = new PostContentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PostContent", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("LoopDetectedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amz-lex-active-contexts",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-active-contexts_Value"))},
                    {"x-amz-lex-alternative-intents",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-alternative-intents_Value"))},
                    {"x-amz-lex-bot-version","x-amz-lex-bot-version_Value"},
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-dialog-state","x-amz-lex-dialog-state_Value"},
                    {"x-amz-lex-input-transcript","x-amz-lex-input-transcript_Value"},
                    {"x-amz-lex-intent-name","x-amz-lex-intent-name_Value"},
                    {"x-amz-lex-message","x-amz-lex-message_Value"},
                    {"x-amz-lex-message-format","x-amz-lex-message-format_Value"},
                    {"x-amz-lex-nlu-intent-confidence",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-nlu-intent-confidence_Value"))},
                    {"x-amz-lex-sentiment","x-amz-lex-sentiment_Value"},
                    {"x-amz-lex-session-attributes",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-session-attributes_Value"))},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-slots",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-slots_Value"))},
                    {"x-amz-lex-slot-to-elicit","x-amz-lex-slot-to-elicit_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","LoopDetectedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PostContentResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void PostContent_NotAcceptableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PostContent");

            var request = InstantiateClassGenerator.Execute<PostContentRequest>();
            var marshaller = new PostContentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PostContent", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotAcceptableException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amz-lex-active-contexts",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-active-contexts_Value"))},
                    {"x-amz-lex-alternative-intents",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-alternative-intents_Value"))},
                    {"x-amz-lex-bot-version","x-amz-lex-bot-version_Value"},
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-dialog-state","x-amz-lex-dialog-state_Value"},
                    {"x-amz-lex-input-transcript","x-amz-lex-input-transcript_Value"},
                    {"x-amz-lex-intent-name","x-amz-lex-intent-name_Value"},
                    {"x-amz-lex-message","x-amz-lex-message_Value"},
                    {"x-amz-lex-message-format","x-amz-lex-message-format_Value"},
                    {"x-amz-lex-nlu-intent-confidence",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-nlu-intent-confidence_Value"))},
                    {"x-amz-lex-sentiment","x-amz-lex-sentiment_Value"},
                    {"x-amz-lex-session-attributes",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-session-attributes_Value"))},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-slots",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-slots_Value"))},
                    {"x-amz-lex-slot-to-elicit","x-amz-lex-slot-to-elicit_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotAcceptableException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PostContentResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void PostContent_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PostContent");

            var request = InstantiateClassGenerator.Execute<PostContentRequest>();
            var marshaller = new PostContentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PostContent", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amz-lex-active-contexts",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-active-contexts_Value"))},
                    {"x-amz-lex-alternative-intents",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-alternative-intents_Value"))},
                    {"x-amz-lex-bot-version","x-amz-lex-bot-version_Value"},
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-dialog-state","x-amz-lex-dialog-state_Value"},
                    {"x-amz-lex-input-transcript","x-amz-lex-input-transcript_Value"},
                    {"x-amz-lex-intent-name","x-amz-lex-intent-name_Value"},
                    {"x-amz-lex-message","x-amz-lex-message_Value"},
                    {"x-amz-lex-message-format","x-amz-lex-message-format_Value"},
                    {"x-amz-lex-nlu-intent-confidence",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-nlu-intent-confidence_Value"))},
                    {"x-amz-lex-sentiment","x-amz-lex-sentiment_Value"},
                    {"x-amz-lex-session-attributes",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-session-attributes_Value"))},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-slots",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-slots_Value"))},
                    {"x-amz-lex-slot-to-elicit","x-amz-lex-slot-to-elicit_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PostContentResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void PostContent_RequestTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PostContent");

            var request = InstantiateClassGenerator.Execute<PostContentRequest>();
            var marshaller = new PostContentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PostContent", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("RequestTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amz-lex-active-contexts",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-active-contexts_Value"))},
                    {"x-amz-lex-alternative-intents",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-alternative-intents_Value"))},
                    {"x-amz-lex-bot-version","x-amz-lex-bot-version_Value"},
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-dialog-state","x-amz-lex-dialog-state_Value"},
                    {"x-amz-lex-input-transcript","x-amz-lex-input-transcript_Value"},
                    {"x-amz-lex-intent-name","x-amz-lex-intent-name_Value"},
                    {"x-amz-lex-message","x-amz-lex-message_Value"},
                    {"x-amz-lex-message-format","x-amz-lex-message-format_Value"},
                    {"x-amz-lex-nlu-intent-confidence",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-nlu-intent-confidence_Value"))},
                    {"x-amz-lex-sentiment","x-amz-lex-sentiment_Value"},
                    {"x-amz-lex-session-attributes",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-session-attributes_Value"))},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-slots",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-slots_Value"))},
                    {"x-amz-lex-slot-to-elicit","x-amz-lex-slot-to-elicit_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","RequestTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PostContentResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void PostContent_UnsupportedMediaTypeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PostContent");

            var request = InstantiateClassGenerator.Execute<PostContentRequest>();
            var marshaller = new PostContentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PostContent", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedMediaTypeException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amz-lex-active-contexts",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-active-contexts_Value"))},
                    {"x-amz-lex-alternative-intents",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-alternative-intents_Value"))},
                    {"x-amz-lex-bot-version","x-amz-lex-bot-version_Value"},
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-dialog-state","x-amz-lex-dialog-state_Value"},
                    {"x-amz-lex-input-transcript","x-amz-lex-input-transcript_Value"},
                    {"x-amz-lex-intent-name","x-amz-lex-intent-name_Value"},
                    {"x-amz-lex-message","x-amz-lex-message_Value"},
                    {"x-amz-lex-message-format","x-amz-lex-message-format_Value"},
                    {"x-amz-lex-nlu-intent-confidence",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-nlu-intent-confidence_Value"))},
                    {"x-amz-lex-sentiment","x-amz-lex-sentiment_Value"},
                    {"x-amz-lex-session-attributes",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-session-attributes_Value"))},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-slots",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-slots_Value"))},
                    {"x-amz-lex-slot-to-elicit","x-amz-lex-slot-to-elicit_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedMediaTypeException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PostContentResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void PostTextMarshallTest()
        {
            var operation = service_model.FindOperation("PostText");

            var request = InstantiateClassGenerator.Execute<PostTextRequest>();
            var marshaller = new PostTextRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PostText", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PostTextResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PostTextResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void PostText_BadGatewayExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PostText");

            var request = InstantiateClassGenerator.Execute<PostTextRequest>();
            var marshaller = new PostTextRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PostText", request, internalRequest, service_model);

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
            var response = PostTextResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void PostText_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PostText");

            var request = InstantiateClassGenerator.Execute<PostTextRequest>();
            var marshaller = new PostTextRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PostText", request, internalRequest, service_model);

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
            var response = PostTextResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void PostText_ConflictExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PostText");

            var request = InstantiateClassGenerator.Execute<PostTextRequest>();
            var marshaller = new PostTextRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PostText", request, internalRequest, service_model);

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
            var response = PostTextResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void PostText_DependencyFailedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PostText");

            var request = InstantiateClassGenerator.Execute<PostTextRequest>();
            var marshaller = new PostTextRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PostText", request, internalRequest, service_model);

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
            var response = PostTextResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void PostText_InternalFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PostText");

            var request = InstantiateClassGenerator.Execute<PostTextRequest>();
            var marshaller = new PostTextRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PostText", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalFailureException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalFailureException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PostTextResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void PostText_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PostText");

            var request = InstantiateClassGenerator.Execute<PostTextRequest>();
            var marshaller = new PostTextRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PostText", request, internalRequest, service_model);

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
            var response = PostTextResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void PostText_LoopDetectedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PostText");

            var request = InstantiateClassGenerator.Execute<PostTextRequest>();
            var marshaller = new PostTextRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PostText", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("LoopDetectedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","LoopDetectedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PostTextResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void PostText_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PostText");

            var request = InstantiateClassGenerator.Execute<PostTextRequest>();
            var marshaller = new PostTextRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PostText", request, internalRequest, service_model);

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
            var response = PostTextResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
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
                    {"x-amz-lex-active-contexts",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-active-contexts_Value"))},
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-dialog-state","x-amz-lex-dialog-state_Value"},
                    {"x-amz-lex-intent-name","x-amz-lex-intent-name_Value"},
                    {"x-amz-lex-message","x-amz-lex-message_Value"},
                    {"x-amz-lex-message-format","x-amz-lex-message-format_Value"},
                    {"x-amz-lex-session-attributes",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-session-attributes_Value"))},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-slots",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-slots_Value"))},
                    {"x-amz-lex-slot-to-elicit","x-amz-lex-slot-to-elicit_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = PutSessionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PutSessionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
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
                    {"x-amz-lex-active-contexts",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-active-contexts_Value"))},
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-dialog-state","x-amz-lex-dialog-state_Value"},
                    {"x-amz-lex-intent-name","x-amz-lex-intent-name_Value"},
                    {"x-amz-lex-message","x-amz-lex-message_Value"},
                    {"x-amz-lex-message-format","x-amz-lex-message-format_Value"},
                    {"x-amz-lex-session-attributes",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-session-attributes_Value"))},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-slots",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-slots_Value"))},
                    {"x-amz-lex-slot-to-elicit","x-amz-lex-slot-to-elicit_Value"},
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
        [TestCategory("Lex")]
        public void PutSession_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutSession");

            var request = InstantiateClassGenerator.Execute<PutSessionRequest>();
            var marshaller = new PutSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PutSession", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("BadRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amz-lex-active-contexts",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-active-contexts_Value"))},
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-dialog-state","x-amz-lex-dialog-state_Value"},
                    {"x-amz-lex-intent-name","x-amz-lex-intent-name_Value"},
                    {"x-amz-lex-message","x-amz-lex-message_Value"},
                    {"x-amz-lex-message-format","x-amz-lex-message-format_Value"},
                    {"x-amz-lex-session-attributes",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-session-attributes_Value"))},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-slots",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-slots_Value"))},
                    {"x-amz-lex-slot-to-elicit","x-amz-lex-slot-to-elicit_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","BadRequestException"},
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
        [TestCategory("Lex")]
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
                    {"x-amz-lex-active-contexts",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-active-contexts_Value"))},
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-dialog-state","x-amz-lex-dialog-state_Value"},
                    {"x-amz-lex-intent-name","x-amz-lex-intent-name_Value"},
                    {"x-amz-lex-message","x-amz-lex-message_Value"},
                    {"x-amz-lex-message-format","x-amz-lex-message-format_Value"},
                    {"x-amz-lex-session-attributes",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-session-attributes_Value"))},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-slots",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-slots_Value"))},
                    {"x-amz-lex-slot-to-elicit","x-amz-lex-slot-to-elicit_Value"},
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
        [TestCategory("Lex")]
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
                    {"x-amz-lex-active-contexts",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-active-contexts_Value"))},
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-dialog-state","x-amz-lex-dialog-state_Value"},
                    {"x-amz-lex-intent-name","x-amz-lex-intent-name_Value"},
                    {"x-amz-lex-message","x-amz-lex-message_Value"},
                    {"x-amz-lex-message-format","x-amz-lex-message-format_Value"},
                    {"x-amz-lex-session-attributes",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-session-attributes_Value"))},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-slots",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-slots_Value"))},
                    {"x-amz-lex-slot-to-elicit","x-amz-lex-slot-to-elicit_Value"},
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
        [TestCategory("Lex")]
        public void PutSession_InternalFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutSession");

            var request = InstantiateClassGenerator.Execute<PutSessionRequest>();
            var marshaller = new PutSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PutSession", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalFailureException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amz-lex-active-contexts",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-active-contexts_Value"))},
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-dialog-state","x-amz-lex-dialog-state_Value"},
                    {"x-amz-lex-intent-name","x-amz-lex-intent-name_Value"},
                    {"x-amz-lex-message","x-amz-lex-message_Value"},
                    {"x-amz-lex-message-format","x-amz-lex-message-format_Value"},
                    {"x-amz-lex-session-attributes",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-session-attributes_Value"))},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-slots",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-slots_Value"))},
                    {"x-amz-lex-slot-to-elicit","x-amz-lex-slot-to-elicit_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalFailureException"},
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
        [TestCategory("Lex")]
        public void PutSession_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutSession");

            var request = InstantiateClassGenerator.Execute<PutSessionRequest>();
            var marshaller = new PutSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PutSession", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amz-lex-active-contexts",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-active-contexts_Value"))},
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-dialog-state","x-amz-lex-dialog-state_Value"},
                    {"x-amz-lex-intent-name","x-amz-lex-intent-name_Value"},
                    {"x-amz-lex-message","x-amz-lex-message_Value"},
                    {"x-amz-lex-message-format","x-amz-lex-message-format_Value"},
                    {"x-amz-lex-session-attributes",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-session-attributes_Value"))},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-slots",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-slots_Value"))},
                    {"x-amz-lex-slot-to-elicit","x-amz-lex-slot-to-elicit_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","LimitExceededException"},
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
        [TestCategory("Lex")]
        public void PutSession_NotAcceptableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutSession");

            var request = InstantiateClassGenerator.Execute<PutSessionRequest>();
            var marshaller = new PutSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PutSession", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotAcceptableException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amz-lex-active-contexts",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-active-contexts_Value"))},
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-dialog-state","x-amz-lex-dialog-state_Value"},
                    {"x-amz-lex-intent-name","x-amz-lex-intent-name_Value"},
                    {"x-amz-lex-message","x-amz-lex-message_Value"},
                    {"x-amz-lex-message-format","x-amz-lex-message-format_Value"},
                    {"x-amz-lex-session-attributes",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-session-attributes_Value"))},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-slots",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-slots_Value"))},
                    {"x-amz-lex-slot-to-elicit","x-amz-lex-slot-to-elicit_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotAcceptableException"},
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
        [TestCategory("Lex")]
        public void PutSession_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutSession");

            var request = InstantiateClassGenerator.Execute<PutSessionRequest>();
            var marshaller = new PutSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PutSession", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amz-lex-active-contexts",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-active-contexts_Value"))},
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-dialog-state","x-amz-lex-dialog-state_Value"},
                    {"x-amz-lex-intent-name","x-amz-lex-intent-name_Value"},
                    {"x-amz-lex-message","x-amz-lex-message_Value"},
                    {"x-amz-lex-message-format","x-amz-lex-message-format_Value"},
                    {"x-amz-lex-session-attributes",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-session-attributes_Value"))},
                    {"x-amz-lex-session-id","x-amz-lex-session-id_Value"},
                    {"x-amz-lex-slots",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-slots_Value"))},
                    {"x-amz-lex-slot-to-elicit","x-amz-lex-slot-to-elicit_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PutSessionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}