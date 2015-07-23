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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Glacier;
using Amazon.Glacier.Model;
using Amazon.Glacier.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class GlacierMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("glacier-2012-06-01.normal.json", "glacier.customizations.json");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void AbortMultipartUploadMarshallTest()
        {
            var operation = service_model.FindOperation("AbortMultipartUpload");

            var request = InstantiateClassGenerator.Execute<AbortMultipartUploadRequest>();
            var marshaller = new AbortMultipartUploadRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("AbortMultipartUpload", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void AbortVaultLockMarshallTest()
        {
            var operation = service_model.FindOperation("AbortVaultLock");

            var request = InstantiateClassGenerator.Execute<AbortVaultLockRequest>();
            var marshaller = new AbortVaultLockRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("AbortVaultLock", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void AddTagsToVaultMarshallTest()
        {
            var operation = service_model.FindOperation("AddTagsToVault");

            var request = InstantiateClassGenerator.Execute<AddTagsToVaultRequest>();
            var marshaller = new AddTagsToVaultRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("AddTagsToVault", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void CompleteMultipartUploadMarshallTest()
        {
            var operation = service_model.FindOperation("CompleteMultipartUpload");

            var request = InstantiateClassGenerator.Execute<CompleteMultipartUploadRequest>();
            var marshaller = new CompleteMultipartUploadRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("CompleteMultipartUpload", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amz-archive-id","x-amz-archive-id_Value"},
                    {"x-amz-sha256-tree-hash","x-amz-sha256-tree-hash_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CompleteMultipartUploadResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CompleteMultipartUploadResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void CompleteVaultLockMarshallTest()
        {
            var operation = service_model.FindOperation("CompleteVaultLock");

            var request = InstantiateClassGenerator.Execute<CompleteVaultLockRequest>();
            var marshaller = new CompleteVaultLockRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("CompleteVaultLock", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void CreateVaultMarshallTest()
        {
            var operation = service_model.FindOperation("CreateVault");

            var request = InstantiateClassGenerator.Execute<CreateVaultRequest>();
            var marshaller = new CreateVaultRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("CreateVault", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateVaultResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateVaultResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void DeleteArchiveMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteArchive");

            var request = InstantiateClassGenerator.Execute<DeleteArchiveRequest>();
            var marshaller = new DeleteArchiveRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteArchive", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void DeleteVaultMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteVault");

            var request = InstantiateClassGenerator.Execute<DeleteVaultRequest>();
            var marshaller = new DeleteVaultRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteVault", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void DeleteVaultAccessPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteVaultAccessPolicy");

            var request = InstantiateClassGenerator.Execute<DeleteVaultAccessPolicyRequest>();
            var marshaller = new DeleteVaultAccessPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteVaultAccessPolicy", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void DeleteVaultNotificationsMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteVaultNotifications");

            var request = InstantiateClassGenerator.Execute<DeleteVaultNotificationsRequest>();
            var marshaller = new DeleteVaultNotificationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteVaultNotifications", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void DescribeJobMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeJob");

            var request = InstantiateClassGenerator.Execute<DescribeJobRequest>();
            var marshaller = new DescribeJobRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DescribeJob", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeJobResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeJobResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void DescribeVaultMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeVault");

            var request = InstantiateClassGenerator.Execute<DescribeVaultRequest>();
            var marshaller = new DescribeVaultRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DescribeVault", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DescribeVaultResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeVaultResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void GetDataRetrievalPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("GetDataRetrievalPolicy");

            var request = InstantiateClassGenerator.Execute<GetDataRetrievalPolicyRequest>();
            var marshaller = new GetDataRetrievalPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetDataRetrievalPolicy", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetDataRetrievalPolicyResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetDataRetrievalPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void GetJobOutputMarshallTest()
        {
            var operation = service_model.FindOperation("GetJobOutput");

            var request = InstantiateClassGenerator.Execute<GetJobOutputRequest>();
            var marshaller = new GetJobOutputRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetJobOutput", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Accept-Ranges","Accept-Ranges_Value"},
                    {"x-amz-archive-description","x-amz-archive-description_Value"},
                    {"x-amz-sha256-tree-hash","x-amz-sha256-tree-hash_Value"},
                    {"Content-Range","Content-Range_Value"},
                    {"Content-Type","Content-Type_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetJobOutputResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetJobOutputResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void GetVaultAccessPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("GetVaultAccessPolicy");

            var request = InstantiateClassGenerator.Execute<GetVaultAccessPolicyRequest>();
            var marshaller = new GetVaultAccessPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetVaultAccessPolicy", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetVaultAccessPolicyResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetVaultAccessPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void GetVaultLockMarshallTest()
        {
            var operation = service_model.FindOperation("GetVaultLock");

            var request = InstantiateClassGenerator.Execute<GetVaultLockRequest>();
            var marshaller = new GetVaultLockRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetVaultLock", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetVaultLockResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetVaultLockResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void GetVaultNotificationsMarshallTest()
        {
            var operation = service_model.FindOperation("GetVaultNotifications");

            var request = InstantiateClassGenerator.Execute<GetVaultNotificationsRequest>();
            var marshaller = new GetVaultNotificationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetVaultNotifications", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetVaultNotificationsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetVaultNotificationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void InitiateJobMarshallTest()
        {
            var operation = service_model.FindOperation("InitiateJob");

            var request = InstantiateClassGenerator.Execute<InitiateJobRequest>();
            var marshaller = new InitiateJobRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("InitiateJob", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amz-job-id","x-amz-job-id_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = InitiateJobResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as InitiateJobResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void InitiateMultipartUploadMarshallTest()
        {
            var operation = service_model.FindOperation("InitiateMultipartUpload");

            var request = InstantiateClassGenerator.Execute<InitiateMultipartUploadRequest>();
            var marshaller = new InitiateMultipartUploadRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("InitiateMultipartUpload", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Location","Location_Value"},
                    {"x-amz-multipart-upload-id","x-amz-multipart-upload-id_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = InitiateMultipartUploadResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as InitiateMultipartUploadResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void InitiateVaultLockMarshallTest()
        {
            var operation = service_model.FindOperation("InitiateVaultLock");

            var request = InstantiateClassGenerator.Execute<InitiateVaultLockRequest>();
            var marshaller = new InitiateVaultLockRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("InitiateVaultLock", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amz-lock-id","x-amz-lock-id_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = InitiateVaultLockResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as InitiateVaultLockResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void ListJobsMarshallTest()
        {
            var operation = service_model.FindOperation("ListJobs");

            var request = InstantiateClassGenerator.Execute<ListJobsRequest>();
            var marshaller = new ListJobsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ListJobs", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListJobsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListJobsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void ListMultipartUploadsMarshallTest()
        {
            var operation = service_model.FindOperation("ListMultipartUploads");

            var request = InstantiateClassGenerator.Execute<ListMultipartUploadsRequest>();
            var marshaller = new ListMultipartUploadsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ListMultipartUploads", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListMultipartUploadsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListMultipartUploadsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void ListPartsMarshallTest()
        {
            var operation = service_model.FindOperation("ListParts");

            var request = InstantiateClassGenerator.Execute<ListPartsRequest>();
            var marshaller = new ListPartsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ListParts", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListPartsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListPartsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void ListTagsForVaultMarshallTest()
        {
            var operation = service_model.FindOperation("ListTagsForVault");

            var request = InstantiateClassGenerator.Execute<ListTagsForVaultRequest>();
            var marshaller = new ListTagsForVaultRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ListTagsForVault", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListTagsForVaultResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListTagsForVaultResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void ListVaultsMarshallTest()
        {
            var operation = service_model.FindOperation("ListVaults");

            var request = InstantiateClassGenerator.Execute<ListVaultsRequest>();
            var marshaller = new ListVaultsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ListVaults", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListVaultsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListVaultsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void RemoveTagsFromVaultMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveTagsFromVault");

            var request = InstantiateClassGenerator.Execute<RemoveTagsFromVaultRequest>();
            var marshaller = new RemoveTagsFromVaultRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("RemoveTagsFromVault", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void SetDataRetrievalPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("SetDataRetrievalPolicy");

            var request = InstantiateClassGenerator.Execute<SetDataRetrievalPolicyRequest>();
            var marshaller = new SetDataRetrievalPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("SetDataRetrievalPolicy", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void SetVaultAccessPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("SetVaultAccessPolicy");

            var request = InstantiateClassGenerator.Execute<SetVaultAccessPolicyRequest>();
            var marshaller = new SetVaultAccessPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("SetVaultAccessPolicy", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void SetVaultNotificationsMarshallTest()
        {
            var operation = service_model.FindOperation("SetVaultNotifications");

            var request = InstantiateClassGenerator.Execute<SetVaultNotificationsRequest>();
            var marshaller = new SetVaultNotificationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("SetVaultNotifications", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void UploadArchiveMarshallTest()
        {
            var operation = service_model.FindOperation("UploadArchive");

            var request = InstantiateClassGenerator.Execute<UploadArchiveRequest>();
            var marshaller = new UploadArchiveRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UploadArchive", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amz-archive-id","x-amz-archive-id_Value"},
                    {"x-amz-sha256-tree-hash","x-amz-sha256-tree-hash_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UploadArchiveResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UploadArchiveResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Glacier")]
        public void UploadMultipartPartMarshallTest()
        {
            var operation = service_model.FindOperation("UploadMultipartPart");

            var request = InstantiateClassGenerator.Execute<UploadMultipartPartRequest>();
            var marshaller = new UploadMultipartPartRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UploadMultipartPart", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amz-sha256-tree-hash","x-amz-sha256-tree-hash_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UploadMultipartPartResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UploadMultipartPartResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

            }
}