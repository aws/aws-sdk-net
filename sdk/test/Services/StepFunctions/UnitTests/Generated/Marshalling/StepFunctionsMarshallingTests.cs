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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */


using System;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.StepFunctions;
using Amazon.StepFunctions.Model;
using Amazon.StepFunctions.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class StepFunctionsMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("states");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void CreateActivityMarshallTest()
        {
            var operation = service_model.FindOperation("CreateActivity");

            var request = InstantiateClassGenerator.Execute<CreateActivityRequest>(operation);
            var marshaller = new CreateActivityRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<CreateActivityRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = CreateActivityResponseUnmarshaller.Instance.Unmarshall(context) as CreateActivityResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void CreateActivity_ActivityLimitExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateActivity");

            var request = InstantiateClassGenerator.Execute<CreateActivityRequest>(operation);
            var marshaller = new CreateActivityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateActivityRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ActivityLimitExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ActivityLimitExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateActivityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void CreateActivity_InvalidNameExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateActivity");

            var request = InstantiateClassGenerator.Execute<CreateActivityRequest>(operation);
            var marshaller = new CreateActivityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateActivityRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidNameException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidNameException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateActivityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void CreateActivity_TooManyTagsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateActivity");

            var request = InstantiateClassGenerator.Execute<CreateActivityRequest>(operation);
            var marshaller = new CreateActivityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateActivityRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyTagsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"TooManyTagsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateActivityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void CreateStateMachineMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStateMachine");

            var request = InstantiateClassGenerator.Execute<CreateStateMachineRequest>(operation);
            var marshaller = new CreateStateMachineRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<CreateStateMachineRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = CreateStateMachineResponseUnmarshaller.Instance.Unmarshall(context) as CreateStateMachineResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void CreateStateMachine_ConflictExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateStateMachine");

            var request = InstantiateClassGenerator.Execute<CreateStateMachineRequest>(operation);
            var marshaller = new CreateStateMachineRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateStateMachineRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ConflictException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateStateMachineResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void CreateStateMachine_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateStateMachine");

            var request = InstantiateClassGenerator.Execute<CreateStateMachineRequest>(operation);
            var marshaller = new CreateStateMachineRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateStateMachineRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateStateMachineResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void CreateStateMachine_InvalidDefinitionExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateStateMachine");

            var request = InstantiateClassGenerator.Execute<CreateStateMachineRequest>(operation);
            var marshaller = new CreateStateMachineRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateStateMachineRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDefinitionException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidDefinitionException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateStateMachineResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void CreateStateMachine_InvalidLoggingConfigurationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateStateMachine");

            var request = InstantiateClassGenerator.Execute<CreateStateMachineRequest>(operation);
            var marshaller = new CreateStateMachineRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateStateMachineRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidLoggingConfigurationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidLoggingConfigurationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateStateMachineResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void CreateStateMachine_InvalidNameExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateStateMachine");

            var request = InstantiateClassGenerator.Execute<CreateStateMachineRequest>(operation);
            var marshaller = new CreateStateMachineRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateStateMachineRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidNameException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidNameException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateStateMachineResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void CreateStateMachine_InvalidTracingConfigurationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateStateMachine");

            var request = InstantiateClassGenerator.Execute<CreateStateMachineRequest>(operation);
            var marshaller = new CreateStateMachineRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateStateMachineRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTracingConfigurationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidTracingConfigurationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateStateMachineResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void CreateStateMachine_StateMachineAlreadyExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateStateMachine");

            var request = InstantiateClassGenerator.Execute<CreateStateMachineRequest>(operation);
            var marshaller = new CreateStateMachineRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateStateMachineRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("StateMachineAlreadyExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"StateMachineAlreadyExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateStateMachineResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void CreateStateMachine_StateMachineDeletingExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateStateMachine");

            var request = InstantiateClassGenerator.Execute<CreateStateMachineRequest>(operation);
            var marshaller = new CreateStateMachineRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateStateMachineRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("StateMachineDeletingException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"StateMachineDeletingException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateStateMachineResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void CreateStateMachine_StateMachineLimitExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateStateMachine");

            var request = InstantiateClassGenerator.Execute<CreateStateMachineRequest>(operation);
            var marshaller = new CreateStateMachineRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateStateMachineRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("StateMachineLimitExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"StateMachineLimitExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateStateMachineResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void CreateStateMachine_StateMachineTypeNotSupportedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateStateMachine");

            var request = InstantiateClassGenerator.Execute<CreateStateMachineRequest>(operation);
            var marshaller = new CreateStateMachineRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateStateMachineRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("StateMachineTypeNotSupportedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"StateMachineTypeNotSupportedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateStateMachineResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void CreateStateMachine_TooManyTagsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateStateMachine");

            var request = InstantiateClassGenerator.Execute<CreateStateMachineRequest>(operation);
            var marshaller = new CreateStateMachineRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateStateMachineRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyTagsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"TooManyTagsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateStateMachineResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void CreateStateMachine_ValidationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateStateMachine");

            var request = InstantiateClassGenerator.Execute<CreateStateMachineRequest>(operation);
            var marshaller = new CreateStateMachineRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateStateMachineRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ValidationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateStateMachineResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void CreateStateMachineAliasMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStateMachineAlias");

            var request = InstantiateClassGenerator.Execute<CreateStateMachineAliasRequest>(operation);
            var marshaller = new CreateStateMachineAliasRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<CreateStateMachineAliasRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = CreateStateMachineAliasResponseUnmarshaller.Instance.Unmarshall(context) as CreateStateMachineAliasResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void CreateStateMachineAlias_ConflictExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateStateMachineAlias");

            var request = InstantiateClassGenerator.Execute<CreateStateMachineAliasRequest>(operation);
            var marshaller = new CreateStateMachineAliasRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateStateMachineAliasRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ConflictException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateStateMachineAliasResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void CreateStateMachineAlias_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateStateMachineAlias");

            var request = InstantiateClassGenerator.Execute<CreateStateMachineAliasRequest>(operation);
            var marshaller = new CreateStateMachineAliasRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateStateMachineAliasRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateStateMachineAliasResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void CreateStateMachineAlias_InvalidNameExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateStateMachineAlias");

            var request = InstantiateClassGenerator.Execute<CreateStateMachineAliasRequest>(operation);
            var marshaller = new CreateStateMachineAliasRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateStateMachineAliasRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidNameException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidNameException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateStateMachineAliasResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void CreateStateMachineAlias_ResourceNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateStateMachineAlias");

            var request = InstantiateClassGenerator.Execute<CreateStateMachineAliasRequest>(operation);
            var marshaller = new CreateStateMachineAliasRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateStateMachineAliasRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ResourceNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateStateMachineAliasResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void CreateStateMachineAlias_ServiceQuotaExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateStateMachineAlias");

            var request = InstantiateClassGenerator.Execute<CreateStateMachineAliasRequest>(operation);
            var marshaller = new CreateStateMachineAliasRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateStateMachineAliasRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceQuotaExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ServiceQuotaExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateStateMachineAliasResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void CreateStateMachineAlias_StateMachineDeletingExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateStateMachineAlias");

            var request = InstantiateClassGenerator.Execute<CreateStateMachineAliasRequest>(operation);
            var marshaller = new CreateStateMachineAliasRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateStateMachineAliasRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("StateMachineDeletingException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"StateMachineDeletingException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateStateMachineAliasResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void CreateStateMachineAlias_ValidationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateStateMachineAlias");

            var request = InstantiateClassGenerator.Execute<CreateStateMachineAliasRequest>(operation);
            var marshaller = new CreateStateMachineAliasRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateStateMachineAliasRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ValidationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateStateMachineAliasResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DeleteActivityMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteActivity");

            var request = InstantiateClassGenerator.Execute<DeleteActivityRequest>(operation);
            var marshaller = new DeleteActivityRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DeleteActivityRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DeleteActivityResponseUnmarshaller.Instance.Unmarshall(context) as DeleteActivityResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DeleteActivity_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteActivity");

            var request = InstantiateClassGenerator.Execute<DeleteActivityRequest>(operation);
            var marshaller = new DeleteActivityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteActivityRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteActivityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DeleteStateMachineMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteStateMachine");

            var request = InstantiateClassGenerator.Execute<DeleteStateMachineRequest>(operation);
            var marshaller = new DeleteStateMachineRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DeleteStateMachineRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DeleteStateMachineResponseUnmarshaller.Instance.Unmarshall(context) as DeleteStateMachineResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DeleteStateMachine_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteStateMachine");

            var request = InstantiateClassGenerator.Execute<DeleteStateMachineRequest>(operation);
            var marshaller = new DeleteStateMachineRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteStateMachineRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteStateMachineResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DeleteStateMachine_ValidationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteStateMachine");

            var request = InstantiateClassGenerator.Execute<DeleteStateMachineRequest>(operation);
            var marshaller = new DeleteStateMachineRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteStateMachineRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ValidationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteStateMachineResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DeleteStateMachineAliasMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteStateMachineAlias");

            var request = InstantiateClassGenerator.Execute<DeleteStateMachineAliasRequest>(operation);
            var marshaller = new DeleteStateMachineAliasRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DeleteStateMachineAliasRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DeleteStateMachineAliasResponseUnmarshaller.Instance.Unmarshall(context) as DeleteStateMachineAliasResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DeleteStateMachineAlias_ConflictExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteStateMachineAlias");

            var request = InstantiateClassGenerator.Execute<DeleteStateMachineAliasRequest>(operation);
            var marshaller = new DeleteStateMachineAliasRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteStateMachineAliasRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ConflictException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteStateMachineAliasResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DeleteStateMachineAlias_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteStateMachineAlias");

            var request = InstantiateClassGenerator.Execute<DeleteStateMachineAliasRequest>(operation);
            var marshaller = new DeleteStateMachineAliasRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteStateMachineAliasRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteStateMachineAliasResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DeleteStateMachineAlias_ResourceNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteStateMachineAlias");

            var request = InstantiateClassGenerator.Execute<DeleteStateMachineAliasRequest>(operation);
            var marshaller = new DeleteStateMachineAliasRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteStateMachineAliasRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ResourceNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteStateMachineAliasResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DeleteStateMachineAlias_ValidationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteStateMachineAlias");

            var request = InstantiateClassGenerator.Execute<DeleteStateMachineAliasRequest>(operation);
            var marshaller = new DeleteStateMachineAliasRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteStateMachineAliasRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ValidationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteStateMachineAliasResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DeleteStateMachineVersionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteStateMachineVersion");

            var request = InstantiateClassGenerator.Execute<DeleteStateMachineVersionRequest>(operation);
            var marshaller = new DeleteStateMachineVersionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DeleteStateMachineVersionRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DeleteStateMachineVersionResponseUnmarshaller.Instance.Unmarshall(context) as DeleteStateMachineVersionResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DeleteStateMachineVersion_ConflictExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteStateMachineVersion");

            var request = InstantiateClassGenerator.Execute<DeleteStateMachineVersionRequest>(operation);
            var marshaller = new DeleteStateMachineVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteStateMachineVersionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ConflictException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteStateMachineVersionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DeleteStateMachineVersion_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteStateMachineVersion");

            var request = InstantiateClassGenerator.Execute<DeleteStateMachineVersionRequest>(operation);
            var marshaller = new DeleteStateMachineVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteStateMachineVersionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteStateMachineVersionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DeleteStateMachineVersion_ValidationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteStateMachineVersion");

            var request = InstantiateClassGenerator.Execute<DeleteStateMachineVersionRequest>(operation);
            var marshaller = new DeleteStateMachineVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteStateMachineVersionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ValidationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteStateMachineVersionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DescribeActivityMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeActivity");

            var request = InstantiateClassGenerator.Execute<DescribeActivityRequest>(operation);
            var marshaller = new DescribeActivityRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DescribeActivityRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeActivityResponseUnmarshaller.Instance.Unmarshall(context) as DescribeActivityResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DescribeActivity_ActivityDoesNotExistExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeActivity");

            var request = InstantiateClassGenerator.Execute<DescribeActivityRequest>(operation);
            var marshaller = new DescribeActivityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeActivityRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ActivityDoesNotExistException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ActivityDoesNotExistException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeActivityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DescribeActivity_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeActivity");

            var request = InstantiateClassGenerator.Execute<DescribeActivityRequest>(operation);
            var marshaller = new DescribeActivityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeActivityRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeActivityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DescribeExecutionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeExecution");

            var request = InstantiateClassGenerator.Execute<DescribeExecutionRequest>(operation);
            var marshaller = new DescribeExecutionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DescribeExecutionRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeExecutionResponseUnmarshaller.Instance.Unmarshall(context) as DescribeExecutionResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DescribeExecution_ExecutionDoesNotExistExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeExecution");

            var request = InstantiateClassGenerator.Execute<DescribeExecutionRequest>(operation);
            var marshaller = new DescribeExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeExecutionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ExecutionDoesNotExistException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ExecutionDoesNotExistException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DescribeExecution_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeExecution");

            var request = InstantiateClassGenerator.Execute<DescribeExecutionRequest>(operation);
            var marshaller = new DescribeExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeExecutionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DescribeMapRunMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeMapRun");

            var request = InstantiateClassGenerator.Execute<DescribeMapRunRequest>(operation);
            var marshaller = new DescribeMapRunRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DescribeMapRunRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeMapRunResponseUnmarshaller.Instance.Unmarshall(context) as DescribeMapRunResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DescribeMapRun_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeMapRun");

            var request = InstantiateClassGenerator.Execute<DescribeMapRunRequest>(operation);
            var marshaller = new DescribeMapRunRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeMapRunRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeMapRunResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DescribeMapRun_ResourceNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeMapRun");

            var request = InstantiateClassGenerator.Execute<DescribeMapRunRequest>(operation);
            var marshaller = new DescribeMapRunRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeMapRunRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ResourceNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeMapRunResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DescribeStateMachineMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeStateMachine");

            var request = InstantiateClassGenerator.Execute<DescribeStateMachineRequest>(operation);
            var marshaller = new DescribeStateMachineRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DescribeStateMachineRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeStateMachineResponseUnmarshaller.Instance.Unmarshall(context) as DescribeStateMachineResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DescribeStateMachine_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeStateMachine");

            var request = InstantiateClassGenerator.Execute<DescribeStateMachineRequest>(operation);
            var marshaller = new DescribeStateMachineRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeStateMachineRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeStateMachineResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DescribeStateMachine_StateMachineDoesNotExistExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeStateMachine");

            var request = InstantiateClassGenerator.Execute<DescribeStateMachineRequest>(operation);
            var marshaller = new DescribeStateMachineRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeStateMachineRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("StateMachineDoesNotExistException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"StateMachineDoesNotExistException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeStateMachineResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DescribeStateMachineAliasMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeStateMachineAlias");

            var request = InstantiateClassGenerator.Execute<DescribeStateMachineAliasRequest>(operation);
            var marshaller = new DescribeStateMachineAliasRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DescribeStateMachineAliasRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeStateMachineAliasResponseUnmarshaller.Instance.Unmarshall(context) as DescribeStateMachineAliasResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DescribeStateMachineAlias_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeStateMachineAlias");

            var request = InstantiateClassGenerator.Execute<DescribeStateMachineAliasRequest>(operation);
            var marshaller = new DescribeStateMachineAliasRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeStateMachineAliasRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeStateMachineAliasResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DescribeStateMachineAlias_ResourceNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeStateMachineAlias");

            var request = InstantiateClassGenerator.Execute<DescribeStateMachineAliasRequest>(operation);
            var marshaller = new DescribeStateMachineAliasRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeStateMachineAliasRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ResourceNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeStateMachineAliasResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DescribeStateMachineAlias_ValidationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeStateMachineAlias");

            var request = InstantiateClassGenerator.Execute<DescribeStateMachineAliasRequest>(operation);
            var marshaller = new DescribeStateMachineAliasRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeStateMachineAliasRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ValidationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeStateMachineAliasResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DescribeStateMachineForExecutionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeStateMachineForExecution");

            var request = InstantiateClassGenerator.Execute<DescribeStateMachineForExecutionRequest>(operation);
            var marshaller = new DescribeStateMachineForExecutionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DescribeStateMachineForExecutionRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeStateMachineForExecutionResponseUnmarshaller.Instance.Unmarshall(context) as DescribeStateMachineForExecutionResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DescribeStateMachineForExecution_ExecutionDoesNotExistExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeStateMachineForExecution");

            var request = InstantiateClassGenerator.Execute<DescribeStateMachineForExecutionRequest>(operation);
            var marshaller = new DescribeStateMachineForExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeStateMachineForExecutionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ExecutionDoesNotExistException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ExecutionDoesNotExistException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeStateMachineForExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void DescribeStateMachineForExecution_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeStateMachineForExecution");

            var request = InstantiateClassGenerator.Execute<DescribeStateMachineForExecutionRequest>(operation);
            var marshaller = new DescribeStateMachineForExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeStateMachineForExecutionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeStateMachineForExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void GetActivityTaskMarshallTest()
        {
            var operation = service_model.FindOperation("GetActivityTask");

            var request = InstantiateClassGenerator.Execute<GetActivityTaskRequest>(operation);
            var marshaller = new GetActivityTaskRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<GetActivityTaskRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetActivityTaskResponseUnmarshaller.Instance.Unmarshall(context) as GetActivityTaskResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void GetActivityTask_ActivityDoesNotExistExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetActivityTask");

            var request = InstantiateClassGenerator.Execute<GetActivityTaskRequest>(operation);
            var marshaller = new GetActivityTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetActivityTaskRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ActivityDoesNotExistException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ActivityDoesNotExistException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetActivityTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void GetActivityTask_ActivityWorkerLimitExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetActivityTask");

            var request = InstantiateClassGenerator.Execute<GetActivityTaskRequest>(operation);
            var marshaller = new GetActivityTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetActivityTaskRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ActivityWorkerLimitExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ActivityWorkerLimitExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetActivityTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void GetActivityTask_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetActivityTask");

            var request = InstantiateClassGenerator.Execute<GetActivityTaskRequest>(operation);
            var marshaller = new GetActivityTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetActivityTaskRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetActivityTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void GetExecutionHistoryMarshallTest()
        {
            var operation = service_model.FindOperation("GetExecutionHistory");

            var request = InstantiateClassGenerator.Execute<GetExecutionHistoryRequest>(operation);
            var marshaller = new GetExecutionHistoryRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<GetExecutionHistoryRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetExecutionHistoryResponseUnmarshaller.Instance.Unmarshall(context) as GetExecutionHistoryResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void GetExecutionHistory_ExecutionDoesNotExistExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetExecutionHistory");

            var request = InstantiateClassGenerator.Execute<GetExecutionHistoryRequest>(operation);
            var marshaller = new GetExecutionHistoryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetExecutionHistoryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ExecutionDoesNotExistException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ExecutionDoesNotExistException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetExecutionHistoryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void GetExecutionHistory_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetExecutionHistory");

            var request = InstantiateClassGenerator.Execute<GetExecutionHistoryRequest>(operation);
            var marshaller = new GetExecutionHistoryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetExecutionHistoryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetExecutionHistoryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void GetExecutionHistory_InvalidTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetExecutionHistory");

            var request = InstantiateClassGenerator.Execute<GetExecutionHistoryRequest>(operation);
            var marshaller = new GetExecutionHistoryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetExecutionHistoryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetExecutionHistoryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListActivitiesMarshallTest()
        {
            var operation = service_model.FindOperation("ListActivities");

            var request = InstantiateClassGenerator.Execute<ListActivitiesRequest>(operation);
            var marshaller = new ListActivitiesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<ListActivitiesRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListActivitiesResponseUnmarshaller.Instance.Unmarshall(context) as ListActivitiesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListActivities_InvalidTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListActivities");

            var request = InstantiateClassGenerator.Execute<ListActivitiesRequest>(operation);
            var marshaller = new ListActivitiesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListActivitiesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListActivitiesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListExecutionsMarshallTest()
        {
            var operation = service_model.FindOperation("ListExecutions");

            var request = InstantiateClassGenerator.Execute<ListExecutionsRequest>(operation);
            var marshaller = new ListExecutionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<ListExecutionsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListExecutionsResponseUnmarshaller.Instance.Unmarshall(context) as ListExecutionsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListExecutions_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListExecutions");

            var request = InstantiateClassGenerator.Execute<ListExecutionsRequest>(operation);
            var marshaller = new ListExecutionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListExecutionsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListExecutionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListExecutions_InvalidTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListExecutions");

            var request = InstantiateClassGenerator.Execute<ListExecutionsRequest>(operation);
            var marshaller = new ListExecutionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListExecutionsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListExecutionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListExecutions_ResourceNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListExecutions");

            var request = InstantiateClassGenerator.Execute<ListExecutionsRequest>(operation);
            var marshaller = new ListExecutionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListExecutionsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ResourceNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListExecutionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListExecutions_StateMachineDoesNotExistExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListExecutions");

            var request = InstantiateClassGenerator.Execute<ListExecutionsRequest>(operation);
            var marshaller = new ListExecutionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListExecutionsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("StateMachineDoesNotExistException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"StateMachineDoesNotExistException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListExecutionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListExecutions_StateMachineTypeNotSupportedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListExecutions");

            var request = InstantiateClassGenerator.Execute<ListExecutionsRequest>(operation);
            var marshaller = new ListExecutionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListExecutionsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("StateMachineTypeNotSupportedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"StateMachineTypeNotSupportedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListExecutionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListExecutions_ValidationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListExecutions");

            var request = InstantiateClassGenerator.Execute<ListExecutionsRequest>(operation);
            var marshaller = new ListExecutionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListExecutionsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ValidationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListExecutionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListMapRunsMarshallTest()
        {
            var operation = service_model.FindOperation("ListMapRuns");

            var request = InstantiateClassGenerator.Execute<ListMapRunsRequest>(operation);
            var marshaller = new ListMapRunsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<ListMapRunsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListMapRunsResponseUnmarshaller.Instance.Unmarshall(context) as ListMapRunsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListMapRuns_ExecutionDoesNotExistExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListMapRuns");

            var request = InstantiateClassGenerator.Execute<ListMapRunsRequest>(operation);
            var marshaller = new ListMapRunsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListMapRunsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ExecutionDoesNotExistException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ExecutionDoesNotExistException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListMapRunsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListMapRuns_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListMapRuns");

            var request = InstantiateClassGenerator.Execute<ListMapRunsRequest>(operation);
            var marshaller = new ListMapRunsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListMapRunsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListMapRunsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListMapRuns_InvalidTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListMapRuns");

            var request = InstantiateClassGenerator.Execute<ListMapRunsRequest>(operation);
            var marshaller = new ListMapRunsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListMapRunsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListMapRunsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListStateMachineAliasesMarshallTest()
        {
            var operation = service_model.FindOperation("ListStateMachineAliases");

            var request = InstantiateClassGenerator.Execute<ListStateMachineAliasesRequest>(operation);
            var marshaller = new ListStateMachineAliasesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<ListStateMachineAliasesRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListStateMachineAliasesResponseUnmarshaller.Instance.Unmarshall(context) as ListStateMachineAliasesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListStateMachineAliases_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListStateMachineAliases");

            var request = InstantiateClassGenerator.Execute<ListStateMachineAliasesRequest>(operation);
            var marshaller = new ListStateMachineAliasesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListStateMachineAliasesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListStateMachineAliasesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListStateMachineAliases_InvalidTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListStateMachineAliases");

            var request = InstantiateClassGenerator.Execute<ListStateMachineAliasesRequest>(operation);
            var marshaller = new ListStateMachineAliasesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListStateMachineAliasesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListStateMachineAliasesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListStateMachineAliases_ResourceNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListStateMachineAliases");

            var request = InstantiateClassGenerator.Execute<ListStateMachineAliasesRequest>(operation);
            var marshaller = new ListStateMachineAliasesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListStateMachineAliasesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ResourceNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListStateMachineAliasesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListStateMachineAliases_StateMachineDeletingExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListStateMachineAliases");

            var request = InstantiateClassGenerator.Execute<ListStateMachineAliasesRequest>(operation);
            var marshaller = new ListStateMachineAliasesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListStateMachineAliasesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("StateMachineDeletingException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"StateMachineDeletingException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListStateMachineAliasesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListStateMachineAliases_StateMachineDoesNotExistExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListStateMachineAliases");

            var request = InstantiateClassGenerator.Execute<ListStateMachineAliasesRequest>(operation);
            var marshaller = new ListStateMachineAliasesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListStateMachineAliasesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("StateMachineDoesNotExistException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"StateMachineDoesNotExistException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListStateMachineAliasesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListStateMachinesMarshallTest()
        {
            var operation = service_model.FindOperation("ListStateMachines");

            var request = InstantiateClassGenerator.Execute<ListStateMachinesRequest>(operation);
            var marshaller = new ListStateMachinesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<ListStateMachinesRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListStateMachinesResponseUnmarshaller.Instance.Unmarshall(context) as ListStateMachinesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListStateMachines_InvalidTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListStateMachines");

            var request = InstantiateClassGenerator.Execute<ListStateMachinesRequest>(operation);
            var marshaller = new ListStateMachinesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListStateMachinesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListStateMachinesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListStateMachineVersionsMarshallTest()
        {
            var operation = service_model.FindOperation("ListStateMachineVersions");

            var request = InstantiateClassGenerator.Execute<ListStateMachineVersionsRequest>(operation);
            var marshaller = new ListStateMachineVersionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<ListStateMachineVersionsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListStateMachineVersionsResponseUnmarshaller.Instance.Unmarshall(context) as ListStateMachineVersionsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListStateMachineVersions_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListStateMachineVersions");

            var request = InstantiateClassGenerator.Execute<ListStateMachineVersionsRequest>(operation);
            var marshaller = new ListStateMachineVersionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListStateMachineVersionsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListStateMachineVersionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListStateMachineVersions_InvalidTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListStateMachineVersions");

            var request = InstantiateClassGenerator.Execute<ListStateMachineVersionsRequest>(operation);
            var marshaller = new ListStateMachineVersionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListStateMachineVersionsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListStateMachineVersionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListStateMachineVersions_ValidationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListStateMachineVersions");

            var request = InstantiateClassGenerator.Execute<ListStateMachineVersionsRequest>(operation);
            var marshaller = new ListStateMachineVersionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListStateMachineVersionsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ValidationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListStateMachineVersionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListTagsForResourceMarshallTest()
        {
            var operation = service_model.FindOperation("ListTagsForResource");

            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>(operation);
            var marshaller = new ListTagsForResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<ListTagsForResourceRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListTagsForResourceResponseUnmarshaller.Instance.Unmarshall(context) as ListTagsForResourceResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListTagsForResource_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListTagsForResource");

            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>(operation);
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListTagsForResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListTagsForResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void ListTagsForResource_ResourceNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListTagsForResource");

            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>(operation);
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListTagsForResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ResourceNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListTagsForResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void PublishStateMachineVersionMarshallTest()
        {
            var operation = service_model.FindOperation("PublishStateMachineVersion");

            var request = InstantiateClassGenerator.Execute<PublishStateMachineVersionRequest>(operation);
            var marshaller = new PublishStateMachineVersionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<PublishStateMachineVersionRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = PublishStateMachineVersionResponseUnmarshaller.Instance.Unmarshall(context) as PublishStateMachineVersionResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void PublishStateMachineVersion_ConflictExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PublishStateMachineVersion");

            var request = InstantiateClassGenerator.Execute<PublishStateMachineVersionRequest>(operation);
            var marshaller = new PublishStateMachineVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PublishStateMachineVersionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ConflictException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PublishStateMachineVersionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void PublishStateMachineVersion_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PublishStateMachineVersion");

            var request = InstantiateClassGenerator.Execute<PublishStateMachineVersionRequest>(operation);
            var marshaller = new PublishStateMachineVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PublishStateMachineVersionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PublishStateMachineVersionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void PublishStateMachineVersion_ServiceQuotaExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PublishStateMachineVersion");

            var request = InstantiateClassGenerator.Execute<PublishStateMachineVersionRequest>(operation);
            var marshaller = new PublishStateMachineVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PublishStateMachineVersionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceQuotaExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ServiceQuotaExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PublishStateMachineVersionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void PublishStateMachineVersion_StateMachineDeletingExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PublishStateMachineVersion");

            var request = InstantiateClassGenerator.Execute<PublishStateMachineVersionRequest>(operation);
            var marshaller = new PublishStateMachineVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PublishStateMachineVersionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("StateMachineDeletingException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"StateMachineDeletingException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PublishStateMachineVersionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void PublishStateMachineVersion_StateMachineDoesNotExistExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PublishStateMachineVersion");

            var request = InstantiateClassGenerator.Execute<PublishStateMachineVersionRequest>(operation);
            var marshaller = new PublishStateMachineVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PublishStateMachineVersionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("StateMachineDoesNotExistException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"StateMachineDoesNotExistException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PublishStateMachineVersionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void PublishStateMachineVersion_ValidationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PublishStateMachineVersion");

            var request = InstantiateClassGenerator.Execute<PublishStateMachineVersionRequest>(operation);
            var marshaller = new PublishStateMachineVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PublishStateMachineVersionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ValidationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PublishStateMachineVersionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void RedriveExecutionMarshallTest()
        {
            var operation = service_model.FindOperation("RedriveExecution");

            var request = InstantiateClassGenerator.Execute<RedriveExecutionRequest>(operation);
            var marshaller = new RedriveExecutionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<RedriveExecutionRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = RedriveExecutionResponseUnmarshaller.Instance.Unmarshall(context) as RedriveExecutionResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void RedriveExecution_ExecutionDoesNotExistExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RedriveExecution");

            var request = InstantiateClassGenerator.Execute<RedriveExecutionRequest>(operation);
            var marshaller = new RedriveExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RedriveExecutionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ExecutionDoesNotExistException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ExecutionDoesNotExistException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RedriveExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void RedriveExecution_ExecutionLimitExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RedriveExecution");

            var request = InstantiateClassGenerator.Execute<RedriveExecutionRequest>(operation);
            var marshaller = new RedriveExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RedriveExecutionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ExecutionLimitExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ExecutionLimitExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RedriveExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void RedriveExecution_ExecutionNotRedrivableExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RedriveExecution");

            var request = InstantiateClassGenerator.Execute<RedriveExecutionRequest>(operation);
            var marshaller = new RedriveExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RedriveExecutionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ExecutionNotRedrivableException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ExecutionNotRedrivableException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RedriveExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void RedriveExecution_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RedriveExecution");

            var request = InstantiateClassGenerator.Execute<RedriveExecutionRequest>(operation);
            var marshaller = new RedriveExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RedriveExecutionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RedriveExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void SendTaskFailureMarshallTest()
        {
            var operation = service_model.FindOperation("SendTaskFailure");

            var request = InstantiateClassGenerator.Execute<SendTaskFailureRequest>(operation);
            var marshaller = new SendTaskFailureRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<SendTaskFailureRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = SendTaskFailureResponseUnmarshaller.Instance.Unmarshall(context) as SendTaskFailureResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void SendTaskFailure_InvalidTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendTaskFailure");

            var request = InstantiateClassGenerator.Execute<SendTaskFailureRequest>(operation);
            var marshaller = new SendTaskFailureRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendTaskFailureRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendTaskFailureResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void SendTaskFailure_TaskDoesNotExistExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendTaskFailure");

            var request = InstantiateClassGenerator.Execute<SendTaskFailureRequest>(operation);
            var marshaller = new SendTaskFailureRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendTaskFailureRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TaskDoesNotExistException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"TaskDoesNotExistException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendTaskFailureResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void SendTaskFailure_TaskTimedOutExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendTaskFailure");

            var request = InstantiateClassGenerator.Execute<SendTaskFailureRequest>(operation);
            var marshaller = new SendTaskFailureRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendTaskFailureRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TaskTimedOutException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"TaskTimedOutException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendTaskFailureResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void SendTaskHeartbeatMarshallTest()
        {
            var operation = service_model.FindOperation("SendTaskHeartbeat");

            var request = InstantiateClassGenerator.Execute<SendTaskHeartbeatRequest>(operation);
            var marshaller = new SendTaskHeartbeatRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<SendTaskHeartbeatRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = SendTaskHeartbeatResponseUnmarshaller.Instance.Unmarshall(context) as SendTaskHeartbeatResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void SendTaskHeartbeat_InvalidTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendTaskHeartbeat");

            var request = InstantiateClassGenerator.Execute<SendTaskHeartbeatRequest>(operation);
            var marshaller = new SendTaskHeartbeatRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendTaskHeartbeatRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendTaskHeartbeatResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void SendTaskHeartbeat_TaskDoesNotExistExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendTaskHeartbeat");

            var request = InstantiateClassGenerator.Execute<SendTaskHeartbeatRequest>(operation);
            var marshaller = new SendTaskHeartbeatRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendTaskHeartbeatRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TaskDoesNotExistException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"TaskDoesNotExistException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendTaskHeartbeatResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void SendTaskHeartbeat_TaskTimedOutExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendTaskHeartbeat");

            var request = InstantiateClassGenerator.Execute<SendTaskHeartbeatRequest>(operation);
            var marshaller = new SendTaskHeartbeatRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendTaskHeartbeatRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TaskTimedOutException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"TaskTimedOutException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendTaskHeartbeatResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void SendTaskSuccessMarshallTest()
        {
            var operation = service_model.FindOperation("SendTaskSuccess");

            var request = InstantiateClassGenerator.Execute<SendTaskSuccessRequest>(operation);
            var marshaller = new SendTaskSuccessRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<SendTaskSuccessRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = SendTaskSuccessResponseUnmarshaller.Instance.Unmarshall(context) as SendTaskSuccessResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void SendTaskSuccess_InvalidOutputExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendTaskSuccess");

            var request = InstantiateClassGenerator.Execute<SendTaskSuccessRequest>(operation);
            var marshaller = new SendTaskSuccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendTaskSuccessRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOutputException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidOutputException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendTaskSuccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void SendTaskSuccess_InvalidTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendTaskSuccess");

            var request = InstantiateClassGenerator.Execute<SendTaskSuccessRequest>(operation);
            var marshaller = new SendTaskSuccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendTaskSuccessRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendTaskSuccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void SendTaskSuccess_TaskDoesNotExistExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendTaskSuccess");

            var request = InstantiateClassGenerator.Execute<SendTaskSuccessRequest>(operation);
            var marshaller = new SendTaskSuccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendTaskSuccessRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TaskDoesNotExistException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"TaskDoesNotExistException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendTaskSuccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void SendTaskSuccess_TaskTimedOutExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendTaskSuccess");

            var request = InstantiateClassGenerator.Execute<SendTaskSuccessRequest>(operation);
            var marshaller = new SendTaskSuccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendTaskSuccessRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TaskTimedOutException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"TaskTimedOutException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendTaskSuccessResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void StartExecutionMarshallTest()
        {
            var operation = service_model.FindOperation("StartExecution");

            var request = InstantiateClassGenerator.Execute<StartExecutionRequest>(operation);
            var marshaller = new StartExecutionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<StartExecutionRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = StartExecutionResponseUnmarshaller.Instance.Unmarshall(context) as StartExecutionResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void StartExecution_ExecutionAlreadyExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartExecution");

            var request = InstantiateClassGenerator.Execute<StartExecutionRequest>(operation);
            var marshaller = new StartExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartExecutionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ExecutionAlreadyExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ExecutionAlreadyExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void StartExecution_ExecutionLimitExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartExecution");

            var request = InstantiateClassGenerator.Execute<StartExecutionRequest>(operation);
            var marshaller = new StartExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartExecutionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ExecutionLimitExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ExecutionLimitExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void StartExecution_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartExecution");

            var request = InstantiateClassGenerator.Execute<StartExecutionRequest>(operation);
            var marshaller = new StartExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartExecutionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void StartExecution_InvalidExecutionInputExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartExecution");

            var request = InstantiateClassGenerator.Execute<StartExecutionRequest>(operation);
            var marshaller = new StartExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartExecutionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidExecutionInputException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidExecutionInputException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void StartExecution_InvalidNameExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartExecution");

            var request = InstantiateClassGenerator.Execute<StartExecutionRequest>(operation);
            var marshaller = new StartExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartExecutionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidNameException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidNameException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void StartExecution_StateMachineDeletingExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartExecution");

            var request = InstantiateClassGenerator.Execute<StartExecutionRequest>(operation);
            var marshaller = new StartExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartExecutionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("StateMachineDeletingException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"StateMachineDeletingException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void StartExecution_StateMachineDoesNotExistExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartExecution");

            var request = InstantiateClassGenerator.Execute<StartExecutionRequest>(operation);
            var marshaller = new StartExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartExecutionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("StateMachineDoesNotExistException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"StateMachineDoesNotExistException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void StartExecution_ValidationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartExecution");

            var request = InstantiateClassGenerator.Execute<StartExecutionRequest>(operation);
            var marshaller = new StartExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartExecutionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ValidationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void StartSyncExecutionMarshallTest()
        {
            var operation = service_model.FindOperation("StartSyncExecution");

            var request = InstantiateClassGenerator.Execute<StartSyncExecutionRequest>(operation);
            var marshaller = new StartSyncExecutionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<StartSyncExecutionRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = StartSyncExecutionResponseUnmarshaller.Instance.Unmarshall(context) as StartSyncExecutionResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void StartSyncExecution_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartSyncExecution");

            var request = InstantiateClassGenerator.Execute<StartSyncExecutionRequest>(operation);
            var marshaller = new StartSyncExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartSyncExecutionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartSyncExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void StartSyncExecution_InvalidExecutionInputExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartSyncExecution");

            var request = InstantiateClassGenerator.Execute<StartSyncExecutionRequest>(operation);
            var marshaller = new StartSyncExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartSyncExecutionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidExecutionInputException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidExecutionInputException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartSyncExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void StartSyncExecution_InvalidNameExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartSyncExecution");

            var request = InstantiateClassGenerator.Execute<StartSyncExecutionRequest>(operation);
            var marshaller = new StartSyncExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartSyncExecutionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidNameException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidNameException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartSyncExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void StartSyncExecution_StateMachineDeletingExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartSyncExecution");

            var request = InstantiateClassGenerator.Execute<StartSyncExecutionRequest>(operation);
            var marshaller = new StartSyncExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartSyncExecutionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("StateMachineDeletingException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"StateMachineDeletingException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartSyncExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void StartSyncExecution_StateMachineDoesNotExistExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartSyncExecution");

            var request = InstantiateClassGenerator.Execute<StartSyncExecutionRequest>(operation);
            var marshaller = new StartSyncExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartSyncExecutionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("StateMachineDoesNotExistException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"StateMachineDoesNotExistException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartSyncExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void StartSyncExecution_StateMachineTypeNotSupportedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartSyncExecution");

            var request = InstantiateClassGenerator.Execute<StartSyncExecutionRequest>(operation);
            var marshaller = new StartSyncExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartSyncExecutionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("StateMachineTypeNotSupportedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"StateMachineTypeNotSupportedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartSyncExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void StopExecutionMarshallTest()
        {
            var operation = service_model.FindOperation("StopExecution");

            var request = InstantiateClassGenerator.Execute<StopExecutionRequest>(operation);
            var marshaller = new StopExecutionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<StopExecutionRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = StopExecutionResponseUnmarshaller.Instance.Unmarshall(context) as StopExecutionResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void StopExecution_ExecutionDoesNotExistExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StopExecution");

            var request = InstantiateClassGenerator.Execute<StopExecutionRequest>(operation);
            var marshaller = new StopExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StopExecutionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ExecutionDoesNotExistException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ExecutionDoesNotExistException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StopExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void StopExecution_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StopExecution");

            var request = InstantiateClassGenerator.Execute<StopExecutionRequest>(operation);
            var marshaller = new StopExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StopExecutionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StopExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void StopExecution_ValidationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StopExecution");

            var request = InstantiateClassGenerator.Execute<StopExecutionRequest>(operation);
            var marshaller = new StopExecutionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StopExecutionRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ValidationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StopExecutionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void TagResourceMarshallTest()
        {
            var operation = service_model.FindOperation("TagResource");

            var request = InstantiateClassGenerator.Execute<TagResourceRequest>(operation);
            var marshaller = new TagResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<TagResourceRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = TagResourceResponseUnmarshaller.Instance.Unmarshall(context) as TagResourceResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void TagResource_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("TagResource");

            var request = InstantiateClassGenerator.Execute<TagResourceRequest>(operation);
            var marshaller = new TagResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<TagResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = TagResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void TagResource_ResourceNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("TagResource");

            var request = InstantiateClassGenerator.Execute<TagResourceRequest>(operation);
            var marshaller = new TagResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<TagResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ResourceNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = TagResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void TagResource_TooManyTagsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("TagResource");

            var request = InstantiateClassGenerator.Execute<TagResourceRequest>(operation);
            var marshaller = new TagResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<TagResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyTagsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"TooManyTagsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = TagResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void TestStateMarshallTest()
        {
            var operation = service_model.FindOperation("TestState");

            var request = InstantiateClassGenerator.Execute<TestStateRequest>(operation);
            var marshaller = new TestStateRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<TestStateRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = TestStateResponseUnmarshaller.Instance.Unmarshall(context) as TestStateResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void TestState_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("TestState");

            var request = InstantiateClassGenerator.Execute<TestStateRequest>(operation);
            var marshaller = new TestStateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<TestStateRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = TestStateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void TestState_InvalidDefinitionExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("TestState");

            var request = InstantiateClassGenerator.Execute<TestStateRequest>(operation);
            var marshaller = new TestStateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<TestStateRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDefinitionException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidDefinitionException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = TestStateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void TestState_InvalidExecutionInputExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("TestState");

            var request = InstantiateClassGenerator.Execute<TestStateRequest>(operation);
            var marshaller = new TestStateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<TestStateRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidExecutionInputException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidExecutionInputException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = TestStateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void TestState_ValidationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("TestState");

            var request = InstantiateClassGenerator.Execute<TestStateRequest>(operation);
            var marshaller = new TestStateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<TestStateRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ValidationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = TestStateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void UntagResourceMarshallTest()
        {
            var operation = service_model.FindOperation("UntagResource");

            var request = InstantiateClassGenerator.Execute<UntagResourceRequest>(operation);
            var marshaller = new UntagResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<UntagResourceRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = UntagResourceResponseUnmarshaller.Instance.Unmarshall(context) as UntagResourceResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void UntagResource_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UntagResource");

            var request = InstantiateClassGenerator.Execute<UntagResourceRequest>(operation);
            var marshaller = new UntagResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UntagResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UntagResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void UntagResource_ResourceNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UntagResource");

            var request = InstantiateClassGenerator.Execute<UntagResourceRequest>(operation);
            var marshaller = new UntagResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UntagResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ResourceNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UntagResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void UpdateMapRunMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateMapRun");

            var request = InstantiateClassGenerator.Execute<UpdateMapRunRequest>(operation);
            var marshaller = new UpdateMapRunRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<UpdateMapRunRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = UpdateMapRunResponseUnmarshaller.Instance.Unmarshall(context) as UpdateMapRunResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void UpdateMapRun_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateMapRun");

            var request = InstantiateClassGenerator.Execute<UpdateMapRunRequest>(operation);
            var marshaller = new UpdateMapRunRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateMapRunRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateMapRunResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void UpdateMapRun_ResourceNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateMapRun");

            var request = InstantiateClassGenerator.Execute<UpdateMapRunRequest>(operation);
            var marshaller = new UpdateMapRunRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateMapRunRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ResourceNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateMapRunResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void UpdateMapRun_ValidationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateMapRun");

            var request = InstantiateClassGenerator.Execute<UpdateMapRunRequest>(operation);
            var marshaller = new UpdateMapRunRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateMapRunRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ValidationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateMapRunResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void UpdateStateMachineMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStateMachine");

            var request = InstantiateClassGenerator.Execute<UpdateStateMachineRequest>(operation);
            var marshaller = new UpdateStateMachineRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<UpdateStateMachineRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = UpdateStateMachineResponseUnmarshaller.Instance.Unmarshall(context) as UpdateStateMachineResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void UpdateStateMachine_ConflictExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateStateMachine");

            var request = InstantiateClassGenerator.Execute<UpdateStateMachineRequest>(operation);
            var marshaller = new UpdateStateMachineRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateStateMachineRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ConflictException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateStateMachineResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void UpdateStateMachine_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateStateMachine");

            var request = InstantiateClassGenerator.Execute<UpdateStateMachineRequest>(operation);
            var marshaller = new UpdateStateMachineRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateStateMachineRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateStateMachineResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void UpdateStateMachine_InvalidDefinitionExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateStateMachine");

            var request = InstantiateClassGenerator.Execute<UpdateStateMachineRequest>(operation);
            var marshaller = new UpdateStateMachineRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateStateMachineRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDefinitionException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidDefinitionException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateStateMachineResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void UpdateStateMachine_InvalidLoggingConfigurationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateStateMachine");

            var request = InstantiateClassGenerator.Execute<UpdateStateMachineRequest>(operation);
            var marshaller = new UpdateStateMachineRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateStateMachineRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidLoggingConfigurationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidLoggingConfigurationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateStateMachineResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void UpdateStateMachine_InvalidTracingConfigurationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateStateMachine");

            var request = InstantiateClassGenerator.Execute<UpdateStateMachineRequest>(operation);
            var marshaller = new UpdateStateMachineRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateStateMachineRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTracingConfigurationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidTracingConfigurationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateStateMachineResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void UpdateStateMachine_MissingRequiredParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateStateMachine");

            var request = InstantiateClassGenerator.Execute<UpdateStateMachineRequest>(operation);
            var marshaller = new UpdateStateMachineRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateStateMachineRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("MissingRequiredParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"MissingRequiredParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateStateMachineResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void UpdateStateMachine_ServiceQuotaExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateStateMachine");

            var request = InstantiateClassGenerator.Execute<UpdateStateMachineRequest>(operation);
            var marshaller = new UpdateStateMachineRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateStateMachineRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceQuotaExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ServiceQuotaExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateStateMachineResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void UpdateStateMachine_StateMachineDeletingExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateStateMachine");

            var request = InstantiateClassGenerator.Execute<UpdateStateMachineRequest>(operation);
            var marshaller = new UpdateStateMachineRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateStateMachineRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("StateMachineDeletingException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"StateMachineDeletingException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateStateMachineResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void UpdateStateMachine_StateMachineDoesNotExistExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateStateMachine");

            var request = InstantiateClassGenerator.Execute<UpdateStateMachineRequest>(operation);
            var marshaller = new UpdateStateMachineRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateStateMachineRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("StateMachineDoesNotExistException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"StateMachineDoesNotExistException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateStateMachineResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void UpdateStateMachine_ValidationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateStateMachine");

            var request = InstantiateClassGenerator.Execute<UpdateStateMachineRequest>(operation);
            var marshaller = new UpdateStateMachineRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateStateMachineRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ValidationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateStateMachineResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void UpdateStateMachineAliasMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStateMachineAlias");

            var request = InstantiateClassGenerator.Execute<UpdateStateMachineAliasRequest>(operation);
            var marshaller = new UpdateStateMachineAliasRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<UpdateStateMachineAliasRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = UpdateStateMachineAliasResponseUnmarshaller.Instance.Unmarshall(context) as UpdateStateMachineAliasResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void UpdateStateMachineAlias_ConflictExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateStateMachineAlias");

            var request = InstantiateClassGenerator.Execute<UpdateStateMachineAliasRequest>(operation);
            var marshaller = new UpdateStateMachineAliasRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateStateMachineAliasRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ConflictException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateStateMachineAliasResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void UpdateStateMachineAlias_InvalidArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateStateMachineAlias");

            var request = InstantiateClassGenerator.Execute<UpdateStateMachineAliasRequest>(operation);
            var marshaller = new UpdateStateMachineAliasRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateStateMachineAliasRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateStateMachineAliasResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void UpdateStateMachineAlias_ResourceNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateStateMachineAlias");

            var request = InstantiateClassGenerator.Execute<UpdateStateMachineAliasRequest>(operation);
            var marshaller = new UpdateStateMachineAliasRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateStateMachineAliasRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ResourceNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateStateMachineAliasResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void UpdateStateMachineAlias_StateMachineDeletingExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateStateMachineAlias");

            var request = InstantiateClassGenerator.Execute<UpdateStateMachineAliasRequest>(operation);
            var marshaller = new UpdateStateMachineAliasRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateStateMachineAliasRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("StateMachineDeletingException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"StateMachineDeletingException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateStateMachineAliasResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("StepFunctions")]
        public void UpdateStateMachineAlias_ValidationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateStateMachineAlias");

            var request = InstantiateClassGenerator.Execute<UpdateStateMachineAliasRequest>(operation);
            var marshaller = new UpdateStateMachineAliasRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateStateMachineAliasRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ValidationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateStateMachineAliasResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}