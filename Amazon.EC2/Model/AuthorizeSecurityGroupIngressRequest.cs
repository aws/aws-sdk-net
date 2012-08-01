/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Adds permissions to a security group.
    ///
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
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class AuthorizeSecurityGroupIngressRequest
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
        /// Gets and sets the UserId property.
        /// AWS Access Key ID.
        /// </summary>
        [XmlElementAttribute(ElementName = "UserId")]
        public string UserId
        {
            get { return this.userIdField; }
            set { this.userIdField = value; }
        }

        /// <summary>
        /// Sets the UserId property
        /// </summary>
        /// <param name="userId">AWS Access Key ID.</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the GroupId property.
        /// Id of the standard (EC2) or VPC security group to modify. Conditional
        /// The group must belong to your account.
        /// </summary>
        [XmlElementAttribute(ElementName = "GroupId")]
        public string GroupId
        {
            get { return this.groupIdField; }
            set { this.groupIdField = value; }
        }

        /// <summary>
        /// Sets the GroupId property
        /// </summary>
        /// <param name="groupId">Id of the standard (EC2) or VPC security group to modify. Conditional
        /// The group must belong to your account.</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the GroupName property.
        /// Name of the group to modify. The name must be
        /// valid and belong to the account
        /// </summary>
        [XmlElementAttribute(ElementName = "GroupName")]
        public string GroupName
        {
            get { return this.groupNameField; }
            set { this.groupNameField = value; }
        }

        /// <summary>
        /// Sets the GroupName property
        /// </summary>
        /// <param name="groupName">Name of the group to modify. The name must be
        /// valid and belong to the account</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the SourceSecurityGroupName property.
        /// Name of the security group. Cannot be used
        /// when specifying a CIDR IP address.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceSecurityGroupName")]
        public string SourceSecurityGroupName
        {
            get { return this.sourceSecurityGroupNameField; }
            set { this.sourceSecurityGroupNameField = value; }
        }

        /// <summary>
        /// Sets the SourceSecurityGroupName property
        /// </summary>
        /// <param name="sourceSecurityGroupName">Name of the security group. Cannot be used
        /// when specifying a CIDR IP address.</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the SourceSecurityGroupOwnerId property.
        /// AWS User ID of an account. Cannot be used when
        /// specifying a CIDR IP address.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceSecurityGroupOwnerId")]
        public string SourceSecurityGroupOwnerId
        {
            get { return this.sourceSecurityGroupOwnerIdField; }
            set { this.sourceSecurityGroupOwnerIdField = value; }
        }

        /// <summary>
        /// Sets the SourceSecurityGroupOwnerId property
        /// </summary>
        /// <param name="sourceSecurityGroupOwnerId">AWS User ID of an account. Cannot be used when
        /// specifying a CIDR IP address.</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the IpProtocol property.
        /// IP protocol.
        /// </summary>
        [XmlElementAttribute(ElementName = "IpProtocol")]
        public string IpProtocol
        {
            get { return this.ipProtocolField; }
            set { this.ipProtocolField = value; }
        }

        /// <summary>
        /// Sets the IpProtocol property
        /// </summary>
        /// <param name="ipProtocol">IP protocol.</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the FromPort property.
        /// Start of port range for the TCP and UDP protocols, or an ICMP type number.
        /// An ICMP type number of -1 indicates a wildcard (i.e., any ICMP type number).
        /// </summary>
        [XmlElementAttribute(ElementName = "FromPort")]
        public Decimal FromPort
        {
            get { return this.fromPortField.GetValueOrDefault(); }
            set { this.fromPortField = value; }
        }

        /// <summary>
        /// Sets the FromPort property
        /// </summary>
        /// <param name="fromPort">Start of port range for the TCP and UDP protocols, or an ICMP type number.
        /// An ICMP type number of -1 indicates a wildcard (i.e., any ICMP type number).</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the ToPort property.
        /// End of port range for the TCP and UDP protocols, or an ICMP code.
        /// An ICMP code of -1 indicates a wildcard (i.e., any ICMP code).
        /// </summary>
        [XmlElementAttribute(ElementName = "ToPort")]
        public Decimal ToPort
        {
            get { return this.toPortField.GetValueOrDefault(); }
            set { this.toPortField = value; }
        }

        /// <summary>
        /// Sets the ToPort property
        /// </summary>
        /// <param name="toPort">End of port range for the TCP and UDP protocols, or an ICMP code.
        /// An ICMP code of -1 indicates a wildcard (i.e., any ICMP code).</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the CidrIp property.
        /// CIDR range.
        /// </summary>
        [XmlElementAttribute(ElementName = "CidrIp")]
        public string CidrIp
        {
            get { return this.cidrIpField; }
            set { this.cidrIpField = value; }
        }

        /// <summary>
        /// Sets the CidrIp property
        /// </summary>
        /// <param name="cidrIp">CIDR range.</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the IpPermissions property.
        /// Set of IP permissions associated with the
        /// security group.
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
        /// Sets the IpPermissions property
        /// </summary>
        /// <param name="list">Set of IP permissions associated with the
        /// security group.</param>
        /// <returns>this instance</returns>
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
