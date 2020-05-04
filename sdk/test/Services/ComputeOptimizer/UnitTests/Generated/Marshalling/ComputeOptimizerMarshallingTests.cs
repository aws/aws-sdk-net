/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */


using System;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.ComputeOptimizer;
using Amazon.ComputeOptimizer.Model;
using Amazon.ComputeOptimizer.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class ComputeOptimizerMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("compute-optimizer");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetAutoScalingGroupRecommendationsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetAutoScalingGroupRecommendationsRequest>();
            var marshaller = new GetAutoScalingGroupRecommendationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<GetAutoScalingGroupRecommendationsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetAutoScalingGroupRecommendations").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetAutoScalingGroupRecommendationsResponseUnmarshaller.Instance.Unmarshall(context)
                as GetAutoScalingGroupRecommendationsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetAutoScalingGroupRecommendations_AccessDeniedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetAutoScalingGroupRecommendations");

            var request = InstantiateClassGenerator.Execute<GetAutoScalingGroupRecommendationsRequest>();
            var marshaller = new GetAutoScalingGroupRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetAutoScalingGroupRecommendationsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AccessDeniedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetAutoScalingGroupRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetAutoScalingGroupRecommendations_InternalServerExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetAutoScalingGroupRecommendations");

            var request = InstantiateClassGenerator.Execute<GetAutoScalingGroupRecommendationsRequest>();
            var marshaller = new GetAutoScalingGroupRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetAutoScalingGroupRecommendationsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServerException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalServerException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetAutoScalingGroupRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetAutoScalingGroupRecommendations_InvalidParameterValueExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetAutoScalingGroupRecommendations");

            var request = InstantiateClassGenerator.Execute<GetAutoScalingGroupRecommendationsRequest>();
            var marshaller = new GetAutoScalingGroupRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetAutoScalingGroupRecommendationsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterValueException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidParameterValueException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetAutoScalingGroupRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetAutoScalingGroupRecommendations_MissingAuthenticationTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetAutoScalingGroupRecommendations");

            var request = InstantiateClassGenerator.Execute<GetAutoScalingGroupRecommendationsRequest>();
            var marshaller = new GetAutoScalingGroupRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetAutoScalingGroupRecommendationsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("MissingAuthenticationTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","MissingAuthenticationTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetAutoScalingGroupRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetAutoScalingGroupRecommendations_OptInRequiredExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetAutoScalingGroupRecommendations");

            var request = InstantiateClassGenerator.Execute<GetAutoScalingGroupRecommendationsRequest>();
            var marshaller = new GetAutoScalingGroupRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetAutoScalingGroupRecommendationsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OptInRequiredException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OptInRequiredException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetAutoScalingGroupRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetAutoScalingGroupRecommendations_ResourceNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetAutoScalingGroupRecommendations");

            var request = InstantiateClassGenerator.Execute<GetAutoScalingGroupRecommendationsRequest>();
            var marshaller = new GetAutoScalingGroupRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetAutoScalingGroupRecommendationsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetAutoScalingGroupRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetAutoScalingGroupRecommendations_ServiceUnavailableExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetAutoScalingGroupRecommendations");

            var request = InstantiateClassGenerator.Execute<GetAutoScalingGroupRecommendationsRequest>();
            var marshaller = new GetAutoScalingGroupRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetAutoScalingGroupRecommendationsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceUnavailableException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceUnavailableException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetAutoScalingGroupRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetAutoScalingGroupRecommendations_ThrottlingExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetAutoScalingGroupRecommendations");

            var request = InstantiateClassGenerator.Execute<GetAutoScalingGroupRecommendationsRequest>();
            var marshaller = new GetAutoScalingGroupRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetAutoScalingGroupRecommendationsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetAutoScalingGroupRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetEC2InstanceRecommendationsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetEC2InstanceRecommendationsRequest>();
            var marshaller = new GetEC2InstanceRecommendationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<GetEC2InstanceRecommendationsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetEC2InstanceRecommendations").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetEC2InstanceRecommendationsResponseUnmarshaller.Instance.Unmarshall(context)
                as GetEC2InstanceRecommendationsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetEC2InstanceRecommendations_AccessDeniedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEC2InstanceRecommendations");

            var request = InstantiateClassGenerator.Execute<GetEC2InstanceRecommendationsRequest>();
            var marshaller = new GetEC2InstanceRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEC2InstanceRecommendationsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AccessDeniedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEC2InstanceRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetEC2InstanceRecommendations_InternalServerExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEC2InstanceRecommendations");

            var request = InstantiateClassGenerator.Execute<GetEC2InstanceRecommendationsRequest>();
            var marshaller = new GetEC2InstanceRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEC2InstanceRecommendationsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServerException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalServerException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEC2InstanceRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetEC2InstanceRecommendations_InvalidParameterValueExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEC2InstanceRecommendations");

            var request = InstantiateClassGenerator.Execute<GetEC2InstanceRecommendationsRequest>();
            var marshaller = new GetEC2InstanceRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEC2InstanceRecommendationsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterValueException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidParameterValueException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEC2InstanceRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetEC2InstanceRecommendations_MissingAuthenticationTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEC2InstanceRecommendations");

            var request = InstantiateClassGenerator.Execute<GetEC2InstanceRecommendationsRequest>();
            var marshaller = new GetEC2InstanceRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEC2InstanceRecommendationsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("MissingAuthenticationTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","MissingAuthenticationTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEC2InstanceRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetEC2InstanceRecommendations_OptInRequiredExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEC2InstanceRecommendations");

            var request = InstantiateClassGenerator.Execute<GetEC2InstanceRecommendationsRequest>();
            var marshaller = new GetEC2InstanceRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEC2InstanceRecommendationsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OptInRequiredException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OptInRequiredException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEC2InstanceRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetEC2InstanceRecommendations_ResourceNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEC2InstanceRecommendations");

            var request = InstantiateClassGenerator.Execute<GetEC2InstanceRecommendationsRequest>();
            var marshaller = new GetEC2InstanceRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEC2InstanceRecommendationsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEC2InstanceRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetEC2InstanceRecommendations_ServiceUnavailableExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEC2InstanceRecommendations");

            var request = InstantiateClassGenerator.Execute<GetEC2InstanceRecommendationsRequest>();
            var marshaller = new GetEC2InstanceRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEC2InstanceRecommendationsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceUnavailableException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceUnavailableException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEC2InstanceRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetEC2InstanceRecommendations_ThrottlingExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEC2InstanceRecommendations");

            var request = InstantiateClassGenerator.Execute<GetEC2InstanceRecommendationsRequest>();
            var marshaller = new GetEC2InstanceRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEC2InstanceRecommendationsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEC2InstanceRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetEC2RecommendationProjectedMetricsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetEC2RecommendationProjectedMetricsRequest>();
            var marshaller = new GetEC2RecommendationProjectedMetricsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<GetEC2RecommendationProjectedMetricsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetEC2RecommendationProjectedMetrics").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetEC2RecommendationProjectedMetricsResponseUnmarshaller.Instance.Unmarshall(context)
                as GetEC2RecommendationProjectedMetricsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetEC2RecommendationProjectedMetrics_AccessDeniedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEC2RecommendationProjectedMetrics");

            var request = InstantiateClassGenerator.Execute<GetEC2RecommendationProjectedMetricsRequest>();
            var marshaller = new GetEC2RecommendationProjectedMetricsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEC2RecommendationProjectedMetricsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AccessDeniedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEC2RecommendationProjectedMetricsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetEC2RecommendationProjectedMetrics_InternalServerExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEC2RecommendationProjectedMetrics");

            var request = InstantiateClassGenerator.Execute<GetEC2RecommendationProjectedMetricsRequest>();
            var marshaller = new GetEC2RecommendationProjectedMetricsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEC2RecommendationProjectedMetricsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServerException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalServerException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEC2RecommendationProjectedMetricsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetEC2RecommendationProjectedMetrics_InvalidParameterValueExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEC2RecommendationProjectedMetrics");

            var request = InstantiateClassGenerator.Execute<GetEC2RecommendationProjectedMetricsRequest>();
            var marshaller = new GetEC2RecommendationProjectedMetricsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEC2RecommendationProjectedMetricsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterValueException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidParameterValueException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEC2RecommendationProjectedMetricsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetEC2RecommendationProjectedMetrics_MissingAuthenticationTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEC2RecommendationProjectedMetrics");

            var request = InstantiateClassGenerator.Execute<GetEC2RecommendationProjectedMetricsRequest>();
            var marshaller = new GetEC2RecommendationProjectedMetricsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEC2RecommendationProjectedMetricsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("MissingAuthenticationTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","MissingAuthenticationTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEC2RecommendationProjectedMetricsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetEC2RecommendationProjectedMetrics_OptInRequiredExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEC2RecommendationProjectedMetrics");

            var request = InstantiateClassGenerator.Execute<GetEC2RecommendationProjectedMetricsRequest>();
            var marshaller = new GetEC2RecommendationProjectedMetricsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEC2RecommendationProjectedMetricsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OptInRequiredException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OptInRequiredException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEC2RecommendationProjectedMetricsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetEC2RecommendationProjectedMetrics_ResourceNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEC2RecommendationProjectedMetrics");

            var request = InstantiateClassGenerator.Execute<GetEC2RecommendationProjectedMetricsRequest>();
            var marshaller = new GetEC2RecommendationProjectedMetricsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEC2RecommendationProjectedMetricsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEC2RecommendationProjectedMetricsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetEC2RecommendationProjectedMetrics_ServiceUnavailableExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEC2RecommendationProjectedMetrics");

            var request = InstantiateClassGenerator.Execute<GetEC2RecommendationProjectedMetricsRequest>();
            var marshaller = new GetEC2RecommendationProjectedMetricsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEC2RecommendationProjectedMetricsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceUnavailableException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceUnavailableException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEC2RecommendationProjectedMetricsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetEC2RecommendationProjectedMetrics_ThrottlingExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEC2RecommendationProjectedMetrics");

            var request = InstantiateClassGenerator.Execute<GetEC2RecommendationProjectedMetricsRequest>();
            var marshaller = new GetEC2RecommendationProjectedMetricsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEC2RecommendationProjectedMetricsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEC2RecommendationProjectedMetricsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetEnrollmentStatusMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetEnrollmentStatusRequest>();
            var marshaller = new GetEnrollmentStatusRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<GetEnrollmentStatusRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetEnrollmentStatus").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetEnrollmentStatusResponseUnmarshaller.Instance.Unmarshall(context)
                as GetEnrollmentStatusResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetEnrollmentStatus_AccessDeniedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEnrollmentStatus");

            var request = InstantiateClassGenerator.Execute<GetEnrollmentStatusRequest>();
            var marshaller = new GetEnrollmentStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEnrollmentStatusRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AccessDeniedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEnrollmentStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetEnrollmentStatus_InternalServerExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEnrollmentStatus");

            var request = InstantiateClassGenerator.Execute<GetEnrollmentStatusRequest>();
            var marshaller = new GetEnrollmentStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEnrollmentStatusRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServerException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalServerException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEnrollmentStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetEnrollmentStatus_InvalidParameterValueExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEnrollmentStatus");

            var request = InstantiateClassGenerator.Execute<GetEnrollmentStatusRequest>();
            var marshaller = new GetEnrollmentStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEnrollmentStatusRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterValueException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidParameterValueException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEnrollmentStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetEnrollmentStatus_MissingAuthenticationTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEnrollmentStatus");

            var request = InstantiateClassGenerator.Execute<GetEnrollmentStatusRequest>();
            var marshaller = new GetEnrollmentStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEnrollmentStatusRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("MissingAuthenticationTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","MissingAuthenticationTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEnrollmentStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetEnrollmentStatus_ServiceUnavailableExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEnrollmentStatus");

            var request = InstantiateClassGenerator.Execute<GetEnrollmentStatusRequest>();
            var marshaller = new GetEnrollmentStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEnrollmentStatusRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceUnavailableException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceUnavailableException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEnrollmentStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetEnrollmentStatus_ThrottlingExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEnrollmentStatus");

            var request = InstantiateClassGenerator.Execute<GetEnrollmentStatusRequest>();
            var marshaller = new GetEnrollmentStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEnrollmentStatusRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEnrollmentStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetRecommendationSummariesMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetRecommendationSummariesRequest>();
            var marshaller = new GetRecommendationSummariesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<GetRecommendationSummariesRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetRecommendationSummaries").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetRecommendationSummariesResponseUnmarshaller.Instance.Unmarshall(context)
                as GetRecommendationSummariesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetRecommendationSummaries_AccessDeniedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetRecommendationSummaries");

            var request = InstantiateClassGenerator.Execute<GetRecommendationSummariesRequest>();
            var marshaller = new GetRecommendationSummariesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetRecommendationSummariesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AccessDeniedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetRecommendationSummariesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetRecommendationSummaries_InternalServerExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetRecommendationSummaries");

            var request = InstantiateClassGenerator.Execute<GetRecommendationSummariesRequest>();
            var marshaller = new GetRecommendationSummariesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetRecommendationSummariesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServerException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalServerException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetRecommendationSummariesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetRecommendationSummaries_InvalidParameterValueExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetRecommendationSummaries");

            var request = InstantiateClassGenerator.Execute<GetRecommendationSummariesRequest>();
            var marshaller = new GetRecommendationSummariesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetRecommendationSummariesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterValueException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidParameterValueException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetRecommendationSummariesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetRecommendationSummaries_MissingAuthenticationTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetRecommendationSummaries");

            var request = InstantiateClassGenerator.Execute<GetRecommendationSummariesRequest>();
            var marshaller = new GetRecommendationSummariesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetRecommendationSummariesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("MissingAuthenticationTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","MissingAuthenticationTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetRecommendationSummariesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetRecommendationSummaries_OptInRequiredExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetRecommendationSummaries");

            var request = InstantiateClassGenerator.Execute<GetRecommendationSummariesRequest>();
            var marshaller = new GetRecommendationSummariesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetRecommendationSummariesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OptInRequiredException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OptInRequiredException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetRecommendationSummariesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetRecommendationSummaries_ServiceUnavailableExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetRecommendationSummaries");

            var request = InstantiateClassGenerator.Execute<GetRecommendationSummariesRequest>();
            var marshaller = new GetRecommendationSummariesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetRecommendationSummariesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceUnavailableException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceUnavailableException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetRecommendationSummariesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void GetRecommendationSummaries_ThrottlingExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetRecommendationSummaries");

            var request = InstantiateClassGenerator.Execute<GetRecommendationSummariesRequest>();
            var marshaller = new GetRecommendationSummariesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetRecommendationSummariesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetRecommendationSummariesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void UpdateEnrollmentStatusMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<UpdateEnrollmentStatusRequest>();
            var marshaller = new UpdateEnrollmentStatusRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<UpdateEnrollmentStatusRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("UpdateEnrollmentStatus").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = UpdateEnrollmentStatusResponseUnmarshaller.Instance.Unmarshall(context)
                as UpdateEnrollmentStatusResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void UpdateEnrollmentStatus_AccessDeniedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateEnrollmentStatus");

            var request = InstantiateClassGenerator.Execute<UpdateEnrollmentStatusRequest>();
            var marshaller = new UpdateEnrollmentStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateEnrollmentStatusRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AccessDeniedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateEnrollmentStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void UpdateEnrollmentStatus_InternalServerExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateEnrollmentStatus");

            var request = InstantiateClassGenerator.Execute<UpdateEnrollmentStatusRequest>();
            var marshaller = new UpdateEnrollmentStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateEnrollmentStatusRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServerException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalServerException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateEnrollmentStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void UpdateEnrollmentStatus_InvalidParameterValueExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateEnrollmentStatus");

            var request = InstantiateClassGenerator.Execute<UpdateEnrollmentStatusRequest>();
            var marshaller = new UpdateEnrollmentStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateEnrollmentStatusRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterValueException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidParameterValueException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateEnrollmentStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void UpdateEnrollmentStatus_MissingAuthenticationTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateEnrollmentStatus");

            var request = InstantiateClassGenerator.Execute<UpdateEnrollmentStatusRequest>();
            var marshaller = new UpdateEnrollmentStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateEnrollmentStatusRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("MissingAuthenticationTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","MissingAuthenticationTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateEnrollmentStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void UpdateEnrollmentStatus_ServiceUnavailableExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateEnrollmentStatus");

            var request = InstantiateClassGenerator.Execute<UpdateEnrollmentStatusRequest>();
            var marshaller = new UpdateEnrollmentStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateEnrollmentStatusRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ServiceUnavailableException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ServiceUnavailableException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateEnrollmentStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("ComputeOptimizer")]
        public void UpdateEnrollmentStatus_ThrottlingExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateEnrollmentStatus");

            var request = InstantiateClassGenerator.Execute<UpdateEnrollmentStatusRequest>();
            var marshaller = new UpdateEnrollmentStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateEnrollmentStatusRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateEnrollmentStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}