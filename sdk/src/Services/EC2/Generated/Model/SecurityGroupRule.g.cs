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
    /// Describes a security group rule.
    /// </summary>
    public partial class SecurityGroupRule
    {
        /// <summary>
        /// Gets and sets the property CidrIpv4. 
        /// <para>
        /// The IPv4 CIDR range.
        /// </para>
        /// </summary>
        public string CidrIpv4 { get; set; }

        /// <summary>
        /// Checks to see if the CidrIpv4 property is set.
        /// </summary>
        internal bool IsSetCidrIpv4() => this.CidrIpv4 != null;

        /// <summary>
        /// Gets and sets the property CidrIpv6. 
        /// <para>
        /// The IPv6 CIDR range.
        /// </para>
        /// </summary>
        public string CidrIpv6 { get; set; }

        /// <summary>
        /// Checks to see if the CidrIpv6 property is set.
        /// </summary>
        internal bool IsSetCidrIpv6() => this.CidrIpv6 != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The security group rule description.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FromPort. 
        /// <para>
        /// If the protocol is TCP or UDP, this is the start of the port range. If the protocol
        /// is ICMP or ICMPv6, this is the ICMP type or -1 (all ICMP types).
        /// </para>
        /// </summary>
        public int? FromPort { get; set; }

        /// <summary>
        /// Checks to see if the FromPort property is set.
        /// </summary>
        internal bool IsSetFromPort() => this.FromPort.HasValue;

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The ID of the security group.
        /// </para>
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property GroupOwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the security group. 
        /// </para>
        /// </summary>
        public string GroupOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the GroupOwnerId property is set.
        /// </summary>
        internal bool IsSetGroupOwnerId() => this.GroupOwnerId != null;

        /// <summary>
        /// Gets and sets the property IpProtocol. 
        /// <para>
        /// The IP protocol name (<c>tcp</c>, <c>udp</c>, <c>icmp</c>, <c>icmpv6</c>) or number
        /// (see <a href="http://www.iana.org/assignments/protocol-numbers/protocol-numbers.xhtml">Protocol
        /// Numbers</a>). 
        /// </para>
        ///  
        /// <para>
        /// Use <c>-1</c> to specify all protocols.
        /// </para>
        /// </summary>
        public string IpProtocol { get; set; }

        /// <summary>
        /// Checks to see if the IpProtocol property is set.
        /// </summary>
        internal bool IsSetIpProtocol() => this.IpProtocol != null;

        /// <summary>
        /// Gets and sets the property IsEgress. 
        /// <para>
        /// Indicates whether the security group rule is an outbound rule.
        /// </para>
        /// </summary>
        public bool? IsEgress { get; set; }

        /// <summary>
        /// Checks to see if the IsEgress property is set.
        /// </summary>
        internal bool IsSetIsEgress() => this.IsEgress.HasValue;

        /// <summary>
        /// Gets and sets the property PrefixListId. 
        /// <para>
        /// The ID of the prefix list.
        /// </para>
        /// </summary>
        public string PrefixListId { get; set; }

        /// <summary>
        /// Checks to see if the PrefixListId property is set.
        /// </summary>
        internal bool IsSetPrefixListId() => this.PrefixListId != null;

        /// <summary>
        /// Gets and sets the property ReferencedGroupInfo. 
        /// <para>
        /// Describes the security group that is referenced in the rule.
        /// </para>
        /// </summary>
        public ReferencedSecurityGroup ReferencedGroupInfo { get; set; }

        /// <summary>
        /// Checks to see if the ReferencedGroupInfo property is set.
        /// </summary>
        internal bool IsSetReferencedGroupInfo() => this.ReferencedGroupInfo != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupRuleArn. 
        /// <para>
        /// The ARN of the security group rule.
        /// </para>
        /// </summary>
        public string SecurityGroupRuleArn { get; set; }

        /// <summary>
        /// Checks to see if the SecurityGroupRuleArn property is set.
        /// </summary>
        internal bool IsSetSecurityGroupRuleArn() => this.SecurityGroupRuleArn != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupRuleId. 
        /// <para>
        /// The ID of the security group rule.
        /// </para>
        /// </summary>
        public string SecurityGroupRuleId { get; set; }

        /// <summary>
        /// Checks to see if the SecurityGroupRuleId property is set.
        /// </summary>
        internal bool IsSetSecurityGroupRuleId() => this.SecurityGroupRuleId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags applied to the security group rule.
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
        /// Gets and sets the property ToPort. 
        /// <para>
        /// If the protocol is TCP or UDP, this is the end of the port range. If the protocol
        /// is ICMP or ICMPv6, this is the ICMP code or -1 (all ICMP codes). If the start port
        /// is -1 (all ICMP types), then the end port must be -1 (all ICMP codes).
        /// </para>
        /// </summary>
        public int? ToPort { get; set; }

        /// <summary>
        /// Checks to see if the ToPort property is set.
        /// </summary>
        internal bool IsSetToPort() => this.ToPort.HasValue;
    }
}
