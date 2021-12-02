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
    /// Container for the parameters to the DeletePublicIpv4Pool operation.
    /// Delete a public IPv4 pool. A public IPv4 pool is an EC2 IP address pool required for
    /// the public IPv4 CIDRs that you own and bring to Amazon Web Services to manage with
    /// IPAM. IPv6 addresses you bring to Amazon Web Services, however, use IPAM pools only.
    /// </summary>
    public partial class DeletePublicIpv4PoolRequest : AmazonEC2Request
    {
        private string _poolId;

        /// <summary>
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The ID of the public IPv4 pool you want to delete.
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