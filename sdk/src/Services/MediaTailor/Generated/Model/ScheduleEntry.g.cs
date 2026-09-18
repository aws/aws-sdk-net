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
    /// The properties for a schedule.
    /// </summary>
    public partial class ScheduleEntry
    {
        /// <summary>
        /// Gets and sets the property ApproximateDurationSeconds. 
        /// <para>
        /// The approximate duration of this program, in seconds.
        /// </para>
        /// </summary>
        public long? ApproximateDurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ApproximateDurationSeconds property is set.
        /// </summary>
        internal bool IsSetApproximateDurationSeconds() => this.ApproximateDurationSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property ApproximateStartTime. 
        /// <para>
        /// The approximate time that the program will start playing.
        /// </para>
        /// </summary>
        public DateTime? ApproximateStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ApproximateStartTime property is set.
        /// </summary>
        internal bool IsSetApproximateStartTime() => this.ApproximateStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the program.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Audiences. 
        /// <para>
        /// The list of audiences defined in ScheduleEntry.
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
        /// The name of the channel that uses this schedule.
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
        /// The name of the live source used for the program.
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
        [AWSProperty(Required = true)]
        public string ProgramName { get; set; }

        /// <summary>
        /// Checks to see if the ProgramName property is set.
        /// </summary>
        internal bool IsSetProgramName() => this.ProgramName != null;

        /// <summary>
        /// Gets and sets the property ScheduleAdBreaks. 
        /// <para>
        /// The schedule's ad break properties.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ScheduleAdBreak> ScheduleAdBreaks { get; set; } = AWSConfigs.InitializeCollections ? new List<ScheduleAdBreak>() : null;

        /// <summary>
        /// Checks to see if the ScheduleAdBreaks property is set.
        /// </summary>
        internal bool IsSetScheduleAdBreaks() => this.ScheduleAdBreaks != null && (this.ScheduleAdBreaks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScheduleEntryType. 
        /// <para>
        /// The type of schedule entry.
        /// </para>
        /// </summary>
        public ScheduleEntryType ScheduleEntryType { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleEntryType property is set.
        /// </summary>
        internal bool IsSetScheduleEntryType() => this.ScheduleEntryType != null;

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
        /// Gets and sets the property VodSourceName. 
        /// <para>
        /// The name of the VOD source.
        /// </para>
        /// </summary>
        public string VodSourceName { get; set; }

        /// <summary>
        /// Checks to see if the VodSourceName property is set.
        /// </summary>
        internal bool IsSetVodSourceName() => this.VodSourceName != null;
    }
}
