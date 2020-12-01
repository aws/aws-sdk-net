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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Honeycode;
using Amazon.Honeycode.Model;
using Amazon.Honeycode.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class HoneycodeMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("honeycode");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchCreateTableRowsMarshallTest()
        {
            var operation = service_model.FindOperation("BatchCreateTableRows");

            var request = InstantiateClassGenerator.Execute<BatchCreateTableRowsRequest>();
            var marshaller = new BatchCreateTableRowsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("BatchCreateTableRows", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = BatchCreateTableRowsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as BatchCreateTableRowsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchCreateTableRows_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchCreateTableRows");

            var request = InstantiateClassGenerator.Execute<BatchCreateTableRowsRequest>();
            var marshaller = new BatchCreateTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchCreateTableRows", request, internalRequest, service_model);

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
            var response = BatchCreateTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchCreateTableRows_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchCreateTableRows");

            var request = InstantiateClassGenerator.Execute<BatchCreateTableRowsRequest>();
            var marshaller = new BatchCreateTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchCreateTableRows", request, internalRequest, service_model);

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
            var response = BatchCreateTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchCreateTableRows_RequestTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchCreateTableRows");

            var request = InstantiateClassGenerator.Execute<BatchCreateTableRowsRequest>();
            var marshaller = new BatchCreateTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchCreateTableRows", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("RequestTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","RequestTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = BatchCreateTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchCreateTableRows_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchCreateTableRows");

            var request = InstantiateClassGenerator.Execute<BatchCreateTableRowsRequest>();
            var marshaller = new BatchCreateTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchCreateTableRows", request, internalRequest, service_model);

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
            var response = BatchCreateTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchCreateTableRows_ServiceQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchCreateTableRows");

            var request = InstantiateClassGenerator.Execute<BatchCreateTableRowsRequest>();
            var marshaller = new BatchCreateTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchCreateTableRows", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceQuotaExceededException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceQuotaExceededException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = BatchCreateTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchCreateTableRows_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchCreateTableRows");

            var request = InstantiateClassGenerator.Execute<BatchCreateTableRowsRequest>();
            var marshaller = new BatchCreateTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchCreateTableRows", request, internalRequest, service_model);

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
            var response = BatchCreateTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchCreateTableRows_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchCreateTableRows");

            var request = InstantiateClassGenerator.Execute<BatchCreateTableRowsRequest>();
            var marshaller = new BatchCreateTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchCreateTableRows", request, internalRequest, service_model);

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
            var response = BatchCreateTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchCreateTableRows_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchCreateTableRows");

            var request = InstantiateClassGenerator.Execute<BatchCreateTableRowsRequest>();
            var marshaller = new BatchCreateTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchCreateTableRows", request, internalRequest, service_model);

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
            var response = BatchCreateTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchDeleteTableRowsMarshallTest()
        {
            var operation = service_model.FindOperation("BatchDeleteTableRows");

            var request = InstantiateClassGenerator.Execute<BatchDeleteTableRowsRequest>();
            var marshaller = new BatchDeleteTableRowsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("BatchDeleteTableRows", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = BatchDeleteTableRowsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as BatchDeleteTableRowsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchDeleteTableRows_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchDeleteTableRows");

            var request = InstantiateClassGenerator.Execute<BatchDeleteTableRowsRequest>();
            var marshaller = new BatchDeleteTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchDeleteTableRows", request, internalRequest, service_model);

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
            var response = BatchDeleteTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchDeleteTableRows_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchDeleteTableRows");

            var request = InstantiateClassGenerator.Execute<BatchDeleteTableRowsRequest>();
            var marshaller = new BatchDeleteTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchDeleteTableRows", request, internalRequest, service_model);

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
            var response = BatchDeleteTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchDeleteTableRows_RequestTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchDeleteTableRows");

            var request = InstantiateClassGenerator.Execute<BatchDeleteTableRowsRequest>();
            var marshaller = new BatchDeleteTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchDeleteTableRows", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("RequestTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","RequestTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = BatchDeleteTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchDeleteTableRows_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchDeleteTableRows");

            var request = InstantiateClassGenerator.Execute<BatchDeleteTableRowsRequest>();
            var marshaller = new BatchDeleteTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchDeleteTableRows", request, internalRequest, service_model);

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
            var response = BatchDeleteTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchDeleteTableRows_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchDeleteTableRows");

            var request = InstantiateClassGenerator.Execute<BatchDeleteTableRowsRequest>();
            var marshaller = new BatchDeleteTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchDeleteTableRows", request, internalRequest, service_model);

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
            var response = BatchDeleteTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchDeleteTableRows_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchDeleteTableRows");

            var request = InstantiateClassGenerator.Execute<BatchDeleteTableRowsRequest>();
            var marshaller = new BatchDeleteTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchDeleteTableRows", request, internalRequest, service_model);

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
            var response = BatchDeleteTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchDeleteTableRows_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchDeleteTableRows");

            var request = InstantiateClassGenerator.Execute<BatchDeleteTableRowsRequest>();
            var marshaller = new BatchDeleteTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchDeleteTableRows", request, internalRequest, service_model);

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
            var response = BatchDeleteTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchUpdateTableRowsMarshallTest()
        {
            var operation = service_model.FindOperation("BatchUpdateTableRows");

            var request = InstantiateClassGenerator.Execute<BatchUpdateTableRowsRequest>();
            var marshaller = new BatchUpdateTableRowsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("BatchUpdateTableRows", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = BatchUpdateTableRowsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as BatchUpdateTableRowsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchUpdateTableRows_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchUpdateTableRows");

            var request = InstantiateClassGenerator.Execute<BatchUpdateTableRowsRequest>();
            var marshaller = new BatchUpdateTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchUpdateTableRows", request, internalRequest, service_model);

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
            var response = BatchUpdateTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchUpdateTableRows_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchUpdateTableRows");

            var request = InstantiateClassGenerator.Execute<BatchUpdateTableRowsRequest>();
            var marshaller = new BatchUpdateTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchUpdateTableRows", request, internalRequest, service_model);

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
            var response = BatchUpdateTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchUpdateTableRows_RequestTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchUpdateTableRows");

            var request = InstantiateClassGenerator.Execute<BatchUpdateTableRowsRequest>();
            var marshaller = new BatchUpdateTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchUpdateTableRows", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("RequestTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","RequestTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = BatchUpdateTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchUpdateTableRows_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchUpdateTableRows");

            var request = InstantiateClassGenerator.Execute<BatchUpdateTableRowsRequest>();
            var marshaller = new BatchUpdateTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchUpdateTableRows", request, internalRequest, service_model);

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
            var response = BatchUpdateTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchUpdateTableRows_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchUpdateTableRows");

            var request = InstantiateClassGenerator.Execute<BatchUpdateTableRowsRequest>();
            var marshaller = new BatchUpdateTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchUpdateTableRows", request, internalRequest, service_model);

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
            var response = BatchUpdateTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchUpdateTableRows_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchUpdateTableRows");

            var request = InstantiateClassGenerator.Execute<BatchUpdateTableRowsRequest>();
            var marshaller = new BatchUpdateTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchUpdateTableRows", request, internalRequest, service_model);

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
            var response = BatchUpdateTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchUpdateTableRows_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchUpdateTableRows");

            var request = InstantiateClassGenerator.Execute<BatchUpdateTableRowsRequest>();
            var marshaller = new BatchUpdateTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchUpdateTableRows", request, internalRequest, service_model);

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
            var response = BatchUpdateTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchUpsertTableRowsMarshallTest()
        {
            var operation = service_model.FindOperation("BatchUpsertTableRows");

            var request = InstantiateClassGenerator.Execute<BatchUpsertTableRowsRequest>();
            var marshaller = new BatchUpsertTableRowsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("BatchUpsertTableRows", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = BatchUpsertTableRowsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as BatchUpsertTableRowsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchUpsertTableRows_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchUpsertTableRows");

            var request = InstantiateClassGenerator.Execute<BatchUpsertTableRowsRequest>();
            var marshaller = new BatchUpsertTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchUpsertTableRows", request, internalRequest, service_model);

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
            var response = BatchUpsertTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchUpsertTableRows_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchUpsertTableRows");

            var request = InstantiateClassGenerator.Execute<BatchUpsertTableRowsRequest>();
            var marshaller = new BatchUpsertTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchUpsertTableRows", request, internalRequest, service_model);

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
            var response = BatchUpsertTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchUpsertTableRows_RequestTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchUpsertTableRows");

            var request = InstantiateClassGenerator.Execute<BatchUpsertTableRowsRequest>();
            var marshaller = new BatchUpsertTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchUpsertTableRows", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("RequestTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","RequestTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = BatchUpsertTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchUpsertTableRows_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchUpsertTableRows");

            var request = InstantiateClassGenerator.Execute<BatchUpsertTableRowsRequest>();
            var marshaller = new BatchUpsertTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchUpsertTableRows", request, internalRequest, service_model);

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
            var response = BatchUpsertTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchUpsertTableRows_ServiceQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchUpsertTableRows");

            var request = InstantiateClassGenerator.Execute<BatchUpsertTableRowsRequest>();
            var marshaller = new BatchUpsertTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchUpsertTableRows", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceQuotaExceededException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceQuotaExceededException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = BatchUpsertTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchUpsertTableRows_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchUpsertTableRows");

            var request = InstantiateClassGenerator.Execute<BatchUpsertTableRowsRequest>();
            var marshaller = new BatchUpsertTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchUpsertTableRows", request, internalRequest, service_model);

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
            var response = BatchUpsertTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchUpsertTableRows_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchUpsertTableRows");

            var request = InstantiateClassGenerator.Execute<BatchUpsertTableRowsRequest>();
            var marshaller = new BatchUpsertTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchUpsertTableRows", request, internalRequest, service_model);

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
            var response = BatchUpsertTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void BatchUpsertTableRows_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchUpsertTableRows");

            var request = InstantiateClassGenerator.Execute<BatchUpsertTableRowsRequest>();
            var marshaller = new BatchUpsertTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchUpsertTableRows", request, internalRequest, service_model);

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
            var response = BatchUpsertTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void DescribeTableDataImportJobMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTableDataImportJob");

            var request = InstantiateClassGenerator.Execute<DescribeTableDataImportJobRequest>();
            var marshaller = new DescribeTableDataImportJobRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeTableDataImportJob", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeTableDataImportJobResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeTableDataImportJobResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void DescribeTableDataImportJob_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTableDataImportJob");

            var request = InstantiateClassGenerator.Execute<DescribeTableDataImportJobRequest>();
            var marshaller = new DescribeTableDataImportJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeTableDataImportJob", request, internalRequest, service_model);

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
            var response = DescribeTableDataImportJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void DescribeTableDataImportJob_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTableDataImportJob");

            var request = InstantiateClassGenerator.Execute<DescribeTableDataImportJobRequest>();
            var marshaller = new DescribeTableDataImportJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeTableDataImportJob", request, internalRequest, service_model);

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
            var response = DescribeTableDataImportJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void DescribeTableDataImportJob_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTableDataImportJob");

            var request = InstantiateClassGenerator.Execute<DescribeTableDataImportJobRequest>();
            var marshaller = new DescribeTableDataImportJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeTableDataImportJob", request, internalRequest, service_model);

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
            var response = DescribeTableDataImportJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void DescribeTableDataImportJob_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTableDataImportJob");

            var request = InstantiateClassGenerator.Execute<DescribeTableDataImportJobRequest>();
            var marshaller = new DescribeTableDataImportJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeTableDataImportJob", request, internalRequest, service_model);

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
            var response = DescribeTableDataImportJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void DescribeTableDataImportJob_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTableDataImportJob");

            var request = InstantiateClassGenerator.Execute<DescribeTableDataImportJobRequest>();
            var marshaller = new DescribeTableDataImportJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeTableDataImportJob", request, internalRequest, service_model);

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
            var response = DescribeTableDataImportJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void DescribeTableDataImportJob_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTableDataImportJob");

            var request = InstantiateClassGenerator.Execute<DescribeTableDataImportJobRequest>();
            var marshaller = new DescribeTableDataImportJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeTableDataImportJob", request, internalRequest, service_model);

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
            var response = DescribeTableDataImportJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void GetScreenDataMarshallTest()
        {
            var operation = service_model.FindOperation("GetScreenData");

            var request = InstantiateClassGenerator.Execute<GetScreenDataRequest>();
            var marshaller = new GetScreenDataRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetScreenData", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = GetScreenDataResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetScreenDataResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void GetScreenData_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetScreenData");

            var request = InstantiateClassGenerator.Execute<GetScreenDataRequest>();
            var marshaller = new GetScreenDataRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetScreenData", request, internalRequest, service_model);

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
            var response = GetScreenDataResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void GetScreenData_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetScreenData");

            var request = InstantiateClassGenerator.Execute<GetScreenDataRequest>();
            var marshaller = new GetScreenDataRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetScreenData", request, internalRequest, service_model);

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
            var response = GetScreenDataResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void GetScreenData_RequestTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetScreenData");

            var request = InstantiateClassGenerator.Execute<GetScreenDataRequest>();
            var marshaller = new GetScreenDataRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetScreenData", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("RequestTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","RequestTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetScreenDataResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void GetScreenData_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetScreenData");

            var request = InstantiateClassGenerator.Execute<GetScreenDataRequest>();
            var marshaller = new GetScreenDataRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetScreenData", request, internalRequest, service_model);

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
            var response = GetScreenDataResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void GetScreenData_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetScreenData");

            var request = InstantiateClassGenerator.Execute<GetScreenDataRequest>();
            var marshaller = new GetScreenDataRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetScreenData", request, internalRequest, service_model);

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
            var response = GetScreenDataResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void GetScreenData_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetScreenData");

            var request = InstantiateClassGenerator.Execute<GetScreenDataRequest>();
            var marshaller = new GetScreenDataRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetScreenData", request, internalRequest, service_model);

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
            var response = GetScreenDataResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void GetScreenData_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetScreenData");

            var request = InstantiateClassGenerator.Execute<GetScreenDataRequest>();
            var marshaller = new GetScreenDataRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetScreenData", request, internalRequest, service_model);

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
            var response = GetScreenDataResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void InvokeScreenAutomationMarshallTest()
        {
            var operation = service_model.FindOperation("InvokeScreenAutomation");

            var request = InstantiateClassGenerator.Execute<InvokeScreenAutomationRequest>();
            var marshaller = new InvokeScreenAutomationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("InvokeScreenAutomation", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = InvokeScreenAutomationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as InvokeScreenAutomationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void InvokeScreenAutomation_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("InvokeScreenAutomation");

            var request = InstantiateClassGenerator.Execute<InvokeScreenAutomationRequest>();
            var marshaller = new InvokeScreenAutomationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("InvokeScreenAutomation", request, internalRequest, service_model);

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
            var response = InvokeScreenAutomationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void InvokeScreenAutomation_AutomationExecutionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("InvokeScreenAutomation");

            var request = InstantiateClassGenerator.Execute<InvokeScreenAutomationRequest>();
            var marshaller = new InvokeScreenAutomationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("InvokeScreenAutomation", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AutomationExecutionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AutomationExecutionException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = InvokeScreenAutomationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void InvokeScreenAutomation_AutomationExecutionTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("InvokeScreenAutomation");

            var request = InstantiateClassGenerator.Execute<InvokeScreenAutomationRequest>();
            var marshaller = new InvokeScreenAutomationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("InvokeScreenAutomation", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AutomationExecutionTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AutomationExecutionTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = InvokeScreenAutomationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void InvokeScreenAutomation_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("InvokeScreenAutomation");

            var request = InstantiateClassGenerator.Execute<InvokeScreenAutomationRequest>();
            var marshaller = new InvokeScreenAutomationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("InvokeScreenAutomation", request, internalRequest, service_model);

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
            var response = InvokeScreenAutomationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void InvokeScreenAutomation_RequestTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("InvokeScreenAutomation");

            var request = InstantiateClassGenerator.Execute<InvokeScreenAutomationRequest>();
            var marshaller = new InvokeScreenAutomationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("InvokeScreenAutomation", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("RequestTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","RequestTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = InvokeScreenAutomationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void InvokeScreenAutomation_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("InvokeScreenAutomation");

            var request = InstantiateClassGenerator.Execute<InvokeScreenAutomationRequest>();
            var marshaller = new InvokeScreenAutomationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("InvokeScreenAutomation", request, internalRequest, service_model);

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
            var response = InvokeScreenAutomationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void InvokeScreenAutomation_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("InvokeScreenAutomation");

            var request = InstantiateClassGenerator.Execute<InvokeScreenAutomationRequest>();
            var marshaller = new InvokeScreenAutomationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("InvokeScreenAutomation", request, internalRequest, service_model);

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
            var response = InvokeScreenAutomationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void InvokeScreenAutomation_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("InvokeScreenAutomation");

            var request = InstantiateClassGenerator.Execute<InvokeScreenAutomationRequest>();
            var marshaller = new InvokeScreenAutomationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("InvokeScreenAutomation", request, internalRequest, service_model);

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
            var response = InvokeScreenAutomationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void InvokeScreenAutomation_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("InvokeScreenAutomation");

            var request = InstantiateClassGenerator.Execute<InvokeScreenAutomationRequest>();
            var marshaller = new InvokeScreenAutomationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("InvokeScreenAutomation", request, internalRequest, service_model);

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
            var response = InvokeScreenAutomationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void ListTableColumnsMarshallTest()
        {
            var operation = service_model.FindOperation("ListTableColumns");

            var request = InstantiateClassGenerator.Execute<ListTableColumnsRequest>();
            var marshaller = new ListTableColumnsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListTableColumns", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListTableColumnsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListTableColumnsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void ListTableColumns_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTableColumns");

            var request = InstantiateClassGenerator.Execute<ListTableColumnsRequest>();
            var marshaller = new ListTableColumnsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListTableColumns", request, internalRequest, service_model);

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
            var response = ListTableColumnsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void ListTableColumns_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTableColumns");

            var request = InstantiateClassGenerator.Execute<ListTableColumnsRequest>();
            var marshaller = new ListTableColumnsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListTableColumns", request, internalRequest, service_model);

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
            var response = ListTableColumnsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void ListTableColumns_RequestTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTableColumns");

            var request = InstantiateClassGenerator.Execute<ListTableColumnsRequest>();
            var marshaller = new ListTableColumnsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListTableColumns", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("RequestTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","RequestTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListTableColumnsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void ListTableColumns_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTableColumns");

            var request = InstantiateClassGenerator.Execute<ListTableColumnsRequest>();
            var marshaller = new ListTableColumnsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListTableColumns", request, internalRequest, service_model);

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
            var response = ListTableColumnsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void ListTableColumns_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTableColumns");

            var request = InstantiateClassGenerator.Execute<ListTableColumnsRequest>();
            var marshaller = new ListTableColumnsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListTableColumns", request, internalRequest, service_model);

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
            var response = ListTableColumnsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void ListTableColumns_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTableColumns");

            var request = InstantiateClassGenerator.Execute<ListTableColumnsRequest>();
            var marshaller = new ListTableColumnsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListTableColumns", request, internalRequest, service_model);

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
            var response = ListTableColumnsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void ListTableColumns_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTableColumns");

            var request = InstantiateClassGenerator.Execute<ListTableColumnsRequest>();
            var marshaller = new ListTableColumnsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListTableColumns", request, internalRequest, service_model);

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
            var response = ListTableColumnsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void ListTableRowsMarshallTest()
        {
            var operation = service_model.FindOperation("ListTableRows");

            var request = InstantiateClassGenerator.Execute<ListTableRowsRequest>();
            var marshaller = new ListTableRowsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListTableRows", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListTableRowsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListTableRowsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void ListTableRows_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTableRows");

            var request = InstantiateClassGenerator.Execute<ListTableRowsRequest>();
            var marshaller = new ListTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListTableRows", request, internalRequest, service_model);

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
            var response = ListTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void ListTableRows_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTableRows");

            var request = InstantiateClassGenerator.Execute<ListTableRowsRequest>();
            var marshaller = new ListTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListTableRows", request, internalRequest, service_model);

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
            var response = ListTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void ListTableRows_RequestTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTableRows");

            var request = InstantiateClassGenerator.Execute<ListTableRowsRequest>();
            var marshaller = new ListTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListTableRows", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("RequestTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","RequestTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void ListTableRows_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTableRows");

            var request = InstantiateClassGenerator.Execute<ListTableRowsRequest>();
            var marshaller = new ListTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListTableRows", request, internalRequest, service_model);

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
            var response = ListTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void ListTableRows_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTableRows");

            var request = InstantiateClassGenerator.Execute<ListTableRowsRequest>();
            var marshaller = new ListTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListTableRows", request, internalRequest, service_model);

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
            var response = ListTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void ListTableRows_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTableRows");

            var request = InstantiateClassGenerator.Execute<ListTableRowsRequest>();
            var marshaller = new ListTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListTableRows", request, internalRequest, service_model);

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
            var response = ListTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void ListTableRows_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTableRows");

            var request = InstantiateClassGenerator.Execute<ListTableRowsRequest>();
            var marshaller = new ListTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListTableRows", request, internalRequest, service_model);

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
            var response = ListTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void ListTablesMarshallTest()
        {
            var operation = service_model.FindOperation("ListTables");

            var request = InstantiateClassGenerator.Execute<ListTablesRequest>();
            var marshaller = new ListTablesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListTables", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListTablesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListTablesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void ListTables_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTables");

            var request = InstantiateClassGenerator.Execute<ListTablesRequest>();
            var marshaller = new ListTablesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListTables", request, internalRequest, service_model);

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
            var response = ListTablesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void ListTables_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTables");

            var request = InstantiateClassGenerator.Execute<ListTablesRequest>();
            var marshaller = new ListTablesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListTables", request, internalRequest, service_model);

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
            var response = ListTablesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void ListTables_RequestTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTables");

            var request = InstantiateClassGenerator.Execute<ListTablesRequest>();
            var marshaller = new ListTablesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListTables", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("RequestTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","RequestTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListTablesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void ListTables_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTables");

            var request = InstantiateClassGenerator.Execute<ListTablesRequest>();
            var marshaller = new ListTablesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListTables", request, internalRequest, service_model);

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
            var response = ListTablesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void ListTables_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTables");

            var request = InstantiateClassGenerator.Execute<ListTablesRequest>();
            var marshaller = new ListTablesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListTables", request, internalRequest, service_model);

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
            var response = ListTablesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void ListTables_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTables");

            var request = InstantiateClassGenerator.Execute<ListTablesRequest>();
            var marshaller = new ListTablesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListTables", request, internalRequest, service_model);

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
            var response = ListTablesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void ListTables_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTables");

            var request = InstantiateClassGenerator.Execute<ListTablesRequest>();
            var marshaller = new ListTablesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListTables", request, internalRequest, service_model);

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
            var response = ListTablesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void QueryTableRowsMarshallTest()
        {
            var operation = service_model.FindOperation("QueryTableRows");

            var request = InstantiateClassGenerator.Execute<QueryTableRowsRequest>();
            var marshaller = new QueryTableRowsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("QueryTableRows", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = QueryTableRowsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as QueryTableRowsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void QueryTableRows_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("QueryTableRows");

            var request = InstantiateClassGenerator.Execute<QueryTableRowsRequest>();
            var marshaller = new QueryTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("QueryTableRows", request, internalRequest, service_model);

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
            var response = QueryTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void QueryTableRows_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("QueryTableRows");

            var request = InstantiateClassGenerator.Execute<QueryTableRowsRequest>();
            var marshaller = new QueryTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("QueryTableRows", request, internalRequest, service_model);

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
            var response = QueryTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void QueryTableRows_RequestTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("QueryTableRows");

            var request = InstantiateClassGenerator.Execute<QueryTableRowsRequest>();
            var marshaller = new QueryTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("QueryTableRows", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("RequestTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","RequestTimeoutException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = QueryTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void QueryTableRows_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("QueryTableRows");

            var request = InstantiateClassGenerator.Execute<QueryTableRowsRequest>();
            var marshaller = new QueryTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("QueryTableRows", request, internalRequest, service_model);

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
            var response = QueryTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void QueryTableRows_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("QueryTableRows");

            var request = InstantiateClassGenerator.Execute<QueryTableRowsRequest>();
            var marshaller = new QueryTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("QueryTableRows", request, internalRequest, service_model);

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
            var response = QueryTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void QueryTableRows_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("QueryTableRows");

            var request = InstantiateClassGenerator.Execute<QueryTableRowsRequest>();
            var marshaller = new QueryTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("QueryTableRows", request, internalRequest, service_model);

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
            var response = QueryTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void QueryTableRows_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("QueryTableRows");

            var request = InstantiateClassGenerator.Execute<QueryTableRowsRequest>();
            var marshaller = new QueryTableRowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("QueryTableRows", request, internalRequest, service_model);

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
            var response = QueryTableRowsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void StartTableDataImportJobMarshallTest()
        {
            var operation = service_model.FindOperation("StartTableDataImportJob");

            var request = InstantiateClassGenerator.Execute<StartTableDataImportJobRequest>();
            var marshaller = new StartTableDataImportJobRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("StartTableDataImportJob", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = StartTableDataImportJobResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as StartTableDataImportJobResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void StartTableDataImportJob_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartTableDataImportJob");

            var request = InstantiateClassGenerator.Execute<StartTableDataImportJobRequest>();
            var marshaller = new StartTableDataImportJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartTableDataImportJob", request, internalRequest, service_model);

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
            var response = StartTableDataImportJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void StartTableDataImportJob_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartTableDataImportJob");

            var request = InstantiateClassGenerator.Execute<StartTableDataImportJobRequest>();
            var marshaller = new StartTableDataImportJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartTableDataImportJob", request, internalRequest, service_model);

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
            var response = StartTableDataImportJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void StartTableDataImportJob_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartTableDataImportJob");

            var request = InstantiateClassGenerator.Execute<StartTableDataImportJobRequest>();
            var marshaller = new StartTableDataImportJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartTableDataImportJob", request, internalRequest, service_model);

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
            var response = StartTableDataImportJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void StartTableDataImportJob_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartTableDataImportJob");

            var request = InstantiateClassGenerator.Execute<StartTableDataImportJobRequest>();
            var marshaller = new StartTableDataImportJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartTableDataImportJob", request, internalRequest, service_model);

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
            var response = StartTableDataImportJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void StartTableDataImportJob_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartTableDataImportJob");

            var request = InstantiateClassGenerator.Execute<StartTableDataImportJobRequest>();
            var marshaller = new StartTableDataImportJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartTableDataImportJob", request, internalRequest, service_model);

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
            var response = StartTableDataImportJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Honeycode")]
        public void StartTableDataImportJob_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartTableDataImportJob");

            var request = InstantiateClassGenerator.Execute<StartTableDataImportJobRequest>();
            var marshaller = new StartTableDataImportJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartTableDataImportJob", request, internalRequest, service_model);

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
            var response = StartTableDataImportJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}