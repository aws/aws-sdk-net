/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// Releases the specified Elastic IP address.
    /// 
    ///  
    /// <para>
    /// After releasing an Elastic IP address, it is released to the IP address pool and might
    /// be unavailable to you. Be sure to update your DNS records and any servers or devices
    /// that communicate with the address. If you attempt to release an Elastic IP address
    /// that you already released, you'll get an <code>AuthFailure</code> error if the address
    /// is already allocated to another AWS account.
    /// </para>
    ///  
    /// <para>
    /// [EC2-Classic, default VPC] Releasing an Elastic IP address automatically disassociates
    /// it from any instance that it's associated with. To disassociate an Elastic IP address
    /// without releasing it, use <a>DisassociateAddress</a>.
    /// </para>
    ///  
    /// <para>
    /// [Nondefault VPC] You must use <a>DisassociateAddress</a> to disassociate the Elastic
    /// IP address before you try to release it. Otherwise, Amazon EC2 returns an error (<code>InvalidIPAddress.InUse</code>).
    /// </para>
    /// </summary>
    public partial class ReleaseAddressRequest : AmazonEC2Request
    {
        private string _allocationId;
        private string _publicIp;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ReleaseAddressRequest() { }

        /// <summary>
        /// Instantiates ReleaseAddressRequest with the parameterized properties
        /// </summary>
        /// <param name="publicIp">[EC2-Classic] The Elastic IP address. Required for EC2-Classic.</param>
        public ReleaseAddressRequest(string publicIp)
        {
            _publicIp = publicIp;
        }

        /// <summary>
        /// Gets and sets the property AllocationId. 
        /// <para>
        /// [EC2-VPC] The allocation ID. Required for EC2-VPC.
        /// </para>
        /// </summary>
        public string AllocationId
        {
            get { return this._allocationId; }
            set { this._allocationId = value; }
        }

        // Check to see if AllocationId property is set
        internal bool IsSetAllocationId()
        {
            return this._allocationId != null;
        }

        /// <summary>
        /// Gets and sets the property PublicIp. 
        /// <para>
        /// [EC2-Classic] The Elastic IP address. Required for EC2-Classic.
        /// </para>
        /// </summary>
        public string PublicIp
        {
            get { return this._publicIp; }
            set { this._publicIp = value; }
        }

        // Check to see if PublicIp property is set
        internal bool IsSetPublicIp()
        {
            return this._publicIp != null;
        }

    }
}