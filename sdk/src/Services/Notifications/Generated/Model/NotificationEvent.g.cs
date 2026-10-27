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

namespace Amazon.Notifications.Model
{
    /// <summary>
    /// A <c>NotificationEvent</c> is a notification-focused representation of an event. They
    /// contain semantic information used by Channels to create end-user notifications.
    /// </summary>
    public partial class NotificationEvent
    {
        /// <summary>
        /// Gets and sets the property AggregateNotificationEventArn. 
        /// <para>
        /// If the value of <c>aggregationEventType</c> is not <c>NONE</c>, this is the Amazon
        /// Resource Event (ARN) of the parent aggregate notification.
        /// </para>
        ///  
        /// <para>
        /// This is omitted if notification isn't aggregated.
        /// </para>
        /// </summary>
        public string AggregateNotificationEventArn { get; set; }

        /// <summary>
        /// Checks to see if the AggregateNotificationEventArn property is set.
        /// </summary>
        internal bool IsSetAggregateNotificationEventArn() => this.AggregateNotificationEventArn != null;

        /// <summary>
        /// Gets and sets the property AggregationEventType. 
        /// <para>
        /// The aggregation type of the <c>NotificationConfiguration</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AGGREGATE</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The notification event is an aggregate notification. Aggregate notifications summarize
        /// grouped events over a specified time period.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>CHILD</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Some <c>EventRules</c> are <c>ACTIVE</c> and some are <c>INACTIVE</c>. Any call can
        /// be run.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>NONE</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The notification isn't aggregated.
        /// </para>
        ///  </li> </ul> </li> </ul> </li> </ul>
        /// </summary>
        public AggregationEventType AggregationEventType { get; set; }

        /// <summary>
        /// Checks to see if the AggregationEventType property is set.
        /// </summary>
        internal bool IsSetAggregationEventType() => this.AggregationEventType != null;

        /// <summary>
        /// Gets and sets the property AggregationSummary. 
        /// <para>
        /// Provides additional information about how multiple notifications are grouped.
        /// </para>
        /// </summary>
        public AggregationSummary AggregationSummary { get; set; }

        /// <summary>
        /// Checks to see if the AggregationSummary property is set.
        /// </summary>
        internal bool IsSetAggregationSummary() => this.AggregationSummary != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the event.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property EventStatus. 
        /// <para>
        /// The assessed nature of the event.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HEALTHY</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// All <c>EventRules</c> are <c>ACTIVE</c> and any call can be run.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>UNHEALTHY</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Some <c>EventRules</c> are <c>ACTIVE</c> and some are <c>INACTIVE</c>. Any call can
        /// be run.
        /// </para>
        ///  </li> </ul> </li> </ul> </li> </ul>
        /// </summary>
        public EventStatus EventStatus { get; set; }

        /// <summary>
        /// Checks to see if the EventStatus property is set.
        /// </summary>
        internal bool IsSetEventStatus() => this.EventStatus != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for a <c>NotificationEvent</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Media. 
        /// <para>
        /// A list of media elements.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<MediaElement> Media { get; set; } = AWSConfigs.InitializeCollections ? new List<MediaElement>() : null;

        /// <summary>
        /// Checks to see if the Media property is set.
        /// </summary>
        internal bool IsSetMedia() => this.Media != null && (this.Media.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MessageComponents.
        /// </summary>
        [AWSProperty(Required = true)]
        public MessageComponents MessageComponents { get; set; }

        /// <summary>
        /// Checks to see if the MessageComponents property is set.
        /// </summary>
        internal bool IsSetMessageComponents() => this.MessageComponents != null;

        /// <summary>
        /// Gets and sets the property NotificationType. 
        /// <para>
        /// The type of event causing the notification.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALERT</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A notification about an event where something was triggered, initiated, reopened,
        /// deployed, or a threshold was breached.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>WARNING</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A notification about an event where an issue is about to arise. For example, something
        /// is approaching a threshold.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>ANNOUNCEMENT</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A notification about an important event. For example, a step in a workflow or escalation
        /// path or that a workflow was updated.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>INFORMATIONAL</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A notification about informational messages. For example, recommendations, service
        /// announcements, or reminders.
        /// </para>
        ///  </li> </ul> </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public NotificationType NotificationType { get; set; }

        /// <summary>
        /// Checks to see if the NotificationType property is set.
        /// </summary>
        internal bool IsSetNotificationType() => this.NotificationType != null;

        /// <summary>
        /// Gets and sets the property OrganizationalUnitId. 
        /// <para>
        /// The unique identifier of the organizational unit associated with the notification
        /// event.
        /// </para>
        /// </summary>
        public string OrganizationalUnitId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationalUnitId property is set.
        /// </summary>
        internal bool IsSetOrganizationalUnitId() => this.OrganizationalUnitId != null;

        /// <summary>
        /// Gets and sets the property SchemaVersion. 
        /// <para>
        /// The schema version of the Notification Event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SchemaVersion SchemaVersion { get; set; }

        /// <summary>
        /// Checks to see if the SchemaVersion property is set.
        /// </summary>
        internal bool IsSetSchemaVersion() => this.SchemaVersion != null;

        /// <summary>
        /// Gets and sets the property SourceEventDetailUrl. 
        /// <para>
        /// The source event URL.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2000)]
        public string SourceEventDetailUrl { get; set; }

        /// <summary>
        /// Checks to see if the SourceEventDetailUrl property is set.
        /// </summary>
        internal bool IsSetSourceEventDetailUrl() => this.SourceEventDetailUrl != null;

        /// <summary>
        /// Gets and sets the property SourceEventDetailUrlDisplayText. 
        /// <para>
        /// The detailed URL for the source event.
        /// </para>
        /// </summary>
        public string SourceEventDetailUrlDisplayText { get; set; }

        /// <summary>
        /// Checks to see if the SourceEventDetailUrlDisplayText property is set.
        /// </summary>
        internal bool IsSetSourceEventDetailUrlDisplayText() => this.SourceEventDetailUrlDisplayText != null;

        /// <summary>
        /// Gets and sets the property SourceEventMetadata. 
        /// <para>
        /// The source event metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SourceEventMetadata SourceEventMetadata { get; set; }

        /// <summary>
        /// Checks to see if the SourceEventMetadata property is set.
        /// </summary>
        internal bool IsSetSourceEventMetadata() => this.SourceEventMetadata != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The notification event start time.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property TextParts. 
        /// <para>
        /// A list of text values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, TextPartValue> TextParts { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, TextPartValue>() : null;

        /// <summary>
        /// Checks to see if the TextParts property is set.
        /// </summary>
        internal bool IsSetTextParts() => this.TextParts != null && (this.TextParts.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
