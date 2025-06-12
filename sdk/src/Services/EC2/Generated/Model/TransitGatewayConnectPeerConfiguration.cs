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
    /// Describes the Connect peer details.
    /// </summary>
    public partial class TransitGatewayConnectPeerConfiguration
    {
        private List<TransitGatewayAttachmentBgpConfiguration> _bgpConfigurations = AWSConfigs.InitializeCollections ? new List<TransitGatewayAttachmentBgpConfiguration>() : null;
        private List<string> _insideCidrBlocks = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _peerAddress;
        private ProtocolValue _protocol;
        private string _transitGatewayAddress;

        /// <summary>
        /// Gets and sets the property BgpConfigurations. 
        /// <para>
        /// The BGP configuration details.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TransitGatewayAttachmentBgpConfiguration> BgpConfigurations
        {
            get { return this._bgpConfigurations; }
            set { this._bgpConfigurations = value; }
        }

        // Check to see if BgpConfigurations property is set
        internal bool IsSetBgpConfigurations()
        {
            return this._bgpConfigurations != null && (this._bgpConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InsideCidrBlocks. 
        /// <para>
        /// The range of interior BGP peer IP addresses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InsideCidrBlocks
        {
            get { return this._insideCidrBlocks; }
            set { this._insideCidrBlocks = value; }
        }

        // Check to see if InsideCidrBlocks property is set
        internal bool IsSetInsideCidrBlocks()
        {
            return this._insideCidrBlocks != null && (this._insideCidrBlocks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PeerAddress. 
        /// <para>
        /// The Connect peer IP address on the appliance side of the tunnel.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The tunnel protocol.
        /// </para>
        /// </summary>
        public ProtocolValue Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayAddress. 
        /// <para>
        /// The Connect peer IP address on the transit gateway side of the tunnel.
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

    }
}