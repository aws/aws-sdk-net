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
    /// This is the response object from the DescribeProgram operation.
    /// </summary>
    public partial class DescribeProgramResponse : AmazonWebServiceResponse
    {
        private List<AdBreak> _adBreaks = new List<AdBreak>();
        private string _arn;
        private string _channelName;
        private ClipRange _clipRange;
        private DateTime? _creationTime;
        private long? _durationMillis;
        private string _liveSourceName;
        private string _programName;
        private DateTime? _scheduledStartTime;
        private string _sourceLocationName;
        private string _vodSourceName;

        /// <summary>
        /// Gets and sets the property AdBreaks. 
        /// <para>
        /// The ad break configuration settings.
        /// </para>
        /// </summary>
        public List<AdBreak> AdBreaks
        {
            get { return this._adBreaks; }
            set { this._adBreaks = value; }
        }

        // Check to see if AdBreaks property is set
        internal bool IsSetAdBreaks()
        {
            return this._adBreaks != null && this._adBreaks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the program.
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
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the channel that the program belongs to.
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
        /// Gets and sets the property ClipRange. 
        /// <para>
        /// The clip range configuration settings.
        /// </para>
        /// </summary>
        public ClipRange ClipRange
        {
            get { return this._clipRange; }
            set { this._clipRange = value; }
        }

        // Check to see if ClipRange property is set
        internal bool IsSetClipRange()
        {
            return this._clipRange != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp of when the program was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DurationMillis. 
        /// <para>
        /// The duration of the live program in milliseconds.
        /// </para>
        /// </summary>
        public long DurationMillis
        {
            get { return this._durationMillis.GetValueOrDefault(); }
            set { this._durationMillis = value; }
        }

        // Check to see if DurationMillis property is set
        internal bool IsSetDurationMillis()
        {
            return this._durationMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LiveSourceName. 
        /// <para>
        /// The name of the LiveSource for this Program.
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
        /// Gets and sets the property ScheduledStartTime. 
        /// <para>
        /// The date and time that the program is scheduled to start in ISO 8601 format and Coordinated
        /// Universal Time (UTC). For example, the value 2021-03-27T17:48:16.751Z represents March
        /// 27, 2021 at 17:48:16.751 UTC.
        /// </para>
        /// </summary>
        public DateTime ScheduledStartTime
        {
            get { return this._scheduledStartTime.GetValueOrDefault(); }
            set { this._scheduledStartTime = value; }
        }

        // Check to see if ScheduledStartTime property is set
        internal bool IsSetScheduledStartTime()
        {
            return this._scheduledStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceLocationName. 
        /// <para>
        /// The source location name.
        /// </para>
        /// </summary>
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
        /// The name that's used to refer to a VOD source.
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