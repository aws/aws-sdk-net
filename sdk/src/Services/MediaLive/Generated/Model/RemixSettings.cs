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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Remix Settings
    /// </summary>
    public partial class RemixSettings
    {
        private List<AudioChannelMapping> _channelMappings = AWSConfigs.InitializeCollections ? new List<AudioChannelMapping>() : null;
        private int? _channelsIn;
        private int? _channelsOut;

        /// <summary>
        /// Gets and sets the property ChannelMappings. Mapping of input channels to output channels,
        /// with appropriate gain adjustments.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AudioChannelMapping> ChannelMappings
        {
            get { return this._channelMappings; }
            set { this._channelMappings = value; }
        }

        // Check to see if ChannelMappings property is set
        internal bool IsSetChannelMappings()
        {
            return this._channelMappings != null && (this._channelMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ChannelsIn. Number of input channels to be used.
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
        public int? ChannelsIn
        {
            get { return this._channelsIn; }
            set { this._channelsIn = value; }
        }

        // Check to see if ChannelsIn property is set
        internal bool IsSetChannelsIn()
        {
            return this._channelsIn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ChannelsOut. Number of output channels to be produced.Valid
        /// values: 1, 2, 4, 6, 8
        /// </summary>
        [AWSProperty(Min=1, Max=8)]
        public int? ChannelsOut
        {
            get { return this._channelsOut; }
            set { this._channelsOut = value; }
        }

        // Check to see if ChannelsOut property is set
        internal bool IsSetChannelsOut()
        {
            return this._channelsOut.HasValue; 
        }

    }
}