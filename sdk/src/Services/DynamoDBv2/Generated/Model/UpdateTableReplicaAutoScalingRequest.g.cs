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
    /// Container for the parameters to the UpdateTableReplicaAutoScaling operation. Updates
    /// auto scaling settings on your global tables at once.
    /// </summary>
    public partial class UpdateTableReplicaAutoScalingRequest : AmazonDynamoDBRequest
    {
        /// <summary>
        /// Gets and sets the property GlobalSecondaryIndexUpdates. 
        /// <para>
        /// Represents the auto scaling settings of the global secondary indexes of the replica
        /// to be updated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<GlobalSecondaryIndexAutoScalingUpdate> GlobalSecondaryIndexUpdates { get; set; } = AWSConfigs.InitializeCollections ? new List<GlobalSecondaryIndexAutoScalingUpdate>() : null;

        /// <summary>
        /// Checks to see if the GlobalSecondaryIndexUpdates property is set.
        /// </summary>
        internal bool IsSetGlobalSecondaryIndexUpdates() => this.GlobalSecondaryIndexUpdates != null && (this.GlobalSecondaryIndexUpdates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProvisionedWriteCapacityAutoScalingUpdate.
        /// </summary>
        public AutoScalingSettingsUpdate ProvisionedWriteCapacityAutoScalingUpdate { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedWriteCapacityAutoScalingUpdate property is set.
        /// </summary>
        internal bool IsSetProvisionedWriteCapacityAutoScalingUpdate() => this.ProvisionedWriteCapacityAutoScalingUpdate != null;

        /// <summary>
        /// Gets and sets the property ReplicaUpdates. 
        /// <para>
        /// Represents the auto scaling settings of replicas of the table that will be modified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<ReplicaAutoScalingUpdate> ReplicaUpdates { get; set; } = AWSConfigs.InitializeCollections ? new List<ReplicaAutoScalingUpdate>() : null;

        /// <summary>
        /// Checks to see if the ReplicaUpdates property is set.
        /// </summary>
        internal bool IsSetReplicaUpdates() => this.ReplicaUpdates != null && (this.ReplicaUpdates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the global table to be updated. You can also provide the Amazon Resource
        /// Name (ARN) of the table in this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;
    }
}
