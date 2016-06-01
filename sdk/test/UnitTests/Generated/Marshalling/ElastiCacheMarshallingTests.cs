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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.ElastiCache;
using Amazon.ElastiCache.Model;
using Amazon.ElastiCache.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class ElastiCacheMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("elasticache-2015-02-02.normal.json", "elasticache.customizations.json");
        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void AddTagsToResourceMarshallTest()
        {
            var operation = service_model.FindOperation("AddTagsToResource");

            var request = InstantiateClassGenerator.Execute<AddTagsToResourceRequest>();
            var marshaller = new AddTagsToResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = AddTagsToResourceResponseUnmarshaller.Instance.Unmarshall(context)
                as AddTagsToResourceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void AuthorizeCacheSecurityGroupIngressMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeCacheSecurityGroupIngress");

            var request = InstantiateClassGenerator.Execute<AuthorizeCacheSecurityGroupIngressRequest>();
            var marshaller = new AuthorizeCacheSecurityGroupIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = AuthorizeCacheSecurityGroupIngressResponseUnmarshaller.Instance.Unmarshall(context)
                as AuthorizeCacheSecurityGroupIngressResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void CopySnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("CopySnapshot");

            var request = InstantiateClassGenerator.Execute<CopySnapshotRequest>();
            var marshaller = new CopySnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CopySnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as CopySnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void CreateCacheClusterMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCacheCluster");

            var request = InstantiateClassGenerator.Execute<CreateCacheClusterRequest>();
            var marshaller = new CreateCacheClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateCacheClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateCacheClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void CreateCacheParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCacheParameterGroup");

            var request = InstantiateClassGenerator.Execute<CreateCacheParameterGroupRequest>();
            var marshaller = new CreateCacheParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateCacheParameterGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateCacheParameterGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void CreateCacheSecurityGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCacheSecurityGroup");

            var request = InstantiateClassGenerator.Execute<CreateCacheSecurityGroupRequest>();
            var marshaller = new CreateCacheSecurityGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateCacheSecurityGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateCacheSecurityGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void CreateCacheSubnetGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCacheSubnetGroup");

            var request = InstantiateClassGenerator.Execute<CreateCacheSubnetGroupRequest>();
            var marshaller = new CreateCacheSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateCacheSubnetGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateCacheSubnetGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void CreateReplicationGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateReplicationGroup");

            var request = InstantiateClassGenerator.Execute<CreateReplicationGroupRequest>();
            var marshaller = new CreateReplicationGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateReplicationGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateReplicationGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void CreateSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSnapshot");

            var request = InstantiateClassGenerator.Execute<CreateSnapshotRequest>();
            var marshaller = new CreateSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void DeleteCacheClusterMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCacheCluster");

            var request = InstantiateClassGenerator.Execute<DeleteCacheClusterRequest>();
            var marshaller = new DeleteCacheClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteCacheClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteCacheClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void DeleteCacheParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCacheParameterGroup");

            var request = InstantiateClassGenerator.Execute<DeleteCacheParameterGroupRequest>();
            var marshaller = new DeleteCacheParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void DeleteCacheSecurityGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCacheSecurityGroup");

            var request = InstantiateClassGenerator.Execute<DeleteCacheSecurityGroupRequest>();
            var marshaller = new DeleteCacheSecurityGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void DeleteCacheSubnetGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCacheSubnetGroup");

            var request = InstantiateClassGenerator.Execute<DeleteCacheSubnetGroupRequest>();
            var marshaller = new DeleteCacheSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void DeleteReplicationGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteReplicationGroup");

            var request = InstantiateClassGenerator.Execute<DeleteReplicationGroupRequest>();
            var marshaller = new DeleteReplicationGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteReplicationGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteReplicationGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void DeleteSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSnapshot");

            var request = InstantiateClassGenerator.Execute<DeleteSnapshotRequest>();
            var marshaller = new DeleteSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void DescribeCacheClustersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeCacheClusters");

            var request = InstantiateClassGenerator.Execute<DescribeCacheClustersRequest>();
            var marshaller = new DescribeCacheClustersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeCacheClustersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeCacheClustersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void DescribeCacheEngineVersionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeCacheEngineVersions");

            var request = InstantiateClassGenerator.Execute<DescribeCacheEngineVersionsRequest>();
            var marshaller = new DescribeCacheEngineVersionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeCacheEngineVersionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeCacheEngineVersionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void DescribeCacheParameterGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeCacheParameterGroups");

            var request = InstantiateClassGenerator.Execute<DescribeCacheParameterGroupsRequest>();
            var marshaller = new DescribeCacheParameterGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeCacheParameterGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeCacheParameterGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void DescribeCacheParametersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeCacheParameters");

            var request = InstantiateClassGenerator.Execute<DescribeCacheParametersRequest>();
            var marshaller = new DescribeCacheParametersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeCacheParametersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeCacheParametersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void DescribeCacheSecurityGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeCacheSecurityGroups");

            var request = InstantiateClassGenerator.Execute<DescribeCacheSecurityGroupsRequest>();
            var marshaller = new DescribeCacheSecurityGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeCacheSecurityGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeCacheSecurityGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void DescribeCacheSubnetGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeCacheSubnetGroups");

            var request = InstantiateClassGenerator.Execute<DescribeCacheSubnetGroupsRequest>();
            var marshaller = new DescribeCacheSubnetGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeCacheSubnetGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeCacheSubnetGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void DescribeEngineDefaultParametersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEngineDefaultParameters");

            var request = InstantiateClassGenerator.Execute<DescribeEngineDefaultParametersRequest>();
            var marshaller = new DescribeEngineDefaultParametersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeEngineDefaultParametersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeEngineDefaultParametersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void DescribeEventsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEvents");

            var request = InstantiateClassGenerator.Execute<DescribeEventsRequest>();
            var marshaller = new DescribeEventsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeEventsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeEventsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void DescribeReplicationGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReplicationGroups");

            var request = InstantiateClassGenerator.Execute<DescribeReplicationGroupsRequest>();
            var marshaller = new DescribeReplicationGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeReplicationGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeReplicationGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void DescribeReservedCacheNodesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReservedCacheNodes");

            var request = InstantiateClassGenerator.Execute<DescribeReservedCacheNodesRequest>();
            var marshaller = new DescribeReservedCacheNodesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeReservedCacheNodesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeReservedCacheNodesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void DescribeReservedCacheNodesOfferingsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReservedCacheNodesOfferings");

            var request = InstantiateClassGenerator.Execute<DescribeReservedCacheNodesOfferingsRequest>();
            var marshaller = new DescribeReservedCacheNodesOfferingsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeReservedCacheNodesOfferingsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeReservedCacheNodesOfferingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void DescribeSnapshotsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSnapshots");

            var request = InstantiateClassGenerator.Execute<DescribeSnapshotsRequest>();
            var marshaller = new DescribeSnapshotsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeSnapshotsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeSnapshotsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void ListAllowedNodeTypeModificationsMarshallTest()
        {
            var operation = service_model.FindOperation("ListAllowedNodeTypeModifications");

            var request = InstantiateClassGenerator.Execute<ListAllowedNodeTypeModificationsRequest>();
            var marshaller = new ListAllowedNodeTypeModificationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListAllowedNodeTypeModificationsResponseUnmarshaller.Instance.Unmarshall(context)
                as ListAllowedNodeTypeModificationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void ListTagsForResourceMarshallTest()
        {
            var operation = service_model.FindOperation("ListTagsForResource");

            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListTagsForResourceResponseUnmarshaller.Instance.Unmarshall(context)
                as ListTagsForResourceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void ModifyCacheClusterMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCacheCluster");

            var request = InstantiateClassGenerator.Execute<ModifyCacheClusterRequest>();
            var marshaller = new ModifyCacheClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyCacheClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyCacheClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void ModifyCacheParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCacheParameterGroup");

            var request = InstantiateClassGenerator.Execute<ModifyCacheParameterGroupRequest>();
            var marshaller = new ModifyCacheParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyCacheParameterGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyCacheParameterGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void ModifyCacheSubnetGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCacheSubnetGroup");

            var request = InstantiateClassGenerator.Execute<ModifyCacheSubnetGroupRequest>();
            var marshaller = new ModifyCacheSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyCacheSubnetGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyCacheSubnetGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void ModifyReplicationGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyReplicationGroup");

            var request = InstantiateClassGenerator.Execute<ModifyReplicationGroupRequest>();
            var marshaller = new ModifyReplicationGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyReplicationGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyReplicationGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void PurchaseReservedCacheNodesOfferingMarshallTest()
        {
            var operation = service_model.FindOperation("PurchaseReservedCacheNodesOffering");

            var request = InstantiateClassGenerator.Execute<PurchaseReservedCacheNodesOfferingRequest>();
            var marshaller = new PurchaseReservedCacheNodesOfferingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = PurchaseReservedCacheNodesOfferingResponseUnmarshaller.Instance.Unmarshall(context)
                as PurchaseReservedCacheNodesOfferingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void RebootCacheClusterMarshallTest()
        {
            var operation = service_model.FindOperation("RebootCacheCluster");

            var request = InstantiateClassGenerator.Execute<RebootCacheClusterRequest>();
            var marshaller = new RebootCacheClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RebootCacheClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as RebootCacheClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void RemoveTagsFromResourceMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveTagsFromResource");

            var request = InstantiateClassGenerator.Execute<RemoveTagsFromResourceRequest>();
            var marshaller = new RemoveTagsFromResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RemoveTagsFromResourceResponseUnmarshaller.Instance.Unmarshall(context)
                as RemoveTagsFromResourceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void ResetCacheParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ResetCacheParameterGroup");

            var request = InstantiateClassGenerator.Execute<ResetCacheParameterGroupRequest>();
            var marshaller = new ResetCacheParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ResetCacheParameterGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as ResetCacheParameterGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElastiCache")]
        public void RevokeCacheSecurityGroupIngressMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeCacheSecurityGroupIngress");

            var request = InstantiateClassGenerator.Execute<RevokeCacheSecurityGroupIngressRequest>();
            var marshaller = new RevokeCacheSecurityGroupIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RevokeCacheSecurityGroupIngressResponseUnmarshaller.Instance.Unmarshall(context)
                as RevokeCacheSecurityGroupIngressResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
    }
}