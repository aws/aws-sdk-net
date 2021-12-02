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
    /// A CIDR provisioned to an IPAM pool.
    /// </summary>
    public partial class IpamPoolCidr
    {
        private string _cidr;
        private IpamPoolCidrFailureReason _failureReason;
        private IpamPoolCidrState _state;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The CIDR provisioned to the IPAM pool. A CIDR is a representation of an IP address
        /// and its associated network mask (or netmask) and refers to a range of IP addresses.
        /// An IPv4 CIDR example is <code>10.24.34.0/23</code>. An IPv6 CIDR example is <code>2001:DB8::/32</code>.
        /// </para>
        /// </summary>
        public string Cidr
        {
            get { return this._cidr; }
            set { this._cidr = value; }
        }

        // Check to see if Cidr property is set
        internal bool IsSetCidr()
        {
            return this._cidr != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// Details related to why an IPAM pool CIDR failed to be provisioned.
        /// </para>
        /// </summary>
        public IpamPoolCidrFailureReason FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the CIDR.
        /// </para>
        /// </summary>
        public IpamPoolCidrState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}