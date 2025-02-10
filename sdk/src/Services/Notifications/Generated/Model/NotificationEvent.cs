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
 * Do not modify this file. This file is generated from the notifications-2018-05-10.normal.json service model.
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
        private string _aggregateNotificationEventArn;
        private AggregationEventType _aggregationEventType;
        private AggregationSummary _aggregationSummary;
        private DateTime? _endTime;
        private EventStatus _eventStatus;
        private string _id;
        private List<MediaElement> _media = AWSConfigs.InitializeCollections ? new List<MediaElement>() : null;
        private MessageComponents _messageComponents;
        private NotificationType _notificationType;
        private SchemaVersion _schemaVersion;
        private string _sourceEventDetailUrl;
        private string _sourceEventDetailUrlDisplayText;
        private SourceEventMetadata _sourceEventMetadata;
        private DateTime? _startTime;
        private Dictionary<string, TextPartValue> _textParts = AWSConfigs.InitializeCollections ? new Dictionary<string, TextPartValue>() : null;

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
        public string AggregateNotificationEventArn
        {
            get { return this._aggregateNotificationEventArn; }
            set { this._aggregateNotificationEventArn = value; }
        }

        // Check to see if AggregateNotificationEventArn property is set
        internal bool IsSetAggregateNotificationEventArn()
        {
            return this._aggregateNotificationEventArn != null;
        }

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
        public AggregationEventType AggregationEventType
        {
            get { return this._aggregationEventType; }
            set { this._aggregationEventType = value; }
        }

        // Check to see if AggregationEventType property is set
        internal bool IsSetAggregationEventType()
        {
            return this._aggregationEventType != null;
        }

        /// <summary>
        /// Gets and sets the property AggregationSummary. 
        /// <para>
        /// Provides additional information about how multiple notifications are grouped.
        /// </para>
        /// </summary>
        public AggregationSummary AggregationSummary
        {
            get { return this._aggregationSummary; }
            set { this._aggregationSummary = value; }
        }

        // Check to see if AggregationSummary property is set
        internal bool IsSetAggregationSummary()
        {
            return this._aggregationSummary != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the event.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

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
        public EventStatus EventStatus
        {
            get { return this._eventStatus; }
            set { this._eventStatus = value; }
        }

        // Check to see if EventStatus property is set
        internal bool IsSetEventStatus()
        {
            return this._eventStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for a <c>NotificationEvent</c>.
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
        /// Gets and sets the property Media. 
        /// <para>
        /// A list of media elements.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<MediaElement> Media
        {
            get { return this._media; }
            set { this._media = value; }
        }

        // Check to see if Media property is set
        internal bool IsSetMedia()
        {
            return this._media != null && (this._media.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MessageComponents.
        /// </summary>
        [AWSProperty(Required=true)]
        public MessageComponents MessageComponents
        {
            get { return this._messageComponents; }
            set { this._messageComponents = value; }
        }

        // Check to see if MessageComponents property is set
        internal bool IsSetMessageComponents()
        {
            return this._messageComponents != null;
        }

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
        [AWSProperty(Required=true)]
        public NotificationType NotificationType
        {
            get { return this._notificationType; }
            set { this._notificationType = value; }
        }

        // Check to see if NotificationType property is set
        internal bool IsSetNotificationType()
        {
            return this._notificationType != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaVersion. 
        /// <para>
        /// The schema version of the Notification Event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SchemaVersion SchemaVersion
        {
            get { return this._schemaVersion; }
            set { this._schemaVersion = value; }
        }

        // Check to see if SchemaVersion property is set
        internal bool IsSetSchemaVersion()
        {
            return this._schemaVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SourceEventDetailUrl. 
        /// <para>
        /// The source event URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2000)]
        public string SourceEventDetailUrl
        {
            get { return this._sourceEventDetailUrl; }
            set { this._sourceEventDetailUrl = value; }
        }

        // Check to see if SourceEventDetailUrl property is set
        internal bool IsSetSourceEventDetailUrl()
        {
            return this._sourceEventDetailUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SourceEventDetailUrlDisplayText. 
        /// <para>
        /// The detailed URL for the source event.
        /// </para>
        /// </summary>
        public string SourceEventDetailUrlDisplayText
        {
            get { return this._sourceEventDetailUrlDisplayText; }
            set { this._sourceEventDetailUrlDisplayText = value; }
        }

        // Check to see if SourceEventDetailUrlDisplayText property is set
        internal bool IsSetSourceEventDetailUrlDisplayText()
        {
            return this._sourceEventDetailUrlDisplayText != null;
        }

        /// <summary>
        /// Gets and sets the property SourceEventMetadata. 
        /// <para>
        /// The source event metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SourceEventMetadata SourceEventMetadata
        {
            get { return this._sourceEventMetadata; }
            set { this._sourceEventMetadata = value; }
        }

        // Check to see if SourceEventMetadata property is set
        internal bool IsSetSourceEventMetadata()
        {
            return this._sourceEventMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The notification event start time.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TextParts. 
        /// <para>
        /// A list of text values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, TextPartValue> TextParts
        {
            get { return this._textParts; }
            set { this._textParts = value; }
        }

        // Check to see if TextParts property is set
        internal bool IsSetTextParts()
        {
            return this._textParts != null && (this._textParts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}