/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Adds one or more egress rules to a VPC security group.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This call permits instances in a security group to send traffic to one or more destination
    /// CIDR IP address ranges, or to one or more destination security groups in the same VPC.
    /// </para>
    /// <para>
    /// This action applies only to security groups in a VPC; it's not supported for standard (EC2) security groups.
    /// </para>
    /// <para>
    /// Each rule consists of the protocol (e.g., TCP), plus either a CIDR range, or a source group. For the TCP
    /// and UDP protocols, you must also specify the destination port or port range. For the ICMP protocol, you
    /// must also specify the ICMP type and code.You can use -1 as a wildcard for the ICMP type or code.
    /// </para>
    /// <para>
    /// Rule changes are propagated to instances within the security group as quickly as possible. However, a
    /// small delay might occur.
    /// </para>
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class AuthorizeSecurityGroupEgressRequest : EC2Request
    {    
        private string groupIdField;
        private List<IpPermissionSpecification> ipPermissionsField;

        /// <summary>
        /// ID of the VPC security group to modify.
        /// </summary>
        [XmlElementAttribute(ElementName = "GroupId")]
        public string GroupId
        {
            get { return this.groupIdField; }
            set { this.groupIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the VPC security group to modify.
        /// </summary>
        /// <param name="groupId">ID of the VPC security group to modify.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AuthorizeSecurityGroupEgressRequest WithGroupId(string groupId)
        {
            this.groupIdField = groupId;
            return this;
        }

        /// <summary>
        /// Checks if GroupId property is set
        /// </summary>
        /// <returns>true if GroupId property is set</returns>
        public bool IsSetGroupId()
        {
            return this.groupIdField != null;
        }

        /// <summary>
        /// Set of IP permissions associated with the security group.
        /// </summary>
        [XmlElementAttribute(ElementName = "IpPermissions")]
        public List<IpPermissionSpecification> IpPermissions
        {
            get
            {
                if (this.ipPermissionsField == null)
                {
                    this.ipPermissionsField = new List<IpPermissionSpecification>();
                }
                return this.ipPermissionsField;
            }
            set { this.ipPermissionsField = value; }
        }

        /// <summary>
        /// Sets the IP permissions associated with the security group.
        /// </summary>
        /// <param name="list">Set of IP permissions associated with the
        /// security group.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AuthorizeSecurityGroupEgressRequest WithIpPermissions(params IpPermissionSpecification[] list)
        {
            foreach (IpPermissionSpecification item in list)
            {
                IpPermissions.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if IpPermissions property is set
        /// </summary>
        /// <returns>true if IpPermissions property is set</returns>
        public bool IsSetIpPermissions()
        {
            return (IpPermissions.Count > 0);
        }

    }
}
