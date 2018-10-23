/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ProvisionByoipCidr operation.
    /// Provisions an address range for use with your AWS resources through bring your own
    /// IP addresses (BYOIP) and creates a corresponding address pool. After the address range
    /// is provisioned, it is ready to be advertised using <a>AdvertiseByoipCidr</a>.
    /// 
    ///  
    /// <para>
    /// AWS verifies that you own the address range and are authorized to advertise it. You
    /// must ensure that the address range is registered to you and that you created an RPKI
    /// ROA to authorize Amazon ASNs 16509 and 14618 to advertise the address range. For more
    /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-byoip.html">Bring
    /// Your Own IP Addresses (BYOIP)</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Provisioning an address range is an asynchronous operation, so the call returns immediately,
    /// but the address range is not ready to use until its status changes from <code>pending-provision</code>
    /// to <code>provisioned</code>. To monitor the status of an address range, use <a>DescribeByoipCidrs</a>.
    /// To allocate an Elastic IP address from your address pool, use <a>AllocateAddress</a>
    /// with either the specific address from the address pool or the ID of the address pool.
    /// </para>
    /// </summary>
    public partial class ProvisionByoipCidrRequest : AmazonEC2Request
    {
        private string _cidr;
        private CidrAuthorizationContext _cidrAuthorizationContext;
        private string _description;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The public IPv4 address range, in CIDR notation. The most specific prefix that you
        /// can specify is /24. The address range cannot overlap with another address range that
        /// you've brought to this or another region.
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
        /// A signed document that proves that you are authorized to bring the specified IP address
        /// range to Amazon using BYOIP.
        /// </para>
        /// </summary>
        public CidrAuthorizationContext CidrAuthorizationContext
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the address range and the address pool.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

    }
}