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
    /// Represents item interaction event information sent using the <c>PutEvents</c> API.
    /// </summary>
    public partial class Event
    {
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
        /// The type of event, such as click or download. This property corresponds to the <c>EVENT_TYPE</c>
        /// field of your Item interactions dataset's schema and depends on the types of events
        /// you are tracking.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property EventValue. 
        /// <para>
        /// The event value that corresponds to the <c>EVENT_VALUE</c> field of the Item interactions
        /// schema.
        /// </para>
        /// </summary>
        public float? EventValue { get; set; }

        /// <summary>
        /// Checks to see if the EventValue property is set.
        /// </summary>
        internal bool IsSetEventValue() => this.EventValue.HasValue;

        /// <summary>
        /// Gets and sets the property Impression. 
        /// <para>
        /// A list of item IDs that represents the sequence of items you have shown the user.
        /// For example, <c>["itemId1", "itemId2", "itemId3"]</c>. Provide a list of items to
        /// manually record impressions data for an event. For more information on recording impressions
        /// data, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/recording-events.html#putevents-including-impressions-data">Recording
        /// impressions data</a>. 
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
        /// Gets and sets the property ItemId. 
        /// <para>
        /// The item ID key that corresponds to the <c>ITEM_ID</c> field of the Item interactions
        /// dataset's schema.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string ItemId { get; set; }

        /// <summary>
        /// Checks to see if the ItemId property is set.
        /// </summary>
        internal bool IsSetItemId() => this.ItemId != null;

        /// <summary>
        /// Gets and sets the property MetricAttribution. 
        /// <para>
        /// Contains information about the metric attribution associated with an event. For more
        /// information about metric attributions, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/measuring-recommendation-impact.html">Measuring
        /// impact of recommendations</a>.
        /// </para>
        /// </summary>
        public MetricAttribution MetricAttribution { get; set; }

        /// <summary>
        /// Checks to see if the MetricAttribution property is set.
        /// </summary>
        internal bool IsSetMetricAttribution() => this.MetricAttribution != null;

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// A string map of event-specific data that you might choose to record. For example,
        /// if a user rates a movie on your site, other than movie ID (<c>itemId</c>) and rating
        /// (<c>eventValue</c>) , you might also send the number of movie ratings made by the
        /// user.
        /// </para>
        ///  
        /// <para>
        /// Each item in the map consists of a key-value pair. For example,
        /// </para>
        ///  
        /// <para>
        ///  <c>{"numberOfRatings": "12"}</c> 
        /// </para>
        ///  
        /// <para>
        /// The keys use camel case names that match the fields in the Item interactions dataset's
        /// schema. In the above example, the <c>numberOfRatings</c> would match the 'NUMBER_OF_RATINGS'
        /// field defined in the Item interactions dataset's schema.
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
        /// The ID of the list of recommendations that contains the item the user interacted with.
        /// Provide a <c>recommendationId</c> to have Amazon Personalize implicitly record the
        /// recommendations you show your user as impressions data. Or provide a <c>recommendationId</c>
        /// if you use a metric attribution to measure the impact of recommendations. 
        /// </para>
        ///  
        /// <para>
        ///  For more information on recording impressions data, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/recording-events.html#putevents-including-impressions-data">Recording
        /// impressions data</a>. For more information on creating a metric attribution see <a
        /// href="https://docs.aws.amazon.com/personalize/latest/dg/measuring-recommendation-impact.html">Measuring
        /// impact of recommendations</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 40)]
        public string RecommendationId { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationId property is set.
        /// </summary>
        internal bool IsSetRecommendationId() => this.RecommendationId != null;

        /// <summary>
        /// Gets and sets the property SentAt. 
        /// <para>
        /// The timestamp (in Unix time) on the client side when the event occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? SentAt { get; set; }

        /// <summary>
        /// Checks to see if the SentAt property is set.
        /// </summary>
        internal bool IsSetSentAt() => this.SentAt.HasValue;
    }
}
