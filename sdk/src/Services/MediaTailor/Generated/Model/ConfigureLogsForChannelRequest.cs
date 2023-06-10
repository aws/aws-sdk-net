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
    /// Container for the parameters to the ConfigureLogsForChannel operation.
    /// Configures Amazon CloudWatch log settings for a channel.
    /// </summary>
    public partial class ConfigureLogsForChannelRequest : AmazonMediaTailorRequest
    {
        private string _channelName;
        private List<string> _logTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ChannelName
        {
            get { return this._channelName; }
            set { this._channelName = value; }
        }

        // Check to see if ChannelName property is set
        internal bool IsSetChannelName()
        {
            return this._channelName != null;
        }

        /// <summary>
        /// Gets and sets the property LogTypes. 
        /// <para>
        /// The types of logs to collect.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> LogTypes
        {
            get { return this._logTypes; }
            set { this._logTypes = value; }
        }

        // Check to see if LogTypes property is set
        internal bool IsSetLogTypes()
        {
            return this._logTypes != null && this._logTypes.Count > 0; 
        }

    }
}