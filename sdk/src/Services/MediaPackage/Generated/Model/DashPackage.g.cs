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

namespace Amazon.MediaPackage.Model
{
    /// <summary>
    /// A Dynamic Adaptive Streaming over HTTP (DASH) packaging configuration.
    /// </summary>
    public partial class DashPackage
    {
        /// <summary>
        /// Gets and sets the property AdTriggers.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdTriggers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdTriggers property is set.
        /// </summary>
        internal bool IsSetAdTriggers() => this.AdTriggers != null && (this.AdTriggers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AdsOnDeliveryRestrictions.
        /// </summary>
        public AdsOnDeliveryRestrictions AdsOnDeliveryRestrictions { get; set; }

        /// <summary>
        /// Checks to see if the AdsOnDeliveryRestrictions property is set.
        /// </summary>
        internal bool IsSetAdsOnDeliveryRestrictions() => this.AdsOnDeliveryRestrictions != null;

        /// <summary>
        /// Gets and sets the property Encryption.
        /// </summary>
        public DashEncryption Encryption { get; set; }

        /// <summary>
        /// Checks to see if the Encryption property is set.
        /// </summary>
        internal bool IsSetEncryption() => this.Encryption != null;

        /// <summary>
        /// Gets and sets the property IncludeIframeOnlyStream. When enabled, an I-Frame only
        /// stream will be included in the output.
        /// </summary>
        public bool? IncludeIframeOnlyStream { get; set; }

        /// <summary>
        /// Checks to see if the IncludeIframeOnlyStream property is set.
        /// </summary>
        internal bool IsSetIncludeIframeOnlyStream() => this.IncludeIframeOnlyStream.HasValue;

        /// <summary>
        /// Gets and sets the property ManifestLayout. Determines the position of some tags in
        /// the Media Presentation Description (MPD). When set to FULL, elements like SegmentTemplate
        /// and ContentProtection are included in each Representation. When set to COMPACT, duplicate
        /// elements are combined and presented at the AdaptationSet level. When set to DRM_TOP_LEVEL_COMPACT,
        /// content protection elements are placed the MPD level and referenced at the AdaptationSet
        /// level.
        /// </summary>
        public ManifestLayout ManifestLayout { get; set; }

        /// <summary>
        /// Checks to see if the ManifestLayout property is set.
        /// </summary>
        internal bool IsSetManifestLayout() => this.ManifestLayout != null;

        /// <summary>
        /// Gets and sets the property ManifestWindowSeconds. Time window (in seconds) contained
        /// in each manifest.
        /// </summary>
        public int? ManifestWindowSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ManifestWindowSeconds property is set.
        /// </summary>
        internal bool IsSetManifestWindowSeconds() => this.ManifestWindowSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property MinBufferTimeSeconds. Minimum duration (in seconds) that
        /// a player will buffer media before starting the presentation.
        /// </summary>
        public int? MinBufferTimeSeconds { get; set; }

        /// <summary>
        /// Checks to see if the MinBufferTimeSeconds property is set.
        /// </summary>
        internal bool IsSetMinBufferTimeSeconds() => this.MinBufferTimeSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property MinUpdatePeriodSeconds. Minimum duration (in seconds) between
        /// potential changes to the Dynamic Adaptive Streaming over HTTP (DASH) Media Presentation
        /// Description (MPD).
        /// </summary>
        public int? MinUpdatePeriodSeconds { get; set; }

        /// <summary>
        /// Checks to see if the MinUpdatePeriodSeconds property is set.
        /// </summary>
        internal bool IsSetMinUpdatePeriodSeconds() => this.MinUpdatePeriodSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property PeriodTriggers. A list of triggers that controls when the
        /// outgoing Dynamic Adaptive Streaming over HTTP (DASH) Media Presentation Description
        /// (MPD) will be partitioned into multiple periods. If empty, the content will not be
        /// partitioned into more than one period. If the list contains "ADS", new periods will
        /// be created where the Channel source contains SCTE-35 ad markers.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PeriodTriggers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PeriodTriggers property is set.
        /// </summary>
        internal bool IsSetPeriodTriggers() => this.PeriodTriggers != null && (this.PeriodTriggers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Profile. The Dynamic Adaptive Streaming over HTTP (DASH)
        /// profile type. When set to "HBBTV_1_5", HbbTV 1.5 compliant output is enabled. When
        /// set to "DVB-DASH_2014", DVB-DASH 2014 compliant output is enabled.
        /// </summary>
        public Profile Profile { get; set; }

        /// <summary>
        /// Checks to see if the Profile property is set.
        /// </summary>
        internal bool IsSetProfile() => this.Profile != null;

        /// <summary>
        /// Gets and sets the property SegmentDurationSeconds. Duration (in seconds) of each segment.
        /// Actual segments will be rounded to the nearest multiple of the source segment duration.
        /// </summary>
        public int? SegmentDurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the SegmentDurationSeconds property is set.
        /// </summary>
        internal bool IsSetSegmentDurationSeconds() => this.SegmentDurationSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property SegmentTemplateFormat. Determines the type of SegmentTemplate
        /// included in the Media Presentation Description (MPD). When set to NUMBER_WITH_TIMELINE,
        /// a full timeline is presented in each SegmentTemplate, with $Number$ media URLs. When
        /// set to TIME_WITH_TIMELINE, a full timeline is presented in each SegmentTemplate, with
        /// $Time$ media URLs. When set to NUMBER_WITH_DURATION, only a duration is included in
        /// each SegmentTemplate, with $Number$ media URLs.
        /// </summary>
        public SegmentTemplateFormat SegmentTemplateFormat { get; set; }

        /// <summary>
        /// Checks to see if the SegmentTemplateFormat property is set.
        /// </summary>
        internal bool IsSetSegmentTemplateFormat() => this.SegmentTemplateFormat != null;

        /// <summary>
        /// Gets and sets the property StreamSelection.
        /// </summary>
        public StreamSelection StreamSelection { get; set; }

        /// <summary>
        /// Checks to see if the StreamSelection property is set.
        /// </summary>
        internal bool IsSetStreamSelection() => this.StreamSelection != null;

        /// <summary>
        /// Gets and sets the property SuggestedPresentationDelaySeconds. Duration (in seconds)
        /// to delay live content before presentation.
        /// </summary>
        public int? SuggestedPresentationDelaySeconds { get; set; }

        /// <summary>
        /// Checks to see if the SuggestedPresentationDelaySeconds property is set.
        /// </summary>
        internal bool IsSetSuggestedPresentationDelaySeconds() => this.SuggestedPresentationDelaySeconds.HasValue;

        /// <summary>
        /// Gets and sets the property UtcTiming. Determines the type of UTCTiming included in
        /// the Media Presentation Description (MPD)
        /// </summary>
        public UtcTiming UtcTiming { get; set; }

        /// <summary>
        /// Checks to see if the UtcTiming property is set.
        /// </summary>
        internal bool IsSetUtcTiming() => this.UtcTiming != null;

        /// <summary>
        /// Gets and sets the property UtcTimingUri. Specifies the value attribute of the UTCTiming
        /// field when utcTiming is set to HTTP-ISO, HTTP-HEAD or HTTP-XSDATE
        /// </summary>
        public string UtcTimingUri { get; set; }

        /// <summary>
        /// Checks to see if the UtcTimingUri property is set.
        /// </summary>
        internal bool IsSetUtcTimingUri() => this.UtcTimingUri != null;
    }
}
