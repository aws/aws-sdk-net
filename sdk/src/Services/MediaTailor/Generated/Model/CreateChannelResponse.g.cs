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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the CreateChannel operation.
    /// </summary>
    public partial class CreateChannelResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) to assign to the channel.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Audiences. 
        /// <para>
        /// The list of audiences defined in channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Audiences { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Audiences property is set.
        /// </summary>
        internal bool IsSetAudiences() => this.Audiences != null && (this.Audiences.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name to assign to the channel.
        /// </para>
        /// </summary>
        public string ChannelName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelName property is set.
        /// </summary>
        internal bool IsSetChannelName() => this.ChannelName != null;

        /// <summary>
        /// Gets and sets the property ChannelState. 
        /// <para>
        /// Indicates whether the channel is in a running state or not.
        /// </para>
        /// </summary>
        public ChannelState ChannelState { get; set; }

        /// <summary>
        /// Checks to see if the ChannelState property is set.
        /// </summary>
        internal bool IsSetChannelState() => this.ChannelState != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp of when the channel was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property FillerSlate. 
        /// <para>
        /// Contains information about the slate used to fill gaps between programs in the schedule.
        /// </para>
        /// </summary>
        public SlateSource FillerSlate { get; set; }

        /// <summary>
        /// Checks to see if the FillerSlate property is set.
        /// </summary>
        internal bool IsSetFillerSlate() => this.FillerSlate != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp of when the channel was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// The output properties to assign to the channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResponseOutputItem> Outputs { get; set; } = AWSConfigs.InitializeCollections ? new List<ResponseOutputItem>() : null;

        /// <summary>
        /// Checks to see if the Outputs property is set.
        /// </summary>
        internal bool IsSetOutputs() => this.Outputs != null && (this.Outputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PlaybackMode. 
        /// <para>
        /// The playback mode to assign to the channel.
        /// </para>
        /// </summary>
        public string PlaybackMode { get; set; }

        /// <summary>
        /// Checks to see if the PlaybackMode property is set.
        /// </summary>
        internal bool IsSetPlaybackMode() => this.PlaybackMode != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to assign to the channel. Tags are key-value pairs that you can associate
        /// with Amazon resources to help with organization, access control, and cost tracking.
        /// For more information, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/tagging.html">Tagging
        /// AWS Elemental MediaTailor Resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The tier of the channel.
        /// </para>
        /// </summary>
        public string Tier { get; set; }

        /// <summary>
        /// Checks to see if the Tier property is set.
        /// </summary>
        internal bool IsSetTier() => this.Tier != null;

        /// <summary>
        /// Gets and sets the property TimeShiftConfiguration. 
        /// <para>
        ///  The time-shifted viewing configuration assigned to the channel. 
        /// </para>
        /// </summary>
        public TimeShiftConfiguration TimeShiftConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TimeShiftConfiguration property is set.
        /// </summary>
        internal bool IsSetTimeShiftConfiguration() => this.TimeShiftConfiguration != null;
    }
}
