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
    /// Container for the parameters to the ProvisionIpamByoasn operation.
    /// Provisions your Autonomous System Number (ASN) for use in your Amazon Web Services
    /// account. This action requires authorization context for Amazon to bring the ASN to
    /// an Amazon Web Services account. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/tutorials-byoasn.html">Tutorial:
    /// Bring your ASN to IPAM</a> in the <i>Amazon VPC IPAM guide</i>.
    /// </summary>
    public partial class ProvisionIpamByoasnRequest : AmazonEC2Request
    {
        private string _asn;
        private AsnAuthorizationContext _asnAuthorizationContext;
        private string _ipamId;

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
        /// Gets and sets the property AsnAuthorizationContext. 
        /// <para>
        /// An ASN authorization context.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AsnAuthorizationContext AsnAuthorizationContext
        {
            get { return this._asnAuthorizationContext; }
            set { this._asnAuthorizationContext = value; }
        }

        // Check to see if AsnAuthorizationContext property is set
        internal bool IsSetAsnAuthorizationContext()
        {
            return this._asnAuthorizationContext != null;
        }

        /// <summary>
        /// Gets and sets the property IpamId. 
        /// <para>
        /// An IPAM ID.
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