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
    /// Represents the properties of a replica.
    /// </summary>
    public partial class ReplicaSettingsDescription
    {
        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The Region name of the replica.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RegionName { get; set; }

        /// <summary>
        /// Checks to see if the RegionName property is set.
        /// </summary>
        internal bool IsSetRegionName() => this.RegionName != null;

        /// <summary>
        /// Gets and sets the property ReplicaBillingModeSummary. 
        /// <para>
        /// The read/write capacity mode of the replica.
        /// </para>
        /// </summary>
        public BillingModeSummary ReplicaBillingModeSummary { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaBillingModeSummary property is set.
        /// </summary>
        internal bool IsSetReplicaBillingModeSummary() => this.ReplicaBillingModeSummary != null;

        /// <summary>
        /// Gets and sets the property ReplicaGlobalSecondaryIndexSettings. 
        /// <para>
        /// Replica global secondary index settings for the global table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReplicaGlobalSecondaryIndexSettingsDescription> ReplicaGlobalSecondaryIndexSettings { get; set; } = AWSConfigs.InitializeCollections ? new List<ReplicaGlobalSecondaryIndexSettingsDescription>() : null;

        /// <summary>
        /// Checks to see if the ReplicaGlobalSecondaryIndexSettings property is set.
        /// </summary>
        internal bool IsSetReplicaGlobalSecondaryIndexSettings() => this.ReplicaGlobalSecondaryIndexSettings != null && (this.ReplicaGlobalSecondaryIndexSettings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReplicaProvisionedReadCapacityAutoScalingSettings. 
        /// <para>
        /// Auto scaling settings for a global table replica's read capacity units.
        /// </para>
        /// </summary>
        public AutoScalingSettingsDescription ReplicaProvisionedReadCapacityAutoScalingSettings { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaProvisionedReadCapacityAutoScalingSettings property is set.
        /// </summary>
        internal bool IsSetReplicaProvisionedReadCapacityAutoScalingSettings() => this.ReplicaProvisionedReadCapacityAutoScalingSettings != null;

        /// <summary>
        /// Gets and sets the property ReplicaProvisionedReadCapacityUnits. 
        /// <para>
        /// The maximum number of strongly consistent reads consumed per second before DynamoDB
        /// returns a <c>ThrottlingException</c>. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithTables.html#ProvisionedThroughput">Specifying
        /// Read and Write Requirements</a> in the <i>Amazon DynamoDB Developer Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ReplicaProvisionedReadCapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaProvisionedReadCapacityUnits property is set.
        /// </summary>
        internal bool IsSetReplicaProvisionedReadCapacityUnits() => this.ReplicaProvisionedReadCapacityUnits.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicaProvisionedWriteCapacityAutoScalingSettings. 
        /// <para>
        /// Auto scaling settings for a global table replica's write capacity units.
        /// </para>
        /// </summary>
        public AutoScalingSettingsDescription ReplicaProvisionedWriteCapacityAutoScalingSettings { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaProvisionedWriteCapacityAutoScalingSettings property is set.
        /// </summary>
        internal bool IsSetReplicaProvisionedWriteCapacityAutoScalingSettings() => this.ReplicaProvisionedWriteCapacityAutoScalingSettings != null;

        /// <summary>
        /// Gets and sets the property ReplicaProvisionedWriteCapacityUnits. 
        /// <para>
        /// The maximum number of writes consumed per second before DynamoDB returns a <c>ThrottlingException</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithTables.html#ProvisionedThroughput">Specifying
        /// Read and Write Requirements</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ReplicaProvisionedWriteCapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaProvisionedWriteCapacityUnits property is set.
        /// </summary>
        internal bool IsSetReplicaProvisionedWriteCapacityUnits() => this.ReplicaProvisionedWriteCapacityUnits.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicaStatus. 
        /// <para>
        /// The current state of the Region:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> - The Region is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> - The Region is being updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> - The Region is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - The Region is ready for use.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ReplicaStatus ReplicaStatus { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaStatus property is set.
        /// </summary>
        internal bool IsSetReplicaStatus() => this.ReplicaStatus != null;

        /// <summary>
        /// Gets and sets the property ReplicaTableClassSummary.
        /// </summary>
        public TableClassSummary ReplicaTableClassSummary { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaTableClassSummary property is set.
        /// </summary>
        internal bool IsSetReplicaTableClassSummary() => this.ReplicaTableClassSummary != null;
    }
}
