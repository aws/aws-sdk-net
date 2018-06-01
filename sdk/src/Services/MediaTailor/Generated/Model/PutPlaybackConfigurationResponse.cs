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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// This is the response object from the PutPlaybackConfiguration operation.
    /// </summary>
    public partial class PutPlaybackConfigurationResponse : AmazonWebServiceResponse
    {
        private string _adDecisionServerUrl;
        private CdnConfiguration _cdnConfiguration;
        private HlsConfiguration _hlsConfiguration;
        private string _name;
        private string _playbackEndpointPrefix;
        private string _sessionInitializationEndpointPrefix;
        private string _slateAdUrl;
        private string _videoContentSourceUrl;

        /// <summary>
        /// Gets and sets the property AdDecisionServerUrl. 
        /// <para>
        /// The URL for the ad decision server (ADS). This includes the specification of static
        /// parameters and placeholders for dynamic parameters. AWS Elemental MediaTailor substitutes
        /// player-specific and session-specific parameters as needed when calling the ADS. Alternately,
        /// for testing, you can provide a static VAST URL. The maximum length is 25000 characters.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The identifier for the configuration.
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
        /// URL for a high-quality video asset to transcode and use to fill in time that's not
        /// used by ads. AWS Elemental MediaTailor shows the slate to fill in gaps in media content.
        /// Configuring the slate is optional for non-VPAID configurations. For VPAID, the slate
        /// is required because AWS Elemental MediaTailor provides it in the slots designated
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