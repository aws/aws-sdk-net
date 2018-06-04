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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Use Manual audio remixing (RemixSettings) to adjust audio levels for each audio channel
    /// in each output of your job. With audio remixing, you can output more or fewer audio
    /// channels than your input audio source provides.
    /// </summary>
    public partial class RemixSettings
    {
        private ChannelMapping _channelMapping;
        private int? _channelsIn;
        private int? _channelsOut;

        /// <summary>
        /// Gets and sets the property ChannelMapping.
        /// </summary>
        public ChannelMapping ChannelMapping
        {
            get { return this._channelMapping; }
            set { this._channelMapping = value; }
        }

        // Check to see if ChannelMapping property is set
        internal bool IsSetChannelMapping()
        {
            return this._channelMapping != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelsIn. Specify the number of audio channels from your
        /// input that you want to use in your output. With remixing, you might combine or split
        /// the data in these channels, so the number of channels in your final output might be
        /// different.
        /// </summary>
        public int ChannelsIn
        {
            get { return this._channelsIn.GetValueOrDefault(); }
            set { this._channelsIn = value; }
        }

        // Check to see if ChannelsIn property is set
        internal bool IsSetChannelsIn()
        {
            return this._channelsIn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ChannelsOut. Specify the number of channels in this output
        /// after remixing. Valid values: 1, 2, 4, 6, 8
        /// </summary>
        public int ChannelsOut
        {
            get { return this._channelsOut.GetValueOrDefault(); }
            set { this._channelsOut = value; }
        }

        // Check to see if ChannelsOut property is set
        internal bool IsSetChannelsOut()
        {
            return this._channelsOut.HasValue; 
        }

    }
}