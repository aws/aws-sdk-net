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
    /// Creates a new security group. Group names must be
    /// unique per account.
    ///
    /// Every instance is launched in a security group.
    /// If no security group is specified during launch,
    /// the instances are launched in the default security group.
    /// Instances within the same security group have unrestricted network
    /// access to each other. Instances will reject network access attempts from
    /// other instances in a different security group. As the owner of instances you
    /// can grant or revoke specific permissions using the
    /// AuthorizeSecurityGroupIngress and RevokeSecurityGroupIngress
    /// operations
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class CreateSecurityGroupRequest
    {    
        private string groupNameField;
        private string groupDescriptionField;
        private string vpcIdField;

        /// <summary>
        /// Gets and sets the GroupName property.
        /// Name of the security group.
        ///
        /// Constraints:
        /// Accepts alphanumeric characters, spaces, dashes, and
        /// underscores.
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
        /// <param name="groupName">Name of the security group.
        ///
        /// Constraints:
        /// Accepts alphanumeric characters, spaces, dashes, and
        /// underscores.</param>
        /// <returns>this instance</returns>
        public CreateSecurityGroupRequest WithGroupName(string groupName)
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
        /// Gets and sets the GroupDescription property.
        /// Description of the group.
        ///
        /// Constraints: Accepts
        /// alphanumeric characters, spaces, dashes, and
        /// underscores.
        /// </summary>
        [XmlElementAttribute(ElementName = "GroupDescription")]
        public string GroupDescription
        {
            get { return this.groupDescriptionField; }
            set { this.groupDescriptionField = value; }
        }

        /// <summary>
        /// Sets the GroupDescription property
        /// </summary>
        /// <param name="groupDescription">Description of the group.
        ///
        /// Constraints: Accepts
        /// alphanumeric characters, spaces, dashes, and
        /// underscores.</param>
        /// <returns>this instance</returns>
        public CreateSecurityGroupRequest WithGroupDescription(string groupDescription)
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
        /// Gets and sets the VpcId property.
        /// ID of the VPC.
        ///
        /// Condition: Required for VPC security groups
        /// </summary>
        [XmlElementAttribute(ElementName = "VpcId")]
        public string VpcId
        {
            get { return this.vpcIdField; }
            set { this.vpcIdField = value; }
        }

        /// <summary>
        /// Sets the VpcId property
        /// </summary>
        /// <param name="vpcId">ID of the VPC.
        ///
        /// Condition: Required for VPC security groups</param>
        /// <returns>this instance</returns>
        public CreateSecurityGroupRequest WithVpcId(string vpcId)
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

    }
}
