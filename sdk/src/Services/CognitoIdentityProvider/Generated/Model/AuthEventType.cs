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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// One authentication event that Amazon Cognito logged in a user pool with threat protection
    /// active. Contains user and device metadata and a risk assessment from your user pool.
    /// </summary>
    public partial class AuthEventType
    {
        private List<ChallengeResponseType> _challengeResponses = AWSConfigs.InitializeCollections ? new List<ChallengeResponseType>() : null;
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
        /// A list of the challenges that the user was requested to answer, for example <c>Password</c>,
        /// and the result, for example <c>Success</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ChallengeResponseType> ChallengeResponses
        {
            get { return this._challengeResponses; }
            set { this._challengeResponses = value; }
        }

        // Check to see if ChallengeResponses property is set
        internal bool IsSetChallengeResponses()
        {
            return this._challengeResponses != null && (this._challengeResponses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the item was created. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
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
        /// The user context data captured at the time of an event request. This value provides
        /// additional information about the client from which event the request is received.
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
        /// The <c>UpdateAuthEventFeedback</c> or <c>AdminUpdateAuthEventFeedback</c> feedback
        /// that you or your user provided in response to the event. A value of <c>Valid</c> indicates
        /// that you disagreed with the level of risk that your user pool assigned, and evaluated
        /// a session to be valid, or likely safe. A value of <c>Invalid</c> indicates that you
        /// agreed with the user pool risk level and evaluated a session to be invalid, or likely
        /// malicious.
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
        [AWSProperty(Min=0, Max=131072)]
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
        /// The threat evaluation from your user pool about an event. Contains information about
        /// whether your user pool detected compromised credentials, whether the event triggered
        /// an automated response, and the level of risk.
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
        /// The type of authentication event.
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