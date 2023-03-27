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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// The logging configuration associated with an Amazon Chime SDK Voice Connector. Specifies
    /// whether SIP message logs can be sent to Amazon CloudWatch Logs.
    /// </summary>
    public partial class LoggingConfiguration
    {
        private bool? _enableMediaMetricLogs;
        private bool? _enableSIPLogs;

        /// <summary>
        /// Gets and sets the property EnableMediaMetricLogs. 
        /// <para>
        /// Enables or disables media metrics logging.
        /// </para>
        /// </summary>
        public bool EnableMediaMetricLogs
        {
            get { return this._enableMediaMetricLogs.GetValueOrDefault(); }
            set { this._enableMediaMetricLogs = value; }
        }

        // Check to see if EnableMediaMetricLogs property is set
        internal bool IsSetEnableMediaMetricLogs()
        {
            return this._enableMediaMetricLogs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableSIPLogs. 
        /// <para>
        /// Boolean that enables sending SIP message logs to Amazon CloudWatch logs.
        /// </para>
        /// </summary>
        public bool EnableSIPLogs
        {
            get { return this._enableSIPLogs.GetValueOrDefault(); }
            set { this._enableSIPLogs = value; }
        }

        // Check to see if EnableSIPLogs property is set
        internal bool IsSetEnableSIPLogs()
        {
            return this._enableSIPLogs.HasValue; 
        }

    }
}