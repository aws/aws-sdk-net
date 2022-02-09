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
 * Do not modify this file. This file is generated from the iotevents-data-2018-10-23.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.IoTEventsData;
using Amazon.IoTEventsData.Model;
using Amazon.IoTEventsData.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class IoTEventsDataMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("iotevents-data");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchAcknowledgeAlarmMarshallTest()
        {
            var operation = service_model.FindOperation("BatchAcknowledgeAlarm");

            var request = InstantiateClassGenerator.Execute<BatchAcknowledgeAlarmRequest>();
            var marshaller = new BatchAcknowledgeAlarmRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("BatchAcknowledgeAlarm", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = BatchAcknowledgeAlarmResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as BatchAcknowledgeAlarmResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchAcknowledgeAlarm_InternalFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchAcknowledgeAlarm");

            var request = InstantiateClassGenerator.Execute<BatchAcknowledgeAlarmRequest>();
            var marshaller = new BatchAcknowledgeAlarmRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchAcknowledgeAlarm", request, internalRequest, service_model);

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
            var response = BatchAcknowledgeAlarmResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchAcknowledgeAlarm_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchAcknowledgeAlarm");

            var request = InstantiateClassGenerator.Execute<BatchAcknowledgeAlarmRequest>();
            var marshaller = new BatchAcknowledgeAlarmRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchAcknowledgeAlarm", request, internalRequest, service_model);

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
            var response = BatchAcknowledgeAlarmResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchAcknowledgeAlarm_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchAcknowledgeAlarm");

            var request = InstantiateClassGenerator.Execute<BatchAcknowledgeAlarmRequest>();
            var marshaller = new BatchAcknowledgeAlarmRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchAcknowledgeAlarm", request, internalRequest, service_model);

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
            var response = BatchAcknowledgeAlarmResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchAcknowledgeAlarm_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchAcknowledgeAlarm");

            var request = InstantiateClassGenerator.Execute<BatchAcknowledgeAlarmRequest>();
            var marshaller = new BatchAcknowledgeAlarmRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchAcknowledgeAlarm", request, internalRequest, service_model);

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
            var response = BatchAcknowledgeAlarmResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchDisableAlarmMarshallTest()
        {
            var operation = service_model.FindOperation("BatchDisableAlarm");

            var request = InstantiateClassGenerator.Execute<BatchDisableAlarmRequest>();
            var marshaller = new BatchDisableAlarmRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("BatchDisableAlarm", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = BatchDisableAlarmResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as BatchDisableAlarmResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchDisableAlarm_InternalFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchDisableAlarm");

            var request = InstantiateClassGenerator.Execute<BatchDisableAlarmRequest>();
            var marshaller = new BatchDisableAlarmRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchDisableAlarm", request, internalRequest, service_model);

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
            var response = BatchDisableAlarmResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchDisableAlarm_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchDisableAlarm");

            var request = InstantiateClassGenerator.Execute<BatchDisableAlarmRequest>();
            var marshaller = new BatchDisableAlarmRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchDisableAlarm", request, internalRequest, service_model);

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
            var response = BatchDisableAlarmResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchDisableAlarm_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchDisableAlarm");

            var request = InstantiateClassGenerator.Execute<BatchDisableAlarmRequest>();
            var marshaller = new BatchDisableAlarmRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchDisableAlarm", request, internalRequest, service_model);

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
            var response = BatchDisableAlarmResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchDisableAlarm_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchDisableAlarm");

            var request = InstantiateClassGenerator.Execute<BatchDisableAlarmRequest>();
            var marshaller = new BatchDisableAlarmRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchDisableAlarm", request, internalRequest, service_model);

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
            var response = BatchDisableAlarmResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchEnableAlarmMarshallTest()
        {
            var operation = service_model.FindOperation("BatchEnableAlarm");

            var request = InstantiateClassGenerator.Execute<BatchEnableAlarmRequest>();
            var marshaller = new BatchEnableAlarmRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("BatchEnableAlarm", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = BatchEnableAlarmResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as BatchEnableAlarmResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchEnableAlarm_InternalFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchEnableAlarm");

            var request = InstantiateClassGenerator.Execute<BatchEnableAlarmRequest>();
            var marshaller = new BatchEnableAlarmRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchEnableAlarm", request, internalRequest, service_model);

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
            var response = BatchEnableAlarmResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchEnableAlarm_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchEnableAlarm");

            var request = InstantiateClassGenerator.Execute<BatchEnableAlarmRequest>();
            var marshaller = new BatchEnableAlarmRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchEnableAlarm", request, internalRequest, service_model);

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
            var response = BatchEnableAlarmResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchEnableAlarm_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchEnableAlarm");

            var request = InstantiateClassGenerator.Execute<BatchEnableAlarmRequest>();
            var marshaller = new BatchEnableAlarmRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchEnableAlarm", request, internalRequest, service_model);

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
            var response = BatchEnableAlarmResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchEnableAlarm_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchEnableAlarm");

            var request = InstantiateClassGenerator.Execute<BatchEnableAlarmRequest>();
            var marshaller = new BatchEnableAlarmRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchEnableAlarm", request, internalRequest, service_model);

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
            var response = BatchEnableAlarmResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchPutMessageMarshallTest()
        {
            var operation = service_model.FindOperation("BatchPutMessage");

            var request = InstantiateClassGenerator.Execute<BatchPutMessageRequest>();
            var marshaller = new BatchPutMessageRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("BatchPutMessage", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = BatchPutMessageResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as BatchPutMessageResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchPutMessage_InternalFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchPutMessage");

            var request = InstantiateClassGenerator.Execute<BatchPutMessageRequest>();
            var marshaller = new BatchPutMessageRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchPutMessage", request, internalRequest, service_model);

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
            var response = BatchPutMessageResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchPutMessage_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchPutMessage");

            var request = InstantiateClassGenerator.Execute<BatchPutMessageRequest>();
            var marshaller = new BatchPutMessageRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchPutMessage", request, internalRequest, service_model);

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
            var response = BatchPutMessageResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchPutMessage_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchPutMessage");

            var request = InstantiateClassGenerator.Execute<BatchPutMessageRequest>();
            var marshaller = new BatchPutMessageRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchPutMessage", request, internalRequest, service_model);

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
            var response = BatchPutMessageResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchPutMessage_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchPutMessage");

            var request = InstantiateClassGenerator.Execute<BatchPutMessageRequest>();
            var marshaller = new BatchPutMessageRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchPutMessage", request, internalRequest, service_model);

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
            var response = BatchPutMessageResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchResetAlarmMarshallTest()
        {
            var operation = service_model.FindOperation("BatchResetAlarm");

            var request = InstantiateClassGenerator.Execute<BatchResetAlarmRequest>();
            var marshaller = new BatchResetAlarmRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("BatchResetAlarm", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = BatchResetAlarmResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as BatchResetAlarmResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchResetAlarm_InternalFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchResetAlarm");

            var request = InstantiateClassGenerator.Execute<BatchResetAlarmRequest>();
            var marshaller = new BatchResetAlarmRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchResetAlarm", request, internalRequest, service_model);

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
            var response = BatchResetAlarmResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchResetAlarm_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchResetAlarm");

            var request = InstantiateClassGenerator.Execute<BatchResetAlarmRequest>();
            var marshaller = new BatchResetAlarmRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchResetAlarm", request, internalRequest, service_model);

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
            var response = BatchResetAlarmResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchResetAlarm_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchResetAlarm");

            var request = InstantiateClassGenerator.Execute<BatchResetAlarmRequest>();
            var marshaller = new BatchResetAlarmRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchResetAlarm", request, internalRequest, service_model);

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
            var response = BatchResetAlarmResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchResetAlarm_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchResetAlarm");

            var request = InstantiateClassGenerator.Execute<BatchResetAlarmRequest>();
            var marshaller = new BatchResetAlarmRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchResetAlarm", request, internalRequest, service_model);

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
            var response = BatchResetAlarmResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchSnoozeAlarmMarshallTest()
        {
            var operation = service_model.FindOperation("BatchSnoozeAlarm");

            var request = InstantiateClassGenerator.Execute<BatchSnoozeAlarmRequest>();
            var marshaller = new BatchSnoozeAlarmRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("BatchSnoozeAlarm", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = BatchSnoozeAlarmResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as BatchSnoozeAlarmResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchSnoozeAlarm_InternalFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchSnoozeAlarm");

            var request = InstantiateClassGenerator.Execute<BatchSnoozeAlarmRequest>();
            var marshaller = new BatchSnoozeAlarmRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchSnoozeAlarm", request, internalRequest, service_model);

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
            var response = BatchSnoozeAlarmResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchSnoozeAlarm_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchSnoozeAlarm");

            var request = InstantiateClassGenerator.Execute<BatchSnoozeAlarmRequest>();
            var marshaller = new BatchSnoozeAlarmRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchSnoozeAlarm", request, internalRequest, service_model);

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
            var response = BatchSnoozeAlarmResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchSnoozeAlarm_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchSnoozeAlarm");

            var request = InstantiateClassGenerator.Execute<BatchSnoozeAlarmRequest>();
            var marshaller = new BatchSnoozeAlarmRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchSnoozeAlarm", request, internalRequest, service_model);

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
            var response = BatchSnoozeAlarmResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchSnoozeAlarm_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchSnoozeAlarm");

            var request = InstantiateClassGenerator.Execute<BatchSnoozeAlarmRequest>();
            var marshaller = new BatchSnoozeAlarmRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchSnoozeAlarm", request, internalRequest, service_model);

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
            var response = BatchSnoozeAlarmResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchUpdateDetectorMarshallTest()
        {
            var operation = service_model.FindOperation("BatchUpdateDetector");

            var request = InstantiateClassGenerator.Execute<BatchUpdateDetectorRequest>();
            var marshaller = new BatchUpdateDetectorRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("BatchUpdateDetector", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = BatchUpdateDetectorResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as BatchUpdateDetectorResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchUpdateDetector_InternalFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchUpdateDetector");

            var request = InstantiateClassGenerator.Execute<BatchUpdateDetectorRequest>();
            var marshaller = new BatchUpdateDetectorRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchUpdateDetector", request, internalRequest, service_model);

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
            var response = BatchUpdateDetectorResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchUpdateDetector_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchUpdateDetector");

            var request = InstantiateClassGenerator.Execute<BatchUpdateDetectorRequest>();
            var marshaller = new BatchUpdateDetectorRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchUpdateDetector", request, internalRequest, service_model);

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
            var response = BatchUpdateDetectorResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchUpdateDetector_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchUpdateDetector");

            var request = InstantiateClassGenerator.Execute<BatchUpdateDetectorRequest>();
            var marshaller = new BatchUpdateDetectorRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchUpdateDetector", request, internalRequest, service_model);

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
            var response = BatchUpdateDetectorResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void BatchUpdateDetector_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("BatchUpdateDetector");

            var request = InstantiateClassGenerator.Execute<BatchUpdateDetectorRequest>();
            var marshaller = new BatchUpdateDetectorRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("BatchUpdateDetector", request, internalRequest, service_model);

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
            var response = BatchUpdateDetectorResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void DescribeAlarmMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAlarm");

            var request = InstantiateClassGenerator.Execute<DescribeAlarmRequest>();
            var marshaller = new DescribeAlarmRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeAlarm", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = DescribeAlarmResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DescribeAlarmResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void DescribeAlarm_InternalFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAlarm");

            var request = InstantiateClassGenerator.Execute<DescribeAlarmRequest>();
            var marshaller = new DescribeAlarmRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeAlarm", request, internalRequest, service_model);

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
            var response = DescribeAlarmResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void DescribeAlarm_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAlarm");

            var request = InstantiateClassGenerator.Execute<DescribeAlarmRequest>();
            var marshaller = new DescribeAlarmRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeAlarm", request, internalRequest, service_model);

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
            var response = DescribeAlarmResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void DescribeAlarm_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAlarm");

            var request = InstantiateClassGenerator.Execute<DescribeAlarmRequest>();
            var marshaller = new DescribeAlarmRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeAlarm", request, internalRequest, service_model);

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
            var response = DescribeAlarmResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void DescribeAlarm_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAlarm");

            var request = InstantiateClassGenerator.Execute<DescribeAlarmRequest>();
            var marshaller = new DescribeAlarmRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeAlarm", request, internalRequest, service_model);

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
            var response = DescribeAlarmResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void DescribeAlarm_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAlarm");

            var request = InstantiateClassGenerator.Execute<DescribeAlarmRequest>();
            var marshaller = new DescribeAlarmRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeAlarm", request, internalRequest, service_model);

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
            var response = DescribeAlarmResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void DescribeDetectorMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDetector");

            var request = InstantiateClassGenerator.Execute<DescribeDetectorRequest>();
            var marshaller = new DescribeDetectorRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeDetector", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = DescribeDetectorResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DescribeDetectorResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void DescribeDetector_InternalFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDetector");

            var request = InstantiateClassGenerator.Execute<DescribeDetectorRequest>();
            var marshaller = new DescribeDetectorRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeDetector", request, internalRequest, service_model);

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
            var response = DescribeDetectorResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void DescribeDetector_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDetector");

            var request = InstantiateClassGenerator.Execute<DescribeDetectorRequest>();
            var marshaller = new DescribeDetectorRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeDetector", request, internalRequest, service_model);

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
            var response = DescribeDetectorResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void DescribeDetector_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDetector");

            var request = InstantiateClassGenerator.Execute<DescribeDetectorRequest>();
            var marshaller = new DescribeDetectorRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeDetector", request, internalRequest, service_model);

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
            var response = DescribeDetectorResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void DescribeDetector_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDetector");

            var request = InstantiateClassGenerator.Execute<DescribeDetectorRequest>();
            var marshaller = new DescribeDetectorRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeDetector", request, internalRequest, service_model);

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
            var response = DescribeDetectorResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void DescribeDetector_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDetector");

            var request = InstantiateClassGenerator.Execute<DescribeDetectorRequest>();
            var marshaller = new DescribeDetectorRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeDetector", request, internalRequest, service_model);

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
            var response = DescribeDetectorResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void ListAlarmsMarshallTest()
        {
            var operation = service_model.FindOperation("ListAlarms");

            var request = InstantiateClassGenerator.Execute<ListAlarmsRequest>();
            var marshaller = new ListAlarmsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListAlarms", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = ListAlarmsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as ListAlarmsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void ListAlarms_InternalFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListAlarms");

            var request = InstantiateClassGenerator.Execute<ListAlarmsRequest>();
            var marshaller = new ListAlarmsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListAlarms", request, internalRequest, service_model);

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
            var response = ListAlarmsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void ListAlarms_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListAlarms");

            var request = InstantiateClassGenerator.Execute<ListAlarmsRequest>();
            var marshaller = new ListAlarmsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListAlarms", request, internalRequest, service_model);

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
            var response = ListAlarmsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void ListAlarms_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListAlarms");

            var request = InstantiateClassGenerator.Execute<ListAlarmsRequest>();
            var marshaller = new ListAlarmsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListAlarms", request, internalRequest, service_model);

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
            var response = ListAlarmsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void ListAlarms_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListAlarms");

            var request = InstantiateClassGenerator.Execute<ListAlarmsRequest>();
            var marshaller = new ListAlarmsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListAlarms", request, internalRequest, service_model);

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
            var response = ListAlarmsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void ListAlarms_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListAlarms");

            var request = InstantiateClassGenerator.Execute<ListAlarmsRequest>();
            var marshaller = new ListAlarmsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListAlarms", request, internalRequest, service_model);

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
            var response = ListAlarmsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void ListDetectorsMarshallTest()
        {
            var operation = service_model.FindOperation("ListDetectors");

            var request = InstantiateClassGenerator.Execute<ListDetectorsRequest>();
            var marshaller = new ListDetectorsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListDetectors", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = ListDetectorsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as ListDetectorsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void ListDetectors_InternalFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListDetectors");

            var request = InstantiateClassGenerator.Execute<ListDetectorsRequest>();
            var marshaller = new ListDetectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListDetectors", request, internalRequest, service_model);

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
            var response = ListDetectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void ListDetectors_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListDetectors");

            var request = InstantiateClassGenerator.Execute<ListDetectorsRequest>();
            var marshaller = new ListDetectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListDetectors", request, internalRequest, service_model);

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
            var response = ListDetectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void ListDetectors_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListDetectors");

            var request = InstantiateClassGenerator.Execute<ListDetectorsRequest>();
            var marshaller = new ListDetectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListDetectors", request, internalRequest, service_model);

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
            var response = ListDetectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void ListDetectors_ServiceUnavailableExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListDetectors");

            var request = InstantiateClassGenerator.Execute<ListDetectorsRequest>();
            var marshaller = new ListDetectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListDetectors", request, internalRequest, service_model);

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
            var response = ListDetectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("IoTEventsData")]
        public void ListDetectors_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListDetectors");

            var request = InstantiateClassGenerator.Execute<ListDetectorsRequest>();
            var marshaller = new ListDetectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListDetectors", request, internalRequest, service_model);

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
            var response = ListDetectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}