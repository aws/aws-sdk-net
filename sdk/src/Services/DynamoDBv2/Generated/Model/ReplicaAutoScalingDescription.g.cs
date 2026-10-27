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
    /// Represents the auto scaling settings of the replica.
    /// </summary>
    public partial class ReplicaAutoScalingDescription
    {
        /// <summary>
        /// Gets and sets the property GlobalSecondaryIndexes. 
        /// <para>
        /// Replica-specific global secondary index auto scaling settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReplicaGlobalSecondaryIndexAutoScalingDescription> GlobalSecondaryIndexes { get; set; } = AWSConfigs.InitializeCollections ? new List<ReplicaGlobalSecondaryIndexAutoScalingDescription>() : null;

        /// <summary>
        /// Checks to see if the GlobalSecondaryIndexes property is set.
        /// </summary>
        internal bool IsSetGlobalSecondaryIndexes() => this.GlobalSecondaryIndexes != null && (this.GlobalSecondaryIndexes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The Region where the replica exists.
        /// </para>
        /// </summary>
        public string RegionName { get; set; }

        /// <summary>
        /// Checks to see if the RegionName property is set.
        /// </summary>
        internal bool IsSetRegionName() => this.RegionName != null;

        /// <summary>
        /// Gets and sets the property ReplicaProvisionedReadCapacityAutoScalingSettings.
        /// </summary>
        public AutoScalingSettingsDescription ReplicaProvisionedReadCapacityAutoScalingSettings { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaProvisionedReadCapacityAutoScalingSettings property is set.
        /// </summary>
        internal bool IsSetReplicaProvisionedReadCapacityAutoScalingSettings() => this.ReplicaProvisionedReadCapacityAutoScalingSettings != null;

        /// <summary>
        /// Gets and sets the property ReplicaProvisionedWriteCapacityAutoScalingSettings.
        /// </summary>
        public AutoScalingSettingsDescription ReplicaProvisionedWriteCapacityAutoScalingSettings { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaProvisionedWriteCapacityAutoScalingSettings property is set.
        /// </summary>
        internal bool IsSetReplicaProvisionedWriteCapacityAutoScalingSettings() => this.ReplicaProvisionedWriteCapacityAutoScalingSettings != null;

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
        ///  </li> </ul>
        /// </summary>
        public ReplicaStatus ReplicaStatus { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaStatus property is set.
        /// </summary>
        internal bool IsSetReplicaStatus() => this.ReplicaStatus != null;
    }
}
