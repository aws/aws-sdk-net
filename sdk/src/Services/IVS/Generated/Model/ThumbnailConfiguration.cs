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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
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
namespace Amazon.IVS.Model
{
    /// <summary>
    /// An object representing a configuration of thumbnails for recorded video.
    /// </summary>
    public partial class ThumbnailConfiguration
    {
        private RecordingMode _recordingMode;
        private ThumbnailConfigurationResolution _resolution;
        private List<string> _storage = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private long? _targetIntervalSeconds;

        /// <summary>
        /// Gets and sets the property RecordingMode. 
        /// <para>
        /// Thumbnail recording mode. Default: <c>INTERVAL</c>.
        /// </para>
        /// </summary>
        public RecordingMode RecordingMode
        {
            get { return this._recordingMode; }
            set { this._recordingMode = value; }
        }

        // Check to see if RecordingMode property is set
        internal bool IsSetRecordingMode()
        {
            return this._recordingMode != null;
        }

        /// <summary>
        /// Gets and sets the property Resolution. 
        /// <para>
        /// Indicates the desired resolution of recorded thumbnails. Thumbnails are recorded at
        /// the selected resolution if the corresponding rendition is available during the stream;
        /// otherwise, they are recorded at source resolution. For more information about resolution
        /// values and their corresponding height and width dimensions, see <a href="https://docs.aws.amazon.com/ivs/latest/userguide/record-to-s3.html">Auto-Record
        /// to Amazon S3</a>. Default: Null (source resolution is returned).
        /// </para>
        /// </summary>
        public ThumbnailConfigurationResolution Resolution
        {
            get { return this._resolution; }
            set { this._resolution = value; }
        }

        // Check to see if Resolution property is set
        internal bool IsSetResolution()
        {
            return this._resolution != null;
        }

        /// <summary>
        /// Gets and sets the property Storage. 
        /// <para>
        /// Indicates the format in which thumbnails are recorded. <c>SEQUENTIAL</c> records all
        /// generated thumbnails in a serial manner, to the media/thumbnails directory. <c>LATEST</c>
        /// saves the latest thumbnail in media/latest_thumbnail/thumb.jpg and overwrites it at
        /// the interval specified by <c>targetIntervalSeconds</c>. You can enable both <c>SEQUENTIAL</c>
        /// and <c>LATEST</c>. Default: <c>SEQUENTIAL</c>.
        /// </para>
        /// </summary>
        public List<string> Storage
        {
            get { return this._storage; }
            set { this._storage = value; }
        }

        // Check to see if Storage property is set
        internal bool IsSetStorage()
        {
            return this._storage != null && (this._storage.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetIntervalSeconds. 
        /// <para>
        /// The targeted thumbnail-generation interval in seconds. This is configurable (and required)
        /// only if <c>recordingMode</c> is <c>INTERVAL</c>. Default: 60.
        /// </para>
        ///  
        /// <para>
        ///  <b>Important:</b> For the <c>BASIC</c> channel type, or the <c>STANDARD</c> channel
        /// type with multitrack input, setting a value for <c>targetIntervalSeconds</c> does
        /// not guarantee that thumbnails are generated at the specified interval. For thumbnails
        /// to be generated at the <c>targetIntervalSeconds</c> interval, the <c>IDR/Keyframe</c>
        /// value for the input video must be less than the <c>targetIntervalSeconds</c> value.
        /// See <a href="https://docs.aws.amazon.com/ivs/latest/userguide/streaming-config.html">
        /// Amazon IVS Streaming Configuration</a> for information on setting <c>IDR/Keyframe</c>
        /// to the recommended value in video-encoder settings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=60)]
        public long TargetIntervalSeconds
        {
            get { return this._targetIntervalSeconds.GetValueOrDefault(); }
            set { this._targetIntervalSeconds = value; }
        }

        // Check to see if TargetIntervalSeconds property is set
        internal bool IsSetTargetIntervalSeconds()
        {
            return this._targetIntervalSeconds.HasValue; 
        }

    }
}