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
    /// Returns the descriptions of the reserved nodes.
    /// </summary>
    public partial class DescribeReservedNodesRequest : AmazonWebServiceRequest
    {
        private string _marker;
        private int? _maxRecords;
        private string _reservedNodeId;


        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        ///            An optional parameter that specifies the starting point to return a set
        /// of response records.            When the results of a <a>DescribeReservedNodes</a>
        /// request exceed the value specified in <code>MaxRecords</code>,            AWS returns
        /// a value in the <code>Marker</code> field of the response. You can retrieve the next
        /// set of            response records by providing the returned marker value in the <code>Marker</code>
        /// parameter and            retrying the request.       
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }


        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeReservedNodesRequest WithMarker(string marker)
        {
            this._marker = marker;
            return this;
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }


        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        ///            The maximum number of response records to return in each call.        
        ///    If the number of remaining response records exceeds the specified <code>MaxRecords</code>
        /// value,            a value is returned in a <code>marker</code> field of the response.
        ///            You can retrieve the next set of records by retrying the command with the
        /// returned marker value.       
        /// </para>
        ///        
        /// <para>
        /// Default: <code>100</code>
        /// </para>
        ///        
        /// <para>
        /// Constraints: minimum 20, maximum 100.
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }


        /// <summary>
        /// Sets the MaxRecords property
        /// </summary>
        /// <param name="maxRecords">The value to set for the MaxRecords property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeReservedNodesRequest WithMaxRecords(int maxRecords)
        {
            this._maxRecords = maxRecords;
            return this;
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property ReservedNodeId. 
        /// <para>
        /// Identifier for the node reservation.
        /// </para>
        /// </summary>
        public string ReservedNodeId
        {
            get { return this._reservedNodeId; }
            set { this._reservedNodeId = value; }
        }


        /// <summary>
        /// Sets the ReservedNodeId property
        /// </summary>
        /// <param name="reservedNodeId">The value to set for the ReservedNodeId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeReservedNodesRequest WithReservedNodeId(string reservedNodeId)
        {
            this._reservedNodeId = reservedNodeId;
            return this;
        }

        // Check to see if ReservedNodeId property is set
        internal bool IsSetReservedNodeId()
        {
            return this._reservedNodeId != null;
        }

    }
}