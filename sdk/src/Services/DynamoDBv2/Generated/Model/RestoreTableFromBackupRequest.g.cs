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
    /// Container for the parameters to the RestoreTableFromBackup operation. Creates a new
    /// table from an existing backup. Any number of users can execute up to 50 concurrent
    /// restores (any type of restore) in a given account. <para> You can call <c>RestoreTableFromBackup</c>
    /// at a maximum rate of 10 times per second. </para> <para> You must manually set up
    /// the following on the restored table: </para> <ul> <li> <para> Auto scaling policies
    /// </para> </li> <li> <para> IAM policies </para> </li> <li> <para> Amazon CloudWatch
    /// metrics and alarms </para> </li> <li> <para> Tags </para> </li> <li> <para> Stream
    /// settings </para> </li> <li> <para> Time to Live (TTL) settings </para> </li> </ul>
    /// </summary>
    public partial class RestoreTableFromBackupRequest : AmazonDynamoDBRequest
    {
        /// <summary>
        /// Gets and sets the property BackupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) associated with the backup.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 37, Max = 1024)]
        public string BackupArn { get; set; }

        /// <summary>
        /// Checks to see if the BackupArn property is set.
        /// </summary>
        internal bool IsSetBackupArn() => this.BackupArn != null;

        /// <summary>
        /// Gets and sets the property BillingModeOverride. 
        /// <para>
        /// The billing mode of the restored table.
        /// </para>
        /// </summary>
        public BillingMode BillingModeOverride { get; set; }

        /// <summary>
        /// Checks to see if the BillingModeOverride property is set.
        /// </summary>
        internal bool IsSetBillingModeOverride() => this.BillingModeOverride != null;

        /// <summary>
        /// Gets and sets the property GlobalSecondaryIndexOverride. 
        /// <para>
        /// List of global secondary indexes for the restored table. The indexes provided should
        /// match existing secondary indexes. You can choose to exclude some or all of the indexes
        /// at the time of restore.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GlobalSecondaryIndex> GlobalSecondaryIndexOverride { get; set; } = AWSConfigs.InitializeCollections ? new List<GlobalSecondaryIndex>() : null;

        /// <summary>
        /// Checks to see if the GlobalSecondaryIndexOverride property is set.
        /// </summary>
        internal bool IsSetGlobalSecondaryIndexOverride() => this.GlobalSecondaryIndexOverride != null && (this.GlobalSecondaryIndexOverride.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LocalSecondaryIndexOverride. 
        /// <para>
        /// List of local secondary indexes for the restored table. The indexes provided should
        /// match existing secondary indexes. You can choose to exclude some or all of the indexes
        /// at the time of restore.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LocalSecondaryIndex> LocalSecondaryIndexOverride { get; set; } = AWSConfigs.InitializeCollections ? new List<LocalSecondaryIndex>() : null;

        /// <summary>
        /// Checks to see if the LocalSecondaryIndexOverride property is set.
        /// </summary>
        internal bool IsSetLocalSecondaryIndexOverride() => this.LocalSecondaryIndexOverride != null && (this.LocalSecondaryIndexOverride.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OnDemandThroughputOverride.
        /// </summary>
        public OnDemandThroughput OnDemandThroughputOverride { get; set; }

        /// <summary>
        /// Checks to see if the OnDemandThroughputOverride property is set.
        /// </summary>
        internal bool IsSetOnDemandThroughputOverride() => this.OnDemandThroughputOverride != null;

        /// <summary>
        /// Gets and sets the property ProvisionedThroughputOverride. 
        /// <para>
        /// Provisioned throughput settings for the restored table.
        /// </para>
        /// </summary>
        public ProvisionedThroughput ProvisionedThroughputOverride { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedThroughputOverride property is set.
        /// </summary>
        internal bool IsSetProvisionedThroughputOverride() => this.ProvisionedThroughputOverride != null;

        /// <summary>
        /// Gets and sets the property SSESpecificationOverride. 
        /// <para>
        /// The new server-side encryption settings for the restored table.
        /// </para>
        /// </summary>
        public SSESpecification SSESpecificationOverride { get; set; }

        /// <summary>
        /// Checks to see if the SSESpecificationOverride property is set.
        /// </summary>
        internal bool IsSetSSESpecificationOverride() => this.SSESpecificationOverride != null;

        /// <summary>
        /// Gets and sets the property TargetTableName. 
        /// <para>
        /// The name of the new table to which the backup must be restored.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 255)]
        public string TargetTableName { get; set; }

        /// <summary>
        /// Checks to see if the TargetTableName property is set.
        /// </summary>
        internal bool IsSetTargetTableName() => this.TargetTableName != null;

        /// <summary>
        /// Gets and sets the property VectorIndexOverride. 
        /// <para>
        /// The vector indexes for the restored table. If not specified, all vector indexes from
        /// the backup are restored. The indexes provided must match existing vector indexes from
        /// the backup. You can choose to exclude some or all of the vector indexes at the time
        /// of restore.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VectorIndex> VectorIndexOverride { get; set; } = AWSConfigs.InitializeCollections ? new List<VectorIndex>() : null;

        /// <summary>
        /// Checks to see if the VectorIndexOverride property is set.
        /// </summary>
        internal bool IsSetVectorIndexOverride() => this.VectorIndexOverride != null && (this.VectorIndexOverride.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
