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

namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// Create a DASH manifest configuration.
    /// </summary>
    public partial class CreateDashManifestConfiguration
    {
        /// <summary>
        /// Gets and sets the property AudioTimelinePattern. 
        /// <para>
        /// How MediaPackage represents the audio timeline in the DASH manifest. This setting
        /// applies DASH Segment Duration Patternization, as defined in the MPEG-DASH specification,
        /// to audio adaptation sets. When set to <c>PATTERNED</c>, MediaPackage uses a pattern-based
        /// segment template for audio, which reduces manifest size by expressing repeating segment
        /// durations as a pattern instead of listing each segment individually. When set to <c>NONE</c>,
        /// the manifest contains an explicit timeline that lists each audio segment.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>NONE</c> | <c>PATTERNED</c> 
        /// </para>
        ///  
        /// <para>
        /// For information about audio timeline patterns, see <a href="https://docs.aws.amazon.com/mediapackage/latest/userguide/dash-audio-timeline-pattern.html">DASH
        /// audio timeline pattern</a> in the <i>Elemental MediaPackage v2 User Guide</i>.
        /// </para>
        /// </summary>
        public DashAudioTimelinePattern AudioTimelinePattern { get; set; }

        /// <summary>
        /// Checks to see if the AudioTimelinePattern property is set.
        /// </summary>
        internal bool IsSetAudioTimelinePattern() => this.AudioTimelinePattern != null;

        /// <summary>
        /// Gets and sets the property AvailabilityStartTimeConfiguration. 
        /// <para>
        /// The configuration for the DASH <c>availabilityStartTime</c> attribute of the Media
        /// Presentation Description (MPD). If you don't specify a value, MediaPackage uses the
        /// default availability start time of <c>2024-01-01T00:00:00Z</c>.
        /// </para>
        /// </summary>
        public DashAvailabilityStartTimeConfiguration AvailabilityStartTimeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityStartTimeConfiguration property is set.
        /// </summary>
        internal bool IsSetAvailabilityStartTimeConfiguration() => this.AvailabilityStartTimeConfiguration != null;

        /// <summary>
        /// Gets and sets the property BaseUrls. 
        /// <para>
        /// The base URLs to use for retrieving segments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<DashBaseUrl> BaseUrls { get; set; } = AWSConfigs.InitializeCollections ? new List<DashBaseUrl>() : null;

        /// <summary>
        /// Checks to see if the BaseUrls property is set.
        /// </summary>
        internal bool IsSetBaseUrls() => this.BaseUrls != null && (this.BaseUrls.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Compactness. 
        /// <para>
        /// The layout of the DASH manifest that MediaPackage produces. <c>STANDARD</c> indicates
        /// a default manifest, which is compacted. <c>NONE</c> indicates a full manifest.
        /// </para>
        ///  
        /// <para>
        /// For information about compactness, see <a href="https://docs.aws.amazon.com/mediapackage/latest/userguide/compacted.html">DASH
        /// manifest compactness</a> in the <i>Elemental MediaPackage v2 User Guide</i>.
        /// </para>
        /// </summary>
        public DashCompactness Compactness { get; set; }

        /// <summary>
        /// Checks to see if the Compactness property is set.
        /// </summary>
        internal bool IsSetCompactness() => this.Compactness != null;

        /// <summary>
        /// Gets and sets the property DrmSignaling. 
        /// <para>
        /// Determines how the DASH manifest signals the DRM content.
        /// </para>
        /// </summary>
        public DashDrmSignaling DrmSignaling { get; set; }

        /// <summary>
        /// Checks to see if the DrmSignaling property is set.
        /// </summary>
        internal bool IsSetDrmSignaling() => this.DrmSignaling != null;

        /// <summary>
        /// Gets and sets the property DvbSettings. 
        /// <para>
        /// For endpoints that use the DVB-DASH profile only. The font download and error reporting
        /// information that you want MediaPackage to pass through to the manifest.
        /// </para>
        /// </summary>
        public DashDvbSettings DvbSettings { get; set; }

        /// <summary>
        /// Checks to see if the DvbSettings property is set.
        /// </summary>
        internal bool IsSetDvbSettings() => this.DvbSettings != null;

        /// <summary>
        /// Gets and sets the property FilterConfiguration.
        /// </summary>
        public FilterConfiguration FilterConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FilterConfiguration property is set.
        /// </summary>
        internal bool IsSetFilterConfiguration() => this.FilterConfiguration != null;

        /// <summary>
        /// Gets and sets the property ManifestName. 
        /// <para>
        /// A short string that's appended to the endpoint URL. The child manifest name creates
        /// a unique path to this endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ManifestName { get; set; }

        /// <summary>
        /// Checks to see if the ManifestName property is set.
        /// </summary>
        internal bool IsSetManifestName() => this.ManifestName != null;

        /// <summary>
        /// Gets and sets the property ManifestWindowSeconds. 
        /// <para>
        /// The total duration (in seconds) of the manifest's content.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 30)]
        public int? ManifestWindowSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ManifestWindowSeconds property is set.
        /// </summary>
        internal bool IsSetManifestWindowSeconds() => this.ManifestWindowSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property MinBufferTimeSeconds. 
        /// <para>
        /// Minimum amount of content (in seconds) that a player must keep available in the buffer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 3600)]
        public int? MinBufferTimeSeconds { get; set; }

        /// <summary>
        /// Checks to see if the MinBufferTimeSeconds property is set.
        /// </summary>
        internal bool IsSetMinBufferTimeSeconds() => this.MinBufferTimeSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property MinUpdatePeriodSeconds. 
        /// <para>
        /// Minimum amount of time (in seconds) that the player should wait before requesting
        /// updates to the manifest.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 3600)]
        public int? MinUpdatePeriodSeconds { get; set; }

        /// <summary>
        /// Checks to see if the MinUpdatePeriodSeconds property is set.
        /// </summary>
        internal bool IsSetMinUpdatePeriodSeconds() => this.MinUpdatePeriodSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property PeriodTriggers. 
        /// <para>
        /// A list of triggers that controls when AWS Elemental MediaPackage separates the MPEG-DASH
        /// manifest into multiple periods. Type <c>ADS</c> to indicate that AWS Elemental MediaPackage
        /// must create periods in the output manifest that correspond to SCTE-35 ad markers in
        /// the input source. Leave this value empty to indicate that the manifest is contained
        /// all in one period. For more information about periods in the DASH manifest, see <a
        /// href="https://docs.aws.amazon.com/mediapackage/latest/userguide/multi-period.html">Multi-period
        /// DASH in AWS Elemental MediaPackage</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> PeriodTriggers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PeriodTriggers property is set.
        /// </summary>
        internal bool IsSetPeriodTriggers() => this.PeriodTriggers != null && (this.PeriodTriggers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Profiles. 
        /// <para>
        /// The profile that the output is compliant with.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> Profiles { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Profiles property is set.
        /// </summary>
        internal bool IsSetProfiles() => this.Profiles != null && (this.Profiles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProgramInformation. 
        /// <para>
        /// Details about the content that you want MediaPackage to pass through in the manifest
        /// to the playback device.
        /// </para>
        /// </summary>
        public DashProgramInformation ProgramInformation { get; set; }

        /// <summary>
        /// Checks to see if the ProgramInformation property is set.
        /// </summary>
        internal bool IsSetProgramInformation() => this.ProgramInformation != null;

        /// <summary>
        /// Gets and sets the property ScteDash. 
        /// <para>
        /// The SCTE configuration.
        /// </para>
        /// </summary>
        public ScteDash ScteDash { get; set; }

        /// <summary>
        /// Checks to see if the ScteDash property is set.
        /// </summary>
        internal bool IsSetScteDash() => this.ScteDash != null;

        /// <summary>
        /// Gets and sets the property SegmentTemplateFormat. 
        /// <para>
        /// Determines the type of variable used in the <c>media</c> URL of the <c>SegmentTemplate</c>
        /// tag in the manifest. Also specifies if segment timeline information is included in
        /// <c>SegmentTimeline</c> or <c>SegmentTemplate</c>.
        /// </para>
        ///  
        /// <para>
        /// Value description:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NUMBER_WITH_TIMELINE</c> - The <c>$Number$</c> variable is used in the <c>media</c>
        /// URL. The value of this variable is the sequential number of the segment. A full <c>SegmentTimeline</c>
        /// object is presented in each <c>SegmentTemplate</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DashSegmentTemplateFormat SegmentTemplateFormat { get; set; }

        /// <summary>
        /// Checks to see if the SegmentTemplateFormat property is set.
        /// </summary>
        internal bool IsSetSegmentTemplateFormat() => this.SegmentTemplateFormat != null;

        /// <summary>
        /// Gets and sets the property SubtitleConfiguration. 
        /// <para>
        /// The configuration for DASH subtitles.
        /// </para>
        /// </summary>
        public DashSubtitleConfiguration SubtitleConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SubtitleConfiguration property is set.
        /// </summary>
        internal bool IsSetSubtitleConfiguration() => this.SubtitleConfiguration != null;

        /// <summary>
        /// Gets and sets the property SuggestedPresentationDelaySeconds. 
        /// <para>
        /// The amount of time (in seconds) that the player should be from the end of the manifest.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 3600)]
        public int? SuggestedPresentationDelaySeconds { get; set; }

        /// <summary>
        /// Checks to see if the SuggestedPresentationDelaySeconds property is set.
        /// </summary>
        internal bool IsSetSuggestedPresentationDelaySeconds() => this.SuggestedPresentationDelaySeconds.HasValue;

        /// <summary>
        /// Gets and sets the property UriPathType. 
        /// <para>
        /// The type of path to use in manifest URIs. <c>LEAF</c> uses leaf-relative paths (for
        /// example, <c>index_1.mpd</c>). <c>ROOT</c> uses root-relative paths that include the
        /// full path from root (for example, <c>/out/v1/channel-group/channel/endpoint/index_1.mpd</c>).
        /// If you don't specify a value, the default is <c>LEAF</c>.
        /// </para>
        /// </summary>
        public UriPathType UriPathType { get; set; }

        /// <summary>
        /// Checks to see if the UriPathType property is set.
        /// </summary>
        internal bool IsSetUriPathType() => this.UriPathType != null;

        /// <summary>
        /// Gets and sets the property UtcTiming. 
        /// <para>
        /// Determines the type of UTC timing included in the DASH Media Presentation Description
        /// (MPD).
        /// </para>
        /// </summary>
        public DashUtcTiming UtcTiming { get; set; }

        /// <summary>
        /// Checks to see if the UtcTiming property is set.
        /// </summary>
        internal bool IsSetUtcTiming() => this.UtcTiming != null;
    }
}
