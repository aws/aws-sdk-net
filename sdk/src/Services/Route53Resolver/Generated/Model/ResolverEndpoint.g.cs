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

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// In the response to a <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_CreateResolverEndpoint.html">CreateResolverEndpoint</a>,
    /// <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_DeleteResolverEndpoint.html">DeleteResolverEndpoint</a>,
    /// <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_GetResolverEndpoint.html">GetResolverEndpoint</a>,
    /// Updates the name, or ResolverEndpointType for an endpoint, or <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_UpdateResolverEndpoint.html">UpdateResolverEndpoint</a>
    /// request, a complex type that contains settings for an existing inbound or outbound
    /// Resolver endpoint.
    /// </summary>
    public partial class ResolverEndpoint
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN (Amazon Resource Name) for the Resolver endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the endpoint was created, in Unix time format and Coordinated
        /// Universal Time (UTC).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 40)]
        public string CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime != null;

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request that created the Resolver endpoint. The
        /// <c>CreatorRequestId</c> allows failed requests to be retried without the risk of running
        /// the operation twice.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CreatorRequestId { get; set; }

        /// <summary>
        /// Checks to see if the CreatorRequestId property is set.
        /// </summary>
        internal bool IsSetCreatorRequestId() => this.CreatorRequestId != null;

        /// <summary>
        /// Gets and sets the property Direction. 
        /// <para>
        /// Indicates whether the Resolver endpoint allows inbound or outbound DNS queries:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INBOUND</c>: allows DNS queries to your VPC from your network
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OUTBOUND</c>: allows DNS queries from your VPC to your network
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INBOUND_DELEGATION</c>: Resolver delegates queries to Route 53 private hosted
        /// zones from your network.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResolverEndpointDirection Direction { get; set; }

        /// <summary>
        /// Checks to see if the Direction property is set.
        /// </summary>
        internal bool IsSetDirection() => this.Direction != null;

        /// <summary>
        /// Gets and sets the property Dns64Enabled. 
        /// <para>
        /// Indicates whether DNS64 is enabled for the inbound Resolver endpoint. When <c>true</c>,
        /// Route 53 Resolver synthesizes AAAA (IPv6) records for IPv4-only services by prepending
        /// the <c>64:ff9b::/96</c> prefix to the IPv4 address.
        /// </para>
        /// </summary>
        public bool? Dns64Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Dns64Enabled property is set.
        /// </summary>
        internal bool IsSetDns64Enabled() => this.Dns64Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property HostVPCId. 
        /// <para>
        /// The ID of the VPC that you want to create the Resolver endpoint in.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string HostVPCId { get; set; }

        /// <summary>
        /// Checks to see if the HostVPCId property is set.
        /// </summary>
        internal bool IsSetHostVPCId() => this.HostVPCId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the Resolver endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IpAddressCount. 
        /// <para>
        /// The number of IP addresses that the Resolver endpoint can use for DNS queries.
        /// </para>
        /// </summary>
        public int? IpAddressCount { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressCount property is set.
        /// </summary>
        internal bool IsSetIpAddressCount() => this.IpAddressCount.HasValue;

        /// <summary>
        /// Gets and sets the property Ipv6InternetAccessEnabled. 
        /// <para>
        /// Indicates whether IPv6 internet access is enabled for the outbound Resolver endpoint.
        /// When <c>true</c>, the endpoint elastic network interfaces (ENIs) can forward DNS queries
        /// to public IPv6 targets through an internet gateway.
        /// </para>
        /// </summary>
        public bool? Ipv6InternetAccessEnabled { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6InternetAccessEnabled property is set.
        /// </summary>
        internal bool IsSetIpv6InternetAccessEnabled() => this.Ipv6InternetAccessEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property ModificationTime. 
        /// <para>
        /// The date and time that the endpoint was last modified, in Unix time format and Coordinated
        /// Universal Time (UTC).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 40)]
        public string ModificationTime { get; set; }

        /// <summary>
        /// Checks to see if the ModificationTime property is set.
        /// </summary>
        internal bool IsSetModificationTime() => this.ModificationTime != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name that you assigned to the Resolver endpoint when you submitted a <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_CreateResolverEndpoint.html">CreateResolverEndpoint</a>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The ARN (Amazon Resource Name) for the Outpost.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string OutpostArn { get; set; }

        /// <summary>
        /// Checks to see if the OutpostArn property is set.
        /// </summary>
        internal bool IsSetOutpostArn() => this.OutpostArn != null;

        /// <summary>
        /// Gets and sets the property PreferredInstanceType. 
        /// <para>
        ///  The Amazon EC2 instance type. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string PreferredInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the PreferredInstanceType property is set.
        /// </summary>
        internal bool IsSetPreferredInstanceType() => this.PreferredInstanceType != null;

        /// <summary>
        /// Gets and sets the property Protocols. 
        /// <para>
        ///  Protocols used for the endpoint. DoH-FIPS is applicable for a default inbound endpoints
        /// only. 
        /// </para>
        ///  
        /// <para>
        /// For an inbound endpoint you can apply the protocols as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Do53 and DoH in combination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do53 and DoH-FIPS in combination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do53 alone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DoH alone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DoH-FIPS alone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// None, which is treated as Do53.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a delegation inbound endpoint you can use Do53 only.
        /// </para>
        ///  
        /// <para>
        /// For an outbound endpoint you can apply the protocols as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Do53 and DoH in combination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do53 alone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DoH alone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// None, which is treated as Do53.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<string> Protocols { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Protocols property is set.
        /// </summary>
        internal bool IsSetProtocols() => this.Protocols != null && (this.Protocols.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResolverEndpointType. 
        /// <para>
        ///  The Resolver endpoint IP address type. 
        /// </para>
        /// </summary>
        public ResolverEndpointType ResolverEndpointType { get; set; }

        /// <summary>
        /// Checks to see if the ResolverEndpointType property is set.
        /// </summary>
        internal bool IsSetResolverEndpointType() => this.ResolverEndpointType != null;

        /// <summary>
        /// Gets and sets the property RniEnhancedMetricsEnabled. 
        /// <para>
        /// Indicates whether RNI enhanced metrics are enabled for the Resolver endpoint. When
        /// enabled, one-minute granular metrics are published in CloudWatch for each RNI associated
        /// with this endpoint. When disabled, these metrics are not published.
        /// </para>
        /// </summary>
        public bool? RniEnhancedMetricsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the RniEnhancedMetricsEnabled property is set.
        /// </summary>
        internal bool IsSetRniEnhancedMetricsEnabled() => this.RniEnhancedMetricsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The ID of one or more security groups that control access to this VPC. The security
        /// group must include one or more inbound rules (for inbound endpoints) or outbound rules
        /// (for outbound endpoints). Inbound and outbound rules must allow TCP and UDP access.
        /// For inbound access, open port 53. For outbound access, open the port that you're using
        /// for DNS queries on your network.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// A code that specifies the current status of the Resolver endpoint. Valid values include
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c>: Resolver is creating and configuring one or more Amazon VPC network
        /// interfaces for this endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OPERATIONAL</c>: The Amazon VPC network interfaces for this endpoint are correctly
        /// configured and able to pass inbound or outbound DNS queries between your network and
        /// Resolver.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c>: Resolver is associating or disassociating one or more network interfaces
        /// with this endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AUTO_RECOVERING</c>: Resolver is trying to recover one or more of the network
        /// interfaces that are associated with this endpoint. During the recovery process, the
        /// endpoint functions with limited capacity because of the limit on the number of DNS
        /// queries per IP address (per network interface). For the current limit, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DNSLimitations.html#limits-api-entities-resolver">Limits
        /// on Route 53 Resolver</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTION_NEEDED</c>: This endpoint is unhealthy, and Resolver can't automatically
        /// recover it. To resolve the problem, we recommend that you check each IP address that
        /// you associated with the endpoint. For each IP address that isn't available, add another
        /// IP address and then delete the IP address that isn't available. (An endpoint must
        /// always include at least two IP addresses.) A status of <c>ACTION_NEEDED</c> can have
        /// a variety of causes. Here are two common causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// One or more of the network interfaces that are associated with the endpoint were deleted
        /// using Amazon VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The network interface couldn't be created for some reason that's outside the control
        /// of Resolver.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>DELETING</c>: Resolver is deleting this endpoint and the associated network interfaces.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResolverEndpointStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A detailed description of the status of the Resolver endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property TargetNameServerMetricsEnabled. 
        /// <para>
        /// Indicates whether target name server metrics are enabled for the outbound Resolver
        /// endpoint. When enabled, one-minute granular metrics are published in CloudWatch for
        /// each target name server associated with this endpoint. When disabled, these metrics
        /// are not published. This feature is not supported for inbound Resolver endpoint.
        /// </para>
        /// </summary>
        public bool? TargetNameServerMetricsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the TargetNameServerMetricsEnabled property is set.
        /// </summary>
        internal bool IsSetTargetNameServerMetricsEnabled() => this.TargetNameServerMetricsEnabled.HasValue;
    }
}
