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
    /// Container for the parameters to the ListLineageNodeHistory operation.
    /// Lists the history of the specified data lineage node.
    /// </summary>
    public partial class ListLineageNodeHistoryRequest : AmazonDataZoneRequest
    {
        private EdgeDirection _direction;
        private string _domainIdentifier;
        private DateTime? _eventTimestampGTE;
        private DateTime? _eventTimestampLTE;
        private string _identifier;
        private int? _maxResults;
        private string _nextToken;
        private SortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property Direction. 
        /// <para>
        /// The direction of the data lineage node refers to the lineage node having neighbors
        /// in that direction. For example, if direction is <c>UPSTREAM</c>, the <c>ListLineageNodeHistory</c>
        /// API responds with historical versions with upstream neighbors only.
        /// </para>
        /// </summary>
        public EdgeDirection Direction
        {
            get { return this._direction; }
            set { this._direction = value; }
        }

        // Check to see if Direction property is set
        internal bool IsSetDirection()
        {
            return this._direction != null;
        }

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the domain where you want to list the history of the specified data lineage
        /// node.
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
        /// Gets and sets the property EventTimestampGTE. 
        /// <para>
        /// Specifies whether the action is to return data lineage node history from the time
        /// after the event timestamp.
        /// </para>
        /// </summary>
        public DateTime? EventTimestampGTE
        {
            get { return this._eventTimestampGTE; }
            set { this._eventTimestampGTE = value; }
        }

        // Check to see if EventTimestampGTE property is set
        internal bool IsSetEventTimestampGTE()
        {
            return this._eventTimestampGTE.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventTimestampLTE. 
        /// <para>
        /// Specifies whether the action is to return data lineage node history from the time
        /// prior of the event timestamp.
        /// </para>
        /// </summary>
        public DateTime? EventTimestampLTE
        {
            get { return this._eventTimestampLTE; }
            set { this._eventTimestampLTE = value; }
        }

        // Check to see if EventTimestampLTE property is set
        internal bool IsSetEventTimestampLTE()
        {
            return this._eventTimestampLTE.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The ID of the data lineage node whose history you want to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2086)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of history items to return in a single call to ListLineageNodeHistory.
        /// When the number of memberships to be listed is greater than the value of MaxResults,
        /// the response contains a NextToken value that you can use in a subsequent call to ListLineageNodeHistory
        /// to list the next set of items.
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
        /// When the number of history items is greater than the default value for the MaxResults
        /// parameter, or if you explicitly specify a value for MaxResults that is less than the
        /// number of items, the response includes a pagination token named NextToken. You can
        /// specify this NextToken value in a subsequent call to ListLineageNodeHistory to list
        /// the next set of items.
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
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The order by which you want data lineage node history to be sorted.
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

    }
}