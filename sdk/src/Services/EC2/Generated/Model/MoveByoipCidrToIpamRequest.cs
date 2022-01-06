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
    /// Container for the parameters to the MoveByoipCidrToIpam operation.
    /// Move an BYOIP IPv4 CIDR to IPAM from a public IPv4 pool.
    /// </summary>
    public partial class MoveByoipCidrToIpamRequest : AmazonEC2Request
    {
        private string _cidr;
        private string _ipamPoolId;
        private string _ipamPoolOwner;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The BYOIP CIDR.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property IpamPoolId. 
        /// <para>
        /// The IPAM pool ID.
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
        /// Gets and sets the property IpamPoolOwner. 
        /// <para>
        /// The Amazon Web Services account ID of the owner of the IPAM pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IpamPoolOwner
        {
            get { return this._ipamPoolOwner; }
            set { this._ipamPoolOwner = value; }
        }

        // Check to see if IpamPoolOwner property is set
        internal bool IsSetIpamPoolOwner()
        {
            return this._ipamPoolOwner != null;
        }

    }
}