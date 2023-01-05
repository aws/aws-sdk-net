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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeReservedNodesOfferings operation.
    /// Lists available reserved node offerings.
    /// </summary>
    public partial class DescribeReservedNodesOfferingsRequest : AmazonMemoryDBRequest
    {
        private string _duration;
        private int? _maxResults;
        private string _nextToken;
        private string _nodeType;
        private string _offeringType;
        private string _reservedNodesOfferingId;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// Duration filter value, specified in years or seconds. Use this parameter to show only
        /// reservations for a given duration.
        /// </para>
        /// </summary>
        public string Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of records to include in the response. If more records exist than
        /// the specified MaxRecords value, a marker is included in the response so that the remaining
        /// results can be retrieved.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An optional marker returned from a prior request. Use this marker for pagination of
        /// results from this operation. If this parameter is specified, the response includes
        /// only records beyond the marker, up to the value specified by MaxRecords.
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
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The node type for the reserved nodes. For more information, see <a href="https://docs.aws.amazon.com/memorydb/latest/devguide/nodes.reserved.html#reserved-nodes-supported">Supported
        /// node types</a>.
        /// </para>
        /// </summary>
        public string NodeType
        {
            get { return this._nodeType; }
            set { this._nodeType = value; }
        }

        // Check to see if NodeType property is set
        internal bool IsSetNodeType()
        {
            return this._nodeType != null;
        }

        /// <summary>
        /// Gets and sets the property OfferingType. 
        /// <para>
        /// The offering type filter value. Use this parameter to show only the available offerings
        /// matching the specified offering type. Valid values: "All Upfront"|"Partial Upfront"|
        /// "No Upfront"
        /// </para>
        /// </summary>
        public string OfferingType
        {
            get { return this._offeringType; }
            set { this._offeringType = value; }
        }

        // Check to see if OfferingType property is set
        internal bool IsSetOfferingType()
        {
            return this._offeringType != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedNodesOfferingId. 
        /// <para>
        /// The offering identifier filter value. Use this parameter to show only the available
        /// offering that matches the specified reservation identifier.
        /// </para>
        /// </summary>
        public string ReservedNodesOfferingId
        {
            get { return this._reservedNodesOfferingId; }
            set { this._reservedNodesOfferingId = value; }
        }

        // Check to see if ReservedNodesOfferingId property is set
        internal bool IsSetReservedNodesOfferingId()
        {
            return this._reservedNodesOfferingId != null;
        }

    }
}