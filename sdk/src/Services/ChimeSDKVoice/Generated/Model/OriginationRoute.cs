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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// Origination routes define call distribution properties for your SIP hosts to receive
    /// inbound calls using an Amazon Chime SDK Voice Connector. Limit: Ten origination routes
    /// for each Voice Connector.
    /// 
    ///  <note> 
    /// <para>
    /// The parameters listed below are not required, but you must use at least one.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class OriginationRoute
    {
        private string _host;
        private int? _port;
        private int? _priority;
        private OriginationRouteProtocol _protocol;
        private int? _weight;

        /// <summary>
        /// Gets and sets the property Host. 
        /// <para>
        /// The FQDN or IP address to contact for origination traffic.
        /// </para>
        /// </summary>
        public string Host
        {
            get { return this._host; }
            set { this._host = value; }
        }

        // Check to see if Host property is set
        internal bool IsSetHost()
        {
            return this._host != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The designated origination route port. Defaults to 5060.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority associated with the host, with 1 being the highest priority. Higher priority
        /// hosts are attempted first.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int Priority
        {
            get { return this._priority.GetValueOrDefault(); }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol to use for the origination route. Encryption-enabled Amazon Chime SDK
        /// Voice Connectors use TCP protocol by default.
        /// </para>
        /// </summary>
        public OriginationRouteProtocol Protocol
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
        /// Gets and sets the property Weight. 
        /// <para>
        /// The weight assigned to an origination route. When hosts have equal priority, calls
        /// are distributed between them based on their relative weights.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int Weight
        {
            get { return this._weight.GetValueOrDefault(); }
            set { this._weight = value; }
        }

        // Check to see if Weight property is set
        internal bool IsSetWeight()
        {
            return this._weight.HasValue; 
        }

    }
}