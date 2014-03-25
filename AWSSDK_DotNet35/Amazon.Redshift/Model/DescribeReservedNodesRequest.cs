/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeReservedNodes operation.
    /// <para> Returns the descriptions of the reserved nodes. </para>
    /// </summary>
    public partial class DescribeReservedNodesRequest : AmazonRedshiftRequest
    {
        private string reservedNodeId;
        private int? maxRecords;
        private string marker;


        /// <summary>
        /// Identifier for the node reservation.
        ///  
        /// </summary>
        public string ReservedNodeId
        {
            get { return this.reservedNodeId; }
            set { this.reservedNodeId = value; }
        }

        // Check to see if ReservedNodeId property is set
        internal bool IsSetReservedNodeId()
        {
            return this.reservedNodeId != null;
        }

        /// <summary>
        /// The maximum number of response records to return in each call. If the number of remaining response records exceeds the specified
        /// <c>MaxRecords</c> value, a value is returned in a <c>marker</c> field of the response. You can retrieve the next set of records by retrying
        /// the command with the returned marker value. Default: <c>100</c> Constraints: minimum 20, maximum 100.
        ///  
        /// </summary>
        public int MaxRecords
        {
            get { return this.maxRecords ?? default(int); }
            set { this.maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this.maxRecords.HasValue;
        }

        /// <summary>
        /// An optional parameter that specifies the starting point to return a set of response records. When the results of a
        /// <a>DescribeReservedNodes</a> request exceed the value specified in <c>MaxRecords</c>, AWS returns a value in the <c>Marker</c> field of the
        /// response. You can retrieve the next set of response records by providing the returned marker value in the <c>Marker</c> parameter and
        /// retrying the request.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

    }
}
    
