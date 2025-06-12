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
    /// The properties for a schedule.
    /// </summary>
    public partial class ScheduleEntry
    {
        private long? _approximateDurationSeconds;
        private DateTime? _approximateStartTime;
        private string _arn;
        private List<string> _audiences = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _channelName;
        private string _liveSourceName;
        private string _programName;
        private List<ScheduleAdBreak> _scheduleAdBreaks = AWSConfigs.InitializeCollections ? new List<ScheduleAdBreak>() : null;
        private ScheduleEntryType _scheduleEntryType;
        private string _sourceLocationName;
        private string _vodSourceName;

        /// <summary>
        /// Gets and sets the property ApproximateDurationSeconds. 
        /// <para>
        /// The approximate duration of this program, in seconds.
        /// </para>
        /// </summary>
        public long? ApproximateDurationSeconds
        {
            get { return this._approximateDurationSeconds; }
            set { this._approximateDurationSeconds = value; }
        }

        // Check to see if ApproximateDurationSeconds property is set
        internal bool IsSetApproximateDurationSeconds()
        {
            return this._approximateDurationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ApproximateStartTime. 
        /// <para>
        /// The approximate time that the program will start playing.
        /// </para>
        /// </summary>
        public DateTime? ApproximateStartTime
        {
            get { return this._approximateStartTime; }
            set { this._approximateStartTime = value; }
        }

        // Check to see if ApproximateStartTime property is set
        internal bool IsSetApproximateStartTime()
        {
            return this._approximateStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the program.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The list of audiences defined in ScheduleEntry.
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
        /// The name of the channel that uses this schedule.
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
        /// Gets and sets the property LiveSourceName. 
        /// <para>
        /// The name of the live source used for the program.
        /// </para>
        /// </summary>
        public string LiveSourceName
        {
            get { return this._liveSourceName; }
            set { this._liveSourceName = value; }
        }

        // Check to see if LiveSourceName property is set
        internal bool IsSetLiveSourceName()
        {
            return this._liveSourceName != null;
        }

        /// <summary>
        /// Gets and sets the property ProgramName. 
        /// <para>
        /// The name of the program.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProgramName
        {
            get { return this._programName; }
            set { this._programName = value; }
        }

        // Check to see if ProgramName property is set
        internal bool IsSetProgramName()
        {
            return this._programName != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleAdBreaks. 
        /// <para>
        /// The schedule's ad break properties.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ScheduleAdBreak> ScheduleAdBreaks
        {
            get { return this._scheduleAdBreaks; }
            set { this._scheduleAdBreaks = value; }
        }

        // Check to see if ScheduleAdBreaks property is set
        internal bool IsSetScheduleAdBreaks()
        {
            return this._scheduleAdBreaks != null && (this._scheduleAdBreaks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScheduleEntryType. 
        /// <para>
        /// The type of schedule entry.
        /// </para>
        /// </summary>
        public ScheduleEntryType ScheduleEntryType
        {
            get { return this._scheduleEntryType; }
            set { this._scheduleEntryType = value; }
        }

        // Check to see if ScheduleEntryType property is set
        internal bool IsSetScheduleEntryType()
        {
            return this._scheduleEntryType != null;
        }

        /// <summary>
        /// Gets and sets the property SourceLocationName. 
        /// <para>
        /// The name of the source location.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceLocationName
        {
            get { return this._sourceLocationName; }
            set { this._sourceLocationName = value; }
        }

        // Check to see if SourceLocationName property is set
        internal bool IsSetSourceLocationName()
        {
            return this._sourceLocationName != null;
        }

        /// <summary>
        /// Gets and sets the property VodSourceName. 
        /// <para>
        /// The name of the VOD source.
        /// </para>
        /// </summary>
        public string VodSourceName
        {
            get { return this._vodSourceName; }
            set { this._vodSourceName = value; }
        }

        // Check to see if VodSourceName property is set
        internal bool IsSetVodSourceName()
        {
            return this._vodSourceName != null;
        }

    }
}