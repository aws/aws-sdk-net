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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The transport parameters that are associated with an outbound media stream.
    /// </summary>
    public partial class DestinationConfiguration
    {
        private string _destinationIp;
        private int? _destinationPort;
        private Interface _interface;
        private string _outboundIp;

        /// <summary>
        /// Gets and sets the property DestinationIp. The IP address where contents of the media
        /// stream will be sent.
        /// </summary>
        [AWSProperty(Required=true)]
        public string DestinationIp
        {
            get { return this._destinationIp; }
            set { this._destinationIp = value; }
        }

        // Check to see if DestinationIp property is set
        internal bool IsSetDestinationIp()
        {
            return this._destinationIp != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationPort. The port to use when the content of the
        /// media stream is distributed to the output.
        /// </summary>
        [AWSProperty(Required=true)]
        public int DestinationPort
        {
            get { return this._destinationPort.GetValueOrDefault(); }
            set { this._destinationPort = value; }
        }

        // Check to see if DestinationPort property is set
        internal bool IsSetDestinationPort()
        {
            return this._destinationPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Interface. The VPC interface that is used for the media
        /// stream associated with the output.
        /// </summary>
        [AWSProperty(Required=true)]
        public Interface Interface
        {
            get { return this._interface; }
            set { this._interface = value; }
        }

        // Check to see if Interface property is set
        internal bool IsSetInterface()
        {
            return this._interface != null;
        }

        /// <summary>
        /// Gets and sets the property OutboundIp. The IP address that the receiver requires in
        /// order to establish a connection with the flow. This value is represented by the elastic
        /// network interface IP address of the VPC. This field applies only to outputs that use
        /// the CDI or ST 2110 JPEG XS protocol.
        /// </summary>
        [AWSProperty(Required=true)]
        public string OutboundIp
        {
            get { return this._outboundIp; }
            set { this._outboundIp = value; }
        }

        // Check to see if OutboundIp property is set
        internal bool IsSetOutboundIp()
        {
            return this._outboundIp != null;
        }

    }
}