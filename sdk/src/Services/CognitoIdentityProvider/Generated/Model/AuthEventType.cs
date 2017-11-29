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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The authentication event type.
    /// </summary>
    public partial class AuthEventType
    {
        private List<ChallengeResponseType> _challengeResponses = new List<ChallengeResponseType>();
        private DateTime? _creationDate;
        private EventContextDataType _eventContextData;
        private EventFeedbackType _eventFeedback;
        private string _eventId;
        private EventResponseType _eventResponse;
        private EventRiskType _eventRisk;
        private EventType _eventType;

        /// <summary>
        /// Gets and sets the property ChallengeResponses. 
        /// <para>
        /// The challenge responses.
        /// </para>
        /// </summary>
        public List<ChallengeResponseType> ChallengeResponses
        {
            get { return this._challengeResponses; }
            set { this._challengeResponses = value; }
        }

        // Check to see if ChallengeResponses property is set
        internal bool IsSetChallengeResponses()
        {
            return this._challengeResponses != null && this._challengeResponses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The creation date
        /// </para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventContextData. 
        /// <para>
        /// The user context data captured at the time of an event request. It provides additional
        /// information about the client from which event the request is received.
        /// </para>
        /// </summary>
        public EventContextDataType EventContextData
        {
            get { return this._eventContextData; }
            set { this._eventContextData = value; }
        }

        // Check to see if EventContextData property is set
        internal bool IsSetEventContextData()
        {
            return this._eventContextData != null;
        }

        /// <summary>
        /// Gets and sets the property EventFeedback. 
        /// <para>
        /// A flag specifying the user feedback captured at the time of an event request is good
        /// or bad. 
        /// </para>
        /// </summary>
        public EventFeedbackType EventFeedback
        {
            get { return this._eventFeedback; }
            set { this._eventFeedback = value; }
        }

        // Check to see if EventFeedback property is set
        internal bool IsSetEventFeedback()
        {
            return this._eventFeedback != null;
        }

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The event ID.
        /// </para>
        /// </summary>
        public string EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId != null;
        }

        /// <summary>
        /// Gets and sets the property EventResponse. 
        /// <para>
        /// The event response.
        /// </para>
        /// </summary>
        public EventResponseType EventResponse
        {
            get { return this._eventResponse; }
            set { this._eventResponse = value; }
        }

        // Check to see if EventResponse property is set
        internal bool IsSetEventResponse()
        {
            return this._eventResponse != null;
        }

        /// <summary>
        /// Gets and sets the property EventRisk. 
        /// <para>
        /// The event risk.
        /// </para>
        /// </summary>
        public EventRiskType EventRisk
        {
            get { return this._eventRisk; }
            set { this._eventRisk = value; }
        }

        // Check to see if EventRisk property is set
        internal bool IsSetEventRisk()
        {
            return this._eventRisk != null;
        }

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The event type.
        /// </para>
        /// </summary>
        public EventType EventType
        {
            get { return this._eventType; }
            set { this._eventType = value; }
        }

        // Check to see if EventType property is set
        internal bool IsSetEventType()
        {
            return this._eventType != null;
        }

    }
}