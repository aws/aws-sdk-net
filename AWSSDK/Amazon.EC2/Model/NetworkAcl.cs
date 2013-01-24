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
    /// Network ACL description.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class NetworkAcl
    {    
        private string networkAclIdField;
        private string vpcIdField;
        private bool? defaultField;
        private List<NetworkAclEntry> entriesField;
        private List<NetworkAclAssociation> associationsField;
        private List<Tag> tagField;

        /// <summary>
        /// The network ACL's ID.
        /// </summary>
        [XmlElementAttribute(ElementName = "NetworkAclId")]
        public string NetworkAclId
        {
            get { return this.networkAclIdField; }
            set { this.networkAclIdField = value; }
        }

        /// <summary>
        /// Sets the network ACL's ID.
        /// </summary>
        /// <param name="networkAclId">The network ACL's ID.</param>
        /// <returns>this instance</returns>
        public NetworkAcl WithNetworkAclId(string networkAclId)
        {
            this.networkAclIdField = networkAclId;
            return this;
        }

        /// <summary>
        /// Checks if NetworkAclId property is set
        /// </summary>
        /// <returns>true if NetworkAclId property is set</returns>
        public bool IsSetNetworkAclId()
        {
            return this.networkAclIdField != null;
        }

        /// <summary>
        /// The ID of the VPC the network ACL is in.
        /// </summary>
        [XmlElementAttribute(ElementName = "VpcId")]
        public string VpcId
        {
            get { return this.vpcIdField; }
            set { this.vpcIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the VPC the network ACL is in.
        /// </summary>
        /// <param name="vpcId">The ID of the VPC the network ACL is in.</param>
        /// <returns>this instance</returns>
        public NetworkAcl WithVpcId(string vpcId)
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
        /// Whether this is the default network ACL in the VPC.
        /// </summary>
        [XmlElementAttribute(ElementName = "Default")]
        public bool Default
        {
            get { return this.defaultField.GetValueOrDefault(); }
            set { this.defaultField = value; }
        }

        /// <summary>
        /// Sets whether this is the default network ACL in the VPC.
        /// </summary>
        /// <param name="isDefault">Whether this is the default network ACL in the VPC.</param>
        /// <returns>this instance</returns>
        public NetworkAcl WithDefault(bool isDefault)
        {
            this.defaultField = isDefault;
            return this;
        }

        /// <summary>
        /// Checks if Default property is set
        /// </summary>
        /// <returns>true if Default property is set</returns>
        public bool IsSetDefault()
        {
            return this.defaultField.HasValue;
        }

        /// <summary>
        /// A list of entries (rules) in the network ACL.
        /// </summary>
        [XmlElementAttribute(ElementName = "Entries")]
        public List<NetworkAclEntry> Entries
        {
            get
            {
                if (this.entriesField == null)
                {
                    this.entriesField = new List<NetworkAclEntry>();
                }
                return this.entriesField;
            }
            set { this.entriesField = value; }
        }

        /// <summary>
        /// Sets the entries (rules) in the network ACL.
        /// </summary>
        /// <param name="list">A list of entries (rules) in the network ACL.</param>
        /// <returns>this instance</returns>
        public NetworkAcl WithEntries(params NetworkAclEntry[] list)
        {
            foreach (NetworkAclEntry item in list)
            {
                Entries.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Entries property is set
        /// </summary>
        /// <returns>true if Entries property is set</returns>
        public bool IsSetEntries()
        {
            return (Entries.Count > 0);
        }

        /// <summary>
        /// A list of associations between the network ACL and one or more subnets.
        /// </summary>
        [XmlElementAttribute(ElementName = "Associations")]
        public List<NetworkAclAssociation> Associations
        {
            get
            {
                if (this.associationsField == null)
                {
                    this.associationsField = new List<NetworkAclAssociation>();
                }
                return this.associationsField;
            }
            set { this.associationsField = value; }
        }

        /// <summary>
        /// Sets the associations between the network ACL and one or more subnets.
        /// </summary>
        /// <param name="list">A list of associations between the network ACL and one or more
        /// subnets.</param>
        /// <returns>this instance</returns>
        public NetworkAcl WithAssociations(params NetworkAclAssociation[] list)
        {
            foreach (NetworkAclAssociation item in list)
            {
                Associations.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Associations property is set
        /// </summary>
        /// <returns>true if Associations property is set</returns>
        public bool IsSetAssociations()
        {
            return (Associations.Count > 0);
        }

        /// <summary>
        /// A list of tags for the NetworkAcl.
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
        /// Sets the tags for the NetworkAcl.
        /// </summary>
        /// <param name="list">A list of tags for the NetworkAcl.</param>
        /// <returns>this instance</returns>
        public NetworkAcl WithTag(params Tag[] list)
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

    }
}
