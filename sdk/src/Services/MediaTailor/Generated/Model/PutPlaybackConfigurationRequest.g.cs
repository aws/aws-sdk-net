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

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Container for the parameters to the PutPlaybackConfiguration operation. Creates a
    /// playback configuration. For information about MediaTailor configurations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/configurations.html">Working
    /// with configurations in AWS Elemental MediaTailor</a>.
    /// </summary>
    public partial class PutPlaybackConfigurationRequest : AmazonMediaTailorRequest
    {
        /// <summary>
        /// Gets and sets the property AdConditioningConfiguration. 
        /// <para>
        /// The setting that indicates what conditioning MediaTailor will perform on ads that
        /// the ad decision server (ADS) returns, and what priority MediaTailor uses when inserting
        /// ads. 
        /// </para>
        /// </summary>
        public AdConditioningConfiguration AdConditioningConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AdConditioningConfiguration property is set.
        /// </summary>
        internal bool IsSetAdConditioningConfiguration() => this.AdConditioningConfiguration != null;

        /// <summary>
        /// Gets and sets the property AdDecisionServerConfiguration. 
        /// <para>
        /// The configuration for customizing HTTP requests to the ad decision server (ADS). This
        /// includes settings for request method, headers, body content, and compression options.
        /// </para>
        /// </summary>
        public AdDecisionServerConfiguration AdDecisionServerConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AdDecisionServerConfiguration property is set.
        /// </summary>
        internal bool IsSetAdDecisionServerConfiguration() => this.AdDecisionServerConfiguration != null;

        /// <summary>
        /// Gets and sets the property AdDecisionServerUrl. 
        /// <para>
        /// The URL for the ad decision server (ADS). This includes the specification of static
        /// parameters and placeholders for dynamic parameters. AWS Elemental MediaTailor substitutes
        /// player-specific and session-specific parameters as needed when calling the ADS. Alternately,
        /// for testing you can provide a static VAST URL. The maximum length is 25,000 characters.
        /// </para>
        /// </summary>
        public string AdDecisionServerUrl { get; set; }

        /// <summary>
        /// Checks to see if the AdDecisionServerUrl property is set.
        /// </summary>
        internal bool IsSetAdDecisionServerUrl() => this.AdDecisionServerUrl != null;

        /// <summary>
        /// Gets and sets the property AdsPersonalizationConcurrency. 
        /// <para>
        /// The concurrency settings for ad decision server interactions. These settings control
        /// how many simultaneous ADS requests MediaTailor makes per manifest request.
        /// </para>
        /// </summary>
        public AdsPersonalizationConcurrency AdsPersonalizationConcurrency { get; set; }

        /// <summary>
        /// Checks to see if the AdsPersonalizationConcurrency property is set.
        /// </summary>
        internal bool IsSetAdsPersonalizationConcurrency() => this.AdsPersonalizationConcurrency != null;

        /// <summary>
        /// Gets and sets the property AdsPersonalizationTimeouts. 
        /// <para>
        /// The timeout settings for ad decision server interactions. These settings control how
        /// long MediaTailor waits for ADS responses and the total time budget for ad personalization
        /// across live, VOD, and prefetch workflows.
        /// </para>
        /// </summary>
        public AdsPersonalizationTimeouts AdsPersonalizationTimeouts { get; set; }

        /// <summary>
        /// Checks to see if the AdsPersonalizationTimeouts property is set.
        /// </summary>
        internal bool IsSetAdsPersonalizationTimeouts() => this.AdsPersonalizationTimeouts != null;

        /// <summary>
        /// Gets and sets the property AvailSuppression. 
        /// <para>
        /// The configuration for avail suppression, also known as ad suppression. For more information
        /// about ad suppression, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/ad-behavior.html">Ad
        /// Suppression</a>.
        /// </para>
        /// </summary>
        public AvailSuppression AvailSuppression { get; set; }

        /// <summary>
        /// Checks to see if the AvailSuppression property is set.
        /// </summary>
        internal bool IsSetAvailSuppression() => this.AvailSuppression != null;

        /// <summary>
        /// Gets and sets the property Bumper. 
        /// <para>
        /// The configuration for bumpers. Bumpers are short audio or video clips that play at
        /// the start or before the end of an ad break. To learn more about bumpers, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/bumpers.html">Bumpers</a>.
        /// </para>
        /// </summary>
        public Bumper Bumper { get; set; }

        /// <summary>
        /// Checks to see if the Bumper property is set.
        /// </summary>
        internal bool IsSetBumper() => this.Bumper != null;

        /// <summary>
        /// Gets and sets the property CdnConfiguration. 
        /// <para>
        /// The configuration for using a content delivery network (CDN), like Amazon CloudFront,
        /// for content and ad segment management.
        /// </para>
        /// </summary>
        public CdnConfiguration CdnConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CdnConfiguration property is set.
        /// </summary>
        internal bool IsSetCdnConfiguration() => this.CdnConfiguration != null;

        /// <summary>
        /// Gets and sets the property ConfigurationAliases. 
        /// <para>
        /// The player parameters and aliases used as dynamic variables during session initialization.
        /// For more information, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/variables-domains.html">Domain
        /// Variables</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Dictionary<string, string>> ConfigurationAliases { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Dictionary<string, string>>() : null;

        /// <summary>
        /// Checks to see if the ConfigurationAliases property is set.
        /// </summary>
        internal bool IsSetConfigurationAliases() => this.ConfigurationAliases != null && (this.ConfigurationAliases.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DashConfiguration. 
        /// <para>
        /// The configuration for DASH content.
        /// </para>
        /// </summary>
        public DashConfigurationForPut DashConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DashConfiguration property is set.
        /// </summary>
        internal bool IsSetDashConfiguration() => this.DashConfiguration != null;

        /// <summary>
        /// Gets and sets the property FunctionMapping. 
        /// <para>
        /// A map of lifecycle hook event names to function identifiers. The function mapping
        /// specifies which function MediaTailor executes at each lifecycle hook during ad insertion.
        /// Valid keys are <c>PRE_SESSION_INITIALIZATION</c>, <c>PRE_ADS_REQUEST</c>, <c>POST_ADS_RESPONSE</c>,
        /// and <c>PRE_MANIFEST_INSERTION</c>. For more information, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/monetization-functions-hooks.html">Functions
        /// lifecycle hooks</a> in the <i>MediaTailor User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> FunctionMapping { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the FunctionMapping property is set.
        /// </summary>
        internal bool IsSetFunctionMapping() => this.FunctionMapping != null && (this.FunctionMapping.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public InsertionMode InsertionMode { get; set; }

        /// <summary>
        /// Checks to see if the InsertionMode property is set.
        /// </summary>
        internal bool IsSetInsertionMode() => this.InsertionMode != null;

        /// <summary>
        /// Gets and sets the property LivePreRollConfiguration. 
        /// <para>
        /// The configuration for pre-roll ad insertion.
        /// </para>
        /// </summary>
        public LivePreRollConfiguration LivePreRollConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LivePreRollConfiguration property is set.
        /// </summary>
        internal bool IsSetLivePreRollConfiguration() => this.LivePreRollConfiguration != null;

        /// <summary>
        /// Gets and sets the property ManifestProcessingRules. 
        /// <para>
        /// The configuration for manifest processing rules. Manifest processing rules enable
        /// customization of the personalized manifests created by MediaTailor.
        /// </para>
        /// </summary>
        public ManifestProcessingRules ManifestProcessingRules { get; set; }

        /// <summary>
        /// Checks to see if the ManifestProcessingRules property is set.
        /// </summary>
        internal bool IsSetManifestProcessingRules() => this.ManifestProcessingRules != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The identifier for the playback configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
        [AWSProperty(Min = 1)]
        public int? PersonalizationThresholdSeconds { get; set; }

        /// <summary>
        /// Checks to see if the PersonalizationThresholdSeconds property is set.
        /// </summary>
        internal bool IsSetPersonalizationThresholdSeconds() => this.PersonalizationThresholdSeconds.HasValue;

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
        public string SlateAdUrl { get; set; }

        /// <summary>
        /// Checks to see if the SlateAdUrl property is set.
        /// </summary>
        internal bool IsSetSlateAdUrl() => this.SlateAdUrl != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to assign to the playback configuration. Tags are key-value pairs that you
        /// can associate with Amazon resources to help with organization, access control, and
        /// cost tracking. For more information, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/tagging.html">Tagging
        /// AWS Elemental MediaTailor Resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TranscodeProfileName. 
        /// <para>
        /// The name that is used to associate this playback configuration with a custom transcode
        /// profile. This overrides the dynamic transcoding defaults of MediaTailor. Use this
        /// only if you have already set up custom profiles with the help of AWS Support.
        /// </para>
        /// </summary>
        public string TranscodeProfileName { get; set; }

        /// <summary>
        /// Checks to see if the TranscodeProfileName property is set.
        /// </summary>
        internal bool IsSetTranscodeProfileName() => this.TranscodeProfileName != null;

        /// <summary>
        /// Gets and sets the property VideoContentSourceUrl. 
        /// <para>
        /// The URL prefix for the parent manifest for the stream, minus the asset ID. The maximum
        /// length is 512 characters.
        /// </para>
        /// </summary>
        public string VideoContentSourceUrl { get; set; }

        /// <summary>
        /// Checks to see if the VideoContentSourceUrl property is set.
        /// </summary>
        internal bool IsSetVideoContentSourceUrl() => this.VideoContentSourceUrl != null;

        /// <summary>
        /// Gets and sets the property YieldOptimizationConfiguration. 
        /// <para>
        /// Configuration for Yield Optimization, which fills unsold ad inventory in ad breaks
        /// with programmatic ads from Amazon Publisher Services (APS).
        /// </para>
        /// </summary>
        public YieldOptimizationConfiguration YieldOptimizationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the YieldOptimizationConfiguration property is set.
        /// </summary>
        internal bool IsSetYieldOptimizationConfiguration() => this.YieldOptimizationConfiguration != null;
    }
}
