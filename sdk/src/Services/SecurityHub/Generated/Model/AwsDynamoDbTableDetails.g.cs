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
    /// Provides details about a DynamoDB table.
    /// </summary>
    public partial class AwsDynamoDbTableDetails
    {
        /// <summary>
        /// Gets and sets the property AttributeDefinitions. 
        /// <para>
        /// A list of attribute definitions for the table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsDynamoDbTableAttributeDefinition> AttributeDefinitions { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsDynamoDbTableAttributeDefinition>() : null;

        /// <summary>
        /// Checks to see if the AttributeDefinitions property is set.
        /// </summary>
        internal bool IsSetAttributeDefinitions() => this.AttributeDefinitions != null && (this.AttributeDefinitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BillingModeSummary. 
        /// <para>
        /// Information about the billing for read/write capacity on the table.
        /// </para>
        /// </summary>
        public AwsDynamoDbTableBillingModeSummary BillingModeSummary { get; set; }

        /// <summary>
        /// Checks to see if the BillingModeSummary property is set.
        /// </summary>
        internal bool IsSetBillingModeSummary() => this.BillingModeSummary != null;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// Indicates when the table was created.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime != null;

        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        ///  Indicates whether deletion protection is to be enabled (true) or disabled (false)
        /// on the table. 
        /// </para>
        /// </summary>
        public bool? DeletionProtectionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtectionEnabled property is set.
        /// </summary>
        internal bool IsSetDeletionProtectionEnabled() => this.DeletionProtectionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property GlobalSecondaryIndexes. 
        /// <para>
        /// List of global secondary indexes for the table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsDynamoDbTableGlobalSecondaryIndex> GlobalSecondaryIndexes { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsDynamoDbTableGlobalSecondaryIndex>() : null;

        /// <summary>
        /// Checks to see if the GlobalSecondaryIndexes property is set.
        /// </summary>
        internal bool IsSetGlobalSecondaryIndexes() => this.GlobalSecondaryIndexes != null && (this.GlobalSecondaryIndexes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GlobalTableVersion. 
        /// <para>
        /// The version of global tables being used.
        /// </para>
        /// </summary>
        public string GlobalTableVersion { get; set; }

        /// <summary>
        /// Checks to see if the GlobalTableVersion property is set.
        /// </summary>
        internal bool IsSetGlobalTableVersion() => this.GlobalTableVersion != null;

        /// <summary>
        /// Gets and sets the property ItemCount. 
        /// <para>
        /// The number of items in the table.
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
        /// The primary key structure for the table.
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
        /// Gets and sets the property LatestStreamArn. 
        /// <para>
        /// The ARN of the latest stream for the table.
        /// </para>
        /// </summary>
        public string LatestStreamArn { get; set; }

        /// <summary>
        /// Checks to see if the LatestStreamArn property is set.
        /// </summary>
        internal bool IsSetLatestStreamArn() => this.LatestStreamArn != null;

        /// <summary>
        /// Gets and sets the property LatestStreamLabel. 
        /// <para>
        /// The label of the latest stream. The label is not a unique identifier.
        /// </para>
        /// </summary>
        public string LatestStreamLabel { get; set; }

        /// <summary>
        /// Checks to see if the LatestStreamLabel property is set.
        /// </summary>
        internal bool IsSetLatestStreamLabel() => this.LatestStreamLabel != null;

        /// <summary>
        /// Gets and sets the property LocalSecondaryIndexes. 
        /// <para>
        /// The list of local secondary indexes for the table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsDynamoDbTableLocalSecondaryIndex> LocalSecondaryIndexes { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsDynamoDbTableLocalSecondaryIndex>() : null;

        /// <summary>
        /// Checks to see if the LocalSecondaryIndexes property is set.
        /// </summary>
        internal bool IsSetLocalSecondaryIndexes() => this.LocalSecondaryIndexes != null && (this.LocalSecondaryIndexes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProvisionedThroughput. 
        /// <para>
        /// Information about the provisioned throughput for the table.
        /// </para>
        /// </summary>
        public AwsDynamoDbTableProvisionedThroughput ProvisionedThroughput { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedThroughput property is set.
        /// </summary>
        internal bool IsSetProvisionedThroughput() => this.ProvisionedThroughput != null;

        /// <summary>
        /// Gets and sets the property Replicas. 
        /// <para>
        /// The list of replicas of this table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsDynamoDbTableReplica> Replicas { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsDynamoDbTableReplica>() : null;

        /// <summary>
        /// Checks to see if the Replicas property is set.
        /// </summary>
        internal bool IsSetReplicas() => this.Replicas != null && (this.Replicas.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RestoreSummary. 
        /// <para>
        /// Information about the restore for the table.
        /// </para>
        /// </summary>
        public AwsDynamoDbTableRestoreSummary RestoreSummary { get; set; }

        /// <summary>
        /// Checks to see if the RestoreSummary property is set.
        /// </summary>
        internal bool IsSetRestoreSummary() => this.RestoreSummary != null;

        /// <summary>
        /// Gets and sets the property SseDescription. 
        /// <para>
        /// Information about the server-side encryption for the table.
        /// </para>
        /// </summary>
        public AwsDynamoDbTableSseDescription SseDescription { get; set; }

        /// <summary>
        /// Checks to see if the SseDescription property is set.
        /// </summary>
        internal bool IsSetSseDescription() => this.SseDescription != null;

        /// <summary>
        /// Gets and sets the property StreamSpecification. 
        /// <para>
        /// The current DynamoDB Streams configuration for the table.
        /// </para>
        /// </summary>
        public AwsDynamoDbTableStreamSpecification StreamSpecification { get; set; }

        /// <summary>
        /// Checks to see if the StreamSpecification property is set.
        /// </summary>
        internal bool IsSetStreamSpecification() => this.StreamSpecification != null;

        /// <summary>
        /// Gets and sets the property TableId. 
        /// <para>
        /// The identifier of the table.
        /// </para>
        /// </summary>
        public string TableId { get; set; }

        /// <summary>
        /// Checks to see if the TableId property is set.
        /// </summary>
        internal bool IsSetTableId() => this.TableId != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table.
        /// </para>
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;

        /// <summary>
        /// Gets and sets the property TableSizeBytes. 
        /// <para>
        /// The total size of the table in bytes.
        /// </para>
        /// </summary>
        public long? TableSizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the TableSizeBytes property is set.
        /// </summary>
        internal bool IsSetTableSizeBytes() => this.TableSizeBytes.HasValue;

        /// <summary>
        /// Gets and sets the property TableStatus. 
        /// <para>
        /// The current status of the table. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ARCHIVED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ARCHIVING</c> 
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
        ///  <c>INACCESSIBLE_ENCRYPTION_CREDENTIALS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string TableStatus { get; set; }

        /// <summary>
        /// Checks to see if the TableStatus property is set.
        /// </summary>
        internal bool IsSetTableStatus() => this.TableStatus != null;
    }
}
