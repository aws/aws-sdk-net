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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The output of the bridge. A network output is delivered to your premises.
    /// </summary>
    public partial class BridgeNetworkOutput
    {
        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        ///  The network output IP address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Checks to see if the IpAddress property is set.
        /// </summary>
        internal bool IsSetIpAddress() => this.IpAddress != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The network output name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkName. 
        /// <para>
        ///  The network output's gateway network name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NetworkName { get; set; }

        /// <summary>
        /// Checks to see if the NetworkName property is set.
        /// </summary>
        internal bool IsSetNetworkName() => this.NetworkName != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        ///  The network output's port.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        ///  The network output protocol.
        /// </para>
        ///  <note> 
        /// <para>
        /// Elemental MediaConnect no longer supports the Fujitsu QoS protocol. This reference
        /// is maintained for legacy purposes only.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public Protocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property Ttl. 
        /// <para>
        ///  The network output TTL.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Ttl { get; set; }

        /// <summary>
        /// Checks to see if the Ttl property is set.
        /// </summary>
        internal bool IsSetTtl() => this.Ttl.HasValue;
    }
}
