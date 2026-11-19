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
    /// A security group rule removed with <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RevokeSecurityGroupEgress.html">RevokeSecurityGroupEgress</a>
    /// or <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RevokeSecurityGroupIngress.html">RevokeSecurityGroupIngress</a>.
    /// </summary>
    public partial class RevokedSecurityGroupRule
    {
        /// <summary>
        /// Gets and sets the property CidrIpv4. 
        /// <para>
        /// The IPv4 CIDR of the traffic source.
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
        /// The IPv6 CIDR of the traffic source.
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
        /// A description of the revoked security group rule.
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
        /// The 'from' port number of the security group rule.
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
        /// A security group ID.
        /// </para>
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property IpProtocol. 
        /// <para>
        /// The security group rule's protocol.
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
        /// Defines if a security group rule is an outbound rule.
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
        /// The ID of a prefix list that's the traffic source.
        /// </para>
        /// </summary>
        public string PrefixListId { get; set; }

        /// <summary>
        /// Checks to see if the PrefixListId property is set.
        /// </summary>
        internal bool IsSetPrefixListId() => this.PrefixListId != null;

        /// <summary>
        /// Gets and sets the property ReferencedGroupId. 
        /// <para>
        /// The ID of a referenced security group.
        /// </para>
        /// </summary>
        public string ReferencedGroupId { get; set; }

        /// <summary>
        /// Checks to see if the ReferencedGroupId property is set.
        /// </summary>
        internal bool IsSetReferencedGroupId() => this.ReferencedGroupId != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupRuleId. 
        /// <para>
        /// A security group rule ID.
        /// </para>
        /// </summary>
        public string SecurityGroupRuleId { get; set; }

        /// <summary>
        /// Checks to see if the SecurityGroupRuleId property is set.
        /// </summary>
        internal bool IsSetSecurityGroupRuleId() => this.SecurityGroupRuleId != null;

        /// <summary>
        /// Gets and sets the property ToPort. 
        /// <para>
        /// The 'to' port number of the security group rule.
        /// </para>
        /// </summary>
        public int? ToPort { get; set; }

        /// <summary>
        /// Checks to see if the ToPort property is set.
        /// </summary>
        internal bool IsSetToPort() => this.ToPort.HasValue;
    }
}
