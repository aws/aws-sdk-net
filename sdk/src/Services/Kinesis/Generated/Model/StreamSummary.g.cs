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

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// The summary of a stream.
    /// </summary>
    public partial class StreamSummary
    {
        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The ARN of the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string StreamARN { get; set; }

        /// <summary>
        /// Checks to see if the StreamARN property is set.
        /// </summary>
        internal bool IsSetStreamARN() => this.StreamARN != null;

        /// <summary>
        /// Gets and sets the property StreamCreationTimestamp. 
        /// <para>
        /// The timestamp at which the stream was created.
        /// </para>
        /// </summary>
        public DateTime? StreamCreationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StreamCreationTimestamp property is set.
        /// </summary>
        internal bool IsSetStreamCreationTimestamp() => this.StreamCreationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property StreamModeDetails.
        /// </summary>
        public StreamModeDetails StreamModeDetails { get; set; }

        /// <summary>
        /// Checks to see if the StreamModeDetails property is set.
        /// </summary>
        internal bool IsSetStreamModeDetails() => this.StreamModeDetails != null;

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of a stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string StreamName { get; set; }

        /// <summary>
        /// Checks to see if the StreamName property is set.
        /// </summary>
        internal bool IsSetStreamName() => this.StreamName != null;

        /// <summary>
        /// Gets and sets the property StreamStatus. 
        /// <para>
        /// The status of the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StreamStatus StreamStatus { get; set; }

        /// <summary>
        /// Checks to see if the StreamStatus property is set.
        /// </summary>
        internal bool IsSetStreamStatus() => this.StreamStatus != null;
    }
}
