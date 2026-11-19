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
    /// Describes a stale rule in a security group.
    /// </summary>
    public partial class StaleIpPermission
    {
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
        /// Gets and sets the property IpProtocol. 
        /// <para>
        /// The IP protocol name (<c>tcp</c>, <c>udp</c>, <c>icmp</c>, <c>icmpv6</c>) or number
        /// (see <a href="http://www.iana.org/assignments/protocol-numbers/protocol-numbers.xhtml">Protocol
        /// Numbers)</a>.
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
        /// The IP ranges. Not applicable for stale security group rules.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IpRanges { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IpRanges property is set.
        /// </summary>
        internal bool IsSetIpRanges() => this.IpRanges != null && (this.IpRanges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PrefixListIds. 
        /// <para>
        /// The prefix list IDs. Not applicable for stale security group rules.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PrefixListIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PrefixListIds property is set.
        /// </summary>
        internal bool IsSetPrefixListIds() => this.PrefixListIds != null && (this.PrefixListIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ToPort. 
        /// <para>
        /// If the protocol is TCP or UDP, this is the end of the port range. If the protocol
        /// is ICMP or ICMPv6, this is the ICMP code or -1 (all ICMP codes).
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
        /// The security group pairs. Returns the ID of the referenced security group and VPC,
        /// and the ID and status of the VPC peering connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UserIdGroupPair> UserIdGroupPairs { get; set; } = AWSConfigs.InitializeCollections ? new List<UserIdGroupPair>() : null;

        /// <summary>
        /// Checks to see if the UserIdGroupPairs property is set.
        /// </summary>
        internal bool IsSetUserIdGroupPairs() => this.UserIdGroupPairs != null && (this.UserIdGroupPairs.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
