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
    /// Container for the parameters to the DeprovisionPublicIpv4PoolCidr operation.
    /// Deprovision a CIDR from a public IPv4 pool.
    /// </summary>
    public partial class DeprovisionPublicIpv4PoolCidrRequest : AmazonEC2Request
    {
        private string _cidr;
        private string _poolId;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The CIDR you want to deprovision from the pool. Enter the CIDR you want to deprovision
        /// with a netmask of <code>/32</code>. You must rerun this command for each IP address
        /// in the CIDR range. If your CIDR is a <code>/24</code>, you will have to run this command
        /// to deprovision each of the 256 IP addresses in the <code>/24</code> CIDR.
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
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The ID of the pool that you want to deprovision the CIDR from.
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