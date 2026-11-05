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
    /// Container for the parameters to the ListManagedNotificationEvents operation. Returns
    /// a list of Managed Notification Events according to specified filters, ordered by creation
    /// time in reverse chronological order (newest first).
    /// </summary>
    public partial class ListManagedNotificationEventsRequest : AmazonNotificationsRequest
    {
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
        /// Gets and sets the property IncludeSensitiveEvents. 
        /// <para>
        /// Specifies whether to include sensitive events in the result. By default, only non-sensitive
        /// events are returned. The <c>notifications:AccessSensitiveEvents</c> permission controls
        /// access to sensitive events.
        /// </para>
        /// </summary>
        public bool? IncludeSensitiveEvents { get; set; }

        /// <summary>
        /// Checks to see if the IncludeSensitiveEvents property is set.
        /// </summary>
        internal bool IsSetIncludeSensitiveEvents() => this.IncludeSensitiveEvents.HasValue;

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale code of the language used for the retrieved NotificationEvent. The default
        /// locale is English (en_US).
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
        /// The start token for paginated calls. Retrieved from the response of a previous <c>ListManagedNotificationChannelAssociations</c>
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
        /// The Organizational Unit Id that an Amazon Web Services account belongs to.
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
        /// The Amazon Web Services account ID associated with the Managed Notification Events.
        /// </para>
        /// </summary>
        public string RelatedAccount { get; set; }

        /// <summary>
        /// Checks to see if the RelatedAccount property is set.
        /// </summary>
        internal bool IsSetRelatedAccount() => this.RelatedAccount != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The Amazon Web Services service the event originates from. For example aws.cloudwatch.
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
