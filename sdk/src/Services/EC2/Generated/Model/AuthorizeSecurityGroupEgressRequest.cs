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
    /// Container for the parameters to the AuthorizeSecurityGroupEgress operation.
    /// Adds the specified outbound (egress) rules to a security group.
    /// 
    ///  
    /// <para>
    /// An outbound rule permits instances to send traffic to the specified IPv4 or IPv6 address
    /// ranges, the IP address ranges specified by a prefix list, or the instances that are
    /// associated with a source security group. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/security-group-rules.html">Security
    /// group rules</a>.
    /// </para>
    ///  
    /// <para>
    /// You must specify exactly one of the following destinations: an IPv4 or IPv6 address
    /// range, a prefix list, or a security group. You must specify a protocol for each rule
    /// (for example, TCP). If the protocol is TCP or UDP, you must also specify a port or
    /// port range. If the protocol is ICMP or ICMPv6, you must also specify the ICMP type
    /// and code.
    /// </para>
    ///  
    /// <para>
    /// Rule changes are propagated to instances associated with the security group as quickly
    /// as possible. However, a small delay might occur.
    /// </para>
    ///  
    /// <para>
    /// For examples of rules that you can add to security groups for specific access scenarios,
    /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/security-group-rules-reference.html">Security
    /// group rules for different use cases</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For information about security group quotas, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/amazon-vpc-limits.html">Amazon
    /// VPC quotas</a> in the <i>Amazon VPC User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AuthorizeSecurityGroupEgressRequest : AmazonEC2Request
    {
        private string _groupId;
        private List<IpPermission> _ipPermissions = AWSConfigs.InitializeCollections ? new List<IpPermission>() : null;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The ID of the security group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property IpPermissions. 
        /// <para>
        /// The permissions for the security group rules.
        /// </para>
        /// </summary>
        public List<IpPermission> IpPermissions
        {
            get { return this._ipPermissions; }
            set { this._ipPermissions = value; }
        }

        // Check to see if IpPermissions property is set
        internal bool IsSetIpPermissions()
        {
            return this._ipPermissions != null && (this._ipPermissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags applied to the security group rule.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}