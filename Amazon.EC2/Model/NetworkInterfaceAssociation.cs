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
 *  API Version: 2012-03-01
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Network Interface Association
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2012-03-01/", IsNullable = false)]
    public class NetworkInterfaceAssociation
    {
        private string publicIpField;
        private string ipOwnerIdField;
        private string allocationIdField;
        private string associationIdField;

        /// <summary>
        /// Gets and sets the PublicIp property
        /// </summary>
        [XmlElementAttribute(ElementName = "PublicIp")]
        public string PublicIp
        {
            get { return this.publicIpField; }
            set { this.publicIpField = value; }
        }

        /// <summary>
        /// Sets the PublicIp property
        /// </summary>
        /// <param name="publicIp">Public Ip</param>
        /// <returns>this instance</returns>
        public NetworkInterfaceAssociation WithPublicIp(string publicIp)
        {
            this.publicIpField = publicIp;
            return this;
        }

        /// <summary>
        /// Checks if the PublicIp property is set
        /// </summary>
        /// <returns>true if the PublicIp property is set</returns>
        public bool IsSetPublicIp()
        {
            return !string.IsNullOrEmpty(this.publicIpField);
        }

        /// <summary>
        /// Gets and sets the IpOwnerId property
        /// </summary>
        [XmlElementAttribute(ElementName = "IpOwnerId")]
        public string IpOwnerId
        {
            get { return this.ipOwnerIdField; }
            set { this.ipOwnerIdField = value; }
        }

        /// <summary>
        /// Sets the IpOwnerId property
        /// </summary>
        /// <param name="ipOwnerId">Ip Owner Id</param>
        /// <returns>this instance</returns>
        public NetworkInterfaceAssociation WithIpOwnerId(string ipOwnerId)
        {
            this.ipOwnerIdField = ipOwnerId;
            return this;
        }

        /// <summary>
        /// Checks if the IpOwnerId property is set
        /// </summary>
        /// <returns>true if the IpOwnerId property is set</returns>
        public bool IsSetIpOwnerId()
        {
            return !string.IsNullOrEmpty(this.ipOwnerIdField);
        }

        /// <summary>
        /// Gets and sets the AllocationId property
        /// </summary>
        [XmlElementAttribute(ElementName = "AllocationId")]
        public string AllocationId
        {
            get { return this.allocationIdField; }
            set { this.allocationIdField = value; }
        }

        /// <summary>
        /// Sets the AllocationId property
        /// </summary>
        /// <param name="allocationId">Allocation Id</param>
        /// <returns>this instance</returns>
        public NetworkInterfaceAssociation WithAllocationId(string allocationId)
        {
            this.allocationIdField = allocationId;
            return this;
        }

        /// <summary>
        /// Checks if the AllocationId property is set
        /// </summary>
        /// <returns>true if the AllocationId property is set</returns>
        public bool IsSetAllocationId()
        {
            return !string.IsNullOrEmpty(this.allocationIdField);
        }

        /// <summary>
        /// Gets and sets the AssociationId property
        /// </summary>
        [XmlElementAttribute(ElementName = "AssociationId")]
        public string AssociationId
        {
            get { return this.associationIdField; }
            set { this.associationIdField = value; }
        }

        /// <summary>
        /// Sets the AssociationId property
        /// </summary>
        /// <param name="associationId">Association Id</param>
        /// <returns>this instance</returns>
        public NetworkInterfaceAssociation WithAssociationId(string associationId)
        {
            this.associationIdField = associationId;
            return this;
        }

        /// <summary>
        /// Checks if the AssocationId property is set
        /// </summary>
        /// <returns>true if the AssociationId property is set</returns>
        public bool IsSetAssociationId()
        {
            return !string.IsNullOrEmpty(this.associationIdField);
        }
    }
}
