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
    /// The configuration settings for a standard source endpoint.
    /// </summary>
    public partial class StandardSourceEndpointConfiguration
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the source endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 164)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol used by the source endpoint. Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RTP</c> – Real-time Transport Protocol.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RIST</c> – Reliable Internet Stream Transport.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SRT_CALLER</c> – Secure Reliable Transport (SRT) in caller mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SRT_LISTENER</c> – Secure Reliable Transport (SRT) in listener mode.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SourceEndpointProtocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property ProtocolConfiguration. 
        /// <para>
        /// The protocol configuration for the source endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StandardSourceEndpointProtocolConfiguration ProtocolConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProtocolConfiguration property is set.
        /// </summary>
        internal bool IsSetProtocolConfiguration() => this.ProtocolConfiguration != null;

        /// <summary>
        /// Gets and sets the property SourceNetworkingConfiguration. 
        /// <para>
        /// The networking configuration for the source endpoint, which determines whether it
        /// is publicly accessible or in a virtual private cloud (VPC).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StandardSourceEndpointNetworkingConfiguration SourceNetworkingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SourceNetworkingConfiguration property is set.
        /// </summary>
        internal bool IsSetSourceNetworkingConfiguration() => this.SourceNetworkingConfiguration != null;

        /// <summary>
        /// Gets and sets the property SourceNetworkingType. 
        /// <para>
        /// The networking type of the source endpoint. Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PUBLIC</c> – The source endpoint is publicly accessible.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VPC</c> – The source endpoint is in a virtual private cloud (VPC).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SourceEndpointNetworkingType SourceNetworkingType { get; set; }

        /// <summary>
        /// Checks to see if the SourceNetworkingType property is set.
        /// </summary>
        internal bool IsSetSourceNetworkingType() => this.SourceNetworkingType != null;
    }
}
