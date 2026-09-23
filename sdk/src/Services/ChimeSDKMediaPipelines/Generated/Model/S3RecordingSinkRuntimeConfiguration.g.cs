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

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// A structure that holds the settings for transmitting media files to the Amazon S3
    /// bucket. If specified, the settings in this structure override any settings in <c>S3RecordingSinkConfiguration</c>.
    /// </summary>
    public partial class S3RecordingSinkRuntimeConfiguration
    {
        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The URI of the S3 bucket used as the sink.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 1024)]
        public string Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property RecordingFileFormat. 
        /// <para>
        /// The file format for the media files sent to the Amazon S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecordingFileFormat RecordingFileFormat { get; set; }

        /// <summary>
        /// Checks to see if the RecordingFileFormat property is set.
        /// </summary>
        internal bool IsSetRecordingFileFormat() => this.RecordingFileFormat != null;
    }
}
