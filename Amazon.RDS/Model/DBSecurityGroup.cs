/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2010-01-01
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.RDS.Model
{
    ///<summary>
    ///Information about the DB Security Group.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/doc/2010-01-01/", IsNullable = false)]
    public class DBSecurityGroup
    {
        private string ownerIdField;
        private string DBSecurityGroupNameField;
        private string DBSecurityGroupDescriptionField;
        private List<EC2SecurityGroup> EC2SecurityGroupField;
        private List<IPRange> IPRangeField;

        /// <summary>
        /// Gets and sets the OwnerId property.
        /// AWS ID of the owner of the security group specified in the EC2SecurityGroupName parameter.
        /// </summary>
        [XmlElementAttribute(ElementName = "OwnerId")]
        public string OwnerId
        {
            get { return this.ownerIdField; }
            set { this.ownerIdField = value; }
        }

        /// <summary>
        /// Sets the OwnerId property
        /// </summary>
        /// <param name="ownerId">AWS ID of the owner of the security group specified in the EC2SecurityGroupName parameter.</param>
        /// <returns>this instance</returns>
        public DBSecurityGroup WithOwnerId(string ownerId)
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
        /// Gets and sets the DBSecurityGroupName property.
        /// </summary>
        [XmlElementAttribute(ElementName = "DBSecurityGroupName")]
        public string DBSecurityGroupName
        {
            get { return this.DBSecurityGroupNameField; }
            set { this.DBSecurityGroupNameField = value; }
        }

        /// <summary>
        /// Sets the DBSecurityGroupName property
        /// </summary>
        /// <param name="DBSecurityGroupName">DBSecurityGroupName property</param>
        /// <returns>this instance</returns>
        public DBSecurityGroup WithDBSecurityGroupName(string DBSecurityGroupName)
        {
            this.DBSecurityGroupNameField = DBSecurityGroupName;
            return this;
        }

        /// <summary>
        /// Checks if DBSecurityGroupName property is set
        /// </summary>
        /// <returns>true if DBSecurityGroupName property is set</returns>
        public bool IsSetDBSecurityGroupName()
        {
            return this.DBSecurityGroupNameField != null;
        }

        /// <summary>
        /// Gets and sets the DBSecurityGroupDescription property.
        /// The description of the database security group.
        /// </summary>
        [XmlElementAttribute(ElementName = "DBSecurityGroupDescription")]
        public string DBSecurityGroupDescription
        {
            get { return this.DBSecurityGroupDescriptionField; }
            set { this.DBSecurityGroupDescriptionField = value; }
        }

        /// <summary>
        /// Sets the DBSecurityGroupDescription property
        /// </summary>
        /// <param name="DBSecurityGroupDescription">The description of the database security group.</param>
        /// <returns>this instance</returns>
        public DBSecurityGroup WithDBSecurityGroupDescription(string DBSecurityGroupDescription)
        {
            this.DBSecurityGroupDescriptionField = DBSecurityGroupDescription;
            return this;
        }

        /// <summary>
        /// Checks if DBSecurityGroupDescription property is set
        /// </summary>
        /// <returns>true if DBSecurityGroupDescription property is set</returns>
        public bool IsSetDBSecurityGroupDescription()
        {
            return this.DBSecurityGroupDescriptionField != null;
        }

        /// <summary>
        /// Gets and sets the EC2SecurityGroup property.
        /// List of EC2SecurityGroup elements.
        /// </summary>
        [XmlElementAttribute(ElementName = "EC2SecurityGroup")]
        public List<EC2SecurityGroup> EC2SecurityGroup
        {
            get
            {
                if (this.EC2SecurityGroupField == null)
                {
                    this.EC2SecurityGroupField = new List<EC2SecurityGroup>();
                }
                return this.EC2SecurityGroupField;
            }
            set { this.EC2SecurityGroupField = value; }
        }

        /// <summary>
        /// Sets the EC2SecurityGroup property
        /// </summary>
        /// <param name="list">List of EC2SecurityGroup elements.</param>
        /// <returns>this instance</returns>
        public DBSecurityGroup WithEC2SecurityGroup(params EC2SecurityGroup[] list)
        {
            foreach (EC2SecurityGroup item in list)
            {
                EC2SecurityGroup.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if EC2SecurityGroup property is set
        /// </summary>
        /// <returns>true if EC2SecurityGroup property is set</returns>
        public bool IsSetEC2SecurityGroup()
        {
            return (EC2SecurityGroup.Count > 0);
        }

        /// <summary>
        /// Gets and sets the IPRange property.
        /// </summary>
        [XmlElementAttribute(ElementName = "IPRange")]
        public List<IPRange> IPRange
        {
            get
            {
                if (this.IPRangeField == null)
                {
                    this.IPRangeField = new List<IPRange>();
                }
                return this.IPRangeField;
            }
            set { this.IPRangeField = value; }
        }

        /// <summary>
        /// Sets the IPRange property
        /// </summary>
        /// <param name="list">IPRange property</param>
        /// <returns>this instance</returns>
        public DBSecurityGroup WithIPRange(params IPRange[] list)
        {
            foreach (IPRange item in list)
            {
                IPRange.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if IPRange property is set
        /// </summary>
        /// <returns>true if IPRange property is set</returns>
        public bool IsSetIPRange()
        {
            return (IPRange.Count > 0);
        }

    }
}
