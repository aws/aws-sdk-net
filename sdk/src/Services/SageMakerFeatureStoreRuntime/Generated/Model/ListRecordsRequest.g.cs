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

namespace Amazon.SageMakerFeatureStoreRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the ListRecords operation. Lists the <c>RecordIdentifier</c>
    /// values of all records stored in a <c>FeatureGroup</c>'s <c>OnlineStore</c>. This enables
    /// you to discover which records exist without retrieving the full record data.
    /// </summary>
    public partial class ListRecordsRequest : AmazonSageMakerFeatureStoreRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property FeatureGroupName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the feature group to list records from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 150)]
        public string FeatureGroupName { get; set; }

        /// <summary>
        /// Checks to see if the FeatureGroupName property is set.
        /// </summary>
        internal bool IsSetFeatureGroupName() => this.FeatureGroupName != null;

        /// <summary>
        /// Gets and sets the property IncludeSoftDeletedRecords. 
        /// <para>
        /// If set to <c>true</c>, the result includes records that have been soft deleted.
        /// </para>
        /// </summary>
        public bool? IncludeSoftDeletedRecords { get; set; }

        /// <summary>
        /// Checks to see if the IncludeSoftDeletedRecords property is set.
        /// </summary>
        internal bool IsSetIncludeSoftDeletedRecords() => this.IncludeSoftDeletedRecords.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of record identifiers to return in a single page of results. For
        /// the <c>InMemory</c> tier, this value is a hint and not a strict requirement. The response
        /// may contain more or fewer results than the specified <c>MaxResults</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to resume pagination of <c>ListRecords</c> results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
