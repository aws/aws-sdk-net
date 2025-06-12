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
    /// Create a DASH manifest configuration.
    /// </summary>
    public partial class CreateDashManifestConfiguration
    {
        private List<DashBaseUrl> _baseUrls = AWSConfigs.InitializeCollections ? new List<DashBaseUrl>() : null;
        private DashCompactness _compactness;
        private DashDrmSignaling _drmSignaling;
        private DashDvbSettings _dvbSettings;
        private FilterConfiguration _filterConfiguration;
        private string _manifestName;
        private int? _manifestWindowSeconds;
        private int? _minBufferTimeSeconds;
        private int? _minUpdatePeriodSeconds;
        private List<string> _periodTriggers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _profiles = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DashProgramInformation _programInformation;
        private ScteDash _scteDash;
        private DashSegmentTemplateFormat _segmentTemplateFormat;
        private DashSubtitleConfiguration _subtitleConfiguration;
        private int? _suggestedPresentationDelaySeconds;
        private DashUtcTiming _utcTiming;

        /// <summary>
        /// Gets and sets the property BaseUrls. 
        /// <para>
        /// The base URLs to use for retrieving segments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<DashBaseUrl> BaseUrls
        {
            get { return this._baseUrls; }
            set { this._baseUrls = value; }
        }

        // Check to see if BaseUrls property is set
        internal bool IsSetBaseUrls()
        {
            return this._baseUrls != null && (this._baseUrls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public DashCompactness Compactness
        {
            get { return this._compactness; }
            set { this._compactness = value; }
        }

        // Check to see if Compactness property is set
        internal bool IsSetCompactness()
        {
            return this._compactness != null;
        }

        /// <summary>
        /// Gets and sets the property DrmSignaling. 
        /// <para>
        /// Determines how the DASH manifest signals the DRM content.
        /// </para>
        /// </summary>
        public DashDrmSignaling DrmSignaling
        {
            get { return this._drmSignaling; }
            set { this._drmSignaling = value; }
        }

        // Check to see if DrmSignaling property is set
        internal bool IsSetDrmSignaling()
        {
            return this._drmSignaling != null;
        }

        /// <summary>
        /// Gets and sets the property DvbSettings. 
        /// <para>
        /// For endpoints that use the DVB-DASH profile only. The font download and error reporting
        /// information that you want MediaPackage to pass through to the manifest.
        /// </para>
        /// </summary>
        public DashDvbSettings DvbSettings
        {
            get { return this._dvbSettings; }
            set { this._dvbSettings = value; }
        }

        // Check to see if DvbSettings property is set
        internal bool IsSetDvbSettings()
        {
            return this._dvbSettings != null;
        }

        /// <summary>
        /// Gets and sets the property FilterConfiguration.
        /// </summary>
        public FilterConfiguration FilterConfiguration
        {
            get { return this._filterConfiguration; }
            set { this._filterConfiguration = value; }
        }

        // Check to see if FilterConfiguration property is set
        internal bool IsSetFilterConfiguration()
        {
            return this._filterConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestName. 
        /// <para>
        /// A short string that's appended to the endpoint URL. The child manifest name creates
        /// a unique path to this endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ManifestName
        {
            get { return this._manifestName; }
            set { this._manifestName = value; }
        }

        // Check to see if ManifestName property is set
        internal bool IsSetManifestName()
        {
            return this._manifestName != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestWindowSeconds. 
        /// <para>
        /// The total duration (in seconds) of the manifest's content.
        /// </para>
        /// </summary>
        [AWSProperty(Min=30)]
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
        /// Gets and sets the property MinBufferTimeSeconds. 
        /// <para>
        /// Minimum amount of content (in seconds) that a player must keep available in the buffer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3600)]
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
        /// Gets and sets the property MinUpdatePeriodSeconds. 
        /// <para>
        /// Minimum amount of time (in seconds) that the player should wait before requesting
        /// updates to the manifest.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3600)]
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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
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
        /// Gets and sets the property Profiles. 
        /// <para>
        /// The profile that the output is compliant with.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> Profiles
        {
            get { return this._profiles; }
            set { this._profiles = value; }
        }

        // Check to see if Profiles property is set
        internal bool IsSetProfiles()
        {
            return this._profiles != null && (this._profiles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProgramInformation. 
        /// <para>
        /// Details about the content that you want MediaPackage to pass through in the manifest
        /// to the playback device.
        /// </para>
        /// </summary>
        public DashProgramInformation ProgramInformation
        {
            get { return this._programInformation; }
            set { this._programInformation = value; }
        }

        // Check to see if ProgramInformation property is set
        internal bool IsSetProgramInformation()
        {
            return this._programInformation != null;
        }

        /// <summary>
        /// Gets and sets the property ScteDash. 
        /// <para>
        /// The SCTE configuration.
        /// </para>
        /// </summary>
        public ScteDash ScteDash
        {
            get { return this._scteDash; }
            set { this._scteDash = value; }
        }

        // Check to see if ScteDash property is set
        internal bool IsSetScteDash()
        {
            return this._scteDash != null;
        }

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
        public DashSegmentTemplateFormat SegmentTemplateFormat
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
        /// Gets and sets the property SubtitleConfiguration. 
        /// <para>
        /// The configuration for DASH subtitles.
        /// </para>
        /// </summary>
        public DashSubtitleConfiguration SubtitleConfiguration
        {
            get { return this._subtitleConfiguration; }
            set { this._subtitleConfiguration = value; }
        }

        // Check to see if SubtitleConfiguration property is set
        internal bool IsSetSubtitleConfiguration()
        {
            return this._subtitleConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SuggestedPresentationDelaySeconds. 
        /// <para>
        /// The amount of time (in seconds) that the player should be from the end of the manifest.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3600)]
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
        /// Gets and sets the property UtcTiming. 
        /// <para>
        /// Determines the type of UTC timing included in the DASH Media Presentation Description
        /// (MPD).
        /// </para>
        /// </summary>
        public DashUtcTiming UtcTiming
        {
            get { return this._utcTiming; }
            set { this._utcTiming = value; }
        }

        // Check to see if UtcTiming property is set
        internal bool IsSetUtcTiming()
        {
            return this._utcTiming != null;
        }

    }
}