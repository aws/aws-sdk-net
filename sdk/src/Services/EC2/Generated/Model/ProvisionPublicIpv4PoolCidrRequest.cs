/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ProvisionPublicIpv4PoolCidr operation.
    /// Provision a CIDR to a public IPv4 pool.
    /// 
    ///  
    /// <para>
    /// For more information about IPAM, see <a href="/vpc/latest/ipam/what-is-it-ipam.html">What
    /// is IPAM?</a> in the <i>Amazon VPC IPAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ProvisionPublicIpv4PoolCidrRequest : AmazonEC2Request
    {
        private string _ipamPoolId;
        private int? _netmaskLength;
        private string _poolId;

        /// <summary>
        /// Gets and sets the property IpamPoolId. 
        /// <para>
        /// The ID of the IPAM pool you would like to use to allocate this CIDR.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IpamPoolId
        {
            get { return this._ipamPoolId; }
            set { this._ipamPoolId = value; }
        }

        // Check to see if IpamPoolId property is set
        internal bool IsSetIpamPoolId()
        {
            return this._ipamPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property NetmaskLength. 
        /// <para>
        /// The netmask length of the CIDR you would like to allocate to the public IPv4 pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int NetmaskLength
        {
            get { return this._netmaskLength.GetValueOrDefault(); }
            set { this._netmaskLength = value; }
        }

        // Check to see if NetmaskLength property is set
        internal bool IsSetNetmaskLength()
        {
            return this._netmaskLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The ID of the public IPv4 pool you would like to use for this CIDR.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PoolId
        {
            get { return this._poolId; }
            set { this._poolId = value; }
        }

        // Check to see if PoolId property is set
        internal bool IsSetPoolId()
        {
            return this._poolId != null;
        }

    }
}