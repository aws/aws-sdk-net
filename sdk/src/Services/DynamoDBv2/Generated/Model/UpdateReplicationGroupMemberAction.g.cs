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
    /// Represents a replica to be modified.
    /// </summary>
    public partial class UpdateReplicationGroupMemberAction
    {
        /// <summary>
        /// Gets and sets the property GlobalSecondaryIndexes. 
        /// <para>
        /// Replica-specific global secondary index settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<ReplicaGlobalSecondaryIndex> GlobalSecondaryIndexes { get; set; } = AWSConfigs.InitializeCollections ? new List<ReplicaGlobalSecondaryIndex>() : null;

        /// <summary>
        /// Checks to see if the GlobalSecondaryIndexes property is set.
        /// </summary>
        internal bool IsSetGlobalSecondaryIndexes() => this.GlobalSecondaryIndexes != null && (this.GlobalSecondaryIndexes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KMSMasterKeyId. 
        /// <para>
        /// The KMS key of the replica that should be used for KMS encryption. To specify a key,
        /// use its key ID, Amazon Resource Name (ARN), alias name, or alias ARN. Note that you
        /// should only provide this parameter if the key is different from the default DynamoDB
        /// KMS key <c>alias/aws/dynamodb</c>.
        /// </para>
        /// </summary>
        public string KMSMasterKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KMSMasterKeyId property is set.
        /// </summary>
        internal bool IsSetKMSMasterKeyId() => this.KMSMasterKeyId != null;

        /// <summary>
        /// Gets and sets the property OnDemandThroughputOverride. 
        /// <para>
        /// Overrides the maximum on-demand throughput for the replica table.
        /// </para>
        /// </summary>
        public OnDemandThroughputOverride OnDemandThroughputOverride { get; set; }

        /// <summary>
        /// Checks to see if the OnDemandThroughputOverride property is set.
        /// </summary>
        internal bool IsSetOnDemandThroughputOverride() => this.OnDemandThroughputOverride != null;

        /// <summary>
        /// Gets and sets the property ProvisionedThroughputOverride. 
        /// <para>
        /// Replica-specific provisioned throughput. If not specified, uses the source table's
        /// provisioned throughput settings.
        /// </para>
        /// </summary>
        public ProvisionedThroughputOverride ProvisionedThroughputOverride { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedThroughputOverride property is set.
        /// </summary>
        internal bool IsSetProvisionedThroughputOverride() => this.ProvisionedThroughputOverride != null;

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The Region where the replica exists.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RegionName { get; set; }

        /// <summary>
        /// Checks to see if the RegionName property is set.
        /// </summary>
        internal bool IsSetRegionName() => this.RegionName != null;

        /// <summary>
        /// Gets and sets the property TableClassOverride. 
        /// <para>
        /// Replica-specific table class. If not specified, uses the source table's table class.
        /// </para>
        /// </summary>
        public TableClass TableClassOverride { get; set; }

        /// <summary>
        /// Checks to see if the TableClassOverride property is set.
        /// </summary>
        internal bool IsSetTableClassOverride() => this.TableClassOverride != null;
    }
}
