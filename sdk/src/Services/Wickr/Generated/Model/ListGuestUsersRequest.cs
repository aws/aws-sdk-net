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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
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
namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Container for the parameters to the ListGuestUsers operation.
    /// Retrieves a paginated list of guest users who have communicated with your Wickr network.
    /// Guest users are external users from federated networks who can communicate with network
    /// members.
    /// </summary>
    public partial class ListGuestUsersRequest : AmazonWickrRequest
    {
        private string _billingPeriod;
        private int? _maxResults;
        private string _networkId;
        private string _nextToken;
        private SortDirection _sortDirection;
        private string _sortFields;
        private string _username;

        /// <summary>
        /// Gets and sets the property BillingPeriod. 
        /// <para>
        /// Filter results to only include guest users from this billing period (e.g., '2024-01').
        /// </para>
        /// </summary>
        public string BillingPeriod
        {
            get { return this._billingPeriod; }
            set { this._billingPeriod = value; }
        }

        // Check to see if BillingPeriod property is set
        internal bool IsSetBillingPeriod()
        {
            return this._billingPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of guest users to return in a single page. Valid range is 1-100.
        /// Default is 10.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The ID of the Wickr network from which to list guest users.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=8)]
        public string NetworkId
        {
            get { return this._networkId; }
            set { this._networkId = value; }
        }

        // Check to see if NetworkId property is set
        internal bool IsSetNetworkId()
        {
            return this._networkId != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for retrieving the next page of results. This is returned from a previous
        /// request when there are more results available.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property SortDirection. 
        /// <para>
        /// The direction to sort results. Valid values are 'ASC' (ascending) or 'DESC' (descending).
        /// Default is 'DESC'.
        /// </para>
        /// </summary>
        public SortDirection SortDirection
        {
            get { return this._sortDirection; }
            set { this._sortDirection = value; }
        }

        // Check to see if SortDirection property is set
        internal bool IsSetSortDirection()
        {
            return this._sortDirection != null;
        }

        /// <summary>
        /// Gets and sets the property SortFields. 
        /// <para>
        /// The field to sort guest users by. Accepted values include 'username' and 'billingPeriod'.
        /// </para>
        /// </summary>
        public string SortFields
        {
            get { return this._sortFields; }
            set { this._sortFields = value; }
        }

        // Check to see if SortFields property is set
        internal bool IsSetSortFields()
        {
            return this._sortFields != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// Filter results to only include guest users with usernames matching this value.
        /// </para>
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}