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
    /// The configuration settings for a router output using the SRT (Secure Reliable Transport)
    /// protocol in caller mode, including the destination address and port, minimum latency,
    /// stream ID, and encryption key configuration.
    /// </summary>
    public partial class SrtCallerRouterOutputConfiguration
    {
        /// <summary>
        /// Gets and sets the property DestinationAddress. 
        /// <para>
        /// The destination IP address for the SRT protocol in caller mode.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DestinationAddress { get; set; }

        /// <summary>
        /// Checks to see if the DestinationAddress property is set.
        /// </summary>
        internal bool IsSetDestinationAddress() => this.DestinationAddress != null;

        /// <summary>
        /// Gets and sets the property DestinationPort. 
        /// <para>
        /// The destination port number for the SRT protocol in caller mode.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1024, Max = 65535)]
        public int? DestinationPort { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPort property is set.
        /// </summary>
        internal bool IsSetDestinationPort() => this.DestinationPort.HasValue;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// Defines the encryption settings for an SRT caller output, including the encryption
        /// key configuration and associated parameters.
        /// </para>
        /// </summary>
        public SrtEncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property MinimumLatencyMilliseconds. 
        /// <para>
        /// The minimum latency in milliseconds for the SRT protocol in caller mode.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10000)]
        public long? MinimumLatencyMilliseconds { get; set; }

        /// <summary>
        /// Checks to see if the MinimumLatencyMilliseconds property is set.
        /// </summary>
        internal bool IsSetMinimumLatencyMilliseconds() => this.MinimumLatencyMilliseconds.HasValue;

        /// <summary>
        /// Gets and sets the property StreamId. 
        /// <para>
        /// The stream ID for the SRT protocol in caller mode.
        /// </para>
        /// </summary>
        public string StreamId { get; set; }

        /// <summary>
        /// Checks to see if the StreamId property is set.
        /// </summary>
        internal bool IsSetStreamId() => this.StreamId != null;
    }
}
