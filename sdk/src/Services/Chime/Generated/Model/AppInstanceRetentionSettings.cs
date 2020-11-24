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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// The length of time in days to retain messages.
    /// </summary>
    public partial class AppInstanceRetentionSettings
    {
        private ChannelRetentionSettings _channelRetentionSettings;

        /// <summary>
        /// Gets and sets the property ChannelRetentionSettings. 
        /// <para>
        /// The length of time in days to retain a channel.
        /// </para>
        /// </summary>
        public ChannelRetentionSettings ChannelRetentionSettings
        {
            get { return this._channelRetentionSettings; }
            set { this._channelRetentionSettings = value; }
        }

        // Check to see if ChannelRetentionSettings property is set
        internal bool IsSetChannelRetentionSettings()
        {
            return this._channelRetentionSettings != null;
        }

    }
}