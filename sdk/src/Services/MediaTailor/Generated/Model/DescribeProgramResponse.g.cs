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
    /// This is the response object from the DescribeProgram operation.
    /// </summary>
    public partial class DescribeProgramResponse : AmazonWebServiceResponse
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
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the program.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

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
        /// The name of the channel that the program belongs to.
        /// </para>
        /// </summary>
        public string ChannelName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelName property is set.
        /// </summary>
        internal bool IsSetChannelName() => this.ChannelName != null;

        /// <summary>
        /// Gets and sets the property ClipRange. 
        /// <para>
        /// The clip range configuration settings.
        /// </para>
        /// </summary>
        public ClipRange ClipRange { get; set; }

        /// <summary>
        /// Checks to see if the ClipRange property is set.
        /// </summary>
        internal bool IsSetClipRange() => this.ClipRange != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp of when the program was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DurationMillis. 
        /// <para>
        /// The duration of the live program in milliseconds.
        /// </para>
        /// </summary>
        public long? DurationMillis { get; set; }

        /// <summary>
        /// Checks to see if the DurationMillis property is set.
        /// </summary>
        internal bool IsSetDurationMillis() => this.DurationMillis.HasValue;

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
        /// The name of the program.
        /// </para>
        /// </summary>
        public string ProgramName { get; set; }

        /// <summary>
        /// Checks to see if the ProgramName property is set.
        /// </summary>
        internal bool IsSetProgramName() => this.ProgramName != null;

        /// <summary>
        /// Gets and sets the property ScheduledStartTime. 
        /// <para>
        /// The date and time that the program is scheduled to start in ISO 8601 format and Coordinated
        /// Universal Time (UTC). For example, the value 2021-03-27T17:48:16.751Z represents March
        /// 27, 2021 at 17:48:16.751 UTC.
        /// </para>
        /// </summary>
        public DateTime? ScheduledStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledStartTime property is set.
        /// </summary>
        internal bool IsSetScheduledStartTime() => this.ScheduledStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property SourceLocationName. 
        /// <para>
        /// The source location name.
        /// </para>
        /// </summary>
        public string SourceLocationName { get; set; }

        /// <summary>
        /// Checks to see if the SourceLocationName property is set.
        /// </summary>
        internal bool IsSetSourceLocationName() => this.SourceLocationName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the program. Tags are key-value pairs that you can associate
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
