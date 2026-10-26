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
    /// The configuration settings for a source endpoint that uses SRT in listener mode.
    /// </summary>
    public partial class SrtListenerStandardSourceEndpointConfiguration
    {
        /// <summary>
        /// Gets and sets the property EncryptionPassphrase.
        /// </summary>
        public EndpointEncryptionSecretConfiguration EncryptionPassphrase { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionPassphrase property is set.
        /// </summary>
        internal bool IsSetEncryptionPassphrase() => this.EncryptionPassphrase != null;

        /// <summary>
        /// Gets and sets the property MinimumLatencyMilliseconds. 
        /// <para>
        /// The minimum latency, in milliseconds, for the SRT connection. The valid range is 10
        /// to 10000.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10000)]
        public long? MinimumLatencyMilliseconds { get; set; }

        /// <summary>
        /// Checks to see if the MinimumLatencyMilliseconds property is set.
        /// </summary>
        internal bool IsSetMinimumLatencyMilliseconds() => this.MinimumLatencyMilliseconds.HasValue;

        /// <summary>
        /// Gets and sets the property SourceAddress. 
        /// <para>
        /// The IP address that the source endpoint listens on for incoming connections.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceAddress { get; set; }

        /// <summary>
        /// Checks to see if the SourceAddress property is set.
        /// </summary>
        internal bool IsSetSourceAddress() => this.SourceAddress != null;

        /// <summary>
        /// Gets and sets the property SourceListenerPort. 
        /// <para>
        /// The port that the source endpoint listens on for incoming connections. The valid range
        /// is 1024 to 65535.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1024, Max = 65535)]
        public int? SourceListenerPort { get; set; }

        /// <summary>
        /// Checks to see if the SourceListenerPort property is set.
        /// </summary>
        internal bool IsSetSourceListenerPort() => this.SourceListenerPort.HasValue;

        /// <summary>
        /// Gets and sets the property StreamId. 
        /// <para>
        /// The stream ID that identifies the content for the SRT connection.
        /// </para>
        /// </summary>
        public string StreamId { get; set; }

        /// <summary>
        /// Checks to see if the StreamId property is set.
        /// </summary>
        internal bool IsSetStreamId() => this.StreamId != null;
    }
}
