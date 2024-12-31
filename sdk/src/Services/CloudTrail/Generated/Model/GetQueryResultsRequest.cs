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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the GetQueryResults operation.
    /// Gets event data results of a query. You must specify the <c>QueryID</c> value returned
    /// by the <c>StartQuery</c> operation.
    /// </summary>
    public partial class GetQueryResultsRequest : AmazonCloudTrailRequest
    {
        private string _eventDataStore;
        private string _eventDataStoreOwnerAccountId;
        private int? _maxQueryResults;
        private string _nextToken;
        private string _queryId;

        /// <summary>
        /// Gets and sets the property EventDataStore. 
        /// <para>
        /// The ARN (or ID suffix of the ARN) of the event data store against which the query
        /// was run.
        /// </para>
        /// </summary>
        [Obsolete("EventDataStore is no longer required by GetQueryResultsRequest")]
        [AWSProperty(Min=3, Max=256)]
        public string EventDataStore
        {
            get { return this._eventDataStore; }
            set { this._eventDataStore = value; }
        }

        // Check to see if EventDataStore property is set
        internal bool IsSetEventDataStore()
        {
            return this._eventDataStore != null;
        }

        /// <summary>
        /// Gets and sets the property EventDataStoreOwnerAccountId. 
        /// <para>
        ///  The account ID of the event data store owner. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=16)]
        public string EventDataStoreOwnerAccountId
        {
            get { return this._eventDataStoreOwnerAccountId; }
            set { this._eventDataStoreOwnerAccountId = value; }
        }

        // Check to see if EventDataStoreOwnerAccountId property is set
        internal bool IsSetEventDataStoreOwnerAccountId()
        {
            return this._eventDataStoreOwnerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxQueryResults. 
        /// <para>
        /// The maximum number of query results to display on a single page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxQueryResults
        {
            get { return this._maxQueryResults; }
            set { this._maxQueryResults = value; }
        }

        // Check to see if MaxQueryResults property is set
        internal bool IsSetMaxQueryResults()
        {
            return this._maxQueryResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token you can use to get the next page of query results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=1000)]
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
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The ID of the query for which you want to get results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string QueryId
        {
            get { return this._queryId; }
            set { this._queryId = value; }
        }

        // Check to see if QueryId property is set
        internal bool IsSetQueryId()
        {
            return this._queryId != null;
        }

    }
}