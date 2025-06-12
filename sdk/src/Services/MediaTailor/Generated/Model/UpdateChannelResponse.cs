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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// This is the response object from the UpdateChannel operation.
    /// </summary>
    public partial class UpdateChannelResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private List<string> _audiences = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _channelName;
        private ChannelState _channelState;
        private DateTime? _creationTime;
        private SlateSource _fillerSlate;
        private DateTime? _lastModifiedTime;
        private List<ResponseOutputItem> _outputs = AWSConfigs.InitializeCollections ? new List<ResponseOutputItem>() : null;
        private string _playbackMode;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _tier;
        private TimeShiftConfiguration _timeShiftConfiguration;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) associated with the channel.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Audiences. 
        /// <para>
        /// The list of audiences defined in channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Audiences
        {
            get { return this._audiences; }
            set { this._audiences = value; }
        }

        // Check to see if Audiences property is set
        internal bool IsSetAudiences()
        {
            return this._audiences != null && (this._audiences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the channel.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ChannelState. 
        /// <para>
        /// Returns the state whether the channel is running or not.
        /// </para>
        /// </summary>
        public ChannelState ChannelState
        {
            get { return this._channelState; }
            set { this._channelState = value; }
        }

        // Check to see if ChannelState property is set
        internal bool IsSetChannelState()
        {
            return this._channelState != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp of when the channel was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FillerSlate. 
        /// <para>
        /// The slate used to fill gaps between programs in the schedule. You must configure filler
        /// slate if your channel uses the <c>LINEAR</c> <c>PlaybackMode</c>. MediaTailor doesn't
        /// support filler slate for channels using the <c>LOOP</c> <c>PlaybackMode</c>.
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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp that indicates when the channel was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// The channel's output properties.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResponseOutputItem> Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this._outputs != null && (this._outputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PlaybackMode. 
        /// <para>
        /// The type of playback mode for this channel.
        /// </para>
        ///  
        /// <para>
        ///  <c>LINEAR</c> - Programs play back-to-back only once.
        /// </para>
        ///  
        /// <para>
        ///  <c>LOOP</c> - Programs play back-to-back in an endless loop. When the last program
        /// in the schedule plays, playback loops back to the first program in the schedule.
        /// </para>
        /// </summary>
        public string PlaybackMode
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
        /// The tags to assign to the channel. Tags are key-value pairs that you can associate
        /// with Amazon resources to help with organization, access control, and cost tracking.
        /// For more information, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/tagging.html">Tagging
        /// AWS Elemental MediaTailor Resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The tier associated with this Channel.
        /// </para>
        /// </summary>
        public string Tier
        {
            get { return this._tier; }
            set { this._tier = value; }
        }

        // Check to see if Tier property is set
        internal bool IsSetTier()
        {
            return this._tier != null;
        }

        /// <summary>
        /// Gets and sets the property TimeShiftConfiguration. 
        /// <para>
        ///  The time-shifted viewing configuration for the channel. 
        /// </para>
        /// </summary>
        public TimeShiftConfiguration TimeShiftConfiguration
        {
            get { return this._timeShiftConfiguration; }
            set { this._timeShiftConfiguration = value; }
        }

        // Check to see if TimeShiftConfiguration property is set
        internal bool IsSetTimeShiftConfiguration()
        {
            return this._timeShiftConfiguration != null;
        }

    }
}