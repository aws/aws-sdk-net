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
 * Do not modify this file. This file is generated from the apigatewaymanagementapi-2018-11-29.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.ApiGatewayManagementApi;
using Amazon.ApiGatewayManagementApi.Model;
using Amazon.ApiGatewayManagementApi.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class ApiGatewayManagementApiMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("apigatewaymanagementapi");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ApiGatewayManagementApi")]
        public void DeleteConnectionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteConnection");

            var request = InstantiateClassGenerator.Execute<DeleteConnectionRequest>();
            var marshaller = new DeleteConnectionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteConnection", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ApiGatewayManagementApi")]
        public void DeleteConnection_ForbiddenExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteConnection");

            var request = InstantiateClassGenerator.Execute<DeleteConnectionRequest>();
            var marshaller = new DeleteConnectionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteConnection", request, internalRequest, service_model);

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
            var response = DeleteConnectionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ApiGatewayManagementApi")]
        public void DeleteConnection_GoneExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteConnection");

            var request = InstantiateClassGenerator.Execute<DeleteConnectionRequest>();
            var marshaller = new DeleteConnectionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteConnection", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GoneException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","GoneException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteConnectionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ApiGatewayManagementApi")]
        public void DeleteConnection_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteConnection");

            var request = InstantiateClassGenerator.Execute<DeleteConnectionRequest>();
            var marshaller = new DeleteConnectionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteConnection", request, internalRequest, service_model);

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
            var response = DeleteConnectionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ApiGatewayManagementApi")]
        public void GetConnectionMarshallTest()
        {
            var operation = service_model.FindOperation("GetConnection");

            var request = InstantiateClassGenerator.Execute<GetConnectionRequest>();
            var marshaller = new GetConnectionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetConnection", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = GetConnectionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetConnectionResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ApiGatewayManagementApi")]
        public void GetConnection_ForbiddenExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetConnection");

            var request = InstantiateClassGenerator.Execute<GetConnectionRequest>();
            var marshaller = new GetConnectionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetConnection", request, internalRequest, service_model);

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
            var response = GetConnectionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ApiGatewayManagementApi")]
        public void GetConnection_GoneExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetConnection");

            var request = InstantiateClassGenerator.Execute<GetConnectionRequest>();
            var marshaller = new GetConnectionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetConnection", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GoneException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","GoneException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetConnectionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ApiGatewayManagementApi")]
        public void GetConnection_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetConnection");

            var request = InstantiateClassGenerator.Execute<GetConnectionRequest>();
            var marshaller = new GetConnectionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetConnection", request, internalRequest, service_model);

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
            var response = GetConnectionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ApiGatewayManagementApi")]
        public void PostToConnectionMarshallTest()
        {
            var operation = service_model.FindOperation("PostToConnection");

            var request = InstantiateClassGenerator.Execute<PostToConnectionRequest>();
            var marshaller = new PostToConnectionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PostToConnection", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ApiGatewayManagementApi")]
        public void PostToConnection_ForbiddenExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PostToConnection");

            var request = InstantiateClassGenerator.Execute<PostToConnectionRequest>();
            var marshaller = new PostToConnectionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PostToConnection", request, internalRequest, service_model);

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
            var response = PostToConnectionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ApiGatewayManagementApi")]
        public void PostToConnection_GoneExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PostToConnection");

            var request = InstantiateClassGenerator.Execute<PostToConnectionRequest>();
            var marshaller = new PostToConnectionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PostToConnection", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GoneException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","GoneException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PostToConnectionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ApiGatewayManagementApi")]
        public void PostToConnection_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PostToConnection");

            var request = InstantiateClassGenerator.Execute<PostToConnectionRequest>();
            var marshaller = new PostToConnectionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PostToConnection", request, internalRequest, service_model);

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
            var response = PostToConnectionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ApiGatewayManagementApi")]
        public void PostToConnection_PayloadTooLargeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PostToConnection");

            var request = InstantiateClassGenerator.Execute<PostToConnectionRequest>();
            var marshaller = new PostToConnectionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PostToConnection", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("PayloadTooLargeException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","PayloadTooLargeException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PostToConnectionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}