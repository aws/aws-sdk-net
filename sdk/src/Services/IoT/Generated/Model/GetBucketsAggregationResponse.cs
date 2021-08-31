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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the GetBucketsAggregation operation.
    /// </summary>
    public partial class GetBucketsAggregationResponse : AmazonWebServiceResponse
    {
        private List<Bucket> _buckets = new List<Bucket>();
        private int? _totalCount;

        /// <summary>
        /// Gets and sets the property Buckets. 
        /// <para>
        /// The main part of the response with a list of buckets. Each bucket contains a <code>keyValue</code>
        /// and a <code>count</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>keyValue</code>: The aggregation field value counted for the particular bucket.
        /// </para>
        ///  
        /// <para>
        ///  <code>count</code>: The number of documents that have that value.
        /// </para>
        /// </summary>
        public List<Bucket> Buckets
        {
            get { return this._buckets; }
            set { this._buckets = value; }
        }

        // Check to see if Buckets property is set
        internal bool IsSetBuckets()
        {
            return this._buckets != null && this._buckets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// The total number of documents that fit the query string criteria and contain a value
        /// for the Aggregation field targeted in the request.
        /// </para>
        /// </summary>
        public int TotalCount
        {
            get { return this._totalCount.GetValueOrDefault(); }
            set { this._totalCount = value; }
        }

        // Check to see if TotalCount property is set
        internal bool IsSetTotalCount()
        {
            return this._totalCount.HasValue; 
        }

    }
}