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

namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeReservedNodes operation. Returns information
    /// about reserved nodes for this account, or about a specified reserved node.
    /// </summary>
    public partial class DescribeReservedNodesRequest : AmazonMemoryDBRequest
    {
        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The duration filter value, specified in years or seconds. Use this parameter to show
        /// only reservations for this duration.
        /// </para>
        /// </summary>
        public string Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of records to include in the response. If more records exist than
        /// the specified MaxRecords value, a marker is included in the response so that the remaining
        /// results can be retrieved.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An optional marker returned from a prior request. Use this marker for pagination of
        /// results from this operation. If this parameter is specified, the response includes
        /// only records beyond the marker, up to the value specified by MaxRecords.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The node type filter value. Use this parameter to show only those reservations matching
        /// the specified node type. For more information, see <a href="https://docs.aws.amazon.com/memorydb/latest/devguide/nodes.reserved.html#reserved-nodes-supported">Supported
        /// node types</a>.
        /// </para>
        /// </summary>
        public string NodeType { get; set; }

        /// <summary>
        /// Checks to see if the NodeType property is set.
        /// </summary>
        internal bool IsSetNodeType() => this.NodeType != null;

        /// <summary>
        /// Gets and sets the property OfferingType. 
        /// <para>
        /// The offering type filter value. Use this parameter to show only the available offerings
        /// matching the specified offering type. Valid values: "All Upfront"|"Partial Upfront"|
        /// "No Upfront"
        /// </para>
        /// </summary>
        public string OfferingType { get; set; }

        /// <summary>
        /// Checks to see if the OfferingType property is set.
        /// </summary>
        internal bool IsSetOfferingType() => this.OfferingType != null;

        /// <summary>
        /// Gets and sets the property ReservationId. 
        /// <para>
        /// The reserved node identifier filter value. Use this parameter to show only the reservation
        /// that matches the specified reservation ID.
        /// </para>
        /// </summary>
        public string ReservationId { get; set; }

        /// <summary>
        /// Checks to see if the ReservationId property is set.
        /// </summary>
        internal bool IsSetReservationId() => this.ReservationId != null;

        /// <summary>
        /// Gets and sets the property ReservedNodesOfferingId. 
        /// <para>
        /// The offering identifier filter value. Use this parameter to show only purchased reservations
        /// matching the specified offering identifier.
        /// </para>
        /// </summary>
        public string ReservedNodesOfferingId { get; set; }

        /// <summary>
        /// Checks to see if the ReservedNodesOfferingId property is set.
        /// </summary>
        internal bool IsSetReservedNodesOfferingId() => this.ReservedNodesOfferingId != null;
    }
}
