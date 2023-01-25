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
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/prov-cidr-ipam.html">Provision
    /// CIDRs to pools</a> in the <i>Amazon VPC IPAM User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class ProvisionIpamPoolCidrRequest : AmazonEC2Request
    {
        private string _cidr;
        private IpamCidrAuthorizationContext _cidrAuthorizationContext;
        private string _clientToken;
        private string _ipamPoolId;
        private int? _netmaskLength;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The CIDR you want to assign to the IPAM pool. Either "NetmaskLength" or "Cidr" is
        /// required. This value will be null if you specify "NetmaskLength" and will be filled
        /// in during the provisioning process.
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

        /// <summary>
        /// Gets and sets the property NetmaskLength. 
        /// <para>
        /// The netmask length of the CIDR you'd like to provision to a pool. Can be used for
        /// provisioning Amazon-provided IPv6 CIDRs to top-level pools and for provisioning CIDRs
        /// to pools with source pools. Cannot be used to provision BYOIP CIDRs to top-level pools.
        /// Either "NetmaskLength" or "Cidr" is required.
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

    }
}