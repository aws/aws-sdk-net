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

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// The AWSMediaTailor configuration.
    /// </summary>
    public partial class PlaybackConfiguration
    {
        private string _adDecisionServerUrl;
        private AvailSuppression _availSuppression;
        private Bumper _bumper;
        private CdnConfiguration _cdnConfiguration;
        private DashConfiguration _dashConfiguration;
        private HlsConfiguration _hlsConfiguration;
        private ManifestProcessingRules _manifestProcessingRules;
        private string _name;
        private int? _personalizationThresholdSeconds;
        private string _playbackConfigurationArn;
        private string _playbackEndpointPrefix;
        private string _sessionInitializationEndpointPrefix;
        private string _slateAdUrl;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _transcodeProfileName;
        private string _videoContentSourceUrl;

        /// <summary>
        /// Gets and sets the property AdDecisionServerUrl. 
        /// <para>
        /// The URL for the ad decision server (ADS). This includes the specification of static
        /// parameters and placeholders for dynamic parameters. AWS Elemental MediaTailor substitutes
        /// player-specific and session-specific parameters as needed when calling the ADS. Alternately,
        /// for testing, you can provide a static VAST URL. The maximum length is 25,000 characters.
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
        /// The configuration for Avail Suppression. Ad suppression can be used to turn off ad
        /// personalization in a long manifest, or if a viewer joins mid-break.
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
        /// the start or before the end of an ad break. 
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
        /// Gets and sets the property DashConfiguration. 
        /// <para>
        /// The configuration for DASH content. 
        /// </para>
        /// </summary>
        public DashConfiguration DashConfiguration
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
        /// Gets and sets the property HlsConfiguration. 
        /// <para>
        /// The configuration for HLS content. 
        /// </para>
        /// </summary>
        public HlsConfiguration HlsConfiguration
        {
            get { return this._hlsConfiguration; }
            set { this._hlsConfiguration = value; }
        }

        // Check to see if HlsConfiguration property is set
        internal bool IsSetHlsConfiguration()
        {
            return this._hlsConfiguration != null;
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
        /// The maximum duration of underfilled ad time (in seconds) allowed in an ad break.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int PersonalizationThresholdSeconds
        {
            get { return this._personalizationThresholdSeconds.GetValueOrDefault(); }
            set { this._personalizationThresholdSeconds = value; }
        }

        // Check to see if PersonalizationThresholdSeconds property is set
        internal bool IsSetPersonalizationThresholdSeconds()
        {
            return this._personalizationThresholdSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PlaybackConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the playback configuration. 
        /// </para>
        /// </summary>
        public string PlaybackConfigurationArn
        {
            get { return this._playbackConfigurationArn; }
            set { this._playbackConfigurationArn = value; }
        }

        // Check to see if PlaybackConfigurationArn property is set
        internal bool IsSetPlaybackConfigurationArn()
        {
            return this._playbackConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property PlaybackEndpointPrefix. 
        /// <para>
        /// The URL that the player accesses to get a manifest from AWS Elemental MediaTailor.
        /// This session will use server-side reporting. 
        /// </para>
        /// </summary>
        public string PlaybackEndpointPrefix
        {
            get { return this._playbackEndpointPrefix; }
            set { this._playbackEndpointPrefix = value; }
        }

        // Check to see if PlaybackEndpointPrefix property is set
        internal bool IsSetPlaybackEndpointPrefix()
        {
            return this._playbackEndpointPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property SessionInitializationEndpointPrefix. 
        /// <para>
        /// The URL that the player uses to initialize a session that uses client-side reporting.
        /// 
        /// </para>
        /// </summary>
        public string SessionInitializationEndpointPrefix
        {
            get { return this._sessionInitializationEndpointPrefix; }
            set { this._sessionInitializationEndpointPrefix = value; }
        }

        // Check to see if SessionInitializationEndpointPrefix property is set
        internal bool IsSetSessionInitializationEndpointPrefix()
        {
            return this._sessionInitializationEndpointPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property SlateAdUrl. 
        /// <para>
        /// The URL for a high-quality video asset to transcode and use to fill in time that's
        /// not used by ads. AWS Elemental MediaTailor shows the slate to fill in gaps in media
        /// content. Configuring the slate is optional for non-VPAID playback configurations.
        /// For VPAID, the slate is required because MediaTailor provides it in the slots designated
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
        /// The tags assigned to the playback configuration. 
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
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
        /// The URL prefix for the master playlist for the stream, minus the asset ID. The maximum
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