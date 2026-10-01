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
    /// Container for the parameters to the CreateProgram operation. Creates a program within
    /// a channel. For information about programs, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-programs.html">Working
    /// with programs</a> in the <i>MediaTailor User Guide</i>.
    /// </summary>
    public partial class CreateProgramRequest : AmazonMediaTailorRequest
    {
        /// <summary>
        /// Gets and sets the property AdBreaks. 
        /// <para>
        /// The ad break configuration settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AdBreak> AdBreaks { get; set; } = AWSConfigs.InitializeCollections ? new List<AdBreak>() : null;

        /// <summary>
        /// Checks to see if the AdBreaks property is set.
        /// </summary>
        internal bool IsSetAdBreaks() => this.AdBreaks != null && (this.AdBreaks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AudienceMedia. 
        /// <para>
        /// The list of AudienceMedia defined in program.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AudienceMedia> AudienceMedia { get; set; } = AWSConfigs.InitializeCollections ? new List<AudienceMedia>() : null;

        /// <summary>
        /// Checks to see if the AudienceMedia property is set.
        /// </summary>
        internal bool IsSetAudienceMedia() => this.AudienceMedia != null && (this.AudienceMedia.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the channel for this Program.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelName property is set.
        /// </summary>
        internal bool IsSetChannelName() => this.ChannelName != null;

        /// <summary>
        /// Gets and sets the property LiveSourceName. 
        /// <para>
        /// The name of the LiveSource for this Program.
        /// </para>
        /// </summary>
        public string LiveSourceName { get; set; }

        /// <summary>
        /// Checks to see if the LiveSourceName property is set.
        /// </summary>
        internal bool IsSetLiveSourceName() => this.LiveSourceName != null;

        /// <summary>
        /// Gets and sets the property ProgramName. 
        /// <para>
        /// The name of the Program.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProgramName { get; set; }

        /// <summary>
        /// Checks to see if the ProgramName property is set.
        /// </summary>
        internal bool IsSetProgramName() => this.ProgramName != null;

        /// <summary>
        /// Gets and sets the property ScheduleConfiguration. 
        /// <para>
        /// The schedule configuration settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScheduleConfiguration ScheduleConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleConfiguration property is set.
        /// </summary>
        internal bool IsSetScheduleConfiguration() => this.ScheduleConfiguration != null;

        /// <summary>
        /// Gets and sets the property SourceLocationName. 
        /// <para>
        /// The name of the source location.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceLocationName { get; set; }

        /// <summary>
        /// Checks to see if the SourceLocationName property is set.
        /// </summary>
        internal bool IsSetSourceLocationName() => this.SourceLocationName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to assign to the program. Tags are key-value pairs that you can associate
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
        /// Gets and sets the property VodSourceName. 
        /// <para>
        /// The name that's used to refer to a VOD source.
        /// </para>
        /// </summary>
        public string VodSourceName { get; set; }

        /// <summary>
        /// Checks to see if the VodSourceName property is set.
        /// </summary>
        internal bool IsSetVodSourceName() => this.VodSourceName != null;
    }
}
