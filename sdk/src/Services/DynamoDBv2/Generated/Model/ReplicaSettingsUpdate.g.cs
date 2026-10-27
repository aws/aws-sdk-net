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
    /// Represents the settings for a global table in a Region that will be modified.
    /// </summary>
    public partial class ReplicaSettingsUpdate
    {
        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The Region of the replica to be added.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RegionName { get; set; }

        /// <summary>
        /// Checks to see if the RegionName property is set.
        /// </summary>
        internal bool IsSetRegionName() => this.RegionName != null;

        /// <summary>
        /// Gets and sets the property ReplicaGlobalSecondaryIndexSettingsUpdate. 
        /// <para>
        /// Represents the settings of a global secondary index for a global table that will be
        /// modified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<ReplicaGlobalSecondaryIndexSettingsUpdate> ReplicaGlobalSecondaryIndexSettingsUpdate { get; set; } = AWSConfigs.InitializeCollections ? new List<ReplicaGlobalSecondaryIndexSettingsUpdate>() : null;

        /// <summary>
        /// Checks to see if the ReplicaGlobalSecondaryIndexSettingsUpdate property is set.
        /// </summary>
        internal bool IsSetReplicaGlobalSecondaryIndexSettingsUpdate() => this.ReplicaGlobalSecondaryIndexSettingsUpdate != null && (this.ReplicaGlobalSecondaryIndexSettingsUpdate.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReplicaProvisionedReadCapacityAutoScalingSettingsUpdate.
        /// 
        /// <para>
        /// Auto scaling settings for managing a global table replica's read capacity units.
        /// </para>
        /// </summary>
        public AutoScalingSettingsUpdate ReplicaProvisionedReadCapacityAutoScalingSettingsUpdate { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaProvisionedReadCapacityAutoScalingSettingsUpdate property is set.
        /// </summary>
        internal bool IsSetReplicaProvisionedReadCapacityAutoScalingSettingsUpdate() => this.ReplicaProvisionedReadCapacityAutoScalingSettingsUpdate != null;

        /// <summary>
        /// Gets and sets the property ReplicaProvisionedReadCapacityUnits. 
        /// <para>
        /// The maximum number of strongly consistent reads consumed per second before DynamoDB
        /// returns a <c>ThrottlingException</c>. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithTables.html#ProvisionedThroughput">Specifying
        /// Read and Write Requirements</a> in the <i>Amazon DynamoDB Developer Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? ReplicaProvisionedReadCapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaProvisionedReadCapacityUnits property is set.
        /// </summary>
        internal bool IsSetReplicaProvisionedReadCapacityUnits() => this.ReplicaProvisionedReadCapacityUnits.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicaTableClass. 
        /// <para>
        /// Replica-specific table class. If not specified, uses the source table's table class.
        /// </para>
        /// </summary>
        public TableClass ReplicaTableClass { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaTableClass property is set.
        /// </summary>
        internal bool IsSetReplicaTableClass() => this.ReplicaTableClass != null;
    }
}
