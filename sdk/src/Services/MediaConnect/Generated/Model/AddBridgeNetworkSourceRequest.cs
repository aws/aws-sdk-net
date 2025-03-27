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
    /// Add a network source to an existing bridge.
    /// </summary>
    public partial class AddBridgeNetworkSourceRequest
    {
        private string _multicastIp;
        private MulticastSourceSettings _multicastSourceSettings;
        private string _name;
        private string _networkName;
        private int? _port;
        private Protocol _protocol;

        /// <summary>
        /// Gets and sets the property MulticastIp. 
        /// <para>
        ///  The network source multicast IP.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MulticastIp
        {
            get { return this._multicastIp; }
            set { this._multicastIp = value; }
        }

        // Check to see if MulticastIp property is set
        internal bool IsSetMulticastIp()
        {
            return this._multicastIp != null;
        }

        /// <summary>
        /// Gets and sets the property MulticastSourceSettings. 
        /// <para>
        ///  The settings related to the multicast source. 
        /// </para>
        /// </summary>
        public MulticastSourceSettings MulticastSourceSettings
        {
            get { return this._multicastSourceSettings; }
            set { this._multicastSourceSettings = value; }
        }

        // Check to see if MulticastSourceSettings property is set
        internal bool IsSetMulticastSourceSettings()
        {
            return this._multicastSourceSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the network source. This name is used to reference the source and must
        /// be unique among sources in this bridge.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkName. 
        /// <para>
        ///  The network source's gateway network name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NetworkName
        {
            get { return this._networkName; }
            set { this._networkName = value; }
        }

        // Check to see if NetworkName property is set
        internal bool IsSetNetworkName()
        {
            return this._networkName != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        ///  The network source port.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        ///  The network source protocol.
        /// </para>
        ///  <note> 
        /// <para>
        /// Elemental MediaConnect no longer supports the Fujitsu QoS protocol. This reference
        /// is maintained for legacy purposes only.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public Protocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

    }
}