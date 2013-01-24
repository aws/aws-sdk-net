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
    /// Security group
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class SecurityGroup
    {    
        private string ownerIdField;
        private string vpcIdField;
        private string groupIdField;
        private string groupNameField;
        private string groupDescriptionField;
        private List<Tag> tagField;
        private List<IpPermission> ipPermissionField;
        private List<IpPermission> ipPermissionsEgressField;

        /// <summary>
        /// AWS Access Key ID of the owner of the security group.
        /// </summary>
        [XmlElementAttribute(ElementName = "OwnerId")]
        public string OwnerId
        {
            get { return this.ownerIdField; }
            set { this.ownerIdField = value; }
        }

        /// <summary>
        /// Sets the AWS Access Key ID of the owner of the security group.
        /// </summary>
        /// <param name="ownerId">AWS Access Key ID of the owner of the security
        /// group.</param>
        /// <returns>this instance</returns>
        public SecurityGroup WithOwnerId(string ownerId)
        {
            this.ownerIdField = ownerId;
            return this;
        }

        /// <summary>
        /// Checks if OwnerId property is set
        /// </summary>
        /// <returns>true if OwnerId property is set</returns>
        public bool IsSetOwnerId()
        {
            return this.ownerIdField != null;
        }

        /// <summary>
        /// The ID of the VPC to which the group belongs.
        /// </summary>
        [XmlElementAttribute(ElementName = "VpcId")]
        public string VpcId
        {
            get { return this.vpcIdField; }
            set { this.vpcIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the VPC to which the group belongs.
        /// </summary>
        /// <param name="vpcId">The vpc to which the group belongs.</param>
        /// <returns>this instance</returns>
        public SecurityGroup WithVpcId(string vpcId)
        {
            this.vpcIdField = vpcId;
            return this;
        }

        /// <summary>
        /// Checks if VpcId property is set
        /// </summary>
        /// <returns>true if VpcId property is set</returns>
        public bool IsSetVpcId()
        {
            return this.vpcIdField != null;
        }

        /// <summary>
        /// ID of the security group.
        /// </summary>
        [XmlElementAttribute(ElementName = "GroupId")]
        public string GroupId
        {
            get { return this.groupIdField; }
            set { this.groupIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the security group.
        /// </summary>
        /// <param name="groupId">Id of the security group.</param>
        /// <returns>this instance</returns>
        public SecurityGroup WithGroupId(string groupId)
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
        /// Name of the security group.
        /// </summary>
        [XmlElementAttribute(ElementName = "GroupName")]
        public string GroupName
        {
            get { return this.groupNameField; }
            set { this.groupNameField = value; }
        }

        /// <summary>
        /// Sets the name of the security group.
        /// </summary>
        /// <param name="groupName">Name of the security group.</param>
        /// <returns>this instance</returns>
        public SecurityGroup WithGroupName(string groupName)
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
        /// Description of the security group.
        /// </summary>
        [XmlElementAttribute(ElementName = "GroupDescription")]
        public string GroupDescription
        {
            get { return this.groupDescriptionField; }
            set { this.groupDescriptionField = value; }
        }

        /// <summary>
        /// Sets the description of the security group.
        /// </summary>
        /// <param name="groupDescription">Description of the security group.</param>
        /// <returns>this instance</returns>
        public SecurityGroup WithGroupDescription(string groupDescription)
        {
            this.groupDescriptionField = groupDescription;
            return this;
        }

        /// <summary>
        /// Checks if GroupDescription property is set
        /// </summary>
        /// <returns>true if GroupDescription property is set</returns>
        public bool IsSetGroupDescription()
        {
            return this.groupDescriptionField != null;
        }

        /// <summary>
        /// A list of tags for the security group.
        /// </summary>
        [XmlElementAttribute(ElementName = "Tag")]
        public List<Tag> Tag
        {
            get
            {
                if (this.tagField == null)
                {
                    this.tagField = new List<Tag>();
                }
                return this.tagField;
            }
            set { this.tagField = value; }
        }

        /// <summary>
        /// Sets the tags for the security group.
        /// </summary>
        /// <param name="list">A list of tags for the security group.</param>
        /// <returns>this instance</returns>
        public SecurityGroup WithTag(params Tag[] list)
        {
            foreach (Tag item in list)
            {
                Tag.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Tag property is set
        /// </summary>
        /// <returns>true if Tag property is set</returns>
        public bool IsSetTag()
        {
            return (Tag.Count > 0);
        }

        /// <summary>
        /// Set of IP permissions associated with the security group.
        /// </summary>
        [XmlElementAttribute(ElementName = "IpPermission")]
        public List<IpPermission> IpPermission
        {
            get
            {
                if (this.ipPermissionField == null)
                {
                    this.ipPermissionField = new List<IpPermission>();
                }
                return this.ipPermissionField;
            }
            set { this.ipPermissionField = value; }
        }

        /// <summary>
        /// Sets the IP permissions associated with the security group.
        /// </summary>
        /// <param name="list">Set of IP permissions associated with the
        /// security group.</param>
        /// <returns>this instance</returns>
        public SecurityGroup WithIpPermission(params IpPermission[] list)
        {
            foreach (IpPermission item in list)
            {
                IpPermission.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if IpPermission property is set
        /// </summary>
        /// <returns>true if IpPermission property is set</returns>
        public bool IsSetIpPermission()
        {
            return (IpPermission.Count > 0);
        }

        /// <summary>
        /// A list of outbound rules associated with the security group (for VPC security groups).
        /// </summary>
        [XmlElementAttribute(ElementName = "IpPermissionsEgress")]
        public List<IpPermission> IpPermissionsEgress
        {
            get
            {
                if (this.ipPermissionsEgressField == null)
                {
                    this.ipPermissionsEgressField = new List<IpPermission>();
                }
                return this.ipPermissionsEgressField;
            }
            set { this.ipPermissionsEgressField = value; }
        }

        /// <summary>
        /// Sets the outbound rules associated with the security group (for VPC security groups).
        /// </summary>
        /// <param name="list">A list of outbound rules associated with the security group (for VPC security groups).</param>
        /// <returns>this instance</returns>
        public SecurityGroup WithIpPermissionsEgress(params IpPermission[] list)
        {
            foreach (IpPermission item in list)
            {
                IpPermissionsEgress.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if IpPermissionsEgress property is set
        /// </summary>
        /// <returns>true if IpPermissionsEgress property is set</returns>
        public bool IsSetIpPermissionsEgress()
        {
            return (IpPermissionsEgress.Count > 0);
        }

    }
}
