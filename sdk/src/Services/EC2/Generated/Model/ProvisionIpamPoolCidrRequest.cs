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
    /// Container for the parameters to the ProvisionIpamPoolCidr operation.
    /// Provision a CIDR to an IPAM pool. You can use this action to provision new CIDRs to
    /// a top-level pool or to transfer a CIDR from a top-level pool to a pool within it.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="/vpc/latest/ipam/prov-cidr-ipam.html">Provision
    /// CIDRs to pools</a> in the <i>Amazon VPC IPAM User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class ProvisionIpamPoolCidrRequest : AmazonEC2Request
    {
        private string _cidr;
        private IpamCidrAuthorizationContext _cidrAuthorizationContext;
        private string _ipamPoolId;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The CIDR you want to assign to the IPAM pool.
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
        /// Gets and sets the property CidrAuthorizationContext. 
        /// <para>
        /// A signed document that proves that you are authorized to bring a specified IP address
        /// range to Amazon using BYOIP. This option applies to public pools only.
        /// </para>
        /// </summary>
        public IpamCidrAuthorizationContext CidrAuthorizationContext
        {
            get { return this._cidrAuthorizationContext; }
            set { this._cidrAuthorizationContext = value; }
        }

        // Check to see if CidrAuthorizationContext property is set
        internal bool IsSetCidrAuthorizationContext()
        {
            return this._cidrAuthorizationContext != null;
        }

        /// <summary>
        /// Gets and sets the property IpamPoolId. 
        /// <para>
        /// The ID of the IPAM pool to which you want to assign a CIDR.
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