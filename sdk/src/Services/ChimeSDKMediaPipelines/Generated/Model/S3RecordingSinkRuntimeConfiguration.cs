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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// A structure that holds the settings for transmitting audio and video recordings to
    /// the runtime Amazon S3 bucket.
    /// </summary>
    public partial class S3RecordingSinkRuntimeConfiguration
    {
        private string _destination;
        private RecordingFileFormat _recordingFileFormat;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The URL of the S3 bucket used as the runtime sink.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1024)]
        public string Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property RecordingFileFormat. 
        /// <para>
        /// The file formats for the audio and video files sent to the Amazon S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecordingFileFormat RecordingFileFormat
        {
            get { return this._recordingFileFormat; }
            set { this._recordingFileFormat = value; }
        }

        // Check to see if RecordingFileFormat property is set
        internal bool IsSetRecordingFileFormat()
        {
            return this._recordingFileFormat != null;
        }

    }
}