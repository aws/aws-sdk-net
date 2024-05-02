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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
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
namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// The segment configuration, including the segment name, duration, and other configuration
    /// values.
    /// </summary>
    public partial class Segment
    {
        private Encryption _encryption;
        private bool? _includeIframeOnlyStreams;
        private Scte _scte;
        private int? _segmentDurationSeconds;
        private string _segmentName;
        private bool? _tsIncludeDvbSubtitles;
        private bool? _tsUseAudioRenditionGroup;

        /// <summary>
        /// Gets and sets the property Encryption.
        /// </summary>
        public Encryption Encryption
        {
            get { return this._encryption; }
            set { this._encryption = value; }
        }

        // Check to see if Encryption property is set
        internal bool IsSetEncryption()
        {
            return this._encryption != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeIframeOnlyStreams. 
        /// <para>
        /// When selected, the stream set includes an additional I-frame only stream, along with
        /// the other tracks. If false, this extra stream is not included. MediaPackage generates
        /// an I-frame only stream from the first rendition in the manifest. The service inserts
        /// EXT-I-FRAMES-ONLY tags in the output manifest, and then generates and includes an
        /// I-frames only playlist in the stream. This playlist permits player functionality like
        /// fast forward and rewind.
        /// </para>
        /// </summary>
        public bool? IncludeIframeOnlyStreams
        {
            get { return this._includeIframeOnlyStreams; }
            set { this._includeIframeOnlyStreams = value; }
        }

        // Check to see if IncludeIframeOnlyStreams property is set
        internal bool IsSetIncludeIframeOnlyStreams()
        {
            return this._includeIframeOnlyStreams.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Scte. 
        /// <para>
        /// The SCTE configuration options in the segment settings.
        /// </para>
        /// </summary>
        public Scte Scte
        {
            get { return this._scte; }
            set { this._scte = value; }
        }

        // Check to see if Scte property is set
        internal bool IsSetScte()
        {
            return this._scte != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentDurationSeconds. 
        /// <para>
        /// The duration (in seconds) of each segment. Enter a value equal to, or a multiple of,
        /// the input segment duration. If the value that you enter is different from the input
        /// segment duration, MediaPackage rounds segments to the nearest multiple of the input
        /// segment duration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=30)]
        public int? SegmentDurationSeconds
        {
            get { return this._segmentDurationSeconds; }
            set { this._segmentDurationSeconds = value; }
        }

        // Check to see if SegmentDurationSeconds property is set
        internal bool IsSetSegmentDurationSeconds()
        {
            return this._segmentDurationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SegmentName. 
        /// <para>
        /// The name that describes the segment. The name is the base name of the segment used
        /// in all content manifests inside of the endpoint. You can't use spaces in the name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string SegmentName
        {
            get { return this._segmentName; }
            set { this._segmentName = value; }
        }

        // Check to see if SegmentName property is set
        internal bool IsSetSegmentName()
        {
            return this._segmentName != null;
        }

        /// <summary>
        /// Gets and sets the property TsIncludeDvbSubtitles. 
        /// <para>
        /// By default, MediaPackage excludes all digital video broadcasting (DVB) subtitles from
        /// the output. When selected, MediaPackage passes through DVB subtitles into the output.
        /// </para>
        /// </summary>
        public bool? TsIncludeDvbSubtitles
        {
            get { return this._tsIncludeDvbSubtitles; }
            set { this._tsIncludeDvbSubtitles = value; }
        }

        // Check to see if TsIncludeDvbSubtitles property is set
        internal bool IsSetTsIncludeDvbSubtitles()
        {
            return this._tsIncludeDvbSubtitles.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TsUseAudioRenditionGroup. 
        /// <para>
        /// When selected, MediaPackage bundles all audio tracks in a rendition group. All other
        /// tracks in the stream can be used with any audio rendition from the group.
        /// </para>
        /// </summary>
        public bool? TsUseAudioRenditionGroup
        {
            get { return this._tsUseAudioRenditionGroup; }
            set { this._tsUseAudioRenditionGroup = value; }
        }

        // Check to see if TsUseAudioRenditionGroup property is set
        internal bool IsSetTsUseAudioRenditionGroup()
        {
            return this._tsUseAudioRenditionGroup.HasValue; 
        }

    }
}