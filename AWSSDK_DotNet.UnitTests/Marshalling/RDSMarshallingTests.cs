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
 * Do not modify this file. This file is generated from the rds-2013-09-09.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.RDS;
using Amazon.RDS.Model;
using Amazon.RDS.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class RDSMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("rds-2013-09-09.normal.json", "rds.customizations.json");
        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
        public void AuthorizeDBSecurityGroupIngressMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeDBSecurityGroupIngress");

            var request = InstantiateClassGenerator.Execute<AuthorizeDBSecurityGroupIngressRequest>();
            var marshaller = new AuthorizeDBSecurityGroupIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = AuthorizeDBSecurityGroupIngressResponseUnmarshaller.Instance.Unmarshall(context)
                as AuthorizeDBSecurityGroupIngressResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CopyDBSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("CopyDBSnapshot");

            var request = InstantiateClassGenerator.Execute<CopyDBSnapshotRequest>();
            var marshaller = new CopyDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CopyDBSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as CopyDBSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
        public void CreateDBInstanceReadReplicaMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBInstanceReadReplica");

            var request = InstantiateClassGenerator.Execute<CreateDBInstanceReadReplicaRequest>();
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateDBInstanceReadReplicaResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
        public void CreateDBSecurityGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBSecurityGroup");

            var request = InstantiateClassGenerator.Execute<CreateDBSecurityGroupRequest>();
            var marshaller = new CreateDBSecurityGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateDBSecurityGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateDBSecurityGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void CreateDBSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDBSnapshot");

            var request = InstantiateClassGenerator.Execute<CreateDBSnapshotRequest>();
            var marshaller = new CreateDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateDBSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateDBSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
        public void CreateOptionGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateOptionGroup");

            var request = InstantiateClassGenerator.Execute<CreateOptionGroupRequest>();
            var marshaller = new CreateOptionGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateOptionGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateOptionGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
        public void DeleteDBSecurityGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBSecurityGroup");

            var request = InstantiateClassGenerator.Execute<DeleteDBSecurityGroupRequest>();
            var marshaller = new DeleteDBSecurityGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DeleteDBSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDBSnapshot");

            var request = InstantiateClassGenerator.Execute<DeleteDBSnapshotRequest>();
            var marshaller = new DeleteDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteDBSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteDBSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
        public void DeleteOptionGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteOptionGroup");

            var request = InstantiateClassGenerator.Execute<DeleteOptionGroupRequest>();
            var marshaller = new DeleteOptionGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
        public void DescribeDBLogFilesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBLogFiles");

            var request = InstantiateClassGenerator.Execute<DescribeDBLogFilesRequest>();
            var marshaller = new DescribeDBLogFilesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBLogFilesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBLogFilesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
        public void DescribeDBSecurityGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBSecurityGroups");

            var request = InstantiateClassGenerator.Execute<DescribeDBSecurityGroupsRequest>();
            var marshaller = new DescribeDBSecurityGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBSecurityGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBSecurityGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeDBSnapshotsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDBSnapshots");

            var request = InstantiateClassGenerator.Execute<DescribeDBSnapshotsRequest>();
            var marshaller = new DescribeDBSnapshotsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDBSnapshotsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDBSnapshotsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
        public void DescribeOptionGroupOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeOptionGroupOptions");

            var request = InstantiateClassGenerator.Execute<DescribeOptionGroupOptionsRequest>();
            var marshaller = new DescribeOptionGroupOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeOptionGroupOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeOptionGroupOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeOptionGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeOptionGroups");

            var request = InstantiateClassGenerator.Execute<DescribeOptionGroupsRequest>();
            var marshaller = new DescribeOptionGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeOptionGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeOptionGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
        public void DescribeReservedDBInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReservedDBInstances");

            var request = InstantiateClassGenerator.Execute<DescribeReservedDBInstancesRequest>();
            var marshaller = new DescribeReservedDBInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeReservedDBInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeReservedDBInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DescribeReservedDBInstancesOfferingsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReservedDBInstancesOfferings");

            var request = InstantiateClassGenerator.Execute<DescribeReservedDBInstancesOfferingsRequest>();
            var marshaller = new DescribeReservedDBInstancesOfferingsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeReservedDBInstancesOfferingsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeReservedDBInstancesOfferingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void DownloadDBLogFilePortionMarshallTest()
        {
            var operation = service_model.FindOperation("DownloadDBLogFilePortion");

            var request = InstantiateClassGenerator.Execute<DownloadDBLogFilePortionRequest>();
            var marshaller = new DownloadDBLogFilePortionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DownloadDBLogFilePortionResponseUnmarshaller.Instance.Unmarshall(context)
                as DownloadDBLogFilePortionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
        public void ModifyOptionGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyOptionGroup");

            var request = InstantiateClassGenerator.Execute<ModifyOptionGroupRequest>();
            var marshaller = new ModifyOptionGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyOptionGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyOptionGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void PromoteReadReplicaMarshallTest()
        {
            var operation = service_model.FindOperation("PromoteReadReplica");

            var request = InstantiateClassGenerator.Execute<PromoteReadReplicaRequest>();
            var marshaller = new PromoteReadReplicaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = PromoteReadReplicaResponseUnmarshaller.Instance.Unmarshall(context)
                as PromoteReadReplicaResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void PurchaseReservedDBInstancesOfferingMarshallTest()
        {
            var operation = service_model.FindOperation("PurchaseReservedDBInstancesOffering");

            var request = InstantiateClassGenerator.Execute<PurchaseReservedDBInstancesOfferingRequest>();
            var marshaller = new PurchaseReservedDBInstancesOfferingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = PurchaseReservedDBInstancesOfferingResponseUnmarshaller.Instance.Unmarshall(context)
                as PurchaseReservedDBInstancesOfferingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
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
        [TestCategory("RDS")]
        public void RestoreDBInstanceFromDBSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceFromDBSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceFromDBSnapshotRequest>();
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as RestoreDBInstanceFromDBSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RestoreDBInstanceToPointInTimeMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreDBInstanceToPointInTime");

            var request = InstantiateClassGenerator.Execute<RestoreDBInstanceToPointInTimeRequest>();
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance.Unmarshall(context)
                as RestoreDBInstanceToPointInTimeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("RDS")]
        public void RevokeDBSecurityGroupIngressMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeDBSecurityGroupIngress");

            var request = InstantiateClassGenerator.Execute<RevokeDBSecurityGroupIngressRequest>();
            var marshaller = new RevokeDBSecurityGroupIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RevokeDBSecurityGroupIngressResponseUnmarshaller.Instance.Unmarshall(context)
                as RevokeDBSecurityGroupIngressResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
    }
}