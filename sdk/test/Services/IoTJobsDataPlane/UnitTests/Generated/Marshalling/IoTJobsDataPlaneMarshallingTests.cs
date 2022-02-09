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
 * Do not modify this file. This file is generated from the iot-jobs-data-2017-09-29.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.IoTJobsDataPlane;
using Amazon.IoTJobsDataPlane.Model;
using Amazon.IoTJobsDataPlane.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class IoTJobsDataPlaneMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("iot-jobs-data");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTJobsDataPlane")]
        public void DescribeJobExecutionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeJobExecution");

            var request = InstantiateClassGenerator.Execute<DescribeJobExecutionRequest>();
            var marshaller = new DescribeJobExecutionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeJobExecution", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = DescribeJobExecutionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DescribeJobExecutionResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTJobsDataPlane")]
        public void DescribeJobExecution_CertificateValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeJobExecution");

            var request = InstantiateClassGenerator.Execute<DescribeJobExecutionRequest>();
            var marshaller = new DescribeJobExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeJobExecution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CertificateValidationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CertificateValidationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DescribeJobExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTJobsDataPlane")]
        public void DescribeJobExecution_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeJobExecution");

            var request = InstantiateClassGenerator.Execute<DescribeJobExecutionRequest>();
            var marshaller = new DescribeJobExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeJobExecution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DescribeJobExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTJobsDataPlane")]
        public void DescribeJobExecution_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeJobExecution");

            var request = InstantiateClassGenerator.Execute<DescribeJobExecutionRequest>();
            var marshaller = new DescribeJobExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeJobExecution", request, internalRequest, service_model);

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
            var response = DescribeJobExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTJobsDataPlane")]
        public void DescribeJobExecution_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeJobExecution");

            var request = InstantiateClassGenerator.Execute<DescribeJobExecutionRequest>();
            var marshaller = new DescribeJobExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeJobExecution", request, internalRequest, service_model);

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
            var response = DescribeJobExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTJobsDataPlane")]
        public void DescribeJobExecution_TerminalStateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeJobExecution");

            var request = InstantiateClassGenerator.Execute<DescribeJobExecutionRequest>();
            var marshaller = new DescribeJobExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeJobExecution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TerminalStateException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TerminalStateException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DescribeJobExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTJobsDataPlane")]
        public void DescribeJobExecution_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeJobExecution");

            var request = InstantiateClassGenerator.Execute<DescribeJobExecutionRequest>();
            var marshaller = new DescribeJobExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeJobExecution", request, internalRequest, service_model);

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
            var response = DescribeJobExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTJobsDataPlane")]
        public void GetPendingJobExecutionsMarshallTest()
        {
            var operation = service_model.FindOperation("GetPendingJobExecutions");

            var request = InstantiateClassGenerator.Execute<GetPendingJobExecutionsRequest>();
            var marshaller = new GetPendingJobExecutionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetPendingJobExecutions", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = GetPendingJobExecutionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetPendingJobExecutionsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTJobsDataPlane")]
        public void GetPendingJobExecutions_CertificateValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetPendingJobExecutions");

            var request = InstantiateClassGenerator.Execute<GetPendingJobExecutionsRequest>();
            var marshaller = new GetPendingJobExecutionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetPendingJobExecutions", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CertificateValidationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CertificateValidationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetPendingJobExecutionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTJobsDataPlane")]
        public void GetPendingJobExecutions_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetPendingJobExecutions");

            var request = InstantiateClassGenerator.Execute<GetPendingJobExecutionsRequest>();
            var marshaller = new GetPendingJobExecutionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetPendingJobExecutions", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetPendingJobExecutionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTJobsDataPlane")]
        public void GetPendingJobExecutions_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetPendingJobExecutions");

            var request = InstantiateClassGenerator.Execute<GetPendingJobExecutionsRequest>();
            var marshaller = new GetPendingJobExecutionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetPendingJobExecutions", request, internalRequest, service_model);

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
            var response = GetPendingJobExecutionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTJobsDataPlane")]
        public void GetPendingJobExecutions_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetPendingJobExecutions");

            var request = InstantiateClassGenerator.Execute<GetPendingJobExecutionsRequest>();
            var marshaller = new GetPendingJobExecutionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetPendingJobExecutions", request, internalRequest, service_model);

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
            var response = GetPendingJobExecutionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTJobsDataPlane")]
        public void GetPendingJobExecutions_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetPendingJobExecutions");

            var request = InstantiateClassGenerator.Execute<GetPendingJobExecutionsRequest>();
            var marshaller = new GetPendingJobExecutionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetPendingJobExecutions", request, internalRequest, service_model);

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
            var response = GetPendingJobExecutionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTJobsDataPlane")]
        public void StartNextPendingJobExecutionMarshallTest()
        {
            var operation = service_model.FindOperation("StartNextPendingJobExecution");

            var request = InstantiateClassGenerator.Execute<StartNextPendingJobExecutionRequest>();
            var marshaller = new StartNextPendingJobExecutionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("StartNextPendingJobExecution", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = StartNextPendingJobExecutionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as StartNextPendingJobExecutionResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTJobsDataPlane")]
        public void StartNextPendingJobExecution_CertificateValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartNextPendingJobExecution");

            var request = InstantiateClassGenerator.Execute<StartNextPendingJobExecutionRequest>();
            var marshaller = new StartNextPendingJobExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartNextPendingJobExecution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CertificateValidationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CertificateValidationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StartNextPendingJobExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTJobsDataPlane")]
        public void StartNextPendingJobExecution_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartNextPendingJobExecution");

            var request = InstantiateClassGenerator.Execute<StartNextPendingJobExecutionRequest>();
            var marshaller = new StartNextPendingJobExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartNextPendingJobExecution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StartNextPendingJobExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTJobsDataPlane")]
        public void StartNextPendingJobExecution_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartNextPendingJobExecution");

            var request = InstantiateClassGenerator.Execute<StartNextPendingJobExecutionRequest>();
            var marshaller = new StartNextPendingJobExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartNextPendingJobExecution", request, internalRequest, service_model);

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
            var response = StartNextPendingJobExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTJobsDataPlane")]
        public void StartNextPendingJobExecution_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartNextPendingJobExecution");

            var request = InstantiateClassGenerator.Execute<StartNextPendingJobExecutionRequest>();
            var marshaller = new StartNextPendingJobExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartNextPendingJobExecution", request, internalRequest, service_model);

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
            var response = StartNextPendingJobExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTJobsDataPlane")]
        public void StartNextPendingJobExecution_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartNextPendingJobExecution");

            var request = InstantiateClassGenerator.Execute<StartNextPendingJobExecutionRequest>();
            var marshaller = new StartNextPendingJobExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartNextPendingJobExecution", request, internalRequest, service_model);

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
            var response = StartNextPendingJobExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTJobsDataPlane")]
        public void UpdateJobExecutionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateJobExecution");

            var request = InstantiateClassGenerator.Execute<UpdateJobExecutionRequest>();
            var marshaller = new UpdateJobExecutionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateJobExecution", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = UpdateJobExecutionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as UpdateJobExecutionResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTJobsDataPlane")]
        public void UpdateJobExecution_CertificateValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateJobExecution");

            var request = InstantiateClassGenerator.Execute<UpdateJobExecutionRequest>();
            var marshaller = new UpdateJobExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateJobExecution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CertificateValidationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CertificateValidationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateJobExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTJobsDataPlane")]
        public void UpdateJobExecution_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateJobExecution");

            var request = InstantiateClassGenerator.Execute<UpdateJobExecutionRequest>();
            var marshaller = new UpdateJobExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateJobExecution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateJobExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTJobsDataPlane")]
        public void UpdateJobExecution_InvalidStateTransitionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateJobExecution");

            var request = InstantiateClassGenerator.Execute<UpdateJobExecutionRequest>();
            var marshaller = new UpdateJobExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateJobExecution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidStateTransitionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidStateTransitionException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateJobExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTJobsDataPlane")]
        public void UpdateJobExecution_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateJobExecution");

            var request = InstantiateClassGenerator.Execute<UpdateJobExecutionRequest>();
            var marshaller = new UpdateJobExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateJobExecution", request, internalRequest, service_model);

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
            var response = UpdateJobExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTJobsDataPlane")]
        public void UpdateJobExecution_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateJobExecution");

            var request = InstantiateClassGenerator.Execute<UpdateJobExecutionRequest>();
            var marshaller = new UpdateJobExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateJobExecution", request, internalRequest, service_model);

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
            var response = UpdateJobExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTJobsDataPlane")]
        public void UpdateJobExecution_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateJobExecution");

            var request = InstantiateClassGenerator.Execute<UpdateJobExecutionRequest>();
            var marshaller = new UpdateJobExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateJobExecution", request, internalRequest, service_model);

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
            var response = UpdateJobExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}