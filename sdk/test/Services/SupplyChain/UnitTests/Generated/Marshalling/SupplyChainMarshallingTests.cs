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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.SupplyChain;
using Amazon.SupplyChain.Model;
using Amazon.SupplyChain.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet.UnitTests.TestTools;

namespace AWSSDK_DotNet.UnitTests.Marshalling
{
    [TestClass]
    public partial class SupplyChainMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("supplychain");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SupplyChain")]
        public void CreateBillOfMaterialsImportJobMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBillOfMaterialsImportJob");

            var request = InstantiateClassGenerator.Execute<CreateBillOfMaterialsImportJobRequest>(operation);
            var marshaller = new CreateBillOfMaterialsImportJobRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateBillOfMaterialsImportJob", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = CreateBillOfMaterialsImportJobResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as CreateBillOfMaterialsImportJobResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SupplyChain")]
        public void CreateBillOfMaterialsImportJob_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBillOfMaterialsImportJob");

            var request = InstantiateClassGenerator.Execute<CreateBillOfMaterialsImportJobRequest>(operation);
            var marshaller = new CreateBillOfMaterialsImportJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateBillOfMaterialsImportJob", request, internalRequest, service_model);

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
            var response = CreateBillOfMaterialsImportJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SupplyChain")]
        public void CreateBillOfMaterialsImportJob_ConflictExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBillOfMaterialsImportJob");

            var request = InstantiateClassGenerator.Execute<CreateBillOfMaterialsImportJobRequest>(operation);
            var marshaller = new CreateBillOfMaterialsImportJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateBillOfMaterialsImportJob", request, internalRequest, service_model);

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
            var response = CreateBillOfMaterialsImportJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SupplyChain")]
        public void CreateBillOfMaterialsImportJob_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBillOfMaterialsImportJob");

            var request = InstantiateClassGenerator.Execute<CreateBillOfMaterialsImportJobRequest>(operation);
            var marshaller = new CreateBillOfMaterialsImportJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateBillOfMaterialsImportJob", request, internalRequest, service_model);

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
            var response = CreateBillOfMaterialsImportJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SupplyChain")]
        public void CreateBillOfMaterialsImportJob_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBillOfMaterialsImportJob");

            var request = InstantiateClassGenerator.Execute<CreateBillOfMaterialsImportJobRequest>(operation);
            var marshaller = new CreateBillOfMaterialsImportJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateBillOfMaterialsImportJob", request, internalRequest, service_model);

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
            var response = CreateBillOfMaterialsImportJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SupplyChain")]
        public void CreateBillOfMaterialsImportJob_ServiceQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBillOfMaterialsImportJob");

            var request = InstantiateClassGenerator.Execute<CreateBillOfMaterialsImportJobRequest>(operation);
            var marshaller = new CreateBillOfMaterialsImportJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateBillOfMaterialsImportJob", request, internalRequest, service_model);

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
            var response = CreateBillOfMaterialsImportJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SupplyChain")]
        public void CreateBillOfMaterialsImportJob_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBillOfMaterialsImportJob");

            var request = InstantiateClassGenerator.Execute<CreateBillOfMaterialsImportJobRequest>(operation);
            var marshaller = new CreateBillOfMaterialsImportJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateBillOfMaterialsImportJob", request, internalRequest, service_model);

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
            var response = CreateBillOfMaterialsImportJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SupplyChain")]
        public void CreateBillOfMaterialsImportJob_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBillOfMaterialsImportJob");

            var request = InstantiateClassGenerator.Execute<CreateBillOfMaterialsImportJobRequest>(operation);
            var marshaller = new CreateBillOfMaterialsImportJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateBillOfMaterialsImportJob", request, internalRequest, service_model);

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
            var response = CreateBillOfMaterialsImportJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SupplyChain")]
        public void GetBillOfMaterialsImportJobMarshallTest()
        {
            var operation = service_model.FindOperation("GetBillOfMaterialsImportJob");

            var request = InstantiateClassGenerator.Execute<GetBillOfMaterialsImportJobRequest>(operation);
            var marshaller = new GetBillOfMaterialsImportJobRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBillOfMaterialsImportJob", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = GetBillOfMaterialsImportJobResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetBillOfMaterialsImportJobResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SupplyChain")]
        public void GetBillOfMaterialsImportJob_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBillOfMaterialsImportJob");

            var request = InstantiateClassGenerator.Execute<GetBillOfMaterialsImportJobRequest>(operation);
            var marshaller = new GetBillOfMaterialsImportJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetBillOfMaterialsImportJob", request, internalRequest, service_model);

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
            var response = GetBillOfMaterialsImportJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SupplyChain")]
        public void GetBillOfMaterialsImportJob_ConflictExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBillOfMaterialsImportJob");

            var request = InstantiateClassGenerator.Execute<GetBillOfMaterialsImportJobRequest>(operation);
            var marshaller = new GetBillOfMaterialsImportJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetBillOfMaterialsImportJob", request, internalRequest, service_model);

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
            var response = GetBillOfMaterialsImportJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SupplyChain")]
        public void GetBillOfMaterialsImportJob_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBillOfMaterialsImportJob");

            var request = InstantiateClassGenerator.Execute<GetBillOfMaterialsImportJobRequest>(operation);
            var marshaller = new GetBillOfMaterialsImportJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetBillOfMaterialsImportJob", request, internalRequest, service_model);

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
            var response = GetBillOfMaterialsImportJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SupplyChain")]
        public void GetBillOfMaterialsImportJob_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBillOfMaterialsImportJob");

            var request = InstantiateClassGenerator.Execute<GetBillOfMaterialsImportJobRequest>(operation);
            var marshaller = new GetBillOfMaterialsImportJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetBillOfMaterialsImportJob", request, internalRequest, service_model);

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
            var response = GetBillOfMaterialsImportJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SupplyChain")]
        public void GetBillOfMaterialsImportJob_ServiceQuotaExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBillOfMaterialsImportJob");

            var request = InstantiateClassGenerator.Execute<GetBillOfMaterialsImportJobRequest>(operation);
            var marshaller = new GetBillOfMaterialsImportJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetBillOfMaterialsImportJob", request, internalRequest, service_model);

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
            var response = GetBillOfMaterialsImportJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SupplyChain")]
        public void GetBillOfMaterialsImportJob_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBillOfMaterialsImportJob");

            var request = InstantiateClassGenerator.Execute<GetBillOfMaterialsImportJobRequest>(operation);
            var marshaller = new GetBillOfMaterialsImportJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetBillOfMaterialsImportJob", request, internalRequest, service_model);

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
            var response = GetBillOfMaterialsImportJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("SupplyChain")]
        public void GetBillOfMaterialsImportJob_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetBillOfMaterialsImportJob");

            var request = InstantiateClassGenerator.Execute<GetBillOfMaterialsImportJobRequest>(operation);
            var marshaller = new GetBillOfMaterialsImportJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetBillOfMaterialsImportJob", request, internalRequest, service_model);

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
            var response = GetBillOfMaterialsImportJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}