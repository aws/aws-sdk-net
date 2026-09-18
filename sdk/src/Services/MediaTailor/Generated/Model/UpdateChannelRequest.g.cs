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
    /// Container for the parameters to the UpdateChannel operation. Updates a channel. For
    /// information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
    /// with channels</a> in the <i>MediaTailor User Guide</i>.
    /// </summary>
    public partial class UpdateChannelRequest : AmazonMediaTailorRequest
    {
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
        /// The name of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelName property is set.
        /// </summary>
        internal bool IsSetChannelName() => this.ChannelName != null;

        /// <summary>
        /// Gets and sets the property FillerSlate. 
        /// <para>
        /// The slate used to fill gaps between programs in the schedule. You must configure filler
        /// slate if your channel uses the <c>LINEAR</c> <c>PlaybackMode</c>. MediaTailor doesn't
        /// support filler slate for channels using the <c>LOOP</c> <c>PlaybackMode</c>.
        /// </para>
        /// </summary>
        public SlateSource FillerSlate { get; set; }

        /// <summary>
        /// Checks to see if the FillerSlate property is set.
        /// </summary>
        internal bool IsSetFillerSlate() => this.FillerSlate != null;

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// The channel's output properties.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RequestOutputItem> Outputs { get; set; } = AWSConfigs.InitializeCollections ? new List<RequestOutputItem>() : null;

        /// <summary>
        /// Checks to see if the Outputs property is set.
        /// </summary>
        internal bool IsSetOutputs() => this.Outputs != null && (this.Outputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeShiftConfiguration. 
        /// <para>
        ///  The time-shifted viewing configuration you want to associate to the channel. 
        /// </para>
        /// </summary>
        public TimeShiftConfiguration TimeShiftConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TimeShiftConfiguration property is set.
        /// </summary>
        internal bool IsSetTimeShiftConfiguration() => this.TimeShiftConfiguration != null;
    }
}
