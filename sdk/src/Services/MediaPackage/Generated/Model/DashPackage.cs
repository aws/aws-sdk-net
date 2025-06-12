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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
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
namespace Amazon.MediaPackage.Model
{
    /// <summary>
    /// A Dynamic Adaptive Streaming over HTTP (DASH) packaging configuration.
    /// </summary>
    public partial class DashPackage
    {
        private AdsOnDeliveryRestrictions _adsOnDeliveryRestrictions;
        private List<string> _adTriggers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DashEncryption _encryption;
        private bool? _includeIframeOnlyStream;
        private ManifestLayout _manifestLayout;
        private int? _manifestWindowSeconds;
        private int? _minBufferTimeSeconds;
        private int? _minUpdatePeriodSeconds;
        private List<string> _periodTriggers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Profile _profile;
        private int? _segmentDurationSeconds;
        private SegmentTemplateFormat _segmentTemplateFormat;
        private StreamSelection _streamSelection;
        private int? _suggestedPresentationDelaySeconds;
        private UtcTiming _utcTiming;
        private string _utcTimingUri;

        /// <summary>
        /// Gets and sets the property AdsOnDeliveryRestrictions.
        /// </summary>
        public AdsOnDeliveryRestrictions AdsOnDeliveryRestrictions
        {
            get { return this._adsOnDeliveryRestrictions; }
            set { this._adsOnDeliveryRestrictions = value; }
        }

        // Check to see if AdsOnDeliveryRestrictions property is set
        internal bool IsSetAdsOnDeliveryRestrictions()
        {
            return this._adsOnDeliveryRestrictions != null;
        }

        /// <summary>
        /// Gets and sets the property AdTriggers.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdTriggers
        {
            get { return this._adTriggers; }
            set { this._adTriggers = value; }
        }

        // Check to see if AdTriggers property is set
        internal bool IsSetAdTriggers()
        {
            return this._adTriggers != null && (this._adTriggers.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property IncludeIframeOnlyStream. When enabled, an I-Frame only
        /// stream will be included in the output.
        /// </summary>
        public bool? IncludeIframeOnlyStream
        {
            get { return this._includeIframeOnlyStream; }
            set { this._includeIframeOnlyStream = value; }
        }

        // Check to see if IncludeIframeOnlyStream property is set
        internal bool IsSetIncludeIframeOnlyStream()
        {
            return this._includeIframeOnlyStream.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ManifestLayout. Determines the position of some tags in
        /// the Media Presentation Description (MPD).  When set to FULL, elements like SegmentTemplate
        /// and ContentProtection are included in each Representation.  When set to COMPACT, duplicate
        /// elements are combined and presented at the AdaptationSet level. When set to DRM_TOP_LEVEL_COMPACT,
        /// content protection elements are placed the MPD level and referenced at the AdaptationSet
        /// level.
        /// </summary>
        public ManifestLayout ManifestLayout
        {
            get { return this._manifestLayout; }
            set { this._manifestLayout = value; }
        }

        // Check to see if ManifestLayout property is set
        internal bool IsSetManifestLayout()
        {
            return this._manifestLayout != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestWindowSeconds. Time window (in seconds) contained
        /// in each manifest.
        /// </summary>
        public int? ManifestWindowSeconds
        {
            get { return this._manifestWindowSeconds; }
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
        public int? MinBufferTimeSeconds
        {
            get { return this._minBufferTimeSeconds; }
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
        public int? MinUpdatePeriodSeconds
        {
            get { return this._minUpdatePeriodSeconds; }
            set { this._minUpdatePeriodSeconds = value; }
        }

        // Check to see if MinUpdatePeriodSeconds property is set
        internal bool IsSetMinUpdatePeriodSeconds()
        {
            return this._minUpdatePeriodSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PeriodTriggers. A list of triggers that controls when the
        /// outgoing Dynamic Adaptive Streaming over HTTP (DASH)Media Presentation Description
        /// (MPD) will be partitioned into multiple periods. If empty, the content will notbe
        /// partitioned into more than one period. If the list contains "ADS", new periods will
        /// be created wherethe Channel source contains SCTE-35 ad markers.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PeriodTriggers
        {
            get { return this._periodTriggers; }
            set { this._periodTriggers = value; }
        }

        // Check to see if PeriodTriggers property is set
        internal bool IsSetPeriodTriggers()
        {
            return this._periodTriggers != null && (this._periodTriggers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Profile. The Dynamic Adaptive Streaming over HTTP (DASH)
        /// profile type.  When set to "HBBTV_1_5", HbbTV 1.5 compliant output is enabled. When
        /// set to "DVB-DASH_2014", DVB-DASH 2014 compliant output is enabled.
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
        public int? SuggestedPresentationDelaySeconds
        {
            get { return this._suggestedPresentationDelaySeconds; }
            set { this._suggestedPresentationDelaySeconds = value; }
        }

        // Check to see if SuggestedPresentationDelaySeconds property is set
        internal bool IsSetSuggestedPresentationDelaySeconds()
        {
            return this._suggestedPresentationDelaySeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UtcTiming. Determines the type of UTCTiming included in
        /// the Media Presentation Description (MPD)
        /// </summary>
        public UtcTiming UtcTiming
        {
            get { return this._utcTiming; }
            set { this._utcTiming = value; }
        }

        // Check to see if UtcTiming property is set
        internal bool IsSetUtcTiming()
        {
            return this._utcTiming != null;
        }

        /// <summary>
        /// Gets and sets the property UtcTimingUri. Specifies the value attribute of the UTCTiming
        /// field when utcTiming is set to HTTP-ISO, HTTP-HEAD or HTTP-XSDATE
        /// </summary>
        public string UtcTimingUri
        {
            get { return this._utcTimingUri; }
            set { this._utcTimingUri = value; }
        }

        // Check to see if UtcTimingUri property is set
        internal bool IsSetUtcTimingUri()
        {
            return this._utcTimingUri != null;
        }

    }
}