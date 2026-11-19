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
    /// Describes a VPC endpoint.
    /// </summary>
    public partial class VpcEndpoint
    {
        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The date and time that the endpoint was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimestamp property is set.
        /// </summary>
        internal bool IsSetCreationTimestamp() => this.CreationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property DnsEntries. 
        /// <para>
        /// (Interface endpoint) The DNS entries for the endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DnsEntry> DnsEntries { get; set; } = AWSConfigs.InitializeCollections ? new List<DnsEntry>() : null;

        /// <summary>
        /// Checks to see if the DnsEntries property is set.
        /// </summary>
        internal bool IsSetDnsEntries() => this.DnsEntries != null && (this.DnsEntries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DnsOptions. 
        /// <para>
        /// The DNS options for the endpoint.
        /// </para>
        /// </summary>
        public DnsOptions DnsOptions { get; set; }

        /// <summary>
        /// Checks to see if the DnsOptions property is set.
        /// </summary>
        internal bool IsSetDnsOptions() => this.DnsOptions != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// Reason for the failure.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// (Interface, Resource, ServiceNetwork, and Tunnel endpoints only) Information about
        /// the security groups that are associated with the network interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SecurityGroupIdentifier> Groups { get; set; } = AWSConfigs.InitializeCollections ? new List<SecurityGroupIdentifier>() : null;

        /// <summary>
        /// Checks to see if the Groups property is set.
        /// </summary>
        internal bool IsSetGroups() => this.Groups != null && (this.Groups.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property Ipv4Prefixes. 
        /// <para>
        /// Array of IPv4 prefixes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SubnetIpPrefixes> Ipv4Prefixes { get; set; } = AWSConfigs.InitializeCollections ? new List<SubnetIpPrefixes>() : null;

        /// <summary>
        /// Checks to see if the Ipv4Prefixes property is set.
        /// </summary>
        internal bool IsSetIpv4Prefixes() => this.Ipv4Prefixes != null && (this.Ipv4Prefixes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Ipv6Prefixes. 
        /// <para>
        /// Array of IPv6 prefixes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SubnetIpPrefixes> Ipv6Prefixes { get; set; } = AWSConfigs.InitializeCollections ? new List<SubnetIpPrefixes>() : null;

        /// <summary>
        /// Checks to see if the Ipv6Prefixes property is set.
        /// </summary>
        internal bool IsSetIpv6Prefixes() => this.Ipv6Prefixes != null && (this.Ipv6Prefixes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastError. 
        /// <para>
        /// The last error that occurred for endpoint.
        /// </para>
        /// </summary>
        public LastError LastError { get; set; }

        /// <summary>
        /// Checks to see if the LastError property is set.
        /// </summary>
        internal bool IsSetLastError() => this.LastError != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceIds. 
        /// <para>
        /// (Interface, Gateway Load Balancer endpoints, Resource, ServiceNetwork, and Tunnel
        /// endpoints only) The network interfaces for the endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NetworkInterfaceIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NetworkInterfaceIds property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceIds() => this.NetworkInterfaceIds != null && (this.NetworkInterfaceIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the endpoint.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property PayerResponsibilities. 
        /// <para>
        /// The payer responsibility settings for the endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PayerResponsibilityEntry> PayerResponsibilities { get; set; } = AWSConfigs.InitializeCollections ? new List<PayerResponsibilityEntry>() : null;

        /// <summary>
        /// Checks to see if the PayerResponsibilities property is set.
        /// </summary>
        internal bool IsSetPayerResponsibilities() => this.PayerResponsibilities != null && (this.PayerResponsibilities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// The policy document associated with the endpoint, if applicable.
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
        /// (Interface endpoint) Indicates whether the VPC is associated with a private hosted
        /// zone.
        /// </para>
        /// </summary>
        public bool? PrivateDnsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the PrivateDnsEnabled property is set.
        /// </summary>
        internal bool IsSetPrivateDnsEnabled() => this.PrivateDnsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property RequesterManaged. 
        /// <para>
        /// Indicates whether the endpoint is being managed by its service.
        /// </para>
        /// </summary>
        public bool? RequesterManaged { get; set; }

        /// <summary>
        /// Checks to see if the RequesterManaged property is set.
        /// </summary>
        internal bool IsSetRequesterManaged() => this.RequesterManaged.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource configuration.
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
        /// (Gateway endpoint) The IDs of the route tables associated with the endpoint.
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
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service to which the endpoint is associated.
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
        /// The Amazon Resource Name (ARN) of the service network.
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
        /// The Region where the service is hosted.
        /// </para>
        /// </summary>
        public string ServiceRegion { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRegion property is set.
        /// </summary>
        internal bool IsSetServiceRegion() => this.ServiceRegion != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the endpoint.
        /// </para>
        /// </summary>
        public State State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// (Interface, Gateway Load Balancer endpoints, Resource, ServiceNetwork, and Tunnel
        /// endpoints only) The subnets for the endpoint.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The ID of the endpoint.
        /// </para>
        /// </summary>
        public string VpcEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointId property is set.
        /// </summary>
        internal bool IsSetVpcEndpointId() => this.VpcEndpointId != null;

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
        /// </summary>
        public VpcEndpointType VpcEndpointType { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointType property is set.
        /// </summary>
        internal bool IsSetVpcEndpointType() => this.VpcEndpointType != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC to which the endpoint is associated.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
