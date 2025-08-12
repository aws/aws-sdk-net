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
    /// Container for the parameters to the AdvertiseByoipCidr operation.
    /// Advertises an IPv4 or IPv6 address range that is provisioned for use with your Amazon
    /// Web Services resources through bring your own IP addresses (BYOIP).
    /// 
    ///  
    /// <para>
    /// You can perform this operation at most once every 10 seconds, even if you specify
    /// different address ranges each time.
    /// </para>
    ///  
    /// <para>
    /// We recommend that you stop advertising the BYOIP CIDR from other locations when you
    /// advertise it from Amazon Web Services. To minimize down time, you can configure your
    /// Amazon Web Services resources to use an address from a BYOIP CIDR before it is advertised,
    /// and then simultaneously stop advertising it from the current location and start advertising
    /// it through Amazon Web Services.
    /// </para>
    ///  
    /// <para>
    /// It can take a few minutes before traffic to the specified addresses starts routing
    /// to Amazon Web Services because of BGP propagation delays.
    /// </para>
    /// </summary>
    public partial class AdvertiseByoipCidrRequest : AmazonEC2Request
    {
        private string _asn;
        private string _cidr;
        private bool? _dryRun;
        private string _networkBorderGroup;

        /// <summary>
        /// Gets and sets the property Asn. 
        /// <para>
        /// The public 2-byte or 4-byte ASN that you want to advertise.
        /// </para>
        /// </summary>
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
        /// The address range, in CIDR notation. This must be the exact range that you provisioned.
        /// You can't advertise only a portion of the provisioned range.
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
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
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
        /// Gets and sets the property NetworkBorderGroup. 
        /// <para>
        /// If you have <a href="https://docs.aws.amazon.com/local-zones/latest/ug/how-local-zones-work.html">Local
        /// Zones</a> enabled, you can choose a network border group for Local Zones when you
        /// provision and advertise a BYOIPv4 CIDR. Choose the network border group carefully
        /// as the EIP and the Amazon Web Services resource it is associated with must reside
        /// in the same network border group.
        /// </para>
        ///  
        /// <para>
        /// You can provision BYOIP address ranges to and advertise them in the following Local
        /// Zone network border groups:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// us-east-1-dfw-2
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// us-west-2-lax-1
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// us-west-2-phx-2
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// You cannot provision or advertise BYOIPv6 address ranges in Local Zones at this time.
        /// </para>
        ///  </note>
        /// </summary>
        public string NetworkBorderGroup
        {
            get { return this._networkBorderGroup; }
            set { this._networkBorderGroup = value; }
        }

        // Check to see if NetworkBorderGroup property is set
        internal bool IsSetNetworkBorderGroup()
        {
            return this._networkBorderGroup != null;
        }

    }
}