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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Redshift;
using Amazon.Redshift.Model;
using Amazon.Redshift.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class RedshiftMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("redshift-2012-12-01.normal.json", "redshift.customizations.json");
        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AuthorizeClusterSecurityGroupIngressMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeClusterSecurityGroupIngress");

            var request = InstantiateClassGenerator.Execute<AuthorizeClusterSecurityGroupIngressRequest>();
            var marshaller = new AuthorizeClusterSecurityGroupIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = AuthorizeClusterSecurityGroupIngressResponseUnmarshaller.Instance.Unmarshall(context)
                as AuthorizeClusterSecurityGroupIngressResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void AuthorizeSnapshotAccessMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeSnapshotAccess");

            var request = InstantiateClassGenerator.Execute<AuthorizeSnapshotAccessRequest>();
            var marshaller = new AuthorizeSnapshotAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = AuthorizeSnapshotAccessResponseUnmarshaller.Instance.Unmarshall(context)
                as AuthorizeSnapshotAccessResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CopyClusterSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("CopyClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CopyClusterSnapshotRequest>();
            var marshaller = new CopyClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CopyClusterSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as CopyClusterSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCluster");

            var request = InstantiateClassGenerator.Execute<CreateClusterRequest>();
            var marshaller = new CreateClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<CreateClusterParameterGroupRequest>();
            var marshaller = new CreateClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateClusterParameterGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateClusterParameterGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterSecurityGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterSecurityGroup");

            var request = InstantiateClassGenerator.Execute<CreateClusterSecurityGroupRequest>();
            var marshaller = new CreateClusterSecurityGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateClusterSecurityGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateClusterSecurityGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<CreateClusterSnapshotRequest>();
            var marshaller = new CreateClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateClusterSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateClusterSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateClusterSubnetGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClusterSubnetGroup");

            var request = InstantiateClassGenerator.Execute<CreateClusterSubnetGroupRequest>();
            var marshaller = new CreateClusterSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateClusterSubnetGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateClusterSubnetGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
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
        [TestCategory("Redshift")]
        public void CreateHsmClientCertificateMarshallTest()
        {
            var operation = service_model.FindOperation("CreateHsmClientCertificate");

            var request = InstantiateClassGenerator.Execute<CreateHsmClientCertificateRequest>();
            var marshaller = new CreateHsmClientCertificateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateHsmClientCertificateResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateHsmClientCertificateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateHsmConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("CreateHsmConfiguration");

            var request = InstantiateClassGenerator.Execute<CreateHsmConfigurationRequest>();
            var marshaller = new CreateHsmConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateHsmConfigurationResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateHsmConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateSnapshotCopyGrantMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSnapshotCopyGrant");

            var request = InstantiateClassGenerator.Execute<CreateSnapshotCopyGrantRequest>();
            var marshaller = new CreateSnapshotCopyGrantRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateSnapshotCopyGrantResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateSnapshotCopyGrantResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void CreateTagsMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTags");

            var request = InstantiateClassGenerator.Execute<CreateTagsRequest>();
            var marshaller = new CreateTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteClusterMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCluster");

            var request = InstantiateClassGenerator.Execute<DeleteClusterRequest>();
            var marshaller = new DeleteClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteClusterParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<DeleteClusterParameterGroupRequest>();
            var marshaller = new DeleteClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteClusterSecurityGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteClusterSecurityGroup");

            var request = InstantiateClassGenerator.Execute<DeleteClusterSecurityGroupRequest>();
            var marshaller = new DeleteClusterSecurityGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteClusterSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<DeleteClusterSnapshotRequest>();
            var marshaller = new DeleteClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteClusterSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteClusterSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteClusterSubnetGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteClusterSubnetGroup");

            var request = InstantiateClassGenerator.Execute<DeleteClusterSubnetGroupRequest>();
            var marshaller = new DeleteClusterSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteEventSubscriptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteEventSubscription");

            var request = InstantiateClassGenerator.Execute<DeleteEventSubscriptionRequest>();
            var marshaller = new DeleteEventSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteHsmClientCertificateMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteHsmClientCertificate");

            var request = InstantiateClassGenerator.Execute<DeleteHsmClientCertificateRequest>();
            var marshaller = new DeleteHsmClientCertificateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteHsmConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteHsmConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteHsmConfigurationRequest>();
            var marshaller = new DeleteHsmConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteSnapshotCopyGrantMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSnapshotCopyGrant");

            var request = InstantiateClassGenerator.Execute<DeleteSnapshotCopyGrantRequest>();
            var marshaller = new DeleteSnapshotCopyGrantRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DeleteTagsMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteTags");

            var request = InstantiateClassGenerator.Execute<DeleteTagsRequest>();
            var marshaller = new DeleteTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterParameterGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterParameterGroups");

            var request = InstantiateClassGenerator.Execute<DescribeClusterParameterGroupsRequest>();
            var marshaller = new DescribeClusterParameterGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeClusterParameterGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeClusterParameterGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterParametersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterParameters");

            var request = InstantiateClassGenerator.Execute<DescribeClusterParametersRequest>();
            var marshaller = new DescribeClusterParametersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeClusterParametersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeClusterParametersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClustersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusters");

            var request = InstantiateClassGenerator.Execute<DescribeClustersRequest>();
            var marshaller = new DescribeClustersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeClustersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeClustersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterSecurityGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterSecurityGroups");

            var request = InstantiateClassGenerator.Execute<DescribeClusterSecurityGroupsRequest>();
            var marshaller = new DescribeClusterSecurityGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeClusterSecurityGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeClusterSecurityGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterSnapshotsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterSnapshots");

            var request = InstantiateClassGenerator.Execute<DescribeClusterSnapshotsRequest>();
            var marshaller = new DescribeClusterSnapshotsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeClusterSnapshotsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeClusterSnapshotsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterSubnetGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterSubnetGroups");

            var request = InstantiateClassGenerator.Execute<DescribeClusterSubnetGroupsRequest>();
            var marshaller = new DescribeClusterSubnetGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeClusterSubnetGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeClusterSubnetGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeClusterVersionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClusterVersions");

            var request = InstantiateClassGenerator.Execute<DescribeClusterVersionsRequest>();
            var marshaller = new DescribeClusterVersionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeClusterVersionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeClusterVersionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeDefaultClusterParametersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDefaultClusterParameters");

            var request = InstantiateClassGenerator.Execute<DescribeDefaultClusterParametersRequest>();
            var marshaller = new DescribeDefaultClusterParametersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeDefaultClusterParametersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDefaultClusterParametersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
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
        [TestCategory("Redshift")]
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
        [TestCategory("Redshift")]
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
        [TestCategory("Redshift")]
        public void DescribeHsmClientCertificatesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeHsmClientCertificates");

            var request = InstantiateClassGenerator.Execute<DescribeHsmClientCertificatesRequest>();
            var marshaller = new DescribeHsmClientCertificatesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeHsmClientCertificatesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeHsmClientCertificatesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeHsmConfigurationsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeHsmConfigurations");

            var request = InstantiateClassGenerator.Execute<DescribeHsmConfigurationsRequest>();
            var marshaller = new DescribeHsmConfigurationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeHsmConfigurationsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeHsmConfigurationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeLoggingStatusMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLoggingStatus");

            var request = InstantiateClassGenerator.Execute<DescribeLoggingStatusRequest>();
            var marshaller = new DescribeLoggingStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeLoggingStatusResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeLoggingStatusResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeOrderableClusterOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeOrderableClusterOptions");

            var request = InstantiateClassGenerator.Execute<DescribeOrderableClusterOptionsRequest>();
            var marshaller = new DescribeOrderableClusterOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeOrderableClusterOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeOrderableClusterOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeReservedNodeOfferingsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReservedNodeOfferings");

            var request = InstantiateClassGenerator.Execute<DescribeReservedNodeOfferingsRequest>();
            var marshaller = new DescribeReservedNodeOfferingsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeReservedNodeOfferingsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeReservedNodeOfferingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeReservedNodesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReservedNodes");

            var request = InstantiateClassGenerator.Execute<DescribeReservedNodesRequest>();
            var marshaller = new DescribeReservedNodesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeReservedNodesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeReservedNodesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeResizeMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeResize");

            var request = InstantiateClassGenerator.Execute<DescribeResizeRequest>();
            var marshaller = new DescribeResizeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeResizeResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeResizeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeSnapshotCopyGrantsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSnapshotCopyGrants");

            var request = InstantiateClassGenerator.Execute<DescribeSnapshotCopyGrantsRequest>();
            var marshaller = new DescribeSnapshotCopyGrantsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeSnapshotCopyGrantsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeSnapshotCopyGrantsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeTableRestoreStatusMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTableRestoreStatus");

            var request = InstantiateClassGenerator.Execute<DescribeTableRestoreStatusRequest>();
            var marshaller = new DescribeTableRestoreStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeTableRestoreStatusResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTableRestoreStatusResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DescribeTagsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTags");

            var request = InstantiateClassGenerator.Execute<DescribeTagsRequest>();
            var marshaller = new DescribeTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeTagsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTagsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DisableLoggingMarshallTest()
        {
            var operation = service_model.FindOperation("DisableLogging");

            var request = InstantiateClassGenerator.Execute<DisableLoggingRequest>();
            var marshaller = new DisableLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DisableLoggingResponseUnmarshaller.Instance.Unmarshall(context)
                as DisableLoggingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void DisableSnapshotCopyMarshallTest()
        {
            var operation = service_model.FindOperation("DisableSnapshotCopy");

            var request = InstantiateClassGenerator.Execute<DisableSnapshotCopyRequest>();
            var marshaller = new DisableSnapshotCopyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DisableSnapshotCopyResponseUnmarshaller.Instance.Unmarshall(context)
                as DisableSnapshotCopyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void EnableLoggingMarshallTest()
        {
            var operation = service_model.FindOperation("EnableLogging");

            var request = InstantiateClassGenerator.Execute<EnableLoggingRequest>();
            var marshaller = new EnableLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = EnableLoggingResponseUnmarshaller.Instance.Unmarshall(context)
                as EnableLoggingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void EnableSnapshotCopyMarshallTest()
        {
            var operation = service_model.FindOperation("EnableSnapshotCopy");

            var request = InstantiateClassGenerator.Execute<EnableSnapshotCopyRequest>();
            var marshaller = new EnableSnapshotCopyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = EnableSnapshotCopyResponseUnmarshaller.Instance.Unmarshall(context)
                as EnableSnapshotCopyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCluster");

            var request = InstantiateClassGenerator.Execute<ModifyClusterRequest>();
            var marshaller = new ModifyClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterIamRolesMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterIamRoles");

            var request = InstantiateClassGenerator.Execute<ModifyClusterIamRolesRequest>();
            var marshaller = new ModifyClusterIamRolesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyClusterIamRolesResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyClusterIamRolesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<ModifyClusterParameterGroupRequest>();
            var marshaller = new ModifyClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyClusterParameterGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyClusterParameterGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ModifyClusterSubnetGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClusterSubnetGroup");

            var request = InstantiateClassGenerator.Execute<ModifyClusterSubnetGroupRequest>();
            var marshaller = new ModifyClusterSubnetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyClusterSubnetGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyClusterSubnetGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
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
        [TestCategory("Redshift")]
        public void ModifySnapshotCopyRetentionPeriodMarshallTest()
        {
            var operation = service_model.FindOperation("ModifySnapshotCopyRetentionPeriod");

            var request = InstantiateClassGenerator.Execute<ModifySnapshotCopyRetentionPeriodRequest>();
            var marshaller = new ModifySnapshotCopyRetentionPeriodRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifySnapshotCopyRetentionPeriodResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifySnapshotCopyRetentionPeriodResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void PurchaseReservedNodeOfferingMarshallTest()
        {
            var operation = service_model.FindOperation("PurchaseReservedNodeOffering");

            var request = InstantiateClassGenerator.Execute<PurchaseReservedNodeOfferingRequest>();
            var marshaller = new PurchaseReservedNodeOfferingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = PurchaseReservedNodeOfferingResponseUnmarshaller.Instance.Unmarshall(context)
                as PurchaseReservedNodeOfferingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RebootClusterMarshallTest()
        {
            var operation = service_model.FindOperation("RebootCluster");

            var request = InstantiateClassGenerator.Execute<RebootClusterRequest>();
            var marshaller = new RebootClusterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RebootClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as RebootClusterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void ResetClusterParameterGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ResetClusterParameterGroup");

            var request = InstantiateClassGenerator.Execute<ResetClusterParameterGroupRequest>();
            var marshaller = new ResetClusterParameterGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ResetClusterParameterGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as ResetClusterParameterGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreFromClusterSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreFromClusterSnapshotRequest>();
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RestoreFromClusterSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as RestoreFromClusterSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RestoreTableFromClusterSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreTableFromClusterSnapshot");

            var request = InstantiateClassGenerator.Execute<RestoreTableFromClusterSnapshotRequest>();
            var marshaller = new RestoreTableFromClusterSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RestoreTableFromClusterSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as RestoreTableFromClusterSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RevokeClusterSecurityGroupIngressMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeClusterSecurityGroupIngress");

            var request = InstantiateClassGenerator.Execute<RevokeClusterSecurityGroupIngressRequest>();
            var marshaller = new RevokeClusterSecurityGroupIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RevokeClusterSecurityGroupIngressResponseUnmarshaller.Instance.Unmarshall(context)
                as RevokeClusterSecurityGroupIngressResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RevokeSnapshotAccessMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeSnapshotAccess");

            var request = InstantiateClassGenerator.Execute<RevokeSnapshotAccessRequest>();
            var marshaller = new RevokeSnapshotAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RevokeSnapshotAccessResponseUnmarshaller.Instance.Unmarshall(context)
                as RevokeSnapshotAccessResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("Redshift")]
        public void RotateEncryptionKeyMarshallTest()
        {
            var operation = service_model.FindOperation("RotateEncryptionKey");

            var request = InstantiateClassGenerator.Execute<RotateEncryptionKeyRequest>();
            var marshaller = new RotateEncryptionKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RotateEncryptionKeyResponseUnmarshaller.Instance.Unmarshall(context)
                as RotateEncryptionKeyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
    }
}