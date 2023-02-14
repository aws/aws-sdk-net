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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        static readonly ServiceModel service_model = Utils.LoadServiceModel("ec2");
        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AcceptAddressTransferMarshallTest()
        {
            var operation = service_model.FindOperation("AcceptAddressTransfer");

            var request = InstantiateClassGenerator.Execute<AcceptAddressTransferRequest>();
            var marshaller = new AcceptAddressTransferRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AcceptAddressTransferResponseUnmarshaller.Instance.Unmarshall(context)
                as AcceptAddressTransferResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AcceptReservedInstancesExchangeQuoteMarshallTest()
        {
            var operation = service_model.FindOperation("AcceptReservedInstancesExchangeQuote");

            var request = InstantiateClassGenerator.Execute<AcceptReservedInstancesExchangeQuoteRequest>();
            var marshaller = new AcceptReservedInstancesExchangeQuoteRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AcceptReservedInstancesExchangeQuoteResponseUnmarshaller.Instance.Unmarshall(context)
                as AcceptReservedInstancesExchangeQuoteResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AcceptTransitGatewayMulticastDomainAssociationsMarshallTest()
        {
            var operation = service_model.FindOperation("AcceptTransitGatewayMulticastDomainAssociations");

            var request = InstantiateClassGenerator.Execute<AcceptTransitGatewayMulticastDomainAssociationsRequest>();
            var marshaller = new AcceptTransitGatewayMulticastDomainAssociationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AcceptTransitGatewayMulticastDomainAssociationsResponseUnmarshaller.Instance.Unmarshall(context)
                as AcceptTransitGatewayMulticastDomainAssociationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AcceptTransitGatewayPeeringAttachmentMarshallTest()
        {
            var operation = service_model.FindOperation("AcceptTransitGatewayPeeringAttachment");

            var request = InstantiateClassGenerator.Execute<AcceptTransitGatewayPeeringAttachmentRequest>();
            var marshaller = new AcceptTransitGatewayPeeringAttachmentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AcceptTransitGatewayPeeringAttachmentResponseUnmarshaller.Instance.Unmarshall(context)
                as AcceptTransitGatewayPeeringAttachmentResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AcceptTransitGatewayVpcAttachmentMarshallTest()
        {
            var operation = service_model.FindOperation("AcceptTransitGatewayVpcAttachment");

            var request = InstantiateClassGenerator.Execute<AcceptTransitGatewayVpcAttachmentRequest>();
            var marshaller = new AcceptTransitGatewayVpcAttachmentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AcceptTransitGatewayVpcAttachmentResponseUnmarshaller.Instance.Unmarshall(context)
                as AcceptTransitGatewayVpcAttachmentResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AcceptVpcEndpointConnectionsMarshallTest()
        {
            var operation = service_model.FindOperation("AcceptVpcEndpointConnections");

            var request = InstantiateClassGenerator.Execute<AcceptVpcEndpointConnectionsRequest>();
            var marshaller = new AcceptVpcEndpointConnectionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AcceptVpcEndpointConnectionsResponseUnmarshaller.Instance.Unmarshall(context)
                as AcceptVpcEndpointConnectionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

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
        public void AdvertiseByoipCidrMarshallTest()
        {
            var operation = service_model.FindOperation("AdvertiseByoipCidr");

            var request = InstantiateClassGenerator.Execute<AdvertiseByoipCidrRequest>();
            var marshaller = new AdvertiseByoipCidrRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AdvertiseByoipCidrResponseUnmarshaller.Instance.Unmarshall(context)
                as AdvertiseByoipCidrResponse;   
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
        public void AllocateIpamPoolCidrMarshallTest()
        {
            var operation = service_model.FindOperation("AllocateIpamPoolCidr");

            var request = InstantiateClassGenerator.Execute<AllocateIpamPoolCidrRequest>();
            var marshaller = new AllocateIpamPoolCidrRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AllocateIpamPoolCidrResponseUnmarshaller.Instance.Unmarshall(context)
                as AllocateIpamPoolCidrResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ApplySecurityGroupsToClientVpnTargetNetworkMarshallTest()
        {
            var operation = service_model.FindOperation("ApplySecurityGroupsToClientVpnTargetNetwork");

            var request = InstantiateClassGenerator.Execute<ApplySecurityGroupsToClientVpnTargetNetworkRequest>();
            var marshaller = new ApplySecurityGroupsToClientVpnTargetNetworkRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ApplySecurityGroupsToClientVpnTargetNetworkResponseUnmarshaller.Instance.Unmarshall(context)
                as ApplySecurityGroupsToClientVpnTargetNetworkResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AssignIpv6AddressesMarshallTest()
        {
            var operation = service_model.FindOperation("AssignIpv6Addresses");

            var request = InstantiateClassGenerator.Execute<AssignIpv6AddressesRequest>();
            var marshaller = new AssignIpv6AddressesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AssignIpv6AddressesResponseUnmarshaller.Instance.Unmarshall(context)
                as AssignIpv6AddressesResponse;   
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


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AssignPrivateIpAddressesResponseUnmarshaller.Instance.Unmarshall(context)
                as AssignPrivateIpAddressesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AssignPrivateNatGatewayAddressMarshallTest()
        {
            var operation = service_model.FindOperation("AssignPrivateNatGatewayAddress");

            var request = InstantiateClassGenerator.Execute<AssignPrivateNatGatewayAddressRequest>();
            var marshaller = new AssignPrivateNatGatewayAddressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AssignPrivateNatGatewayAddressResponseUnmarshaller.Instance.Unmarshall(context)
                as AssignPrivateNatGatewayAddressResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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
        public void AssociateClientVpnTargetNetworkMarshallTest()
        {
            var operation = service_model.FindOperation("AssociateClientVpnTargetNetwork");

            var request = InstantiateClassGenerator.Execute<AssociateClientVpnTargetNetworkRequest>();
            var marshaller = new AssociateClientVpnTargetNetworkRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AssociateClientVpnTargetNetworkResponseUnmarshaller.Instance.Unmarshall(context)
                as AssociateClientVpnTargetNetworkResponse;   
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
        public void AssociateEnclaveCertificateIamRoleMarshallTest()
        {
            var operation = service_model.FindOperation("AssociateEnclaveCertificateIamRole");

            var request = InstantiateClassGenerator.Execute<AssociateEnclaveCertificateIamRoleRequest>();
            var marshaller = new AssociateEnclaveCertificateIamRoleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AssociateEnclaveCertificateIamRoleResponseUnmarshaller.Instance.Unmarshall(context)
                as AssociateEnclaveCertificateIamRoleResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AssociateIamInstanceProfileMarshallTest()
        {
            var operation = service_model.FindOperation("AssociateIamInstanceProfile");

            var request = InstantiateClassGenerator.Execute<AssociateIamInstanceProfileRequest>();
            var marshaller = new AssociateIamInstanceProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AssociateIamInstanceProfileResponseUnmarshaller.Instance.Unmarshall(context)
                as AssociateIamInstanceProfileResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AssociateInstanceEventWindowMarshallTest()
        {
            var operation = service_model.FindOperation("AssociateInstanceEventWindow");

            var request = InstantiateClassGenerator.Execute<AssociateInstanceEventWindowRequest>();
            var marshaller = new AssociateInstanceEventWindowRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AssociateInstanceEventWindowResponseUnmarshaller.Instance.Unmarshall(context)
                as AssociateInstanceEventWindowResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AssociateIpamResourceDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("AssociateIpamResourceDiscovery");

            var request = InstantiateClassGenerator.Execute<AssociateIpamResourceDiscoveryRequest>();
            var marshaller = new AssociateIpamResourceDiscoveryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AssociateIpamResourceDiscoveryResponseUnmarshaller.Instance.Unmarshall(context)
                as AssociateIpamResourceDiscoveryResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AssociateNatGatewayAddressMarshallTest()
        {
            var operation = service_model.FindOperation("AssociateNatGatewayAddress");

            var request = InstantiateClassGenerator.Execute<AssociateNatGatewayAddressRequest>();
            var marshaller = new AssociateNatGatewayAddressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AssociateNatGatewayAddressResponseUnmarshaller.Instance.Unmarshall(context)
                as AssociateNatGatewayAddressResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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
        public void AssociateSubnetCidrBlockMarshallTest()
        {
            var operation = service_model.FindOperation("AssociateSubnetCidrBlock");

            var request = InstantiateClassGenerator.Execute<AssociateSubnetCidrBlockRequest>();
            var marshaller = new AssociateSubnetCidrBlockRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AssociateSubnetCidrBlockResponseUnmarshaller.Instance.Unmarshall(context)
                as AssociateSubnetCidrBlockResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AssociateTransitGatewayMulticastDomainMarshallTest()
        {
            var operation = service_model.FindOperation("AssociateTransitGatewayMulticastDomain");

            var request = InstantiateClassGenerator.Execute<AssociateTransitGatewayMulticastDomainRequest>();
            var marshaller = new AssociateTransitGatewayMulticastDomainRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AssociateTransitGatewayMulticastDomainResponseUnmarshaller.Instance.Unmarshall(context)
                as AssociateTransitGatewayMulticastDomainResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AssociateTransitGatewayPolicyTableMarshallTest()
        {
            var operation = service_model.FindOperation("AssociateTransitGatewayPolicyTable");

            var request = InstantiateClassGenerator.Execute<AssociateTransitGatewayPolicyTableRequest>();
            var marshaller = new AssociateTransitGatewayPolicyTableRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AssociateTransitGatewayPolicyTableResponseUnmarshaller.Instance.Unmarshall(context)
                as AssociateTransitGatewayPolicyTableResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AssociateTransitGatewayRouteTableMarshallTest()
        {
            var operation = service_model.FindOperation("AssociateTransitGatewayRouteTable");

            var request = InstantiateClassGenerator.Execute<AssociateTransitGatewayRouteTableRequest>();
            var marshaller = new AssociateTransitGatewayRouteTableRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AssociateTransitGatewayRouteTableResponseUnmarshaller.Instance.Unmarshall(context)
                as AssociateTransitGatewayRouteTableResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AssociateTrunkInterfaceMarshallTest()
        {
            var operation = service_model.FindOperation("AssociateTrunkInterface");

            var request = InstantiateClassGenerator.Execute<AssociateTrunkInterfaceRequest>();
            var marshaller = new AssociateTrunkInterfaceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AssociateTrunkInterfaceResponseUnmarshaller.Instance.Unmarshall(context)
                as AssociateTrunkInterfaceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void AssociateVpcCidrBlockMarshallTest()
        {
            var operation = service_model.FindOperation("AssociateVpcCidrBlock");

            var request = InstantiateClassGenerator.Execute<AssociateVpcCidrBlockRequest>();
            var marshaller = new AssociateVpcCidrBlockRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AssociateVpcCidrBlockResponseUnmarshaller.Instance.Unmarshall(context)
                as AssociateVpcCidrBlockResponse;   
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
        public void AttachVerifiedAccessTrustProviderMarshallTest()
        {
            var operation = service_model.FindOperation("AttachVerifiedAccessTrustProvider");

            var request = InstantiateClassGenerator.Execute<AttachVerifiedAccessTrustProviderRequest>();
            var marshaller = new AttachVerifiedAccessTrustProviderRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AttachVerifiedAccessTrustProviderResponseUnmarshaller.Instance.Unmarshall(context)
                as AttachVerifiedAccessTrustProviderResponse;   
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
        public void AuthorizeClientVpnIngressMarshallTest()
        {
            var operation = service_model.FindOperation("AuthorizeClientVpnIngress");

            var request = InstantiateClassGenerator.Execute<AuthorizeClientVpnIngressRequest>();
            var marshaller = new AuthorizeClientVpnIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AuthorizeClientVpnIngressResponseUnmarshaller.Instance.Unmarshall(context)
                as AuthorizeClientVpnIngressResponse;   
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


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AuthorizeSecurityGroupEgressResponseUnmarshaller.Instance.Unmarshall(context)
                as AuthorizeSecurityGroupEgressResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = AuthorizeSecurityGroupIngressResponseUnmarshaller.Instance.Unmarshall(context)
                as AuthorizeSecurityGroupIngressResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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
        public void CancelCapacityReservationMarshallTest()
        {
            var operation = service_model.FindOperation("CancelCapacityReservation");

            var request = InstantiateClassGenerator.Execute<CancelCapacityReservationRequest>();
            var marshaller = new CancelCapacityReservationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CancelCapacityReservationResponseUnmarshaller.Instance.Unmarshall(context)
                as CancelCapacityReservationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CancelCapacityReservationFleetsMarshallTest()
        {
            var operation = service_model.FindOperation("CancelCapacityReservationFleets");

            var request = InstantiateClassGenerator.Execute<CancelCapacityReservationFleetsRequest>();
            var marshaller = new CancelCapacityReservationFleetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CancelCapacityReservationFleetsResponseUnmarshaller.Instance.Unmarshall(context)
                as CancelCapacityReservationFleetsResponse;   
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
        public void CancelImageLaunchPermissionMarshallTest()
        {
            var operation = service_model.FindOperation("CancelImageLaunchPermission");

            var request = InstantiateClassGenerator.Execute<CancelImageLaunchPermissionRequest>();
            var marshaller = new CancelImageLaunchPermissionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CancelImageLaunchPermissionResponseUnmarshaller.Instance.Unmarshall(context)
                as CancelImageLaunchPermissionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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
        public void CopyFpgaImageMarshallTest()
        {
            var operation = service_model.FindOperation("CopyFpgaImage");

            var request = InstantiateClassGenerator.Execute<CopyFpgaImageRequest>();
            var marshaller = new CopyFpgaImageRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CopyFpgaImageResponseUnmarshaller.Instance.Unmarshall(context)
                as CopyFpgaImageResponse;   
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
        public void CreateCapacityReservationMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCapacityReservation");

            var request = InstantiateClassGenerator.Execute<CreateCapacityReservationRequest>();
            var marshaller = new CreateCapacityReservationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateCapacityReservationResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateCapacityReservationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateCapacityReservationFleetMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCapacityReservationFleet");

            var request = InstantiateClassGenerator.Execute<CreateCapacityReservationFleetRequest>();
            var marshaller = new CreateCapacityReservationFleetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateCapacityReservationFleetResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateCapacityReservationFleetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateCarrierGatewayMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCarrierGateway");

            var request = InstantiateClassGenerator.Execute<CreateCarrierGatewayRequest>();
            var marshaller = new CreateCarrierGatewayRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateCarrierGatewayResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateCarrierGatewayResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateClientVpnEndpointMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClientVpnEndpoint");

            var request = InstantiateClassGenerator.Execute<CreateClientVpnEndpointRequest>();
            var marshaller = new CreateClientVpnEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateClientVpnEndpointResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateClientVpnEndpointResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateClientVpnRouteMarshallTest()
        {
            var operation = service_model.FindOperation("CreateClientVpnRoute");

            var request = InstantiateClassGenerator.Execute<CreateClientVpnRouteRequest>();
            var marshaller = new CreateClientVpnRouteRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateClientVpnRouteResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateClientVpnRouteResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateCoipCidrMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCoipCidr");

            var request = InstantiateClassGenerator.Execute<CreateCoipCidrRequest>();
            var marshaller = new CreateCoipCidrRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateCoipCidrResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateCoipCidrResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateCoipPoolMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCoipPool");

            var request = InstantiateClassGenerator.Execute<CreateCoipPoolRequest>();
            var marshaller = new CreateCoipPoolRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateCoipPoolResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateCoipPoolResponse;   
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
        public void CreateDefaultSubnetMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDefaultSubnet");

            var request = InstantiateClassGenerator.Execute<CreateDefaultSubnetRequest>();
            var marshaller = new CreateDefaultSubnetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateDefaultSubnetResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateDefaultSubnetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateDefaultVpcMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDefaultVpc");

            var request = InstantiateClassGenerator.Execute<CreateDefaultVpcRequest>();
            var marshaller = new CreateDefaultVpcRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateDefaultVpcResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateDefaultVpcResponse;   
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
        public void CreateEgressOnlyInternetGatewayMarshallTest()
        {
            var operation = service_model.FindOperation("CreateEgressOnlyInternetGateway");

            var request = InstantiateClassGenerator.Execute<CreateEgressOnlyInternetGatewayRequest>();
            var marshaller = new CreateEgressOnlyInternetGatewayRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateEgressOnlyInternetGatewayResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateEgressOnlyInternetGatewayResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateFleetMarshallTest()
        {
            var operation = service_model.FindOperation("CreateFleet");

            var request = InstantiateClassGenerator.Execute<CreateFleetRequest>();
            var marshaller = new CreateFleetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateFleetResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateFleetResponse;   
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
        public void CreateFpgaImageMarshallTest()
        {
            var operation = service_model.FindOperation("CreateFpgaImage");

            var request = InstantiateClassGenerator.Execute<CreateFpgaImageRequest>();
            var marshaller = new CreateFpgaImageRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateFpgaImageResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateFpgaImageResponse;   
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
        public void CreateInstanceEventWindowMarshallTest()
        {
            var operation = service_model.FindOperation("CreateInstanceEventWindow");

            var request = InstantiateClassGenerator.Execute<CreateInstanceEventWindowRequest>();
            var marshaller = new CreateInstanceEventWindowRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateInstanceEventWindowResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateInstanceEventWindowResponse;   
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
        public void CreateIpamMarshallTest()
        {
            var operation = service_model.FindOperation("CreateIpam");

            var request = InstantiateClassGenerator.Execute<CreateIpamRequest>();
            var marshaller = new CreateIpamRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateIpamResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateIpamResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateIpamPoolMarshallTest()
        {
            var operation = service_model.FindOperation("CreateIpamPool");

            var request = InstantiateClassGenerator.Execute<CreateIpamPoolRequest>();
            var marshaller = new CreateIpamPoolRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateIpamPoolResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateIpamPoolResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateIpamResourceDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("CreateIpamResourceDiscovery");

            var request = InstantiateClassGenerator.Execute<CreateIpamResourceDiscoveryRequest>();
            var marshaller = new CreateIpamResourceDiscoveryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateIpamResourceDiscoveryResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateIpamResourceDiscoveryResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateIpamScopeMarshallTest()
        {
            var operation = service_model.FindOperation("CreateIpamScope");

            var request = InstantiateClassGenerator.Execute<CreateIpamScopeRequest>();
            var marshaller = new CreateIpamScopeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateIpamScopeResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateIpamScopeResponse;   
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
        public void CreateLaunchTemplateMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLaunchTemplate");

            var request = InstantiateClassGenerator.Execute<CreateLaunchTemplateRequest>();
            var marshaller = new CreateLaunchTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateLaunchTemplateResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateLaunchTemplateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateLaunchTemplateVersionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLaunchTemplateVersion");

            var request = InstantiateClassGenerator.Execute<CreateLaunchTemplateVersionRequest>();
            var marshaller = new CreateLaunchTemplateVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateLaunchTemplateVersionResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateLaunchTemplateVersionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateLocalGatewayRouteMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLocalGatewayRoute");

            var request = InstantiateClassGenerator.Execute<CreateLocalGatewayRouteRequest>();
            var marshaller = new CreateLocalGatewayRouteRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateLocalGatewayRouteResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateLocalGatewayRouteResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateLocalGatewayRouteTableMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLocalGatewayRouteTable");

            var request = InstantiateClassGenerator.Execute<CreateLocalGatewayRouteTableRequest>();
            var marshaller = new CreateLocalGatewayRouteTableRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateLocalGatewayRouteTableResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateLocalGatewayRouteTableResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateLocalGatewayRouteTableVirtualInterfaceGroupAssociationMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLocalGatewayRouteTableVirtualInterfaceGroupAssociation");

            var request = InstantiateClassGenerator.Execute<CreateLocalGatewayRouteTableVirtualInterfaceGroupAssociationRequest>();
            var marshaller = new CreateLocalGatewayRouteTableVirtualInterfaceGroupAssociationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateLocalGatewayRouteTableVirtualInterfaceGroupAssociationResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateLocalGatewayRouteTableVirtualInterfaceGroupAssociationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateLocalGatewayRouteTableVpcAssociationMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLocalGatewayRouteTableVpcAssociation");

            var request = InstantiateClassGenerator.Execute<CreateLocalGatewayRouteTableVpcAssociationRequest>();
            var marshaller = new CreateLocalGatewayRouteTableVpcAssociationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateLocalGatewayRouteTableVpcAssociationResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateLocalGatewayRouteTableVpcAssociationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateManagedPrefixListMarshallTest()
        {
            var operation = service_model.FindOperation("CreateManagedPrefixList");

            var request = InstantiateClassGenerator.Execute<CreateManagedPrefixListRequest>();
            var marshaller = new CreateManagedPrefixListRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateManagedPrefixListResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateManagedPrefixListResponse;   
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
        public void CreateNetworkInsightsAccessScopeMarshallTest()
        {
            var operation = service_model.FindOperation("CreateNetworkInsightsAccessScope");

            var request = InstantiateClassGenerator.Execute<CreateNetworkInsightsAccessScopeRequest>();
            var marshaller = new CreateNetworkInsightsAccessScopeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateNetworkInsightsAccessScopeResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateNetworkInsightsAccessScopeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateNetworkInsightsPathMarshallTest()
        {
            var operation = service_model.FindOperation("CreateNetworkInsightsPath");

            var request = InstantiateClassGenerator.Execute<CreateNetworkInsightsPathRequest>();
            var marshaller = new CreateNetworkInsightsPathRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateNetworkInsightsPathResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateNetworkInsightsPathResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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
        public void CreateNetworkInterfacePermissionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateNetworkInterfacePermission");

            var request = InstantiateClassGenerator.Execute<CreateNetworkInterfacePermissionRequest>();
            var marshaller = new CreateNetworkInterfacePermissionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateNetworkInterfacePermissionResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateNetworkInterfacePermissionResponse;   
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


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreatePlacementGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CreatePlacementGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreatePublicIpv4PoolMarshallTest()
        {
            var operation = service_model.FindOperation("CreatePublicIpv4Pool");

            var request = InstantiateClassGenerator.Execute<CreatePublicIpv4PoolRequest>();
            var marshaller = new CreatePublicIpv4PoolRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreatePublicIpv4PoolResponseUnmarshaller.Instance.Unmarshall(context)
                as CreatePublicIpv4PoolResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateReplaceRootVolumeTaskMarshallTest()
        {
            var operation = service_model.FindOperation("CreateReplaceRootVolumeTask");

            var request = InstantiateClassGenerator.Execute<CreateReplaceRootVolumeTaskRequest>();
            var marshaller = new CreateReplaceRootVolumeTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateReplaceRootVolumeTaskResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateReplaceRootVolumeTaskResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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
        public void CreateRestoreImageTaskMarshallTest()
        {
            var operation = service_model.FindOperation("CreateRestoreImageTask");

            var request = InstantiateClassGenerator.Execute<CreateRestoreImageTaskRequest>();
            var marshaller = new CreateRestoreImageTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateRestoreImageTaskResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateRestoreImageTaskResponse;   
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
        public void CreateSnapshotsMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSnapshots");

            var request = InstantiateClassGenerator.Execute<CreateSnapshotsRequest>();
            var marshaller = new CreateSnapshotsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateSnapshotsResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateSnapshotsResponse;   
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
        public void CreateStoreImageTaskMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStoreImageTask");

            var request = InstantiateClassGenerator.Execute<CreateStoreImageTaskRequest>();
            var marshaller = new CreateStoreImageTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateStoreImageTaskResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateStoreImageTaskResponse;   
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
        public void CreateSubnetCidrReservationMarshallTest()
        {
            var operation = service_model.FindOperation("CreateSubnetCidrReservation");

            var request = InstantiateClassGenerator.Execute<CreateSubnetCidrReservationRequest>();
            var marshaller = new CreateSubnetCidrReservationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateSubnetCidrReservationResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateSubnetCidrReservationResponse;   
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
        public void CreateTrafficMirrorFilterMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTrafficMirrorFilter");

            var request = InstantiateClassGenerator.Execute<CreateTrafficMirrorFilterRequest>();
            var marshaller = new CreateTrafficMirrorFilterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateTrafficMirrorFilterResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateTrafficMirrorFilterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateTrafficMirrorFilterRuleMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTrafficMirrorFilterRule");

            var request = InstantiateClassGenerator.Execute<CreateTrafficMirrorFilterRuleRequest>();
            var marshaller = new CreateTrafficMirrorFilterRuleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateTrafficMirrorFilterRuleResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateTrafficMirrorFilterRuleResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateTrafficMirrorSessionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTrafficMirrorSession");

            var request = InstantiateClassGenerator.Execute<CreateTrafficMirrorSessionRequest>();
            var marshaller = new CreateTrafficMirrorSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateTrafficMirrorSessionResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateTrafficMirrorSessionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateTrafficMirrorTargetMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTrafficMirrorTarget");

            var request = InstantiateClassGenerator.Execute<CreateTrafficMirrorTargetRequest>();
            var marshaller = new CreateTrafficMirrorTargetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateTrafficMirrorTargetResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateTrafficMirrorTargetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateTransitGatewayMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTransitGateway");

            var request = InstantiateClassGenerator.Execute<CreateTransitGatewayRequest>();
            var marshaller = new CreateTransitGatewayRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateTransitGatewayResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateTransitGatewayResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateTransitGatewayConnectMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTransitGatewayConnect");

            var request = InstantiateClassGenerator.Execute<CreateTransitGatewayConnectRequest>();
            var marshaller = new CreateTransitGatewayConnectRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateTransitGatewayConnectResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateTransitGatewayConnectResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateTransitGatewayConnectPeerMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTransitGatewayConnectPeer");

            var request = InstantiateClassGenerator.Execute<CreateTransitGatewayConnectPeerRequest>();
            var marshaller = new CreateTransitGatewayConnectPeerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateTransitGatewayConnectPeerResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateTransitGatewayConnectPeerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateTransitGatewayMulticastDomainMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTransitGatewayMulticastDomain");

            var request = InstantiateClassGenerator.Execute<CreateTransitGatewayMulticastDomainRequest>();
            var marshaller = new CreateTransitGatewayMulticastDomainRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateTransitGatewayMulticastDomainResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateTransitGatewayMulticastDomainResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateTransitGatewayPeeringAttachmentMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTransitGatewayPeeringAttachment");

            var request = InstantiateClassGenerator.Execute<CreateTransitGatewayPeeringAttachmentRequest>();
            var marshaller = new CreateTransitGatewayPeeringAttachmentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateTransitGatewayPeeringAttachmentResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateTransitGatewayPeeringAttachmentResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateTransitGatewayPolicyTableMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTransitGatewayPolicyTable");

            var request = InstantiateClassGenerator.Execute<CreateTransitGatewayPolicyTableRequest>();
            var marshaller = new CreateTransitGatewayPolicyTableRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateTransitGatewayPolicyTableResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateTransitGatewayPolicyTableResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateTransitGatewayPrefixListReferenceMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTransitGatewayPrefixListReference");

            var request = InstantiateClassGenerator.Execute<CreateTransitGatewayPrefixListReferenceRequest>();
            var marshaller = new CreateTransitGatewayPrefixListReferenceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateTransitGatewayPrefixListReferenceResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateTransitGatewayPrefixListReferenceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateTransitGatewayRouteMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTransitGatewayRoute");

            var request = InstantiateClassGenerator.Execute<CreateTransitGatewayRouteRequest>();
            var marshaller = new CreateTransitGatewayRouteRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateTransitGatewayRouteResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateTransitGatewayRouteResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateTransitGatewayRouteTableMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTransitGatewayRouteTable");

            var request = InstantiateClassGenerator.Execute<CreateTransitGatewayRouteTableRequest>();
            var marshaller = new CreateTransitGatewayRouteTableRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateTransitGatewayRouteTableResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateTransitGatewayRouteTableResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateTransitGatewayRouteTableAnnouncementMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTransitGatewayRouteTableAnnouncement");

            var request = InstantiateClassGenerator.Execute<CreateTransitGatewayRouteTableAnnouncementRequest>();
            var marshaller = new CreateTransitGatewayRouteTableAnnouncementRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateTransitGatewayRouteTableAnnouncementResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateTransitGatewayRouteTableAnnouncementResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateTransitGatewayVpcAttachmentMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTransitGatewayVpcAttachment");

            var request = InstantiateClassGenerator.Execute<CreateTransitGatewayVpcAttachmentRequest>();
            var marshaller = new CreateTransitGatewayVpcAttachmentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateTransitGatewayVpcAttachmentResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateTransitGatewayVpcAttachmentResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateVerifiedAccessEndpointMarshallTest()
        {
            var operation = service_model.FindOperation("CreateVerifiedAccessEndpoint");

            var request = InstantiateClassGenerator.Execute<CreateVerifiedAccessEndpointRequest>();
            var marshaller = new CreateVerifiedAccessEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateVerifiedAccessEndpointResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateVerifiedAccessEndpointResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateVerifiedAccessGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateVerifiedAccessGroup");

            var request = InstantiateClassGenerator.Execute<CreateVerifiedAccessGroupRequest>();
            var marshaller = new CreateVerifiedAccessGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateVerifiedAccessGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateVerifiedAccessGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateVerifiedAccessInstanceMarshallTest()
        {
            var operation = service_model.FindOperation("CreateVerifiedAccessInstance");

            var request = InstantiateClassGenerator.Execute<CreateVerifiedAccessInstanceRequest>();
            var marshaller = new CreateVerifiedAccessInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateVerifiedAccessInstanceResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateVerifiedAccessInstanceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateVerifiedAccessTrustProviderMarshallTest()
        {
            var operation = service_model.FindOperation("CreateVerifiedAccessTrustProvider");

            var request = InstantiateClassGenerator.Execute<CreateVerifiedAccessTrustProviderRequest>();
            var marshaller = new CreateVerifiedAccessTrustProviderRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateVerifiedAccessTrustProviderResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateVerifiedAccessTrustProviderResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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
        public void CreateVpcEndpointConnectionNotificationMarshallTest()
        {
            var operation = service_model.FindOperation("CreateVpcEndpointConnectionNotification");

            var request = InstantiateClassGenerator.Execute<CreateVpcEndpointConnectionNotificationRequest>();
            var marshaller = new CreateVpcEndpointConnectionNotificationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateVpcEndpointConnectionNotificationResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateVpcEndpointConnectionNotificationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void CreateVpcEndpointServiceConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("CreateVpcEndpointServiceConfiguration");

            var request = InstantiateClassGenerator.Execute<CreateVpcEndpointServiceConfigurationRequest>();
            var marshaller = new CreateVpcEndpointServiceConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = CreateVpcEndpointServiceConfigurationResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateVpcEndpointServiceConfigurationResponse;   
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
        public void DeleteCarrierGatewayMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCarrierGateway");

            var request = InstantiateClassGenerator.Execute<DeleteCarrierGatewayRequest>();
            var marshaller = new DeleteCarrierGatewayRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteCarrierGatewayResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteCarrierGatewayResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteClientVpnEndpointMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteClientVpnEndpoint");

            var request = InstantiateClassGenerator.Execute<DeleteClientVpnEndpointRequest>();
            var marshaller = new DeleteClientVpnEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteClientVpnEndpointResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteClientVpnEndpointResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteClientVpnRouteMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteClientVpnRoute");

            var request = InstantiateClassGenerator.Execute<DeleteClientVpnRouteRequest>();
            var marshaller = new DeleteClientVpnRouteRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteClientVpnRouteResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteClientVpnRouteResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteCoipCidrMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCoipCidr");

            var request = InstantiateClassGenerator.Execute<DeleteCoipCidrRequest>();
            var marshaller = new DeleteCoipCidrRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteCoipCidrResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteCoipCidrResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteCoipPoolMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCoipPool");

            var request = InstantiateClassGenerator.Execute<DeleteCoipPoolRequest>();
            var marshaller = new DeleteCoipPoolRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteCoipPoolResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteCoipPoolResponse;   
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
        public void DeleteEgressOnlyInternetGatewayMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteEgressOnlyInternetGateway");

            var request = InstantiateClassGenerator.Execute<DeleteEgressOnlyInternetGatewayRequest>();
            var marshaller = new DeleteEgressOnlyInternetGatewayRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteEgressOnlyInternetGatewayResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteEgressOnlyInternetGatewayResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteFleetsMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteFleets");

            var request = InstantiateClassGenerator.Execute<DeleteFleetsRequest>();
            var marshaller = new DeleteFleetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteFleetsResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteFleetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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
        public void DeleteFpgaImageMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteFpgaImage");

            var request = InstantiateClassGenerator.Execute<DeleteFpgaImageRequest>();
            var marshaller = new DeleteFpgaImageRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteFpgaImageResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteFpgaImageResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteInstanceEventWindowMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteInstanceEventWindow");

            var request = InstantiateClassGenerator.Execute<DeleteInstanceEventWindowRequest>();
            var marshaller = new DeleteInstanceEventWindowRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteInstanceEventWindowResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteInstanceEventWindowResponse;   
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
        public void DeleteIpamMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteIpam");

            var request = InstantiateClassGenerator.Execute<DeleteIpamRequest>();
            var marshaller = new DeleteIpamRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteIpamResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteIpamResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteIpamPoolMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteIpamPool");

            var request = InstantiateClassGenerator.Execute<DeleteIpamPoolRequest>();
            var marshaller = new DeleteIpamPoolRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteIpamPoolResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteIpamPoolResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteIpamResourceDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteIpamResourceDiscovery");

            var request = InstantiateClassGenerator.Execute<DeleteIpamResourceDiscoveryRequest>();
            var marshaller = new DeleteIpamResourceDiscoveryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteIpamResourceDiscoveryResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteIpamResourceDiscoveryResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteIpamScopeMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteIpamScope");

            var request = InstantiateClassGenerator.Execute<DeleteIpamScopeRequest>();
            var marshaller = new DeleteIpamScopeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteIpamScopeResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteIpamScopeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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
        public void DeleteLaunchTemplateMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteLaunchTemplate");

            var request = InstantiateClassGenerator.Execute<DeleteLaunchTemplateRequest>();
            var marshaller = new DeleteLaunchTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteLaunchTemplateResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteLaunchTemplateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteLaunchTemplateVersionsMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteLaunchTemplateVersions");

            var request = InstantiateClassGenerator.Execute<DeleteLaunchTemplateVersionsRequest>();
            var marshaller = new DeleteLaunchTemplateVersionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteLaunchTemplateVersionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteLaunchTemplateVersionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteLocalGatewayRouteMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteLocalGatewayRoute");

            var request = InstantiateClassGenerator.Execute<DeleteLocalGatewayRouteRequest>();
            var marshaller = new DeleteLocalGatewayRouteRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteLocalGatewayRouteResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteLocalGatewayRouteResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteLocalGatewayRouteTableMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteLocalGatewayRouteTable");

            var request = InstantiateClassGenerator.Execute<DeleteLocalGatewayRouteTableRequest>();
            var marshaller = new DeleteLocalGatewayRouteTableRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteLocalGatewayRouteTableResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteLocalGatewayRouteTableResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteLocalGatewayRouteTableVirtualInterfaceGroupAssociationMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteLocalGatewayRouteTableVirtualInterfaceGroupAssociation");

            var request = InstantiateClassGenerator.Execute<DeleteLocalGatewayRouteTableVirtualInterfaceGroupAssociationRequest>();
            var marshaller = new DeleteLocalGatewayRouteTableVirtualInterfaceGroupAssociationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteLocalGatewayRouteTableVirtualInterfaceGroupAssociationResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteLocalGatewayRouteTableVirtualInterfaceGroupAssociationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteLocalGatewayRouteTableVpcAssociationMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteLocalGatewayRouteTableVpcAssociation");

            var request = InstantiateClassGenerator.Execute<DeleteLocalGatewayRouteTableVpcAssociationRequest>();
            var marshaller = new DeleteLocalGatewayRouteTableVpcAssociationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteLocalGatewayRouteTableVpcAssociationResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteLocalGatewayRouteTableVpcAssociationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteManagedPrefixListMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteManagedPrefixList");

            var request = InstantiateClassGenerator.Execute<DeleteManagedPrefixListRequest>();
            var marshaller = new DeleteManagedPrefixListRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteManagedPrefixListResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteManagedPrefixListResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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
        public void DeleteNetworkInsightsAccessScopeMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteNetworkInsightsAccessScope");

            var request = InstantiateClassGenerator.Execute<DeleteNetworkInsightsAccessScopeRequest>();
            var marshaller = new DeleteNetworkInsightsAccessScopeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteNetworkInsightsAccessScopeResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteNetworkInsightsAccessScopeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteNetworkInsightsAccessScopeAnalysisMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteNetworkInsightsAccessScopeAnalysis");

            var request = InstantiateClassGenerator.Execute<DeleteNetworkInsightsAccessScopeAnalysisRequest>();
            var marshaller = new DeleteNetworkInsightsAccessScopeAnalysisRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteNetworkInsightsAccessScopeAnalysisResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteNetworkInsightsAccessScopeAnalysisResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteNetworkInsightsAnalysisMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteNetworkInsightsAnalysis");

            var request = InstantiateClassGenerator.Execute<DeleteNetworkInsightsAnalysisRequest>();
            var marshaller = new DeleteNetworkInsightsAnalysisRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteNetworkInsightsAnalysisResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteNetworkInsightsAnalysisResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteNetworkInsightsPathMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteNetworkInsightsPath");

            var request = InstantiateClassGenerator.Execute<DeleteNetworkInsightsPathRequest>();
            var marshaller = new DeleteNetworkInsightsPathRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteNetworkInsightsPathResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteNetworkInsightsPathResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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
        public void DeleteNetworkInterfacePermissionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteNetworkInterfacePermission");

            var request = InstantiateClassGenerator.Execute<DeleteNetworkInterfacePermissionRequest>();
            var marshaller = new DeleteNetworkInterfacePermissionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteNetworkInterfacePermissionResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteNetworkInterfacePermissionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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
        public void DeletePublicIpv4PoolMarshallTest()
        {
            var operation = service_model.FindOperation("DeletePublicIpv4Pool");

            var request = InstantiateClassGenerator.Execute<DeletePublicIpv4PoolRequest>();
            var marshaller = new DeletePublicIpv4PoolRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeletePublicIpv4PoolResponseUnmarshaller.Instance.Unmarshall(context)
                as DeletePublicIpv4PoolResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteQueuedReservedInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteQueuedReservedInstances");

            var request = InstantiateClassGenerator.Execute<DeleteQueuedReservedInstancesRequest>();
            var marshaller = new DeleteQueuedReservedInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteQueuedReservedInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteQueuedReservedInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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
        public void DeleteSubnetCidrReservationMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteSubnetCidrReservation");

            var request = InstantiateClassGenerator.Execute<DeleteSubnetCidrReservationRequest>();
            var marshaller = new DeleteSubnetCidrReservationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteSubnetCidrReservationResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteSubnetCidrReservationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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
        public void DeleteTrafficMirrorFilterMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteTrafficMirrorFilter");

            var request = InstantiateClassGenerator.Execute<DeleteTrafficMirrorFilterRequest>();
            var marshaller = new DeleteTrafficMirrorFilterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteTrafficMirrorFilterResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteTrafficMirrorFilterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteTrafficMirrorFilterRuleMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteTrafficMirrorFilterRule");

            var request = InstantiateClassGenerator.Execute<DeleteTrafficMirrorFilterRuleRequest>();
            var marshaller = new DeleteTrafficMirrorFilterRuleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteTrafficMirrorFilterRuleResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteTrafficMirrorFilterRuleResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteTrafficMirrorSessionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteTrafficMirrorSession");

            var request = InstantiateClassGenerator.Execute<DeleteTrafficMirrorSessionRequest>();
            var marshaller = new DeleteTrafficMirrorSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteTrafficMirrorSessionResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteTrafficMirrorSessionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteTrafficMirrorTargetMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteTrafficMirrorTarget");

            var request = InstantiateClassGenerator.Execute<DeleteTrafficMirrorTargetRequest>();
            var marshaller = new DeleteTrafficMirrorTargetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteTrafficMirrorTargetResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteTrafficMirrorTargetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteTransitGatewayMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteTransitGateway");

            var request = InstantiateClassGenerator.Execute<DeleteTransitGatewayRequest>();
            var marshaller = new DeleteTransitGatewayRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteTransitGatewayResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteTransitGatewayResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteTransitGatewayConnectMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteTransitGatewayConnect");

            var request = InstantiateClassGenerator.Execute<DeleteTransitGatewayConnectRequest>();
            var marshaller = new DeleteTransitGatewayConnectRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteTransitGatewayConnectResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteTransitGatewayConnectResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteTransitGatewayConnectPeerMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteTransitGatewayConnectPeer");

            var request = InstantiateClassGenerator.Execute<DeleteTransitGatewayConnectPeerRequest>();
            var marshaller = new DeleteTransitGatewayConnectPeerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteTransitGatewayConnectPeerResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteTransitGatewayConnectPeerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteTransitGatewayMulticastDomainMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteTransitGatewayMulticastDomain");

            var request = InstantiateClassGenerator.Execute<DeleteTransitGatewayMulticastDomainRequest>();
            var marshaller = new DeleteTransitGatewayMulticastDomainRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteTransitGatewayMulticastDomainResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteTransitGatewayMulticastDomainResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteTransitGatewayPeeringAttachmentMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteTransitGatewayPeeringAttachment");

            var request = InstantiateClassGenerator.Execute<DeleteTransitGatewayPeeringAttachmentRequest>();
            var marshaller = new DeleteTransitGatewayPeeringAttachmentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteTransitGatewayPeeringAttachmentResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteTransitGatewayPeeringAttachmentResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteTransitGatewayPolicyTableMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteTransitGatewayPolicyTable");

            var request = InstantiateClassGenerator.Execute<DeleteTransitGatewayPolicyTableRequest>();
            var marshaller = new DeleteTransitGatewayPolicyTableRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteTransitGatewayPolicyTableResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteTransitGatewayPolicyTableResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteTransitGatewayPrefixListReferenceMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteTransitGatewayPrefixListReference");

            var request = InstantiateClassGenerator.Execute<DeleteTransitGatewayPrefixListReferenceRequest>();
            var marshaller = new DeleteTransitGatewayPrefixListReferenceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteTransitGatewayPrefixListReferenceResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteTransitGatewayPrefixListReferenceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteTransitGatewayRouteMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteTransitGatewayRoute");

            var request = InstantiateClassGenerator.Execute<DeleteTransitGatewayRouteRequest>();
            var marshaller = new DeleteTransitGatewayRouteRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteTransitGatewayRouteResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteTransitGatewayRouteResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteTransitGatewayRouteTableMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteTransitGatewayRouteTable");

            var request = InstantiateClassGenerator.Execute<DeleteTransitGatewayRouteTableRequest>();
            var marshaller = new DeleteTransitGatewayRouteTableRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteTransitGatewayRouteTableResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteTransitGatewayRouteTableResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteTransitGatewayRouteTableAnnouncementMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteTransitGatewayRouteTableAnnouncement");

            var request = InstantiateClassGenerator.Execute<DeleteTransitGatewayRouteTableAnnouncementRequest>();
            var marshaller = new DeleteTransitGatewayRouteTableAnnouncementRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteTransitGatewayRouteTableAnnouncementResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteTransitGatewayRouteTableAnnouncementResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteTransitGatewayVpcAttachmentMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteTransitGatewayVpcAttachment");

            var request = InstantiateClassGenerator.Execute<DeleteTransitGatewayVpcAttachmentRequest>();
            var marshaller = new DeleteTransitGatewayVpcAttachmentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteTransitGatewayVpcAttachmentResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteTransitGatewayVpcAttachmentResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteVerifiedAccessEndpointMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteVerifiedAccessEndpoint");

            var request = InstantiateClassGenerator.Execute<DeleteVerifiedAccessEndpointRequest>();
            var marshaller = new DeleteVerifiedAccessEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteVerifiedAccessEndpointResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteVerifiedAccessEndpointResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteVerifiedAccessGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteVerifiedAccessGroup");

            var request = InstantiateClassGenerator.Execute<DeleteVerifiedAccessGroupRequest>();
            var marshaller = new DeleteVerifiedAccessGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteVerifiedAccessGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteVerifiedAccessGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteVerifiedAccessInstanceMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteVerifiedAccessInstance");

            var request = InstantiateClassGenerator.Execute<DeleteVerifiedAccessInstanceRequest>();
            var marshaller = new DeleteVerifiedAccessInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteVerifiedAccessInstanceResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteVerifiedAccessInstanceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeleteVerifiedAccessTrustProviderMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteVerifiedAccessTrustProvider");

            var request = InstantiateClassGenerator.Execute<DeleteVerifiedAccessTrustProviderRequest>();
            var marshaller = new DeleteVerifiedAccessTrustProviderRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteVerifiedAccessTrustProviderResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteVerifiedAccessTrustProviderResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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
        public void DeleteVpcEndpointConnectionNotificationsMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteVpcEndpointConnectionNotifications");

            var request = InstantiateClassGenerator.Execute<DeleteVpcEndpointConnectionNotificationsRequest>();
            var marshaller = new DeleteVpcEndpointConnectionNotificationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteVpcEndpointConnectionNotificationsResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteVpcEndpointConnectionNotificationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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
        public void DeleteVpcEndpointServiceConfigurationsMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteVpcEndpointServiceConfigurations");

            var request = InstantiateClassGenerator.Execute<DeleteVpcEndpointServiceConfigurationsRequest>();
            var marshaller = new DeleteVpcEndpointServiceConfigurationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeleteVpcEndpointServiceConfigurationsResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteVpcEndpointServiceConfigurationsResponse;   
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
        public void DeprovisionByoipCidrMarshallTest()
        {
            var operation = service_model.FindOperation("DeprovisionByoipCidr");

            var request = InstantiateClassGenerator.Execute<DeprovisionByoipCidrRequest>();
            var marshaller = new DeprovisionByoipCidrRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeprovisionByoipCidrResponseUnmarshaller.Instance.Unmarshall(context)
                as DeprovisionByoipCidrResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeprovisionIpamPoolCidrMarshallTest()
        {
            var operation = service_model.FindOperation("DeprovisionIpamPoolCidr");

            var request = InstantiateClassGenerator.Execute<DeprovisionIpamPoolCidrRequest>();
            var marshaller = new DeprovisionIpamPoolCidrRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeprovisionIpamPoolCidrResponseUnmarshaller.Instance.Unmarshall(context)
                as DeprovisionIpamPoolCidrResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeprovisionPublicIpv4PoolCidrMarshallTest()
        {
            var operation = service_model.FindOperation("DeprovisionPublicIpv4PoolCidr");

            var request = InstantiateClassGenerator.Execute<DeprovisionPublicIpv4PoolCidrRequest>();
            var marshaller = new DeprovisionPublicIpv4PoolCidrRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeprovisionPublicIpv4PoolCidrResponseUnmarshaller.Instance.Unmarshall(context)
                as DeprovisionPublicIpv4PoolCidrResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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
        public void DeregisterInstanceEventNotificationAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("DeregisterInstanceEventNotificationAttributes");

            var request = InstantiateClassGenerator.Execute<DeregisterInstanceEventNotificationAttributesRequest>();
            var marshaller = new DeregisterInstanceEventNotificationAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeregisterInstanceEventNotificationAttributesResponseUnmarshaller.Instance.Unmarshall(context)
                as DeregisterInstanceEventNotificationAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeregisterTransitGatewayMulticastGroupMembersMarshallTest()
        {
            var operation = service_model.FindOperation("DeregisterTransitGatewayMulticastGroupMembers");

            var request = InstantiateClassGenerator.Execute<DeregisterTransitGatewayMulticastGroupMembersRequest>();
            var marshaller = new DeregisterTransitGatewayMulticastGroupMembersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeregisterTransitGatewayMulticastGroupMembersResponseUnmarshaller.Instance.Unmarshall(context)
                as DeregisterTransitGatewayMulticastGroupMembersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DeregisterTransitGatewayMulticastGroupSourcesMarshallTest()
        {
            var operation = service_model.FindOperation("DeregisterTransitGatewayMulticastGroupSources");

            var request = InstantiateClassGenerator.Execute<DeregisterTransitGatewayMulticastGroupSourcesRequest>();
            var marshaller = new DeregisterTransitGatewayMulticastGroupSourcesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DeregisterTransitGatewayMulticastGroupSourcesResponseUnmarshaller.Instance.Unmarshall(context)
                as DeregisterTransitGatewayMulticastGroupSourcesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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
        public void DescribeAddressesAttributeMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAddressesAttribute");

            var request = InstantiateClassGenerator.Execute<DescribeAddressesAttributeRequest>();
            var marshaller = new DescribeAddressesAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeAddressesAttributeResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeAddressesAttributeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeAddressTransfersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAddressTransfers");

            var request = InstantiateClassGenerator.Execute<DescribeAddressTransfersRequest>();
            var marshaller = new DescribeAddressTransfersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeAddressTransfersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeAddressTransfersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeAggregateIdFormatMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAggregateIdFormat");

            var request = InstantiateClassGenerator.Execute<DescribeAggregateIdFormatRequest>();
            var marshaller = new DescribeAggregateIdFormatRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeAggregateIdFormatResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeAggregateIdFormatResponse;   
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
        public void DescribeAwsNetworkPerformanceMetricSubscriptionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAwsNetworkPerformanceMetricSubscriptions");

            var request = InstantiateClassGenerator.Execute<DescribeAwsNetworkPerformanceMetricSubscriptionsRequest>();
            var marshaller = new DescribeAwsNetworkPerformanceMetricSubscriptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeAwsNetworkPerformanceMetricSubscriptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeAwsNetworkPerformanceMetricSubscriptionsResponse;   
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
        public void DescribeByoipCidrsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeByoipCidrs");

            var request = InstantiateClassGenerator.Execute<DescribeByoipCidrsRequest>();
            var marshaller = new DescribeByoipCidrsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeByoipCidrsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeByoipCidrsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeCapacityReservationFleetsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeCapacityReservationFleets");

            var request = InstantiateClassGenerator.Execute<DescribeCapacityReservationFleetsRequest>();
            var marshaller = new DescribeCapacityReservationFleetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeCapacityReservationFleetsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeCapacityReservationFleetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeCapacityReservationsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeCapacityReservations");

            var request = InstantiateClassGenerator.Execute<DescribeCapacityReservationsRequest>();
            var marshaller = new DescribeCapacityReservationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeCapacityReservationsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeCapacityReservationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeCarrierGatewaysMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeCarrierGateways");

            var request = InstantiateClassGenerator.Execute<DescribeCarrierGatewaysRequest>();
            var marshaller = new DescribeCarrierGatewaysRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeCarrierGatewaysResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeCarrierGatewaysResponse;   
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
        public void DescribeClientVpnAuthorizationRulesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClientVpnAuthorizationRules");

            var request = InstantiateClassGenerator.Execute<DescribeClientVpnAuthorizationRulesRequest>();
            var marshaller = new DescribeClientVpnAuthorizationRulesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeClientVpnAuthorizationRulesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeClientVpnAuthorizationRulesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeClientVpnConnectionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClientVpnConnections");

            var request = InstantiateClassGenerator.Execute<DescribeClientVpnConnectionsRequest>();
            var marshaller = new DescribeClientVpnConnectionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeClientVpnConnectionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeClientVpnConnectionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeClientVpnEndpointsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClientVpnEndpoints");

            var request = InstantiateClassGenerator.Execute<DescribeClientVpnEndpointsRequest>();
            var marshaller = new DescribeClientVpnEndpointsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeClientVpnEndpointsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeClientVpnEndpointsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeClientVpnRoutesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClientVpnRoutes");

            var request = InstantiateClassGenerator.Execute<DescribeClientVpnRoutesRequest>();
            var marshaller = new DescribeClientVpnRoutesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeClientVpnRoutesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeClientVpnRoutesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeClientVpnTargetNetworksMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeClientVpnTargetNetworks");

            var request = InstantiateClassGenerator.Execute<DescribeClientVpnTargetNetworksRequest>();
            var marshaller = new DescribeClientVpnTargetNetworksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeClientVpnTargetNetworksResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeClientVpnTargetNetworksResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeCoipPoolsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeCoipPools");

            var request = InstantiateClassGenerator.Execute<DescribeCoipPoolsRequest>();
            var marshaller = new DescribeCoipPoolsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeCoipPoolsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeCoipPoolsResponse;   
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
        public void DescribeEgressOnlyInternetGatewaysMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeEgressOnlyInternetGateways");

            var request = InstantiateClassGenerator.Execute<DescribeEgressOnlyInternetGatewaysRequest>();
            var marshaller = new DescribeEgressOnlyInternetGatewaysRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeEgressOnlyInternetGatewaysResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeEgressOnlyInternetGatewaysResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeElasticGpusMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeElasticGpus");

            var request = InstantiateClassGenerator.Execute<DescribeElasticGpusRequest>();
            var marshaller = new DescribeElasticGpusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeElasticGpusResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeElasticGpusResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeExportImageTasksMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeExportImageTasks");

            var request = InstantiateClassGenerator.Execute<DescribeExportImageTasksRequest>();
            var marshaller = new DescribeExportImageTasksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeExportImageTasksResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeExportImageTasksResponse;   
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
        public void DescribeFastLaunchImagesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeFastLaunchImages");

            var request = InstantiateClassGenerator.Execute<DescribeFastLaunchImagesRequest>();
            var marshaller = new DescribeFastLaunchImagesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeFastLaunchImagesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeFastLaunchImagesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeFastSnapshotRestoresMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeFastSnapshotRestores");

            var request = InstantiateClassGenerator.Execute<DescribeFastSnapshotRestoresRequest>();
            var marshaller = new DescribeFastSnapshotRestoresRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeFastSnapshotRestoresResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeFastSnapshotRestoresResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeFleetHistoryMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeFleetHistory");

            var request = InstantiateClassGenerator.Execute<DescribeFleetHistoryRequest>();
            var marshaller = new DescribeFleetHistoryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeFleetHistoryResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeFleetHistoryResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeFleetInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeFleetInstances");

            var request = InstantiateClassGenerator.Execute<DescribeFleetInstancesRequest>();
            var marshaller = new DescribeFleetInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeFleetInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeFleetInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeFleetsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeFleets");

            var request = InstantiateClassGenerator.Execute<DescribeFleetsRequest>();
            var marshaller = new DescribeFleetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeFleetsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeFleetsResponse;   
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
        public void DescribeFpgaImageAttributeMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeFpgaImageAttribute");

            var request = InstantiateClassGenerator.Execute<DescribeFpgaImageAttributeRequest>();
            var marshaller = new DescribeFpgaImageAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeFpgaImageAttributeResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeFpgaImageAttributeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeFpgaImagesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeFpgaImages");

            var request = InstantiateClassGenerator.Execute<DescribeFpgaImagesRequest>();
            var marshaller = new DescribeFpgaImagesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeFpgaImagesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeFpgaImagesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeHostReservationOfferingsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeHostReservationOfferings");

            var request = InstantiateClassGenerator.Execute<DescribeHostReservationOfferingsRequest>();
            var marshaller = new DescribeHostReservationOfferingsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeHostReservationOfferingsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeHostReservationOfferingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeHostReservationsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeHostReservations");

            var request = InstantiateClassGenerator.Execute<DescribeHostReservationsRequest>();
            var marshaller = new DescribeHostReservationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeHostReservationsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeHostReservationsResponse;   
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
        public void DescribeIamInstanceProfileAssociationsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeIamInstanceProfileAssociations");

            var request = InstantiateClassGenerator.Execute<DescribeIamInstanceProfileAssociationsRequest>();
            var marshaller = new DescribeIamInstanceProfileAssociationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeIamInstanceProfileAssociationsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeIamInstanceProfileAssociationsResponse;   
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
        public void DescribeInstanceCreditSpecificationsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeInstanceCreditSpecifications");

            var request = InstantiateClassGenerator.Execute<DescribeInstanceCreditSpecificationsRequest>();
            var marshaller = new DescribeInstanceCreditSpecificationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeInstanceCreditSpecificationsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeInstanceCreditSpecificationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeInstanceEventNotificationAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeInstanceEventNotificationAttributes");

            var request = InstantiateClassGenerator.Execute<DescribeInstanceEventNotificationAttributesRequest>();
            var marshaller = new DescribeInstanceEventNotificationAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeInstanceEventNotificationAttributesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeInstanceEventNotificationAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeInstanceEventWindowsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeInstanceEventWindows");

            var request = InstantiateClassGenerator.Execute<DescribeInstanceEventWindowsRequest>();
            var marshaller = new DescribeInstanceEventWindowsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeInstanceEventWindowsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeInstanceEventWindowsResponse;   
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
        public void DescribeInstanceTypeOfferingsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeInstanceTypeOfferings");

            var request = InstantiateClassGenerator.Execute<DescribeInstanceTypeOfferingsRequest>();
            var marshaller = new DescribeInstanceTypeOfferingsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeInstanceTypeOfferingsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeInstanceTypeOfferingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeInstanceTypesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeInstanceTypes");

            var request = InstantiateClassGenerator.Execute<DescribeInstanceTypesRequest>();
            var marshaller = new DescribeInstanceTypesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeInstanceTypesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeInstanceTypesResponse;   
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
        public void DescribeIpamPoolsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeIpamPools");

            var request = InstantiateClassGenerator.Execute<DescribeIpamPoolsRequest>();
            var marshaller = new DescribeIpamPoolsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeIpamPoolsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeIpamPoolsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeIpamResourceDiscoveriesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeIpamResourceDiscoveries");

            var request = InstantiateClassGenerator.Execute<DescribeIpamResourceDiscoveriesRequest>();
            var marshaller = new DescribeIpamResourceDiscoveriesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeIpamResourceDiscoveriesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeIpamResourceDiscoveriesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeIpamResourceDiscoveryAssociationsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeIpamResourceDiscoveryAssociations");

            var request = InstantiateClassGenerator.Execute<DescribeIpamResourceDiscoveryAssociationsRequest>();
            var marshaller = new DescribeIpamResourceDiscoveryAssociationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeIpamResourceDiscoveryAssociationsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeIpamResourceDiscoveryAssociationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeIpamsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeIpams");

            var request = InstantiateClassGenerator.Execute<DescribeIpamsRequest>();
            var marshaller = new DescribeIpamsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeIpamsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeIpamsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeIpamScopesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeIpamScopes");

            var request = InstantiateClassGenerator.Execute<DescribeIpamScopesRequest>();
            var marshaller = new DescribeIpamScopesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeIpamScopesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeIpamScopesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeIpv6PoolsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeIpv6Pools");

            var request = InstantiateClassGenerator.Execute<DescribeIpv6PoolsRequest>();
            var marshaller = new DescribeIpv6PoolsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeIpv6PoolsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeIpv6PoolsResponse;   
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
        public void DescribeLaunchTemplatesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLaunchTemplates");

            var request = InstantiateClassGenerator.Execute<DescribeLaunchTemplatesRequest>();
            var marshaller = new DescribeLaunchTemplatesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeLaunchTemplatesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeLaunchTemplatesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeLaunchTemplateVersionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLaunchTemplateVersions");

            var request = InstantiateClassGenerator.Execute<DescribeLaunchTemplateVersionsRequest>();
            var marshaller = new DescribeLaunchTemplateVersionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeLaunchTemplateVersionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeLaunchTemplateVersionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeLocalGatewayRouteTablesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLocalGatewayRouteTables");

            var request = InstantiateClassGenerator.Execute<DescribeLocalGatewayRouteTablesRequest>();
            var marshaller = new DescribeLocalGatewayRouteTablesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeLocalGatewayRouteTablesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeLocalGatewayRouteTablesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociationsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociations");

            var request = InstantiateClassGenerator.Execute<DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociationsRequest>();
            var marshaller = new DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociationsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeLocalGatewayRouteTableVpcAssociationsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLocalGatewayRouteTableVpcAssociations");

            var request = InstantiateClassGenerator.Execute<DescribeLocalGatewayRouteTableVpcAssociationsRequest>();
            var marshaller = new DescribeLocalGatewayRouteTableVpcAssociationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeLocalGatewayRouteTableVpcAssociationsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeLocalGatewayRouteTableVpcAssociationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeLocalGatewaysMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLocalGateways");

            var request = InstantiateClassGenerator.Execute<DescribeLocalGatewaysRequest>();
            var marshaller = new DescribeLocalGatewaysRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeLocalGatewaysResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeLocalGatewaysResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeLocalGatewayVirtualInterfaceGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLocalGatewayVirtualInterfaceGroups");

            var request = InstantiateClassGenerator.Execute<DescribeLocalGatewayVirtualInterfaceGroupsRequest>();
            var marshaller = new DescribeLocalGatewayVirtualInterfaceGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeLocalGatewayVirtualInterfaceGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeLocalGatewayVirtualInterfaceGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeLocalGatewayVirtualInterfacesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLocalGatewayVirtualInterfaces");

            var request = InstantiateClassGenerator.Execute<DescribeLocalGatewayVirtualInterfacesRequest>();
            var marshaller = new DescribeLocalGatewayVirtualInterfacesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeLocalGatewayVirtualInterfacesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeLocalGatewayVirtualInterfacesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeManagedPrefixListsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeManagedPrefixLists");

            var request = InstantiateClassGenerator.Execute<DescribeManagedPrefixListsRequest>();
            var marshaller = new DescribeManagedPrefixListsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeManagedPrefixListsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeManagedPrefixListsResponse;   
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
        public void DescribeNetworkInsightsAccessScopeAnalysesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeNetworkInsightsAccessScopeAnalyses");

            var request = InstantiateClassGenerator.Execute<DescribeNetworkInsightsAccessScopeAnalysesRequest>();
            var marshaller = new DescribeNetworkInsightsAccessScopeAnalysesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeNetworkInsightsAccessScopeAnalysesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeNetworkInsightsAccessScopeAnalysesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeNetworkInsightsAccessScopesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeNetworkInsightsAccessScopes");

            var request = InstantiateClassGenerator.Execute<DescribeNetworkInsightsAccessScopesRequest>();
            var marshaller = new DescribeNetworkInsightsAccessScopesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeNetworkInsightsAccessScopesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeNetworkInsightsAccessScopesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeNetworkInsightsAnalysesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeNetworkInsightsAnalyses");

            var request = InstantiateClassGenerator.Execute<DescribeNetworkInsightsAnalysesRequest>();
            var marshaller = new DescribeNetworkInsightsAnalysesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeNetworkInsightsAnalysesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeNetworkInsightsAnalysesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeNetworkInsightsPathsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeNetworkInsightsPaths");

            var request = InstantiateClassGenerator.Execute<DescribeNetworkInsightsPathsRequest>();
            var marshaller = new DescribeNetworkInsightsPathsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeNetworkInsightsPathsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeNetworkInsightsPathsResponse;   
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
        public void DescribeNetworkInterfacePermissionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeNetworkInterfacePermissions");

            var request = InstantiateClassGenerator.Execute<DescribeNetworkInterfacePermissionsRequest>();
            var marshaller = new DescribeNetworkInterfacePermissionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeNetworkInterfacePermissionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeNetworkInterfacePermissionsResponse;   
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
        public void DescribePrincipalIdFormatMarshallTest()
        {
            var operation = service_model.FindOperation("DescribePrincipalIdFormat");

            var request = InstantiateClassGenerator.Execute<DescribePrincipalIdFormatRequest>();
            var marshaller = new DescribePrincipalIdFormatRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribePrincipalIdFormatResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribePrincipalIdFormatResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribePublicIpv4PoolsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribePublicIpv4Pools");

            var request = InstantiateClassGenerator.Execute<DescribePublicIpv4PoolsRequest>();
            var marshaller = new DescribePublicIpv4PoolsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribePublicIpv4PoolsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribePublicIpv4PoolsResponse;   
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
        public void DescribeReplaceRootVolumeTasksMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReplaceRootVolumeTasks");

            var request = InstantiateClassGenerator.Execute<DescribeReplaceRootVolumeTasksRequest>();
            var marshaller = new DescribeReplaceRootVolumeTasksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeReplaceRootVolumeTasksResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeReplaceRootVolumeTasksResponse;   
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
        public void DescribeSecurityGroupRulesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSecurityGroupRules");

            var request = InstantiateClassGenerator.Execute<DescribeSecurityGroupRulesRequest>();
            var marshaller = new DescribeSecurityGroupRulesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeSecurityGroupRulesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeSecurityGroupRulesResponse;   
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
        public void DescribeSnapshotTierStatusMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSnapshotTierStatus");

            var request = InstantiateClassGenerator.Execute<DescribeSnapshotTierStatusRequest>();
            var marshaller = new DescribeSnapshotTierStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeSnapshotTierStatusResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeSnapshotTierStatusResponse;   
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
        public void DescribeStoreImageTasksMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeStoreImageTasks");

            var request = InstantiateClassGenerator.Execute<DescribeStoreImageTasksRequest>();
            var marshaller = new DescribeStoreImageTasksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeStoreImageTasksResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeStoreImageTasksResponse;   
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
        public void DescribeTrafficMirrorFiltersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTrafficMirrorFilters");

            var request = InstantiateClassGenerator.Execute<DescribeTrafficMirrorFiltersRequest>();
            var marshaller = new DescribeTrafficMirrorFiltersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeTrafficMirrorFiltersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTrafficMirrorFiltersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeTrafficMirrorSessionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTrafficMirrorSessions");

            var request = InstantiateClassGenerator.Execute<DescribeTrafficMirrorSessionsRequest>();
            var marshaller = new DescribeTrafficMirrorSessionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeTrafficMirrorSessionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTrafficMirrorSessionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeTrafficMirrorTargetsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTrafficMirrorTargets");

            var request = InstantiateClassGenerator.Execute<DescribeTrafficMirrorTargetsRequest>();
            var marshaller = new DescribeTrafficMirrorTargetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeTrafficMirrorTargetsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTrafficMirrorTargetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeTransitGatewayAttachmentsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTransitGatewayAttachments");

            var request = InstantiateClassGenerator.Execute<DescribeTransitGatewayAttachmentsRequest>();
            var marshaller = new DescribeTransitGatewayAttachmentsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeTransitGatewayAttachmentsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTransitGatewayAttachmentsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeTransitGatewayConnectPeersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTransitGatewayConnectPeers");

            var request = InstantiateClassGenerator.Execute<DescribeTransitGatewayConnectPeersRequest>();
            var marshaller = new DescribeTransitGatewayConnectPeersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeTransitGatewayConnectPeersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTransitGatewayConnectPeersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeTransitGatewayConnectsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTransitGatewayConnects");

            var request = InstantiateClassGenerator.Execute<DescribeTransitGatewayConnectsRequest>();
            var marshaller = new DescribeTransitGatewayConnectsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeTransitGatewayConnectsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTransitGatewayConnectsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeTransitGatewayMulticastDomainsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTransitGatewayMulticastDomains");

            var request = InstantiateClassGenerator.Execute<DescribeTransitGatewayMulticastDomainsRequest>();
            var marshaller = new DescribeTransitGatewayMulticastDomainsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeTransitGatewayMulticastDomainsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTransitGatewayMulticastDomainsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeTransitGatewayPeeringAttachmentsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTransitGatewayPeeringAttachments");

            var request = InstantiateClassGenerator.Execute<DescribeTransitGatewayPeeringAttachmentsRequest>();
            var marshaller = new DescribeTransitGatewayPeeringAttachmentsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeTransitGatewayPeeringAttachmentsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTransitGatewayPeeringAttachmentsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeTransitGatewayPolicyTablesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTransitGatewayPolicyTables");

            var request = InstantiateClassGenerator.Execute<DescribeTransitGatewayPolicyTablesRequest>();
            var marshaller = new DescribeTransitGatewayPolicyTablesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeTransitGatewayPolicyTablesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTransitGatewayPolicyTablesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeTransitGatewayRouteTableAnnouncementsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTransitGatewayRouteTableAnnouncements");

            var request = InstantiateClassGenerator.Execute<DescribeTransitGatewayRouteTableAnnouncementsRequest>();
            var marshaller = new DescribeTransitGatewayRouteTableAnnouncementsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeTransitGatewayRouteTableAnnouncementsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTransitGatewayRouteTableAnnouncementsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeTransitGatewayRouteTablesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTransitGatewayRouteTables");

            var request = InstantiateClassGenerator.Execute<DescribeTransitGatewayRouteTablesRequest>();
            var marshaller = new DescribeTransitGatewayRouteTablesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeTransitGatewayRouteTablesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTransitGatewayRouteTablesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeTransitGatewaysMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTransitGateways");

            var request = InstantiateClassGenerator.Execute<DescribeTransitGatewaysRequest>();
            var marshaller = new DescribeTransitGatewaysRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeTransitGatewaysResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTransitGatewaysResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeTransitGatewayVpcAttachmentsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTransitGatewayVpcAttachments");

            var request = InstantiateClassGenerator.Execute<DescribeTransitGatewayVpcAttachmentsRequest>();
            var marshaller = new DescribeTransitGatewayVpcAttachmentsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeTransitGatewayVpcAttachmentsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTransitGatewayVpcAttachmentsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeTrunkInterfaceAssociationsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTrunkInterfaceAssociations");

            var request = InstantiateClassGenerator.Execute<DescribeTrunkInterfaceAssociationsRequest>();
            var marshaller = new DescribeTrunkInterfaceAssociationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeTrunkInterfaceAssociationsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTrunkInterfaceAssociationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeVerifiedAccessEndpointsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeVerifiedAccessEndpoints");

            var request = InstantiateClassGenerator.Execute<DescribeVerifiedAccessEndpointsRequest>();
            var marshaller = new DescribeVerifiedAccessEndpointsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeVerifiedAccessEndpointsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeVerifiedAccessEndpointsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeVerifiedAccessGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeVerifiedAccessGroups");

            var request = InstantiateClassGenerator.Execute<DescribeVerifiedAccessGroupsRequest>();
            var marshaller = new DescribeVerifiedAccessGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeVerifiedAccessGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeVerifiedAccessGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeVerifiedAccessInstanceLoggingConfigurationsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeVerifiedAccessInstanceLoggingConfigurations");

            var request = InstantiateClassGenerator.Execute<DescribeVerifiedAccessInstanceLoggingConfigurationsRequest>();
            var marshaller = new DescribeVerifiedAccessInstanceLoggingConfigurationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeVerifiedAccessInstanceLoggingConfigurationsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeVerifiedAccessInstanceLoggingConfigurationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeVerifiedAccessInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeVerifiedAccessInstances");

            var request = InstantiateClassGenerator.Execute<DescribeVerifiedAccessInstancesRequest>();
            var marshaller = new DescribeVerifiedAccessInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeVerifiedAccessInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeVerifiedAccessInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeVerifiedAccessTrustProvidersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeVerifiedAccessTrustProviders");

            var request = InstantiateClassGenerator.Execute<DescribeVerifiedAccessTrustProvidersRequest>();
            var marshaller = new DescribeVerifiedAccessTrustProvidersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeVerifiedAccessTrustProvidersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeVerifiedAccessTrustProvidersResponse;   
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
        public void DescribeVolumesModificationsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeVolumesModifications");

            var request = InstantiateClassGenerator.Execute<DescribeVolumesModificationsRequest>();
            var marshaller = new DescribeVolumesModificationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeVolumesModificationsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeVolumesModificationsResponse;   
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
        public void DescribeVpcEndpointConnectionNotificationsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeVpcEndpointConnectionNotifications");

            var request = InstantiateClassGenerator.Execute<DescribeVpcEndpointConnectionNotificationsRequest>();
            var marshaller = new DescribeVpcEndpointConnectionNotificationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeVpcEndpointConnectionNotificationsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeVpcEndpointConnectionNotificationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeVpcEndpointConnectionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeVpcEndpointConnections");

            var request = InstantiateClassGenerator.Execute<DescribeVpcEndpointConnectionsRequest>();
            var marshaller = new DescribeVpcEndpointConnectionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeVpcEndpointConnectionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeVpcEndpointConnectionsResponse;   
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
        public void DescribeVpcEndpointServiceConfigurationsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeVpcEndpointServiceConfigurations");

            var request = InstantiateClassGenerator.Execute<DescribeVpcEndpointServiceConfigurationsRequest>();
            var marshaller = new DescribeVpcEndpointServiceConfigurationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeVpcEndpointServiceConfigurationsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeVpcEndpointServiceConfigurationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DescribeVpcEndpointServicePermissionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeVpcEndpointServicePermissions");

            var request = InstantiateClassGenerator.Execute<DescribeVpcEndpointServicePermissionsRequest>();
            var marshaller = new DescribeVpcEndpointServicePermissionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DescribeVpcEndpointServicePermissionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeVpcEndpointServicePermissionsResponse;   
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
        public void DetachVerifiedAccessTrustProviderMarshallTest()
        {
            var operation = service_model.FindOperation("DetachVerifiedAccessTrustProvider");

            var request = InstantiateClassGenerator.Execute<DetachVerifiedAccessTrustProviderRequest>();
            var marshaller = new DetachVerifiedAccessTrustProviderRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DetachVerifiedAccessTrustProviderResponseUnmarshaller.Instance.Unmarshall(context)
                as DetachVerifiedAccessTrustProviderResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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
        public void DisableAddressTransferMarshallTest()
        {
            var operation = service_model.FindOperation("DisableAddressTransfer");

            var request = InstantiateClassGenerator.Execute<DisableAddressTransferRequest>();
            var marshaller = new DisableAddressTransferRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DisableAddressTransferResponseUnmarshaller.Instance.Unmarshall(context)
                as DisableAddressTransferResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DisableAwsNetworkPerformanceMetricSubscriptionMarshallTest()
        {
            var operation = service_model.FindOperation("DisableAwsNetworkPerformanceMetricSubscription");

            var request = InstantiateClassGenerator.Execute<DisableAwsNetworkPerformanceMetricSubscriptionRequest>();
            var marshaller = new DisableAwsNetworkPerformanceMetricSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DisableAwsNetworkPerformanceMetricSubscriptionResponseUnmarshaller.Instance.Unmarshall(context)
                as DisableAwsNetworkPerformanceMetricSubscriptionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DisableEbsEncryptionByDefaultMarshallTest()
        {
            var operation = service_model.FindOperation("DisableEbsEncryptionByDefault");

            var request = InstantiateClassGenerator.Execute<DisableEbsEncryptionByDefaultRequest>();
            var marshaller = new DisableEbsEncryptionByDefaultRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DisableEbsEncryptionByDefaultResponseUnmarshaller.Instance.Unmarshall(context)
                as DisableEbsEncryptionByDefaultResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DisableFastLaunchMarshallTest()
        {
            var operation = service_model.FindOperation("DisableFastLaunch");

            var request = InstantiateClassGenerator.Execute<DisableFastLaunchRequest>();
            var marshaller = new DisableFastLaunchRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DisableFastLaunchResponseUnmarshaller.Instance.Unmarshall(context)
                as DisableFastLaunchResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DisableFastSnapshotRestoresMarshallTest()
        {
            var operation = service_model.FindOperation("DisableFastSnapshotRestores");

            var request = InstantiateClassGenerator.Execute<DisableFastSnapshotRestoresRequest>();
            var marshaller = new DisableFastSnapshotRestoresRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DisableFastSnapshotRestoresResponseUnmarshaller.Instance.Unmarshall(context)
                as DisableFastSnapshotRestoresResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DisableImageDeprecationMarshallTest()
        {
            var operation = service_model.FindOperation("DisableImageDeprecation");

            var request = InstantiateClassGenerator.Execute<DisableImageDeprecationRequest>();
            var marshaller = new DisableImageDeprecationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DisableImageDeprecationResponseUnmarshaller.Instance.Unmarshall(context)
                as DisableImageDeprecationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DisableIpamOrganizationAdminAccountMarshallTest()
        {
            var operation = service_model.FindOperation("DisableIpamOrganizationAdminAccount");

            var request = InstantiateClassGenerator.Execute<DisableIpamOrganizationAdminAccountRequest>();
            var marshaller = new DisableIpamOrganizationAdminAccountRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DisableIpamOrganizationAdminAccountResponseUnmarshaller.Instance.Unmarshall(context)
                as DisableIpamOrganizationAdminAccountResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DisableSerialConsoleAccessMarshallTest()
        {
            var operation = service_model.FindOperation("DisableSerialConsoleAccess");

            var request = InstantiateClassGenerator.Execute<DisableSerialConsoleAccessRequest>();
            var marshaller = new DisableSerialConsoleAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DisableSerialConsoleAccessResponseUnmarshaller.Instance.Unmarshall(context)
                as DisableSerialConsoleAccessResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DisableTransitGatewayRouteTablePropagationMarshallTest()
        {
            var operation = service_model.FindOperation("DisableTransitGatewayRouteTablePropagation");

            var request = InstantiateClassGenerator.Execute<DisableTransitGatewayRouteTablePropagationRequest>();
            var marshaller = new DisableTransitGatewayRouteTablePropagationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DisableTransitGatewayRouteTablePropagationResponseUnmarshaller.Instance.Unmarshall(context)
                as DisableTransitGatewayRouteTablePropagationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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
        public void DisassociateClientVpnTargetNetworkMarshallTest()
        {
            var operation = service_model.FindOperation("DisassociateClientVpnTargetNetwork");

            var request = InstantiateClassGenerator.Execute<DisassociateClientVpnTargetNetworkRequest>();
            var marshaller = new DisassociateClientVpnTargetNetworkRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DisassociateClientVpnTargetNetworkResponseUnmarshaller.Instance.Unmarshall(context)
                as DisassociateClientVpnTargetNetworkResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DisassociateEnclaveCertificateIamRoleMarshallTest()
        {
            var operation = service_model.FindOperation("DisassociateEnclaveCertificateIamRole");

            var request = InstantiateClassGenerator.Execute<DisassociateEnclaveCertificateIamRoleRequest>();
            var marshaller = new DisassociateEnclaveCertificateIamRoleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DisassociateEnclaveCertificateIamRoleResponseUnmarshaller.Instance.Unmarshall(context)
                as DisassociateEnclaveCertificateIamRoleResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DisassociateIamInstanceProfileMarshallTest()
        {
            var operation = service_model.FindOperation("DisassociateIamInstanceProfile");

            var request = InstantiateClassGenerator.Execute<DisassociateIamInstanceProfileRequest>();
            var marshaller = new DisassociateIamInstanceProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DisassociateIamInstanceProfileResponseUnmarshaller.Instance.Unmarshall(context)
                as DisassociateIamInstanceProfileResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DisassociateInstanceEventWindowMarshallTest()
        {
            var operation = service_model.FindOperation("DisassociateInstanceEventWindow");

            var request = InstantiateClassGenerator.Execute<DisassociateInstanceEventWindowRequest>();
            var marshaller = new DisassociateInstanceEventWindowRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DisassociateInstanceEventWindowResponseUnmarshaller.Instance.Unmarshall(context)
                as DisassociateInstanceEventWindowResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DisassociateIpamResourceDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("DisassociateIpamResourceDiscovery");

            var request = InstantiateClassGenerator.Execute<DisassociateIpamResourceDiscoveryRequest>();
            var marshaller = new DisassociateIpamResourceDiscoveryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DisassociateIpamResourceDiscoveryResponseUnmarshaller.Instance.Unmarshall(context)
                as DisassociateIpamResourceDiscoveryResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DisassociateNatGatewayAddressMarshallTest()
        {
            var operation = service_model.FindOperation("DisassociateNatGatewayAddress");

            var request = InstantiateClassGenerator.Execute<DisassociateNatGatewayAddressRequest>();
            var marshaller = new DisassociateNatGatewayAddressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DisassociateNatGatewayAddressResponseUnmarshaller.Instance.Unmarshall(context)
                as DisassociateNatGatewayAddressResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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
        public void DisassociateSubnetCidrBlockMarshallTest()
        {
            var operation = service_model.FindOperation("DisassociateSubnetCidrBlock");

            var request = InstantiateClassGenerator.Execute<DisassociateSubnetCidrBlockRequest>();
            var marshaller = new DisassociateSubnetCidrBlockRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DisassociateSubnetCidrBlockResponseUnmarshaller.Instance.Unmarshall(context)
                as DisassociateSubnetCidrBlockResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DisassociateTransitGatewayMulticastDomainMarshallTest()
        {
            var operation = service_model.FindOperation("DisassociateTransitGatewayMulticastDomain");

            var request = InstantiateClassGenerator.Execute<DisassociateTransitGatewayMulticastDomainRequest>();
            var marshaller = new DisassociateTransitGatewayMulticastDomainRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DisassociateTransitGatewayMulticastDomainResponseUnmarshaller.Instance.Unmarshall(context)
                as DisassociateTransitGatewayMulticastDomainResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DisassociateTransitGatewayPolicyTableMarshallTest()
        {
            var operation = service_model.FindOperation("DisassociateTransitGatewayPolicyTable");

            var request = InstantiateClassGenerator.Execute<DisassociateTransitGatewayPolicyTableRequest>();
            var marshaller = new DisassociateTransitGatewayPolicyTableRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DisassociateTransitGatewayPolicyTableResponseUnmarshaller.Instance.Unmarshall(context)
                as DisassociateTransitGatewayPolicyTableResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DisassociateTransitGatewayRouteTableMarshallTest()
        {
            var operation = service_model.FindOperation("DisassociateTransitGatewayRouteTable");

            var request = InstantiateClassGenerator.Execute<DisassociateTransitGatewayRouteTableRequest>();
            var marshaller = new DisassociateTransitGatewayRouteTableRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DisassociateTransitGatewayRouteTableResponseUnmarshaller.Instance.Unmarshall(context)
                as DisassociateTransitGatewayRouteTableResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DisassociateTrunkInterfaceMarshallTest()
        {
            var operation = service_model.FindOperation("DisassociateTrunkInterface");

            var request = InstantiateClassGenerator.Execute<DisassociateTrunkInterfaceRequest>();
            var marshaller = new DisassociateTrunkInterfaceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DisassociateTrunkInterfaceResponseUnmarshaller.Instance.Unmarshall(context)
                as DisassociateTrunkInterfaceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void DisassociateVpcCidrBlockMarshallTest()
        {
            var operation = service_model.FindOperation("DisassociateVpcCidrBlock");

            var request = InstantiateClassGenerator.Execute<DisassociateVpcCidrBlockRequest>();
            var marshaller = new DisassociateVpcCidrBlockRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = DisassociateVpcCidrBlockResponseUnmarshaller.Instance.Unmarshall(context)
                as DisassociateVpcCidrBlockResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void EnableAddressTransferMarshallTest()
        {
            var operation = service_model.FindOperation("EnableAddressTransfer");

            var request = InstantiateClassGenerator.Execute<EnableAddressTransferRequest>();
            var marshaller = new EnableAddressTransferRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = EnableAddressTransferResponseUnmarshaller.Instance.Unmarshall(context)
                as EnableAddressTransferResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void EnableAwsNetworkPerformanceMetricSubscriptionMarshallTest()
        {
            var operation = service_model.FindOperation("EnableAwsNetworkPerformanceMetricSubscription");

            var request = InstantiateClassGenerator.Execute<EnableAwsNetworkPerformanceMetricSubscriptionRequest>();
            var marshaller = new EnableAwsNetworkPerformanceMetricSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = EnableAwsNetworkPerformanceMetricSubscriptionResponseUnmarshaller.Instance.Unmarshall(context)
                as EnableAwsNetworkPerformanceMetricSubscriptionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void EnableEbsEncryptionByDefaultMarshallTest()
        {
            var operation = service_model.FindOperation("EnableEbsEncryptionByDefault");

            var request = InstantiateClassGenerator.Execute<EnableEbsEncryptionByDefaultRequest>();
            var marshaller = new EnableEbsEncryptionByDefaultRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = EnableEbsEncryptionByDefaultResponseUnmarshaller.Instance.Unmarshall(context)
                as EnableEbsEncryptionByDefaultResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void EnableFastLaunchMarshallTest()
        {
            var operation = service_model.FindOperation("EnableFastLaunch");

            var request = InstantiateClassGenerator.Execute<EnableFastLaunchRequest>();
            var marshaller = new EnableFastLaunchRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = EnableFastLaunchResponseUnmarshaller.Instance.Unmarshall(context)
                as EnableFastLaunchResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void EnableFastSnapshotRestoresMarshallTest()
        {
            var operation = service_model.FindOperation("EnableFastSnapshotRestores");

            var request = InstantiateClassGenerator.Execute<EnableFastSnapshotRestoresRequest>();
            var marshaller = new EnableFastSnapshotRestoresRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = EnableFastSnapshotRestoresResponseUnmarshaller.Instance.Unmarshall(context)
                as EnableFastSnapshotRestoresResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void EnableImageDeprecationMarshallTest()
        {
            var operation = service_model.FindOperation("EnableImageDeprecation");

            var request = InstantiateClassGenerator.Execute<EnableImageDeprecationRequest>();
            var marshaller = new EnableImageDeprecationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = EnableImageDeprecationResponseUnmarshaller.Instance.Unmarshall(context)
                as EnableImageDeprecationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void EnableIpamOrganizationAdminAccountMarshallTest()
        {
            var operation = service_model.FindOperation("EnableIpamOrganizationAdminAccount");

            var request = InstantiateClassGenerator.Execute<EnableIpamOrganizationAdminAccountRequest>();
            var marshaller = new EnableIpamOrganizationAdminAccountRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = EnableIpamOrganizationAdminAccountResponseUnmarshaller.Instance.Unmarshall(context)
                as EnableIpamOrganizationAdminAccountResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void EnableReachabilityAnalyzerOrganizationSharingMarshallTest()
        {
            var operation = service_model.FindOperation("EnableReachabilityAnalyzerOrganizationSharing");

            var request = InstantiateClassGenerator.Execute<EnableReachabilityAnalyzerOrganizationSharingRequest>();
            var marshaller = new EnableReachabilityAnalyzerOrganizationSharingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = EnableReachabilityAnalyzerOrganizationSharingResponseUnmarshaller.Instance.Unmarshall(context)
                as EnableReachabilityAnalyzerOrganizationSharingResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void EnableSerialConsoleAccessMarshallTest()
        {
            var operation = service_model.FindOperation("EnableSerialConsoleAccess");

            var request = InstantiateClassGenerator.Execute<EnableSerialConsoleAccessRequest>();
            var marshaller = new EnableSerialConsoleAccessRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = EnableSerialConsoleAccessResponseUnmarshaller.Instance.Unmarshall(context)
                as EnableSerialConsoleAccessResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void EnableTransitGatewayRouteTablePropagationMarshallTest()
        {
            var operation = service_model.FindOperation("EnableTransitGatewayRouteTablePropagation");

            var request = InstantiateClassGenerator.Execute<EnableTransitGatewayRouteTablePropagationRequest>();
            var marshaller = new EnableTransitGatewayRouteTablePropagationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = EnableTransitGatewayRouteTablePropagationResponseUnmarshaller.Instance.Unmarshall(context)
                as EnableTransitGatewayRouteTablePropagationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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
        public void ExportClientVpnClientCertificateRevocationListMarshallTest()
        {
            var operation = service_model.FindOperation("ExportClientVpnClientCertificateRevocationList");

            var request = InstantiateClassGenerator.Execute<ExportClientVpnClientCertificateRevocationListRequest>();
            var marshaller = new ExportClientVpnClientCertificateRevocationListRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ExportClientVpnClientCertificateRevocationListResponseUnmarshaller.Instance.Unmarshall(context)
                as ExportClientVpnClientCertificateRevocationListResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ExportClientVpnClientConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("ExportClientVpnClientConfiguration");

            var request = InstantiateClassGenerator.Execute<ExportClientVpnClientConfigurationRequest>();
            var marshaller = new ExportClientVpnClientConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ExportClientVpnClientConfigurationResponseUnmarshaller.Instance.Unmarshall(context)
                as ExportClientVpnClientConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ExportImageMarshallTest()
        {
            var operation = service_model.FindOperation("ExportImage");

            var request = InstantiateClassGenerator.Execute<ExportImageRequest>();
            var marshaller = new ExportImageRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ExportImageResponseUnmarshaller.Instance.Unmarshall(context)
                as ExportImageResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ExportTransitGatewayRoutesMarshallTest()
        {
            var operation = service_model.FindOperation("ExportTransitGatewayRoutes");

            var request = InstantiateClassGenerator.Execute<ExportTransitGatewayRoutesRequest>();
            var marshaller = new ExportTransitGatewayRoutesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ExportTransitGatewayRoutesResponseUnmarshaller.Instance.Unmarshall(context)
                as ExportTransitGatewayRoutesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetAssociatedEnclaveCertificateIamRolesMarshallTest()
        {
            var operation = service_model.FindOperation("GetAssociatedEnclaveCertificateIamRoles");

            var request = InstantiateClassGenerator.Execute<GetAssociatedEnclaveCertificateIamRolesRequest>();
            var marshaller = new GetAssociatedEnclaveCertificateIamRolesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetAssociatedEnclaveCertificateIamRolesResponseUnmarshaller.Instance.Unmarshall(context)
                as GetAssociatedEnclaveCertificateIamRolesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetAssociatedIpv6PoolCidrsMarshallTest()
        {
            var operation = service_model.FindOperation("GetAssociatedIpv6PoolCidrs");

            var request = InstantiateClassGenerator.Execute<GetAssociatedIpv6PoolCidrsRequest>();
            var marshaller = new GetAssociatedIpv6PoolCidrsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetAssociatedIpv6PoolCidrsResponseUnmarshaller.Instance.Unmarshall(context)
                as GetAssociatedIpv6PoolCidrsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetAwsNetworkPerformanceDataMarshallTest()
        {
            var operation = service_model.FindOperation("GetAwsNetworkPerformanceData");

            var request = InstantiateClassGenerator.Execute<GetAwsNetworkPerformanceDataRequest>();
            var marshaller = new GetAwsNetworkPerformanceDataRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetAwsNetworkPerformanceDataResponseUnmarshaller.Instance.Unmarshall(context)
                as GetAwsNetworkPerformanceDataResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetCapacityReservationUsageMarshallTest()
        {
            var operation = service_model.FindOperation("GetCapacityReservationUsage");

            var request = InstantiateClassGenerator.Execute<GetCapacityReservationUsageRequest>();
            var marshaller = new GetCapacityReservationUsageRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetCapacityReservationUsageResponseUnmarshaller.Instance.Unmarshall(context)
                as GetCapacityReservationUsageResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetCoipPoolUsageMarshallTest()
        {
            var operation = service_model.FindOperation("GetCoipPoolUsage");

            var request = InstantiateClassGenerator.Execute<GetCoipPoolUsageRequest>();
            var marshaller = new GetCoipPoolUsageRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetCoipPoolUsageResponseUnmarshaller.Instance.Unmarshall(context)
                as GetCoipPoolUsageResponse;   
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
        public void GetDefaultCreditSpecificationMarshallTest()
        {
            var operation = service_model.FindOperation("GetDefaultCreditSpecification");

            var request = InstantiateClassGenerator.Execute<GetDefaultCreditSpecificationRequest>();
            var marshaller = new GetDefaultCreditSpecificationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetDefaultCreditSpecificationResponseUnmarshaller.Instance.Unmarshall(context)
                as GetDefaultCreditSpecificationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetEbsDefaultKmsKeyIdMarshallTest()
        {
            var operation = service_model.FindOperation("GetEbsDefaultKmsKeyId");

            var request = InstantiateClassGenerator.Execute<GetEbsDefaultKmsKeyIdRequest>();
            var marshaller = new GetEbsDefaultKmsKeyIdRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetEbsDefaultKmsKeyIdResponseUnmarshaller.Instance.Unmarshall(context)
                as GetEbsDefaultKmsKeyIdResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetEbsEncryptionByDefaultMarshallTest()
        {
            var operation = service_model.FindOperation("GetEbsEncryptionByDefault");

            var request = InstantiateClassGenerator.Execute<GetEbsEncryptionByDefaultRequest>();
            var marshaller = new GetEbsEncryptionByDefaultRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetEbsEncryptionByDefaultResponseUnmarshaller.Instance.Unmarshall(context)
                as GetEbsEncryptionByDefaultResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetFlowLogsIntegrationTemplateMarshallTest()
        {
            var operation = service_model.FindOperation("GetFlowLogsIntegrationTemplate");

            var request = InstantiateClassGenerator.Execute<GetFlowLogsIntegrationTemplateRequest>();
            var marshaller = new GetFlowLogsIntegrationTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetFlowLogsIntegrationTemplateResponseUnmarshaller.Instance.Unmarshall(context)
                as GetFlowLogsIntegrationTemplateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetGroupsForCapacityReservationMarshallTest()
        {
            var operation = service_model.FindOperation("GetGroupsForCapacityReservation");

            var request = InstantiateClassGenerator.Execute<GetGroupsForCapacityReservationRequest>();
            var marshaller = new GetGroupsForCapacityReservationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetGroupsForCapacityReservationResponseUnmarshaller.Instance.Unmarshall(context)
                as GetGroupsForCapacityReservationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetHostReservationPurchasePreviewMarshallTest()
        {
            var operation = service_model.FindOperation("GetHostReservationPurchasePreview");

            var request = InstantiateClassGenerator.Execute<GetHostReservationPurchasePreviewRequest>();
            var marshaller = new GetHostReservationPurchasePreviewRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetHostReservationPurchasePreviewResponseUnmarshaller.Instance.Unmarshall(context)
                as GetHostReservationPurchasePreviewResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetInstanceTypesFromInstanceRequirementsMarshallTest()
        {
            var operation = service_model.FindOperation("GetInstanceTypesFromInstanceRequirements");

            var request = InstantiateClassGenerator.Execute<GetInstanceTypesFromInstanceRequirementsRequest>();
            var marshaller = new GetInstanceTypesFromInstanceRequirementsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetInstanceTypesFromInstanceRequirementsResponseUnmarshaller.Instance.Unmarshall(context)
                as GetInstanceTypesFromInstanceRequirementsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetInstanceUefiDataMarshallTest()
        {
            var operation = service_model.FindOperation("GetInstanceUefiData");

            var request = InstantiateClassGenerator.Execute<GetInstanceUefiDataRequest>();
            var marshaller = new GetInstanceUefiDataRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetInstanceUefiDataResponseUnmarshaller.Instance.Unmarshall(context)
                as GetInstanceUefiDataResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetIpamAddressHistoryMarshallTest()
        {
            var operation = service_model.FindOperation("GetIpamAddressHistory");

            var request = InstantiateClassGenerator.Execute<GetIpamAddressHistoryRequest>();
            var marshaller = new GetIpamAddressHistoryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetIpamAddressHistoryResponseUnmarshaller.Instance.Unmarshall(context)
                as GetIpamAddressHistoryResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetIpamDiscoveredAccountsMarshallTest()
        {
            var operation = service_model.FindOperation("GetIpamDiscoveredAccounts");

            var request = InstantiateClassGenerator.Execute<GetIpamDiscoveredAccountsRequest>();
            var marshaller = new GetIpamDiscoveredAccountsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetIpamDiscoveredAccountsResponseUnmarshaller.Instance.Unmarshall(context)
                as GetIpamDiscoveredAccountsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetIpamDiscoveredResourceCidrsMarshallTest()
        {
            var operation = service_model.FindOperation("GetIpamDiscoveredResourceCidrs");

            var request = InstantiateClassGenerator.Execute<GetIpamDiscoveredResourceCidrsRequest>();
            var marshaller = new GetIpamDiscoveredResourceCidrsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetIpamDiscoveredResourceCidrsResponseUnmarshaller.Instance.Unmarshall(context)
                as GetIpamDiscoveredResourceCidrsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetIpamPoolAllocationsMarshallTest()
        {
            var operation = service_model.FindOperation("GetIpamPoolAllocations");

            var request = InstantiateClassGenerator.Execute<GetIpamPoolAllocationsRequest>();
            var marshaller = new GetIpamPoolAllocationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetIpamPoolAllocationsResponseUnmarshaller.Instance.Unmarshall(context)
                as GetIpamPoolAllocationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetIpamPoolCidrsMarshallTest()
        {
            var operation = service_model.FindOperation("GetIpamPoolCidrs");

            var request = InstantiateClassGenerator.Execute<GetIpamPoolCidrsRequest>();
            var marshaller = new GetIpamPoolCidrsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetIpamPoolCidrsResponseUnmarshaller.Instance.Unmarshall(context)
                as GetIpamPoolCidrsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetIpamResourceCidrsMarshallTest()
        {
            var operation = service_model.FindOperation("GetIpamResourceCidrs");

            var request = InstantiateClassGenerator.Execute<GetIpamResourceCidrsRequest>();
            var marshaller = new GetIpamResourceCidrsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetIpamResourceCidrsResponseUnmarshaller.Instance.Unmarshall(context)
                as GetIpamResourceCidrsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetLaunchTemplateDataMarshallTest()
        {
            var operation = service_model.FindOperation("GetLaunchTemplateData");

            var request = InstantiateClassGenerator.Execute<GetLaunchTemplateDataRequest>();
            var marshaller = new GetLaunchTemplateDataRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetLaunchTemplateDataResponseUnmarshaller.Instance.Unmarshall(context)
                as GetLaunchTemplateDataResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetManagedPrefixListAssociationsMarshallTest()
        {
            var operation = service_model.FindOperation("GetManagedPrefixListAssociations");

            var request = InstantiateClassGenerator.Execute<GetManagedPrefixListAssociationsRequest>();
            var marshaller = new GetManagedPrefixListAssociationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetManagedPrefixListAssociationsResponseUnmarshaller.Instance.Unmarshall(context)
                as GetManagedPrefixListAssociationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetManagedPrefixListEntriesMarshallTest()
        {
            var operation = service_model.FindOperation("GetManagedPrefixListEntries");

            var request = InstantiateClassGenerator.Execute<GetManagedPrefixListEntriesRequest>();
            var marshaller = new GetManagedPrefixListEntriesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetManagedPrefixListEntriesResponseUnmarshaller.Instance.Unmarshall(context)
                as GetManagedPrefixListEntriesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetNetworkInsightsAccessScopeAnalysisFindingsMarshallTest()
        {
            var operation = service_model.FindOperation("GetNetworkInsightsAccessScopeAnalysisFindings");

            var request = InstantiateClassGenerator.Execute<GetNetworkInsightsAccessScopeAnalysisFindingsRequest>();
            var marshaller = new GetNetworkInsightsAccessScopeAnalysisFindingsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetNetworkInsightsAccessScopeAnalysisFindingsResponseUnmarshaller.Instance.Unmarshall(context)
                as GetNetworkInsightsAccessScopeAnalysisFindingsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetNetworkInsightsAccessScopeContentMarshallTest()
        {
            var operation = service_model.FindOperation("GetNetworkInsightsAccessScopeContent");

            var request = InstantiateClassGenerator.Execute<GetNetworkInsightsAccessScopeContentRequest>();
            var marshaller = new GetNetworkInsightsAccessScopeContentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetNetworkInsightsAccessScopeContentResponseUnmarshaller.Instance.Unmarshall(context)
                as GetNetworkInsightsAccessScopeContentResponse;   
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
        public void GetReservedInstancesExchangeQuoteMarshallTest()
        {
            var operation = service_model.FindOperation("GetReservedInstancesExchangeQuote");

            var request = InstantiateClassGenerator.Execute<GetReservedInstancesExchangeQuoteRequest>();
            var marshaller = new GetReservedInstancesExchangeQuoteRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetReservedInstancesExchangeQuoteResponseUnmarshaller.Instance.Unmarshall(context)
                as GetReservedInstancesExchangeQuoteResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetSerialConsoleAccessStatusMarshallTest()
        {
            var operation = service_model.FindOperation("GetSerialConsoleAccessStatus");

            var request = InstantiateClassGenerator.Execute<GetSerialConsoleAccessStatusRequest>();
            var marshaller = new GetSerialConsoleAccessStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetSerialConsoleAccessStatusResponseUnmarshaller.Instance.Unmarshall(context)
                as GetSerialConsoleAccessStatusResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetSpotPlacementScoresMarshallTest()
        {
            var operation = service_model.FindOperation("GetSpotPlacementScores");

            var request = InstantiateClassGenerator.Execute<GetSpotPlacementScoresRequest>();
            var marshaller = new GetSpotPlacementScoresRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetSpotPlacementScoresResponseUnmarshaller.Instance.Unmarshall(context)
                as GetSpotPlacementScoresResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetSubnetCidrReservationsMarshallTest()
        {
            var operation = service_model.FindOperation("GetSubnetCidrReservations");

            var request = InstantiateClassGenerator.Execute<GetSubnetCidrReservationsRequest>();
            var marshaller = new GetSubnetCidrReservationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetSubnetCidrReservationsResponseUnmarshaller.Instance.Unmarshall(context)
                as GetSubnetCidrReservationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetTransitGatewayAttachmentPropagationsMarshallTest()
        {
            var operation = service_model.FindOperation("GetTransitGatewayAttachmentPropagations");

            var request = InstantiateClassGenerator.Execute<GetTransitGatewayAttachmentPropagationsRequest>();
            var marshaller = new GetTransitGatewayAttachmentPropagationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetTransitGatewayAttachmentPropagationsResponseUnmarshaller.Instance.Unmarshall(context)
                as GetTransitGatewayAttachmentPropagationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetTransitGatewayMulticastDomainAssociationsMarshallTest()
        {
            var operation = service_model.FindOperation("GetTransitGatewayMulticastDomainAssociations");

            var request = InstantiateClassGenerator.Execute<GetTransitGatewayMulticastDomainAssociationsRequest>();
            var marshaller = new GetTransitGatewayMulticastDomainAssociationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetTransitGatewayMulticastDomainAssociationsResponseUnmarshaller.Instance.Unmarshall(context)
                as GetTransitGatewayMulticastDomainAssociationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetTransitGatewayPolicyTableAssociationsMarshallTest()
        {
            var operation = service_model.FindOperation("GetTransitGatewayPolicyTableAssociations");

            var request = InstantiateClassGenerator.Execute<GetTransitGatewayPolicyTableAssociationsRequest>();
            var marshaller = new GetTransitGatewayPolicyTableAssociationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetTransitGatewayPolicyTableAssociationsResponseUnmarshaller.Instance.Unmarshall(context)
                as GetTransitGatewayPolicyTableAssociationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetTransitGatewayPolicyTableEntriesMarshallTest()
        {
            var operation = service_model.FindOperation("GetTransitGatewayPolicyTableEntries");

            var request = InstantiateClassGenerator.Execute<GetTransitGatewayPolicyTableEntriesRequest>();
            var marshaller = new GetTransitGatewayPolicyTableEntriesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetTransitGatewayPolicyTableEntriesResponseUnmarshaller.Instance.Unmarshall(context)
                as GetTransitGatewayPolicyTableEntriesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetTransitGatewayPrefixListReferencesMarshallTest()
        {
            var operation = service_model.FindOperation("GetTransitGatewayPrefixListReferences");

            var request = InstantiateClassGenerator.Execute<GetTransitGatewayPrefixListReferencesRequest>();
            var marshaller = new GetTransitGatewayPrefixListReferencesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetTransitGatewayPrefixListReferencesResponseUnmarshaller.Instance.Unmarshall(context)
                as GetTransitGatewayPrefixListReferencesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetTransitGatewayRouteTableAssociationsMarshallTest()
        {
            var operation = service_model.FindOperation("GetTransitGatewayRouteTableAssociations");

            var request = InstantiateClassGenerator.Execute<GetTransitGatewayRouteTableAssociationsRequest>();
            var marshaller = new GetTransitGatewayRouteTableAssociationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetTransitGatewayRouteTableAssociationsResponseUnmarshaller.Instance.Unmarshall(context)
                as GetTransitGatewayRouteTableAssociationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetTransitGatewayRouteTablePropagationsMarshallTest()
        {
            var operation = service_model.FindOperation("GetTransitGatewayRouteTablePropagations");

            var request = InstantiateClassGenerator.Execute<GetTransitGatewayRouteTablePropagationsRequest>();
            var marshaller = new GetTransitGatewayRouteTablePropagationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetTransitGatewayRouteTablePropagationsResponseUnmarshaller.Instance.Unmarshall(context)
                as GetTransitGatewayRouteTablePropagationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetVerifiedAccessEndpointPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("GetVerifiedAccessEndpointPolicy");

            var request = InstantiateClassGenerator.Execute<GetVerifiedAccessEndpointPolicyRequest>();
            var marshaller = new GetVerifiedAccessEndpointPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetVerifiedAccessEndpointPolicyResponseUnmarshaller.Instance.Unmarshall(context)
                as GetVerifiedAccessEndpointPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetVerifiedAccessGroupPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("GetVerifiedAccessGroupPolicy");

            var request = InstantiateClassGenerator.Execute<GetVerifiedAccessGroupPolicyRequest>();
            var marshaller = new GetVerifiedAccessGroupPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetVerifiedAccessGroupPolicyResponseUnmarshaller.Instance.Unmarshall(context)
                as GetVerifiedAccessGroupPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetVpnConnectionDeviceSampleConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("GetVpnConnectionDeviceSampleConfiguration");

            var request = InstantiateClassGenerator.Execute<GetVpnConnectionDeviceSampleConfigurationRequest>();
            var marshaller = new GetVpnConnectionDeviceSampleConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetVpnConnectionDeviceSampleConfigurationResponseUnmarshaller.Instance.Unmarshall(context)
                as GetVpnConnectionDeviceSampleConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void GetVpnConnectionDeviceTypesMarshallTest()
        {
            var operation = service_model.FindOperation("GetVpnConnectionDeviceTypes");

            var request = InstantiateClassGenerator.Execute<GetVpnConnectionDeviceTypesRequest>();
            var marshaller = new GetVpnConnectionDeviceTypesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = GetVpnConnectionDeviceTypesResponseUnmarshaller.Instance.Unmarshall(context)
                as GetVpnConnectionDeviceTypesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ImportClientVpnClientCertificateRevocationListMarshallTest()
        {
            var operation = service_model.FindOperation("ImportClientVpnClientCertificateRevocationList");

            var request = InstantiateClassGenerator.Execute<ImportClientVpnClientCertificateRevocationListRequest>();
            var marshaller = new ImportClientVpnClientCertificateRevocationListRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ImportClientVpnClientCertificateRevocationListResponseUnmarshaller.Instance.Unmarshall(context)
                as ImportClientVpnClientCertificateRevocationListResponse;   
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
        public void ListImagesInRecycleBinMarshallTest()
        {
            var operation = service_model.FindOperation("ListImagesInRecycleBin");

            var request = InstantiateClassGenerator.Execute<ListImagesInRecycleBinRequest>();
            var marshaller = new ListImagesInRecycleBinRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ListImagesInRecycleBinResponseUnmarshaller.Instance.Unmarshall(context)
                as ListImagesInRecycleBinResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ListSnapshotsInRecycleBinMarshallTest()
        {
            var operation = service_model.FindOperation("ListSnapshotsInRecycleBin");

            var request = InstantiateClassGenerator.Execute<ListSnapshotsInRecycleBinRequest>();
            var marshaller = new ListSnapshotsInRecycleBinRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ListSnapshotsInRecycleBinResponseUnmarshaller.Instance.Unmarshall(context)
                as ListSnapshotsInRecycleBinResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyAddressAttributeMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyAddressAttribute");

            var request = InstantiateClassGenerator.Execute<ModifyAddressAttributeRequest>();
            var marshaller = new ModifyAddressAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyAddressAttributeResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyAddressAttributeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyAvailabilityZoneGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyAvailabilityZoneGroup");

            var request = InstantiateClassGenerator.Execute<ModifyAvailabilityZoneGroupRequest>();
            var marshaller = new ModifyAvailabilityZoneGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyAvailabilityZoneGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyAvailabilityZoneGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyCapacityReservationMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCapacityReservation");

            var request = InstantiateClassGenerator.Execute<ModifyCapacityReservationRequest>();
            var marshaller = new ModifyCapacityReservationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyCapacityReservationResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyCapacityReservationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyCapacityReservationFleetMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyCapacityReservationFleet");

            var request = InstantiateClassGenerator.Execute<ModifyCapacityReservationFleetRequest>();
            var marshaller = new ModifyCapacityReservationFleetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyCapacityReservationFleetResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyCapacityReservationFleetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyClientVpnEndpointMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyClientVpnEndpoint");

            var request = InstantiateClassGenerator.Execute<ModifyClientVpnEndpointRequest>();
            var marshaller = new ModifyClientVpnEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyClientVpnEndpointResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyClientVpnEndpointResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyDefaultCreditSpecificationMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyDefaultCreditSpecification");

            var request = InstantiateClassGenerator.Execute<ModifyDefaultCreditSpecificationRequest>();
            var marshaller = new ModifyDefaultCreditSpecificationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyDefaultCreditSpecificationResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyDefaultCreditSpecificationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyEbsDefaultKmsKeyIdMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyEbsDefaultKmsKeyId");

            var request = InstantiateClassGenerator.Execute<ModifyEbsDefaultKmsKeyIdRequest>();
            var marshaller = new ModifyEbsDefaultKmsKeyIdRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyEbsDefaultKmsKeyIdResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyEbsDefaultKmsKeyIdResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyFleetMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyFleet");

            var request = InstantiateClassGenerator.Execute<ModifyFleetRequest>();
            var marshaller = new ModifyFleetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyFleetResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyFleetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyFpgaImageAttributeMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyFpgaImageAttribute");

            var request = InstantiateClassGenerator.Execute<ModifyFpgaImageAttributeRequest>();
            var marshaller = new ModifyFpgaImageAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyFpgaImageAttributeResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyFpgaImageAttributeResponse;   
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
        public void ModifyInstanceCapacityReservationAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyInstanceCapacityReservationAttributes");

            var request = InstantiateClassGenerator.Execute<ModifyInstanceCapacityReservationAttributesRequest>();
            var marshaller = new ModifyInstanceCapacityReservationAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyInstanceCapacityReservationAttributesResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyInstanceCapacityReservationAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyInstanceCreditSpecificationMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyInstanceCreditSpecification");

            var request = InstantiateClassGenerator.Execute<ModifyInstanceCreditSpecificationRequest>();
            var marshaller = new ModifyInstanceCreditSpecificationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyInstanceCreditSpecificationResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyInstanceCreditSpecificationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyInstanceEventStartTimeMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyInstanceEventStartTime");

            var request = InstantiateClassGenerator.Execute<ModifyInstanceEventStartTimeRequest>();
            var marshaller = new ModifyInstanceEventStartTimeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyInstanceEventStartTimeResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyInstanceEventStartTimeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyInstanceEventWindowMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyInstanceEventWindow");

            var request = InstantiateClassGenerator.Execute<ModifyInstanceEventWindowRequest>();
            var marshaller = new ModifyInstanceEventWindowRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyInstanceEventWindowResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyInstanceEventWindowResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyInstanceMaintenanceOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyInstanceMaintenanceOptions");

            var request = InstantiateClassGenerator.Execute<ModifyInstanceMaintenanceOptionsRequest>();
            var marshaller = new ModifyInstanceMaintenanceOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyInstanceMaintenanceOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyInstanceMaintenanceOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyInstanceMetadataOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyInstanceMetadataOptions");

            var request = InstantiateClassGenerator.Execute<ModifyInstanceMetadataOptionsRequest>();
            var marshaller = new ModifyInstanceMetadataOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyInstanceMetadataOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyInstanceMetadataOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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
        public void ModifyIpamMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyIpam");

            var request = InstantiateClassGenerator.Execute<ModifyIpamRequest>();
            var marshaller = new ModifyIpamRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyIpamResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyIpamResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyIpamPoolMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyIpamPool");

            var request = InstantiateClassGenerator.Execute<ModifyIpamPoolRequest>();
            var marshaller = new ModifyIpamPoolRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyIpamPoolResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyIpamPoolResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyIpamResourceCidrMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyIpamResourceCidr");

            var request = InstantiateClassGenerator.Execute<ModifyIpamResourceCidrRequest>();
            var marshaller = new ModifyIpamResourceCidrRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyIpamResourceCidrResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyIpamResourceCidrResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyIpamResourceDiscoveryMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyIpamResourceDiscovery");

            var request = InstantiateClassGenerator.Execute<ModifyIpamResourceDiscoveryRequest>();
            var marshaller = new ModifyIpamResourceDiscoveryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyIpamResourceDiscoveryResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyIpamResourceDiscoveryResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyIpamScopeMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyIpamScope");

            var request = InstantiateClassGenerator.Execute<ModifyIpamScopeRequest>();
            var marshaller = new ModifyIpamScopeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyIpamScopeResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyIpamScopeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyLaunchTemplateMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyLaunchTemplate");

            var request = InstantiateClassGenerator.Execute<ModifyLaunchTemplateRequest>();
            var marshaller = new ModifyLaunchTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyLaunchTemplateResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyLaunchTemplateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyLocalGatewayRouteMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyLocalGatewayRoute");

            var request = InstantiateClassGenerator.Execute<ModifyLocalGatewayRouteRequest>();
            var marshaller = new ModifyLocalGatewayRouteRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyLocalGatewayRouteResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyLocalGatewayRouteResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyManagedPrefixListMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyManagedPrefixList");

            var request = InstantiateClassGenerator.Execute<ModifyManagedPrefixListRequest>();
            var marshaller = new ModifyManagedPrefixListRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyManagedPrefixListResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyManagedPrefixListResponse;   
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
        public void ModifyPrivateDnsNameOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyPrivateDnsNameOptions");

            var request = InstantiateClassGenerator.Execute<ModifyPrivateDnsNameOptionsRequest>();
            var marshaller = new ModifyPrivateDnsNameOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyPrivateDnsNameOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyPrivateDnsNameOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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
        public void ModifySecurityGroupRulesMarshallTest()
        {
            var operation = service_model.FindOperation("ModifySecurityGroupRules");

            var request = InstantiateClassGenerator.Execute<ModifySecurityGroupRulesRequest>();
            var marshaller = new ModifySecurityGroupRulesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifySecurityGroupRulesResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifySecurityGroupRulesResponse;   
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
        public void ModifySnapshotTierMarshallTest()
        {
            var operation = service_model.FindOperation("ModifySnapshotTier");

            var request = InstantiateClassGenerator.Execute<ModifySnapshotTierRequest>();
            var marshaller = new ModifySnapshotTierRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifySnapshotTierResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifySnapshotTierResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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
        public void ModifyTrafficMirrorFilterNetworkServicesMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyTrafficMirrorFilterNetworkServices");

            var request = InstantiateClassGenerator.Execute<ModifyTrafficMirrorFilterNetworkServicesRequest>();
            var marshaller = new ModifyTrafficMirrorFilterNetworkServicesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyTrafficMirrorFilterNetworkServicesResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyTrafficMirrorFilterNetworkServicesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyTrafficMirrorFilterRuleMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyTrafficMirrorFilterRule");

            var request = InstantiateClassGenerator.Execute<ModifyTrafficMirrorFilterRuleRequest>();
            var marshaller = new ModifyTrafficMirrorFilterRuleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyTrafficMirrorFilterRuleResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyTrafficMirrorFilterRuleResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyTrafficMirrorSessionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyTrafficMirrorSession");

            var request = InstantiateClassGenerator.Execute<ModifyTrafficMirrorSessionRequest>();
            var marshaller = new ModifyTrafficMirrorSessionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyTrafficMirrorSessionResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyTrafficMirrorSessionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyTransitGatewayMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyTransitGateway");

            var request = InstantiateClassGenerator.Execute<ModifyTransitGatewayRequest>();
            var marshaller = new ModifyTransitGatewayRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyTransitGatewayResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyTransitGatewayResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyTransitGatewayPrefixListReferenceMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyTransitGatewayPrefixListReference");

            var request = InstantiateClassGenerator.Execute<ModifyTransitGatewayPrefixListReferenceRequest>();
            var marshaller = new ModifyTransitGatewayPrefixListReferenceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyTransitGatewayPrefixListReferenceResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyTransitGatewayPrefixListReferenceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyTransitGatewayVpcAttachmentMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyTransitGatewayVpcAttachment");

            var request = InstantiateClassGenerator.Execute<ModifyTransitGatewayVpcAttachmentRequest>();
            var marshaller = new ModifyTransitGatewayVpcAttachmentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyTransitGatewayVpcAttachmentResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyTransitGatewayVpcAttachmentResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyVerifiedAccessEndpointMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyVerifiedAccessEndpoint");

            var request = InstantiateClassGenerator.Execute<ModifyVerifiedAccessEndpointRequest>();
            var marshaller = new ModifyVerifiedAccessEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyVerifiedAccessEndpointResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyVerifiedAccessEndpointResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyVerifiedAccessEndpointPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyVerifiedAccessEndpointPolicy");

            var request = InstantiateClassGenerator.Execute<ModifyVerifiedAccessEndpointPolicyRequest>();
            var marshaller = new ModifyVerifiedAccessEndpointPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyVerifiedAccessEndpointPolicyResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyVerifiedAccessEndpointPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyVerifiedAccessGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyVerifiedAccessGroup");

            var request = InstantiateClassGenerator.Execute<ModifyVerifiedAccessGroupRequest>();
            var marshaller = new ModifyVerifiedAccessGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyVerifiedAccessGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyVerifiedAccessGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyVerifiedAccessGroupPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyVerifiedAccessGroupPolicy");

            var request = InstantiateClassGenerator.Execute<ModifyVerifiedAccessGroupPolicyRequest>();
            var marshaller = new ModifyVerifiedAccessGroupPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyVerifiedAccessGroupPolicyResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyVerifiedAccessGroupPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyVerifiedAccessInstanceMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyVerifiedAccessInstance");

            var request = InstantiateClassGenerator.Execute<ModifyVerifiedAccessInstanceRequest>();
            var marshaller = new ModifyVerifiedAccessInstanceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyVerifiedAccessInstanceResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyVerifiedAccessInstanceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyVerifiedAccessInstanceLoggingConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyVerifiedAccessInstanceLoggingConfiguration");

            var request = InstantiateClassGenerator.Execute<ModifyVerifiedAccessInstanceLoggingConfigurationRequest>();
            var marshaller = new ModifyVerifiedAccessInstanceLoggingConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyVerifiedAccessInstanceLoggingConfigurationResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyVerifiedAccessInstanceLoggingConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyVerifiedAccessTrustProviderMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyVerifiedAccessTrustProvider");

            var request = InstantiateClassGenerator.Execute<ModifyVerifiedAccessTrustProviderRequest>();
            var marshaller = new ModifyVerifiedAccessTrustProviderRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyVerifiedAccessTrustProviderResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyVerifiedAccessTrustProviderResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyVolumeMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyVolume");

            var request = InstantiateClassGenerator.Execute<ModifyVolumeRequest>();
            var marshaller = new ModifyVolumeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyVolumeResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyVolumeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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
        public void ModifyVpcEndpointConnectionNotificationMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyVpcEndpointConnectionNotification");

            var request = InstantiateClassGenerator.Execute<ModifyVpcEndpointConnectionNotificationRequest>();
            var marshaller = new ModifyVpcEndpointConnectionNotificationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyVpcEndpointConnectionNotificationResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyVpcEndpointConnectionNotificationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyVpcEndpointServiceConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyVpcEndpointServiceConfiguration");

            var request = InstantiateClassGenerator.Execute<ModifyVpcEndpointServiceConfigurationRequest>();
            var marshaller = new ModifyVpcEndpointServiceConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyVpcEndpointServiceConfigurationResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyVpcEndpointServiceConfigurationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyVpcEndpointServicePayerResponsibilityMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyVpcEndpointServicePayerResponsibility");

            var request = InstantiateClassGenerator.Execute<ModifyVpcEndpointServicePayerResponsibilityRequest>();
            var marshaller = new ModifyVpcEndpointServicePayerResponsibilityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyVpcEndpointServicePayerResponsibilityResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyVpcEndpointServicePayerResponsibilityResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyVpcEndpointServicePermissionsMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyVpcEndpointServicePermissions");

            var request = InstantiateClassGenerator.Execute<ModifyVpcEndpointServicePermissionsRequest>();
            var marshaller = new ModifyVpcEndpointServicePermissionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyVpcEndpointServicePermissionsResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyVpcEndpointServicePermissionsResponse;   
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
        public void ModifyVpcTenancyMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyVpcTenancy");

            var request = InstantiateClassGenerator.Execute<ModifyVpcTenancyRequest>();
            var marshaller = new ModifyVpcTenancyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyVpcTenancyResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyVpcTenancyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyVpnConnectionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyVpnConnection");

            var request = InstantiateClassGenerator.Execute<ModifyVpnConnectionRequest>();
            var marshaller = new ModifyVpnConnectionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyVpnConnectionResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyVpnConnectionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyVpnConnectionOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyVpnConnectionOptions");

            var request = InstantiateClassGenerator.Execute<ModifyVpnConnectionOptionsRequest>();
            var marshaller = new ModifyVpnConnectionOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyVpnConnectionOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyVpnConnectionOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyVpnTunnelCertificateMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyVpnTunnelCertificate");

            var request = InstantiateClassGenerator.Execute<ModifyVpnTunnelCertificateRequest>();
            var marshaller = new ModifyVpnTunnelCertificateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyVpnTunnelCertificateResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyVpnTunnelCertificateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ModifyVpnTunnelOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyVpnTunnelOptions");

            var request = InstantiateClassGenerator.Execute<ModifyVpnTunnelOptionsRequest>();
            var marshaller = new ModifyVpnTunnelOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ModifyVpnTunnelOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyVpnTunnelOptionsResponse;   
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
        public void MoveByoipCidrToIpamMarshallTest()
        {
            var operation = service_model.FindOperation("MoveByoipCidrToIpam");

            var request = InstantiateClassGenerator.Execute<MoveByoipCidrToIpamRequest>();
            var marshaller = new MoveByoipCidrToIpamRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = MoveByoipCidrToIpamResponseUnmarshaller.Instance.Unmarshall(context)
                as MoveByoipCidrToIpamResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ProvisionByoipCidrMarshallTest()
        {
            var operation = service_model.FindOperation("ProvisionByoipCidr");

            var request = InstantiateClassGenerator.Execute<ProvisionByoipCidrRequest>();
            var marshaller = new ProvisionByoipCidrRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ProvisionByoipCidrResponseUnmarshaller.Instance.Unmarshall(context)
                as ProvisionByoipCidrResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ProvisionIpamPoolCidrMarshallTest()
        {
            var operation = service_model.FindOperation("ProvisionIpamPoolCidr");

            var request = InstantiateClassGenerator.Execute<ProvisionIpamPoolCidrRequest>();
            var marshaller = new ProvisionIpamPoolCidrRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ProvisionIpamPoolCidrResponseUnmarshaller.Instance.Unmarshall(context)
                as ProvisionIpamPoolCidrResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ProvisionPublicIpv4PoolCidrMarshallTest()
        {
            var operation = service_model.FindOperation("ProvisionPublicIpv4PoolCidr");

            var request = InstantiateClassGenerator.Execute<ProvisionPublicIpv4PoolCidrRequest>();
            var marshaller = new ProvisionPublicIpv4PoolCidrRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ProvisionPublicIpv4PoolCidrResponseUnmarshaller.Instance.Unmarshall(context)
                as ProvisionPublicIpv4PoolCidrResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void PurchaseHostReservationMarshallTest()
        {
            var operation = service_model.FindOperation("PurchaseHostReservation");

            var request = InstantiateClassGenerator.Execute<PurchaseHostReservationRequest>();
            var marshaller = new PurchaseHostReservationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = PurchaseHostReservationResponseUnmarshaller.Instance.Unmarshall(context)
                as PurchaseHostReservationResponse;   
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
        public void RegisterInstanceEventNotificationAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("RegisterInstanceEventNotificationAttributes");

            var request = InstantiateClassGenerator.Execute<RegisterInstanceEventNotificationAttributesRequest>();
            var marshaller = new RegisterInstanceEventNotificationAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = RegisterInstanceEventNotificationAttributesResponseUnmarshaller.Instance.Unmarshall(context)
                as RegisterInstanceEventNotificationAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void RegisterTransitGatewayMulticastGroupMembersMarshallTest()
        {
            var operation = service_model.FindOperation("RegisterTransitGatewayMulticastGroupMembers");

            var request = InstantiateClassGenerator.Execute<RegisterTransitGatewayMulticastGroupMembersRequest>();
            var marshaller = new RegisterTransitGatewayMulticastGroupMembersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = RegisterTransitGatewayMulticastGroupMembersResponseUnmarshaller.Instance.Unmarshall(context)
                as RegisterTransitGatewayMulticastGroupMembersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void RegisterTransitGatewayMulticastGroupSourcesMarshallTest()
        {
            var operation = service_model.FindOperation("RegisterTransitGatewayMulticastGroupSources");

            var request = InstantiateClassGenerator.Execute<RegisterTransitGatewayMulticastGroupSourcesRequest>();
            var marshaller = new RegisterTransitGatewayMulticastGroupSourcesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = RegisterTransitGatewayMulticastGroupSourcesResponseUnmarshaller.Instance.Unmarshall(context)
                as RegisterTransitGatewayMulticastGroupSourcesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void RejectTransitGatewayMulticastDomainAssociationsMarshallTest()
        {
            var operation = service_model.FindOperation("RejectTransitGatewayMulticastDomainAssociations");

            var request = InstantiateClassGenerator.Execute<RejectTransitGatewayMulticastDomainAssociationsRequest>();
            var marshaller = new RejectTransitGatewayMulticastDomainAssociationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = RejectTransitGatewayMulticastDomainAssociationsResponseUnmarshaller.Instance.Unmarshall(context)
                as RejectTransitGatewayMulticastDomainAssociationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void RejectTransitGatewayPeeringAttachmentMarshallTest()
        {
            var operation = service_model.FindOperation("RejectTransitGatewayPeeringAttachment");

            var request = InstantiateClassGenerator.Execute<RejectTransitGatewayPeeringAttachmentRequest>();
            var marshaller = new RejectTransitGatewayPeeringAttachmentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = RejectTransitGatewayPeeringAttachmentResponseUnmarshaller.Instance.Unmarshall(context)
                as RejectTransitGatewayPeeringAttachmentResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void RejectTransitGatewayVpcAttachmentMarshallTest()
        {
            var operation = service_model.FindOperation("RejectTransitGatewayVpcAttachment");

            var request = InstantiateClassGenerator.Execute<RejectTransitGatewayVpcAttachmentRequest>();
            var marshaller = new RejectTransitGatewayVpcAttachmentRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = RejectTransitGatewayVpcAttachmentResponseUnmarshaller.Instance.Unmarshall(context)
                as RejectTransitGatewayVpcAttachmentResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void RejectVpcEndpointConnectionsMarshallTest()
        {
            var operation = service_model.FindOperation("RejectVpcEndpointConnections");

            var request = InstantiateClassGenerator.Execute<RejectVpcEndpointConnectionsRequest>();
            var marshaller = new RejectVpcEndpointConnectionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = RejectVpcEndpointConnectionsResponseUnmarshaller.Instance.Unmarshall(context)
                as RejectVpcEndpointConnectionsResponse;   
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
        public void ReleaseIpamPoolAllocationMarshallTest()
        {
            var operation = service_model.FindOperation("ReleaseIpamPoolAllocation");

            var request = InstantiateClassGenerator.Execute<ReleaseIpamPoolAllocationRequest>();
            var marshaller = new ReleaseIpamPoolAllocationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ReleaseIpamPoolAllocationResponseUnmarshaller.Instance.Unmarshall(context)
                as ReleaseIpamPoolAllocationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ReplaceIamInstanceProfileAssociationMarshallTest()
        {
            var operation = service_model.FindOperation("ReplaceIamInstanceProfileAssociation");

            var request = InstantiateClassGenerator.Execute<ReplaceIamInstanceProfileAssociationRequest>();
            var marshaller = new ReplaceIamInstanceProfileAssociationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ReplaceIamInstanceProfileAssociationResponseUnmarshaller.Instance.Unmarshall(context)
                as ReplaceIamInstanceProfileAssociationResponse;   
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
        public void ReplaceTransitGatewayRouteMarshallTest()
        {
            var operation = service_model.FindOperation("ReplaceTransitGatewayRoute");

            var request = InstantiateClassGenerator.Execute<ReplaceTransitGatewayRouteRequest>();
            var marshaller = new ReplaceTransitGatewayRouteRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ReplaceTransitGatewayRouteResponseUnmarshaller.Instance.Unmarshall(context)
                as ReplaceTransitGatewayRouteResponse;   
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
        public void ResetAddressAttributeMarshallTest()
        {
            var operation = service_model.FindOperation("ResetAddressAttribute");

            var request = InstantiateClassGenerator.Execute<ResetAddressAttributeRequest>();
            var marshaller = new ResetAddressAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ResetAddressAttributeResponseUnmarshaller.Instance.Unmarshall(context)
                as ResetAddressAttributeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ResetEbsDefaultKmsKeyIdMarshallTest()
        {
            var operation = service_model.FindOperation("ResetEbsDefaultKmsKeyId");

            var request = InstantiateClassGenerator.Execute<ResetEbsDefaultKmsKeyIdRequest>();
            var marshaller = new ResetEbsDefaultKmsKeyIdRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ResetEbsDefaultKmsKeyIdResponseUnmarshaller.Instance.Unmarshall(context)
                as ResetEbsDefaultKmsKeyIdResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void ResetFpgaImageAttributeMarshallTest()
        {
            var operation = service_model.FindOperation("ResetFpgaImageAttribute");

            var request = InstantiateClassGenerator.Execute<ResetFpgaImageAttributeRequest>();
            var marshaller = new ResetFpgaImageAttributeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = ResetFpgaImageAttributeResponseUnmarshaller.Instance.Unmarshall(context)
                as ResetFpgaImageAttributeResponse;   
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
        public void RestoreImageFromRecycleBinMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreImageFromRecycleBin");

            var request = InstantiateClassGenerator.Execute<RestoreImageFromRecycleBinRequest>();
            var marshaller = new RestoreImageFromRecycleBinRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = RestoreImageFromRecycleBinResponseUnmarshaller.Instance.Unmarshall(context)
                as RestoreImageFromRecycleBinResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void RestoreManagedPrefixListVersionMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreManagedPrefixListVersion");

            var request = InstantiateClassGenerator.Execute<RestoreManagedPrefixListVersionRequest>();
            var marshaller = new RestoreManagedPrefixListVersionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = RestoreManagedPrefixListVersionResponseUnmarshaller.Instance.Unmarshall(context)
                as RestoreManagedPrefixListVersionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void RestoreSnapshotFromRecycleBinMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreSnapshotFromRecycleBin");

            var request = InstantiateClassGenerator.Execute<RestoreSnapshotFromRecycleBinRequest>();
            var marshaller = new RestoreSnapshotFromRecycleBinRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = RestoreSnapshotFromRecycleBinResponseUnmarshaller.Instance.Unmarshall(context)
                as RestoreSnapshotFromRecycleBinResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void RestoreSnapshotTierMarshallTest()
        {
            var operation = service_model.FindOperation("RestoreSnapshotTier");

            var request = InstantiateClassGenerator.Execute<RestoreSnapshotTierRequest>();
            var marshaller = new RestoreSnapshotTierRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = RestoreSnapshotTierResponseUnmarshaller.Instance.Unmarshall(context)
                as RestoreSnapshotTierResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void RevokeClientVpnIngressMarshallTest()
        {
            var operation = service_model.FindOperation("RevokeClientVpnIngress");

            var request = InstantiateClassGenerator.Execute<RevokeClientVpnIngressRequest>();
            var marshaller = new RevokeClientVpnIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = RevokeClientVpnIngressResponseUnmarshaller.Instance.Unmarshall(context)
                as RevokeClientVpnIngressResponse;   
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


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = RevokeSecurityGroupEgressResponseUnmarshaller.Instance.Unmarshall(context)
                as RevokeSecurityGroupEgressResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = RevokeSecurityGroupIngressResponseUnmarshaller.Instance.Unmarshall(context)
                as RevokeSecurityGroupIngressResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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
        public void SearchLocalGatewayRoutesMarshallTest()
        {
            var operation = service_model.FindOperation("SearchLocalGatewayRoutes");

            var request = InstantiateClassGenerator.Execute<SearchLocalGatewayRoutesRequest>();
            var marshaller = new SearchLocalGatewayRoutesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = SearchLocalGatewayRoutesResponseUnmarshaller.Instance.Unmarshall(context)
                as SearchLocalGatewayRoutesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void SearchTransitGatewayMulticastGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("SearchTransitGatewayMulticastGroups");

            var request = InstantiateClassGenerator.Execute<SearchTransitGatewayMulticastGroupsRequest>();
            var marshaller = new SearchTransitGatewayMulticastGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = SearchTransitGatewayMulticastGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as SearchTransitGatewayMulticastGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void SearchTransitGatewayRoutesMarshallTest()
        {
            var operation = service_model.FindOperation("SearchTransitGatewayRoutes");

            var request = InstantiateClassGenerator.Execute<SearchTransitGatewayRoutesRequest>();
            var marshaller = new SearchTransitGatewayRoutesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = SearchTransitGatewayRoutesResponseUnmarshaller.Instance.Unmarshall(context)
                as SearchTransitGatewayRoutesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void SendDiagnosticInterruptMarshallTest()
        {
            var operation = service_model.FindOperation("SendDiagnosticInterrupt");

            var request = InstantiateClassGenerator.Execute<SendDiagnosticInterruptRequest>();
            var marshaller = new SendDiagnosticInterruptRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


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
        public void StartNetworkInsightsAccessScopeAnalysisMarshallTest()
        {
            var operation = service_model.FindOperation("StartNetworkInsightsAccessScopeAnalysis");

            var request = InstantiateClassGenerator.Execute<StartNetworkInsightsAccessScopeAnalysisRequest>();
            var marshaller = new StartNetworkInsightsAccessScopeAnalysisRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = StartNetworkInsightsAccessScopeAnalysisResponseUnmarshaller.Instance.Unmarshall(context)
                as StartNetworkInsightsAccessScopeAnalysisResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void StartNetworkInsightsAnalysisMarshallTest()
        {
            var operation = service_model.FindOperation("StartNetworkInsightsAnalysis");

            var request = InstantiateClassGenerator.Execute<StartNetworkInsightsAnalysisRequest>();
            var marshaller = new StartNetworkInsightsAnalysisRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = StartNetworkInsightsAnalysisResponseUnmarshaller.Instance.Unmarshall(context)
                as StartNetworkInsightsAnalysisResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void StartVpcEndpointServicePrivateDnsVerificationMarshallTest()
        {
            var operation = service_model.FindOperation("StartVpcEndpointServicePrivateDnsVerification");

            var request = InstantiateClassGenerator.Execute<StartVpcEndpointServicePrivateDnsVerificationRequest>();
            var marshaller = new StartVpcEndpointServicePrivateDnsVerificationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = StartVpcEndpointServicePrivateDnsVerificationResponseUnmarshaller.Instance.Unmarshall(context)
                as StartVpcEndpointServicePrivateDnsVerificationResponse;   
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
        public void TerminateClientVpnConnectionsMarshallTest()
        {
            var operation = service_model.FindOperation("TerminateClientVpnConnections");

            var request = InstantiateClassGenerator.Execute<TerminateClientVpnConnectionsRequest>();
            var marshaller = new TerminateClientVpnConnectionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = TerminateClientVpnConnectionsResponseUnmarshaller.Instance.Unmarshall(context)
                as TerminateClientVpnConnectionsResponse;   
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
        public void UnassignIpv6AddressesMarshallTest()
        {
            var operation = service_model.FindOperation("UnassignIpv6Addresses");

            var request = InstantiateClassGenerator.Execute<UnassignIpv6AddressesRequest>();
            var marshaller = new UnassignIpv6AddressesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = UnassignIpv6AddressesResponseUnmarshaller.Instance.Unmarshall(context)
                as UnassignIpv6AddressesResponse;   
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
        public void UnassignPrivateNatGatewayAddressMarshallTest()
        {
            var operation = service_model.FindOperation("UnassignPrivateNatGatewayAddress");

            var request = InstantiateClassGenerator.Execute<UnassignPrivateNatGatewayAddressRequest>();
            var marshaller = new UnassignPrivateNatGatewayAddressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = UnassignPrivateNatGatewayAddressResponseUnmarshaller.Instance.Unmarshall(context)
                as UnassignPrivateNatGatewayAddressResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
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

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void UpdateSecurityGroupRuleDescriptionsEgressMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateSecurityGroupRuleDescriptionsEgress");

            var request = InstantiateClassGenerator.Execute<UpdateSecurityGroupRuleDescriptionsEgressRequest>();
            var marshaller = new UpdateSecurityGroupRuleDescriptionsEgressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = UpdateSecurityGroupRuleDescriptionsEgressResponseUnmarshaller.Instance.Unmarshall(context)
                as UpdateSecurityGroupRuleDescriptionsEgressResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void UpdateSecurityGroupRuleDescriptionsIngressMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateSecurityGroupRuleDescriptionsIngress");

            var request = InstantiateClassGenerator.Execute<UpdateSecurityGroupRuleDescriptionsIngressRequest>();
            var marshaller = new UpdateSecurityGroupRuleDescriptionsIngressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = UpdateSecurityGroupRuleDescriptionsIngressResponseUnmarshaller.Instance.Unmarshall(context)
                as UpdateSecurityGroupRuleDescriptionsIngressResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("EC2")]
        public void WithdrawByoipCidrMarshallTest()
        {
            var operation = service_model.FindOperation("WithdrawByoipCidr");

            var request = InstantiateClassGenerator.Execute<WithdrawByoipCidrRequest>();
            var marshaller = new WithdrawByoipCidrRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var response = WithdrawByoipCidrResponseUnmarshaller.Instance.Unmarshall(context)
                as WithdrawByoipCidrResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
    }
}