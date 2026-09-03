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
    /// The configuration settings for a standard router output, including the protocol, protocol-specific
    /// configuration, network interface, and availability zone.
    /// </summary>
    public partial class StandardRouterOutputConfiguration
    {
        /// <summary>
        /// Gets and sets the property NetworkInterfaceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the network interface associated with the standard
        /// router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NetworkInterfaceArn { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceArn property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceArn() => this.NetworkInterfaceArn != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol used by the standard router output.
        /// </para>
        /// </summary>
        public RouterOutputProtocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property ProtocolConfiguration. 
        /// <para>
        /// The configuration settings for the protocol used by the standard router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouterOutputProtocolConfiguration ProtocolConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProtocolConfiguration property is set.
        /// </summary>
        internal bool IsSetProtocolConfiguration() => this.ProtocolConfiguration != null;
    }
}
