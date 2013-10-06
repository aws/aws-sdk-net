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
    /// Network ACL association.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class NetworkAclAssociation
    {    
        private string networkAclAssociationIdField;
        private string networkAclIdField;
        private string subnetIdField;

        /// <summary>
        /// An identifier representing the association between a network ACL and a subnet.
        /// </summary>
        [XmlElementAttribute(ElementName = "NetworkAclAssociationId")]
        public string NetworkAclAssociationId
        {
            get { return this.networkAclAssociationIdField; }
            set { this.networkAclAssociationIdField = value; }
        }

        /// <summary>
        /// Sets an identifier representing the association between a network ACL and a subnet.
        /// </summary>
        /// <param name="networkAclAssociationId">An identifier representing the association between a network ACL
        /// and a subnet.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public NetworkAclAssociation WithNetworkAclAssociationId(string networkAclAssociationId)
        {
            this.networkAclAssociationIdField = networkAclAssociationId;
            return this;
        }

        /// <summary>
        /// Checks if NetworkAclAssociationId property is set
        /// </summary>
        /// <returns>true if NetworkAclAssociationId property is set</returns>
        public bool IsSetNetworkAclAssociationId()
        {
            return this.networkAclAssociationIdField != null;
        }

        /// <summary>
        /// The ID of the network ACL in the association.
        /// </summary>
        [XmlElementAttribute(ElementName = "NetworkAclId")]
        public string NetworkAclId
        {
            get { return this.networkAclIdField; }
            set { this.networkAclIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the network ACL in the association.
        /// </summary>
        /// <param name="networkAclId">The ID of the network ACL in the association.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public NetworkAclAssociation WithNetworkAclId(string networkAclId)
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
        /// The ID of the subnet in the association.
        /// </summary>
        [XmlElementAttribute(ElementName = "SubnetId")]
        public string SubnetId
        {
            get { return this.subnetIdField; }
            set { this.subnetIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the subnet in the association.
        /// </summary>
        /// <param name="subnetId">The ID of the subnet in the association.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public NetworkAclAssociation WithSubnetId(string subnetId)
        {
            this.subnetIdField = subnetId;
            return this;
        }

        /// <summary>
        /// Checks if SubnetId property is set
        /// </summary>
        /// <returns>true if SubnetId property is set</returns>
        public bool IsSetSubnetId()
        {
            return this.subnetIdField != null;
        }

    }
}
