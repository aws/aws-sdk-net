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
 * Do not modify this file. This file is generated from the personalize-events-2018-03-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PersonalizeEvents.Model
{
    /// <summary>
    /// Represents user interaction event information sent using the <code>PutEvents</code>
    /// API.
    /// </summary>
    public partial class Event
    {
        private string _eventId;
        private string _eventType;
        private float? _eventValue;
        private List<string> _impression = new List<string>();
        private string _itemId;
        private string _properties;
        private string _recommendationId;
        private DateTime? _sentAt;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// An ID associated with the event. If an event ID is not provided, Amazon Personalize
        /// generates a unique ID for the event. An event ID is not used as an input to the model.
        /// Amazon Personalize uses the event ID to distinquish unique events. Any subsequent
        /// events after the first with the same event ID are not used in model training.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of event, such as click or download. This property corresponds to the <code>EVENT_TYPE</code>
        /// field of your Interactions schema and depends on the types of events you are tracking.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string EventType
        {
            get { return this._eventType; }
            set { this._eventType = value; }
        }

        // Check to see if EventType property is set
        internal bool IsSetEventType()
        {
            return this._eventType != null;
        }

        /// <summary>
        /// Gets and sets the property EventValue. 
        /// <para>
        /// The event value that corresponds to the <code>EVENT_VALUE</code> field of the Interactions
        /// schema.
        /// </para>
        /// </summary>
        public float EventValue
        {
            get { return this._eventValue.GetValueOrDefault(); }
            set { this._eventValue = value; }
        }

        // Check to see if EventValue property is set
        internal bool IsSetEventValue()
        {
            return this._eventValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Impression. 
        /// <para>
        /// A list of item IDs that represents the sequence of items you have shown the user.
        /// For example, <code>["itemId1", "itemId2", "itemId3"]</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public List<string> Impression
        {
            get { return this._impression; }
            set { this._impression = value; }
        }

        // Check to see if Impression property is set
        internal bool IsSetImpression()
        {
            return this._impression != null && this._impression.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ItemId. 
        /// <para>
        /// The item ID key that corresponds to the <code>ITEM_ID</code> field of the Interactions
        /// schema.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ItemId
        {
            get { return this._itemId; }
            set { this._itemId = value; }
        }

        // Check to see if ItemId property is set
        internal bool IsSetItemId()
        {
            return this._itemId != null;
        }

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// A string map of event-specific data that you might choose to record. For example,
        /// if a user rates a movie on your site, other than movie ID (<code>itemId</code>) and
        /// rating (<code>eventValue</code>) , you might also send the number of movie ratings
        /// made by the user.
        /// </para>
        ///  
        /// <para>
        /// Each item in the map consists of a key-value pair. For example,
        /// </para>
        ///  
        /// <para>
        ///  <code>{"numberOfRatings": "12"}</code> 
        /// </para>
        ///  
        /// <para>
        /// The keys use camel case names that match the fields in the Interactions schema. In
        /// the above example, the <code>numberOfRatings</code> would match the 'NUMBER_OF_RATINGS'
        /// field defined in the Interactions schema.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationId. 
        /// <para>
        /// The ID of the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public string RecommendationId
        {
            get { return this._recommendationId; }
            set { this._recommendationId = value; }
        }

        // Check to see if RecommendationId property is set
        internal bool IsSetRecommendationId()
        {
            return this._recommendationId != null;
        }

        /// <summary>
        /// Gets and sets the property SentAt. 
        /// <para>
        /// The timestamp (in Unix time) on the client side when the event occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime SentAt
        {
            get { return this._sentAt.GetValueOrDefault(); }
            set { this._sentAt = value; }
        }

        // Check to see if SentAt property is set
        internal bool IsSetSentAt()
        {
            return this._sentAt.HasValue; 
        }

    }
}