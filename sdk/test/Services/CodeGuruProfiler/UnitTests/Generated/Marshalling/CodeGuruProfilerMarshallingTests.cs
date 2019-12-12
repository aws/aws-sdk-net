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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.CodeGuruProfiler;
using Amazon.CodeGuruProfiler.Model;
using Amazon.CodeGuruProfiler.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class CodeGuruProfilerMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("codeguruprofiler");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CodeGuruProfiler")]
        public void ConfigureAgentMarshallTest()
        {
            var operation = service_model.FindOperation("ConfigureAgent");

            var request = InstantiateClassGenerator.Execute<ConfigureAgentRequest>();
            var marshaller = new ConfigureAgentRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ConfigureAgent", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ConfigureAgentResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ConfigureAgentResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CodeGuruProfiler")]
        public void CreateProfilingGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateProfilingGroup");

            var request = InstantiateClassGenerator.Execute<CreateProfilingGroupRequest>();
            var marshaller = new CreateProfilingGroupRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateProfilingGroup", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateProfilingGroupResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateProfilingGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CodeGuruProfiler")]
        public void DeleteProfilingGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteProfilingGroup");

            var request = InstantiateClassGenerator.Execute<DeleteProfilingGroupRequest>();
            var marshaller = new DeleteProfilingGroupRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteProfilingGroup", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DeleteProfilingGroupResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteProfilingGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CodeGuruProfiler")]
        public void DescribeProfilingGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeProfilingGroup");

            var request = InstantiateClassGenerator.Execute<DescribeProfilingGroupRequest>();
            var marshaller = new DescribeProfilingGroupRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeProfilingGroup", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeProfilingGroupResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeProfilingGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CodeGuruProfiler")]
        public void GetProfileMarshallTest()
        {
            var operation = service_model.FindOperation("GetProfile");

            var request = InstantiateClassGenerator.Execute<GetProfileRequest>();
            var marshaller = new GetProfileRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetProfile", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Encoding","Content-Encoding_Value"},
                    {"Content-Type","Content-Type_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetProfileResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetProfileResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CodeGuruProfiler")]
        public void ListProfileTimesMarshallTest()
        {
            var operation = service_model.FindOperation("ListProfileTimes");

            var request = InstantiateClassGenerator.Execute<ListProfileTimesRequest>();
            var marshaller = new ListProfileTimesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListProfileTimes", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListProfileTimesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListProfileTimesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CodeGuruProfiler")]
        public void ListProfilingGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("ListProfilingGroups");

            var request = InstantiateClassGenerator.Execute<ListProfilingGroupsRequest>();
            var marshaller = new ListProfilingGroupsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListProfilingGroups", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = ListProfilingGroupsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListProfilingGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CodeGuruProfiler")]
        public void PostAgentProfileMarshallTest()
        {
            var operation = service_model.FindOperation("PostAgentProfile");

            var request = InstantiateClassGenerator.Execute<PostAgentProfileRequest>();
            var marshaller = new PostAgentProfileRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PostAgentProfile", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = PostAgentProfileResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PostAgentProfileResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("CodeGuruProfiler")]
        public void UpdateProfilingGroupMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateProfilingGroup");

            var request = InstantiateClassGenerator.Execute<UpdateProfilingGroupRequest>();
            var marshaller = new UpdateProfilingGroupRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateProfilingGroup", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = UpdateProfilingGroupResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateProfilingGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

            }
}