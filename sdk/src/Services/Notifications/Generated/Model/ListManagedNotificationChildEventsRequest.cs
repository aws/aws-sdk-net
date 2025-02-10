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
    /// Container for the parameters to the ListManagedNotificationChildEvents operation.
    /// Returns a list of <c>ManagedNotificationChildEvents</c> for a specified aggregate
    /// <c>ManagedNotificationEvent</c>, ordered by creation time in reverse chronological
    /// order (newest first).
    /// </summary>
    public partial class ListManagedNotificationChildEventsRequest : AmazonNotificationsRequest
    {
        private string _aggregateManagedNotificationEventArn;
        private DateTime? _endTime;
        private LocaleCode _locale;
        private int? _maxResults;
        private string _nextToken;
        private string _organizationalUnitId;
        private string _relatedAccount;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property AggregateManagedNotificationEventArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <c>ManagedNotificationEvent</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AggregateManagedNotificationEventArn
        {
            get { return this._aggregateManagedNotificationEventArn; }
            set { this._aggregateManagedNotificationEventArn = value; }
        }

        // Check to see if AggregateManagedNotificationEventArn property is set
        internal bool IsSetAggregateManagedNotificationEventArn()
        {
            return this._aggregateManagedNotificationEventArn != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Latest time of events to return from this call.
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
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale code of the language used for the retrieved <c>NotificationEvent</c>. The
        /// default locale is English.<c>en_US</c>.
        /// </para>
        /// </summary>
        public LocaleCode Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to be returned in this call. Defaults to 20.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The start token for paginated calls. Retrieved from the response of a previous ListManagedNotificationChannelAssociations
        /// call. Next token uses Base64 encoding.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationalUnitId. 
        /// <para>
        /// The identifier of the Amazon Web Services Organizations organizational unit (OU) associated
        /// with the Managed Notification Child Events.
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
        /// The Amazon Web Services account ID associated with the Managed Notification Child
        /// Events.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The earliest time of events to return from this call.
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

    }
}