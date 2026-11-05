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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Configures the connection for a source that uses SRT as the connection protocol. In
    /// terms of establishing the connection, MediaLive is always the caller and the upstream
    /// system is always the listener. In terms of transmission of the source content, MediaLive
    /// is always the receiver and the upstream system is always the sender.
    /// </summary>
    public partial class SrtCallerSourceRequest
    {
        /// <summary>
        /// Gets and sets the property Decryption.
        /// </summary>
        public SrtCallerDecryptionRequest Decryption { get; set; }

        /// <summary>
        /// Checks to see if the Decryption property is set.
        /// </summary>
        internal bool IsSetDecryption() => this.Decryption != null;

        /// <summary>
        /// Gets and sets the property MinimumLatency. The preferred latency (in milliseconds)
        /// for implementing packet loss and recovery. Packet recovery is a key feature of SRT.
        /// Obtain this value from the operator at the upstream system.
        /// </summary>
        public int? MinimumLatency { get; set; }

        /// <summary>
        /// Checks to see if the MinimumLatency property is set.
        /// </summary>
        internal bool IsSetMinimumLatency() => this.MinimumLatency.HasValue;

        /// <summary>
        /// Gets and sets the property SrtListenerAddress. The IP address at the upstream system
        /// (the listener) that MediaLive (the caller) will connect to.
        /// </summary>
        public string SrtListenerAddress { get; set; }

        /// <summary>
        /// Checks to see if the SrtListenerAddress property is set.
        /// </summary>
        internal bool IsSetSrtListenerAddress() => this.SrtListenerAddress != null;

        /// <summary>
        /// Gets and sets the property SrtListenerPort. The port at the upstream system (the listener)
        /// that MediaLive (the caller) will connect to.
        /// </summary>
        public string SrtListenerPort { get; set; }

        /// <summary>
        /// Checks to see if the SrtListenerPort property is set.
        /// </summary>
        internal bool IsSetSrtListenerPort() => this.SrtListenerPort != null;

        /// <summary>
        /// Gets and sets the property StreamId. This value is required if the upstream system
        /// uses this identifier because without it, the SRT handshake between MediaLive (the
        /// caller) and the upstream system (the listener) might fail.
        /// </summary>
        public string StreamId { get; set; }

        /// <summary>
        /// Checks to see if the StreamId property is set.
        /// </summary>
        internal bool IsSetStreamId() => this.StreamId != null;
    }
}
