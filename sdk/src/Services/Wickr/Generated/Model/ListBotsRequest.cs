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
    /// Container for the parameters to the ListBots operation.
    /// Retrieves a paginated list of bots in a specified Wickr network. You can filter and
    /// sort the results based on various criteria.
    /// </summary>
    public partial class ListBotsRequest : AmazonWickrRequest
    {
        private string _displayName;
        private string _groupId;
        private int? _maxResults;
        private string _networkId;
        private string _nextToken;
        private SortDirection _sortDirection;
        private string _sortFields;
        private int? _status;
        private string _username;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// Filter results to only include bots with display names matching this value.
        /// </para>
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// Filter results to only include bots belonging to this security group.
        /// </para>
        /// </summary>
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of bots to return in a single page. Valid range is 1-100. Default
        /// is 10.
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
        /// The ID of the Wickr network from which to list bots.
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
        /// The fields to sort bots by. Multiple fields can be specified by separating them with
        /// '+'. Accepted values include 'username', 'firstName', 'displayName', 'status', and
        /// 'groupId'.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// Filter results to only include bots with this status (1 for pending, 2 for active).
        /// </para>
        /// </summary>
        public int Status
        {
            get { return this._status.GetValueOrDefault(); }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// Filter results to only include bots with usernames matching this value.
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