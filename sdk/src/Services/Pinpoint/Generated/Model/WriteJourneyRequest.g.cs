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
    /// Specifies the configuration and other settings for a journey.
    /// </summary>
    public partial class WriteJourneyRequest
    {
        /// <summary>
        /// Gets and sets the property Activities. 
        /// <para>
        /// A map that contains a set of Activity objects, one object for each activity in the
        /// journey. For each Activity object, the key is the unique identifier (string) for an
        /// activity and the value is the settings for the activity. An activity identifier can
        /// contain a maximum of 100 characters. The characters must be alphanumeric characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Activity> Activities { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Activity>() : null;

        /// <summary>
        /// Checks to see if the Activities property is set.
        /// </summary>
        internal bool IsSetActivities() => this.Activities != null && (this.Activities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClosedDays. 
        /// <para>
        /// The time when journey will stop sending messages. QuietTime should be configured first
        /// and SendingSchedule should be set to true.
        /// </para>
        /// </summary>
        public ClosedDays ClosedDays { get; set; }

        /// <summary>
        /// Checks to see if the ClosedDays property is set.
        /// </summary>
        internal bool IsSetClosedDays() => this.ClosedDays != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date, in ISO 8601 format, when the journey was created.
        /// </para>
        /// </summary>
        public string CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate != null;

        /// <summary>
        /// Gets and sets the property JourneyChannelSettings. 
        /// <para>
        /// The channel-specific configurations for the journey.
        /// </para>
        /// </summary>
        public JourneyChannelSettings JourneyChannelSettings { get; set; }

        /// <summary>
        /// Checks to see if the JourneyChannelSettings property is set.
        /// </summary>
        internal bool IsSetJourneyChannelSettings() => this.JourneyChannelSettings != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date, in ISO 8601 format, when the journey was last modified.
        /// </para>
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate != null;

        /// <summary>
        /// Gets and sets the property Limits. 
        /// <para>
        /// The messaging and entry limits for the journey.
        /// </para>
        /// </summary>
        public JourneyLimits Limits { get; set; }

        /// <summary>
        /// Checks to see if the Limits property is set.
        /// </summary>
        internal bool IsSetLimits() => this.Limits != null;

        /// <summary>
        /// Gets and sets the property LocalTime. 
        /// <para>
        /// Specifies whether the journey's scheduled start and end times use each participant's
        /// local time. To base the schedule on each participant's local time, set this value
        /// to true.
        /// </para>
        /// </summary>
        public bool? LocalTime { get; set; }

        /// <summary>
        /// Checks to see if the LocalTime property is set.
        /// </summary>
        internal bool IsSetLocalTime() => this.LocalTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the journey. A journey name can contain a maximum of 150 characters. The
        /// characters can be alphanumeric characters or symbols, such as underscores (_) or hyphens
        /// (-). A journey name can't contain any spaces.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OpenHours. 
        /// <para>
        /// The time when journey allow to send messages. QuietTime should be configured first
        /// and SendingSchedule should be set to true.
        /// </para>
        /// </summary>
        public OpenHours OpenHours { get; set; }

        /// <summary>
        /// Checks to see if the OpenHours property is set.
        /// </summary>
        internal bool IsSetOpenHours() => this.OpenHours != null;

        /// <summary>
        /// Gets and sets the property QuietTime. 
        /// <para>
        /// The quiet time settings for the journey. Quiet time is a specific time range when
        /// a journey doesn't send messages to participants, if all the following conditions are
        /// met:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// The EndpointDemographic.Timezone property of the endpoint for the participant is set
        /// to a valid value.
        /// </para>
        /// </li> <li>
        /// <para>
        /// The current time in the participant's time zone is later than or equal to the time
        /// specified by the QuietTime.Start property for the journey.
        /// </para>
        /// </li> <li>
        /// <para>
        /// The current time in the participant's time zone is earlier than or equal to the time
        /// specified by the QuietTime.End property for the journey.
        /// </para>
        /// </li></ul> 
        /// <para>
        /// If any of the preceding conditions isn't met, the participant will receive messages
        /// from the journey, even if quiet time is enabled.
        /// </para>
        /// </summary>
        public QuietTime QuietTime { get; set; }

        /// <summary>
        /// Checks to see if the QuietTime property is set.
        /// </summary>
        internal bool IsSetQuietTime() => this.QuietTime != null;

        /// <summary>
        /// Gets and sets the property RefreshFrequency. 
        /// <para>
        /// The frequency with which Amazon Pinpoint evaluates segment and event data for the
        /// journey, as a duration in ISO 8601 format.
        /// </para>
        /// </summary>
        public string RefreshFrequency { get; set; }

        /// <summary>
        /// Checks to see if the RefreshFrequency property is set.
        /// </summary>
        internal bool IsSetRefreshFrequency() => this.RefreshFrequency != null;

        /// <summary>
        /// Gets and sets the property RefreshOnSegmentUpdate. 
        /// <para>
        /// Indicates whether the journey participants should be refreshed when a segment is updated.
        /// </para>
        /// </summary>
        public bool? RefreshOnSegmentUpdate { get; set; }

        /// <summary>
        /// Checks to see if the RefreshOnSegmentUpdate property is set.
        /// </summary>
        internal bool IsSetRefreshOnSegmentUpdate() => this.RefreshOnSegmentUpdate.HasValue;

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule settings for the journey.
        /// </para>
        /// </summary>
        public JourneySchedule Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

        /// <summary>
        /// Gets and sets the property SendingSchedule. 
        /// <para>
        /// Indicates if journey has Advance Quiet Time enabled. This flag should be set to true
        /// in order to allow using OpenHours and ClosedDays.
        /// </para>
        /// </summary>
        public bool? SendingSchedule { get; set; }

        /// <summary>
        /// Checks to see if the SendingSchedule property is set.
        /// </summary>
        internal bool IsSetSendingSchedule() => this.SendingSchedule.HasValue;

        /// <summary>
        /// Gets and sets the property StartActivity. 
        /// <para>
        /// The unique identifier for the first activity in the journey. The identifier for this
        /// activity can contain a maximum of 128 characters. The characters must be alphanumeric
        /// characters.
        /// </para>
        /// </summary>
        public string StartActivity { get; set; }

        /// <summary>
        /// Checks to see if the StartActivity property is set.
        /// </summary>
        internal bool IsSetStartActivity() => this.StartActivity != null;

        /// <summary>
        /// Gets and sets the property StartCondition. 
        /// <para>
        /// The segment that defines which users are participants in the journey.
        /// </para>
        /// </summary>
        public StartCondition StartCondition { get; set; }

        /// <summary>
        /// Checks to see if the StartCondition property is set.
        /// </summary>
        internal bool IsSetStartCondition() => this.StartCondition != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The status of the journey. Valid values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// DRAFT - Saves the journey and doesn't publish it.
        /// </para>
        /// </li> <li>
        /// <para>
        /// ACTIVE - Saves and publishes the journey. Depending on the journey's schedule, the
        /// journey starts running immediately or at the scheduled start time. If a journey's
        /// status is ACTIVE, you can't add, change, or remove activities from it.
        /// </para>
        /// </li></ul> 
        /// <para>
        /// PAUSED, CANCELLED, COMPLETED, and CLOSED states are not supported in requests to create
        /// or update a journey. To cancel, pause, or resume a journey, use the <link linkend="apps-application-id-journeys-journey-id-state">Journey
        /// State</link> resource.
        /// </para>
        /// </summary>
        public State State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property TimezoneEstimationMethods. 
        /// <para>
        /// An array of time zone estimation methods, if any, to use for determining an <a href="https://docs.aws.amazon.com/pinpoint/latest/apireference/apps-application-id-endpoints-endpoint-id.html">Endpoints</a>
        /// time zone if the Endpoint does not have a value for the Demographic.Timezone attribute.
        /// </para>
        ///  <ul> <li>
        /// <para>
        /// PHONE_NUMBER - A time zone is determined based on the Endpoint.Address and Endpoint.Location.Country.
        /// </para>
        /// </li> <li>
        /// <para>
        /// POSTAL_CODE - A time zone is determined based on the Endpoint.Location.PostalCode
        /// and Endpoint.Location.Country.
        /// </para>
        ///  <note>
        /// <para>
        /// POSTAL_CODE detection is only supported in the United States, United Kingdom, Australia,
        /// New Zealand, Canada, France, Italy, Spain, Germany and in regions where Amazon Pinpoint
        /// is available.
        /// </para>
        /// </note></li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TimezoneEstimationMethods { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TimezoneEstimationMethods property is set.
        /// </summary>
        internal bool IsSetTimezoneEstimationMethods() => this.TimezoneEstimationMethods != null && (this.TimezoneEstimationMethods.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WaitForQuietTime. 
        /// <para>
        /// Specifies whether endpoints in quiet hours should enter a wait till the end of their
        /// quiet hours.
        /// </para>
        /// </summary>
        public bool? WaitForQuietTime { get; set; }

        /// <summary>
        /// Checks to see if the WaitForQuietTime property is set.
        /// </summary>
        internal bool IsSetWaitForQuietTime() => this.WaitForQuietTime.HasValue;
    }
}
