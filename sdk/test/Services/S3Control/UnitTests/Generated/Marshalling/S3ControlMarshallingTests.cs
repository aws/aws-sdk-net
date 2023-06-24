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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Linq;
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

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateAccessPointResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as CreateAccessPointResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void CreateAccessPointForObjectLambdaMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAccessPointForObjectLambda");

            var request = InstantiateClassGenerator.Execute<CreateAccessPointForObjectLambdaRequest>();
            var marshaller = new CreateAccessPointForObjectLambdaRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateAccessPointForObjectLambda", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateAccessPointForObjectLambdaResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as CreateAccessPointForObjectLambdaResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void CreateBucketMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBucket");

            var request = InstantiateClassGenerator.Execute<CreateBucketRequest>();
            var marshaller = new CreateBucketRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateBucket", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateBucketResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as CreateBucketResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void CreateBucket_BucketAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBucket");

            var request = InstantiateClassGenerator.Execute<CreateBucketRequest>();
            var marshaller = new CreateBucketRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateBucket", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("BucketAlreadyExistsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateBucketResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void CreateBucket_BucketAlreadyOwnedByYouExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateBucket");

            var request = InstantiateClassGenerator.Execute<CreateBucketRequest>();
            var marshaller = new CreateBucketRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateBucket", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("BucketAlreadyOwnedByYouException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateBucketResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
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
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateJobResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as CreateJobResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void CreateJob_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateJob");

            var request = InstantiateClassGenerator.Execute<CreateJobRequest>();
            var marshaller = new CreateJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateJob", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("BadRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void CreateJob_IdempotencyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateJob");

            var request = InstantiateClassGenerator.Execute<CreateJobRequest>();
            var marshaller = new CreateJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateJob", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("IdempotencyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void CreateJob_InternalServiceExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateJob");

            var request = InstantiateClassGenerator.Execute<CreateJobRequest>();
            var marshaller = new CreateJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateJob", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServiceException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void CreateJob_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateJob");

            var request = InstantiateClassGenerator.Execute<CreateJobRequest>();
            var marshaller = new CreateJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateJob", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void CreateMultiRegionAccessPointMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMultiRegionAccessPoint");

            var request = InstantiateClassGenerator.Execute<CreateMultiRegionAccessPointRequest>();
            var marshaller = new CreateMultiRegionAccessPointRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateMultiRegionAccessPoint", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateMultiRegionAccessPointResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as CreateMultiRegionAccessPointResponse;
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
        public void DeleteAccessPointForObjectLambdaMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAccessPointForObjectLambda");

            var request = InstantiateClassGenerator.Execute<DeleteAccessPointForObjectLambdaRequest>();
            var marshaller = new DeleteAccessPointForObjectLambdaRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteAccessPointForObjectLambda", request, internalRequest, service_model);

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
        public void DeleteAccessPointPolicyForObjectLambdaMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAccessPointPolicyForObjectLambda");

            var request = InstantiateClassGenerator.Execute<DeleteAccessPointPolicyForObjectLambdaRequest>();
            var marshaller = new DeleteAccessPointPolicyForObjectLambdaRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteAccessPointPolicyForObjectLambda", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void DeleteBucketMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBucket");

            var request = InstantiateClassGenerator.Execute<DeleteBucketRequest>();
            var marshaller = new DeleteBucketRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteBucket", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void DeleteBucketLifecycleConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBucketLifecycleConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteBucketLifecycleConfigurationRequest>();
            var marshaller = new DeleteBucketLifecycleConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteBucketLifecycleConfiguration", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void DeleteBucketPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBucketPolicy");

            var request = InstantiateClassGenerator.Execute<DeleteBucketPolicyRequest>();
            var marshaller = new DeleteBucketPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteBucketPolicy", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void DeleteBucketReplicationMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBucketReplication");

            var request = InstantiateClassGenerator.Execute<DeleteBucketReplicationRequest>();
            var marshaller = new DeleteBucketReplicationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteBucketReplication", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void DeleteBucketTaggingMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteBucketTagging");

            var request = InstantiateClassGenerator.Execute<DeleteBucketTaggingRequest>();
            var marshaller = new DeleteBucketTaggingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteBucketTagging", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void DeleteJobTaggingMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteJobTagging");

            var request = InstantiateClassGenerator.Execute<DeleteJobTaggingRequest>();
            var marshaller = new DeleteJobTaggingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteJobTagging", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DeleteJobTaggingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DeleteJobTaggingResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void DeleteJobTagging_InternalServiceExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteJobTagging");

            var request = InstantiateClassGenerator.Execute<DeleteJobTaggingRequest>();
            var marshaller = new DeleteJobTaggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteJobTagging", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServiceException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteJobTaggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void DeleteJobTagging_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteJobTagging");

            var request = InstantiateClassGenerator.Execute<DeleteJobTaggingRequest>();
            var marshaller = new DeleteJobTaggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteJobTagging", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteJobTaggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void DeleteJobTagging_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteJobTagging");

            var request = InstantiateClassGenerator.Execute<DeleteJobTaggingRequest>();
            var marshaller = new DeleteJobTaggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteJobTagging", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteJobTaggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void DeleteMultiRegionAccessPointMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMultiRegionAccessPoint");

            var request = InstantiateClassGenerator.Execute<DeleteMultiRegionAccessPointRequest>();
            var marshaller = new DeleteMultiRegionAccessPointRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteMultiRegionAccessPoint", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DeleteMultiRegionAccessPointResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DeleteMultiRegionAccessPointResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
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
        public void DeleteStorageLensConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteStorageLensConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteStorageLensConfigurationRequest>();
            var marshaller = new DeleteStorageLensConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteStorageLensConfiguration", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void DeleteStorageLensConfigurationTaggingMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteStorageLensConfigurationTagging");

            var request = InstantiateClassGenerator.Execute<DeleteStorageLensConfigurationTaggingRequest>();
            var marshaller = new DeleteStorageLensConfigurationTaggingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteStorageLensConfigurationTagging", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DeleteStorageLensConfigurationTaggingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DeleteStorageLensConfigurationTaggingResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
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
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeJobResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DescribeJobResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void DescribeJob_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeJob");

            var request = InstantiateClassGenerator.Execute<DescribeJobRequest>();
            var marshaller = new DescribeJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeJob", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("BadRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DescribeJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void DescribeJob_InternalServiceExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeJob");

            var request = InstantiateClassGenerator.Execute<DescribeJobRequest>();
            var marshaller = new DescribeJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeJob", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServiceException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DescribeJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void DescribeJob_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeJob");

            var request = InstantiateClassGenerator.Execute<DescribeJobRequest>();
            var marshaller = new DescribeJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeJob", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DescribeJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void DescribeJob_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeJob");

            var request = InstantiateClassGenerator.Execute<DescribeJobRequest>();
            var marshaller = new DescribeJobRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DescribeJob", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DescribeJobResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void DescribeMultiRegionAccessPointOperationMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeMultiRegionAccessPointOperation");

            var request = InstantiateClassGenerator.Execute<DescribeMultiRegionAccessPointOperationRequest>();
            var marshaller = new DescribeMultiRegionAccessPointOperationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DescribeMultiRegionAccessPointOperation", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeMultiRegionAccessPointOperationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DescribeMultiRegionAccessPointOperationResponse;
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
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetAccessPointResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetAccessPointResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void GetAccessPointConfigurationForObjectLambdaMarshallTest()
        {
            var operation = service_model.FindOperation("GetAccessPointConfigurationForObjectLambda");

            var request = InstantiateClassGenerator.Execute<GetAccessPointConfigurationForObjectLambdaRequest>();
            var marshaller = new GetAccessPointConfigurationForObjectLambdaRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetAccessPointConfigurationForObjectLambda", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetAccessPointConfigurationForObjectLambdaResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetAccessPointConfigurationForObjectLambdaResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void GetAccessPointForObjectLambdaMarshallTest()
        {
            var operation = service_model.FindOperation("GetAccessPointForObjectLambda");

            var request = InstantiateClassGenerator.Execute<GetAccessPointForObjectLambdaRequest>();
            var marshaller = new GetAccessPointForObjectLambdaRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetAccessPointForObjectLambda", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetAccessPointForObjectLambdaResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetAccessPointForObjectLambdaResponse;
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
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetAccessPointPolicyResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetAccessPointPolicyResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void GetAccessPointPolicyForObjectLambdaMarshallTest()
        {
            var operation = service_model.FindOperation("GetAccessPointPolicyForObjectLambda");

            var request = InstantiateClassGenerator.Execute<GetAccessPointPolicyForObjectLambdaRequest>();
            var marshaller = new GetAccessPointPolicyForObjectLambdaRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetAccessPointPolicyForObjectLambda", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetAccessPointPolicyForObjectLambdaResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetAccessPointPolicyForObjectLambdaResponse;
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
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetAccessPointPolicyStatusResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetAccessPointPolicyStatusResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void GetAccessPointPolicyStatusForObjectLambdaMarshallTest()
        {
            var operation = service_model.FindOperation("GetAccessPointPolicyStatusForObjectLambda");

            var request = InstantiateClassGenerator.Execute<GetAccessPointPolicyStatusForObjectLambdaRequest>();
            var marshaller = new GetAccessPointPolicyStatusForObjectLambdaRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetAccessPointPolicyStatusForObjectLambda", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetAccessPointPolicyStatusForObjectLambdaResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetAccessPointPolicyStatusForObjectLambdaResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void GetBucketMarshallTest()
        {
            var operation = service_model.FindOperation("GetBucket");

            var request = InstantiateClassGenerator.Execute<GetBucketRequest>();
            var marshaller = new GetBucketRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBucket", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetBucketResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetBucketResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void GetBucketLifecycleConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("GetBucketLifecycleConfiguration");

            var request = InstantiateClassGenerator.Execute<GetBucketLifecycleConfigurationRequest>();
            var marshaller = new GetBucketLifecycleConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBucketLifecycleConfiguration", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetBucketLifecycleConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetBucketLifecycleConfigurationResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void GetBucketPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("GetBucketPolicy");

            var request = InstantiateClassGenerator.Execute<GetBucketPolicyRequest>();
            var marshaller = new GetBucketPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBucketPolicy", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetBucketPolicyResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetBucketPolicyResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void GetBucketReplicationMarshallTest()
        {
            var operation = service_model.FindOperation("GetBucketReplication");

            var request = InstantiateClassGenerator.Execute<GetBucketReplicationRequest>();
            var marshaller = new GetBucketReplicationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBucketReplication", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetBucketReplicationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetBucketReplicationResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void GetBucketTaggingMarshallTest()
        {
            var operation = service_model.FindOperation("GetBucketTagging");

            var request = InstantiateClassGenerator.Execute<GetBucketTaggingRequest>();
            var marshaller = new GetBucketTaggingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBucketTagging", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetBucketTaggingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetBucketTaggingResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void GetBucketVersioningMarshallTest()
        {
            var operation = service_model.FindOperation("GetBucketVersioning");

            var request = InstantiateClassGenerator.Execute<GetBucketVersioningRequest>();
            var marshaller = new GetBucketVersioningRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetBucketVersioning", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetBucketVersioningResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetBucketVersioningResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void GetJobTaggingMarshallTest()
        {
            var operation = service_model.FindOperation("GetJobTagging");

            var request = InstantiateClassGenerator.Execute<GetJobTaggingRequest>();
            var marshaller = new GetJobTaggingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetJobTagging", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetJobTaggingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetJobTaggingResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void GetJobTagging_InternalServiceExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetJobTagging");

            var request = InstantiateClassGenerator.Execute<GetJobTaggingRequest>();
            var marshaller = new GetJobTaggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetJobTagging", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServiceException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetJobTaggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void GetJobTagging_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetJobTagging");

            var request = InstantiateClassGenerator.Execute<GetJobTaggingRequest>();
            var marshaller = new GetJobTaggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetJobTagging", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetJobTaggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void GetJobTagging_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetJobTagging");

            var request = InstantiateClassGenerator.Execute<GetJobTaggingRequest>();
            var marshaller = new GetJobTaggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetJobTagging", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetJobTaggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void GetMultiRegionAccessPointMarshallTest()
        {
            var operation = service_model.FindOperation("GetMultiRegionAccessPoint");

            var request = InstantiateClassGenerator.Execute<GetMultiRegionAccessPointRequest>();
            var marshaller = new GetMultiRegionAccessPointRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetMultiRegionAccessPoint", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetMultiRegionAccessPointResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetMultiRegionAccessPointResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void GetMultiRegionAccessPointPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("GetMultiRegionAccessPointPolicy");

            var request = InstantiateClassGenerator.Execute<GetMultiRegionAccessPointPolicyRequest>();
            var marshaller = new GetMultiRegionAccessPointPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetMultiRegionAccessPointPolicy", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetMultiRegionAccessPointPolicyResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetMultiRegionAccessPointPolicyResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void GetMultiRegionAccessPointPolicyStatusMarshallTest()
        {
            var operation = service_model.FindOperation("GetMultiRegionAccessPointPolicyStatus");

            var request = InstantiateClassGenerator.Execute<GetMultiRegionAccessPointPolicyStatusRequest>();
            var marshaller = new GetMultiRegionAccessPointPolicyStatusRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetMultiRegionAccessPointPolicyStatus", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetMultiRegionAccessPointPolicyStatusResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetMultiRegionAccessPointPolicyStatusResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void GetMultiRegionAccessPointRoutesMarshallTest()
        {
            var operation = service_model.FindOperation("GetMultiRegionAccessPointRoutes");

            var request = InstantiateClassGenerator.Execute<GetMultiRegionAccessPointRoutesRequest>();
            var marshaller = new GetMultiRegionAccessPointRoutesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetMultiRegionAccessPointRoutes", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetMultiRegionAccessPointRoutesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetMultiRegionAccessPointRoutesResponse;
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
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetPublicAccessBlockResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetPublicAccessBlockResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void GetPublicAccessBlock_NoSuchPublicAccessBlockConfigurationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetPublicAccessBlock");

            var request = InstantiateClassGenerator.Execute<GetPublicAccessBlockRequest>();
            var marshaller = new GetPublicAccessBlockRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetPublicAccessBlock", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchPublicAccessBlockConfigurationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetPublicAccessBlockResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void GetStorageLensConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("GetStorageLensConfiguration");

            var request = InstantiateClassGenerator.Execute<GetStorageLensConfigurationRequest>();
            var marshaller = new GetStorageLensConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetStorageLensConfiguration", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetStorageLensConfigurationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetStorageLensConfigurationResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void GetStorageLensConfigurationTaggingMarshallTest()
        {
            var operation = service_model.FindOperation("GetStorageLensConfigurationTagging");

            var request = InstantiateClassGenerator.Execute<GetStorageLensConfigurationTaggingRequest>();
            var marshaller = new GetStorageLensConfigurationTaggingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetStorageLensConfigurationTagging", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetStorageLensConfigurationTaggingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetStorageLensConfigurationTaggingResponse;
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
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListAccessPointsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as ListAccessPointsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void ListAccessPointsForObjectLambdaMarshallTest()
        {
            var operation = service_model.FindOperation("ListAccessPointsForObjectLambda");

            var request = InstantiateClassGenerator.Execute<ListAccessPointsForObjectLambdaRequest>();
            var marshaller = new ListAccessPointsForObjectLambdaRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListAccessPointsForObjectLambda", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListAccessPointsForObjectLambdaResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as ListAccessPointsForObjectLambdaResponse;
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
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListJobsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as ListJobsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void ListJobs_InternalServiceExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListJobs");

            var request = InstantiateClassGenerator.Execute<ListJobsRequest>();
            var marshaller = new ListJobsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListJobs", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServiceException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListJobsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void ListJobs_InvalidNextTokenExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListJobs");

            var request = InstantiateClassGenerator.Execute<ListJobsRequest>();
            var marshaller = new ListJobsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListJobs", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidNextTokenException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListJobsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void ListJobs_InvalidRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListJobs");

            var request = InstantiateClassGenerator.Execute<ListJobsRequest>();
            var marshaller = new ListJobsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListJobs", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListJobsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void ListMultiRegionAccessPointsMarshallTest()
        {
            var operation = service_model.FindOperation("ListMultiRegionAccessPoints");

            var request = InstantiateClassGenerator.Execute<ListMultiRegionAccessPointsRequest>();
            var marshaller = new ListMultiRegionAccessPointsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListMultiRegionAccessPoints", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListMultiRegionAccessPointsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as ListMultiRegionAccessPointsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void ListRegionalBucketsMarshallTest()
        {
            var operation = service_model.FindOperation("ListRegionalBuckets");

            var request = InstantiateClassGenerator.Execute<ListRegionalBucketsRequest>();
            var marshaller = new ListRegionalBucketsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListRegionalBuckets", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListRegionalBucketsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as ListRegionalBucketsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void ListStorageLensConfigurationsMarshallTest()
        {
            var operation = service_model.FindOperation("ListStorageLensConfigurations");

            var request = InstantiateClassGenerator.Execute<ListStorageLensConfigurationsRequest>();
            var marshaller = new ListStorageLensConfigurationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListStorageLensConfigurations", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListStorageLensConfigurationsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as ListStorageLensConfigurationsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void PutAccessPointConfigurationForObjectLambdaMarshallTest()
        {
            var operation = service_model.FindOperation("PutAccessPointConfigurationForObjectLambda");

            var request = InstantiateClassGenerator.Execute<PutAccessPointConfigurationForObjectLambdaRequest>();
            var marshaller = new PutAccessPointConfigurationForObjectLambdaRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutAccessPointConfigurationForObjectLambda", request, internalRequest, service_model);

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
        public void PutAccessPointPolicyForObjectLambdaMarshallTest()
        {
            var operation = service_model.FindOperation("PutAccessPointPolicyForObjectLambda");

            var request = InstantiateClassGenerator.Execute<PutAccessPointPolicyForObjectLambdaRequest>();
            var marshaller = new PutAccessPointPolicyForObjectLambdaRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutAccessPointPolicyForObjectLambda", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void PutBucketLifecycleConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("PutBucketLifecycleConfiguration");

            var request = InstantiateClassGenerator.Execute<PutBucketLifecycleConfigurationRequest>();
            var marshaller = new PutBucketLifecycleConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutBucketLifecycleConfiguration", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void PutBucketPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("PutBucketPolicy");

            var request = InstantiateClassGenerator.Execute<PutBucketPolicyRequest>();
            var marshaller = new PutBucketPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutBucketPolicy", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void PutBucketReplicationMarshallTest()
        {
            var operation = service_model.FindOperation("PutBucketReplication");

            var request = InstantiateClassGenerator.Execute<PutBucketReplicationRequest>();
            var marshaller = new PutBucketReplicationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutBucketReplication", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void PutBucketTaggingMarshallTest()
        {
            var operation = service_model.FindOperation("PutBucketTagging");

            var request = InstantiateClassGenerator.Execute<PutBucketTaggingRequest>();
            var marshaller = new PutBucketTaggingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutBucketTagging", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void PutBucketVersioningMarshallTest()
        {
            var operation = service_model.FindOperation("PutBucketVersioning");

            var request = InstantiateClassGenerator.Execute<PutBucketVersioningRequest>();
            var marshaller = new PutBucketVersioningRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutBucketVersioning", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void PutJobTaggingMarshallTest()
        {
            var operation = service_model.FindOperation("PutJobTagging");

            var request = InstantiateClassGenerator.Execute<PutJobTaggingRequest>();
            var marshaller = new PutJobTaggingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutJobTagging", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = PutJobTaggingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as PutJobTaggingResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void PutJobTagging_InternalServiceExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutJobTagging");

            var request = InstantiateClassGenerator.Execute<PutJobTaggingRequest>();
            var marshaller = new PutJobTaggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PutJobTagging", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServiceException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PutJobTaggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void PutJobTagging_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutJobTagging");

            var request = InstantiateClassGenerator.Execute<PutJobTaggingRequest>();
            var marshaller = new PutJobTaggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PutJobTagging", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PutJobTaggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void PutJobTagging_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutJobTagging");

            var request = InstantiateClassGenerator.Execute<PutJobTaggingRequest>();
            var marshaller = new PutJobTaggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PutJobTagging", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PutJobTaggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void PutJobTagging_TooManyTagsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PutJobTagging");

            var request = InstantiateClassGenerator.Execute<PutJobTaggingRequest>();
            var marshaller = new PutJobTaggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("PutJobTagging", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyTagsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = PutJobTaggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void PutMultiRegionAccessPointPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("PutMultiRegionAccessPointPolicy");

            var request = InstantiateClassGenerator.Execute<PutMultiRegionAccessPointPolicyRequest>();
            var marshaller = new PutMultiRegionAccessPointPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutMultiRegionAccessPointPolicy", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = PutMultiRegionAccessPointPolicyResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as PutMultiRegionAccessPointPolicyResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
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
        public void PutStorageLensConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("PutStorageLensConfiguration");

            var request = InstantiateClassGenerator.Execute<PutStorageLensConfigurationRequest>();
            var marshaller = new PutStorageLensConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutStorageLensConfiguration", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void PutStorageLensConfigurationTaggingMarshallTest()
        {
            var operation = service_model.FindOperation("PutStorageLensConfigurationTagging");

            var request = InstantiateClassGenerator.Execute<PutStorageLensConfigurationTaggingRequest>();
            var marshaller = new PutStorageLensConfigurationTaggingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutStorageLensConfigurationTagging", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = PutStorageLensConfigurationTaggingResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as PutStorageLensConfigurationTaggingResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void SubmitMultiRegionAccessPointRoutesMarshallTest()
        {
            var operation = service_model.FindOperation("SubmitMultiRegionAccessPointRoutes");

            var request = InstantiateClassGenerator.Execute<SubmitMultiRegionAccessPointRoutesRequest>();
            var marshaller = new SubmitMultiRegionAccessPointRoutesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("SubmitMultiRegionAccessPointRoutes", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = SubmitMultiRegionAccessPointRoutesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as SubmitMultiRegionAccessPointRoutesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
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
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UpdateJobPriorityResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as UpdateJobPriorityResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void UpdateJobPriority_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateJobPriority");

            var request = InstantiateClassGenerator.Execute<UpdateJobPriorityRequest>();
            var marshaller = new UpdateJobPriorityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateJobPriority", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("BadRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateJobPriorityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void UpdateJobPriority_InternalServiceExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateJobPriority");

            var request = InstantiateClassGenerator.Execute<UpdateJobPriorityRequest>();
            var marshaller = new UpdateJobPriorityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateJobPriority", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServiceException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateJobPriorityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void UpdateJobPriority_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateJobPriority");

            var request = InstantiateClassGenerator.Execute<UpdateJobPriorityRequest>();
            var marshaller = new UpdateJobPriorityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateJobPriority", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateJobPriorityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void UpdateJobPriority_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateJobPriority");

            var request = InstantiateClassGenerator.Execute<UpdateJobPriorityRequest>();
            var marshaller = new UpdateJobPriorityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateJobPriority", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateJobPriorityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UpdateJobStatusResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as UpdateJobStatusResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void UpdateJobStatus_BadRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateJobStatus");

            var request = InstantiateClassGenerator.Execute<UpdateJobStatusRequest>();
            var marshaller = new UpdateJobStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateJobStatus", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("BadRequestException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateJobStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void UpdateJobStatus_InternalServiceExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateJobStatus");

            var request = InstantiateClassGenerator.Execute<UpdateJobStatusRequest>();
            var marshaller = new UpdateJobStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateJobStatus", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServiceException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateJobStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void UpdateJobStatus_JobStatusExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateJobStatus");

            var request = InstantiateClassGenerator.Execute<UpdateJobStatusRequest>();
            var marshaller = new UpdateJobStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateJobStatus", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("JobStatusException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateJobStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void UpdateJobStatus_NotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateJobStatus");

            var request = InstantiateClassGenerator.Execute<UpdateJobStatusRequest>();
            var marshaller = new UpdateJobStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateJobStatus", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateJobStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void UpdateJobStatus_TooManyRequestsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateJobStatus");

            var request = InstantiateClassGenerator.Execute<UpdateJobStatusRequest>();
            var marshaller = new UpdateJobStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateJobStatus", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRequestsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateJobStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}