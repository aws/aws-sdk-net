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
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Allocate Address Result
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class AllocateAddressResult
    {    
        private string domainField;
        private string allocationIdField;
        private string publicIpField;

        /// <summary>
        /// Gets and sets the Domain property.
        /// Whether this elastic IP address is for instances in EC2 (i.e., standard)
        /// or instances in a VPC.
        /// </summary>
        [XmlElementAttribute(ElementName = "Domain")]
        public string Domain
        {
            get { return this.domainField; }
            set { this.domainField = value; }
        }

        /// <summary>
        /// Checks if Domain property is set
        /// </summary>
        /// <returns>true if Domain property is set</returns>
        public bool IsSetDomain()
        {
            return this.domainField != null;
        }

        /// <summary>
        /// Gets and sets the AllocationId property.
        /// ID that AWS assigns to represent the allocation of the address for
        /// use with Amazon VPC. Returned only for VPC elastic IP addresses.
        /// </summary>
        [XmlElementAttribute(ElementName = "AllocationId")]
        public string AllocationId
        {
            get { return this.allocationIdField; }
            set { this.allocationIdField = value; }
        }

        /// <summary>
        /// Checks if AllocationId property is set
        /// </summary>
        /// <returns>true if AllocationId property is set</returns>
        public bool IsSetAllocationId()
        {
            return this.allocationIdField != null;
        }

        /// <summary>
        /// Gets and sets the PublicIp property.
        /// IP address for use with your account.
        /// </summary>
        [XmlElementAttribute(ElementName = "PublicIp")]
        public string PublicIp
        {
            get { return this.publicIpField; }
            set { this.publicIpField = value; }
        }

        /// <summary>
        /// Checks if PublicIp property is set
        /// </summary>
        /// <returns>true if PublicIp property is set</returns>
        public bool IsSetPublicIp()
        {
            return this.publicIpField != null;
        }

        /// <summary>
        /// XML Representation of this object
        /// </summary>
        /// <returns>XML String</returns>
        public string ToXML()
        {
            StringBuilder xml = new StringBuilder(1024);
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(this.GetType());
            using (StringWriter sw = new StringWriter(xml))
            {
                serializer.Serialize(sw, this);
            }
            return xml.ToString();
        }

        /// <summary>
        /// String Representation of this object. Overrides Object.ToString()
        /// </summary>
        /// <returns>This object as a string</returns>
        public override string ToString()
        {
            return this.ToXML();
        }
    }
}
