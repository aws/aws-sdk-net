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
    /// This is the response object from the ConfigureLogsForPlaybackConfiguration operation.
    /// </summary>
    public partial class ConfigureLogsForPlaybackConfigurationResponse : AmazonWebServiceResponse
    {
        private AdsInteractionLog _adsInteractionLog;
        private List<string> _enabledLoggingStrategies = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ManifestServiceInteractionLog _manifestServiceInteractionLog;
        private int? _percentEnabled;
        private string _playbackConfigurationName;

        /// <summary>
        /// Gets and sets the property AdsInteractionLog. 
        /// <para>
        /// The event types that MediaTailor emits in logs for interactions with the ADS.
        /// </para>
        /// </summary>
        public AdsInteractionLog AdsInteractionLog
        {
            get { return this._adsInteractionLog; }
            set { this._adsInteractionLog = value; }
        }

        // Check to see if AdsInteractionLog property is set
        internal bool IsSetAdsInteractionLog()
        {
            return this._adsInteractionLog != null;
        }

        /// <summary>
        /// Gets and sets the property EnabledLoggingStrategies. 
        /// <para>
        /// The method used for collecting logs from AWS Elemental MediaTailor. <c>LEGACY_CLOUDWATCH</c>
        /// indicates that MediaTailor is sending logs directly to Amazon CloudWatch Logs. <c>VENDED_LOGS</c>
        /// indicates that MediaTailor is sending logs to CloudWatch, which then vends the logs
        /// to your destination of choice. Supported destinations are CloudWatch Logs log group,
        /// Amazon S3 bucket, and Amazon Data Firehose stream. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnabledLoggingStrategies
        {
            get { return this._enabledLoggingStrategies; }
            set { this._enabledLoggingStrategies = value; }
        }

        // Check to see if EnabledLoggingStrategies property is set
        internal bool IsSetEnabledLoggingStrategies()
        {
            return this._enabledLoggingStrategies != null && (this._enabledLoggingStrategies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ManifestServiceInteractionLog. 
        /// <para>
        /// The event types that MediaTailor emits in logs for interactions with the origin server.
        /// </para>
        /// </summary>
        public ManifestServiceInteractionLog ManifestServiceInteractionLog
        {
            get { return this._manifestServiceInteractionLog; }
            set { this._manifestServiceInteractionLog = value; }
        }

        // Check to see if ManifestServiceInteractionLog property is set
        internal bool IsSetManifestServiceInteractionLog()
        {
            return this._manifestServiceInteractionLog != null;
        }

        /// <summary>
        /// Gets and sets the property PercentEnabled. 
        /// <para>
        /// The percentage of session logs that MediaTailor sends to your Cloudwatch Logs account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? PercentEnabled
        {
            get { return this._percentEnabled; }
            set { this._percentEnabled = value; }
        }

        // Check to see if PercentEnabled property is set
        internal bool IsSetPercentEnabled()
        {
            return this._percentEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PlaybackConfigurationName. 
        /// <para>
        /// The name of the playback configuration.
        /// </para>
        /// </summary>
        public string PlaybackConfigurationName
        {
            get { return this._playbackConfigurationName; }
            set { this._playbackConfigurationName = value; }
        }

        // Check to see if PlaybackConfigurationName property is set
        internal bool IsSetPlaybackConfigurationName()
        {
            return this._playbackConfigurationName != null;
        }

    }
}