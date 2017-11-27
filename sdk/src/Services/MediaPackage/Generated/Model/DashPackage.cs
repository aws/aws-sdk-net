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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaPackage.Model
{
    /// <summary>
    /// A Dynamic Adaptive Streaming over HTTP (DASH) packaging configuration.
    /// </summary>
    public partial class DashPackage
    {
        private DashEncryption _encryption;
        private int? _manifestWindowSeconds;
        private int? _minBufferTimeSeconds;
        private int? _minUpdatePeriodSeconds;
        private Profile _profile;
        private int? _segmentDurationSeconds;
        private StreamSelection _streamSelection;
        private int? _suggestedPresentationDelaySeconds;

        /// <summary>
        /// Gets and sets the property Encryption.
        /// </summary>
        public DashEncryption Encryption
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
        /// Gets and sets the property ManifestWindowSeconds. Time window (in seconds) contained
        /// in each manifest.
        /// </summary>
        public int ManifestWindowSeconds
        {
            get { return this._manifestWindowSeconds.GetValueOrDefault(); }
            set { this._manifestWindowSeconds = value; }
        }

        // Check to see if ManifestWindowSeconds property is set
        internal bool IsSetManifestWindowSeconds()
        {
            return this._manifestWindowSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinBufferTimeSeconds. Minimum duration (in seconds) that
        /// a player will buffer media before starting the presentation.
        /// </summary>
        public int MinBufferTimeSeconds
        {
            get { return this._minBufferTimeSeconds.GetValueOrDefault(); }
            set { this._minBufferTimeSeconds = value; }
        }

        // Check to see if MinBufferTimeSeconds property is set
        internal bool IsSetMinBufferTimeSeconds()
        {
            return this._minBufferTimeSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinUpdatePeriodSeconds. Minimum duration (in seconds) between
        /// potential changes to the Dynamic Adaptive Streaming over HTTP (DASH) Media Presentation
        /// Description (MPD).
        /// </summary>
        public int MinUpdatePeriodSeconds
        {
            get { return this._minUpdatePeriodSeconds.GetValueOrDefault(); }
            set { this._minUpdatePeriodSeconds = value; }
        }

        // Check to see if MinUpdatePeriodSeconds property is set
        internal bool IsSetMinUpdatePeriodSeconds()
        {
            return this._minUpdatePeriodSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Profile. The Dynamic Adaptive Streaming over HTTP (DASH)
        /// profile type.  When set to "HBBTV_1_5", HbbTV 1.5 compliant output is enabled.
        /// </summary>
        public Profile Profile
        {
            get { return this._profile; }
            set { this._profile = value; }
        }

        // Check to see if Profile property is set
        internal bool IsSetProfile()
        {
            return this._profile != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentDurationSeconds. Duration (in seconds) of each segment.
        /// Actual segments will berounded to the nearest multiple of the source segment duration.
        /// </summary>
        public int SegmentDurationSeconds
        {
            get { return this._segmentDurationSeconds.GetValueOrDefault(); }
            set { this._segmentDurationSeconds = value; }
        }

        // Check to see if SegmentDurationSeconds property is set
        internal bool IsSetSegmentDurationSeconds()
        {
            return this._segmentDurationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamSelection.
        /// </summary>
        public StreamSelection StreamSelection
        {
            get { return this._streamSelection; }
            set { this._streamSelection = value; }
        }

        // Check to see if StreamSelection property is set
        internal bool IsSetStreamSelection()
        {
            return this._streamSelection != null;
        }

        /// <summary>
        /// Gets and sets the property SuggestedPresentationDelaySeconds. Duration (in seconds)
        /// to delay live content before presentation.
        /// </summary>
        public int SuggestedPresentationDelaySeconds
        {
            get { return this._suggestedPresentationDelaySeconds.GetValueOrDefault(); }
            set { this._suggestedPresentationDelaySeconds = value; }
        }

        // Check to see if SuggestedPresentationDelaySeconds property is set
        internal bool IsSetSuggestedPresentationDelaySeconds()
        {
            return this._suggestedPresentationDelaySeconds.HasValue; 
        }

    }
}