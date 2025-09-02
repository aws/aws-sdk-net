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
    /// Describes a short summary of a <c>NotificationEvent</c>. This is only used when listing
    /// notification events.
    /// </summary>
    public partial class NotificationEventOverview
    {
        private string _aggregateNotificationEventArn;
        private AggregationEventType _aggregationEventType;
        private AggregationSummary _aggregationSummary;
        private string _arn;
        private DateTime? _creationTime;
        private string _notificationConfigurationArn;
        private NotificationEventSummary _notificationEvent;
        private string _organizationalUnitId;
        private string _relatedAccount;

        /// <summary>
        /// Gets and sets the property AggregateNotificationEventArn. 
        /// <para>
        /// The ARN of the <c>aggregatedNotificationEventArn</c> to match.
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
        /// The <c>NotificationConfiguration</c>'s aggregation type.
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
        /// Provides an aggregated summary data for notification events.
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
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the <c>NotificationEvent</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotificationConfigurationArn. 
        /// <para>
        /// The ARN of the <c>NotificationConfiguration</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NotificationConfigurationArn
        {
            get { return this._notificationConfigurationArn; }
            set { this._notificationConfigurationArn = value; }
        }

        // Check to see if NotificationConfigurationArn property is set
        internal bool IsSetNotificationConfigurationArn()
        {
            return this._notificationConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationEvent. 
        /// <para>
        /// Refers to a <c>NotificationEventSummary</c> object.
        /// </para>
        ///  
        /// <para>
        /// Similar in structure to <c>content</c> in the <c>GetNotificationEvent</c> response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NotificationEventSummary NotificationEvent
        {
            get { return this._notificationEvent; }
            set { this._notificationEvent = value; }
        }

        // Check to see if NotificationEvent property is set
        internal bool IsSetNotificationEvent()
        {
            return this._notificationEvent != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationalUnitId. 
        /// <para>
        /// The unique identifier of the organizational unit in the notification event overview.
        /// </para>
        /// </summary>
        public string OrganizationalUnitId
        {
            get { return this._organizationalUnitId; }
            set { this._organizationalUnitId = value; }
        }

        // Check to see if OrganizationalUnitId property is set
        internal bool IsSetOrganizationalUnitId()
        {
            return this._organizationalUnitId != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedAccount. 
        /// <para>
        /// The account name containing the <c>NotificationHub</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RelatedAccount
        {
            get { return this._relatedAccount; }
            set { this._relatedAccount = value; }
        }

        // Check to see if RelatedAccount property is set
        internal bool IsSetRelatedAccount()
        {
            return this._relatedAccount != null;
        }

    }
}