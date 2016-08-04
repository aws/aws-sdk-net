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
 * Do not modify this file. This file is generated from the ec2-2016-04-01.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.EC2;
using Amazon.EC2.Model;
using Amazon.EC2.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;
using ServiceClientGenerator.Generators.SourceFiles;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class EC2MarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("ec2-2016-04-01.normal.json", "ec2.customizations.json");
        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AcceptVpcPeeringConnectionMarshallTest()
        {
            var operation = service_model.FindOperation("AcceptVpcPeeringConnection");

            var request = InstantiateClassGenerator.Execute<AcceptVpcPeeringConnectionRequest>();
            var marshaller = new AcceptVpcPeeringConnectionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AcceptVpcPeeringConnectionResponseUnmarshaller.Instance.Unmarshall(context)
                as AcceptVpcPeeringConnectionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AllocateAddressMarshallTest()
        {
            var operation = service_model.FindOperation("AllocateAddress");

            var request = InstantiateClassGenerator.Execute<AllocateAddressRequest>();
            var marshaller = new AllocateAddressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AllocateAddressResponseUnmarshaller.Instance.Unmarshall(context)
                as AllocateAddressResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AllocateHostsMarshallTest()
        {
            var operation = service_model.FindOperation("AllocateHosts");

            var request = InstantiateClassGenerator.Execute<AllocateHostsRequest>();
            var marshaller = new AllocateHostsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AllocateHostsResponseUnmarshaller.Instance.Unmarshall(context)
                as AllocateHostsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AssignPrivateIpAddressesMarshallTest()
        {
            var operation = service_model.FindOperation("AssignPrivateIpAddresses");

            var request = InstantiateClassGenerator.Execute<AssignPrivateIpAddressesRequest>();
            var marshaller = new AssignPrivateIpAddressesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AssociateAddressMarshallTest()
        {
            var operation = service_model.FindOperation("AssociateAddress");

            var request = InstantiateClassGenerator.Execute<AssociateAddressRequest>();
            var marshaller = new AssociateAddressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AssociateAddressResponseUnmarshaller.Instance.Unmarshall(context)
                as AssociateAddressResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AssociateDhcpOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("AssociateDhcpOptions");

            var request = InstantiateClassGenerator.Execute<AssociateDhcpOptionsRequest>();
            var marshaller = new AssociateDhcpOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AssociateRouteTableMarshallTest()
        {
            var operation = service_model.FindOperation("AssociateRouteTable");

            var request = InstantiateClassGenerator.Execute<AssociateRouteTableRequest>();
            var marshaller = new AssociateRouteTableRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AssociateRouteTableResponseUnmarshaller.Instance.Unmarshall(context)
                as AssociateRouteTableResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AttachClassicLinkVpcMarshallTest()
        {
            var operation = service_model.FindOperation("AttachClassicLinkVpc");

            var request = InstantiateClassGenerator.Execute<AttachClassicLinkVpcRequest>();
            var marshaller = new AttachClassicLinkVpcRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AttachClassicLinkVpcResponseUnmarshaller.Instance.Unmarshall(context)
                as AttachClassicLinkVpcResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AttachInternetGatewayMarshallTest()
        {
            var operation = service_model.FindOperation("AttachInternetGateway");

            var request = InstantiateClassGenerator.Execute<AttachInternetGatewayRequest>();
            var marshaller = new AttachInternetGatewayRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AttachNetworkInterfaceMarshallTest()
        {
            var operation = service_model.FindOperation("AttachNetworkInterface");

            var request = InstantiateClassGenerator.Execute<AttachNetworkInterfaceRequest>();
            var marshaller = new AttachNetworkInterfaceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AttachNetworkInterfaceResponseUnmarshaller.Instance.Unmarshall(context)
                as AttachNetworkInterfaceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AttachVolumeMarshallTest()
        {
            var operation = service_model.FindOperation("AttachVolume");

            var request = InstantiateClassGenerator.Execute<AttachVolumeRequest>();
            var marshaller = new AttachVolumeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AttachVolumeResponseUnmarshaller.Instance.Unmarshall(context)
                as AttachVolumeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AttachVpnGatewayMarshallTest()
        {
            var operation = service_model.FindOperation("AttachVpnGateway");

            var request = InstantiateClassGenerator.Execute<AttachVpnGatewayRequest>();
            var marshaller = new AttachVpnGatewayRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AttachVpnGatewayResponseUnmarshaller.Instance.Unmarshall(context)
                as AttachVpnGatewayResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AuthorizeSecurityGroupEgressMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeSecurityGroupEgress");

            var request = InstantiateClassGenerator.Execute<AuthorizeSecurityGroupEgressRequest>();
            var marshaller = new AuthorizeSecurityGroupEgressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AuthorizeSecurityGroupIngressMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeSecurityGroupIngress");

            var request = InstantiateClassGenerator.Execute<AuthorizeSecurityGroupIngressRequest>();
            var marshaller = new AuthorizeSecurityGroupIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void BundleInstanceMarshallTest()
        {
            var operation = service_model.FindOperation("BundleInstance");

            var request = InstantiateClassGenerator.Execute<BundleInstanceRequest>();
            var marshaller = new BundleInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = BundleInstanceResponseUnmarshaller.Instance.Unmarshall(context)
                as BundleInstanceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CancelBundleTaskMarshallTest()
        {
            var operation = service_model.FindOperation("CancelBundleTask");

            var request = InstantiateClassGenerator.Execute<CancelBundleTaskRequest>();
            var marshaller = new CancelBundleTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CancelBundleTaskResponseUnmarshaller.Instance.Unmarshall(context)
                as CancelBundleTaskResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CancelConversionTaskMarshallTest()
        {
            var operation = service_model.FindOperation("CancelConversionTask");

            var request = InstantiateClassGenerator.Execute<CancelConversionTaskRequest>();
            var marshaller = new CancelConversionTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CancelExportTaskMarshallTest()
        {
            var operation = service_model.FindOperation("CancelExportTask");

            var request = InstantiateClassGenerator.Execute<CancelExportTaskRequest>();
            var marshaller = new CancelExportTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CancelImportTaskMarshallTest()
        {
            var operation = service_model.FindOperation("CancelImportTask");

            var request = InstantiateClassGenerator.Execute<CancelImportTaskRequest>();
            var marshaller = new CancelImportTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CancelImportTaskResponseUnmarshaller.Instance.Unmarshall(context)
                as CancelImportTaskResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CancelReservedInstancesListingMarshallTest()
        {
            var operation = service_model.FindOperation("CancelReservedInstancesListing");

            var request = InstantiateClassGenerator.Execute<CancelReservedInstancesListingRequest>();
            var marshaller = new CancelReservedInstancesListingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CancelReservedInstancesListingResponseUnmarshaller.Instance.Unmarshall(context)
                as CancelReservedInstancesListingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CancelSpotFleetRequestsMarshallTest()
        {
            var operation = service_model.FindOperation("CancelSpotFleetRequests");

            var request = InstantiateClassGenerator.Execute<CancelSpotFleetRequestsRequest>();
            var marshaller = new CancelSpotFleetRequestsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CancelSpotFleetRequestsResponseUnmarshaller.Instance.Unmarshall(context)
                as CancelSpotFleetRequestsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CancelSpotInstanceRequestsMarshallTest()
        {
            var operation = service_model.FindOperation("CancelSpotInstanceRequests");

            var request = InstantiateClassGenerator.Execute<CancelSpotInstanceRequestsRequest>();
            var marshaller = new CancelSpotInstanceRequestsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CancelSpotInstanceRequestsResponseUnmarshaller.Instance.Unmarshall(context)
                as CancelSpotInstanceRequestsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ConfirmProductInstanceMarshallTest()
        {
            var operation = service_model.FindOperation("ConfirmProductInstance");

            var request = InstantiateClassGenerator.Execute<ConfirmProductInstanceRequest>();
            var marshaller = new ConfirmProductInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ConfirmProductInstanceResponseUnmarshaller.Instance.Unmarshall(context)
                as ConfirmProductInstanceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CopyImageMarshallTest()
        {
            var operation = service_model.FindOperation("CopyImage");

            var request = InstantiateClassGenerator.Execute<CopyImageRequest>();
            var marshaller = new CopyImageRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CopyImageResponseUnmarshaller.Instance.Unmarshall(context)
                as CopyImageResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CopySnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("CopySnapshot");

            var request = InstantiateClassGenerator.Execute<CopySnapshotRequest>();
            var marshaller = new CopySnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CopySnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as CopySnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateCustomerGatewayMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCustomerGateway");

            var request = InstantiateClassGenerator.Execute<CreateCustomerGatewayRequest>();
            var marshaller = new CreateCustomerGatewayRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateCustomerGatewayResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateCustomerGatewayResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateDhcpOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDhcpOptions");

            var request = InstantiateClassGenerator.Execute<CreateDhcpOptionsRequest>();
            var marshaller = new CreateDhcpOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateDhcpOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateDhcpOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateFlowLogsMarshallTest()
        {
            var operation = service_model.FindOperation("CreateFlowLogs");

            var request = InstantiateClassGenerator.Execute<CreateFlowLogsRequest>();
            var marshaller = new CreateFlowLogsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateFlowLogsResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateFlowLogsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateImageMarshallTest()
        {
            var operation = service_model.FindOperation("CreateImage");

            var request = InstantiateClassGenerator.Execute<CreateImageRequest>();
            var marshaller = new CreateImageRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateImageResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateImageResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateInstanceExportTaskMarshallTest()
        {
            var operation = service_model.FindOperation("CreateInstanceExportTask");

            var request = InstantiateClassGenerator.Execute<CreateInstanceExportTaskRequest>();
            var marshaller = new CreateInstanceExportTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateInstanceExportTaskResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateInstanceExportTaskResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateInternetGatewayMarshallTest()
        {
            var operation = service_model.FindOperation("CreateInternetGateway");

            var request = InstantiateClassGenerator.Execute<CreateInternetGatewayRequest>();
            var marshaller = new CreateInternetGatewayRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateInternetGatewayResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateInternetGatewayResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateKeyPairMarshallTest()
        {
            var operation = service_model.FindOperation("CreateKeyPair");

            var request = InstantiateClassGenerator.Execute<CreateKeyPairRequest>();
            var marshaller = new CreateKeyPairRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateKeyPairResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateKeyPairResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateNatGatewayMarshallTest()
        {
            var operation = service_model.FindOperation("CreateNatGateway");

            var request = InstantiateClassGenerator.Execute<CreateNatGatewayRequest>();
            var marshaller = new CreateNatGatewayRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateNatGatewayResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateNatGatewayResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateNetworkAclMarshallTest()
        {
            var operation = service_model.FindOperation("CreateNetworkAcl");

            var request = InstantiateClassGenerator.Execute<CreateNetworkAclRequest>();
            var marshaller = new CreateNetworkAclRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateNetworkAclResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateNetworkAclResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateNetworkAclEntryMarshallTest()
        {
            var operation = service_model.FindOperation("CreateNetworkAclEntry");

            var request = InstantiateClassGenerator.Execute<CreateNetworkAclEntryRequest>();
            var marshaller = new CreateNetworkAclEntryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateNetworkInterfaceMarshallTest()
        {
            var operation = service_model.FindOperation("CreateNetworkInterface");

            var request = InstantiateClassGenerator.Execute<CreateNetworkInterfaceRequest>();
            var marshaller = new CreateNetworkInterfaceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateNetworkInterfaceResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateNetworkInterfaceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreatePlacementGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreatePlacementGroup");

            var request = InstantiateClassGenerator.Execute<CreatePlacementGroupRequest>();
            var marshaller = new CreatePlacementGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateReservedInstancesListingMarshallTest()
        {
            var operation = service_model.FindOperation("CreateReservedInstancesListing");

            var request = InstantiateClassGenerator.Execute<CreateReservedInstancesListingRequest>();
            var marshaller = new CreateReservedInstancesListingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateReservedInstancesListingResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateReservedInstancesListingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateRouteMarshallTest()
        {
            var operation = service_model.FindOperation("CreateRoute");

            var request = InstantiateClassGenerator.Execute<CreateRouteRequest>();
            var marshaller = new CreateRouteRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateRouteResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateRouteResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateRouteTableMarshallTest()
        {
            var operation = service_model.FindOperation("CreateRouteTable");

            var request = InstantiateClassGenerator.Execute<CreateRouteTableRequest>();
            var marshaller = new CreateRouteTableRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateRouteTableResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateRouteTableResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateSecurityGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSecurityGroup");

            var request = InstantiateClassGenerator.Execute<CreateSecurityGroupRequest>();
            var marshaller = new CreateSecurityGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateSecurityGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateSecurityGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSnapshot");

            var request = InstantiateClassGenerator.Execute<CreateSnapshotRequest>();
            var marshaller = new CreateSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateSpotDatafeedSubscriptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSpotDatafeedSubscription");

            var request = InstantiateClassGenerator.Execute<CreateSpotDatafeedSubscriptionRequest>();
            var marshaller = new CreateSpotDatafeedSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateSpotDatafeedSubscriptionResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateSpotDatafeedSubscriptionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateSubnetMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSubnet");

            var request = InstantiateClassGenerator.Execute<CreateSubnetRequest>();
            var marshaller = new CreateSubnetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateSubnetResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateSubnetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
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
        [TestCategory("EC2")]
        public void CreateVolumeMarshallTest()
        {
            var operation = service_model.FindOperation("CreateVolume");

            var request = InstantiateClassGenerator.Execute<CreateVolumeRequest>();
            var marshaller = new CreateVolumeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateVolumeResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateVolumeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateVpcMarshallTest()
        {
            var operation = service_model.FindOperation("CreateVpc");

            var request = InstantiateClassGenerator.Execute<CreateVpcRequest>();
            var marshaller = new CreateVpcRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateVpcResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateVpcResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateVpcEndpointMarshallTest()
        {
            var operation = service_model.FindOperation("CreateVpcEndpoint");

            var request = InstantiateClassGenerator.Execute<CreateVpcEndpointRequest>();
            var marshaller = new CreateVpcEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateVpcEndpointResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateVpcEndpointResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateVpcPeeringConnectionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateVpcPeeringConnection");

            var request = InstantiateClassGenerator.Execute<CreateVpcPeeringConnectionRequest>();
            var marshaller = new CreateVpcPeeringConnectionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateVpcPeeringConnectionResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateVpcPeeringConnectionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateVpnConnectionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateVpnConnection");

            var request = InstantiateClassGenerator.Execute<CreateVpnConnectionRequest>();
            var marshaller = new CreateVpnConnectionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateVpnConnectionResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateVpnConnectionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateVpnConnectionRouteMarshallTest()
        {
            var operation = service_model.FindOperation("CreateVpnConnectionRoute");

            var request = InstantiateClassGenerator.Execute<CreateVpnConnectionRouteRequest>();
            var marshaller = new CreateVpnConnectionRouteRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateVpnGatewayMarshallTest()
        {
            var operation = service_model.FindOperation("CreateVpnGateway");

            var request = InstantiateClassGenerator.Execute<CreateVpnGatewayRequest>();
            var marshaller = new CreateVpnGatewayRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateVpnGatewayResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateVpnGatewayResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteCustomerGatewayMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCustomerGateway");

            var request = InstantiateClassGenerator.Execute<DeleteCustomerGatewayRequest>();
            var marshaller = new DeleteCustomerGatewayRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteDhcpOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDhcpOptions");

            var request = InstantiateClassGenerator.Execute<DeleteDhcpOptionsRequest>();
            var marshaller = new DeleteDhcpOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteFlowLogsMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteFlowLogs");

            var request = InstantiateClassGenerator.Execute<DeleteFlowLogsRequest>();
            var marshaller = new DeleteFlowLogsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteFlowLogsResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteFlowLogsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteInternetGatewayMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteInternetGateway");

            var request = InstantiateClassGenerator.Execute<DeleteInternetGatewayRequest>();
            var marshaller = new DeleteInternetGatewayRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteKeyPairMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteKeyPair");

            var request = InstantiateClassGenerator.Execute<DeleteKeyPairRequest>();
            var marshaller = new DeleteKeyPairRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteNatGatewayMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteNatGateway");

            var request = InstantiateClassGenerator.Execute<DeleteNatGatewayRequest>();
            var marshaller = new DeleteNatGatewayRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteNatGatewayResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteNatGatewayResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteNetworkAclMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteNetworkAcl");

            var request = InstantiateClassGenerator.Execute<DeleteNetworkAclRequest>();
            var marshaller = new DeleteNetworkAclRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteNetworkAclEntryMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteNetworkAclEntry");

            var request = InstantiateClassGenerator.Execute<DeleteNetworkAclEntryRequest>();
            var marshaller = new DeleteNetworkAclEntryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteNetworkInterfaceMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteNetworkInterface");

            var request = InstantiateClassGenerator.Execute<DeleteNetworkInterfaceRequest>();
            var marshaller = new DeleteNetworkInterfaceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeletePlacementGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeletePlacementGroup");

            var request = InstantiateClassGenerator.Execute<DeletePlacementGroupRequest>();
            var marshaller = new DeletePlacementGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteRouteMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteRoute");

            var request = InstantiateClassGenerator.Execute<DeleteRouteRequest>();
            var marshaller = new DeleteRouteRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteRouteTableMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteRouteTable");

            var request = InstantiateClassGenerator.Execute<DeleteRouteTableRequest>();
            var marshaller = new DeleteRouteTableRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteSecurityGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSecurityGroup");

            var request = InstantiateClassGenerator.Execute<DeleteSecurityGroupRequest>();
            var marshaller = new DeleteSecurityGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSnapshot");

            var request = InstantiateClassGenerator.Execute<DeleteSnapshotRequest>();
            var marshaller = new DeleteSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteSpotDatafeedSubscriptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSpotDatafeedSubscription");

            var request = InstantiateClassGenerator.Execute<DeleteSpotDatafeedSubscriptionRequest>();
            var marshaller = new DeleteSpotDatafeedSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteSubnetMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSubnet");

            var request = InstantiateClassGenerator.Execute<DeleteSubnetRequest>();
            var marshaller = new DeleteSubnetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
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
        [TestCategory("EC2")]
        public void DeleteVolumeMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteVolume");

            var request = InstantiateClassGenerator.Execute<DeleteVolumeRequest>();
            var marshaller = new DeleteVolumeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteVpcMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteVpc");

            var request = InstantiateClassGenerator.Execute<DeleteVpcRequest>();
            var marshaller = new DeleteVpcRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteVpcEndpointsMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteVpcEndpoints");

            var request = InstantiateClassGenerator.Execute<DeleteVpcEndpointsRequest>();
            var marshaller = new DeleteVpcEndpointsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteVpcEndpointsResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteVpcEndpointsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteVpcPeeringConnectionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteVpcPeeringConnection");

            var request = InstantiateClassGenerator.Execute<DeleteVpcPeeringConnectionRequest>();
            var marshaller = new DeleteVpcPeeringConnectionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteVpcPeeringConnectionResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteVpcPeeringConnectionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteVpnConnectionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteVpnConnection");

            var request = InstantiateClassGenerator.Execute<DeleteVpnConnectionRequest>();
            var marshaller = new DeleteVpnConnectionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteVpnConnectionRouteMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteVpnConnectionRoute");

            var request = InstantiateClassGenerator.Execute<DeleteVpnConnectionRouteRequest>();
            var marshaller = new DeleteVpnConnectionRouteRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteVpnGatewayMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteVpnGateway");

            var request = InstantiateClassGenerator.Execute<DeleteVpnGatewayRequest>();
            var marshaller = new DeleteVpnGatewayRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeregisterImageMarshallTest()
        {
            var operation = service_model.FindOperation("DeregisterImage");

            var request = InstantiateClassGenerator.Execute<DeregisterImageRequest>();
            var marshaller = new DeregisterImageRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeAccountAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAccountAttributes");

            var request = InstantiateClassGenerator.Execute<DescribeAccountAttributesRequest>();
            var marshaller = new DescribeAccountAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeAccountAttributesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeAccountAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeAddressesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAddresses");

            var request = InstantiateClassGenerator.Execute<DescribeAddressesRequest>();
            var marshaller = new DescribeAddressesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeAddressesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeAddressesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeAvailabilityZonesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAvailabilityZones");

            var request = InstantiateClassGenerator.Execute<DescribeAvailabilityZonesRequest>();
            var marshaller = new DescribeAvailabilityZonesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeAvailabilityZonesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeAvailabilityZonesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeBundleTasksMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeBundleTasks");

            var request = InstantiateClassGenerator.Execute<DescribeBundleTasksRequest>();
            var marshaller = new DescribeBundleTasksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeBundleTasksResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeBundleTasksResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeClassicLinkInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClassicLinkInstances");

            var request = InstantiateClassGenerator.Execute<DescribeClassicLinkInstancesRequest>();
            var marshaller = new DescribeClassicLinkInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeClassicLinkInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeClassicLinkInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeConversionTasksMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeConversionTasks");

            var request = InstantiateClassGenerator.Execute<DescribeConversionTasksRequest>();
            var marshaller = new DescribeConversionTasksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeConversionTasksResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeConversionTasksResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeCustomerGatewaysMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeCustomerGateways");

            var request = InstantiateClassGenerator.Execute<DescribeCustomerGatewaysRequest>();
            var marshaller = new DescribeCustomerGatewaysRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeCustomerGatewaysResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeCustomerGatewaysResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeDhcpOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeDhcpOptions");

            var request = InstantiateClassGenerator.Execute<DescribeDhcpOptionsRequest>();
            var marshaller = new DescribeDhcpOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeDhcpOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDhcpOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeExportTasksMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeExportTasks");

            var request = InstantiateClassGenerator.Execute<DescribeExportTasksRequest>();
            var marshaller = new DescribeExportTasksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeExportTasksResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeExportTasksResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeFlowLogsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeFlowLogs");

            var request = InstantiateClassGenerator.Execute<DescribeFlowLogsRequest>();
            var marshaller = new DescribeFlowLogsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeFlowLogsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeFlowLogsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeHostsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeHosts");

            var request = InstantiateClassGenerator.Execute<DescribeHostsRequest>();
            var marshaller = new DescribeHostsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeHostsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeHostsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeIdentityIdFormatMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeIdentityIdFormat");

            var request = InstantiateClassGenerator.Execute<DescribeIdentityIdFormatRequest>();
            var marshaller = new DescribeIdentityIdFormatRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeIdentityIdFormatResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeIdentityIdFormatResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeIdFormatMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeIdFormat");

            var request = InstantiateClassGenerator.Execute<DescribeIdFormatRequest>();
            var marshaller = new DescribeIdFormatRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeIdFormatResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeIdFormatResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeImageAttributeMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeImageAttribute");

            var request = InstantiateClassGenerator.Execute<DescribeImageAttributeRequest>();
            var marshaller = new DescribeImageAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeImageAttributeResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeImageAttributeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeImagesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeImages");

            var request = InstantiateClassGenerator.Execute<DescribeImagesRequest>();
            var marshaller = new DescribeImagesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeImagesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeImagesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeImportImageTasksMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeImportImageTasks");

            var request = InstantiateClassGenerator.Execute<DescribeImportImageTasksRequest>();
            var marshaller = new DescribeImportImageTasksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeImportImageTasksResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeImportImageTasksResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeImportSnapshotTasksMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeImportSnapshotTasks");

            var request = InstantiateClassGenerator.Execute<DescribeImportSnapshotTasksRequest>();
            var marshaller = new DescribeImportSnapshotTasksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeImportSnapshotTasksResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeImportSnapshotTasksResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeInstanceAttributeMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeInstanceAttribute");

            var request = InstantiateClassGenerator.Execute<DescribeInstanceAttributeRequest>();
            var marshaller = new DescribeInstanceAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeInstanceAttributeResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeInstanceAttributeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeInstances");

            var request = InstantiateClassGenerator.Execute<DescribeInstancesRequest>();
            var marshaller = new DescribeInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeInstanceStatusMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeInstanceStatus");

            var request = InstantiateClassGenerator.Execute<DescribeInstanceStatusRequest>();
            var marshaller = new DescribeInstanceStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeInstanceStatusResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeInstanceStatusResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeInternetGatewaysMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeInternetGateways");

            var request = InstantiateClassGenerator.Execute<DescribeInternetGatewaysRequest>();
            var marshaller = new DescribeInternetGatewaysRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeInternetGatewaysResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeInternetGatewaysResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeKeyPairsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeKeyPairs");

            var request = InstantiateClassGenerator.Execute<DescribeKeyPairsRequest>();
            var marshaller = new DescribeKeyPairsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeKeyPairsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeKeyPairsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeMovingAddressesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeMovingAddresses");

            var request = InstantiateClassGenerator.Execute<DescribeMovingAddressesRequest>();
            var marshaller = new DescribeMovingAddressesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeMovingAddressesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeMovingAddressesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeNatGatewaysMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeNatGateways");

            var request = InstantiateClassGenerator.Execute<DescribeNatGatewaysRequest>();
            var marshaller = new DescribeNatGatewaysRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeNatGatewaysResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeNatGatewaysResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeNetworkAclsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeNetworkAcls");

            var request = InstantiateClassGenerator.Execute<DescribeNetworkAclsRequest>();
            var marshaller = new DescribeNetworkAclsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeNetworkAclsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeNetworkAclsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeNetworkInterfaceAttributeMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeNetworkInterfaceAttribute");

            var request = InstantiateClassGenerator.Execute<DescribeNetworkInterfaceAttributeRequest>();
            var marshaller = new DescribeNetworkInterfaceAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeNetworkInterfaceAttributeResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeNetworkInterfaceAttributeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeNetworkInterfacesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeNetworkInterfaces");

            var request = InstantiateClassGenerator.Execute<DescribeNetworkInterfacesRequest>();
            var marshaller = new DescribeNetworkInterfacesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeNetworkInterfacesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeNetworkInterfacesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribePlacementGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribePlacementGroups");

            var request = InstantiateClassGenerator.Execute<DescribePlacementGroupsRequest>();
            var marshaller = new DescribePlacementGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribePlacementGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribePlacementGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribePrefixListsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribePrefixLists");

            var request = InstantiateClassGenerator.Execute<DescribePrefixListsRequest>();
            var marshaller = new DescribePrefixListsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribePrefixListsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribePrefixListsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeRegionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeRegions");

            var request = InstantiateClassGenerator.Execute<DescribeRegionsRequest>();
            var marshaller = new DescribeRegionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeRegionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeRegionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeReservedInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReservedInstances");

            var request = InstantiateClassGenerator.Execute<DescribeReservedInstancesRequest>();
            var marshaller = new DescribeReservedInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeReservedInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeReservedInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeReservedInstancesListingsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReservedInstancesListings");

            var request = InstantiateClassGenerator.Execute<DescribeReservedInstancesListingsRequest>();
            var marshaller = new DescribeReservedInstancesListingsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeReservedInstancesListingsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeReservedInstancesListingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeReservedInstancesModificationsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReservedInstancesModifications");

            var request = InstantiateClassGenerator.Execute<DescribeReservedInstancesModificationsRequest>();
            var marshaller = new DescribeReservedInstancesModificationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeReservedInstancesModificationsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeReservedInstancesModificationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeReservedInstancesOfferingsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReservedInstancesOfferings");

            var request = InstantiateClassGenerator.Execute<DescribeReservedInstancesOfferingsRequest>();
            var marshaller = new DescribeReservedInstancesOfferingsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeReservedInstancesOfferingsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeReservedInstancesOfferingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeRouteTablesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeRouteTables");

            var request = InstantiateClassGenerator.Execute<DescribeRouteTablesRequest>();
            var marshaller = new DescribeRouteTablesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeRouteTablesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeRouteTablesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeScheduledInstanceAvailabilityMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeScheduledInstanceAvailability");

            var request = InstantiateClassGenerator.Execute<DescribeScheduledInstanceAvailabilityRequest>();
            var marshaller = new DescribeScheduledInstanceAvailabilityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeScheduledInstanceAvailabilityResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeScheduledInstanceAvailabilityResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeScheduledInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeScheduledInstances");

            var request = InstantiateClassGenerator.Execute<DescribeScheduledInstancesRequest>();
            var marshaller = new DescribeScheduledInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeScheduledInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeScheduledInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeSecurityGroupReferencesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSecurityGroupReferences");

            var request = InstantiateClassGenerator.Execute<DescribeSecurityGroupReferencesRequest>();
            var marshaller = new DescribeSecurityGroupReferencesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeSecurityGroupReferencesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeSecurityGroupReferencesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeSecurityGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSecurityGroups");

            var request = InstantiateClassGenerator.Execute<DescribeSecurityGroupsRequest>();
            var marshaller = new DescribeSecurityGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeSecurityGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeSecurityGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeSnapshotAttributeMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSnapshotAttribute");

            var request = InstantiateClassGenerator.Execute<DescribeSnapshotAttributeRequest>();
            var marshaller = new DescribeSnapshotAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeSnapshotAttributeResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeSnapshotAttributeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeSnapshotsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSnapshots");

            var request = InstantiateClassGenerator.Execute<DescribeSnapshotsRequest>();
            var marshaller = new DescribeSnapshotsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeSnapshotsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeSnapshotsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeSpotDatafeedSubscriptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSpotDatafeedSubscription");

            var request = InstantiateClassGenerator.Execute<DescribeSpotDatafeedSubscriptionRequest>();
            var marshaller = new DescribeSpotDatafeedSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeSpotDatafeedSubscriptionResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeSpotDatafeedSubscriptionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeSpotFleetInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSpotFleetInstances");

            var request = InstantiateClassGenerator.Execute<DescribeSpotFleetInstancesRequest>();
            var marshaller = new DescribeSpotFleetInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeSpotFleetInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeSpotFleetInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeSpotFleetRequestHistoryMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSpotFleetRequestHistory");

            var request = InstantiateClassGenerator.Execute<DescribeSpotFleetRequestHistoryRequest>();
            var marshaller = new DescribeSpotFleetRequestHistoryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeSpotFleetRequestHistoryResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeSpotFleetRequestHistoryResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeSpotFleetRequestsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSpotFleetRequests");

            var request = InstantiateClassGenerator.Execute<DescribeSpotFleetRequestsRequest>();
            var marshaller = new DescribeSpotFleetRequestsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeSpotFleetRequestsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeSpotFleetRequestsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeSpotInstanceRequestsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSpotInstanceRequests");

            var request = InstantiateClassGenerator.Execute<DescribeSpotInstanceRequestsRequest>();
            var marshaller = new DescribeSpotInstanceRequestsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeSpotInstanceRequestsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeSpotInstanceRequestsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeSpotPriceHistoryMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSpotPriceHistory");

            var request = InstantiateClassGenerator.Execute<DescribeSpotPriceHistoryRequest>();
            var marshaller = new DescribeSpotPriceHistoryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeSpotPriceHistoryResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeSpotPriceHistoryResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeStaleSecurityGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeStaleSecurityGroups");

            var request = InstantiateClassGenerator.Execute<DescribeStaleSecurityGroupsRequest>();
            var marshaller = new DescribeStaleSecurityGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeStaleSecurityGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeStaleSecurityGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeSubnetsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSubnets");

            var request = InstantiateClassGenerator.Execute<DescribeSubnetsRequest>();
            var marshaller = new DescribeSubnetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeSubnetsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeSubnetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeTagsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTags");

            var request = InstantiateClassGenerator.Execute<DescribeTagsRequest>();
            var marshaller = new DescribeTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeTagsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTagsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeVolumeAttributeMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeVolumeAttribute");

            var request = InstantiateClassGenerator.Execute<DescribeVolumeAttributeRequest>();
            var marshaller = new DescribeVolumeAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeVolumeAttributeResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeVolumeAttributeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeVolumesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeVolumes");

            var request = InstantiateClassGenerator.Execute<DescribeVolumesRequest>();
            var marshaller = new DescribeVolumesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeVolumesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeVolumesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeVolumeStatusMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeVolumeStatus");

            var request = InstantiateClassGenerator.Execute<DescribeVolumeStatusRequest>();
            var marshaller = new DescribeVolumeStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeVolumeStatusResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeVolumeStatusResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeVpcAttributeMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeVpcAttribute");

            var request = InstantiateClassGenerator.Execute<DescribeVpcAttributeRequest>();
            var marshaller = new DescribeVpcAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeVpcAttributeResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeVpcAttributeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeVpcClassicLinkMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeVpcClassicLink");

            var request = InstantiateClassGenerator.Execute<DescribeVpcClassicLinkRequest>();
            var marshaller = new DescribeVpcClassicLinkRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeVpcClassicLinkResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeVpcClassicLinkResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeVpcClassicLinkDnsSupportMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeVpcClassicLinkDnsSupport");

            var request = InstantiateClassGenerator.Execute<DescribeVpcClassicLinkDnsSupportRequest>();
            var marshaller = new DescribeVpcClassicLinkDnsSupportRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeVpcClassicLinkDnsSupportResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeVpcClassicLinkDnsSupportResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeVpcEndpointsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeVpcEndpoints");

            var request = InstantiateClassGenerator.Execute<DescribeVpcEndpointsRequest>();
            var marshaller = new DescribeVpcEndpointsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeVpcEndpointsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeVpcEndpointsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeVpcEndpointServicesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeVpcEndpointServices");

            var request = InstantiateClassGenerator.Execute<DescribeVpcEndpointServicesRequest>();
            var marshaller = new DescribeVpcEndpointServicesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeVpcEndpointServicesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeVpcEndpointServicesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeVpcPeeringConnectionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeVpcPeeringConnections");

            var request = InstantiateClassGenerator.Execute<DescribeVpcPeeringConnectionsRequest>();
            var marshaller = new DescribeVpcPeeringConnectionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeVpcPeeringConnectionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeVpcPeeringConnectionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeVpcsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeVpcs");

            var request = InstantiateClassGenerator.Execute<DescribeVpcsRequest>();
            var marshaller = new DescribeVpcsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeVpcsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeVpcsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeVpnConnectionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeVpnConnections");

            var request = InstantiateClassGenerator.Execute<DescribeVpnConnectionsRequest>();
            var marshaller = new DescribeVpnConnectionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeVpnConnectionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeVpnConnectionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeVpnGatewaysMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeVpnGateways");

            var request = InstantiateClassGenerator.Execute<DescribeVpnGatewaysRequest>();
            var marshaller = new DescribeVpnGatewaysRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeVpnGatewaysResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeVpnGatewaysResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DetachClassicLinkVpcMarshallTest()
        {
            var operation = service_model.FindOperation("DetachClassicLinkVpc");

            var request = InstantiateClassGenerator.Execute<DetachClassicLinkVpcRequest>();
            var marshaller = new DetachClassicLinkVpcRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DetachClassicLinkVpcResponseUnmarshaller.Instance.Unmarshall(context)
                as DetachClassicLinkVpcResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DetachInternetGatewayMarshallTest()
        {
            var operation = service_model.FindOperation("DetachInternetGateway");

            var request = InstantiateClassGenerator.Execute<DetachInternetGatewayRequest>();
            var marshaller = new DetachInternetGatewayRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DetachNetworkInterfaceMarshallTest()
        {
            var operation = service_model.FindOperation("DetachNetworkInterface");

            var request = InstantiateClassGenerator.Execute<DetachNetworkInterfaceRequest>();
            var marshaller = new DetachNetworkInterfaceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DetachVolumeMarshallTest()
        {
            var operation = service_model.FindOperation("DetachVolume");

            var request = InstantiateClassGenerator.Execute<DetachVolumeRequest>();
            var marshaller = new DetachVolumeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DetachVolumeResponseUnmarshaller.Instance.Unmarshall(context)
                as DetachVolumeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DetachVpnGatewayMarshallTest()
        {
            var operation = service_model.FindOperation("DetachVpnGateway");

            var request = InstantiateClassGenerator.Execute<DetachVpnGatewayRequest>();
            var marshaller = new DetachVpnGatewayRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DisableVgwRoutePropagationMarshallTest()
        {
            var operation = service_model.FindOperation("DisableVgwRoutePropagation");

            var request = InstantiateClassGenerator.Execute<DisableVgwRoutePropagationRequest>();
            var marshaller = new DisableVgwRoutePropagationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DisableVpcClassicLinkMarshallTest()
        {
            var operation = service_model.FindOperation("DisableVpcClassicLink");

            var request = InstantiateClassGenerator.Execute<DisableVpcClassicLinkRequest>();
            var marshaller = new DisableVpcClassicLinkRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DisableVpcClassicLinkResponseUnmarshaller.Instance.Unmarshall(context)
                as DisableVpcClassicLinkResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DisableVpcClassicLinkDnsSupportMarshallTest()
        {
            var operation = service_model.FindOperation("DisableVpcClassicLinkDnsSupport");

            var request = InstantiateClassGenerator.Execute<DisableVpcClassicLinkDnsSupportRequest>();
            var marshaller = new DisableVpcClassicLinkDnsSupportRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DisableVpcClassicLinkDnsSupportResponseUnmarshaller.Instance.Unmarshall(context)
                as DisableVpcClassicLinkDnsSupportResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DisassociateAddressMarshallTest()
        {
            var operation = service_model.FindOperation("DisassociateAddress");

            var request = InstantiateClassGenerator.Execute<DisassociateAddressRequest>();
            var marshaller = new DisassociateAddressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DisassociateRouteTableMarshallTest()
        {
            var operation = service_model.FindOperation("DisassociateRouteTable");

            var request = InstantiateClassGenerator.Execute<DisassociateRouteTableRequest>();
            var marshaller = new DisassociateRouteTableRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void EnableVgwRoutePropagationMarshallTest()
        {
            var operation = service_model.FindOperation("EnableVgwRoutePropagation");

            var request = InstantiateClassGenerator.Execute<EnableVgwRoutePropagationRequest>();
            var marshaller = new EnableVgwRoutePropagationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void EnableVolumeIOMarshallTest()
        {
            var operation = service_model.FindOperation("EnableVolumeIO");

            var request = InstantiateClassGenerator.Execute<EnableVolumeIORequest>();
            var marshaller = new EnableVolumeIORequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void EnableVpcClassicLinkMarshallTest()
        {
            var operation = service_model.FindOperation("EnableVpcClassicLink");

            var request = InstantiateClassGenerator.Execute<EnableVpcClassicLinkRequest>();
            var marshaller = new EnableVpcClassicLinkRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = EnableVpcClassicLinkResponseUnmarshaller.Instance.Unmarshall(context)
                as EnableVpcClassicLinkResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void EnableVpcClassicLinkDnsSupportMarshallTest()
        {
            var operation = service_model.FindOperation("EnableVpcClassicLinkDnsSupport");

            var request = InstantiateClassGenerator.Execute<EnableVpcClassicLinkDnsSupportRequest>();
            var marshaller = new EnableVpcClassicLinkDnsSupportRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = EnableVpcClassicLinkDnsSupportResponseUnmarshaller.Instance.Unmarshall(context)
                as EnableVpcClassicLinkDnsSupportResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetConsoleOutputMarshallTest()
        {
            var operation = service_model.FindOperation("GetConsoleOutput");

            var request = InstantiateClassGenerator.Execute<GetConsoleOutputRequest>();
            var marshaller = new GetConsoleOutputRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetConsoleOutputResponseUnmarshaller.Instance.Unmarshall(context)
                as GetConsoleOutputResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetConsoleScreenshotMarshallTest()
        {
            var operation = service_model.FindOperation("GetConsoleScreenshot");

            var request = InstantiateClassGenerator.Execute<GetConsoleScreenshotRequest>();
            var marshaller = new GetConsoleScreenshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetConsoleScreenshotResponseUnmarshaller.Instance.Unmarshall(context)
                as GetConsoleScreenshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetPasswordDataMarshallTest()
        {
            var operation = service_model.FindOperation("GetPasswordData");

            var request = InstantiateClassGenerator.Execute<GetPasswordDataRequest>();
            var marshaller = new GetPasswordDataRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetPasswordDataResponseUnmarshaller.Instance.Unmarshall(context)
                as GetPasswordDataResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ImportImageMarshallTest()
        {
            var operation = service_model.FindOperation("ImportImage");

            var request = InstantiateClassGenerator.Execute<ImportImageRequest>();
            var marshaller = new ImportImageRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ImportImageResponseUnmarshaller.Instance.Unmarshall(context)
                as ImportImageResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ImportInstanceMarshallTest()
        {
            var operation = service_model.FindOperation("ImportInstance");

            var request = InstantiateClassGenerator.Execute<ImportInstanceRequest>();
            var marshaller = new ImportInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ImportInstanceResponseUnmarshaller.Instance.Unmarshall(context)
                as ImportInstanceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ImportKeyPairMarshallTest()
        {
            var operation = service_model.FindOperation("ImportKeyPair");

            var request = InstantiateClassGenerator.Execute<ImportKeyPairRequest>();
            var marshaller = new ImportKeyPairRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ImportKeyPairResponseUnmarshaller.Instance.Unmarshall(context)
                as ImportKeyPairResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ImportSnapshotMarshallTest()
        {
            var operation = service_model.FindOperation("ImportSnapshot");

            var request = InstantiateClassGenerator.Execute<ImportSnapshotRequest>();
            var marshaller = new ImportSnapshotRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ImportSnapshotResponseUnmarshaller.Instance.Unmarshall(context)
                as ImportSnapshotResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ImportVolumeMarshallTest()
        {
            var operation = service_model.FindOperation("ImportVolume");

            var request = InstantiateClassGenerator.Execute<ImportVolumeRequest>();
            var marshaller = new ImportVolumeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ImportVolumeResponseUnmarshaller.Instance.Unmarshall(context)
                as ImportVolumeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyHostsMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyHosts");

            var request = InstantiateClassGenerator.Execute<ModifyHostsRequest>();
            var marshaller = new ModifyHostsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyHostsResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyHostsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyIdentityIdFormatMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyIdentityIdFormat");

            var request = InstantiateClassGenerator.Execute<ModifyIdentityIdFormatRequest>();
            var marshaller = new ModifyIdentityIdFormatRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyIdFormatMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyIdFormat");

            var request = InstantiateClassGenerator.Execute<ModifyIdFormatRequest>();
            var marshaller = new ModifyIdFormatRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyImageAttributeMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyImageAttribute");

            var request = InstantiateClassGenerator.Execute<ModifyImageAttributeRequest>();
            var marshaller = new ModifyImageAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyInstanceAttributeMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyInstanceAttribute");

            var request = InstantiateClassGenerator.Execute<ModifyInstanceAttributeRequest>();
            var marshaller = new ModifyInstanceAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyInstancePlacementMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyInstancePlacement");

            var request = InstantiateClassGenerator.Execute<ModifyInstancePlacementRequest>();
            var marshaller = new ModifyInstancePlacementRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyInstancePlacementResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyInstancePlacementResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyNetworkInterfaceAttributeMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyNetworkInterfaceAttribute");

            var request = InstantiateClassGenerator.Execute<ModifyNetworkInterfaceAttributeRequest>();
            var marshaller = new ModifyNetworkInterfaceAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyReservedInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyReservedInstances");

            var request = InstantiateClassGenerator.Execute<ModifyReservedInstancesRequest>();
            var marshaller = new ModifyReservedInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyReservedInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyReservedInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifySnapshotAttributeMarshallTest()
        {
            var operation = service_model.FindOperation("ModifySnapshotAttribute");

            var request = InstantiateClassGenerator.Execute<ModifySnapshotAttributeRequest>();
            var marshaller = new ModifySnapshotAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifySpotFleetRequestMarshallTest()
        {
            var operation = service_model.FindOperation("ModifySpotFleetRequest");

            var request = InstantiateClassGenerator.Execute<ModifySpotFleetRequestRequest>();
            var marshaller = new ModifySpotFleetRequestRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifySpotFleetRequestResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifySpotFleetRequestResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifySubnetAttributeMarshallTest()
        {
            var operation = service_model.FindOperation("ModifySubnetAttribute");

            var request = InstantiateClassGenerator.Execute<ModifySubnetAttributeRequest>();
            var marshaller = new ModifySubnetAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyVolumeAttributeMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyVolumeAttribute");

            var request = InstantiateClassGenerator.Execute<ModifyVolumeAttributeRequest>();
            var marshaller = new ModifyVolumeAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyVpcAttributeMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyVpcAttribute");

            var request = InstantiateClassGenerator.Execute<ModifyVpcAttributeRequest>();
            var marshaller = new ModifyVpcAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyVpcEndpointMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyVpcEndpoint");

            var request = InstantiateClassGenerator.Execute<ModifyVpcEndpointRequest>();
            var marshaller = new ModifyVpcEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyVpcEndpointResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyVpcEndpointResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyVpcPeeringConnectionOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyVpcPeeringConnectionOptions");

            var request = InstantiateClassGenerator.Execute<ModifyVpcPeeringConnectionOptionsRequest>();
            var marshaller = new ModifyVpcPeeringConnectionOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyVpcPeeringConnectionOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyVpcPeeringConnectionOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void MonitorInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("MonitorInstances");

            var request = InstantiateClassGenerator.Execute<MonitorInstancesRequest>();
            var marshaller = new MonitorInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = MonitorInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as MonitorInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void MoveAddressToVpcMarshallTest()
        {
            var operation = service_model.FindOperation("MoveAddressToVpc");

            var request = InstantiateClassGenerator.Execute<MoveAddressToVpcRequest>();
            var marshaller = new MoveAddressToVpcRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = MoveAddressToVpcResponseUnmarshaller.Instance.Unmarshall(context)
                as MoveAddressToVpcResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void PurchaseReservedInstancesOfferingMarshallTest()
        {
            var operation = service_model.FindOperation("PurchaseReservedInstancesOffering");

            var request = InstantiateClassGenerator.Execute<PurchaseReservedInstancesOfferingRequest>();
            var marshaller = new PurchaseReservedInstancesOfferingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = PurchaseReservedInstancesOfferingResponseUnmarshaller.Instance.Unmarshall(context)
                as PurchaseReservedInstancesOfferingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void PurchaseScheduledInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("PurchaseScheduledInstances");

            var request = InstantiateClassGenerator.Execute<PurchaseScheduledInstancesRequest>();
            var marshaller = new PurchaseScheduledInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = PurchaseScheduledInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as PurchaseScheduledInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void RebootInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("RebootInstances");

            var request = InstantiateClassGenerator.Execute<RebootInstancesRequest>();
            var marshaller = new RebootInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void RegisterImageMarshallTest()
        {
            var operation = service_model.FindOperation("RegisterImage");

            var request = InstantiateClassGenerator.Execute<RegisterImageRequest>();
            var marshaller = new RegisterImageRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = RegisterImageResponseUnmarshaller.Instance.Unmarshall(context)
                as RegisterImageResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void RejectVpcPeeringConnectionMarshallTest()
        {
            var operation = service_model.FindOperation("RejectVpcPeeringConnection");

            var request = InstantiateClassGenerator.Execute<RejectVpcPeeringConnectionRequest>();
            var marshaller = new RejectVpcPeeringConnectionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = RejectVpcPeeringConnectionResponseUnmarshaller.Instance.Unmarshall(context)
                as RejectVpcPeeringConnectionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ReleaseAddressMarshallTest()
        {
            var operation = service_model.FindOperation("ReleaseAddress");

            var request = InstantiateClassGenerator.Execute<ReleaseAddressRequest>();
            var marshaller = new ReleaseAddressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ReleaseHostsMarshallTest()
        {
            var operation = service_model.FindOperation("ReleaseHosts");

            var request = InstantiateClassGenerator.Execute<ReleaseHostsRequest>();
            var marshaller = new ReleaseHostsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ReleaseHostsResponseUnmarshaller.Instance.Unmarshall(context)
                as ReleaseHostsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ReplaceNetworkAclAssociationMarshallTest()
        {
            var operation = service_model.FindOperation("ReplaceNetworkAclAssociation");

            var request = InstantiateClassGenerator.Execute<ReplaceNetworkAclAssociationRequest>();
            var marshaller = new ReplaceNetworkAclAssociationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ReplaceNetworkAclAssociationResponseUnmarshaller.Instance.Unmarshall(context)
                as ReplaceNetworkAclAssociationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ReplaceNetworkAclEntryMarshallTest()
        {
            var operation = service_model.FindOperation("ReplaceNetworkAclEntry");

            var request = InstantiateClassGenerator.Execute<ReplaceNetworkAclEntryRequest>();
            var marshaller = new ReplaceNetworkAclEntryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ReplaceRouteMarshallTest()
        {
            var operation = service_model.FindOperation("ReplaceRoute");

            var request = InstantiateClassGenerator.Execute<ReplaceRouteRequest>();
            var marshaller = new ReplaceRouteRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ReplaceRouteTableAssociationMarshallTest()
        {
            var operation = service_model.FindOperation("ReplaceRouteTableAssociation");

            var request = InstantiateClassGenerator.Execute<ReplaceRouteTableAssociationRequest>();
            var marshaller = new ReplaceRouteTableAssociationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ReplaceRouteTableAssociationResponseUnmarshaller.Instance.Unmarshall(context)
                as ReplaceRouteTableAssociationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ReportInstanceStatusMarshallTest()
        {
            var operation = service_model.FindOperation("ReportInstanceStatus");

            var request = InstantiateClassGenerator.Execute<ReportInstanceStatusRequest>();
            var marshaller = new ReportInstanceStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void RequestSpotFleetMarshallTest()
        {
            var operation = service_model.FindOperation("RequestSpotFleet");

            var request = InstantiateClassGenerator.Execute<RequestSpotFleetRequest>();
            var marshaller = new RequestSpotFleetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = RequestSpotFleetResponseUnmarshaller.Instance.Unmarshall(context)
                as RequestSpotFleetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void RequestSpotInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("RequestSpotInstances");

            var request = InstantiateClassGenerator.Execute<RequestSpotInstancesRequest>();
            var marshaller = new RequestSpotInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = RequestSpotInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as RequestSpotInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ResetImageAttributeMarshallTest()
        {
            var operation = service_model.FindOperation("ResetImageAttribute");

            var request = InstantiateClassGenerator.Execute<ResetImageAttributeRequest>();
            var marshaller = new ResetImageAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ResetInstanceAttributeMarshallTest()
        {
            var operation = service_model.FindOperation("ResetInstanceAttribute");

            var request = InstantiateClassGenerator.Execute<ResetInstanceAttributeRequest>();
            var marshaller = new ResetInstanceAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ResetNetworkInterfaceAttributeMarshallTest()
        {
            var operation = service_model.FindOperation("ResetNetworkInterfaceAttribute");

            var request = InstantiateClassGenerator.Execute<ResetNetworkInterfaceAttributeRequest>();
            var marshaller = new ResetNetworkInterfaceAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ResetSnapshotAttributeMarshallTest()
        {
            var operation = service_model.FindOperation("ResetSnapshotAttribute");

            var request = InstantiateClassGenerator.Execute<ResetSnapshotAttributeRequest>();
            var marshaller = new ResetSnapshotAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void RestoreAddressToClassicMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreAddressToClassic");

            var request = InstantiateClassGenerator.Execute<RestoreAddressToClassicRequest>();
            var marshaller = new RestoreAddressToClassicRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = RestoreAddressToClassicResponseUnmarshaller.Instance.Unmarshall(context)
                as RestoreAddressToClassicResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void RevokeSecurityGroupEgressMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeSecurityGroupEgress");

            var request = InstantiateClassGenerator.Execute<RevokeSecurityGroupEgressRequest>();
            var marshaller = new RevokeSecurityGroupEgressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void RevokeSecurityGroupIngressMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeSecurityGroupIngress");

            var request = InstantiateClassGenerator.Execute<RevokeSecurityGroupIngressRequest>();
            var marshaller = new RevokeSecurityGroupIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void RunInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("RunInstances");

            var request = InstantiateClassGenerator.Execute<RunInstancesRequest>();
            var marshaller = new RunInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = RunInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as RunInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void RunScheduledInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("RunScheduledInstances");

            var request = InstantiateClassGenerator.Execute<RunScheduledInstancesRequest>();
            var marshaller = new RunScheduledInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = RunScheduledInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as RunScheduledInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void StartInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("StartInstances");

            var request = InstantiateClassGenerator.Execute<StartInstancesRequest>();
            var marshaller = new StartInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = StartInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as StartInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void StopInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("StopInstances");

            var request = InstantiateClassGenerator.Execute<StopInstancesRequest>();
            var marshaller = new StopInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = StopInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as StopInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void TerminateInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("TerminateInstances");

            var request = InstantiateClassGenerator.Execute<TerminateInstancesRequest>();
            var marshaller = new TerminateInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = TerminateInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as TerminateInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void UnassignPrivateIpAddressesMarshallTest()
        {
            var operation = service_model.FindOperation("UnassignPrivateIpAddresses");

            var request = InstantiateClassGenerator.Execute<UnassignPrivateIpAddressesRequest>();
            var marshaller = new UnassignPrivateIpAddressesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void UnmonitorInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("UnmonitorInstances");

            var request = InstantiateClassGenerator.Execute<UnmonitorInstancesRequest>();
            var marshaller = new UnmonitorInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = UnmonitorInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as UnmonitorInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
    }
}