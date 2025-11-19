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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
        private string _networkInterfaceArn;
        private RouterOutputProtocol _protocol;
        private RouterOutputProtocolConfiguration _protocolConfiguration;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the network interface associated with the standard
        /// router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NetworkInterfaceArn
        {
            get { return this._networkInterfaceArn; }
            set { this._networkInterfaceArn = value; }
        }

        // Check to see if NetworkInterfaceArn property is set
        internal bool IsSetNetworkInterfaceArn()
        {
            return this._networkInterfaceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol used by the standard router output.
        /// </para>
        /// </summary>
        public RouterOutputProtocol Protocol
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
        /// Gets and sets the property ProtocolConfiguration. 
        /// <para>
        /// The configuration settings for the protocol used by the standard router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouterOutputProtocolConfiguration ProtocolConfiguration
        {
            get { return this._protocolConfiguration; }
            set { this._protocolConfiguration = value; }
        }

        // Check to see if ProtocolConfiguration property is set
        internal bool IsSetProtocolConfiguration()
        {
            return this._protocolConfiguration != null;
        }

    }
}