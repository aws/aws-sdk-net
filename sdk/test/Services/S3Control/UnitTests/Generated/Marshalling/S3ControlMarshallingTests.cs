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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.S3Control;
using Amazon.S3Control.Model;
using Amazon.S3Control.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class S3ControlMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("s3control");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void CreateAccessPointMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAccessPoint");

            var request = InstantiateClassGenerator.Execute<CreateAccessPointRequest>();
            var marshaller = new CreateAccessPointRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateAccessPoint", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void CreateJobMarshallTest()
        {
            var operation = service_model.FindOperation("CreateJob");

            var request = InstantiateClassGenerator.Execute<CreateJobRequest>();
            var marshaller = new CreateJobRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateJob", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateJobResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateJobResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void DeleteAccessPointMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAccessPoint");

            var request = InstantiateClassGenerator.Execute<DeleteAccessPointRequest>();
            var marshaller = new DeleteAccessPointRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteAccessPoint", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void DeleteAccessPointPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAccessPointPolicy");

            var request = InstantiateClassGenerator.Execute<DeleteAccessPointPolicyRequest>();
            var marshaller = new DeleteAccessPointPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteAccessPointPolicy", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void DeletePublicAccessBlockMarshallTest()
        {
            var operation = service_model.FindOperation("DeletePublicAccessBlock");

            var request = InstantiateClassGenerator.Execute<DeletePublicAccessBlockRequest>();
            var marshaller = new DeletePublicAccessBlockRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeletePublicAccessBlock", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void DescribeJobMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeJob");

            var request = InstantiateClassGenerator.Execute<DescribeJobRequest>();
            var marshaller = new DescribeJobRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeJob", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeJobResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeJobResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void GetAccessPointMarshallTest()
        {
            var operation = service_model.FindOperation("GetAccessPoint");

            var request = InstantiateClassGenerator.Execute<GetAccessPointRequest>();
            var marshaller = new GetAccessPointRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetAccessPoint", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetAccessPointResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetAccessPointResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void GetAccessPointPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("GetAccessPointPolicy");

            var request = InstantiateClassGenerator.Execute<GetAccessPointPolicyRequest>();
            var marshaller = new GetAccessPointPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetAccessPointPolicy", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetAccessPointPolicyResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetAccessPointPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void GetAccessPointPolicyStatusMarshallTest()
        {
            var operation = service_model.FindOperation("GetAccessPointPolicyStatus");

            var request = InstantiateClassGenerator.Execute<GetAccessPointPolicyStatusRequest>();
            var marshaller = new GetAccessPointPolicyStatusRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetAccessPointPolicyStatus", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetAccessPointPolicyStatusResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetAccessPointPolicyStatusResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void GetPublicAccessBlockMarshallTest()
        {
            var operation = service_model.FindOperation("GetPublicAccessBlock");

            var request = InstantiateClassGenerator.Execute<GetPublicAccessBlockRequest>();
            var marshaller = new GetPublicAccessBlockRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetPublicAccessBlock", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetPublicAccessBlockResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetPublicAccessBlockResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void ListAccessPointsMarshallTest()
        {
            var operation = service_model.FindOperation("ListAccessPoints");

            var request = InstantiateClassGenerator.Execute<ListAccessPointsRequest>();
            var marshaller = new ListAccessPointsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListAccessPoints", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListAccessPointsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListAccessPointsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void ListJobsMarshallTest()
        {
            var operation = service_model.FindOperation("ListJobs");

            var request = InstantiateClassGenerator.Execute<ListJobsRequest>();
            var marshaller = new ListJobsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListJobs", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListJobsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListJobsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void PutAccessPointPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("PutAccessPointPolicy");

            var request = InstantiateClassGenerator.Execute<PutAccessPointPolicyRequest>();
            var marshaller = new PutAccessPointPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutAccessPointPolicy", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void PutPublicAccessBlockMarshallTest()
        {
            var operation = service_model.FindOperation("PutPublicAccessBlock");

            var request = InstantiateClassGenerator.Execute<PutPublicAccessBlockRequest>();
            var marshaller = new PutPublicAccessBlockRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutPublicAccessBlock", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void UpdateJobPriorityMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateJobPriority");

            var request = InstantiateClassGenerator.Execute<UpdateJobPriorityRequest>();
            var marshaller = new UpdateJobPriorityRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateJobPriority", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UpdateJobPriorityResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateJobPriorityResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void UpdateJobStatusMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateJobStatus");

            var request = InstantiateClassGenerator.Execute<UpdateJobStatusRequest>();
            var marshaller = new UpdateJobStatusRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateJobStatus", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UpdateJobStatusResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateJobStatusResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

            }
}