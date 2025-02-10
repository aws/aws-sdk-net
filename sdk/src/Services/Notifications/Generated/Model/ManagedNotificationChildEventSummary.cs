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
    /// Describes a short summary and metadata for a <c>ManagedNotificationChildEvent</c>.
    /// </summary>
    public partial class ManagedNotificationChildEventSummary
    {
        private AggregationDetail _aggregationDetail;
        private EventStatus _eventStatus;
        private MessageComponentsSummary _messageComponents;
        private NotificationType _notificationType;
        private SchemaVersion _schemaVersion;
        private ManagedSourceEventMetadataSummary _sourceEventMetadata;

        /// <summary>
        /// Gets and sets the property AggregationDetail. 
        /// <para>
        /// Provides detailed information about the dimensions used for event summarization and
        /// aggregation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AggregationDetail AggregationDetail
        {
            get { return this._aggregationDetail; }
            set { this._aggregationDetail = value; }
        }

        // Check to see if AggregationDetail property is set
        internal bool IsSetAggregationDetail()
        {
            return this._aggregationDetail != null;
        }

        /// <summary>
        /// Gets and sets the property EventStatus. 
        /// <para>
        /// The perceived nature of the event.
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
        /// All EventRules are <c>ACTIVE</c> and any call can be run.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>UNHEALTHY</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Some EventRules are <c>ACTIVE</c> and some are <c>INACTIVE</c>. Any call can be run.
        /// </para>
        ///  </li> </ul> </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property MessageComponents.
        /// </summary>
        [AWSProperty(Required=true)]
        public MessageComponentsSummary MessageComponents
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
        /// The Type of the event causing this notification.
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
        /// The schema version of the <c>ManagedNotificationChildEvent</c>.
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
        /// Gets and sets the property SourceEventMetadata. 
        /// <para>
        /// Contains all event metadata present identically across all <c>NotificationEvents</c>.
        /// All fields are present in Source Events via Eventbridge.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ManagedSourceEventMetadataSummary SourceEventMetadata
        {
            get { return this._sourceEventMetadata; }
            set { this._sourceEventMetadata = value; }
        }

        // Check to see if SourceEventMetadata property is set
        internal bool IsSetSourceEventMetadata()
        {
            return this._sourceEventMetadata != null;
        }

    }
}