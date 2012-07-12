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
 *  API Version: 2012-06-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Instance Network Interface Association
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2012-06-15/", IsNullable = false)]
    public class InstanceNetworkInterfaceAssociation
    {
        private string publicIpField;
        private string ipOwnerIdField;

        /// <summary>
        /// Gets and sets the PublicIp property.
        /// The address of the Elastic IP address bound to the network interface.
        /// </summary>
        [XmlElementAttribute(ElementName = "PublicIp")]
        public string PublicIp
        {
            get { return this.publicIpField; }
            set { this.publicIpField = value; }
        }

        /// <summary>
        /// Sets the PublicIp property.
        /// The address of the Elastic IP address bound to the network interface.
        /// </summary>
        /// <param name="publicIp">Public IP</param>
        /// <returns>this instance</returns>
        public InstanceNetworkInterfaceAssociation WithPublicIp(string publicIp)
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
        /// Gets and sets the IpOwnerId property.
        /// The ID of the Elastic IP address owner.
        /// </summary>
        [XmlElementAttribute(ElementName = "IpOwnerId")]
        public string IpOwnerId
        {
            get { return this.ipOwnerIdField; }
            set { this.ipOwnerIdField = value; }
        }

        /// <summary>
        /// Sets the IpOwnerId property.
        /// The ID of the Elastic IP address owner.
        /// </summary>
        /// <param name="ipOwnerId">IP Owner ID</param>
        /// <returns>this instance</returns>
        public InstanceNetworkInterfaceAssociation WithIpOwnerId(string ipOwnerId)
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
    }
}
