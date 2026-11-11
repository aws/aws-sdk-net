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
    /// Contains the details of the replica.
    /// </summary>
    public partial class ReplicaDescription
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
        public List<ReplicaGlobalSecondaryIndexDescription> GlobalSecondaryIndexes { get; set; } = AWSConfigs.InitializeCollections ? new List<ReplicaGlobalSecondaryIndexDescription>() : null;

        /// <summary>
        /// Checks to see if the GlobalSecondaryIndexes property is set.
        /// </summary>
        internal bool IsSetGlobalSecondaryIndexes() => this.GlobalSecondaryIndexes != null && (this.GlobalSecondaryIndexes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GlobalTableSettingsReplicationMode. 
        /// <para>
        /// Indicates one of the settings synchronization modes for the global table replica:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED</c>: Indicates that the settings synchronization mode for the global table
        /// replica is enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c>: Indicates that the settings synchronization mode for the global
        /// table replica is disabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENABLED_WITH_OVERRIDES</c>: This mode is set by default for a same account global
        /// table. Indicates that certain global table settings can be overridden.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public GlobalTableSettingsReplicationMode GlobalTableSettingsReplicationMode { get; set; }

        /// <summary>
        /// Checks to see if the GlobalTableSettingsReplicationMode property is set.
        /// </summary>
        internal bool IsSetGlobalTableSettingsReplicationMode() => this.GlobalTableSettingsReplicationMode != null;

        /// <summary>
        /// Gets and sets the property KMSMasterKeyId. 
        /// <para>
        /// The KMS key of the replica that will be used for KMS encryption.
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
        /// Overrides the maximum on-demand throughput settings for the specified replica table.
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
        /// Replica-specific provisioned throughput. If not described, uses the source table's
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
        /// The name of the Region.
        /// </para>
        /// </summary>
        public string RegionName { get; set; }

        /// <summary>
        /// Checks to see if the RegionName property is set.
        /// </summary>
        internal bool IsSetRegionName() => this.RegionName != null;

        /// <summary>
        /// Gets and sets the property ReplicaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the global table replica.
        /// </para>
        /// </summary>
        public string ReplicaArn { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaArn property is set.
        /// </summary>
        internal bool IsSetReplicaArn() => this.ReplicaArn != null;

        /// <summary>
        /// Gets and sets the property ReplicaInaccessibleDateTime. 
        /// <para>
        /// The time at which the replica was first detected as inaccessible. To determine cause
        /// of inaccessibility check the <c>ReplicaStatus</c> property.
        /// </para>
        /// </summary>
        public DateTime? ReplicaInaccessibleDateTime { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaInaccessibleDateTime property is set.
        /// </summary>
        internal bool IsSetReplicaInaccessibleDateTime() => this.ReplicaInaccessibleDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicaStatus. 
        /// <para>
        /// The current state of the replica:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> - The replica is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> - The replica is being updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> - The replica is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - The replica is ready for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REGION_DISABLED</c> - The replica is inaccessible because the Amazon Web Services
        /// Region has been disabled.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the Amazon Web Services Region remains inaccessible for more than 20 hours, DynamoDB
        /// will remove this replica from the replication group. The replica will not be deleted
        /// and replication will stop from and to this region.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <c>INACCESSIBLE_ENCRYPTION_CREDENTIALS </c> - The KMS key used to encrypt the table
        /// is inaccessible.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the KMS key remains inaccessible for more than 20 hours, DynamoDB will remove this
        /// replica from the replication group. The replica will not be deleted and replication
        /// will stop from and to this region.
        /// </para>
        ///  </note> </li> </ul>
        /// </summary>
        public ReplicaStatus ReplicaStatus { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaStatus property is set.
        /// </summary>
        internal bool IsSetReplicaStatus() => this.ReplicaStatus != null;

        /// <summary>
        /// Gets and sets the property ReplicaStatusDescription. 
        /// <para>
        /// Detailed information about the replica status.
        /// </para>
        /// </summary>
        public string ReplicaStatusDescription { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaStatusDescription property is set.
        /// </summary>
        internal bool IsSetReplicaStatusDescription() => this.ReplicaStatusDescription != null;

        /// <summary>
        /// Gets and sets the property ReplicaStatusPercentProgress. 
        /// <para>
        /// Specifies the progress of a Create, Update, or Delete action on the replica as a percentage.
        /// </para>
        /// </summary>
        public string ReplicaStatusPercentProgress { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaStatusPercentProgress property is set.
        /// </summary>
        internal bool IsSetReplicaStatusPercentProgress() => this.ReplicaStatusPercentProgress != null;

        /// <summary>
        /// Gets and sets the property ReplicaTableClassSummary.
        /// </summary>
        public TableClassSummary ReplicaTableClassSummary { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaTableClassSummary property is set.
        /// </summary>
        internal bool IsSetReplicaTableClassSummary() => this.ReplicaTableClassSummary != null;

        /// <summary>
        /// Gets and sets the property WarmThroughput. 
        /// <para>
        /// Represents the warm throughput value for this replica.
        /// </para>
        /// </summary>
        public TableWarmThroughputDescription WarmThroughput { get; set; }

        /// <summary>
        /// Checks to see if the WarmThroughput property is set.
        /// </summary>
        internal bool IsSetWarmThroughput() => this.WarmThroughput != null;
    }
}
