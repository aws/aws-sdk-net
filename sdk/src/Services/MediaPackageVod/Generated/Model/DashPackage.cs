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
 * Do not modify this file. This file is generated from the mediapackage-vod-2018-11-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaPackageVod.Model
{
    /// <summary>
    /// A Dynamic Adaptive Streaming over HTTP (DASH) packaging configuration.
    /// </summary>
    public partial class DashPackage
    {
        private List<DashManifest> _dashManifests = new List<DashManifest>();
        private DashEncryption _encryption;
        private List<string> _periodTriggers = new List<string>();
        private int? _segmentDurationSeconds;
        private SegmentTemplateFormat _segmentTemplateFormat;

        /// <summary>
        /// Gets and sets the property DashManifests. A list of DASH manifest configurations.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DashManifest> DashManifests
        {
            get { return this._dashManifests; }
            set { this._dashManifests = value; }
        }

        // Check to see if DashManifests property is set
        internal bool IsSetDashManifests()
        {
            return this._dashManifests != null && this._dashManifests.Count > 0; 
        }

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
        /// Gets and sets the property PeriodTriggers. A list of triggers that controls when the
        /// outgoing Dynamic Adaptive Streaming over HTTP (DASH)Media Presentation Description
        /// (MPD) will be partitioned into multiple periods. If empty, the content will notbe
        /// partitioned into more than one period. If the list contains "ADS", new periods will
        /// be created wherethe Asset contains SCTE-35 ad markers.
        /// </summary>
        public List<string> PeriodTriggers
        {
            get { return this._periodTriggers; }
            set { this._periodTriggers = value; }
        }

        // Check to see if PeriodTriggers property is set
        internal bool IsSetPeriodTriggers()
        {
            return this._periodTriggers != null && this._periodTriggers.Count > 0; 
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
        /// Gets and sets the property SegmentTemplateFormat. Determines the type of SegmentTemplate
        /// included in the Media Presentation Description (MPD).  When set to NUMBER_WITH_TIMELINE,
        /// a full timeline is presented in each SegmentTemplate, with $Number$ media URLs.  When
        /// set to TIME_WITH_TIMELINE, a full timeline is presented in each SegmentTemplate, with
        /// $Time$ media URLs. When set to NUMBER_WITH_DURATION, only a duration is included in
        /// each SegmentTemplate, with $Number$ media URLs.
        /// </summary>
        public SegmentTemplateFormat SegmentTemplateFormat
        {
            get { return this._segmentTemplateFormat; }
            set { this._segmentTemplateFormat = value; }
        }

        // Check to see if SegmentTemplateFormat property is set
        internal bool IsSetSegmentTemplateFormat()
        {
            return this._segmentTemplateFormat != null;
        }

    }
}