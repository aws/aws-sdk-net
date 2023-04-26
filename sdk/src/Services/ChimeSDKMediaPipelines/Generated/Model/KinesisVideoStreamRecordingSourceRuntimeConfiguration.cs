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
    /// A structure that contains the runtime settings for recording a Kinesis video stream.
    /// </summary>
    public partial class KinesisVideoStreamRecordingSourceRuntimeConfiguration
    {
        private FragmentSelector _fragmentSelector;
        private List<RecordingStreamConfiguration> _streams = new List<RecordingStreamConfiguration>();

        /// <summary>
        /// Gets and sets the property FragmentSelector. 
        /// <para>
        /// Describes the timestamp range and timestamp origin of a range of fragments in the
        /// Kinesis video stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FragmentSelector FragmentSelector
        {
            get { return this._fragmentSelector; }
            set { this._fragmentSelector = value; }
        }

        // Check to see if FragmentSelector property is set
        internal bool IsSetFragmentSelector()
        {
            return this._fragmentSelector != null;
        }

        /// <summary>
        /// Gets and sets the property Streams. 
        /// <para>
        /// The stream or streams to be recorded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=2)]
        public List<RecordingStreamConfiguration> Streams
        {
            get { return this._streams; }
            set { this._streams = value; }
        }

        // Check to see if Streams property is set
        internal bool IsSetStreams()
        {
            return this._streams != null && this._streams.Count > 0; 
        }

    }
}