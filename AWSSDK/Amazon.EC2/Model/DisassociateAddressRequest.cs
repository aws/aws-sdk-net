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
    /// Disassociates the specified elastic IP address
    /// from the instance to which it is assigned.
    /// </summary>
    /// <remarks>
    /// This is an idempotent operation. If you call it more
    /// than once, Amazon EC2 does not return an error.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class DisassociateAddressRequest : EC2Request
    {    
        private string publicIpField;
        private string associationIdField;

        /// <summary>
        /// IP address that you are disassociating from the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "PublicIp")]
        public string PublicIp
        {
            get { return this.publicIpField; }
            set { this.publicIpField = value; }
        }

        /// <summary>
        /// Sets the IP address that you are disassociating from the instance.
        /// </summary>
        /// <param name="publicIp">IP address that you are disassociating from
        /// the instance.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DisassociateAddressRequest WithPublicIp(string publicIp)
        {
            this.publicIpField = publicIp;
            return this;
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
        /// Association ID corresponding to the VPC elastic IP address 
        /// you want to disassociate.
        ///
        /// Condition: Required for VPC elastic IP addresses
        /// </summary>
        [XmlElementAttribute(ElementName = "AssociationId")]
        public string AssociationId
        {
            get { return this.associationIdField; }
            set { this.associationIdField = value; }
        }

        /// <summary>
        /// Sets the Association ID corresponding to the VPC elastic IP address 
        /// you want to disassociate.
        /// </summary>
        /// <param name="associationId">Association ID corresponding to the VPC elastic IP address 
        /// you want to disassociate.
        ///
        /// Condition: Required for VPC elastic IP addresses</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DisassociateAddressRequest WithAssociationId(string associationId)
        {
            this.associationIdField = associationId;
            return this;
        }

        /// <summary>
        /// Checks if AssociationId property is set
        /// </summary>
        /// <returns>true if AssociationId property is set</returns>
        public bool IsSetAssociationId()
        {
            return this.associationIdField != null;
        }

    }
}
