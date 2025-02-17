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
    /// Container for the parameters to the ConfigureLogsForPlaybackConfiguration operation.
    /// Defines where AWS Elemental MediaTailor sends logs for the playback configuration.
    /// </summary>
    public partial class ConfigureLogsForPlaybackConfigurationRequest : AmazonMediaTailorRequest
    {
        private List<string> _enabledLoggingStrategies = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _percentEnabled;
        private string _playbackConfigurationName;

        /// <summary>
        /// Gets and sets the property EnabledLoggingStrategies. 
        /// <para>
        /// The method used for collecting logs from AWS Elemental MediaTailor. To configure MediaTailor
        /// to send logs directly to Amazon CloudWatch Logs, choose <c>LEGACY_CLOUDWATCH</c>.
        /// To configure MediaTailor to send logs to CloudWatch, which then vends the logs to
        /// your destination of choice, choose <c>VENDED_LOGS</c>. Supported destinations are
        /// CloudWatch Logs log group, Amazon S3 bucket, and Amazon Data Firehose stream.
        /// </para>
        ///  
        /// <para>
        /// To use vended logs, you must configure the delivery destination in Amazon CloudWatch,
        /// as described in <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AWS-logs-and-resource-policy.html#AWS-vended-logs-permissions-V2">Enable
        /// logging from AWS services, Logging that requires additional permissions [V2]</a>.
        /// </para>
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
        /// Gets and sets the property PercentEnabled. 
        /// <para>
        /// The percentage of session logs that MediaTailor sends to your CloudWatch Logs account.
        /// For example, if your playback configuration has 1000 sessions and percentEnabled is
        /// set to <c>60</c>, MediaTailor sends logs for 600 of the sessions to CloudWatch Logs.
        /// MediaTailor decides at random which of the playback configuration sessions to send
        /// logs for. If you want to view logs for a specific session, you can use the <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/debug-log-mode.html">debug
        /// log mode</a>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>0</c> - <c>100</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int PercentEnabled
        {
            get { return this._percentEnabled.GetValueOrDefault(); }
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
        [AWSProperty(Required=true)]
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