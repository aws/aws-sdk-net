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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Represents the properties of a global secondary index.
    /// </summary>
    public partial class GlobalSecondaryIndexDescription
    {
        /// <summary>
        /// Gets and sets the property Backfilling. 
        /// <para>
        /// Indicates whether the index is currently backfilling. <i>Backfilling</i> is the process
        /// of reading items from the table and determining whether they can be added to the index.
        /// (Not all items will qualify: For example, a partition key cannot have any duplicate
        /// values.) If an item can be added to the index, DynamoDB will do so. After all items
        /// have been processed, the backfilling operation is complete and <c>Backfilling</c>
        /// is false.
        /// </para>
        ///  
        /// <para>
        /// You can delete an index that is being created during the <c>Backfilling</c> phase
        /// when <c>IndexStatus</c> is set to CREATING and <c>Backfilling</c> is true. You can't
        /// delete the index that is being created when <c>IndexStatus</c> is set to CREATING
        /// and <c>Backfilling</c> is false. 
        /// </para>
        ///  <note> 
        /// <para>
        /// For indexes that were created during a <c>CreateTable</c> operation, the <c>Backfilling</c>
        /// attribute does not appear in the <c>DescribeTable</c> output.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? Backfilling { get; set; }

        /// <summary>
        /// Checks to see if the Backfilling property is set.
        /// </summary>
        internal bool IsSetBackfilling() => this.Backfilling.HasValue;

        /// <summary>
        /// Gets and sets the property IndexArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the index.
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
        /// The name of the global secondary index.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string IndexName { get; set; }

        /// <summary>
        /// Checks to see if the IndexName property is set.
        /// </summary>
        internal bool IsSetIndexName() => this.IndexName != null;

        /// <summary>
        /// Gets and sets the property IndexSizeBytes. 
        /// <para>
        /// The total size of the specified index, in bytes. DynamoDB updates this value approximately
        /// every six hours. Recent changes might not be reflected in this value.
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
        /// The current state of the global secondary index:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> - The index is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> - The index is being updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> - The index is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - The index is ready for use.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IndexStatus IndexStatus { get; set; }

        /// <summary>
        /// Checks to see if the IndexStatus property is set.
        /// </summary>
        internal bool IsSetIndexStatus() => this.IndexStatus != null;

        /// <summary>
        /// Gets and sets the property ItemCount. 
        /// <para>
        /// The number of items in the specified index. DynamoDB updates this value approximately
        /// every six hours. Recent changes might not be reflected in this value.
        /// </para>
        /// </summary>
        public long? ItemCount { get; set; }

        /// <summary>
        /// Checks to see if the ItemCount property is set.
        /// </summary>
        internal bool IsSetItemCount() => this.ItemCount.HasValue;

        /// <summary>
        /// Gets and sets the property KeySchema. 
        /// <para>
        /// The complete key schema for a global secondary index, which consists of one or more
        /// pairs of attribute names and key types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HASH</c> - partition key
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RANGE</c> - sort key
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The partition key of an item is also known as its <i>hash attribute</i>. The term
        /// "hash attribute" derives from DynamoDB's usage of an internal hash function to evenly
        /// distribute data items across partitions, based on their partition key values.
        /// </para>
        ///  
        /// <para>
        /// The sort key of an item is also known as its <i>range attribute</i>. The term "range
        /// attribute" derives from the way DynamoDB stores items with the same partition key
        /// physically close together, in sorted order by the sort key value.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<KeySchemaElement> KeySchema { get; set; } = AWSConfigs.InitializeCollections ? new List<KeySchemaElement>() : null;

        /// <summary>
        /// Checks to see if the KeySchema property is set.
        /// </summary>
        internal bool IsSetKeySchema() => this.KeySchema != null && (this.KeySchema.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OnDemandThroughput. 
        /// <para>
        /// The maximum number of read and write units for the specified global secondary index.
        /// If you use this parameter, you must specify <c>MaxReadRequestUnits</c>, <c>MaxWriteRequestUnits</c>,
        /// or both.
        /// </para>
        /// </summary>
        public OnDemandThroughput OnDemandThroughput { get; set; }

        /// <summary>
        /// Checks to see if the OnDemandThroughput property is set.
        /// </summary>
        internal bool IsSetOnDemandThroughput() => this.OnDemandThroughput != null;

        /// <summary>
        /// Gets and sets the property Projection. 
        /// <para>
        /// Represents attributes that are copied (projected) from the table into the global secondary
        /// index. These are in addition to the primary key attributes and index key attributes,
        /// which are automatically projected. 
        /// </para>
        /// </summary>
        public Projection Projection { get; set; }

        /// <summary>
        /// Checks to see if the Projection property is set.
        /// </summary>
        internal bool IsSetProjection() => this.Projection != null;

        /// <summary>
        /// Gets and sets the property ProvisionedThroughput. 
        /// <para>
        /// Represents the provisioned throughput settings for the specified global secondary
        /// index.
        /// </para>
        ///  
        /// <para>
        /// For current minimum and maximum provisioned throughput values, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Limits.html">Service,
        /// Account, and Table Quotas</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        public ProvisionedThroughputDescription ProvisionedThroughput { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedThroughput property is set.
        /// </summary>
        internal bool IsSetProvisionedThroughput() => this.ProvisionedThroughput != null;

        /// <summary>
        /// Gets and sets the property WarmThroughput. 
        /// <para>
        /// Represents the warm throughput value (in read units per second and write units per
        /// second) for the specified secondary index.
        /// </para>
        /// </summary>
        public GlobalSecondaryIndexWarmThroughputDescription WarmThroughput { get; set; }

        /// <summary>
        /// Checks to see if the WarmThroughput property is set.
        /// </summary>
        internal bool IsSetWarmThroughput() => this.WarmThroughput != null;
    }
}
