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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeReservedNodeExchangeStatus operation.
    /// Returns exchange status details and associated metadata for a reserved-node exchange.
    /// Statuses include such values as in progress and requested.
    /// </summary>
    public partial class DescribeReservedNodeExchangeStatusRequest : AmazonRedshiftRequest
    {
        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional pagination token provided by a previous <c>DescribeReservedNodeExchangeStatus</c>
        /// request. If this parameter is specified, the response includes only records beyond
        /// the marker, up to the value specified by the <c>MaxRecords</c> parameter. You can
        /// retrieve the next set of response records by providing the returned marker value in
        /// the <c>Marker</c> parameter and retrying the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of response records to return in each call. If the number of remaining
        /// response records exceeds the specified <c>MaxRecords</c> value, a value is returned
        /// in a <c>Marker</c> field of the response. You can retrieve the next set of records
        /// by retrying the command with the returned marker value.
        /// </para>
        /// </summary>
        public int? MaxRecords { get; set; }

        /// <summary>
        /// Checks to see if the MaxRecords property is set.
        /// </summary>
        internal bool IsSetMaxRecords() => this.MaxRecords.HasValue;

        /// <summary>
        /// Gets and sets the property ReservedNodeExchangeRequestId. 
        /// <para>
        /// The identifier of the reserved-node exchange request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ReservedNodeExchangeRequestId { get; set; }

        /// <summary>
        /// Checks to see if the ReservedNodeExchangeRequestId property is set.
        /// </summary>
        internal bool IsSetReservedNodeExchangeRequestId() => this.ReservedNodeExchangeRequestId != null;

        /// <summary>
        /// Gets and sets the property ReservedNodeId. 
        /// <para>
        /// The identifier of the source reserved node in a reserved-node exchange request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ReservedNodeId { get; set; }

        /// <summary>
        /// Checks to see if the ReservedNodeId property is set.
        /// </summary>
        internal bool IsSetReservedNodeId() => this.ReservedNodeId != null;
    }
}
