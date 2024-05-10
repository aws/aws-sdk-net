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
    /// Container for the parameters to the AssociateIpamByoasn operation.
    /// Associates your Autonomous System Number (ASN) with a BYOIP CIDR that you own in the
    /// same Amazon Web Services Region. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/tutorials-byoasn.html">Tutorial:
    /// Bring your ASN to IPAM</a> in the <i>Amazon VPC IPAM guide</i>.
    /// 
    ///  
    /// <para>
    /// After the association succeeds, the ASN is eligible for advertisement. You can view
    /// the association with <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeByoipCidrs.html">DescribeByoipCidrs</a>.
    /// You can advertise the CIDR with <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_AdvertiseByoipCidr.html">AdvertiseByoipCidr</a>.
    /// </para>
    /// </summary>
    public partial class AssociateIpamByoasnRequest : AmazonEC2Request
    {
        private string _asn;
        private string _cidr;

        /// <summary>
        /// Gets and sets the property Asn. 
        /// <para>
        /// A public 2-byte or 4-byte ASN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Asn
        {
            get { return this._asn; }
            set { this._asn = value; }
        }

        // Check to see if Asn property is set
        internal bool IsSetAsn()
        {
            return this._asn != null;
        }

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The BYOIP CIDR you want to associate with an ASN.
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

    }
}