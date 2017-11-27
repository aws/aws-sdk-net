/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings for HLS output groups
    /// </summary>
    public partial class HlsSettings
    {
        private string _audioGroupId;
        private string _audioRenditionSets;
        private HlsAudioTrackType _audioTrackType;
        private HlsIFrameOnlyManifest _iFrameOnlyManifest;
        private string _segmentModifier;

        /// <summary>
        /// Gets and sets the property AudioGroupId. Specifies the group to which the audio Rendition
        /// belongs.
        /// </summary>
        public string AudioGroupId
        {
            get { return this._audioGroupId; }
            set { this._audioGroupId = value; }
        }

        // Check to see if AudioGroupId property is set
        internal bool IsSetAudioGroupId()
        {
            return this._audioGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property AudioRenditionSets. List all the audio groups that are
        /// used with the video output stream. Input all the audio GROUP-IDs that are associated
        /// to the video, separate by ','.
        /// </summary>
        public string AudioRenditionSets
        {
            get { return this._audioRenditionSets; }
            set { this._audioRenditionSets = value; }
        }

        // Check to see if AudioRenditionSets property is set
        internal bool IsSetAudioRenditionSets()
        {
            return this._audioRenditionSets != null;
        }

        /// <summary>
        /// Gets and sets the property AudioTrackType.
        /// </summary>
        public HlsAudioTrackType AudioTrackType
        {
            get { return this._audioTrackType; }
            set { this._audioTrackType = value; }
        }

        // Check to see if AudioTrackType property is set
        internal bool IsSetAudioTrackType()
        {
            return this._audioTrackType != null;
        }

        /// <summary>
        /// Gets and sets the property IFrameOnlyManifest.
        /// </summary>
        public HlsIFrameOnlyManifest IFrameOnlyManifest
        {
            get { return this._iFrameOnlyManifest; }
            set { this._iFrameOnlyManifest = value; }
        }

        // Check to see if IFrameOnlyManifest property is set
        internal bool IsSetIFrameOnlyManifest()
        {
            return this._iFrameOnlyManifest != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentModifier. String concatenated to end of segment
        /// filenames. Accepts "Format Identifiers":#format_identifier_parameters.
        /// </summary>
        public string SegmentModifier
        {
            get { return this._segmentModifier; }
            set { this._segmentModifier = value; }
        }

        // Check to see if SegmentModifier property is set
        internal bool IsSetSegmentModifier()
        {
            return this._segmentModifier != null;
        }

    }
}