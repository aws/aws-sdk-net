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
    /// Container for the parameters to the UpdateProgram operation. Updates a program within
    /// a channel.
    /// </summary>
    public partial class UpdateProgramRequest : AmazonMediaTailorRequest
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
        public UpdateProgramScheduleConfiguration ScheduleConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleConfiguration property is set.
        /// </summary>
        internal bool IsSetScheduleConfiguration() => this.ScheduleConfiguration != null;
    }
}
