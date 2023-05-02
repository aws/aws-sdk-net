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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// Defines a streaming channel.
    /// </summary>
    public partial class StreamChannelDefinition
    {
        private List<ChannelDefinition> _channelDefinitions = new List<ChannelDefinition>();
        private int? _numberOfChannels;

        /// <summary>
        /// Gets and sets the property ChannelDefinitions. 
        /// <para>
        /// The definitions of the channels in a streaming channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<ChannelDefinition> ChannelDefinitions
        {
            get { return this._channelDefinitions; }
            set { this._channelDefinitions = value; }
        }

        // Check to see if ChannelDefinitions property is set
        internal bool IsSetChannelDefinitions()
        {
            return this._channelDefinitions != null && this._channelDefinitions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfChannels. 
        /// <para>
        /// The number of channels in a streaming channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public int NumberOfChannels
        {
            get { return this._numberOfChannels.GetValueOrDefault(); }
            set { this._numberOfChannels = value; }
        }

        // Check to see if NumberOfChannels property is set
        internal bool IsSetNumberOfChannels()
        {
            return this._numberOfChannels.HasValue; 
        }

    }
}