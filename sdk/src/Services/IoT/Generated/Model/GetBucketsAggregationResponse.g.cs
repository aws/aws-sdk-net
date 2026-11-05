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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the GetBucketsAggregation operation.
    /// </summary>
    public partial class GetBucketsAggregationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Buckets. 
        /// <para>
        /// The main part of the response with a list of buckets. Each bucket contains a <c>keyValue</c>
        /// and a <c>count</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>keyValue</c>: The aggregation field value counted for the particular bucket.
        /// </para>
        ///  
        /// <para>
        ///  <c>count</c>: The number of documents that have that value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Bucket> Buckets { get; set; } = AWSConfigs.InitializeCollections ? new List<Bucket>() : null;

        /// <summary>
        /// Checks to see if the Buckets property is set.
        /// </summary>
        internal bool IsSetBuckets() => this.Buckets != null && (this.Buckets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// The total number of things that fit the query string criteria.
        /// </para>
        /// </summary>
        public int? TotalCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalCount property is set.
        /// </summary>
        internal bool IsSetTotalCount() => this.TotalCount.HasValue;
    }
}
