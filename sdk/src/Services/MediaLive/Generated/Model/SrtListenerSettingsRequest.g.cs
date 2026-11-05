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
    /// Configuration for SRT Listener input. Encryption is REQUIRED for all SRT Listener
    /// inputs for security reasons. You must provide decryption settings including algorithm
    /// and passphrase secret ARN.
    /// </summary>
    public partial class SrtListenerSettingsRequest
    {
        /// <summary>
        /// Gets and sets the property Decryption.
        /// </summary>
        [AWSProperty(Required = true)]
        public SrtListenerDecryptionRequest Decryption { get; set; }

        /// <summary>
        /// Checks to see if the Decryption property is set.
        /// </summary>
        internal bool IsSetDecryption() => this.Decryption != null;

        /// <summary>
        /// Gets and sets the property MinimumLatency. Required. The preferred latency in milliseconds
        /// for packet loss and recovery. Range 120-15000.
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MinimumLatency { get; set; }

        /// <summary>
        /// Checks to see if the MinimumLatency property is set.
        /// </summary>
        internal bool IsSetMinimumLatency() => this.MinimumLatency.HasValue;

        /// <summary>
        /// Gets and sets the property StreamId. Optional. The stream ID if the upstream system
        /// uses this identifier.
        /// </summary>
        public string StreamId { get; set; }

        /// <summary>
        /// Checks to see if the StreamId property is set.
        /// </summary>
        internal bool IsSetStreamId() => this.StreamId != null;
    }
}
