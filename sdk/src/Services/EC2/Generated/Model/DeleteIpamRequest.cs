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
    /// Container for the parameters to the DeleteIpam operation.
    /// Delete an IPAM. Deleting an IPAM removes all monitored data associated with the IPAM
    /// including the historical data for CIDRs.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/delete-ipam.html">Delete
    /// an IPAM</a> in the <i>Amazon VPC IPAM User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class DeleteIpamRequest : AmazonEC2Request
    {
        private bool? _cascade;
        private bool? _dryRun;
        private string _ipamId;

        /// <summary>
        /// Gets and sets the property Cascade. 
        /// <para>
        /// Enables you to quickly delete an IPAM, private scopes, pools in private scopes, and
        /// any allocations in the pools in private scopes. You cannot delete the IPAM with this
        /// option if there is a pool in your public scope. If you use this option, IPAM does
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Deallocates any CIDRs allocated to VPC resources (such as VPCs) in pools in private
        /// scopes.
        /// </para>
        ///  <note> 
        /// <para>
        /// No VPC resources are deleted as a result of enabling this option. The CIDR associated
        /// with the resource will no longer be allocated from an IPAM pool, but the CIDR itself
        /// will remain unchanged.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// Deprovisions all IPv4 CIDRs provisioned to IPAM pools in private scopes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Deletes all IPAM pools in private scopes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Deletes all non-default private scopes in the IPAM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Deletes the default public and private scopes and the IPAM.
        /// </para>
        ///  </li> </ul>
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