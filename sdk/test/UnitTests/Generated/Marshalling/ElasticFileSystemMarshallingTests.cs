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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.ElasticFileSystem;
using Amazon.ElasticFileSystem.Model;
using Amazon.ElasticFileSystem.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class ElasticFileSystemMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("elasticfilesystem-2015-02-01.normal.json", "elasticfilesystem.customizations.json");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ElasticFileSystem")]
        public void CreateFileSystemMarshallTest()
        {
            var operation = service_model.FindOperation("CreateFileSystem");

            var request = InstantiateClassGenerator.Execute<CreateFileSystemRequest>();
            var marshaller = new CreateFileSystemRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("CreateFileSystem", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateFileSystemResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateFileSystemResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ElasticFileSystem")]
        public void CreateMountTargetMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMountTarget");

            var request = InstantiateClassGenerator.Execute<CreateMountTargetRequest>();
            var marshaller = new CreateMountTargetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("CreateMountTarget", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = CreateMountTargetResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateMountTargetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ElasticFileSystem")]
        public void CreateTagsMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTags");

            var request = InstantiateClassGenerator.Execute<CreateTagsRequest>();
            var marshaller = new CreateTagsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("CreateTags", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ElasticFileSystem")]
        public void DeleteFileSystemMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteFileSystem");

            var request = InstantiateClassGenerator.Execute<DeleteFileSystemRequest>();
            var marshaller = new DeleteFileSystemRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteFileSystem", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ElasticFileSystem")]
        public void DeleteMountTargetMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMountTarget");

            var request = InstantiateClassGenerator.Execute<DeleteMountTargetRequest>();
            var marshaller = new DeleteMountTargetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteMountTarget", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ElasticFileSystem")]
        public void DeleteTagsMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteTags");

            var request = InstantiateClassGenerator.Execute<DeleteTagsRequest>();
            var marshaller = new DeleteTagsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteTags", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ElasticFileSystem")]
        public void DescribeFileSystemsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeFileSystems");

            var request = InstantiateClassGenerator.Execute<DescribeFileSystemsRequest>();
            var marshaller = new DescribeFileSystemsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DescribeFileSystems", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeFileSystemsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeFileSystemsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ElasticFileSystem")]
        public void DescribeMountTargetsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeMountTargets");

            var request = InstantiateClassGenerator.Execute<DescribeMountTargetsRequest>();
            var marshaller = new DescribeMountTargetsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DescribeMountTargets", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeMountTargetsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeMountTargetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ElasticFileSystem")]
        public void DescribeMountTargetSecurityGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeMountTargetSecurityGroups");

            var request = InstantiateClassGenerator.Execute<DescribeMountTargetSecurityGroupsRequest>();
            var marshaller = new DescribeMountTargetSecurityGroupsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DescribeMountTargetSecurityGroups", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeMountTargetSecurityGroupsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeMountTargetSecurityGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ElasticFileSystem")]
        public void DescribeTagsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTags");

            var request = InstantiateClassGenerator.Execute<DescribeTagsRequest>();
            var marshaller = new DescribeTagsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DescribeTags", request, internalRequest, service_model);            

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
            ResponseUnmarshaller unmarshaller = DescribeTagsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DescribeTagsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("ElasticFileSystem")]
        public void ModifyMountTargetSecurityGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyMountTargetSecurityGroups");

            var request = InstantiateClassGenerator.Execute<ModifyMountTargetSecurityGroupsRequest>();
            var marshaller = new ModifyMountTargetSecurityGroupsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ModifyMountTargetSecurityGroups", request, internalRequest, service_model);            

        }

            }
}