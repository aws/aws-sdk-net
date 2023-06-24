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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the AuthorizeSecurityGroupIngress operation.
    /// Adds the specified inbound (ingress) rules to a security group.
    /// 
    ///  
    /// <para>
    /// An inbound rule permits instances to receive traffic from the specified IPv4 or IPv6
    /// CIDR address range, or from the instances that are associated with the specified destination
    /// security groups. When specifying an inbound rule for your security group in a VPC,
    /// the <code>IpPermissions</code> must include a source for the traffic.
    /// </para>
    ///  
    /// <para>
    /// You specify a protocol for each rule (for example, TCP). For TCP and UDP, you must
    /// also specify the destination port or port range. For ICMP/ICMPv6, you must also specify
    /// the ICMP/ICMPv6 type and code. You can use -1 to mean all types or all codes.
    /// </para>
    ///  
    /// <para>
    /// Rule changes are propagated to instances within the security group as quickly as possible.
    /// However, a small delay might occur.
    /// </para>
    ///  
    /// <para>
    /// For more information about VPC security group quotas, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/amazon-vpc-limits.html">Amazon
    /// VPC quotas</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// We are retiring EC2-Classic. We recommend that you migrate from EC2-Classic to a VPC.
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-migrate.html">Migrate
    /// from EC2-Classic to a VPC</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AuthorizeSecurityGroupIngressRequest : AmazonEC2Request
    {
        private string _groupId;
        private string _groupName;
        private List<IpPermission> _ipPermissions = new List<IpPermission>();
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public AuthorizeSecurityGroupIngressRequest() { }

        /// <summary>
        /// Instantiates AuthorizeSecurityGroupIngressRequest with the parameterized properties
        /// </summary>
        /// <param name="groupName">[EC2-Classic, default VPC] The name of the security group. You must specify either the security group ID or the security group name in the request. For security groups in a nondefault VPC, you must specify the security group ID.</param>
        /// <param name="ipPermissions">The sets of IP permissions.</param>
        public AuthorizeSecurityGroupIngressRequest(string groupName, List<IpPermission> ipPermissions)
        {
            _groupName = groupName;
            _ipPermissions = ipPermissions;
        }

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The ID of the security group. You must specify either the security group ID or the
        /// security group name in the request. For security groups in a nondefault VPC, you must
        /// specify the security group ID.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property GroupName. 
        /// <para>
        /// [EC2-Classic, default VPC] The name of the security group. You must specify either
        /// the security group ID or the security group name in the request. For security groups
        /// in a nondefault VPC, you must specify the security group ID.
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property IpPermissions. 
        /// <para>
        /// The sets of IP permissions.
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
            return this._ipPermissions != null && this._ipPermissions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// [VPC Only] The tags applied to the security group rule.
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
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

    }
}