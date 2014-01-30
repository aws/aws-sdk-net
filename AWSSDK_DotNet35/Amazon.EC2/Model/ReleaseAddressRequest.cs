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
    /// <para>Releases the specified Elastic IP address.</para> <para>After releasing an Elastic IP address, it is released to the IP address pool
    /// and might be unavailable to you. Be sure to update your DNS records and any servers or devices that communicate with the address. If you
    /// attempt to release an Elastic IP address that you already released, you'll get an <c>AuthFailure</c> error if the address is already
    /// allocated to another AWS account.</para> <para>[EC2-Classic, default VPC] Releasing an Elastic IP address automatically disassociates it
    /// from any instance that it's associated with. To disassociate an Elastic IP address without releasing it, use DisassociateAddress.</para>
    /// <para>[Nondefault VPC] You must use the DisassociateAddress to disassociate the Elastic IP address before you try to release it. Otherwise,
    /// Amazon EC2 returns an error ( <c>InvalidIPAddress.InUse</c> ).</para>
    /// </summary>
    public partial class ReleaseAddressRequest : AmazonEC2Request
    {
        private string publicIp;
        private string allocationId;


        /// <summary>
        /// [EC2-Classic] The Elastic IP address.
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
        /// [EC2-VPC] The allocation ID.
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
    
