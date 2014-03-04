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
    /// Adds one or more ingress rules to a security group.
    /// This action applies to both EC2 security groups and VPC security groups.
    /// </summary>
    /// <remarks>
    /// Permissions are specified by the IP protocol (TCP, UDP or ICMP),
    /// the source of the request (by IP range or an Amazon EC2 user-group pair),
    /// the source and destination port ranges (for TCP and UDP), and the
    /// ICMP codes and types (for ICMP). When authorizing ICMP, -1 can
    /// be used as a wildcard in the type and code fields.
    ///
    /// Permission changes are propagated to instances within the
    /// security group as quickly as possible. However, depending on
    /// the number of instances, a small delay might occur.
    ///
    /// When authorizing a user/group pair permission,
    /// GroupName, SourceSecurityGroupName and SourceSecurityGroupOwnerId
    /// must be specified. When authorizing a CIDR IP permission,
    /// GroupName, IpProtocol, FromPort, ToPort and CidrIp must be specified
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class AuthorizeSecurityGroupIngressRequest : EC2Request
    {    
        private string userIdField;
        private string groupIdField;
        private string groupNameField;
        private string sourceSecurityGroupNameField;
        private string sourceSecurityGroupOwnerIdField;
        private string ipProtocolField;
        private Decimal? fromPortField;
        private Decimal? toPortField;
        private string cidrIpField;
        private List<IpPermissionSpecification> ipPermissionsField;

        /// <summary>
        /// AWS Access Key ID.
        /// </summary>
        [XmlElementAttribute(ElementName = "UserId")]
        public string UserId
        {
            get { return this.userIdField; }
            set { this.userIdField = value; }
        }

        /// <summary>
        /// Sets the AWS Access Key ID.
        /// </summary>
        /// <param name="userId">AWS Access Key ID.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AuthorizeSecurityGroupIngressRequest WithUserId(string userId)
        {
            this.userIdField = userId;
            return this;
        }

        /// <summary>
        /// Checks if UserId property is set
        /// </summary>
        /// <returns>true if UserId property is set</returns>
        public bool IsSetUserId()
        {
            return this.userIdField != null;
        }

        /// <summary>
        /// Id of the standard (EC2) or VPC security group to modify.
        /// The group must belong to your account.
        /// </summary>
        [XmlElementAttribute(ElementName = "GroupId")]
        public string GroupId
        {
            get { return this.groupIdField; }
            set { this.groupIdField = value; }
        }

        /// <summary>
        /// Sets the Id of the standard (EC2) or VPC security group to modify.
        /// </summary>
        /// <param name="groupId">Id of the standard (EC2) or VPC security group to modify.
        /// </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AuthorizeSecurityGroupIngressRequest WithGroupId(string groupId)
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
        /// The name of the EC2 security group to modify.
        /// </summary>
        [XmlElementAttribute(ElementName = "GroupName")]
        public string GroupName
        {
            get { return this.groupNameField; }
            set { this.groupNameField = value; }
        }

        /// <summary>
        /// Sets the name of the EC2 security group to modify.
        /// </summary>
        /// <param name="groupName">Name of the group to modify.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AuthorizeSecurityGroupIngressRequest WithGroupName(string groupName)
        {
            this.groupNameField = groupName;
            return this;
        }

        /// <summary>
        /// Checks if GroupName property is set
        /// </summary>
        /// <returns>true if GroupName property is set</returns>
        public bool IsSetGroupName()
        {
            return this.groupNameField != null;
        }

        /// <summary>
        /// The name of the source security group.
        /// Cannot be used when specifying a CIDR IP address.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceSecurityGroupName")]
        public string SourceSecurityGroupName
        {
            get { return this.sourceSecurityGroupNameField; }
            set { this.sourceSecurityGroupNameField = value; }
        }

        /// <summary>
        /// Sets the name of the source security group.
        /// </summary>
        /// <param name="sourceSecurityGroupName">Name of the security group. Cannot be used
        /// when specifying a CIDR IP address.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AuthorizeSecurityGroupIngressRequest WithSourceSecurityGroupName(string sourceSecurityGroupName)
        {
            this.sourceSecurityGroupNameField = sourceSecurityGroupName;
            return this;
        }

        /// <summary>
        /// Checks if SourceSecurityGroupName property is set
        /// </summary>
        /// <returns>true if SourceSecurityGroupName property is set</returns>
        public bool IsSetSourceSecurityGroupName()
        {
            return this.sourceSecurityGroupNameField != null;
        }

        /// <summary>
        /// The ID of the source security group.
        /// Cannot be used when specifying a CIDR IP address.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceSecurityGroupOwnerId")]
        public string SourceSecurityGroupOwnerId
        {
            get { return this.sourceSecurityGroupOwnerIdField; }
            set { this.sourceSecurityGroupOwnerIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the source security group.
        /// </summary>
        /// <param name="sourceSecurityGroupOwnerId">AWS User ID of an account. Cannot be used when
        /// specifying a CIDR IP address.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AuthorizeSecurityGroupIngressRequest WithSourceSecurityGroupOwnerId(string sourceSecurityGroupOwnerId)
        {
            this.sourceSecurityGroupOwnerIdField = sourceSecurityGroupOwnerId;
            return this;
        }

        /// <summary>
        /// Checks if SourceSecurityGroupOwnerId property is set
        /// </summary>
        /// <returns>true if SourceSecurityGroupOwnerId property is set</returns>
        public bool IsSetSourceSecurityGroupOwnerId()
        {
            return this.sourceSecurityGroupOwnerIdField != null;
        }

        /// <summary>
        /// The IP protocol name or number.
        /// EC2 security groups can have rules only for TCP, UDP, and ICMP,
        /// whereas VPC security groups can have rules assigned to any protocol number.
        /// </summary>
        [XmlElementAttribute(ElementName = "IpProtocol")]
        public string IpProtocol
        {
            get { return this.ipProtocolField; }
            set { this.ipProtocolField = value; }
        }

        /// <summary>
        /// Sets the IP protocol name or number.
        /// </summary>
        /// <param name="ipProtocol">IP protocol.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AuthorizeSecurityGroupIngressRequest WithIpProtocol(string ipProtocol)
        {
            this.ipProtocolField = ipProtocol;
            return this;
        }

        /// <summary>
        /// Checks if IpProtocol property is set
        /// </summary>
        /// <returns>true if IpProtocol property is set</returns>
        public bool IsSetIpProtocol()
        {
            return this.ipProtocolField != null;
        }

        /// <summary>
        /// The start of port range for the TCP and UDP protocols, or an ICMP type number.
        /// For the ICMP type number, you can use -1 to specify all ICMP types.
        /// </summary>
        [XmlElementAttribute(ElementName = "FromPort")]
        public Decimal FromPort
        {
            get { return this.fromPortField.GetValueOrDefault(); }
            set { this.fromPortField = value; }
        }

        /// <summary>
        /// Sets the start of port range for the TCP and UDP protocols, or an ICMP type number.
        /// </summary>
        /// <param name="fromPort">The start of port range for the TCP and UDP protocols, or an ICMP type number.
        /// </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AuthorizeSecurityGroupIngressRequest WithFromPort(Decimal fromPort)
        {
            this.fromPortField = fromPort;
            return this;
        }

        /// <summary>
        /// Checks if FromPort property is set
        /// </summary>
        /// <returns>true if FromPort property is set</returns>
        public bool IsSetFromPort()
        {
            return this.fromPortField.HasValue;
        }

        /// <summary>
        /// The end of port range for the TCP and UDP protocols, or an ICMP code number.
        /// For the ICMP code number, you can use -1 to specify all ICMP codes for the given ICMP type.
        /// </summary>
        [XmlElementAttribute(ElementName = "ToPort")]
        public Decimal ToPort
        {
            get { return this.toPortField.GetValueOrDefault(); }
            set { this.toPortField = value; }
        }

        /// <summary>
        /// Sets the end of port range for the TCP and UDP protocols, or an ICMP code number.
        /// </summary>
        /// <param name="toPort">End of port range for the TCP and UDP protocols, or an ICMP code.
        /// An ICMP code of -1 indicates a wildcard (i.e., any ICMP code).</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AuthorizeSecurityGroupIngressRequest WithToPort(Decimal toPort)
        {
            this.toPortField = toPort;
            return this;
        }

        /// <summary>
        /// Checks if ToPort property is set
        /// </summary>
        /// <returns>true if ToPort property is set</returns>
        public bool IsSetToPort()
        {
            return this.toPortField.HasValue;
        }

        /// <summary>
        /// The CIDR range.
        /// Cannot be used when specifying a source security group.
        /// </summary>
        [XmlElementAttribute(ElementName = "CidrIp")]
        public string CidrIp
        {
            get { return this.cidrIpField; }
            set { this.cidrIpField = value; }
        }

        /// <summary>
        /// Sets the CIDR range.
        /// </summary>
        /// <param name="cidrIp">CIDR range.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AuthorizeSecurityGroupIngressRequest WithCidrIp(string cidrIp)
        {
            this.cidrIpField = cidrIp;
            return this;
        }

        /// <summary>
        /// Checks if CidrIp property is set
        /// </summary>
        /// <returns>true if CidrIp property is set</returns>
        public bool IsSetCidrIp()
        {
            return this.cidrIpField != null;
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
        public AuthorizeSecurityGroupIngressRequest WithIpPermissions(params IpPermissionSpecification[] list)
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
