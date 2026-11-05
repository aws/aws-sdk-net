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
    /// Describes a short summary of a <c>NotificationEvent</c>. This is only used when listing
    /// notification events.
    /// </summary>
    public partial class NotificationEventOverview
    {
        /// <summary>
        /// Gets and sets the property AggregateNotificationEventArn. 
        /// <para>
        /// The ARN of the <c>aggregatedNotificationEventArn</c> to match.
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
        public AggregationEventType AggregationEventType { get; set; }

        /// <summary>
        /// Checks to see if the AggregationEventType property is set.
        /// </summary>
        internal bool IsSetAggregationEventType() => this.AggregationEventType != null;

        /// <summary>
        /// Gets and sets the property AggregationSummary. 
        /// <para>
        /// Provides an aggregated summary data for notification events.
        /// </para>
        /// </summary>
        public AggregationSummary AggregationSummary { get; set; }

        /// <summary>
        /// Checks to see if the AggregationSummary property is set.
        /// </summary>
        internal bool IsSetAggregationSummary() => this.AggregationSummary != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the <c>NotificationEvent</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property NotificationConfigurationArn. 
        /// <para>
        /// The ARN of the <c>NotificationConfiguration</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NotificationConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the NotificationConfigurationArn property is set.
        /// </summary>
        internal bool IsSetNotificationConfigurationArn() => this.NotificationConfigurationArn != null;

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
        [AWSProperty(Required = true)]
        public NotificationEventSummary NotificationEvent { get; set; }

        /// <summary>
        /// Checks to see if the NotificationEvent property is set.
        /// </summary>
        internal bool IsSetNotificationEvent() => this.NotificationEvent != null;

        /// <summary>
        /// Gets and sets the property OrganizationalUnitId. 
        /// <para>
        /// The unique identifier of the organizational unit in the notification event overview.
        /// </para>
        /// </summary>
        public string OrganizationalUnitId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationalUnitId property is set.
        /// </summary>
        internal bool IsSetOrganizationalUnitId() => this.OrganizationalUnitId != null;

        /// <summary>
        /// Gets and sets the property RelatedAccount. 
        /// <para>
        /// The account name containing the <c>NotificationHub</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RelatedAccount { get; set; }

        /// <summary>
        /// Checks to see if the RelatedAccount property is set.
        /// </summary>
        internal bool IsSetRelatedAccount() => this.RelatedAccount != null;
    }
}
