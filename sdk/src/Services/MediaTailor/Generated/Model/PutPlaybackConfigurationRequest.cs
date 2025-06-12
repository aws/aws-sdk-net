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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Container for the parameters to the PutPlaybackConfiguration operation.
    /// Creates a playback configuration. For information about MediaTailor configurations,
    /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/configurations.html">Working
    /// with configurations in AWS Elemental MediaTailor</a>.
    /// </summary>
    public partial class PutPlaybackConfigurationRequest : AmazonMediaTailorRequest
    {
        private AdConditioningConfiguration _adConditioningConfiguration;
        private string _adDecisionServerUrl;
        private AvailSuppression _availSuppression;
        private Bumper _bumper;
        private CdnConfiguration _cdnConfiguration;
        private Dictionary<string, Dictionary<string, string>> _configurationAliases = AWSConfigs.InitializeCollections ? new Dictionary<string, Dictionary<string, string>>() : null;
        private DashConfigurationForPut _dashConfiguration;
        private InsertionMode _insertionMode;
        private LivePreRollConfiguration _livePreRollConfiguration;
        private ManifestProcessingRules _manifestProcessingRules;
        private string _name;
        private int? _personalizationThresholdSeconds;
        private string _slateAdUrl;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _transcodeProfileName;
        private string _videoContentSourceUrl;

        /// <summary>
        /// Gets and sets the property AdConditioningConfiguration. 
        /// <para>
        /// The setting that indicates what conditioning MediaTailor will perform on ads that
        /// the ad decision server (ADS) returns, and what priority MediaTailor uses when inserting
        /// ads. 
        /// </para>
        /// </summary>
        public AdConditioningConfiguration AdConditioningConfiguration
        {
            get { return this._adConditioningConfiguration; }
            set { this._adConditioningConfiguration = value; }
        }

        // Check to see if AdConditioningConfiguration property is set
        internal bool IsSetAdConditioningConfiguration()
        {
            return this._adConditioningConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AdDecisionServerUrl. 
        /// <para>
        /// The URL for the ad decision server (ADS). This includes the specification of static
        /// parameters and placeholders for dynamic parameters. AWS Elemental MediaTailor substitutes
        /// player-specific and session-specific parameters as needed when calling the ADS. Alternately,
        /// for testing you can provide a static VAST URL. The maximum length is 25,000 characters.
        /// </para>
        /// </summary>
        public string AdDecisionServerUrl
        {
            get { return this._adDecisionServerUrl; }
            set { this._adDecisionServerUrl = value; }
        }

        // Check to see if AdDecisionServerUrl property is set
        internal bool IsSetAdDecisionServerUrl()
        {
            return this._adDecisionServerUrl != null;
        }

        /// <summary>
        /// Gets and sets the property AvailSuppression. 
        /// <para>
        /// The configuration for avail suppression, also known as ad suppression. For more information
        /// about ad suppression, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/ad-behavior.html">Ad
        /// Suppression</a>.
        /// </para>
        /// </summary>
        public AvailSuppression AvailSuppression
        {
            get { return this._availSuppression; }
            set { this._availSuppression = value; }
        }

        // Check to see if AvailSuppression property is set
        internal bool IsSetAvailSuppression()
        {
            return this._availSuppression != null;
        }

        /// <summary>
        /// Gets and sets the property Bumper. 
        /// <para>
        /// The configuration for bumpers. Bumpers are short audio or video clips that play at
        /// the start or before the end of an ad break. To learn more about bumpers, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/bumpers.html">Bumpers</a>.
        /// </para>
        /// </summary>
        public Bumper Bumper
        {
            get { return this._bumper; }
            set { this._bumper = value; }
        }

        // Check to see if Bumper property is set
        internal bool IsSetBumper()
        {
            return this._bumper != null;
        }

        /// <summary>
        /// Gets and sets the property CdnConfiguration. 
        /// <para>
        /// The configuration for using a content delivery network (CDN), like Amazon CloudFront,
        /// for content and ad segment management.
        /// </para>
        /// </summary>
        public CdnConfiguration CdnConfiguration
        {
            get { return this._cdnConfiguration; }
            set { this._cdnConfiguration = value; }
        }

        // Check to see if CdnConfiguration property is set
        internal bool IsSetCdnConfiguration()
        {
            return this._cdnConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationAliases. 
        /// <para>
        /// The player parameters and aliases used as dynamic variables during session initialization.
        /// For more information, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/variables-domains.html">Domain
        /// Variables</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Dictionary<string, string>> ConfigurationAliases
        {
            get { return this._configurationAliases; }
            set { this._configurationAliases = value; }
        }

        // Check to see if ConfigurationAliases property is set
        internal bool IsSetConfigurationAliases()
        {
            return this._configurationAliases != null && (this._configurationAliases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DashConfiguration. 
        /// <para>
        /// The configuration for DASH content.
        /// </para>
        /// </summary>
        public DashConfigurationForPut DashConfiguration
        {
            get { return this._dashConfiguration; }
            set { this._dashConfiguration = value; }
        }

        // Check to see if DashConfiguration property is set
        internal bool IsSetDashConfiguration()
        {
            return this._dashConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property InsertionMode. 
        /// <para>
        /// The setting that controls whether players can use stitched or guided ad insertion.
        /// The default, <c>STITCHED_ONLY</c>, forces all player sessions to use stitched (server-side)
        /// ad insertion. Choosing <c>PLAYER_SELECT</c> allows players to select either stitched
        /// or guided ad insertion at session-initialization time. The default for players that
        /// do not specify an insertion mode is stitched.
        /// </para>
        /// </summary>
        public InsertionMode InsertionMode
        {
            get { return this._insertionMode; }
            set { this._insertionMode = value; }
        }

        // Check to see if InsertionMode property is set
        internal bool IsSetInsertionMode()
        {
            return this._insertionMode != null;
        }

        /// <summary>
        /// Gets and sets the property LivePreRollConfiguration. 
        /// <para>
        /// The configuration for pre-roll ad insertion.
        /// </para>
        /// </summary>
        public LivePreRollConfiguration LivePreRollConfiguration
        {
            get { return this._livePreRollConfiguration; }
            set { this._livePreRollConfiguration = value; }
        }

        // Check to see if LivePreRollConfiguration property is set
        internal bool IsSetLivePreRollConfiguration()
        {
            return this._livePreRollConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestProcessingRules. 
        /// <para>
        /// The configuration for manifest processing rules. Manifest processing rules enable
        /// customization of the personalized manifests created by MediaTailor.
        /// </para>
        /// </summary>
        public ManifestProcessingRules ManifestProcessingRules
        {
            get { return this._manifestProcessingRules; }
            set { this._manifestProcessingRules = value; }
        }

        // Check to see if ManifestProcessingRules property is set
        internal bool IsSetManifestProcessingRules()
        {
            return this._manifestProcessingRules != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The identifier for the playback configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PersonalizationThresholdSeconds. 
        /// <para>
        /// Defines the maximum duration of underfilled ad time (in seconds) allowed in an ad
        /// break. If the duration of underfilled ad time exceeds the personalization threshold,
        /// then the personalization of the ad break is abandoned and the underlying content is
        /// shown. This feature applies to <i>ad replacement</i> in live and VOD streams, rather
        /// than ad insertion, because it relies on an underlying content stream. For more information
        /// about ad break behavior, including ad replacement and insertion, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/ad-behavior.html">Ad
        /// Behavior in AWS Elemental MediaTailor</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? PersonalizationThresholdSeconds
        {
            get { return this._personalizationThresholdSeconds; }
            set { this._personalizationThresholdSeconds = value; }
        }

        // Check to see if PersonalizationThresholdSeconds property is set
        internal bool IsSetPersonalizationThresholdSeconds()
        {
            return this._personalizationThresholdSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SlateAdUrl. 
        /// <para>
        /// The URL for a high-quality video asset to transcode and use to fill in time that's
        /// not used by ads. AWS Elemental MediaTailor shows the slate to fill in gaps in media
        /// content. Configuring the slate is optional for non-VPAID configurations. For VPAID,
        /// the slate is required because MediaTailor provides it in the slots that are designated
        /// for dynamic ad content. The slate must be a high-quality asset that contains both
        /// audio and video.
        /// </para>
        /// </summary>
        public string SlateAdUrl
        {
            get { return this._slateAdUrl; }
            set { this._slateAdUrl = value; }
        }

        // Check to see if SlateAdUrl property is set
        internal bool IsSetSlateAdUrl()
        {
            return this._slateAdUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to assign to the playback configuration. Tags are key-value pairs that you
        /// can associate with Amazon resources to help with organization, access control, and
        /// cost tracking. For more information, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/tagging.html">Tagging
        /// AWS Elemental MediaTailor Resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TranscodeProfileName. 
        /// <para>
        /// The name that is used to associate this playback configuration with a custom transcode
        /// profile. This overrides the dynamic transcoding defaults of MediaTailor. Use this
        /// only if you have already set up custom profiles with the help of AWS Support.
        /// </para>
        /// </summary>
        public string TranscodeProfileName
        {
            get { return this._transcodeProfileName; }
            set { this._transcodeProfileName = value; }
        }

        // Check to see if TranscodeProfileName property is set
        internal bool IsSetTranscodeProfileName()
        {
            return this._transcodeProfileName != null;
        }

        /// <summary>
        /// Gets and sets the property VideoContentSourceUrl. 
        /// <para>
        /// The URL prefix for the parent manifest for the stream, minus the asset ID. The maximum
        /// length is 512 characters.
        /// </para>
        /// </summary>
        public string VideoContentSourceUrl
        {
            get { return this._videoContentSourceUrl; }
            set { this._videoContentSourceUrl = value; }
        }

        // Check to see if VideoContentSourceUrl property is set
        internal bool IsSetVideoContentSourceUrl()
        {
            return this._videoContentSourceUrl != null;
        }

    }
}