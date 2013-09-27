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
    /// Releases an elastic IP address associated with your account.
    /// </summary>
    ///<remarks>
    /// If you run this operation on an elastic IP address that is
    /// already released, the address might be assigned to another
    /// account which will cause Amazon EC2 to return an error.
    ///
    /// Releasing an IP address automatically disassociates it from any
    /// instance with which it is associated. To disassociate an IP
    /// address without releasing it, use the DisassociateAddress
    /// operation.
    ///
    /// After releasing an elastic IP address, it is
    /// released to the IP // address pool and might no longer be
    /// available to your account. Make sure to update your DNS
    /// records and any servers or devices that communicate with
    /// the address.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class ReleaseAddressRequest : EC2Request
    {    
        private string publicIpField;
        private string allocationIdField;

        /// <summary>
        /// The IP address that you are releasing from your account.
        /// </summary>
        [XmlElementAttribute(ElementName = "PublicIp")]
        public string PublicIp
        {
            get { return this.publicIpField; }
            set { this.publicIpField = value; }
        }

        /// <summary>
        /// Sets the IP address that you are releasing from your account.
        /// </summary>
        /// <param name="publicIp">The IP address that you are releasing from
        /// your account.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReleaseAddressRequest WithPublicIp(string publicIp)
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
        /// Address allocation ID.
        /// This value was provided when you allocated the address for use with Amazon VPC.
        /// </summary>
        [XmlElementAttribute(ElementName = "AllocationId")]
        public string AllocationId
        {
            get { return this.allocationIdField; }
            set { this.allocationIdField = value; }
        }

        /// <summary>
        /// Sets the address allocation ID.
        /// </summary>
        /// <param name="allocationId">The allocation ID that AWS provided when you allocated
        /// the address for use with Amazon VPC.
        /// 
        /// Type: String
        /// Default: None
        /// Condition: Required for VPC elastic IP addresses</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReleaseAddressRequest WithAllocationId(string allocationId)
        {
            this.allocationIdField = allocationId;
            return this;
        }

        /// <summary>
        /// Checks if AllocationId property is set
        /// </summary>
        /// <returns>true if AllocationId property is set</returns>
        public bool IsSetAllocationId()
        {
            return this.allocationIdField != null;
        }

    }
}
