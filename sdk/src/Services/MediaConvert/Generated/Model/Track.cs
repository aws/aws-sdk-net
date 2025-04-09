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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Details about each track (video, audio, or data) in the media file.
    /// </summary>
    public partial class Track
    {
        private AudioProperties _audioProperties;
        private Codec _codec;
        private DataProperties _dataProperties;
        private double? _duration;
        private int? _index;
        private TrackType _trackType;
        private VideoProperties _videoProperties;

        /// <summary>
        /// Gets and sets the property AudioProperties. Details about the media file's audio track.
        /// </summary>
        public AudioProperties AudioProperties
        {
            get { return this._audioProperties; }
            set { this._audioProperties = value; }
        }

        // Check to see if AudioProperties property is set
        internal bool IsSetAudioProperties()
        {
            return this._audioProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Codec. The codec of the audio or video track, or caption
        /// format of the data track.
        /// </summary>
        public Codec Codec
        {
            get { return this._codec; }
            set { this._codec = value; }
        }

        // Check to see if Codec property is set
        internal bool IsSetCodec()
        {
            return this._codec != null;
        }

        /// <summary>
        /// Gets and sets the property DataProperties. Details about the media file's data track.
        /// </summary>
        public DataProperties DataProperties
        {
            get { return this._dataProperties; }
            set { this._dataProperties = value; }
        }

        // Check to see if DataProperties property is set
        internal bool IsSetDataProperties()
        {
            return this._dataProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Duration. The duration of the track, in seconds.
        /// </summary>
        public double? Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Index. The unique index number of the track, starting at
        /// 1.
        /// </summary>
        public int? Index
        {
            get { return this._index; }
            set { this._index = value; }
        }

        // Check to see if Index property is set
        internal bool IsSetIndex()
        {
            return this._index.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrackType. The type of track: video, audio, or data.
        /// </summary>
        public TrackType TrackType
        {
            get { return this._trackType; }
            set { this._trackType = value; }
        }

        // Check to see if TrackType property is set
        internal bool IsSetTrackType()
        {
            return this._trackType != null;
        }

        /// <summary>
        /// Gets and sets the property VideoProperties. Details about the media file's video track.
        /// </summary>
        public VideoProperties VideoProperties
        {
            get { return this._videoProperties; }
            set { this._videoProperties = value; }
        }

        // Check to see if VideoProperties property is set
        internal bool IsSetVideoProperties()
        {
            return this._videoProperties != null;
        }

    }
}