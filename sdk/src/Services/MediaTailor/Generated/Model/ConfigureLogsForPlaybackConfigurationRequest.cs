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
    /// Container for the parameters to the ConfigureLogsForPlaybackConfiguration operation.
    /// Amazon CloudWatch log settings for a playback configuration.
    /// </summary>
    public partial class ConfigureLogsForPlaybackConfigurationRequest : AmazonMediaTailorRequest
    {
        private int? _percentEnabled;
        private string _playbackConfigurationName;

        /// <summary>
        /// Gets and sets the property PercentEnabled. 
        /// <para>
        /// The percentage of session logs that MediaTailor sends to your Cloudwatch Logs account.
        /// For example, if your playback configuration has 1000 sessions and percentEnabled is
        /// set to <code>60</code>, MediaTailor sends logs for 600 of the sessions to CloudWatch
        /// Logs. MediaTailor decides at random which of the playback configuration sessions to
        /// send logs for. If you want to view logs for a specific session, you can use the <a
        /// href="https://docs.aws.amazon.com/mediatailor/latest/ug/debug-log-mode.html">debug
        /// log mode</a>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>0</code> - <code>100</code> 
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