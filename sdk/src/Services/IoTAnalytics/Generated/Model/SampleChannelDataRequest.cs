/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// Container for the parameters to the SampleChannelData operation.
    /// Retrieves a sample of messages from the specified channel ingested during the specified
    /// timeframe. Up to 10 messages can be retrieved.
    /// </summary>
    public partial class SampleChannelDataRequest : AmazonIoTAnalyticsRequest
    {
        private string _channelName;
        private DateTime? _endTimeUtc;
        private int? _maxMessages;
        private DateTime? _startTimeUtc;

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the channel whose message samples are retrieved.
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
        /// Gets and sets the property EndTimeUtc. 
        /// <para>
        /// The end of the time window from which sample messages are retrieved.
        /// </para>
        /// </summary>
        public DateTime EndTimeUtc
        {
            get { return this._endTimeUtc.GetValueOrDefault(); }
            set { this._endTime = this._endTimeUtc = value; }
        }

        // Check to see if EndTimeUtc property is set
        internal bool IsSetEndTimeUtc()
        {
            return this._endTimeUtc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxMessages. 
        /// <para>
        /// The number of sample messages to be retrieved. The limit is 10, the default is also
        /// 10.
        /// </para>
        /// </summary>
        public int MaxMessages
        {
            get { return this._maxMessages.GetValueOrDefault(); }
            set { this._maxMessages = value; }
        }

        // Check to see if MaxMessages property is set
        internal bool IsSetMaxMessages()
        {
            return this._maxMessages.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTimeUtc. 
        /// <para>
        /// The start of the time window from which sample messages are retrieved.
        /// </para>
        /// </summary>
        public DateTime StartTimeUtc
        {
            get { return this._startTimeUtc.GetValueOrDefault(); }
            set { this._startTime = this._startTimeUtc = value; }
        }

        // Check to see if StartTimeUtc property is set
        internal bool IsSetStartTimeUtc()
        {
            return this._startTimeUtc.HasValue; 
        }

#region Backwards compatible properties
        private DateTime? _endTime;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTimeUtc. 
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use EndTimeUtc instead. Setting either EndTime or EndTimeUtc
        /// results in both EndTime and EndTimeUtc being assigned, the latest assignment to either
        /// one of the two property is reflected in the value of both. EndTime is provided for
        /// backwards compatibility only and assigning a non-Utc DateTime to it results in the
        /// wrong timestamp being passed to the service.
        /// </para>
        ///  
        /// <para>
        /// The end of the time window from which sample messages are retrieved.
        /// </para>
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use EndTimeUtc instead. Setting either EndTime or EndTimeUtc results in both EndTime and " +
            "EndTimeUtc being assigned, the latest assignment to either one of the two property is " + 
            "reflected in the value of both. EndTime is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set
            {
                this._endTime = value;
                this._endTimeUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }
        /// <summary>
        /// Gets and sets the property StartTimeUtc. 
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use StartTimeUtc instead. Setting either StartTime or
        /// StartTimeUtc results in both StartTime and StartTimeUtc being assigned, the latest
        /// assignment to either one of the two property is reflected in the value of both. StartTime
        /// is provided for backwards compatibility only and assigning a non-Utc DateTime to it
        /// results in the wrong timestamp being passed to the service.
        /// </para>
        ///  
        /// <para>
        /// The start of the time window from which sample messages are retrieved.
        /// </para>
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use StartTimeUtc instead. Setting either StartTime or StartTimeUtc results in both StartTime and " +
            "StartTimeUtc being assigned, the latest assignment to either one of the two property is " + 
            "reflected in the value of both. StartTime is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set
            {
                this._startTime = value;
                this._startTimeUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }
#endregion
    }
}