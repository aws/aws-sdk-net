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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// The configuration for a source that uses SRT as the connection protocol. In terms
    /// of establishing the connection, MediaLive is always caller and the upstream system
    /// is always the listener. In terms of transmission of the source content, MediaLive
    /// is always the receiver and the upstream system is always the sender.
    /// </summary>
    public partial class SrtCallerSource
    {
        private SrtCallerDecryption _decryption;
        private int? _minimumLatency;
        private string _srtListenerAddress;
        private string _srtListenerPort;
        private string _streamId;

        /// <summary>
        /// Gets and sets the property Decryption.
        /// </summary>
        public SrtCallerDecryption Decryption
        {
            get { return this._decryption; }
            set { this._decryption = value; }
        }

        // Check to see if Decryption property is set
        internal bool IsSetDecryption()
        {
            return this._decryption != null;
        }

        /// <summary>
        /// Gets and sets the property MinimumLatency. The preferred latency (in milliseconds)
        /// for implementing packet loss and recovery. Packet recovery is a key feature of SRT.
        /// </summary>
        public int? MinimumLatency
        {
            get { return this._minimumLatency; }
            set { this._minimumLatency = value; }
        }

        // Check to see if MinimumLatency property is set
        internal bool IsSetMinimumLatency()
        {
            return this._minimumLatency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SrtListenerAddress. The IP address at the upstream system
        /// (the listener) that MediaLive (the caller) connects to.
        /// </summary>
        public string SrtListenerAddress
        {
            get { return this._srtListenerAddress; }
            set { this._srtListenerAddress = value; }
        }

        // Check to see if SrtListenerAddress property is set
        internal bool IsSetSrtListenerAddress()
        {
            return this._srtListenerAddress != null;
        }

        /// <summary>
        /// Gets and sets the property SrtListenerPort. The port at the upstream system (the listener)
        /// that MediaLive (the caller) connects to.
        /// </summary>
        public string SrtListenerPort
        {
            get { return this._srtListenerPort; }
            set { this._srtListenerPort = value; }
        }

        // Check to see if SrtListenerPort property is set
        internal bool IsSetSrtListenerPort()
        {
            return this._srtListenerPort != null;
        }

        /// <summary>
        /// Gets and sets the property StreamId. The stream ID, if the upstream system uses this
        /// identifier.
        /// </summary>
        public string StreamId
        {
            get { return this._streamId; }
            set { this._streamId = value; }
        }

        // Check to see if StreamId property is set
        internal bool IsSetStreamId()
        {
            return this._streamId != null;
        }

    }
}