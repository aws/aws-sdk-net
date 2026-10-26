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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the schedule settings for a campaign.
    /// </summary>
    public partial class Schedule
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The scheduled time, in ISO 8601 format, when the campaign ended or will end.
        /// </para>
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime != null;

        /// <summary>
        /// Gets and sets the property EventFilter. 
        /// <para>
        /// The type of event that causes the campaign to be sent, if the value of the Frequency
        /// property is EVENT.
        /// </para>
        /// </summary>
        public CampaignEventFilter EventFilter { get; set; }

        /// <summary>
        /// Checks to see if the EventFilter property is set.
        /// </summary>
        internal bool IsSetEventFilter() => this.EventFilter != null;

        /// <summary>
        /// Gets and sets the property Frequency. 
        /// <para>
        /// Specifies how often the campaign is sent or whether the campaign is sent in response
        /// to a specific event.
        /// </para>
        /// </summary>
        public Frequency Frequency { get; set; }

        /// <summary>
        /// Checks to see if the Frequency property is set.
        /// </summary>
        internal bool IsSetFrequency() => this.Frequency != null;

        /// <summary>
        /// Gets and sets the property IsLocalTime. 
        /// <para>
        /// Specifies whether the start and end times for the campaign schedule use each recipient's
        /// local time. To base the schedule on each recipient's local time, set this value to
        /// true.
        /// </para>
        /// </summary>
        public bool? IsLocalTime { get; set; }

        /// <summary>
        /// Checks to see if the IsLocalTime property is set.
        /// </summary>
        internal bool IsSetIsLocalTime() => this.IsLocalTime.HasValue;

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
        public QuietTime QuietTime { get; set; }

        /// <summary>
        /// Checks to see if the QuietTime property is set.
        /// </summary>
        internal bool IsSetQuietTime() => this.QuietTime != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The scheduled time when the campaign began or will begin. Valid values are: IMMEDIATE,
        /// to start the campaign immediately; or, a specific time in ISO 8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime != null;

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The starting UTC offset for the campaign schedule, if the value of the IsLocalTime
        /// property is true. Valid values are: UTC, UTC+01, UTC+02, UTC+03, UTC+03:30, UTC+04,
        /// UTC+04:30, UTC+05, UTC+05:30, UTC+05:45, UTC+06, UTC+06:30, UTC+07, UTC+08, UTC+09,
        /// UTC+09:30, UTC+10, UTC+10:30, UTC+11, UTC+12, UTC+13, UTC-02, UTC-03, UTC-04, UTC-05,
        /// UTC-06, UTC-07, UTC-08, UTC-09, UTC-10, and UTC-11.
        /// </para>
        /// </summary>
        public string Timezone { get; set; }

        /// <summary>
        /// Checks to see if the Timezone property is set.
        /// </summary>
        internal bool IsSetTimezone() => this.Timezone != null;
    }
}
