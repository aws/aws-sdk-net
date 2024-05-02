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
 * Do not modify this file. This file is generated from the ec2-instance-connect-2018-04-02.normal.json service model.
 */


using System;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.EC2InstanceConnect;
using Amazon.EC2InstanceConnect.Model;
using Amazon.EC2InstanceConnect.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet.UnitTests.TestTools;

namespace AWSSDK_DotNet.UnitTests.Marshalling
{
    [TestClass]
    public class EC2InstanceConnectMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("ec2-instance-connect");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("EC2InstanceConnect")]
        public void SendSerialConsoleSSHPublicKeyMarshallTest()
        {
            var operation = service_model.FindOperation("SendSerialConsoleSSHPublicKey");

            var request = InstantiateClassGenerator.Execute<SendSerialConsoleSSHPublicKeyRequest>(operation);
            var marshaller = new SendSerialConsoleSSHPublicKeyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<SendSerialConsoleSSHPublicKeyRequest>(request,jsonRequest);

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
            var response = SendSerialConsoleSSHPublicKeyResponseUnmarshaller.Instance.Unmarshall(context) as SendSerialConsoleSSHPublicKeyResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("EC2InstanceConnect")]
        public void SendSerialConsoleSSHPublicKey_AuthExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendSerialConsoleSSHPublicKey");

            var request = InstantiateClassGenerator.Execute<SendSerialConsoleSSHPublicKeyRequest>(operation);
            var marshaller = new SendSerialConsoleSSHPublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendSerialConsoleSSHPublicKeyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AuthException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"AuthException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendSerialConsoleSSHPublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("EC2InstanceConnect")]
        public void SendSerialConsoleSSHPublicKey_EC2InstanceNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendSerialConsoleSSHPublicKey");

            var request = InstantiateClassGenerator.Execute<SendSerialConsoleSSHPublicKeyRequest>(operation);
            var marshaller = new SendSerialConsoleSSHPublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendSerialConsoleSSHPublicKeyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EC2InstanceNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"EC2InstanceNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendSerialConsoleSSHPublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("EC2InstanceConnect")]
        public void SendSerialConsoleSSHPublicKey_EC2InstanceStateInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendSerialConsoleSSHPublicKey");

            var request = InstantiateClassGenerator.Execute<SendSerialConsoleSSHPublicKeyRequest>(operation);
            var marshaller = new SendSerialConsoleSSHPublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendSerialConsoleSSHPublicKeyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EC2InstanceStateInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"EC2InstanceStateInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendSerialConsoleSSHPublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("EC2InstanceConnect")]
        public void SendSerialConsoleSSHPublicKey_EC2InstanceTypeInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendSerialConsoleSSHPublicKey");

            var request = InstantiateClassGenerator.Execute<SendSerialConsoleSSHPublicKeyRequest>(operation);
            var marshaller = new SendSerialConsoleSSHPublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendSerialConsoleSSHPublicKeyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EC2InstanceTypeInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"EC2InstanceTypeInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendSerialConsoleSSHPublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("EC2InstanceConnect")]
        public void SendSerialConsoleSSHPublicKey_EC2InstanceUnavailableExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendSerialConsoleSSHPublicKey");

            var request = InstantiateClassGenerator.Execute<SendSerialConsoleSSHPublicKeyRequest>(operation);
            var marshaller = new SendSerialConsoleSSHPublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendSerialConsoleSSHPublicKeyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EC2InstanceUnavailableException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"EC2InstanceUnavailableException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendSerialConsoleSSHPublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("EC2InstanceConnect")]
        public void SendSerialConsoleSSHPublicKey_InvalidArgsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendSerialConsoleSSHPublicKey");

            var request = InstantiateClassGenerator.Execute<SendSerialConsoleSSHPublicKeyRequest>(operation);
            var marshaller = new SendSerialConsoleSSHPublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendSerialConsoleSSHPublicKeyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArgsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendSerialConsoleSSHPublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("EC2InstanceConnect")]
        public void SendSerialConsoleSSHPublicKey_SerialConsoleAccessDisabledExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendSerialConsoleSSHPublicKey");

            var request = InstantiateClassGenerator.Execute<SendSerialConsoleSSHPublicKeyRequest>(operation);
            var marshaller = new SendSerialConsoleSSHPublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendSerialConsoleSSHPublicKeyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("SerialConsoleAccessDisabledException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"SerialConsoleAccessDisabledException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendSerialConsoleSSHPublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("EC2InstanceConnect")]
        public void SendSerialConsoleSSHPublicKey_SerialConsoleSessionLimitExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendSerialConsoleSSHPublicKey");

            var request = InstantiateClassGenerator.Execute<SendSerialConsoleSSHPublicKeyRequest>(operation);
            var marshaller = new SendSerialConsoleSSHPublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendSerialConsoleSSHPublicKeyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("SerialConsoleSessionLimitExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"SerialConsoleSessionLimitExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendSerialConsoleSSHPublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("EC2InstanceConnect")]
        public void SendSerialConsoleSSHPublicKey_SerialConsoleSessionUnavailableExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendSerialConsoleSSHPublicKey");

            var request = InstantiateClassGenerator.Execute<SendSerialConsoleSSHPublicKeyRequest>(operation);
            var marshaller = new SendSerialConsoleSSHPublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendSerialConsoleSSHPublicKeyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("SerialConsoleSessionUnavailableException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"SerialConsoleSessionUnavailableException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendSerialConsoleSSHPublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("EC2InstanceConnect")]
        public void SendSerialConsoleSSHPublicKey_SerialConsoleSessionUnsupportedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendSerialConsoleSSHPublicKey");

            var request = InstantiateClassGenerator.Execute<SendSerialConsoleSSHPublicKeyRequest>(operation);
            var marshaller = new SendSerialConsoleSSHPublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendSerialConsoleSSHPublicKeyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("SerialConsoleSessionUnsupportedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"SerialConsoleSessionUnsupportedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendSerialConsoleSSHPublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("EC2InstanceConnect")]
        public void SendSerialConsoleSSHPublicKey_ServiceExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendSerialConsoleSSHPublicKey");

            var request = InstantiateClassGenerator.Execute<SendSerialConsoleSSHPublicKeyRequest>(operation);
            var marshaller = new SendSerialConsoleSSHPublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendSerialConsoleSSHPublicKeyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ServiceException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendSerialConsoleSSHPublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("EC2InstanceConnect")]
        public void SendSerialConsoleSSHPublicKey_ThrottlingExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendSerialConsoleSSHPublicKey");

            var request = InstantiateClassGenerator.Execute<SendSerialConsoleSSHPublicKeyRequest>(operation);
            var marshaller = new SendSerialConsoleSSHPublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendSerialConsoleSSHPublicKeyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ThrottlingException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendSerialConsoleSSHPublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("EC2InstanceConnect")]
        public void SendSSHPublicKeyMarshallTest()
        {
            var operation = service_model.FindOperation("SendSSHPublicKey");

            var request = InstantiateClassGenerator.Execute<SendSSHPublicKeyRequest>(operation);
            var marshaller = new SendSSHPublicKeyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<SendSSHPublicKeyRequest>(request,jsonRequest);

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
            var response = SendSSHPublicKeyResponseUnmarshaller.Instance.Unmarshall(context) as SendSSHPublicKeyResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("EC2InstanceConnect")]
        public void SendSSHPublicKey_AuthExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendSSHPublicKey");

            var request = InstantiateClassGenerator.Execute<SendSSHPublicKeyRequest>(operation);
            var marshaller = new SendSSHPublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendSSHPublicKeyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AuthException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"AuthException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendSSHPublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("EC2InstanceConnect")]
        public void SendSSHPublicKey_EC2InstanceNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendSSHPublicKey");

            var request = InstantiateClassGenerator.Execute<SendSSHPublicKeyRequest>(operation);
            var marshaller = new SendSSHPublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendSSHPublicKeyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EC2InstanceNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"EC2InstanceNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendSSHPublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("EC2InstanceConnect")]
        public void SendSSHPublicKey_EC2InstanceStateInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendSSHPublicKey");

            var request = InstantiateClassGenerator.Execute<SendSSHPublicKeyRequest>(operation);
            var marshaller = new SendSSHPublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendSSHPublicKeyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EC2InstanceStateInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"EC2InstanceStateInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendSSHPublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("EC2InstanceConnect")]
        public void SendSSHPublicKey_EC2InstanceUnavailableExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendSSHPublicKey");

            var request = InstantiateClassGenerator.Execute<SendSSHPublicKeyRequest>(operation);
            var marshaller = new SendSSHPublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendSSHPublicKeyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EC2InstanceUnavailableException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"EC2InstanceUnavailableException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendSSHPublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("EC2InstanceConnect")]
        public void SendSSHPublicKey_InvalidArgsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendSSHPublicKey");

            var request = InstantiateClassGenerator.Execute<SendSSHPublicKeyRequest>(operation);
            var marshaller = new SendSSHPublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendSSHPublicKeyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"InvalidArgsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendSSHPublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("EC2InstanceConnect")]
        public void SendSSHPublicKey_ServiceExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendSSHPublicKey");

            var request = InstantiateClassGenerator.Execute<SendSSHPublicKeyRequest>(operation);
            var marshaller = new SendSSHPublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendSSHPublicKeyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ServiceException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendSSHPublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("EC2InstanceConnect")]
        public void SendSSHPublicKey_ThrottlingExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("SendSSHPublicKey");

            var request = InstantiateClassGenerator.Execute<SendSSHPublicKeyRequest>(operation);
            var marshaller = new SendSSHPublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<SendSSHPublicKeyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {HeaderKeys.RequestIdHeader, Guid.NewGuid().ToString()},
                    {HeaderKeys.XAmzCrc32,"0"},
                    {HeaderKeys.XAmzErrorType,"ThrottlingException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = SendSSHPublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}