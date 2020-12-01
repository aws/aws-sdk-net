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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.AmplifyBackend;
using Amazon.AmplifyBackend.Model;
using Amazon.AmplifyBackend.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class AmplifyBackendMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("amplifybackend");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CloneBackendMarshallTest()
        {
            var operation = service_model.FindOperation("CloneBackend");

            var request = InstantiateClassGenerator.Execute<CloneBackendRequest>();
            var marshaller = new CloneBackendRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CloneBackend", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CloneBackendResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CloneBackendResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CloneBackend_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CloneBackend");

            var request = InstantiateClassGenerator.Execute<CloneBackendRequest>();
            var marshaller = new CloneBackendRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CloneBackend", request, internalRequest, service_model);

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
            var response = CloneBackendResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CloneBackend_GatewayTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CloneBackend");

            var request = InstantiateClassGenerator.Execute<CloneBackendRequest>();
            var marshaller = new CloneBackendRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CloneBackend", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GatewayTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","GatewayTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CloneBackendResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CloneBackend_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CloneBackend");

            var request = InstantiateClassGenerator.Execute<CloneBackendRequest>();
            var marshaller = new CloneBackendRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CloneBackend", request, internalRequest, service_model);

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
            var response = CloneBackendResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CloneBackend_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CloneBackend");

            var request = InstantiateClassGenerator.Execute<CloneBackendRequest>();
            var marshaller = new CloneBackendRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CloneBackend", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TooManyRequestsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CloneBackendResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CreateBackendMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBackend");

            var request = InstantiateClassGenerator.Execute<CreateBackendRequest>();
            var marshaller = new CreateBackendRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateBackend", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateBackendResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateBackendResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CreateBackend_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBackend");

            var request = InstantiateClassGenerator.Execute<CreateBackendRequest>();
            var marshaller = new CreateBackendRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateBackend", request, internalRequest, service_model);

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
            var response = CreateBackendResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CreateBackend_GatewayTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBackend");

            var request = InstantiateClassGenerator.Execute<CreateBackendRequest>();
            var marshaller = new CreateBackendRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateBackend", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GatewayTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","GatewayTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateBackendResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CreateBackend_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBackend");

            var request = InstantiateClassGenerator.Execute<CreateBackendRequest>();
            var marshaller = new CreateBackendRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateBackend", request, internalRequest, service_model);

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
            var response = CreateBackendResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CreateBackend_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBackend");

            var request = InstantiateClassGenerator.Execute<CreateBackendRequest>();
            var marshaller = new CreateBackendRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateBackend", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TooManyRequestsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateBackendResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CreateBackendAPIMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBackendAPI");

            var request = InstantiateClassGenerator.Execute<CreateBackendAPIRequest>();
            var marshaller = new CreateBackendAPIRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateBackendAPI", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateBackendAPIResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateBackendAPIResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CreateBackendAPI_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBackendAPI");

            var request = InstantiateClassGenerator.Execute<CreateBackendAPIRequest>();
            var marshaller = new CreateBackendAPIRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateBackendAPI", request, internalRequest, service_model);

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
            var response = CreateBackendAPIResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CreateBackendAPI_GatewayTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBackendAPI");

            var request = InstantiateClassGenerator.Execute<CreateBackendAPIRequest>();
            var marshaller = new CreateBackendAPIRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateBackendAPI", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GatewayTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","GatewayTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateBackendAPIResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CreateBackendAPI_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBackendAPI");

            var request = InstantiateClassGenerator.Execute<CreateBackendAPIRequest>();
            var marshaller = new CreateBackendAPIRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateBackendAPI", request, internalRequest, service_model);

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
            var response = CreateBackendAPIResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CreateBackendAPI_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBackendAPI");

            var request = InstantiateClassGenerator.Execute<CreateBackendAPIRequest>();
            var marshaller = new CreateBackendAPIRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateBackendAPI", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TooManyRequestsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateBackendAPIResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CreateBackendAuthMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBackendAuth");

            var request = InstantiateClassGenerator.Execute<CreateBackendAuthRequest>();
            var marshaller = new CreateBackendAuthRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateBackendAuth", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateBackendAuthResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateBackendAuthResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CreateBackendAuth_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBackendAuth");

            var request = InstantiateClassGenerator.Execute<CreateBackendAuthRequest>();
            var marshaller = new CreateBackendAuthRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateBackendAuth", request, internalRequest, service_model);

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
            var response = CreateBackendAuthResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CreateBackendAuth_GatewayTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBackendAuth");

            var request = InstantiateClassGenerator.Execute<CreateBackendAuthRequest>();
            var marshaller = new CreateBackendAuthRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateBackendAuth", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GatewayTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","GatewayTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateBackendAuthResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CreateBackendAuth_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBackendAuth");

            var request = InstantiateClassGenerator.Execute<CreateBackendAuthRequest>();
            var marshaller = new CreateBackendAuthRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateBackendAuth", request, internalRequest, service_model);

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
            var response = CreateBackendAuthResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CreateBackendAuth_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBackendAuth");

            var request = InstantiateClassGenerator.Execute<CreateBackendAuthRequest>();
            var marshaller = new CreateBackendAuthRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateBackendAuth", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TooManyRequestsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateBackendAuthResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CreateBackendConfigMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBackendConfig");

            var request = InstantiateClassGenerator.Execute<CreateBackendConfigRequest>();
            var marshaller = new CreateBackendConfigRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateBackendConfig", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateBackendConfigResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateBackendConfigResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CreateBackendConfig_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBackendConfig");

            var request = InstantiateClassGenerator.Execute<CreateBackendConfigRequest>();
            var marshaller = new CreateBackendConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateBackendConfig", request, internalRequest, service_model);

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
            var response = CreateBackendConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CreateBackendConfig_GatewayTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBackendConfig");

            var request = InstantiateClassGenerator.Execute<CreateBackendConfigRequest>();
            var marshaller = new CreateBackendConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateBackendConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GatewayTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","GatewayTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateBackendConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CreateBackendConfig_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBackendConfig");

            var request = InstantiateClassGenerator.Execute<CreateBackendConfigRequest>();
            var marshaller = new CreateBackendConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateBackendConfig", request, internalRequest, service_model);

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
            var response = CreateBackendConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CreateBackendConfig_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBackendConfig");

            var request = InstantiateClassGenerator.Execute<CreateBackendConfigRequest>();
            var marshaller = new CreateBackendConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateBackendConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TooManyRequestsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateBackendConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CreateTokenMarshallTest()
        {
            var operation = service_model.FindOperation("CreateToken");

            var request = InstantiateClassGenerator.Execute<CreateTokenRequest>();
            var marshaller = new CreateTokenRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateToken", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateTokenResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateTokenResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CreateToken_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateToken");

            var request = InstantiateClassGenerator.Execute<CreateTokenRequest>();
            var marshaller = new CreateTokenRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateToken", request, internalRequest, service_model);

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
            var response = CreateTokenResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CreateToken_GatewayTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateToken");

            var request = InstantiateClassGenerator.Execute<CreateTokenRequest>();
            var marshaller = new CreateTokenRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateToken", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GatewayTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","GatewayTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateTokenResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CreateToken_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateToken");

            var request = InstantiateClassGenerator.Execute<CreateTokenRequest>();
            var marshaller = new CreateTokenRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateToken", request, internalRequest, service_model);

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
            var response = CreateTokenResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void CreateToken_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateToken");

            var request = InstantiateClassGenerator.Execute<CreateTokenRequest>();
            var marshaller = new CreateTokenRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateToken", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TooManyRequestsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateTokenResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void DeleteBackendMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBackend");

            var request = InstantiateClassGenerator.Execute<DeleteBackendRequest>();
            var marshaller = new DeleteBackendRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteBackend", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteBackendResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteBackendResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void DeleteBackend_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBackend");

            var request = InstantiateClassGenerator.Execute<DeleteBackendRequest>();
            var marshaller = new DeleteBackendRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteBackend", request, internalRequest, service_model);

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
            var response = DeleteBackendResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void DeleteBackend_GatewayTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBackend");

            var request = InstantiateClassGenerator.Execute<DeleteBackendRequest>();
            var marshaller = new DeleteBackendRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteBackend", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GatewayTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","GatewayTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteBackendResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void DeleteBackend_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBackend");

            var request = InstantiateClassGenerator.Execute<DeleteBackendRequest>();
            var marshaller = new DeleteBackendRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteBackend", request, internalRequest, service_model);

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
            var response = DeleteBackendResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void DeleteBackend_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBackend");

            var request = InstantiateClassGenerator.Execute<DeleteBackendRequest>();
            var marshaller = new DeleteBackendRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteBackend", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TooManyRequestsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteBackendResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void DeleteBackendAPIMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBackendAPI");

            var request = InstantiateClassGenerator.Execute<DeleteBackendAPIRequest>();
            var marshaller = new DeleteBackendAPIRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteBackendAPI", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteBackendAPIResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteBackendAPIResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void DeleteBackendAPI_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBackendAPI");

            var request = InstantiateClassGenerator.Execute<DeleteBackendAPIRequest>();
            var marshaller = new DeleteBackendAPIRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteBackendAPI", request, internalRequest, service_model);

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
            var response = DeleteBackendAPIResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void DeleteBackendAPI_GatewayTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBackendAPI");

            var request = InstantiateClassGenerator.Execute<DeleteBackendAPIRequest>();
            var marshaller = new DeleteBackendAPIRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteBackendAPI", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GatewayTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","GatewayTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteBackendAPIResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void DeleteBackendAPI_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBackendAPI");

            var request = InstantiateClassGenerator.Execute<DeleteBackendAPIRequest>();
            var marshaller = new DeleteBackendAPIRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteBackendAPI", request, internalRequest, service_model);

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
            var response = DeleteBackendAPIResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void DeleteBackendAPI_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBackendAPI");

            var request = InstantiateClassGenerator.Execute<DeleteBackendAPIRequest>();
            var marshaller = new DeleteBackendAPIRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteBackendAPI", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TooManyRequestsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteBackendAPIResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void DeleteBackendAuthMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBackendAuth");

            var request = InstantiateClassGenerator.Execute<DeleteBackendAuthRequest>();
            var marshaller = new DeleteBackendAuthRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteBackendAuth", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteBackendAuthResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteBackendAuthResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void DeleteBackendAuth_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBackendAuth");

            var request = InstantiateClassGenerator.Execute<DeleteBackendAuthRequest>();
            var marshaller = new DeleteBackendAuthRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteBackendAuth", request, internalRequest, service_model);

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
            var response = DeleteBackendAuthResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void DeleteBackendAuth_GatewayTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBackendAuth");

            var request = InstantiateClassGenerator.Execute<DeleteBackendAuthRequest>();
            var marshaller = new DeleteBackendAuthRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteBackendAuth", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GatewayTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","GatewayTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteBackendAuthResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void DeleteBackendAuth_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBackendAuth");

            var request = InstantiateClassGenerator.Execute<DeleteBackendAuthRequest>();
            var marshaller = new DeleteBackendAuthRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteBackendAuth", request, internalRequest, service_model);

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
            var response = DeleteBackendAuthResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void DeleteBackendAuth_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBackendAuth");

            var request = InstantiateClassGenerator.Execute<DeleteBackendAuthRequest>();
            var marshaller = new DeleteBackendAuthRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteBackendAuth", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TooManyRequestsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteBackendAuthResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void DeleteTokenMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteToken");

            var request = InstantiateClassGenerator.Execute<DeleteTokenRequest>();
            var marshaller = new DeleteTokenRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteToken", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteTokenResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteTokenResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void DeleteToken_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteToken");

            var request = InstantiateClassGenerator.Execute<DeleteTokenRequest>();
            var marshaller = new DeleteTokenRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteToken", request, internalRequest, service_model);

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
            var response = DeleteTokenResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void DeleteToken_GatewayTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteToken");

            var request = InstantiateClassGenerator.Execute<DeleteTokenRequest>();
            var marshaller = new DeleteTokenRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteToken", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GatewayTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","GatewayTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteTokenResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void DeleteToken_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteToken");

            var request = InstantiateClassGenerator.Execute<DeleteTokenRequest>();
            var marshaller = new DeleteTokenRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteToken", request, internalRequest, service_model);

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
            var response = DeleteTokenResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void DeleteToken_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteToken");

            var request = InstantiateClassGenerator.Execute<DeleteTokenRequest>();
            var marshaller = new DeleteTokenRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteToken", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TooManyRequestsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteTokenResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GenerateBackendAPIModelsMarshallTest()
        {
            var operation = service_model.FindOperation("GenerateBackendAPIModels");

            var request = InstantiateClassGenerator.Execute<GenerateBackendAPIModelsRequest>();
            var marshaller = new GenerateBackendAPIModelsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GenerateBackendAPIModels", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GenerateBackendAPIModelsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GenerateBackendAPIModelsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GenerateBackendAPIModels_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GenerateBackendAPIModels");

            var request = InstantiateClassGenerator.Execute<GenerateBackendAPIModelsRequest>();
            var marshaller = new GenerateBackendAPIModelsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GenerateBackendAPIModels", request, internalRequest, service_model);

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
            var response = GenerateBackendAPIModelsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GenerateBackendAPIModels_GatewayTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GenerateBackendAPIModels");

            var request = InstantiateClassGenerator.Execute<GenerateBackendAPIModelsRequest>();
            var marshaller = new GenerateBackendAPIModelsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GenerateBackendAPIModels", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GatewayTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","GatewayTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GenerateBackendAPIModelsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GenerateBackendAPIModels_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GenerateBackendAPIModels");

            var request = InstantiateClassGenerator.Execute<GenerateBackendAPIModelsRequest>();
            var marshaller = new GenerateBackendAPIModelsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GenerateBackendAPIModels", request, internalRequest, service_model);

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
            var response = GenerateBackendAPIModelsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GenerateBackendAPIModels_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GenerateBackendAPIModels");

            var request = InstantiateClassGenerator.Execute<GenerateBackendAPIModelsRequest>();
            var marshaller = new GenerateBackendAPIModelsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GenerateBackendAPIModels", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TooManyRequestsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GenerateBackendAPIModelsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetBackendMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackend");

            var request = InstantiateClassGenerator.Execute<GetBackendRequest>();
            var marshaller = new GetBackendRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBackend", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetBackendResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetBackendResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetBackend_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackend");

            var request = InstantiateClassGenerator.Execute<GetBackendRequest>();
            var marshaller = new GetBackendRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetBackend", request, internalRequest, service_model);

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
            var response = GetBackendResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetBackend_GatewayTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackend");

            var request = InstantiateClassGenerator.Execute<GetBackendRequest>();
            var marshaller = new GetBackendRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetBackend", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GatewayTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","GatewayTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetBackendResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetBackend_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackend");

            var request = InstantiateClassGenerator.Execute<GetBackendRequest>();
            var marshaller = new GetBackendRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetBackend", request, internalRequest, service_model);

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
            var response = GetBackendResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetBackend_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackend");

            var request = InstantiateClassGenerator.Execute<GetBackendRequest>();
            var marshaller = new GetBackendRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetBackend", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TooManyRequestsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetBackendResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetBackendAPIMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackendAPI");

            var request = InstantiateClassGenerator.Execute<GetBackendAPIRequest>();
            var marshaller = new GetBackendAPIRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBackendAPI", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetBackendAPIResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetBackendAPIResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetBackendAPI_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackendAPI");

            var request = InstantiateClassGenerator.Execute<GetBackendAPIRequest>();
            var marshaller = new GetBackendAPIRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetBackendAPI", request, internalRequest, service_model);

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
            var response = GetBackendAPIResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetBackendAPI_GatewayTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackendAPI");

            var request = InstantiateClassGenerator.Execute<GetBackendAPIRequest>();
            var marshaller = new GetBackendAPIRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetBackendAPI", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GatewayTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","GatewayTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetBackendAPIResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetBackendAPI_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackendAPI");

            var request = InstantiateClassGenerator.Execute<GetBackendAPIRequest>();
            var marshaller = new GetBackendAPIRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetBackendAPI", request, internalRequest, service_model);

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
            var response = GetBackendAPIResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetBackendAPI_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackendAPI");

            var request = InstantiateClassGenerator.Execute<GetBackendAPIRequest>();
            var marshaller = new GetBackendAPIRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetBackendAPI", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TooManyRequestsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetBackendAPIResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetBackendAPIModelsMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackendAPIModels");

            var request = InstantiateClassGenerator.Execute<GetBackendAPIModelsRequest>();
            var marshaller = new GetBackendAPIModelsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBackendAPIModels", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetBackendAPIModelsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetBackendAPIModelsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetBackendAPIModels_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackendAPIModels");

            var request = InstantiateClassGenerator.Execute<GetBackendAPIModelsRequest>();
            var marshaller = new GetBackendAPIModelsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetBackendAPIModels", request, internalRequest, service_model);

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
            var response = GetBackendAPIModelsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetBackendAPIModels_GatewayTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackendAPIModels");

            var request = InstantiateClassGenerator.Execute<GetBackendAPIModelsRequest>();
            var marshaller = new GetBackendAPIModelsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetBackendAPIModels", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GatewayTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","GatewayTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetBackendAPIModelsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetBackendAPIModels_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackendAPIModels");

            var request = InstantiateClassGenerator.Execute<GetBackendAPIModelsRequest>();
            var marshaller = new GetBackendAPIModelsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetBackendAPIModels", request, internalRequest, service_model);

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
            var response = GetBackendAPIModelsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetBackendAPIModels_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackendAPIModels");

            var request = InstantiateClassGenerator.Execute<GetBackendAPIModelsRequest>();
            var marshaller = new GetBackendAPIModelsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetBackendAPIModels", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TooManyRequestsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetBackendAPIModelsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetBackendAuthMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackendAuth");

            var request = InstantiateClassGenerator.Execute<GetBackendAuthRequest>();
            var marshaller = new GetBackendAuthRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBackendAuth", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetBackendAuthResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetBackendAuthResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetBackendAuth_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackendAuth");

            var request = InstantiateClassGenerator.Execute<GetBackendAuthRequest>();
            var marshaller = new GetBackendAuthRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetBackendAuth", request, internalRequest, service_model);

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
            var response = GetBackendAuthResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetBackendAuth_GatewayTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackendAuth");

            var request = InstantiateClassGenerator.Execute<GetBackendAuthRequest>();
            var marshaller = new GetBackendAuthRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetBackendAuth", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GatewayTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","GatewayTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetBackendAuthResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetBackendAuth_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackendAuth");

            var request = InstantiateClassGenerator.Execute<GetBackendAuthRequest>();
            var marshaller = new GetBackendAuthRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetBackendAuth", request, internalRequest, service_model);

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
            var response = GetBackendAuthResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetBackendAuth_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackendAuth");

            var request = InstantiateClassGenerator.Execute<GetBackendAuthRequest>();
            var marshaller = new GetBackendAuthRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetBackendAuth", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TooManyRequestsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetBackendAuthResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetBackendJobMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackendJob");

            var request = InstantiateClassGenerator.Execute<GetBackendJobRequest>();
            var marshaller = new GetBackendJobRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBackendJob", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetBackendJobResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetBackendJobResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetBackendJob_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackendJob");

            var request = InstantiateClassGenerator.Execute<GetBackendJobRequest>();
            var marshaller = new GetBackendJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetBackendJob", request, internalRequest, service_model);

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
            var response = GetBackendJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetBackendJob_GatewayTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackendJob");

            var request = InstantiateClassGenerator.Execute<GetBackendJobRequest>();
            var marshaller = new GetBackendJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetBackendJob", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GatewayTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","GatewayTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetBackendJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetBackendJob_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackendJob");

            var request = InstantiateClassGenerator.Execute<GetBackendJobRequest>();
            var marshaller = new GetBackendJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetBackendJob", request, internalRequest, service_model);

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
            var response = GetBackendJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetBackendJob_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBackendJob");

            var request = InstantiateClassGenerator.Execute<GetBackendJobRequest>();
            var marshaller = new GetBackendJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetBackendJob", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TooManyRequestsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetBackendJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetTokenMarshallTest()
        {
            var operation = service_model.FindOperation("GetToken");

            var request = InstantiateClassGenerator.Execute<GetTokenRequest>();
            var marshaller = new GetTokenRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetToken", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetTokenResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetTokenResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetToken_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetToken");

            var request = InstantiateClassGenerator.Execute<GetTokenRequest>();
            var marshaller = new GetTokenRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetToken", request, internalRequest, service_model);

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
            var response = GetTokenResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetToken_GatewayTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetToken");

            var request = InstantiateClassGenerator.Execute<GetTokenRequest>();
            var marshaller = new GetTokenRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetToken", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GatewayTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","GatewayTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetTokenResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetToken_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetToken");

            var request = InstantiateClassGenerator.Execute<GetTokenRequest>();
            var marshaller = new GetTokenRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetToken", request, internalRequest, service_model);

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
            var response = GetTokenResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void GetToken_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetToken");

            var request = InstantiateClassGenerator.Execute<GetTokenRequest>();
            var marshaller = new GetTokenRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetToken", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TooManyRequestsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetTokenResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void ListBackendJobsMarshallTest()
        {
            var operation = service_model.FindOperation("ListBackendJobs");

            var request = InstantiateClassGenerator.Execute<ListBackendJobsRequest>();
            var marshaller = new ListBackendJobsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListBackendJobs", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListBackendJobsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListBackendJobsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void ListBackendJobs_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListBackendJobs");

            var request = InstantiateClassGenerator.Execute<ListBackendJobsRequest>();
            var marshaller = new ListBackendJobsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListBackendJobs", request, internalRequest, service_model);

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
            var response = ListBackendJobsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void ListBackendJobs_GatewayTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListBackendJobs");

            var request = InstantiateClassGenerator.Execute<ListBackendJobsRequest>();
            var marshaller = new ListBackendJobsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListBackendJobs", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GatewayTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","GatewayTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListBackendJobsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void ListBackendJobs_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListBackendJobs");

            var request = InstantiateClassGenerator.Execute<ListBackendJobsRequest>();
            var marshaller = new ListBackendJobsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListBackendJobs", request, internalRequest, service_model);

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
            var response = ListBackendJobsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void ListBackendJobs_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListBackendJobs");

            var request = InstantiateClassGenerator.Execute<ListBackendJobsRequest>();
            var marshaller = new ListBackendJobsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListBackendJobs", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TooManyRequestsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListBackendJobsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void RemoveAllBackendsMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveAllBackends");

            var request = InstantiateClassGenerator.Execute<RemoveAllBackendsRequest>();
            var marshaller = new RemoveAllBackendsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("RemoveAllBackends", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = RemoveAllBackendsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as RemoveAllBackendsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void RemoveAllBackends_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveAllBackends");

            var request = InstantiateClassGenerator.Execute<RemoveAllBackendsRequest>();
            var marshaller = new RemoveAllBackendsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("RemoveAllBackends", request, internalRequest, service_model);

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
            var response = RemoveAllBackendsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void RemoveAllBackends_GatewayTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveAllBackends");

            var request = InstantiateClassGenerator.Execute<RemoveAllBackendsRequest>();
            var marshaller = new RemoveAllBackendsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("RemoveAllBackends", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GatewayTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","GatewayTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = RemoveAllBackendsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void RemoveAllBackends_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveAllBackends");

            var request = InstantiateClassGenerator.Execute<RemoveAllBackendsRequest>();
            var marshaller = new RemoveAllBackendsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("RemoveAllBackends", request, internalRequest, service_model);

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
            var response = RemoveAllBackendsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void RemoveAllBackends_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveAllBackends");

            var request = InstantiateClassGenerator.Execute<RemoveAllBackendsRequest>();
            var marshaller = new RemoveAllBackendsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("RemoveAllBackends", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TooManyRequestsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = RemoveAllBackendsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void RemoveBackendConfigMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveBackendConfig");

            var request = InstantiateClassGenerator.Execute<RemoveBackendConfigRequest>();
            var marshaller = new RemoveBackendConfigRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("RemoveBackendConfig", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = RemoveBackendConfigResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as RemoveBackendConfigResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void RemoveBackendConfig_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveBackendConfig");

            var request = InstantiateClassGenerator.Execute<RemoveBackendConfigRequest>();
            var marshaller = new RemoveBackendConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("RemoveBackendConfig", request, internalRequest, service_model);

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
            var response = RemoveBackendConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void RemoveBackendConfig_GatewayTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveBackendConfig");

            var request = InstantiateClassGenerator.Execute<RemoveBackendConfigRequest>();
            var marshaller = new RemoveBackendConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("RemoveBackendConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GatewayTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","GatewayTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = RemoveBackendConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void RemoveBackendConfig_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveBackendConfig");

            var request = InstantiateClassGenerator.Execute<RemoveBackendConfigRequest>();
            var marshaller = new RemoveBackendConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("RemoveBackendConfig", request, internalRequest, service_model);

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
            var response = RemoveBackendConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void RemoveBackendConfig_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveBackendConfig");

            var request = InstantiateClassGenerator.Execute<RemoveBackendConfigRequest>();
            var marshaller = new RemoveBackendConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("RemoveBackendConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TooManyRequestsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = RemoveBackendConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void UpdateBackendAPIMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateBackendAPI");

            var request = InstantiateClassGenerator.Execute<UpdateBackendAPIRequest>();
            var marshaller = new UpdateBackendAPIRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateBackendAPI", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateBackendAPIResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateBackendAPIResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void UpdateBackendAPI_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateBackendAPI");

            var request = InstantiateClassGenerator.Execute<UpdateBackendAPIRequest>();
            var marshaller = new UpdateBackendAPIRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateBackendAPI", request, internalRequest, service_model);

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
            var response = UpdateBackendAPIResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void UpdateBackendAPI_GatewayTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateBackendAPI");

            var request = InstantiateClassGenerator.Execute<UpdateBackendAPIRequest>();
            var marshaller = new UpdateBackendAPIRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateBackendAPI", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GatewayTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","GatewayTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateBackendAPIResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void UpdateBackendAPI_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateBackendAPI");

            var request = InstantiateClassGenerator.Execute<UpdateBackendAPIRequest>();
            var marshaller = new UpdateBackendAPIRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateBackendAPI", request, internalRequest, service_model);

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
            var response = UpdateBackendAPIResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void UpdateBackendAPI_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateBackendAPI");

            var request = InstantiateClassGenerator.Execute<UpdateBackendAPIRequest>();
            var marshaller = new UpdateBackendAPIRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateBackendAPI", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TooManyRequestsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateBackendAPIResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void UpdateBackendAuthMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateBackendAuth");

            var request = InstantiateClassGenerator.Execute<UpdateBackendAuthRequest>();
            var marshaller = new UpdateBackendAuthRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateBackendAuth", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateBackendAuthResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateBackendAuthResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void UpdateBackendAuth_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateBackendAuth");

            var request = InstantiateClassGenerator.Execute<UpdateBackendAuthRequest>();
            var marshaller = new UpdateBackendAuthRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateBackendAuth", request, internalRequest, service_model);

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
            var response = UpdateBackendAuthResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void UpdateBackendAuth_GatewayTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateBackendAuth");

            var request = InstantiateClassGenerator.Execute<UpdateBackendAuthRequest>();
            var marshaller = new UpdateBackendAuthRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateBackendAuth", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GatewayTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","GatewayTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateBackendAuthResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void UpdateBackendAuth_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateBackendAuth");

            var request = InstantiateClassGenerator.Execute<UpdateBackendAuthRequest>();
            var marshaller = new UpdateBackendAuthRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateBackendAuth", request, internalRequest, service_model);

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
            var response = UpdateBackendAuthResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void UpdateBackendAuth_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateBackendAuth");

            var request = InstantiateClassGenerator.Execute<UpdateBackendAuthRequest>();
            var marshaller = new UpdateBackendAuthRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateBackendAuth", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TooManyRequestsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateBackendAuthResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void UpdateBackendConfigMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateBackendConfig");

            var request = InstantiateClassGenerator.Execute<UpdateBackendConfigRequest>();
            var marshaller = new UpdateBackendConfigRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateBackendConfig", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateBackendConfigResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateBackendConfigResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void UpdateBackendConfig_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateBackendConfig");

            var request = InstantiateClassGenerator.Execute<UpdateBackendConfigRequest>();
            var marshaller = new UpdateBackendConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateBackendConfig", request, internalRequest, service_model);

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
            var response = UpdateBackendConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void UpdateBackendConfig_GatewayTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateBackendConfig");

            var request = InstantiateClassGenerator.Execute<UpdateBackendConfigRequest>();
            var marshaller = new UpdateBackendConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateBackendConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GatewayTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","GatewayTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateBackendConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void UpdateBackendConfig_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateBackendConfig");

            var request = InstantiateClassGenerator.Execute<UpdateBackendConfigRequest>();
            var marshaller = new UpdateBackendConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateBackendConfig", request, internalRequest, service_model);

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
            var response = UpdateBackendConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void UpdateBackendConfig_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateBackendConfig");

            var request = InstantiateClassGenerator.Execute<UpdateBackendConfigRequest>();
            var marshaller = new UpdateBackendConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateBackendConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TooManyRequestsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateBackendConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void UpdateBackendJobMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateBackendJob");

            var request = InstantiateClassGenerator.Execute<UpdateBackendJobRequest>();
            var marshaller = new UpdateBackendJobRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateBackendJob", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateBackendJobResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateBackendJobResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void UpdateBackendJob_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateBackendJob");

            var request = InstantiateClassGenerator.Execute<UpdateBackendJobRequest>();
            var marshaller = new UpdateBackendJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateBackendJob", request, internalRequest, service_model);

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
            var response = UpdateBackendJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void UpdateBackendJob_GatewayTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateBackendJob");

            var request = InstantiateClassGenerator.Execute<UpdateBackendJobRequest>();
            var marshaller = new UpdateBackendJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateBackendJob", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GatewayTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","GatewayTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateBackendJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void UpdateBackendJob_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateBackendJob");

            var request = InstantiateClassGenerator.Execute<UpdateBackendJobRequest>();
            var marshaller = new UpdateBackendJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateBackendJob", request, internalRequest, service_model);

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
            var response = UpdateBackendJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("AmplifyBackend")]
        public void UpdateBackendJob_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateBackendJob");

            var request = InstantiateClassGenerator.Execute<UpdateBackendJobRequest>();
            var marshaller = new UpdateBackendJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateBackendJob", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TooManyRequestsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateBackendJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}