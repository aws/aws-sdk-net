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
    /// Container for the parameters to the AllocateAddress operation.
    /// Allocates an Elastic IP address to your AWS account. After you allocate the Elastic
    /// IP address you can associate it with an instance or network interface. After you release
    /// an Elastic IP address, it is released to the IP address pool and can be allocated
    /// to a different AWS account.
    /// 
    ///  
    /// <para>
    /// You can allocate an Elastic IP address from an address pool owned by AWS or from an
    /// address pool created from a public IPv4 address range that you have brought to AWS
    /// for use with your AWS resources using bring your own IP addresses (BYOIP). For more
    /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-byoip.html">Bring
    /// Your Own IP Addresses (BYOIP)</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// [EC2-VPC] If you release an Elastic IP address, you might be able to recover it. You
    /// cannot recover an Elastic IP address that you released after it is allocated to another
    /// AWS account. You cannot recover an Elastic IP address for EC2-Classic. To attempt
    /// to recover an Elastic IP address that you released, specify it in this operation.
    /// </para>
    ///  
    /// <para>
    /// An Elastic IP address is for use either in the EC2-Classic platform or in a VPC. By
    /// default, you can allocate 5 Elastic IP addresses for EC2-Classic per region and 5
    /// Elastic IP addresses for EC2-VPC per region.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
    /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AllocateAddressRequest : AmazonEC2Request
    {
        private string _address;
        private DomainType _domain;
        private string _publicIpv4Pool;

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// [EC2-VPC] The Elastic IP address to recover or an IPv4 address from an address pool.
        /// </para>
        /// </summary>
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Check to see if Address property is set
        internal bool IsSetAddress()
        {
            return this._address != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// Set to <code>vpc</code> to allocate the address for use with instances in a VPC.
        /// </para>
        ///  
        /// <para>
        /// Default: The address is for use with instances in EC2-Classic.
        /// </para>
        /// </summary>
        public DomainType Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property PublicIpv4Pool. 
        /// <para>
        /// The ID of an address pool that you own. Use this parameter to let Amazon EC2 select
        /// an address from the address pool. To specify a specific address from the address pool,
        /// use the <code>Address</code> parameter instead.
        /// </para>
        /// </summary>
        public string PublicIpv4Pool
        {
            get { return this._publicIpv4Pool; }
            set { this._publicIpv4Pool = value; }
        }

        // Check to see if PublicIpv4Pool property is set
        internal bool IsSetPublicIpv4Pool()
        {
            return this._publicIpv4Pool != null;
        }

    }
}