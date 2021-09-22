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
    /// Container for the parameters to the CreateChannel operation.
    /// Creates a channel.
    /// </summary>
    public partial class CreateChannelRequest : AmazonMediaTailorRequest
    {
        private string _channelName;
        private SlateSource _fillerSlate;
        private List<RequestOutputItem> _outputs = new List<RequestOutputItem>();
        private PlaybackMode _playbackMode;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The identifier for the channel you are working on.
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
        /// Gets and sets the property FillerSlate. 
        /// <para>
        /// The slate used to fill gaps between programs in the schedule. You must configure filler
        /// slate if your channel uses a LINEAR PlaybackMode.
        /// </para>
        /// </summary>
        public SlateSource FillerSlate
        {
            get { return this._fillerSlate; }
            set { this._fillerSlate = value; }
        }

        // Check to see if FillerSlate property is set
        internal bool IsSetFillerSlate()
        {
            return this._fillerSlate != null;
        }

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// The channel's output properties.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RequestOutputItem> Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this._outputs != null && this._outputs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PlaybackMode. 
        /// <para>
        /// The type of playback mode to use for this channel.
        /// </para>
        ///  
        /// <para>
        /// LINEAR - The programs in the schedule play once back-to-back in the schedule.
        /// </para>
        ///  
        /// <para>
        /// LOOP - The programs in the schedule play back-to-back in an endless loop. When the
        /// last program in the schedule stops playing, playback loops back to the first program
        /// in the schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PlaybackMode PlaybackMode
        {
            get { return this._playbackMode; }
            set { this._playbackMode = value; }
        }

        // Check to see if PlaybackMode property is set
        internal bool IsSetPlaybackMode()
        {
            return this._playbackMode != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to assign to the channel.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}