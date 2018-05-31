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
 * Do not modify this file. This file is generated from the neptune-2018-05-15.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Neptune;
using Amazon.Neptune.Model;
using Amazon.Neptune.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class NeptuneMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("neptune");
        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void AddRoleToDBClusterMarshallTest()
        {
            var operation = service_model.FindOperation("AddRoleToDBCluster");

            var request = InstantiateClassGenerator.Execute<AddRoleToDBClusterRequest>();
            var marshaller = new AddRoleToDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void AddSourceIdentifierToSubscriptionMarshallTest()
        {
            var operation = service_model.FindOperation("AddSourceIdentifierToSubscription");

            var request = InstantiateClassGenerator.Execute<AddSourceIdentifierToSubscriptionRequest>();
            var marshaller = new AddSourceIdentifierToSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = AddSourceIdentifierToSubscriptionResponseUnmarshaller.Instance.Unmarshall(context)
                as AddSourceIdentifierToSubscriptionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void AddTagsToResourceMarshallTest()
        {
            var operation = service_model.FindOperation("AddTagsToResource");

            var request = InstantiateClassGenerator.Execute<AddTagsToResourceRequest>();
            var marshaller = new AddTagsToResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void ApplyPendingMaintenanceActionMarshallTest()
        {
            var operation = service_model.FindOperation("ApplyPendingMaintenanceAction");

            var request = InstantiateClassGenerator.Execute<ApplyPendingMaintenanceActionRequest>();
            var marshaller = new ApplyPendingMaintenanceActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ApplyPendingMaintenanceActionResponseUnmarshaller.Instance.Unmarshall(context)
                as ApplyPendingMaintenanceActionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void CopyDBClusterParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CopyDBClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<CopyDBClusterParameterGroupRequest>();
            var marshaller = new CopyDBClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CopyDBClusterParameterGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CopyDBClusterParameterGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void CopyDBClusterSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("CopyDBClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CopyDBClusterSnapshotRequest>();
            var marshaller = new CopyDBClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CopyDBClusterSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as CopyDBClusterSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void CopyDBParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CopyDBParameterGroup");

            var request = InstantiateClassGenerator.Execute<CopyDBParameterGroupRequest>();
            var marshaller = new CopyDBParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CopyDBParameterGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CopyDBParameterGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void CreateDBClusterMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBCluster");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterRequest>();
            var marshaller = new CreateDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateDBClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateDBClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void CreateDBClusterParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterParameterGroupRequest>();
            var marshaller = new CreateDBClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateDBClusterParameterGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateDBClusterParameterGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void CreateDBClusterSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CreateDBClusterSnapshotRequest>();
            var marshaller = new CreateDBClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateDBClusterSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateDBClusterSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void CreateDBInstanceMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstance");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceRequest>();
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateDBInstanceResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateDBInstanceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void CreateDBParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBParameterGroup");

            var request = InstantiateClassGenerator.Execute<CreateDBParameterGroupRequest>();
            var marshaller = new CreateDBParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateDBParameterGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateDBParameterGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void CreateDBSubnetGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBSubnetGroup");

            var request = InstantiateClassGenerator.Execute<CreateDBSubnetGroupRequest>();
            var marshaller = new CreateDBSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateDBSubnetGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateDBSubnetGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void CreateEventSubscriptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEventSubscription");

            var request = InstantiateClassGenerator.Execute<CreateEventSubscriptionRequest>();
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateEventSubscriptionResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateEventSubscriptionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void DeleteDBClusterMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBCluster");

            var request = InstantiateClassGenerator.Execute<DeleteDBClusterRequest>();
            var marshaller = new DeleteDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteDBClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteDBClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void DeleteDBClusterParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<DeleteDBClusterParameterGroupRequest>();
            var marshaller = new DeleteDBClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void DeleteDBClusterSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<DeleteDBClusterSnapshotRequest>();
            var marshaller = new DeleteDBClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteDBClusterSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteDBClusterSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void DeleteDBInstanceMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBInstance");

            var request = InstantiateClassGenerator.Execute<DeleteDBInstanceRequest>();
            var marshaller = new DeleteDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteDBInstanceResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteDBInstanceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void DeleteDBParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBParameterGroup");

            var request = InstantiateClassGenerator.Execute<DeleteDBParameterGroupRequest>();
            var marshaller = new DeleteDBParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void DeleteDBSubnetGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBSubnetGroup");

            var request = InstantiateClassGenerator.Execute<DeleteDBSubnetGroupRequest>();
            var marshaller = new DeleteDBSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void DeleteEventSubscriptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteEventSubscription");

            var request = InstantiateClassGenerator.Execute<DeleteEventSubscriptionRequest>();
            var marshaller = new DeleteEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteEventSubscriptionResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteEventSubscriptionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void DescribeDBClusterParameterGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBClusterParameterGroups");

            var request = InstantiateClassGenerator.Execute<DescribeDBClusterParameterGroupsRequest>();
            var marshaller = new DescribeDBClusterParameterGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBClusterParameterGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBClusterParameterGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void DescribeDBClusterParametersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBClusterParameters");

            var request = InstantiateClassGenerator.Execute<DescribeDBClusterParametersRequest>();
            var marshaller = new DescribeDBClusterParametersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBClusterParametersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBClusterParametersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void DescribeDBClustersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBClusters");

            var request = InstantiateClassGenerator.Execute<DescribeDBClustersRequest>();
            var marshaller = new DescribeDBClustersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBClustersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBClustersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void DescribeDBClusterSnapshotAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBClusterSnapshotAttributes");

            var request = InstantiateClassGenerator.Execute<DescribeDBClusterSnapshotAttributesRequest>();
            var marshaller = new DescribeDBClusterSnapshotAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBClusterSnapshotAttributesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBClusterSnapshotAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void DescribeDBClusterSnapshotsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBClusterSnapshots");

            var request = InstantiateClassGenerator.Execute<DescribeDBClusterSnapshotsRequest>();
            var marshaller = new DescribeDBClusterSnapshotsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBClusterSnapshotsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBClusterSnapshotsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void DescribeDBEngineVersionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBEngineVersions");

            var request = InstantiateClassGenerator.Execute<DescribeDBEngineVersionsRequest>();
            var marshaller = new DescribeDBEngineVersionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBEngineVersionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBEngineVersionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void DescribeDBInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBInstances");

            var request = InstantiateClassGenerator.Execute<DescribeDBInstancesRequest>();
            var marshaller = new DescribeDBInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void DescribeDBParameterGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBParameterGroups");

            var request = InstantiateClassGenerator.Execute<DescribeDBParameterGroupsRequest>();
            var marshaller = new DescribeDBParameterGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBParameterGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBParameterGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void DescribeDBParametersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBParameters");

            var request = InstantiateClassGenerator.Execute<DescribeDBParametersRequest>();
            var marshaller = new DescribeDBParametersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBParametersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBParametersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void DescribeDBSubnetGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBSubnetGroups");

            var request = InstantiateClassGenerator.Execute<DescribeDBSubnetGroupsRequest>();
            var marshaller = new DescribeDBSubnetGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBSubnetGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBSubnetGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void DescribeEngineDefaultClusterParametersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEngineDefaultClusterParameters");

            var request = InstantiateClassGenerator.Execute<DescribeEngineDefaultClusterParametersRequest>();
            var marshaller = new DescribeEngineDefaultClusterParametersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeEngineDefaultClusterParametersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeEngineDefaultClusterParametersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
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
        [TestCategory("Neptune")]
        public void DescribeEventCategoriesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEventCategories");

            var request = InstantiateClassGenerator.Execute<DescribeEventCategoriesRequest>();
            var marshaller = new DescribeEventCategoriesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeEventCategoriesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeEventCategoriesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
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
        [TestCategory("Neptune")]
        public void DescribeEventSubscriptionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEventSubscriptions");

            var request = InstantiateClassGenerator.Execute<DescribeEventSubscriptionsRequest>();
            var marshaller = new DescribeEventSubscriptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeEventSubscriptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeEventSubscriptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void DescribeOrderableDBInstanceOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeOrderableDBInstanceOptions");

            var request = InstantiateClassGenerator.Execute<DescribeOrderableDBInstanceOptionsRequest>();
            var marshaller = new DescribeOrderableDBInstanceOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeOrderableDBInstanceOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeOrderableDBInstanceOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void DescribePendingMaintenanceActionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribePendingMaintenanceActions");

            var request = InstantiateClassGenerator.Execute<DescribePendingMaintenanceActionsRequest>();
            var marshaller = new DescribePendingMaintenanceActionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribePendingMaintenanceActionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribePendingMaintenanceActionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void DescribeValidDBInstanceModificationsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeValidDBInstanceModifications");

            var request = InstantiateClassGenerator.Execute<DescribeValidDBInstanceModificationsRequest>();
            var marshaller = new DescribeValidDBInstanceModificationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeValidDBInstanceModificationsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeValidDBInstanceModificationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void FailoverDBClusterMarshallTest()
        {
            var operation = service_model.FindOperation("FailoverDBCluster");

            var request = InstantiateClassGenerator.Execute<FailoverDBClusterRequest>();
            var marshaller = new FailoverDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = FailoverDBClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as FailoverDBClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
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
        [TestCategory("Neptune")]
        public void ModifyDBClusterMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBCluster");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterRequest>();
            var marshaller = new ModifyDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyDBClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyDBClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void ModifyDBClusterParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterParameterGroupRequest>();
            var marshaller = new ModifyDBClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyDBClusterParameterGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyDBClusterParameterGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void ModifyDBClusterSnapshotAttributeMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBClusterSnapshotAttribute");

            var request = InstantiateClassGenerator.Execute<ModifyDBClusterSnapshotAttributeRequest>();
            var marshaller = new ModifyDBClusterSnapshotAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyDBClusterSnapshotAttributeResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyDBClusterSnapshotAttributeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void ModifyDBInstanceMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBInstance");

            var request = InstantiateClassGenerator.Execute<ModifyDBInstanceRequest>();
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyDBInstanceResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyDBInstanceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void ModifyDBParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBParameterGroup");

            var request = InstantiateClassGenerator.Execute<ModifyDBParameterGroupRequest>();
            var marshaller = new ModifyDBParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyDBParameterGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyDBParameterGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void ModifyDBSubnetGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDBSubnetGroup");

            var request = InstantiateClassGenerator.Execute<ModifyDBSubnetGroupRequest>();
            var marshaller = new ModifyDBSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyDBSubnetGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyDBSubnetGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void ModifyEventSubscriptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyEventSubscription");

            var request = InstantiateClassGenerator.Execute<ModifyEventSubscriptionRequest>();
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyEventSubscriptionResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyEventSubscriptionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void PromoteReadReplicaDBClusterMarshallTest()
        {
            var operation = service_model.FindOperation("PromoteReadReplicaDBCluster");

            var request = InstantiateClassGenerator.Execute<PromoteReadReplicaDBClusterRequest>();
            var marshaller = new PromoteReadReplicaDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = PromoteReadReplicaDBClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as PromoteReadReplicaDBClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void RebootDBInstanceMarshallTest()
        {
            var operation = service_model.FindOperation("RebootDBInstance");

            var request = InstantiateClassGenerator.Execute<RebootDBInstanceRequest>();
            var marshaller = new RebootDBInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RebootDBInstanceResponseUnmarshaller.Instance.Unmarshall(context)
                as RebootDBInstanceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void RemoveRoleFromDBClusterMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveRoleFromDBCluster");

            var request = InstantiateClassGenerator.Execute<RemoveRoleFromDBClusterRequest>();
            var marshaller = new RemoveRoleFromDBClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void RemoveSourceIdentifierFromSubscriptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveSourceIdentifierFromSubscription");

            var request = InstantiateClassGenerator.Execute<RemoveSourceIdentifierFromSubscriptionRequest>();
            var marshaller = new RemoveSourceIdentifierFromSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RemoveSourceIdentifierFromSubscriptionResponseUnmarshaller.Instance.Unmarshall(context)
                as RemoveSourceIdentifierFromSubscriptionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void RemoveTagsFromResourceMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveTagsFromResource");

            var request = InstantiateClassGenerator.Execute<RemoveTagsFromResourceRequest>();
            var marshaller = new RemoveTagsFromResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void ResetDBClusterParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ResetDBClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<ResetDBClusterParameterGroupRequest>();
            var marshaller = new ResetDBClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ResetDBClusterParameterGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as ResetDBClusterParameterGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void ResetDBParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ResetDBParameterGroup");

            var request = InstantiateClassGenerator.Execute<ResetDBParameterGroupRequest>();
            var marshaller = new ResetDBParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ResetDBParameterGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as ResetDBParameterGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void RestoreDBClusterFromS3MarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromS3");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromS3Request>();
            var marshaller = new RestoreDBClusterFromS3RequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RestoreDBClusterFromS3ResponseUnmarshaller.Instance.Unmarshall(context)
                as RestoreDBClusterFromS3Response;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void RestoreDBClusterFromSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterFromSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterFromSnapshotRequest>();
            var marshaller = new RestoreDBClusterFromSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as RestoreDBClusterFromSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Neptune")]
        public void RestoreDBClusterToPointInTimeMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBClusterToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBClusterToPointInTimeRequest>();
            var marshaller = new RestoreDBClusterToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance.Unmarshall(context)
                as RestoreDBClusterToPointInTimeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
    }
}