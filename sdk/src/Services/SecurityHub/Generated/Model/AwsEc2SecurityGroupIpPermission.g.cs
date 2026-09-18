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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// An IP permission for an EC2 security group.
    /// </summary>
    public partial class AwsEc2SecurityGroupIpPermission
    {
        /// <summary>
        /// Gets and sets the property FromPort. 
        /// <para>
        /// The start of the port range for the TCP and UDP protocols, or an ICMP/ICMPv6 type
        /// number.
        /// </para>
        ///  
        /// <para>
        /// A value of -1 indicates all ICMP/ICMPv6 types. If you specify all ICMP/ICMPv6 types,
        /// you must specify all codes. 
        /// </para>
        /// </summary>
        public int? FromPort { get; set; }

        /// <summary>
        /// Checks to see if the FromPort property is set.
        /// </summary>
        internal bool IsSetFromPort() => this.FromPort.HasValue;

        /// <summary>
        /// Gets and sets the property IpProtocol. 
        /// <para>
        /// The IP protocol name (<c>tcp</c>, <c>udp</c>, <c>icmp</c>, <c>icmpv6</c>) or number.
        /// </para>
        ///  
        /// <para>
        /// [VPC only] Use <c>-1</c> to specify all protocols.
        /// </para>
        ///  
        /// <para>
        /// When authorizing security group rules, specifying <c>-1</c> or a protocol number other
        /// than <c>tcp</c>, <c>udp</c>, <c>icmp</c>, or <c>icmpv6</c> allows traffic on all ports,
        /// regardless of any port range you specify.
        /// </para>
        ///  
        /// <para>
        /// For <c>tcp</c>, <c>udp</c>, and <c>icmp</c>, you must specify a port range.
        /// </para>
        ///  
        /// <para>
        /// For <c>icmpv6</c>, the port range is optional. If you omit the port range, traffic
        /// for all types and codes is allowed. 
        /// </para>
        /// </summary>
        public string IpProtocol { get; set; }

        /// <summary>
        /// Checks to see if the IpProtocol property is set.
        /// </summary>
        internal bool IsSetIpProtocol() => this.IpProtocol != null;

        /// <summary>
        /// Gets and sets the property IpRanges. 
        /// <para>
        /// The IPv4 ranges.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEc2SecurityGroupIpRange> IpRanges { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEc2SecurityGroupIpRange>() : null;

        /// <summary>
        /// Checks to see if the IpRanges property is set.
        /// </summary>
        internal bool IsSetIpRanges() => this.IpRanges != null && (this.IpRanges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Ipv6Ranges. 
        /// <para>
        /// The IPv6 ranges.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEc2SecurityGroupIpv6Range> Ipv6Ranges { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEc2SecurityGroupIpv6Range>() : null;

        /// <summary>
        /// Checks to see if the Ipv6Ranges property is set.
        /// </summary>
        internal bool IsSetIpv6Ranges() => this.Ipv6Ranges != null && (this.Ipv6Ranges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PrefixListIds. 
        /// <para>
        /// [VPC only] The prefix list IDs for an Amazon Web Services service. With outbound rules,
        /// this is the Amazon Web Services service to access through a VPC endpoint from instances
        /// associated with the security group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEc2SecurityGroupPrefixListId> PrefixListIds { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEc2SecurityGroupPrefixListId>() : null;

        /// <summary>
        /// Checks to see if the PrefixListIds property is set.
        /// </summary>
        internal bool IsSetPrefixListIds() => this.PrefixListIds != null && (this.PrefixListIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ToPort. 
        /// <para>
        /// The end of the port range for the TCP and UDP protocols, or an ICMP/ICMPv6 code.
        /// </para>
        ///  
        /// <para>
        /// A value of <c>-1</c> indicates all ICMP/ICMPv6 codes. If you specify all ICMP/ICMPv6
        /// types, you must specify all codes.
        /// </para>
        /// </summary>
        public int? ToPort { get; set; }

        /// <summary>
        /// Checks to see if the ToPort property is set.
        /// </summary>
        internal bool IsSetToPort() => this.ToPort.HasValue;

        /// <summary>
        /// Gets and sets the property UserIdGroupPairs. 
        /// <para>
        /// The security group and Amazon Web Services account ID pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEc2SecurityGroupUserIdGroupPair> UserIdGroupPairs { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEc2SecurityGroupUserIdGroupPair>() : null;

        /// <summary>
        /// Checks to see if the UserIdGroupPairs property is set.
        /// </summary>
        internal bool IsSetUserIdGroupPairs() => this.UserIdGroupPairs != null && (this.UserIdGroupPairs.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
