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
 * Do not modify this file. This file is generated from the polly-2016-06-10.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Polly;
using Amazon.Polly.Model;
using Amazon.Polly.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class PollyMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("polly");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void DeleteLexiconMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteLexicon");

            var request = InstantiateClassGenerator.Execute<DeleteLexiconRequest>();
            var marshaller = new DeleteLexiconRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteLexicon", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = DeleteLexiconResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DeleteLexiconResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void DeleteLexicon_LexiconNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteLexicon");

            var request = InstantiateClassGenerator.Execute<DeleteLexiconRequest>();
            var marshaller = new DeleteLexiconRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteLexicon", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("LexiconNotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","LexiconNotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteLexiconResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void DeleteLexicon_ServiceFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteLexicon");

            var request = InstantiateClassGenerator.Execute<DeleteLexiconRequest>();
            var marshaller = new DeleteLexiconRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteLexicon", request, internalRequest, service_model);

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
            var response = DeleteLexiconResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void DescribeVoicesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeVoices");

            var request = InstantiateClassGenerator.Execute<DescribeVoicesRequest>();
            var marshaller = new DescribeVoicesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeVoices", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = DescribeVoicesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DescribeVoicesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void DescribeVoices_InvalidNextTokenExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeVoices");

            var request = InstantiateClassGenerator.Execute<DescribeVoicesRequest>();
            var marshaller = new DescribeVoicesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeVoices", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidNextTokenException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidNextTokenException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DescribeVoicesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void DescribeVoices_ServiceFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeVoices");

            var request = InstantiateClassGenerator.Execute<DescribeVoicesRequest>();
            var marshaller = new DescribeVoicesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeVoices", request, internalRequest, service_model);

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
            var response = DescribeVoicesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void GetLexiconMarshallTest()
        {
            var operation = service_model.FindOperation("GetLexicon");

            var request = InstantiateClassGenerator.Execute<GetLexiconRequest>();
            var marshaller = new GetLexiconRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetLexicon", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = GetLexiconResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetLexiconResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void GetLexicon_LexiconNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetLexicon");

            var request = InstantiateClassGenerator.Execute<GetLexiconRequest>();
            var marshaller = new GetLexiconRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetLexicon", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("LexiconNotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","LexiconNotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetLexiconResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void GetLexicon_ServiceFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetLexicon");

            var request = InstantiateClassGenerator.Execute<GetLexiconRequest>();
            var marshaller = new GetLexiconRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetLexicon", request, internalRequest, service_model);

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
            var response = GetLexiconResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void GetSpeechSynthesisTaskMarshallTest()
        {
            var operation = service_model.FindOperation("GetSpeechSynthesisTask");

            var request = InstantiateClassGenerator.Execute<GetSpeechSynthesisTaskRequest>();
            var marshaller = new GetSpeechSynthesisTaskRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetSpeechSynthesisTask", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = GetSpeechSynthesisTaskResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetSpeechSynthesisTaskResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void GetSpeechSynthesisTask_InvalidTaskIdExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetSpeechSynthesisTask");

            var request = InstantiateClassGenerator.Execute<GetSpeechSynthesisTaskRequest>();
            var marshaller = new GetSpeechSynthesisTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetSpeechSynthesisTask", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTaskIdException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidTaskIdException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetSpeechSynthesisTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void GetSpeechSynthesisTask_ServiceFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetSpeechSynthesisTask");

            var request = InstantiateClassGenerator.Execute<GetSpeechSynthesisTaskRequest>();
            var marshaller = new GetSpeechSynthesisTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetSpeechSynthesisTask", request, internalRequest, service_model);

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
            var response = GetSpeechSynthesisTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void GetSpeechSynthesisTask_SynthesisTaskNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetSpeechSynthesisTask");

            var request = InstantiateClassGenerator.Execute<GetSpeechSynthesisTaskRequest>();
            var marshaller = new GetSpeechSynthesisTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetSpeechSynthesisTask", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("SynthesisTaskNotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","SynthesisTaskNotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetSpeechSynthesisTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void ListLexiconsMarshallTest()
        {
            var operation = service_model.FindOperation("ListLexicons");

            var request = InstantiateClassGenerator.Execute<ListLexiconsRequest>();
            var marshaller = new ListLexiconsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListLexicons", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = ListLexiconsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as ListLexiconsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void ListLexicons_InvalidNextTokenExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListLexicons");

            var request = InstantiateClassGenerator.Execute<ListLexiconsRequest>();
            var marshaller = new ListLexiconsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListLexicons", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidNextTokenException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidNextTokenException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListLexiconsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void ListLexicons_ServiceFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListLexicons");

            var request = InstantiateClassGenerator.Execute<ListLexiconsRequest>();
            var marshaller = new ListLexiconsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListLexicons", request, internalRequest, service_model);

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
            var response = ListLexiconsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void ListSpeechSynthesisTasksMarshallTest()
        {
            var operation = service_model.FindOperation("ListSpeechSynthesisTasks");

            var request = InstantiateClassGenerator.Execute<ListSpeechSynthesisTasksRequest>();
            var marshaller = new ListSpeechSynthesisTasksRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListSpeechSynthesisTasks", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = ListSpeechSynthesisTasksResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as ListSpeechSynthesisTasksResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void ListSpeechSynthesisTasks_InvalidNextTokenExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListSpeechSynthesisTasks");

            var request = InstantiateClassGenerator.Execute<ListSpeechSynthesisTasksRequest>();
            var marshaller = new ListSpeechSynthesisTasksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListSpeechSynthesisTasks", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidNextTokenException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidNextTokenException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListSpeechSynthesisTasksResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void ListSpeechSynthesisTasks_ServiceFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListSpeechSynthesisTasks");

            var request = InstantiateClassGenerator.Execute<ListSpeechSynthesisTasksRequest>();
            var marshaller = new ListSpeechSynthesisTasksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListSpeechSynthesisTasks", request, internalRequest, service_model);

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
            var response = ListSpeechSynthesisTasksResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void PutLexiconMarshallTest()
        {
            var operation = service_model.FindOperation("PutLexicon");

            var request = InstantiateClassGenerator.Execute<PutLexiconRequest>();
            var marshaller = new PutLexiconRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutLexicon", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = PutLexiconResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as PutLexiconResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void PutLexicon_InvalidLexiconExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutLexicon");

            var request = InstantiateClassGenerator.Execute<PutLexiconRequest>();
            var marshaller = new PutLexiconRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PutLexicon", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidLexiconException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidLexiconException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PutLexiconResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void PutLexicon_LexiconSizeExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutLexicon");

            var request = InstantiateClassGenerator.Execute<PutLexiconRequest>();
            var marshaller = new PutLexiconRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PutLexicon", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("LexiconSizeExceededException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","LexiconSizeExceededException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PutLexiconResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void PutLexicon_MaxLexemeLengthExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutLexicon");

            var request = InstantiateClassGenerator.Execute<PutLexiconRequest>();
            var marshaller = new PutLexiconRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PutLexicon", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("MaxLexemeLengthExceededException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","MaxLexemeLengthExceededException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PutLexiconResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void PutLexicon_MaxLexiconsNumberExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutLexicon");

            var request = InstantiateClassGenerator.Execute<PutLexiconRequest>();
            var marshaller = new PutLexiconRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PutLexicon", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("MaxLexiconsNumberExceededException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","MaxLexiconsNumberExceededException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PutLexiconResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void PutLexicon_ServiceFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutLexicon");

            var request = InstantiateClassGenerator.Execute<PutLexiconRequest>();
            var marshaller = new PutLexiconRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PutLexicon", request, internalRequest, service_model);

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
            var response = PutLexiconResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void PutLexicon_UnsupportedPlsAlphabetExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutLexicon");

            var request = InstantiateClassGenerator.Execute<PutLexiconRequest>();
            var marshaller = new PutLexiconRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PutLexicon", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedPlsAlphabetException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedPlsAlphabetException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PutLexiconResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void PutLexicon_UnsupportedPlsLanguageExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutLexicon");

            var request = InstantiateClassGenerator.Execute<PutLexiconRequest>();
            var marshaller = new PutLexiconRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PutLexicon", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedPlsLanguageException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedPlsLanguageException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PutLexiconResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void StartSpeechSynthesisTaskMarshallTest()
        {
            var operation = service_model.FindOperation("StartSpeechSynthesisTask");

            var request = InstantiateClassGenerator.Execute<StartSpeechSynthesisTaskRequest>();
            var marshaller = new StartSpeechSynthesisTaskRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("StartSpeechSynthesisTask", request, internalRequest, service_model);

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
            ResponseUnmarshaller unmarshaller = StartSpeechSynthesisTaskResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as StartSpeechSynthesisTaskResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void StartSpeechSynthesisTask_EngineNotSupportedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartSpeechSynthesisTask");

            var request = InstantiateClassGenerator.Execute<StartSpeechSynthesisTaskRequest>();
            var marshaller = new StartSpeechSynthesisTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartSpeechSynthesisTask", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EngineNotSupportedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EngineNotSupportedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StartSpeechSynthesisTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void StartSpeechSynthesisTask_InvalidS3BucketExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartSpeechSynthesisTask");

            var request = InstantiateClassGenerator.Execute<StartSpeechSynthesisTaskRequest>();
            var marshaller = new StartSpeechSynthesisTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartSpeechSynthesisTask", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidS3BucketException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidS3BucketException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StartSpeechSynthesisTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void StartSpeechSynthesisTask_InvalidS3KeyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartSpeechSynthesisTask");

            var request = InstantiateClassGenerator.Execute<StartSpeechSynthesisTaskRequest>();
            var marshaller = new StartSpeechSynthesisTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartSpeechSynthesisTask", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidS3KeyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidS3KeyException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StartSpeechSynthesisTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void StartSpeechSynthesisTask_InvalidSampleRateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartSpeechSynthesisTask");

            var request = InstantiateClassGenerator.Execute<StartSpeechSynthesisTaskRequest>();
            var marshaller = new StartSpeechSynthesisTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartSpeechSynthesisTask", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSampleRateException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidSampleRateException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StartSpeechSynthesisTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void StartSpeechSynthesisTask_InvalidSnsTopicArnExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartSpeechSynthesisTask");

            var request = InstantiateClassGenerator.Execute<StartSpeechSynthesisTaskRequest>();
            var marshaller = new StartSpeechSynthesisTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartSpeechSynthesisTask", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSnsTopicArnException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidSnsTopicArnException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StartSpeechSynthesisTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void StartSpeechSynthesisTask_InvalidSsmlExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartSpeechSynthesisTask");

            var request = InstantiateClassGenerator.Execute<StartSpeechSynthesisTaskRequest>();
            var marshaller = new StartSpeechSynthesisTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartSpeechSynthesisTask", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSsmlException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidSsmlException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StartSpeechSynthesisTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void StartSpeechSynthesisTask_LanguageNotSupportedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartSpeechSynthesisTask");

            var request = InstantiateClassGenerator.Execute<StartSpeechSynthesisTaskRequest>();
            var marshaller = new StartSpeechSynthesisTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartSpeechSynthesisTask", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("LanguageNotSupportedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","LanguageNotSupportedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StartSpeechSynthesisTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void StartSpeechSynthesisTask_LexiconNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartSpeechSynthesisTask");

            var request = InstantiateClassGenerator.Execute<StartSpeechSynthesisTaskRequest>();
            var marshaller = new StartSpeechSynthesisTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartSpeechSynthesisTask", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("LexiconNotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","LexiconNotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StartSpeechSynthesisTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void StartSpeechSynthesisTask_MarksNotSupportedForFormatExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartSpeechSynthesisTask");

            var request = InstantiateClassGenerator.Execute<StartSpeechSynthesisTaskRequest>();
            var marshaller = new StartSpeechSynthesisTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartSpeechSynthesisTask", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("MarksNotSupportedForFormatException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","MarksNotSupportedForFormatException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StartSpeechSynthesisTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void StartSpeechSynthesisTask_ServiceFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartSpeechSynthesisTask");

            var request = InstantiateClassGenerator.Execute<StartSpeechSynthesisTaskRequest>();
            var marshaller = new StartSpeechSynthesisTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartSpeechSynthesisTask", request, internalRequest, service_model);

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
            var response = StartSpeechSynthesisTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void StartSpeechSynthesisTask_SsmlMarksNotSupportedForTextTypeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartSpeechSynthesisTask");

            var request = InstantiateClassGenerator.Execute<StartSpeechSynthesisTaskRequest>();
            var marshaller = new StartSpeechSynthesisTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartSpeechSynthesisTask", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("SsmlMarksNotSupportedForTextTypeException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","SsmlMarksNotSupportedForTextTypeException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StartSpeechSynthesisTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void StartSpeechSynthesisTask_TextLengthExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartSpeechSynthesisTask");

            var request = InstantiateClassGenerator.Execute<StartSpeechSynthesisTaskRequest>();
            var marshaller = new StartSpeechSynthesisTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("StartSpeechSynthesisTask", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TextLengthExceededException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TextLengthExceededException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = StartSpeechSynthesisTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void SynthesizeSpeechMarshallTest()
        {
            var operation = service_model.FindOperation("SynthesizeSpeech");

            var request = InstantiateClassGenerator.Execute<SynthesizeSpeechRequest>();
            var marshaller = new SynthesizeSpeechRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("SynthesizeSpeech", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amzn-RequestCharacters",int.MaxValue.ToString(CultureInfo.InvariantCulture)},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = SynthesizeSpeechResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as SynthesizeSpeechResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void SynthesizeSpeech_EngineNotSupportedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SynthesizeSpeech");

            var request = InstantiateClassGenerator.Execute<SynthesizeSpeechRequest>();
            var marshaller = new SynthesizeSpeechRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("SynthesizeSpeech", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EngineNotSupportedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amzn-RequestCharacters",int.MaxValue.ToString(CultureInfo.InvariantCulture)},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EngineNotSupportedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = SynthesizeSpeechResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void SynthesizeSpeech_InvalidSampleRateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SynthesizeSpeech");

            var request = InstantiateClassGenerator.Execute<SynthesizeSpeechRequest>();
            var marshaller = new SynthesizeSpeechRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("SynthesizeSpeech", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSampleRateException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amzn-RequestCharacters",int.MaxValue.ToString(CultureInfo.InvariantCulture)},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidSampleRateException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = SynthesizeSpeechResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void SynthesizeSpeech_InvalidSsmlExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SynthesizeSpeech");

            var request = InstantiateClassGenerator.Execute<SynthesizeSpeechRequest>();
            var marshaller = new SynthesizeSpeechRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("SynthesizeSpeech", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSsmlException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amzn-RequestCharacters",int.MaxValue.ToString(CultureInfo.InvariantCulture)},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidSsmlException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = SynthesizeSpeechResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void SynthesizeSpeech_LanguageNotSupportedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SynthesizeSpeech");

            var request = InstantiateClassGenerator.Execute<SynthesizeSpeechRequest>();
            var marshaller = new SynthesizeSpeechRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("SynthesizeSpeech", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("LanguageNotSupportedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amzn-RequestCharacters",int.MaxValue.ToString(CultureInfo.InvariantCulture)},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","LanguageNotSupportedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = SynthesizeSpeechResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void SynthesizeSpeech_LexiconNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SynthesizeSpeech");

            var request = InstantiateClassGenerator.Execute<SynthesizeSpeechRequest>();
            var marshaller = new SynthesizeSpeechRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("SynthesizeSpeech", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("LexiconNotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amzn-RequestCharacters",int.MaxValue.ToString(CultureInfo.InvariantCulture)},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","LexiconNotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = SynthesizeSpeechResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void SynthesizeSpeech_MarksNotSupportedForFormatExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SynthesizeSpeech");

            var request = InstantiateClassGenerator.Execute<SynthesizeSpeechRequest>();
            var marshaller = new SynthesizeSpeechRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("SynthesizeSpeech", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("MarksNotSupportedForFormatException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amzn-RequestCharacters",int.MaxValue.ToString(CultureInfo.InvariantCulture)},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","MarksNotSupportedForFormatException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = SynthesizeSpeechResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void SynthesizeSpeech_ServiceFailureExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SynthesizeSpeech");

            var request = InstantiateClassGenerator.Execute<SynthesizeSpeechRequest>();
            var marshaller = new SynthesizeSpeechRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("SynthesizeSpeech", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceFailureException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amzn-RequestCharacters",int.MaxValue.ToString(CultureInfo.InvariantCulture)},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceFailureException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = SynthesizeSpeechResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void SynthesizeSpeech_SsmlMarksNotSupportedForTextTypeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SynthesizeSpeech");

            var request = InstantiateClassGenerator.Execute<SynthesizeSpeechRequest>();
            var marshaller = new SynthesizeSpeechRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("SynthesizeSpeech", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("SsmlMarksNotSupportedForTextTypeException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amzn-RequestCharacters",int.MaxValue.ToString(CultureInfo.InvariantCulture)},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","SsmlMarksNotSupportedForTextTypeException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = SynthesizeSpeechResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Polly")]
        public void SynthesizeSpeech_TextLengthExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SynthesizeSpeech");

            var request = InstantiateClassGenerator.Execute<SynthesizeSpeechRequest>();
            var marshaller = new SynthesizeSpeechRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("SynthesizeSpeech", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TextLengthExceededException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amzn-RequestCharacters",int.MaxValue.ToString(CultureInfo.InvariantCulture)},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TextLengthExceededException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = SynthesizeSpeechResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}