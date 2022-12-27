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
    /// This is the response object from the DescribeReservedNodesOfferings operation.
    /// </summary>
    public partial class DescribeReservedNodesOfferingsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ReservedNodesOffering> _reservedNodesOfferings = new List<ReservedNodesOffering>();

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
        /// Gets and sets the property ReservedNodesOfferings. 
        /// <para>
        /// Lists available reserved node offerings.
        /// </para>
        /// </summary>
        public List<ReservedNodesOffering> ReservedNodesOfferings
        {
            get { return this._reservedNodesOfferings; }
            set { this._reservedNodesOfferings = value; }
        }

        // Check to see if ReservedNodesOfferings property is set
        internal bool IsSetReservedNodesOfferings()
        {
            return this._reservedNodesOfferings != null && this._reservedNodesOfferings.Count > 0; 
        }

    }
}