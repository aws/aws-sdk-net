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
    /// Container for the parameters to the ListNotificationEvents operation. Returns a list
    /// of <c>NotificationEvents</c> according to specified filters, in reverse chronological
    /// order (newest first). <important> <para> User Notifications stores notifications in
    /// the individual Regions you register as notification hubs and the Region of the source
    /// event rule. ListNotificationEvents only returns notifications stored in the same Region
    /// in which the action is called. User Notifications doesn't backfill notifications to
    /// new Regions selected as notification hubs. For this reason, we recommend that you
    /// make calls in your oldest registered notification hub. For more information, see <a
    /// href="https://docs.aws.amazon.com/notifications/latest/userguide/notification-hubs.html">Notification
    /// hubs</a> in the <i>Amazon Web Services User Notifications User Guide</i>. </para>
    /// </important>
    /// </summary>
    public partial class ListNotificationEventsRequest : AmazonNotificationsRequest
    {
        /// <summary>
        /// Gets and sets the property AggregateNotificationEventArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <c>aggregatedNotificationEventArn</c> to match.
        /// </para>
        /// </summary>
        public string AggregateNotificationEventArn { get; set; }

        /// <summary>
        /// Checks to see if the AggregateNotificationEventArn property is set.
        /// </summary>
        internal bool IsSetAggregateNotificationEventArn() => this.AggregateNotificationEventArn != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Latest time of events to return from this call.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeChildEvents. 
        /// <para>
        /// Include aggregated child events in the result.
        /// </para>
        /// </summary>
        public bool? IncludeChildEvents { get; set; }

        /// <summary>
        /// Checks to see if the IncludeChildEvents property is set.
        /// </summary>
        internal bool IsSetIncludeChildEvents() => this.IncludeChildEvents.HasValue;

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale code of the language used for the retrieved <c>NotificationEvent</c>. The
        /// default locale is English <c>(en_US)</c>.
        /// </para>
        /// </summary>
        public LocaleCode Locale { get; set; }

        /// <summary>
        /// Checks to see if the Locale property is set.
        /// </summary>
        internal bool IsSetLocale() => this.Locale != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to be returned in this call. Defaults to 20.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The start token for paginated calls. Retrieved from the response of a previous <c>ListEventRules</c>
        /// call. Next token uses Base64 encoding.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property OrganizationalUnitId. 
        /// <para>
        /// The unique identifier of the organizational unit used to filter notification events.
        /// </para>
        /// </summary>
        public string OrganizationalUnitId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationalUnitId property is set.
        /// </summary>
        internal bool IsSetOrganizationalUnitId() => this.OrganizationalUnitId != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The matched event source.
        /// </para>
        ///  
        /// <para>
        /// Must match one of the valid EventBridge sources. Only Amazon Web Services service
        /// sourced events are supported. For example, <c>aws.ec2</c> and <c>aws.cloudwatch</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-service-event.html#eb-service-event-delivery-level">Event
        /// delivery from Amazon Web Services services</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 36)]
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The earliest time of events to return from this call.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
