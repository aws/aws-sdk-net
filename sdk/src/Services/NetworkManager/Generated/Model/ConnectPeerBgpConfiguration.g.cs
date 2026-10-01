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
    /// Describes a core network BGP configuration.
    /// </summary>
    public partial class ConnectPeerBgpConfiguration
    {
        /// <summary>
        /// Gets and sets the property CoreNetworkAddress. 
        /// <para>
        /// The address of a core network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string CoreNetworkAddress { get; set; }

        /// <summary>
        /// Checks to see if the CoreNetworkAddress property is set.
        /// </summary>
        internal bool IsSetCoreNetworkAddress() => this.CoreNetworkAddress != null;

        /// <summary>
        /// Gets and sets the property CoreNetworkAsn. 
        /// <para>
        /// The ASN of the Coret Network.
        /// </para>
        /// </summary>
        public long? CoreNetworkAsn { get; set; }

        /// <summary>
        /// Checks to see if the CoreNetworkAsn property is set.
        /// </summary>
        internal bool IsSetCoreNetworkAsn() => this.CoreNetworkAsn.HasValue;

        /// <summary>
        /// Gets and sets the property PeerAddress. 
        /// <para>
        /// The address of a core network Connect peer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string PeerAddress { get; set; }

        /// <summary>
        /// Checks to see if the PeerAddress property is set.
        /// </summary>
        internal bool IsSetPeerAddress() => this.PeerAddress != null;

        /// <summary>
        /// Gets and sets the property PeerAsn. 
        /// <para>
        /// The ASN of the Connect peer.
        /// </para>
        /// </summary>
        public long? PeerAsn { get; set; }

        /// <summary>
        /// Checks to see if the PeerAsn property is set.
        /// </summary>
        internal bool IsSetPeerAsn() => this.PeerAsn.HasValue;
    }
}
