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
    /// Container for the parameters to the CreateTransitGatewayConnectPeer operation.
    /// Creates a Connect peer for a specified transit gateway Connect attachment between
    /// a transit gateway and an appliance.
    /// 
    ///  
    /// <para>
    /// The peer address and transit gateway address must be the same IP address family (IPv4
    /// or IPv6).
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/tgw/tgw-connect.html#tgw-connect-peer">Connect
    /// peers</a> in the <i>Transit Gateways Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateTransitGatewayConnectPeerRequest : AmazonEC2Request
    {
        private TransitGatewayConnectRequestBgpOptions _bgpOptions;
        private List<string> _insideCidrBlocks = new List<string>();
        private string _peerAddress;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();
        private string _transitGatewayAddress;
        private string _transitGatewayAttachmentId;

        /// <summary>
        /// Gets and sets the property BgpOptions. 
        /// <para>
        /// The BGP options for the Connect peer.
        /// </para>
        /// </summary>
        public TransitGatewayConnectRequestBgpOptions BgpOptions
        {
            get { return this._bgpOptions; }
            set { this._bgpOptions = value; }
        }

        // Check to see if BgpOptions property is set
        internal bool IsSetBgpOptions()
        {
            return this._bgpOptions != null;
        }

        /// <summary>
        /// Gets and sets the property InsideCidrBlocks. 
        /// <para>
        /// The range of inside IP addresses that are used for BGP peering. You must specify a
        /// size /29 IPv4 CIDR block from the <code>169.254.0.0/16</code> range. The first address
        /// from the range must be configured on the appliance as the BGP IP address. You can
        /// also optionally specify a size /125 IPv6 CIDR block from the <code>fd00::/8</code>
        /// range.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> InsideCidrBlocks
        {
            get { return this._insideCidrBlocks; }
            set { this._insideCidrBlocks = value; }
        }

        // Check to see if InsideCidrBlocks property is set
        internal bool IsSetInsideCidrBlocks()
        {
            return this._insideCidrBlocks != null && this._insideCidrBlocks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PeerAddress. 
        /// <para>
        /// The peer IP address (GRE outer IP address) on the appliance side of the Connect peer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PeerAddress
        {
            get { return this._peerAddress; }
            set { this._peerAddress = value; }
        }

        // Check to see if PeerAddress property is set
        internal bool IsSetPeerAddress()
        {
            return this._peerAddress != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the Connect peer.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayAddress. 
        /// <para>
        /// The peer IP address (GRE outer IP address) on the transit gateway side of the Connect
        /// peer, which must be specified from a transit gateway CIDR block. If not specified,
        /// Amazon automatically assigns the first available IP address from the transit gateway
        /// CIDR block.
        /// </para>
        /// </summary>
        public string TransitGatewayAddress
        {
            get { return this._transitGatewayAddress; }
            set { this._transitGatewayAddress = value; }
        }

        // Check to see if TransitGatewayAddress property is set
        internal bool IsSetTransitGatewayAddress()
        {
            return this._transitGatewayAddress != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayAttachmentId. 
        /// <para>
        /// The ID of the Connect attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TransitGatewayAttachmentId
        {
            get { return this._transitGatewayAttachmentId; }
            set { this._transitGatewayAttachmentId = value; }
        }

        // Check to see if TransitGatewayAttachmentId property is set
        internal bool IsSetTransitGatewayAttachmentId()
        {
            return this._transitGatewayAttachmentId != null;
        }

    }
}