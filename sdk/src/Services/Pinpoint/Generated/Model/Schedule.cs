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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the schedule settings for a campaign.
    /// </summary>
    public partial class Schedule
    {
        private string _endTime;
        private CampaignEventFilter _eventFilter;
        private Frequency _frequency;
        private bool? _isLocalTime;
        private QuietTime _quietTime;
        private string _startTime;
        private string _timezone;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The scheduled time, in ISO 8601 format, when the campaign ended or will end.
        /// </para>
        /// </summary>
        public string EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime != null;
        }

        /// <summary>
        /// Gets and sets the property EventFilter. 
        /// <para>
        /// The type of event that causes the campaign to be sent, if the value of the Frequency
        /// property is EVENT.
        /// </para>
        /// </summary>
        public CampaignEventFilter EventFilter
        {
            get { return this._eventFilter; }
            set { this._eventFilter = value; }
        }

        // Check to see if EventFilter property is set
        internal bool IsSetEventFilter()
        {
            return this._eventFilter != null;
        }

        /// <summary>
        /// Gets and sets the property Frequency. 
        /// <para>
        /// Specifies how often the campaign is sent or whether the campaign is sent in response
        /// to a specific event.
        /// </para>
        /// </summary>
        public Frequency Frequency
        {
            get { return this._frequency; }
            set { this._frequency = value; }
        }

        // Check to see if Frequency property is set
        internal bool IsSetFrequency()
        {
            return this._frequency != null;
        }

        /// <summary>
        /// Gets and sets the property IsLocalTime. 
        /// <para>
        /// Specifies whether the start and end times for the campaign schedule use each recipient's
        /// local time. To base the schedule on each recipient's local time, set this value to
        /// true.
        /// </para>
        /// </summary>
        public bool? IsLocalTime
        {
            get { return this._isLocalTime; }
            set { this._isLocalTime = value; }
        }

        // Check to see if IsLocalTime property is set
        internal bool IsSetIsLocalTime()
        {
            return this._isLocalTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QuietTime. 
        /// <para>
        /// The default quiet time for the campaign. Quiet time is a specific time range when
        /// a campaign doesn't send messages to endpoints, if all the following conditions are
        /// met:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// The EndpointDemographic.Timezone property of the endpoint is set to a valid value.
        /// </para>
        /// </li> <li>
        /// <para>
        /// The current time in the endpoint's time zone is later than or equal to the time specified
        /// by the QuietTime.Start property for the campaign.
        /// </para>
        /// </li> <li>
        /// <para>
        /// The current time in the endpoint's time zone is earlier than or equal to the time
        /// specified by the QuietTime.End property for the campaign.
        /// </para>
        /// </li></ul> 
        /// <para>
        /// If any of the preceding conditions isn't met, the endpoint will receive messages from
        /// the campaign, even if quiet time is enabled.
        /// </para>
        /// </summary>
        public QuietTime QuietTime
        {
            get { return this._quietTime; }
            set { this._quietTime = value; }
        }

        // Check to see if QuietTime property is set
        internal bool IsSetQuietTime()
        {
            return this._quietTime != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The scheduled time when the campaign began or will begin. Valid values are: IMMEDIATE,
        /// to start the campaign immediately; or, a specific time in ISO 8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime != null;
        }

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The starting UTC offset for the campaign schedule, if the value of the IsLocalTime
        /// property is true. Valid values are: UTC, UTC+01, UTC+02, UTC+03, UTC+03:30, UTC+04,
        /// UTC+04:30, UTC+05,                  UTC+05:30, UTC+05:45, UTC+06, UTC+06:30, UTC+07,
        /// UTC+08, UTC+09, UTC+09:30,                  UTC+10, UTC+10:30, UTC+11, UTC+12, UTC+13,
        /// UTC-02, UTC-03, UTC-04, UTC-05, UTC-06,                  UTC-07, UTC-08, UTC-09, UTC-10,
        /// and UTC-11.
        /// </para>
        /// </summary>
        public string Timezone
        {
            get { return this._timezone; }
            set { this._timezone = value; }
        }

        // Check to see if Timezone property is set
        internal bool IsSetTimezone()
        {
            return this._timezone != null;
        }

    }
}