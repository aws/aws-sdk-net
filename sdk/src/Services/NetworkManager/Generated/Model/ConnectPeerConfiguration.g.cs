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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes a core network Connect peer configuration.
    /// </summary>
    public partial class ConnectPeerConfiguration
    {
        /// <summary>
        /// Gets and sets the property BgpConfigurations. 
        /// <para>
        /// The Connect peer BGP configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConnectPeerBgpConfiguration> BgpConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<ConnectPeerBgpConfiguration>() : null;

        /// <summary>
        /// Checks to see if the BgpConfigurations property is set.
        /// </summary>
        internal bool IsSetBgpConfigurations() => this.BgpConfigurations != null && (this.BgpConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CoreNetworkAddress. 
        /// <para>
        /// The IP address of a core network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string CoreNetworkAddress { get; set; }

        /// <summary>
        /// Checks to see if the CoreNetworkAddress property is set.
        /// </summary>
        internal bool IsSetCoreNetworkAddress() => this.CoreNetworkAddress != null;

        /// <summary>
        /// Gets and sets the property InsideCidrBlocks. 
        /// <para>
        /// The inside IP addresses used for a Connect peer configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InsideCidrBlocks { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InsideCidrBlocks property is set.
        /// </summary>
        internal bool IsSetInsideCidrBlocks() => this.InsideCidrBlocks != null && (this.InsideCidrBlocks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PeerAddress. 
        /// <para>
        /// The IP address of the Connect peer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string PeerAddress { get; set; }

        /// <summary>
        /// Checks to see if the PeerAddress property is set.
        /// </summary>
        internal bool IsSetPeerAddress() => this.PeerAddress != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol used for a Connect peer configuration.
        /// </para>
        /// </summary>
        public TunnelProtocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;
    }
}
