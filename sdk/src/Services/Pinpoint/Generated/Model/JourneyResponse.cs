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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides information about the status, configuration, and other settings for a journey.
    /// </summary>
    public partial class JourneyResponse
    {
        private Dictionary<string, Activity> _activities = new Dictionary<string, Activity>();
        private string _applicationId;
        private string _creationDate;
        private string _id;
        private string _lastModifiedDate;
        private JourneyLimits _limits;
        private bool? _localTime;
        private string _name;
        private QuietTime _quietTime;
        private string _refreshFrequency;
        private JourneySchedule _schedule;
        private string _startActivity;
        private StartCondition _startCondition;
        private State _state;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Activities. 
        /// <para>
        /// A map that contains a set of Activity objects, one object for each activity in the
        /// journey. For each Activity object, the key is the unique identifier (string) for an
        /// activity and the value is the settings for the activity.
        /// </para>
        /// </summary>
        public Dictionary<string, Activity> Activities
        {
            get { return this._activities; }
            set { this._activities = value; }
        }

        // Check to see if Activities property is set
        internal bool IsSetActivities()
        {
            return this._activities != null && this._activities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier for the application that the journey applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date, in ISO 8601 format, when the journey was created.
        /// </para>
        /// </summary>
        public string CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the journey.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date, in ISO 8601 format, when the journey was last modified.
        /// </para>
        /// </summary>
        public string LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate != null;
        }

        /// <summary>
        /// Gets and sets the property Limits. 
        /// <para>
        /// The messaging and entry limits for the journey.
        /// </para>
        /// </summary>
        public JourneyLimits Limits
        {
            get { return this._limits; }
            set { this._limits = value; }
        }

        // Check to see if Limits property is set
        internal bool IsSetLimits()
        {
            return this._limits != null;
        }

        /// <summary>
        /// Gets and sets the property LocalTime. 
        /// <para>
        /// Specifies whether the journey's scheduled start and end times use each participant's
        /// local time. If this value is true, the schedule uses each participant's local time.
        /// </para>
        /// </summary>
        public bool LocalTime
        {
            get { return this._localTime.GetValueOrDefault(); }
            set { this._localTime = value; }
        }

        // Check to see if LocalTime property is set
        internal bool IsSetLocalTime()
        {
            return this._localTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the journey.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

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
        /// Gets and sets the property RefreshFrequency. 
        /// <para>
        /// The frequency with which Amazon Pinpoint evaluates segment and event data for the
        /// journey, as a duration in ISO 8601 format.
        /// </para>
        /// </summary>
        public string RefreshFrequency
        {
            get { return this._refreshFrequency; }
            set { this._refreshFrequency = value; }
        }

        // Check to see if RefreshFrequency property is set
        internal bool IsSetRefreshFrequency()
        {
            return this._refreshFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule settings for the journey.
        /// </para>
        /// </summary>
        public JourneySchedule Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property StartActivity. 
        /// <para>
        /// The unique identifier for the first activity in the journey.
        /// </para>
        /// </summary>
        public string StartActivity
        {
            get { return this._startActivity; }
            set { this._startActivity = value; }
        }

        // Check to see if StartActivity property is set
        internal bool IsSetStartActivity()
        {
            return this._startActivity != null;
        }

        /// <summary>
        /// Gets and sets the property StartCondition. 
        /// <para>
        /// The segment that defines which users are participants in the journey.
        /// </para>
        /// </summary>
        public StartCondition StartCondition
        {
            get { return this._startCondition; }
            set { this._startCondition = value; }
        }

        // Check to see if StartCondition property is set
        internal bool IsSetStartCondition()
        {
            return this._startCondition != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current status of the journey. Possible values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// DRAFT - The journey is being developed and hasn't been published yet.
        /// </para>
        /// </li> <li>
        /// <para>
        /// ACTIVE - The journey has been developed and published. Depending on the journey's
        /// schedule, the journey may currently be running or scheduled to start running at a
        /// later time. If a journey's status is ACTIVE, you can't add, change, or remove activities
        /// from it.
        /// </para>
        /// </li> <li>
        /// <para>
        /// COMPLETED - The journey has been published and has finished running. All participants
        /// have entered the journey and no participants are waiting to complete the journey or
        /// any activities in the journey.
        /// </para>
        /// </li> <li>
        /// <para>
        /// CANCELLED - The journey has been stopped. If a journey's status is CANCELLED, you
        /// can't add, change, or remove activities or segment settings from the journey.
        /// </para>
        /// </li> <li>
        /// <para>
        /// CLOSED - The journey has been published and has started running. It may have also
        /// passed its scheduled end time, or passed its scheduled start time and a refresh frequency
        /// hasn't been specified for it. If a journey's status is CLOSED, you can't add participants
        /// to it, and no existing participants can enter the journey for the first time. However,
        /// any existing participants who are currently waiting to start an activity may continue
        /// the journey.
        /// </para>
        /// </li></ul>
        /// </summary>
        public State State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// This object is not used or supported.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}