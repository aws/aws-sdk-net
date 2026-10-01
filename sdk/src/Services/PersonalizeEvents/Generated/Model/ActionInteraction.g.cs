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

namespace Amazon.PersonalizeEvents.Model
{
    /// <summary>
    /// Represents an action interaction event sent using the <c>PutActionInteractions</c>
    /// API.
    /// </summary>
    public partial class ActionInteraction
    {
        /// <summary>
        /// Gets and sets the property ActionId. 
        /// <para>
        /// The ID of the action the user interacted with. This corresponds to the <c>ACTION_ID</c>
        /// field of the Action interaction schema.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 256)]
        public string ActionId { get; set; }

        /// <summary>
        /// Checks to see if the ActionId property is set.
        /// </summary>
        internal bool IsSetActionId() => this.ActionId != null;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// An ID associated with the event. If an event ID is not provided, Amazon Personalize
        /// generates a unique ID for the event. An event ID is not used as an input to the model.
        /// Amazon Personalize uses the event ID to distinguish unique events. Any subsequent
        /// events after the first with the same event ID are not used in model training.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of action interaction event. You can specify <c>Viewed</c>, <c>Taken</c>,
        /// and <c>Not Taken</c> event types. For more information about action interaction event
        /// type data, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/action-interaction-event-type-data.html">Event
        /// type data</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property Impression. 
        /// <para>
        /// A list of action IDs that represents the sequence of actions you have shown the user.
        /// For example, <c>["actionId1", "actionId2", "actionId3"]</c>. Amazon Personalize doesn't
        /// use impressions data from action interaction events. Instead, record multiple events
        /// for each action and use the <c>Viewed</c> event type. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public List<string> Impression { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Impression property is set.
        /// </summary>
        internal bool IsSetImpression() => this.Impression != null && (this.Impression.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// A string map of event-specific data that you might choose to record. For example,
        /// if a user takes an action, other than the action ID, you might also send the number
        /// of actions taken by the user.
        /// </para>
        ///  
        /// <para>
        /// Each item in the map consists of a key-value pair. For example,
        /// </para>
        ///  
        /// <para>
        ///  <c>{"numberOfActions": "12"}</c> 
        /// </para>
        ///  
        /// <para>
        /// The keys use camel case names that match the fields in the Action interactions schema.
        /// In the above example, the <c>numberOfActions</c> would match the 'NUMBER_OF_ACTIONS'
        /// field defined in the Action interactions schema.
        /// </para>
        ///  
        /// <para>
        ///  The following can't be included as a keyword for properties (case insensitive). 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  userId 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  sessionId 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// eventType
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// timestamp
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// recommendationId
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// impression
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string Properties { get; set; }

        /// <summary>
        /// Checks to see if the Properties property is set.
        /// </summary>
        internal bool IsSetProperties() => this.Properties != null;

        /// <summary>
        /// Gets and sets the property RecommendationId. 
        /// <para>
        /// The ID of the list of recommendations that contains the action the user interacted
        /// with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 40)]
        public string RecommendationId { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationId property is set.
        /// </summary>
        internal bool IsSetRecommendationId() => this.RecommendationId != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The ID associated with the user's visit. Your application generates a unique <c>sessionId</c>
        /// when a user first visits your website or uses your application. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp for when the action interaction event occurred. Timestamps must be in
        /// Unix epoch time format, in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The ID of the user who interacted with the action. This corresponds to the <c>USER_ID</c>
        /// field of the Action interaction schema.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
