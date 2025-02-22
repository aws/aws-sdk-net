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
    /// Container for the parameters to the ReleaseIpamPoolAllocation operation.
    /// Release an allocation within an IPAM pool. The Region you use should be the IPAM pool
    /// locale. The locale is the Amazon Web Services Region where this IPAM pool is available
    /// for allocations. You can only use this action to release manual allocations. To remove
    /// an allocation for a resource without deleting the resource, set its monitored state
    /// to false using <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ModifyIpamResourceCidr.html">ModifyIpamResourceCidr</a>.
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/release-alloc-ipam.html">Release
    /// an allocation</a> in the <i>Amazon VPC IPAM User Guide</i>. 
    /// 
    ///  <note> 
    /// <para>
    /// All EC2 API actions follow an <a href="https://docs.aws.amazon.com/ec2/latest/devguide/eventual-consistency.html">eventual
    /// consistency</a> model.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ReleaseIpamPoolAllocationRequest : AmazonEC2Request
    {
        private string _cidr;
        private bool? _dryRun;
        private string _ipamPoolAllocationId;
        private string _ipamPoolId;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The CIDR of the allocation you want to release.
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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// A check for whether you have the required permissions for the action without actually
        /// making the request and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IpamPoolAllocationId. 
        /// <para>
        /// The ID of the allocation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IpamPoolAllocationId
        {
            get { return this._ipamPoolAllocationId; }
            set { this._ipamPoolAllocationId = value; }
        }

        // Check to see if IpamPoolAllocationId property is set
        internal bool IsSetIpamPoolAllocationId()
        {
            return this._ipamPoolAllocationId != null;
        }

        /// <summary>
        /// Gets and sets the property IpamPoolId. 
        /// <para>
        /// The ID of the IPAM pool which contains the allocation you want to release.
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