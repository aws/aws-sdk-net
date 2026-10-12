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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// One authentication event that Amazon Cognito logged in a user pool with threat protection
    /// active. Contains user and device metadata and a risk assessment from your user pool.
    /// </summary>
    public partial class AuthEventType
    {
        /// <summary>
        /// Gets and sets the property ChallengeResponses. 
        /// <para>
        /// A list of the challenges that the user was requested to answer, for example <c>Password</c>,
        /// and the result, for example <c>Success</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ChallengeResponseType> ChallengeResponses { get; set; } = AWSConfigs.InitializeCollections ? new List<ChallengeResponseType>() : null;

        /// <summary>
        /// Checks to see if the ChallengeResponses property is set.
        /// </summary>
        internal bool IsSetChallengeResponses() => this.ChallengeResponses != null && (this.ChallengeResponses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the item was created. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property EventContextData. 
        /// <para>
        /// The user context data captured at the time of an event request. This value provides
        /// additional information about the client from which event the request is received.
        /// </para>
        /// </summary>
        public EventContextDataType EventContextData { get; set; }

        /// <summary>
        /// Checks to see if the EventContextData property is set.
        /// </summary>
        internal bool IsSetEventContextData() => this.EventContextData != null;

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
        public EventFeedbackType EventFeedback { get; set; }

        /// <summary>
        /// Checks to see if the EventFeedback property is set.
        /// </summary>
        internal bool IsSetEventFeedback() => this.EventFeedback != null;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The event ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 131072)]
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;

        /// <summary>
        /// Gets and sets the property EventResponse. 
        /// <para>
        /// The event response.
        /// </para>
        /// </summary>
        public EventResponseType EventResponse { get; set; }

        /// <summary>
        /// Checks to see if the EventResponse property is set.
        /// </summary>
        internal bool IsSetEventResponse() => this.EventResponse != null;

        /// <summary>
        /// Gets and sets the property EventRisk. 
        /// <para>
        /// The threat evaluation from your user pool about an event. Contains information about
        /// whether your user pool detected compromised credentials, whether the event triggered
        /// an automated response, and the level of risk.
        /// </para>
        /// </summary>
        public EventRiskType EventRisk { get; set; }

        /// <summary>
        /// Checks to see if the EventRisk property is set.
        /// </summary>
        internal bool IsSetEventRisk() => this.EventRisk != null;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of authentication event.
        /// </para>
        /// </summary>
        public EventType EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;
    }
}
