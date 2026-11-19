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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVpcEndpoint operation. Creates a VPC endpoint.
    /// A VPC endpoint provides a private connection between the specified VPC and the specified
    /// endpoint service. You can use an endpoint service provided by Amazon Web Services,
    /// an Amazon Web Services Marketplace Partner, or another Amazon Web Services account.
    /// For more information, see the <a href="https://docs.aws.amazon.com/vpc/latest/privatelink/">Amazon
    /// Web Services PrivateLink User Guide</a>.
    /// </summary>
    public partial class CreateVpcEndpointRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">How
        /// to ensure idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DnsOptions. 
        /// <para>
        /// The DNS options for the endpoint.
        /// </para>
        /// </summary>
        public DnsOptionsSpecification DnsOptions { get; set; }

        /// <summary>
        /// Checks to see if the DnsOptions property is set.
        /// </summary>
        internal bool IsSetDnsOptions() => this.DnsOptions != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type for the endpoint.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// (Interface and gateway endpoints) A policy to attach to the endpoint that controls
        /// access to the service. The policy must be in valid JSON format. If this parameter
        /// is not specified, we attach a default policy that allows full access to the service.
        /// </para>
        /// </summary>
        public string PolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the PolicyDocument property is set.
        /// </summary>
        internal bool IsSetPolicyDocument() => this.PolicyDocument != null;

        /// <summary>
        /// Gets and sets the property PrivateDnsEnabled. 
        /// <para>
        /// (Interface endpoint) Indicates whether to associate a private hosted zone with the
        /// specified VPC. The private hosted zone contains a record set for the default public
        /// DNS name for the service for the Region (for example, <c>kinesis.us-east-1.amazonaws.com</c>),
        /// which resolves to the private IP addresses of the endpoint network interfaces in the
        /// VPC. This enables you to make requests to the default public DNS name for the service
        /// instead of the public DNS names that are automatically generated by the VPC endpoint
        /// service.
        /// </para>
        ///  
        /// <para>
        /// To use a private hosted zone, you must set the following VPC attributes to <c>true</c>:
        /// <c>enableDnsHostnames</c> and <c>enableDnsSupport</c>. Use <a>ModifyVpcAttribute</a>
        /// to set the VPC attributes.
        /// </para>
        /// </summary>
        public bool? PrivateDnsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the PrivateDnsEnabled property is set.
        /// </summary>
        internal bool IsSetPrivateDnsEnabled() => this.PrivateDnsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceConfigurationArn. 
        /// <para>
        /// (Resource and Tunnel endpoints only) The Amazon Resource Name (ARN) of a resource
        /// configuration associated with the VPC endpoint. The type of resource configuration
        /// depends on the endpoint type:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For a Resource endpoint, you can specify a resource configuration that is of type
        /// <c>SINGLE</c>, <c>GROUP</c>, or <c>ARN</c>. To reach a resource that belongs to a
        /// group, specify the parent <c>GROUP</c> resource configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For a Tunnel endpoint, you can specify a resource configuration that is of type <c>CIDR</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about the types of resource configurations, see <a href="https://docs.aws.amazon.com/vpc/latest/privatelink/resource-configuration.html">Types
        /// of resource configurations</a> in the <i>Amazon Web Services PrivateLink User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This request fails if a VPC endpoint owned by a different Amazon Web Services account
        /// already exists on a resource gateway that is enabled for <c>ResourceGatewayCharges</c>
        /// payer responsibility.
        /// </para>
        /// </summary>
        public string ResourceConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfigurationArn property is set.
        /// </summary>
        internal bool IsSetResourceConfigurationArn() => this.ResourceConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property RouteTableIds. 
        /// <para>
        /// (Gateway endpoint) The route table IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RouteTableIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RouteTableIds property is set.
        /// </summary>
        internal bool IsSetRouteTableIds() => this.RouteTableIds != null && (this.RouteTableIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// (Interface, Resource, ServiceNetwork, and Tunnel endpoints only) The IDs of the security
        /// groups to associate with the endpoint network interfaces. If this parameter is not
        /// specified, we use the default security group for the VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the endpoint service.
        /// </para>
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property ServiceNetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a service network that will be associated with the
        /// VPC endpoint of type service-network.
        /// </para>
        /// </summary>
        public string ServiceNetworkArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNetworkArn property is set.
        /// </summary>
        internal bool IsSetServiceNetworkArn() => this.ServiceNetworkArn != null;

        /// <summary>
        /// Gets and sets the property ServiceRegion. 
        /// <para>
        /// The Region where the service is hosted. The default is the current Region.
        /// </para>
        /// </summary>
        public string ServiceRegion { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRegion property is set.
        /// </summary>
        internal bool IsSetServiceRegion() => this.ServiceRegion != null;

        /// <summary>
        /// Gets and sets the property SubnetConfigurations. 
        /// <para>
        /// The subnet configurations for the endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SubnetConfiguration> SubnetConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<SubnetConfiguration>() : null;

        /// <summary>
        /// Checks to see if the SubnetConfigurations property is set.
        /// </summary>
        internal bool IsSetSubnetConfigurations() => this.SubnetConfigurations != null && (this.SubnetConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// (Interface, Gateway Load Balancer endpoints, Resource, ServiceNetwork, and Tunnel
        /// endpoints only) The IDs of the subnets in which to create endpoint network interfaces.
        /// For a Gateway Load Balancer endpoint, you can specify only one subnet. For a <c>Tunnel</c>
        /// endpoint, the subnets must be in the Availability Zones of the resource gateway associated
        /// with the shared resource configuration. An endpoint network interface is created only
        /// in an Availability Zone that the resource gateway is also in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubnetIds property is set.
        /// </summary>
        internal bool IsSetSubnetIds() => this.SubnetIds != null && (this.SubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to associate with the endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcEndpointType. 
        /// <para>
        /// The type of endpoint.
        /// </para>
        ///  
        /// <para>
        /// For more information about the types of VPC endpoints, see <a href="https://docs.aws.amazon.com/vpc/latest/privatelink/concepts.html#concepts-vpc-endpoints">VPC
        /// endpoints</a> in the <i>Amazon Web Services PrivateLink User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: Gateway
        /// </para>
        /// </summary>
        public VpcEndpointType VpcEndpointType { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointType property is set.
        /// </summary>
        internal bool IsSetVpcEndpointType() => this.VpcEndpointType != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
