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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information abut a global secondary index for the table.
    /// </summary>
    public partial class AwsDynamoDbTableGlobalSecondaryIndex
    {
        /// <summary>
        /// Gets and sets the property Backfilling. 
        /// <para>
        /// Whether the index is currently backfilling.
        /// </para>
        /// </summary>
        public bool? Backfilling { get; set; }

        /// <summary>
        /// Checks to see if the Backfilling property is set.
        /// </summary>
        internal bool IsSetBackfilling() => this.Backfilling.HasValue;

        /// <summary>
        /// Gets and sets the property IndexArn. 
        /// <para>
        /// The ARN of the index.
        /// </para>
        /// </summary>
        public string IndexArn { get; set; }

        /// <summary>
        /// Checks to see if the IndexArn property is set.
        /// </summary>
        internal bool IsSetIndexArn() => this.IndexArn != null;

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the index.
        /// </para>
        /// </summary>
        public string IndexName { get; set; }

        /// <summary>
        /// Checks to see if the IndexName property is set.
        /// </summary>
        internal bool IsSetIndexName() => this.IndexName != null;

        /// <summary>
        /// Gets and sets the property IndexSizeBytes. 
        /// <para>
        /// The total size in bytes of the index.
        /// </para>
        /// </summary>
        public long? IndexSizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the IndexSizeBytes property is set.
        /// </summary>
        internal bool IsSetIndexSizeBytes() => this.IndexSizeBytes.HasValue;

        /// <summary>
        /// Gets and sets the property IndexStatus. 
        /// <para>
        /// The current status of the index.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATING</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string IndexStatus { get; set; }

        /// <summary>
        /// Checks to see if the IndexStatus property is set.
        /// </summary>
        internal bool IsSetIndexStatus() => this.IndexStatus != null;

        /// <summary>
        /// Gets and sets the property ItemCount. 
        /// <para>
        /// The number of items in the index.
        /// </para>
        /// </summary>
        public int? ItemCount { get; set; }

        /// <summary>
        /// Checks to see if the ItemCount property is set.
        /// </summary>
        internal bool IsSetItemCount() => this.ItemCount.HasValue;

        /// <summary>
        /// Gets and sets the property KeySchema. 
        /// <para>
        /// The key schema for the index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsDynamoDbTableKeySchema> KeySchema { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsDynamoDbTableKeySchema>() : null;

        /// <summary>
        /// Checks to see if the KeySchema property is set.
        /// </summary>
        internal bool IsSetKeySchema() => this.KeySchema != null && (this.KeySchema.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Projection. 
        /// <para>
        /// Attributes that are copied from the table into an index.
        /// </para>
        /// </summary>
        public AwsDynamoDbTableProjection Projection { get; set; }

        /// <summary>
        /// Checks to see if the Projection property is set.
        /// </summary>
        internal bool IsSetProjection() => this.Projection != null;

        /// <summary>
        /// Gets and sets the property ProvisionedThroughput. 
        /// <para>
        /// Information about the provisioned throughput settings for the indexes.
        /// </para>
        /// </summary>
        public AwsDynamoDbTableProvisionedThroughput ProvisionedThroughput { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedThroughput property is set.
        /// </summary>
        internal bool IsSetProvisionedThroughput() => this.ProvisionedThroughput != null;
    }
}
