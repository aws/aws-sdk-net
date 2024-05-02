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
 * Do not modify this file. This file is generated from the chatbot-2017-10-11.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Chatbot;
using Amazon.Chatbot.Model;
using Amazon.Chatbot.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet.UnitTests.TestTools;

namespace AWSSDK_DotNet.UnitTests.Marshalling
{
    [TestClass]
    public partial class ChatbotMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("chatbot");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void CreateChimeWebhookConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("CreateChimeWebhookConfiguration");

            var request = InstantiateClassGenerator.Execute<CreateChimeWebhookConfigurationRequest>(operation);
            var marshaller = new CreateChimeWebhookConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateChimeWebhookConfiguration", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateChimeWebhookConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as CreateChimeWebhookConfigurationResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void CreateChimeWebhookConfiguration_ConflictExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateChimeWebhookConfiguration");

            var request = InstantiateClassGenerator.Execute<CreateChimeWebhookConfigurationRequest>(operation);
            var marshaller = new CreateChimeWebhookConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateChimeWebhookConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ConflictException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateChimeWebhookConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void CreateChimeWebhookConfiguration_CreateChimeWebhookConfigurationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateChimeWebhookConfiguration");

            var request = InstantiateClassGenerator.Execute<CreateChimeWebhookConfigurationRequest>(operation);
            var marshaller = new CreateChimeWebhookConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateChimeWebhookConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CreateChimeWebhookConfigurationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"CreateChimeWebhookConfigurationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateChimeWebhookConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void CreateChimeWebhookConfiguration_InvalidParameterExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateChimeWebhookConfiguration");

            var request = InstantiateClassGenerator.Execute<CreateChimeWebhookConfigurationRequest>(operation);
            var marshaller = new CreateChimeWebhookConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateChimeWebhookConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidParameterException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateChimeWebhookConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void CreateChimeWebhookConfiguration_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateChimeWebhookConfiguration");

            var request = InstantiateClassGenerator.Execute<CreateChimeWebhookConfigurationRequest>(operation);
            var marshaller = new CreateChimeWebhookConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateChimeWebhookConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateChimeWebhookConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void CreateChimeWebhookConfiguration_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateChimeWebhookConfiguration");

            var request = InstantiateClassGenerator.Execute<CreateChimeWebhookConfigurationRequest>(operation);
            var marshaller = new CreateChimeWebhookConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateChimeWebhookConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"LimitExceededException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateChimeWebhookConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void CreateMicrosoftTeamsChannelConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMicrosoftTeamsChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<CreateMicrosoftTeamsChannelConfigurationRequest>(operation);
            var marshaller = new CreateMicrosoftTeamsChannelConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateMicrosoftTeamsChannelConfiguration", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as CreateMicrosoftTeamsChannelConfigurationResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void CreateMicrosoftTeamsChannelConfiguration_ConflictExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMicrosoftTeamsChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<CreateMicrosoftTeamsChannelConfigurationRequest>(operation);
            var marshaller = new CreateMicrosoftTeamsChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateMicrosoftTeamsChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ConflictException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void CreateMicrosoftTeamsChannelConfiguration_CreateTeamsChannelConfigurationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMicrosoftTeamsChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<CreateMicrosoftTeamsChannelConfigurationRequest>(operation);
            var marshaller = new CreateMicrosoftTeamsChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateMicrosoftTeamsChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CreateTeamsChannelConfigurationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"CreateTeamsChannelConfigurationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void CreateMicrosoftTeamsChannelConfiguration_InvalidParameterExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMicrosoftTeamsChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<CreateMicrosoftTeamsChannelConfigurationRequest>(operation);
            var marshaller = new CreateMicrosoftTeamsChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateMicrosoftTeamsChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidParameterException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void CreateMicrosoftTeamsChannelConfiguration_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMicrosoftTeamsChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<CreateMicrosoftTeamsChannelConfigurationRequest>(operation);
            var marshaller = new CreateMicrosoftTeamsChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateMicrosoftTeamsChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void CreateMicrosoftTeamsChannelConfiguration_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMicrosoftTeamsChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<CreateMicrosoftTeamsChannelConfigurationRequest>(operation);
            var marshaller = new CreateMicrosoftTeamsChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateMicrosoftTeamsChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"LimitExceededException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void CreateSlackChannelConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSlackChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<CreateSlackChannelConfigurationRequest>(operation);
            var marshaller = new CreateSlackChannelConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateSlackChannelConfiguration", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateSlackChannelConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as CreateSlackChannelConfigurationResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void CreateSlackChannelConfiguration_ConflictExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSlackChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<CreateSlackChannelConfigurationRequest>(operation);
            var marshaller = new CreateSlackChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateSlackChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ConflictException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateSlackChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void CreateSlackChannelConfiguration_CreateSlackChannelConfigurationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSlackChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<CreateSlackChannelConfigurationRequest>(operation);
            var marshaller = new CreateSlackChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateSlackChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CreateSlackChannelConfigurationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"CreateSlackChannelConfigurationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateSlackChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void CreateSlackChannelConfiguration_InvalidParameterExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSlackChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<CreateSlackChannelConfigurationRequest>(operation);
            var marshaller = new CreateSlackChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateSlackChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidParameterException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateSlackChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void CreateSlackChannelConfiguration_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSlackChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<CreateSlackChannelConfigurationRequest>(operation);
            var marshaller = new CreateSlackChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateSlackChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateSlackChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void CreateSlackChannelConfiguration_LimitExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSlackChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<CreateSlackChannelConfigurationRequest>(operation);
            var marshaller = new CreateSlackChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateSlackChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("LimitExceededException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"LimitExceededException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateSlackChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteChimeWebhookConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteChimeWebhookConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteChimeWebhookConfigurationRequest>(operation);
            var marshaller = new DeleteChimeWebhookConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteChimeWebhookConfiguration", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DeleteChimeWebhookConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DeleteChimeWebhookConfigurationResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteChimeWebhookConfiguration_DeleteChimeWebhookConfigurationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteChimeWebhookConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteChimeWebhookConfigurationRequest>(operation);
            var marshaller = new DeleteChimeWebhookConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteChimeWebhookConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("DeleteChimeWebhookConfigurationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"DeleteChimeWebhookConfigurationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteChimeWebhookConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteChimeWebhookConfiguration_InvalidParameterExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteChimeWebhookConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteChimeWebhookConfigurationRequest>(operation);
            var marshaller = new DeleteChimeWebhookConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteChimeWebhookConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidParameterException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteChimeWebhookConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteChimeWebhookConfiguration_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteChimeWebhookConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteChimeWebhookConfigurationRequest>(operation);
            var marshaller = new DeleteChimeWebhookConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteChimeWebhookConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteChimeWebhookConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteChimeWebhookConfiguration_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteChimeWebhookConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteChimeWebhookConfigurationRequest>(operation);
            var marshaller = new DeleteChimeWebhookConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteChimeWebhookConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ResourceNotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteChimeWebhookConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteMicrosoftTeamsChannelConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMicrosoftTeamsChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteMicrosoftTeamsChannelConfigurationRequest>(operation);
            var marshaller = new DeleteMicrosoftTeamsChannelConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteMicrosoftTeamsChannelConfiguration", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DeleteMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DeleteMicrosoftTeamsChannelConfigurationResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteMicrosoftTeamsChannelConfiguration_DeleteTeamsChannelConfigurationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMicrosoftTeamsChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteMicrosoftTeamsChannelConfigurationRequest>(operation);
            var marshaller = new DeleteMicrosoftTeamsChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteMicrosoftTeamsChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("DeleteTeamsChannelConfigurationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"DeleteTeamsChannelConfigurationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteMicrosoftTeamsChannelConfiguration_InvalidParameterExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMicrosoftTeamsChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteMicrosoftTeamsChannelConfigurationRequest>(operation);
            var marshaller = new DeleteMicrosoftTeamsChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteMicrosoftTeamsChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidParameterException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteMicrosoftTeamsChannelConfiguration_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMicrosoftTeamsChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteMicrosoftTeamsChannelConfigurationRequest>(operation);
            var marshaller = new DeleteMicrosoftTeamsChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteMicrosoftTeamsChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteMicrosoftTeamsChannelConfiguration_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMicrosoftTeamsChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteMicrosoftTeamsChannelConfigurationRequest>(operation);
            var marshaller = new DeleteMicrosoftTeamsChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteMicrosoftTeamsChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ResourceNotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteMicrosoftTeamsConfiguredTeamMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMicrosoftTeamsConfiguredTeam");

            var request = InstantiateClassGenerator.Execute<DeleteMicrosoftTeamsConfiguredTeamRequest>(operation);
            var marshaller = new DeleteMicrosoftTeamsConfiguredTeamRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteMicrosoftTeamsConfiguredTeam", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DeleteMicrosoftTeamsConfiguredTeamResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DeleteMicrosoftTeamsConfiguredTeamResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteMicrosoftTeamsConfiguredTeam_DeleteTeamsConfiguredTeamExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMicrosoftTeamsConfiguredTeam");

            var request = InstantiateClassGenerator.Execute<DeleteMicrosoftTeamsConfiguredTeamRequest>(operation);
            var marshaller = new DeleteMicrosoftTeamsConfiguredTeamRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteMicrosoftTeamsConfiguredTeam", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("DeleteTeamsConfiguredTeamException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"DeleteTeamsConfiguredTeamException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteMicrosoftTeamsConfiguredTeamResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteMicrosoftTeamsConfiguredTeam_InvalidParameterExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMicrosoftTeamsConfiguredTeam");

            var request = InstantiateClassGenerator.Execute<DeleteMicrosoftTeamsConfiguredTeamRequest>(operation);
            var marshaller = new DeleteMicrosoftTeamsConfiguredTeamRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteMicrosoftTeamsConfiguredTeam", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidParameterException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteMicrosoftTeamsConfiguredTeamResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteMicrosoftTeamsUserIdentityMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMicrosoftTeamsUserIdentity");

            var request = InstantiateClassGenerator.Execute<DeleteMicrosoftTeamsUserIdentityRequest>(operation);
            var marshaller = new DeleteMicrosoftTeamsUserIdentityRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteMicrosoftTeamsUserIdentity", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DeleteMicrosoftTeamsUserIdentityResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DeleteMicrosoftTeamsUserIdentityResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteMicrosoftTeamsUserIdentity_DeleteMicrosoftTeamsUserIdentityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMicrosoftTeamsUserIdentity");

            var request = InstantiateClassGenerator.Execute<DeleteMicrosoftTeamsUserIdentityRequest>(operation);
            var marshaller = new DeleteMicrosoftTeamsUserIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteMicrosoftTeamsUserIdentity", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("DeleteMicrosoftTeamsUserIdentityException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"DeleteMicrosoftTeamsUserIdentityException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteMicrosoftTeamsUserIdentityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteMicrosoftTeamsUserIdentity_InvalidParameterExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMicrosoftTeamsUserIdentity");

            var request = InstantiateClassGenerator.Execute<DeleteMicrosoftTeamsUserIdentityRequest>(operation);
            var marshaller = new DeleteMicrosoftTeamsUserIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteMicrosoftTeamsUserIdentity", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidParameterException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteMicrosoftTeamsUserIdentityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteMicrosoftTeamsUserIdentity_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMicrosoftTeamsUserIdentity");

            var request = InstantiateClassGenerator.Execute<DeleteMicrosoftTeamsUserIdentityRequest>(operation);
            var marshaller = new DeleteMicrosoftTeamsUserIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteMicrosoftTeamsUserIdentity", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ResourceNotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteMicrosoftTeamsUserIdentityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteSlackChannelConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSlackChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteSlackChannelConfigurationRequest>(operation);
            var marshaller = new DeleteSlackChannelConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteSlackChannelConfiguration", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DeleteSlackChannelConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DeleteSlackChannelConfigurationResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteSlackChannelConfiguration_DeleteSlackChannelConfigurationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSlackChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteSlackChannelConfigurationRequest>(operation);
            var marshaller = new DeleteSlackChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteSlackChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("DeleteSlackChannelConfigurationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"DeleteSlackChannelConfigurationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteSlackChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteSlackChannelConfiguration_InvalidParameterExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSlackChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteSlackChannelConfigurationRequest>(operation);
            var marshaller = new DeleteSlackChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteSlackChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidParameterException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteSlackChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteSlackChannelConfiguration_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSlackChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteSlackChannelConfigurationRequest>(operation);
            var marshaller = new DeleteSlackChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteSlackChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteSlackChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteSlackChannelConfiguration_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSlackChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteSlackChannelConfigurationRequest>(operation);
            var marshaller = new DeleteSlackChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteSlackChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ResourceNotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteSlackChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteSlackUserIdentityMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSlackUserIdentity");

            var request = InstantiateClassGenerator.Execute<DeleteSlackUserIdentityRequest>(operation);
            var marshaller = new DeleteSlackUserIdentityRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteSlackUserIdentity", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DeleteSlackUserIdentityResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DeleteSlackUserIdentityResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteSlackUserIdentity_DeleteSlackUserIdentityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSlackUserIdentity");

            var request = InstantiateClassGenerator.Execute<DeleteSlackUserIdentityRequest>(operation);
            var marshaller = new DeleteSlackUserIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteSlackUserIdentity", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("DeleteSlackUserIdentityException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"DeleteSlackUserIdentityException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteSlackUserIdentityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteSlackUserIdentity_InvalidParameterExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSlackUserIdentity");

            var request = InstantiateClassGenerator.Execute<DeleteSlackUserIdentityRequest>(operation);
            var marshaller = new DeleteSlackUserIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteSlackUserIdentity", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidParameterException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteSlackUserIdentityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteSlackUserIdentity_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSlackUserIdentity");

            var request = InstantiateClassGenerator.Execute<DeleteSlackUserIdentityRequest>(operation);
            var marshaller = new DeleteSlackUserIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteSlackUserIdentity", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ResourceNotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteSlackUserIdentityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteSlackWorkspaceAuthorizationMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSlackWorkspaceAuthorization");

            var request = InstantiateClassGenerator.Execute<DeleteSlackWorkspaceAuthorizationRequest>(operation);
            var marshaller = new DeleteSlackWorkspaceAuthorizationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteSlackWorkspaceAuthorization", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DeleteSlackWorkspaceAuthorizationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DeleteSlackWorkspaceAuthorizationResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteSlackWorkspaceAuthorization_DeleteSlackWorkspaceAuthorizationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSlackWorkspaceAuthorization");

            var request = InstantiateClassGenerator.Execute<DeleteSlackWorkspaceAuthorizationRequest>(operation);
            var marshaller = new DeleteSlackWorkspaceAuthorizationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteSlackWorkspaceAuthorization", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("DeleteSlackWorkspaceAuthorizationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"DeleteSlackWorkspaceAuthorizationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteSlackWorkspaceAuthorizationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DeleteSlackWorkspaceAuthorization_InvalidParameterExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSlackWorkspaceAuthorization");

            var request = InstantiateClassGenerator.Execute<DeleteSlackWorkspaceAuthorizationRequest>(operation);
            var marshaller = new DeleteSlackWorkspaceAuthorizationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteSlackWorkspaceAuthorization", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidParameterException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteSlackWorkspaceAuthorizationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DescribeChimeWebhookConfigurationsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeChimeWebhookConfigurations");

            var request = InstantiateClassGenerator.Execute<DescribeChimeWebhookConfigurationsRequest>(operation);
            var marshaller = new DescribeChimeWebhookConfigurationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeChimeWebhookConfigurations", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeChimeWebhookConfigurationsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DescribeChimeWebhookConfigurationsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DescribeChimeWebhookConfigurations_DescribeChimeWebhookConfigurationsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeChimeWebhookConfigurations");

            var request = InstantiateClassGenerator.Execute<DescribeChimeWebhookConfigurationsRequest>(operation);
            var marshaller = new DescribeChimeWebhookConfigurationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeChimeWebhookConfigurations", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("DescribeChimeWebhookConfigurationsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"DescribeChimeWebhookConfigurationsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DescribeChimeWebhookConfigurationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DescribeChimeWebhookConfigurations_InvalidParameterExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeChimeWebhookConfigurations");

            var request = InstantiateClassGenerator.Execute<DescribeChimeWebhookConfigurationsRequest>(operation);
            var marshaller = new DescribeChimeWebhookConfigurationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeChimeWebhookConfigurations", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidParameterException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DescribeChimeWebhookConfigurationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DescribeChimeWebhookConfigurations_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeChimeWebhookConfigurations");

            var request = InstantiateClassGenerator.Execute<DescribeChimeWebhookConfigurationsRequest>(operation);
            var marshaller = new DescribeChimeWebhookConfigurationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeChimeWebhookConfigurations", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DescribeChimeWebhookConfigurationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DescribeSlackChannelConfigurationsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSlackChannelConfigurations");

            var request = InstantiateClassGenerator.Execute<DescribeSlackChannelConfigurationsRequest>(operation);
            var marshaller = new DescribeSlackChannelConfigurationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeSlackChannelConfigurations", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeSlackChannelConfigurationsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DescribeSlackChannelConfigurationsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DescribeSlackChannelConfigurations_DescribeSlackChannelConfigurationsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSlackChannelConfigurations");

            var request = InstantiateClassGenerator.Execute<DescribeSlackChannelConfigurationsRequest>(operation);
            var marshaller = new DescribeSlackChannelConfigurationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeSlackChannelConfigurations", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("DescribeSlackChannelConfigurationsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"DescribeSlackChannelConfigurationsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DescribeSlackChannelConfigurationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DescribeSlackChannelConfigurations_InvalidParameterExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSlackChannelConfigurations");

            var request = InstantiateClassGenerator.Execute<DescribeSlackChannelConfigurationsRequest>(operation);
            var marshaller = new DescribeSlackChannelConfigurationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeSlackChannelConfigurations", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidParameterException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DescribeSlackChannelConfigurationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DescribeSlackChannelConfigurations_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSlackChannelConfigurations");

            var request = InstantiateClassGenerator.Execute<DescribeSlackChannelConfigurationsRequest>(operation);
            var marshaller = new DescribeSlackChannelConfigurationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeSlackChannelConfigurations", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DescribeSlackChannelConfigurationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DescribeSlackUserIdentitiesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSlackUserIdentities");

            var request = InstantiateClassGenerator.Execute<DescribeSlackUserIdentitiesRequest>(operation);
            var marshaller = new DescribeSlackUserIdentitiesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeSlackUserIdentities", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeSlackUserIdentitiesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DescribeSlackUserIdentitiesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DescribeSlackUserIdentities_DescribeSlackUserIdentitiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSlackUserIdentities");

            var request = InstantiateClassGenerator.Execute<DescribeSlackUserIdentitiesRequest>(operation);
            var marshaller = new DescribeSlackUserIdentitiesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeSlackUserIdentities", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("DescribeSlackUserIdentitiesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"DescribeSlackUserIdentitiesException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DescribeSlackUserIdentitiesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DescribeSlackUserIdentities_InvalidParameterExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSlackUserIdentities");

            var request = InstantiateClassGenerator.Execute<DescribeSlackUserIdentitiesRequest>(operation);
            var marshaller = new DescribeSlackUserIdentitiesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeSlackUserIdentities", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidParameterException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DescribeSlackUserIdentitiesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DescribeSlackUserIdentities_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSlackUserIdentities");

            var request = InstantiateClassGenerator.Execute<DescribeSlackUserIdentitiesRequest>(operation);
            var marshaller = new DescribeSlackUserIdentitiesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeSlackUserIdentities", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DescribeSlackUserIdentitiesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DescribeSlackWorkspacesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSlackWorkspaces");

            var request = InstantiateClassGenerator.Execute<DescribeSlackWorkspacesRequest>(operation);
            var marshaller = new DescribeSlackWorkspacesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeSlackWorkspaces", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeSlackWorkspacesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DescribeSlackWorkspacesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DescribeSlackWorkspaces_DescribeSlackWorkspacesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSlackWorkspaces");

            var request = InstantiateClassGenerator.Execute<DescribeSlackWorkspacesRequest>(operation);
            var marshaller = new DescribeSlackWorkspacesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeSlackWorkspaces", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("DescribeSlackWorkspacesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"DescribeSlackWorkspacesException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DescribeSlackWorkspacesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DescribeSlackWorkspaces_InvalidParameterExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSlackWorkspaces");

            var request = InstantiateClassGenerator.Execute<DescribeSlackWorkspacesRequest>(operation);
            var marshaller = new DescribeSlackWorkspacesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeSlackWorkspaces", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidParameterException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DescribeSlackWorkspacesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void DescribeSlackWorkspaces_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSlackWorkspaces");

            var request = InstantiateClassGenerator.Execute<DescribeSlackWorkspacesRequest>(operation);
            var marshaller = new DescribeSlackWorkspacesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeSlackWorkspaces", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DescribeSlackWorkspacesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void GetAccountPreferencesMarshallTest()
        {
            var operation = service_model.FindOperation("GetAccountPreferences");

            var request = InstantiateClassGenerator.Execute<GetAccountPreferencesRequest>(operation);
            var marshaller = new GetAccountPreferencesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetAccountPreferences", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetAccountPreferencesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetAccountPreferencesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void GetAccountPreferences_GetAccountPreferencesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetAccountPreferences");

            var request = InstantiateClassGenerator.Execute<GetAccountPreferencesRequest>(operation);
            var marshaller = new GetAccountPreferencesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetAccountPreferences", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GetAccountPreferencesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"GetAccountPreferencesException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetAccountPreferencesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void GetAccountPreferences_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetAccountPreferences");

            var request = InstantiateClassGenerator.Execute<GetAccountPreferencesRequest>(operation);
            var marshaller = new GetAccountPreferencesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetAccountPreferences", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetAccountPreferencesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void GetMicrosoftTeamsChannelConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("GetMicrosoftTeamsChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<GetMicrosoftTeamsChannelConfigurationRequest>(operation);
            var marshaller = new GetMicrosoftTeamsChannelConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetMicrosoftTeamsChannelConfiguration", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetMicrosoftTeamsChannelConfigurationResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void GetMicrosoftTeamsChannelConfiguration_GetTeamsChannelConfigurationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetMicrosoftTeamsChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<GetMicrosoftTeamsChannelConfigurationRequest>(operation);
            var marshaller = new GetMicrosoftTeamsChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetMicrosoftTeamsChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("GetTeamsChannelConfigurationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"GetTeamsChannelConfigurationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void GetMicrosoftTeamsChannelConfiguration_InvalidParameterExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetMicrosoftTeamsChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<GetMicrosoftTeamsChannelConfigurationRequest>(operation);
            var marshaller = new GetMicrosoftTeamsChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetMicrosoftTeamsChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidParameterException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void GetMicrosoftTeamsChannelConfiguration_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetMicrosoftTeamsChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<GetMicrosoftTeamsChannelConfigurationRequest>(operation);
            var marshaller = new GetMicrosoftTeamsChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetMicrosoftTeamsChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void ListMicrosoftTeamsChannelConfigurationsMarshallTest()
        {
            var operation = service_model.FindOperation("ListMicrosoftTeamsChannelConfigurations");

            var request = InstantiateClassGenerator.Execute<ListMicrosoftTeamsChannelConfigurationsRequest>(operation);
            var marshaller = new ListMicrosoftTeamsChannelConfigurationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListMicrosoftTeamsChannelConfigurations", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListMicrosoftTeamsChannelConfigurationsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as ListMicrosoftTeamsChannelConfigurationsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void ListMicrosoftTeamsChannelConfigurations_InvalidParameterExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListMicrosoftTeamsChannelConfigurations");

            var request = InstantiateClassGenerator.Execute<ListMicrosoftTeamsChannelConfigurationsRequest>(operation);
            var marshaller = new ListMicrosoftTeamsChannelConfigurationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListMicrosoftTeamsChannelConfigurations", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidParameterException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListMicrosoftTeamsChannelConfigurationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void ListMicrosoftTeamsChannelConfigurations_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListMicrosoftTeamsChannelConfigurations");

            var request = InstantiateClassGenerator.Execute<ListMicrosoftTeamsChannelConfigurationsRequest>(operation);
            var marshaller = new ListMicrosoftTeamsChannelConfigurationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListMicrosoftTeamsChannelConfigurations", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListMicrosoftTeamsChannelConfigurationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void ListMicrosoftTeamsChannelConfigurations_ListTeamsChannelConfigurationsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListMicrosoftTeamsChannelConfigurations");

            var request = InstantiateClassGenerator.Execute<ListMicrosoftTeamsChannelConfigurationsRequest>(operation);
            var marshaller = new ListMicrosoftTeamsChannelConfigurationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListMicrosoftTeamsChannelConfigurations", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ListTeamsChannelConfigurationsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ListTeamsChannelConfigurationsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListMicrosoftTeamsChannelConfigurationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void ListMicrosoftTeamsConfiguredTeamsMarshallTest()
        {
            var operation = service_model.FindOperation("ListMicrosoftTeamsConfiguredTeams");

            var request = InstantiateClassGenerator.Execute<ListMicrosoftTeamsConfiguredTeamsRequest>(operation);
            var marshaller = new ListMicrosoftTeamsConfiguredTeamsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListMicrosoftTeamsConfiguredTeams", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListMicrosoftTeamsConfiguredTeamsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as ListMicrosoftTeamsConfiguredTeamsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void ListMicrosoftTeamsConfiguredTeams_InvalidParameterExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListMicrosoftTeamsConfiguredTeams");

            var request = InstantiateClassGenerator.Execute<ListMicrosoftTeamsConfiguredTeamsRequest>(operation);
            var marshaller = new ListMicrosoftTeamsConfiguredTeamsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListMicrosoftTeamsConfiguredTeams", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidParameterException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListMicrosoftTeamsConfiguredTeamsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void ListMicrosoftTeamsConfiguredTeams_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListMicrosoftTeamsConfiguredTeams");

            var request = InstantiateClassGenerator.Execute<ListMicrosoftTeamsConfiguredTeamsRequest>(operation);
            var marshaller = new ListMicrosoftTeamsConfiguredTeamsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListMicrosoftTeamsConfiguredTeams", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListMicrosoftTeamsConfiguredTeamsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void ListMicrosoftTeamsConfiguredTeams_ListMicrosoftTeamsConfiguredTeamsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListMicrosoftTeamsConfiguredTeams");

            var request = InstantiateClassGenerator.Execute<ListMicrosoftTeamsConfiguredTeamsRequest>(operation);
            var marshaller = new ListMicrosoftTeamsConfiguredTeamsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListMicrosoftTeamsConfiguredTeams", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ListMicrosoftTeamsConfiguredTeamsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ListMicrosoftTeamsConfiguredTeamsException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListMicrosoftTeamsConfiguredTeamsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void ListMicrosoftTeamsUserIdentitiesMarshallTest()
        {
            var operation = service_model.FindOperation("ListMicrosoftTeamsUserIdentities");

            var request = InstantiateClassGenerator.Execute<ListMicrosoftTeamsUserIdentitiesRequest>(operation);
            var marshaller = new ListMicrosoftTeamsUserIdentitiesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListMicrosoftTeamsUserIdentities", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListMicrosoftTeamsUserIdentitiesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as ListMicrosoftTeamsUserIdentitiesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void ListMicrosoftTeamsUserIdentities_InvalidParameterExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListMicrosoftTeamsUserIdentities");

            var request = InstantiateClassGenerator.Execute<ListMicrosoftTeamsUserIdentitiesRequest>(operation);
            var marshaller = new ListMicrosoftTeamsUserIdentitiesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListMicrosoftTeamsUserIdentities", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidParameterException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListMicrosoftTeamsUserIdentitiesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void ListMicrosoftTeamsUserIdentities_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListMicrosoftTeamsUserIdentities");

            var request = InstantiateClassGenerator.Execute<ListMicrosoftTeamsUserIdentitiesRequest>(operation);
            var marshaller = new ListMicrosoftTeamsUserIdentitiesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListMicrosoftTeamsUserIdentities", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListMicrosoftTeamsUserIdentitiesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void ListMicrosoftTeamsUserIdentities_ListMicrosoftTeamsUserIdentitiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListMicrosoftTeamsUserIdentities");

            var request = InstantiateClassGenerator.Execute<ListMicrosoftTeamsUserIdentitiesRequest>(operation);
            var marshaller = new ListMicrosoftTeamsUserIdentitiesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListMicrosoftTeamsUserIdentities", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ListMicrosoftTeamsUserIdentitiesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ListMicrosoftTeamsUserIdentitiesException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListMicrosoftTeamsUserIdentitiesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void UpdateAccountPreferencesMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateAccountPreferences");

            var request = InstantiateClassGenerator.Execute<UpdateAccountPreferencesRequest>(operation);
            var marshaller = new UpdateAccountPreferencesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateAccountPreferences", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UpdateAccountPreferencesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as UpdateAccountPreferencesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void UpdateAccountPreferences_InvalidParameterExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateAccountPreferences");

            var request = InstantiateClassGenerator.Execute<UpdateAccountPreferencesRequest>(operation);
            var marshaller = new UpdateAccountPreferencesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateAccountPreferences", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidParameterException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateAccountPreferencesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void UpdateAccountPreferences_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateAccountPreferences");

            var request = InstantiateClassGenerator.Execute<UpdateAccountPreferencesRequest>(operation);
            var marshaller = new UpdateAccountPreferencesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateAccountPreferences", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateAccountPreferencesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void UpdateAccountPreferences_UpdateAccountPreferencesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateAccountPreferences");

            var request = InstantiateClassGenerator.Execute<UpdateAccountPreferencesRequest>(operation);
            var marshaller = new UpdateAccountPreferencesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateAccountPreferences", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UpdateAccountPreferencesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"UpdateAccountPreferencesException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateAccountPreferencesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void UpdateChimeWebhookConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateChimeWebhookConfiguration");

            var request = InstantiateClassGenerator.Execute<UpdateChimeWebhookConfigurationRequest>(operation);
            var marshaller = new UpdateChimeWebhookConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateChimeWebhookConfiguration", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UpdateChimeWebhookConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as UpdateChimeWebhookConfigurationResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void UpdateChimeWebhookConfiguration_InvalidParameterExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateChimeWebhookConfiguration");

            var request = InstantiateClassGenerator.Execute<UpdateChimeWebhookConfigurationRequest>(operation);
            var marshaller = new UpdateChimeWebhookConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateChimeWebhookConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidParameterException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateChimeWebhookConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void UpdateChimeWebhookConfiguration_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateChimeWebhookConfiguration");

            var request = InstantiateClassGenerator.Execute<UpdateChimeWebhookConfigurationRequest>(operation);
            var marshaller = new UpdateChimeWebhookConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateChimeWebhookConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateChimeWebhookConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void UpdateChimeWebhookConfiguration_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateChimeWebhookConfiguration");

            var request = InstantiateClassGenerator.Execute<UpdateChimeWebhookConfigurationRequest>(operation);
            var marshaller = new UpdateChimeWebhookConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateChimeWebhookConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ResourceNotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateChimeWebhookConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void UpdateChimeWebhookConfiguration_UpdateChimeWebhookConfigurationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateChimeWebhookConfiguration");

            var request = InstantiateClassGenerator.Execute<UpdateChimeWebhookConfigurationRequest>(operation);
            var marshaller = new UpdateChimeWebhookConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateChimeWebhookConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UpdateChimeWebhookConfigurationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"UpdateChimeWebhookConfigurationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateChimeWebhookConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void UpdateMicrosoftTeamsChannelConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateMicrosoftTeamsChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<UpdateMicrosoftTeamsChannelConfigurationRequest>(operation);
            var marshaller = new UpdateMicrosoftTeamsChannelConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateMicrosoftTeamsChannelConfiguration", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UpdateMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as UpdateMicrosoftTeamsChannelConfigurationResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void UpdateMicrosoftTeamsChannelConfiguration_InvalidParameterExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateMicrosoftTeamsChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<UpdateMicrosoftTeamsChannelConfigurationRequest>(operation);
            var marshaller = new UpdateMicrosoftTeamsChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateMicrosoftTeamsChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidParameterException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void UpdateMicrosoftTeamsChannelConfiguration_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateMicrosoftTeamsChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<UpdateMicrosoftTeamsChannelConfigurationRequest>(operation);
            var marshaller = new UpdateMicrosoftTeamsChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateMicrosoftTeamsChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void UpdateMicrosoftTeamsChannelConfiguration_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateMicrosoftTeamsChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<UpdateMicrosoftTeamsChannelConfigurationRequest>(operation);
            var marshaller = new UpdateMicrosoftTeamsChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateMicrosoftTeamsChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ResourceNotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void UpdateMicrosoftTeamsChannelConfiguration_UpdateTeamsChannelConfigurationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateMicrosoftTeamsChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<UpdateMicrosoftTeamsChannelConfigurationRequest>(operation);
            var marshaller = new UpdateMicrosoftTeamsChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateMicrosoftTeamsChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UpdateTeamsChannelConfigurationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"UpdateTeamsChannelConfigurationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void UpdateSlackChannelConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateSlackChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<UpdateSlackChannelConfigurationRequest>(operation);
            var marshaller = new UpdateSlackChannelConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateSlackChannelConfiguration", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UpdateSlackChannelConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as UpdateSlackChannelConfigurationResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void UpdateSlackChannelConfiguration_InvalidParameterExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateSlackChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<UpdateSlackChannelConfigurationRequest>(operation);
            var marshaller = new UpdateSlackChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateSlackChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidParameterException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateSlackChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void UpdateSlackChannelConfiguration_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateSlackChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<UpdateSlackChannelConfigurationRequest>(operation);
            var marshaller = new UpdateSlackChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateSlackChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidRequestException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateSlackChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void UpdateSlackChannelConfiguration_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateSlackChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<UpdateSlackChannelConfigurationRequest>(operation);
            var marshaller = new UpdateSlackChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateSlackChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ResourceNotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateSlackChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Chatbot")]
        public void UpdateSlackChannelConfiguration_UpdateSlackChannelConfigurationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateSlackChannelConfiguration");

            var request = InstantiateClassGenerator.Execute<UpdateSlackChannelConfigurationRequest>(operation);
            var marshaller = new UpdateSlackChannelConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateSlackChannelConfiguration", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UpdateSlackChannelConfigurationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"UpdateSlackChannelConfigurationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateSlackChannelConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}