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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Use Manual audio remixing to adjust audio levels for each audio channel in each output
    /// of your job. With audio remixing, you can output more or fewer audio channels than
    /// your input audio source provides.
    /// </summary>
    public partial class RemixSettings
    {
        private int? _audioDescriptionAudioChannel;
        private int? _audioDescriptionDataChannel;
        private ChannelMapping _channelMapping;
        private int? _channelsIn;
        private int? _channelsOut;

        /// <summary>
        /// Gets and sets the property AudioDescriptionAudioChannel. Optionally specify the channel
        /// in your input that contains your audio description audio signal. MediaConvert mixes
        /// your audio signal across all output channels, while reducing their volume according
        /// to your data stream. When you specify an audio description audio channel, you must
        /// also specify an audio description data channel. For more information about audio description
        /// signals, see the BBC WHP 198 and 051 white papers.
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public int? AudioDescriptionAudioChannel
        {
            get { return this._audioDescriptionAudioChannel; }
            set { this._audioDescriptionAudioChannel = value; }
        }

        // Check to see if AudioDescriptionAudioChannel property is set
        internal bool IsSetAudioDescriptionAudioChannel()
        {
            return this._audioDescriptionAudioChannel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AudioDescriptionDataChannel. Optionally specify the channel
        /// in your input that contains your audio description data stream. MediaConvert mixes
        /// your audio signal across all output channels, while reducing their volume according
        /// to your data stream. When you specify an audio description data channel, you must
        /// also specify an audio description audio channel. For more information about audio
        /// description signals, see the BBC WHP 198 and 051 white papers.
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public int? AudioDescriptionDataChannel
        {
            get { return this._audioDescriptionDataChannel; }
            set { this._audioDescriptionDataChannel = value; }
        }

        // Check to see if AudioDescriptionDataChannel property is set
        internal bool IsSetAudioDescriptionDataChannel()
        {
            return this._audioDescriptionDataChannel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ChannelMapping. Channel mapping contains the group of fields
        /// that hold the remixing value for each channel, in dB. Specify remix values to indicate
        /// how much of the content from your input audio channel you want in your output audio
        /// channels. Each instance of the InputChannels or InputChannelsFineTune array specifies
        /// these values for one output channel. Use one instance of this array for each output
        /// channel. In the console, each array corresponds to a column in the graphical depiction
        /// of the mapping matrix. The rows of the graphical matrix correspond to input channels.
        /// Valid values are within the range from -60 (mute) through 6. A setting of 0 passes
        /// the input channel unchanged to the output channel (no attenuation or amplification).
        /// Use InputChannels or InputChannelsFineTune to specify your remix values. Don't use
        /// both.
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
        /// different. If you are doing both input channel mapping and output channel mapping,
        /// the number of output channels in your input mapping must be the same as the number
        /// of input channels in your output mapping.
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property ChannelsOut. Specify the number of channels in this output
        /// after remixing. Valid values: 1, 2, 4, 6, 8... 64. (1 and even numbers to 64.) If
        /// you are doing both input channel mapping and output channel mapping, the number of
        /// output channels in your input mapping must be the same as the number of input channels
        /// in your output mapping.
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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