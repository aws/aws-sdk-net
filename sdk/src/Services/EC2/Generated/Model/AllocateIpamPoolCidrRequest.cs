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
    /// Container for the parameters to the AllocateIpamPoolCidr operation.
    /// Allocate a CIDR from an IPAM pool. In IPAM, an allocation is a CIDR assignment from
    /// an IPAM pool to another IPAM pool or to a resource. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/allocate-cidrs-ipam.html">Allocate
    /// CIDRs</a> in the <i>Amazon VPC IPAM User Guide</i>.
    /// 
    ///  <note> 
    /// <para>
    /// This action creates an allocation with strong consistency. The returned CIDR will
    /// not overlap with any other allocations from the same pool.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AllocateIpamPoolCidrRequest : AmazonEC2Request
    {
        private string _cidr;
        private string _clientToken;
        private string _description;
        private List<string> _disallowedCidrs = new List<string>();
        private string _ipamPoolId;
        private int? _netmaskLength;
        private bool? _previewNextCidr;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The CIDR you would like to allocate from the IPAM pool. Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If there is no DefaultNetmaskLength allocation rule set on the pool, you must specify
        /// either the NetmaskLength or the CIDR.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the DefaultNetmaskLength allocation rule is set on the pool, you can specify either
        /// the NetmaskLength or the CIDR and the DefaultNetmaskLength allocation rule will be
        /// ignored.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Possible values: Any available IPv4 or IPv6 CIDR.
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the allocation.
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

        /// <summary>
        /// Gets and sets the property DisallowedCidrs. 
        /// <para>
        /// Exclude a particular CIDR range from being returned by the pool. Disallowed CIDRs
        /// are only allowed if using netmask length for allocation.
        /// </para>
        /// </summary>
        public List<string> DisallowedCidrs
        {
            get { return this._disallowedCidrs; }
            set { this._disallowedCidrs = value; }
        }

        // Check to see if DisallowedCidrs property is set
        internal bool IsSetDisallowedCidrs()
        {
            return this._disallowedCidrs != null && this._disallowedCidrs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IpamPoolId. 
        /// <para>
        /// The ID of the IPAM pool from which you would like to allocate a CIDR.
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
        /// Gets and sets the property NetmaskLength. 
        /// <para>
        /// The netmask length of the CIDR you would like to allocate from the IPAM pool. Note
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If there is no DefaultNetmaskLength allocation rule set on the pool, you must specify
        /// either the NetmaskLength or the CIDR.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the DefaultNetmaskLength allocation rule is set on the pool, you can specify either
        /// the NetmaskLength or the CIDR and the DefaultNetmaskLength allocation rule will be
        /// ignored.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Possible netmask lengths for IPv4 addresses are 0 - 32. Possible netmask lengths for
        /// IPv6 addresses are 0 - 128.
        /// </para>
        /// </summary>
        public int NetmaskLength
        {
            get { return this._netmaskLength.GetValueOrDefault(); }
            set { this._netmaskLength = value; }
        }

        // Check to see if NetmaskLength property is set
        internal bool IsSetNetmaskLength()
        {
            return this._netmaskLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PreviewNextCidr. 
        /// <para>
        /// A preview of the next available CIDR in a pool.
        /// </para>
        /// </summary>
        public bool PreviewNextCidr
        {
            get { return this._previewNextCidr.GetValueOrDefault(); }
            set { this._previewNextCidr = value; }
        }

        // Check to see if PreviewNextCidr property is set
        internal bool IsSetPreviewNextCidr()
        {
            return this._previewNextCidr.HasValue; 
        }

    }
}