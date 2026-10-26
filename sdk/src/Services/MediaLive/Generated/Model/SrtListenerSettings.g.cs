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
    /// Settings for SRT Listener input.
    /// </summary>
    public partial class SrtListenerSettings
    {
        /// <summary>
        /// Gets and sets the property Decryption.
        /// </summary>
        public SrtListenerDecryption Decryption { get; set; }

        /// <summary>
        /// Checks to see if the Decryption property is set.
        /// </summary>
        internal bool IsSetDecryption() => this.Decryption != null;

        /// <summary>
        /// Gets and sets the property MinimumLatency. The preferred latency (in milliseconds)
        /// for implementing packet loss and recovery. Range 120-15000.
        /// </summary>
        public int? MinimumLatency { get; set; }

        /// <summary>
        /// Checks to see if the MinimumLatency property is set.
        /// </summary>
        internal bool IsSetMinimumLatency() => this.MinimumLatency.HasValue;

        /// <summary>
        /// Gets and sets the property StreamId. The stream ID, if the upstream system uses this
        /// identifier.
        /// </summary>
        public string StreamId { get; set; }

        /// <summary>
        /// Checks to see if the StreamId property is set.
        /// </summary>
        internal bool IsSetStreamId() => this.StreamId != null;
    }
}
