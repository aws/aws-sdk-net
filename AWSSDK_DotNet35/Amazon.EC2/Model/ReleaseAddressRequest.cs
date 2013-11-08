/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ReleaseAddress operation.
    /// <para> The ReleaseAddress operation releases an elastic IP address associated with your account. </para> <para><b>NOTE:</b> Releasing an IP
    /// address automatically disassociates it from any instance with which it is associated. For more information, see DisassociateAddress. </para>
    /// <para><b>IMPORTANT:</b> After releasing an elastic IP address, it is released to the IP address pool and might no longer be available to
    /// your account. Make sure to update your DNS records and any servers or devices that communicate with the address. If you run this operation
    /// on an elastic IP address that is already released, the address might be assigned to another account which will cause Amazon EC2 to return an
    /// error. </para>
    /// </summary>
    public partial class ReleaseAddressRequest : AmazonEC2Request
    {
        private string publicIp;
        private string allocationId;


        /// <summary>
        /// The elastic IP address that you are releasing from your account.
        ///  
        /// </summary>
        public string PublicIp
        {
            get { return this.publicIp; }
            set { this.publicIp = value; }
        }

        // Check to see if PublicIp property is set
        internal bool IsSetPublicIp()
        {
            return this.publicIp != null;
        }

        /// <summary>
        /// The allocation ID that AWS provided when you allocated the address for use with Amazon VPC.
        ///  
        /// </summary>
        public string AllocationId
        {
            get { return this.allocationId; }
            set { this.allocationId = value; }
        }

        // Check to see if AllocationId property is set
        internal bool IsSetAllocationId()
        {
            return this.allocationId != null;
        }

    }
}
    
