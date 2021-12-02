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
    /// Container for the parameters to the DeleteIpam operation.
    /// Delete an IPAM. Deleting an IPAM removes all monitored data associated with the IPAM
    /// including the historical data for CIDRs.
    /// 
    ///  <note> 
    /// <para>
    /// You cannot delete an IPAM if there are CIDRs provisioned to pools or if there are
    /// allocations in the pools within the IPAM. To deprovision pool CIDRs, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DeprovisionIpamPoolCidr.html">DeprovisionIpamPoolCidr</a>.
    /// To release allocations, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ReleaseIpamPoolAllocation.html">ReleaseIpamPoolAllocation</a>.
    /// 
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information, see <a href="/vpc/latest/ipam/delete-ipam.html">Delete an IPAM</a>
    /// in the <i>Amazon VPC IPAM User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class DeleteIpamRequest : AmazonEC2Request
    {
        private string _ipamId;

        /// <summary>
        /// Gets and sets the property IpamId. 
        /// <para>
        /// The ID of the IPAM to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IpamId
        {
            get { return this._ipamId; }
            set { this._ipamId = value; }
        }

        // Check to see if IpamId property is set
        internal bool IsSetIpamId()
        {
            return this._ipamId != null;
        }

    }
}