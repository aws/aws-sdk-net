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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides information about the general settings and status of all channels for an
    /// application, including channels that aren't enabled for the application.
    /// </summary>
    public partial class ChannelsResponse
    {
        private Dictionary<string, ChannelResponse> _channels = new Dictionary<string, ChannelResponse>();

        /// <summary>
        /// Gets and sets the property Channels. 
        /// <para>
        /// A map that contains a multipart response for each channel. For each item in this object,
        /// the ChannelType is the key and the Channel is the value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, ChannelResponse> Channels
        {
            get { return this._channels; }
            set { this._channels = value; }
        }

        // Check to see if Channels property is set
        internal bool IsSetChannels()
        {
            return this._channels != null && this._channels.Count > 0; 
        }

    }
}