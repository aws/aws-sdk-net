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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteIpamPool operation.
    /// Delete an IPAM pool.
    /// 
    ///  <note> 
    /// <para>
    /// You cannot delete an IPAM pool if there are allocations in it or CIDRs provisioned
    /// to it. To release allocations, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ReleaseIpamPoolAllocation.html">ReleaseIpamPoolAllocation</a>.
    /// To deprovision pool CIDRs, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DeprovisionIpamPoolCidr.html">DeprovisionIpamPoolCidr</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/delete-pool-ipam.html">Delete
    /// a pool</a> in the <i>Amazon VPC IPAM User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class DeleteIpamPoolRequest : AmazonEC2Request
    {
        private bool? _cascade;
        private string _ipamPoolId;

        /// <summary>
        /// Gets and sets the property Cascade. 
        /// <para>
        /// Enables you to quickly delete an IPAM pool and all resources within that pool, including
        /// provisioned CIDRs, allocations, and other pools.
        /// </para>
        ///  <important> 
        /// <para>
        /// You can only use this option to delete pools in the private scope or pools in the
        /// public scope with a source resource. A source resource is a resource used to provision
        /// CIDRs to a resource planning pool.
        /// </para>
        ///  </important>
        /// </summary>
        public bool? Cascade
        {
            get { return this._cascade; }
            set { this._cascade = value; }
        }

        // Check to see if Cascade property is set
        internal bool IsSetCascade()
        {
            return this._cascade.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IpamPoolId. 
        /// <para>
        /// The ID of the pool to delete.
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

    }
}