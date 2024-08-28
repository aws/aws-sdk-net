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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the ListSubscriptionRequests operation.
    /// Lists Amazon DataZone subscription requests.
    /// </summary>
    public partial class ListSubscriptionRequestsRequest : AmazonDataZoneRequest
    {
        private string _approverProjectId;
        private string _domainIdentifier;
        private int? _maxResults;
        private string _nextToken;
        private string _owningProjectId;
        private SortKey _sortBy;
        private SortOrder _sortOrder;
        private SubscriptionRequestStatus _status;
        private string _subscribedListingId;

        /// <summary>
        /// Gets and sets the property ApproverProjectId. 
        /// <para>
        /// The identifier of the subscription request approver's project.
        /// </para>
        /// </summary>
        public string ApproverProjectId
        {
            get { return this._approverProjectId; }
            set { this._approverProjectId = value; }
        }

        // Check to see if ApproverProjectId property is set
        internal bool IsSetApproverProjectId()
        {
            return this._approverProjectId != null;
        }

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainIdentifier
        {
            get { return this._domainIdentifier; }
            set { this._domainIdentifier = value; }
        }

        // Check to see if DomainIdentifier property is set
        internal bool IsSetDomainIdentifier()
        {
            return this._domainIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of subscription requests to return in a single call to <c>ListSubscriptionRequests</c>.
        /// When the number of subscription requests to be listed is greater than the value of
        /// <c>MaxResults</c>, the response contains a <c>NextToken</c> value that you can use
        /// in a subsequent call to <c>ListSubscriptionRequests</c> to list the next set of subscription
        /// requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// When the number of subscription requests is greater than the default value for the
        /// <c>MaxResults</c> parameter, or if you explicitly specify a value for <c>MaxResults</c>
        /// that is less than the number of subscription requests, the response includes a pagination
        /// token named <c>NextToken</c>. You can specify this <c>NextToken</c> value in a subsequent
        /// call to <c>ListSubscriptionRequests</c> to list the next set of subscription requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
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
        /// Gets and sets the property OwningProjectId. 
        /// <para>
        /// The identifier of the project for the subscription requests.
        /// </para>
        /// </summary>
        public string OwningProjectId
        {
            get { return this._owningProjectId; }
            set { this._owningProjectId = value; }
        }

        // Check to see if OwningProjectId property is set
        internal bool IsSetOwningProjectId()
        {
            return this._owningProjectId != null;
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// Specifies the way to sort the results of this action.
        /// </para>
        /// </summary>
        public SortKey SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Specifies the sort order for the results of this action.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies the status of the subscription requests.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is not a required parameter, but if not specified, by default, Amazon DataZone
        /// returns only <c>PENDING</c> subscription requests. 
        /// </para>
        ///  </note>
        /// </summary>
        public SubscriptionRequestStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SubscribedListingId. 
        /// <para>
        /// The identifier of the subscribed listing.
        /// </para>
        /// </summary>
        public string SubscribedListingId
        {
            get { return this._subscribedListingId; }
            set { this._subscribedListingId = value; }
        }

        // Check to see if SubscribedListingId property is set
        internal bool IsSetSubscribedListingId()
        {
            return this._subscribedListingId != null;
        }

    }
}