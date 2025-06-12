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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
    /// Represents the auto scaling settings of a replica that will be modified.
    /// </summary>
    public partial class ReplicaAutoScalingUpdate
    {
        private string _regionName;
        private List<ReplicaGlobalSecondaryIndexAutoScalingUpdate> _replicaGlobalSecondaryIndexUpdates = AWSConfigs.InitializeCollections ? new List<ReplicaGlobalSecondaryIndexAutoScalingUpdate>() : null;
        private AutoScalingSettingsUpdate _replicaProvisionedReadCapacityAutoScalingUpdate;

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The Region where the replica exists.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RegionName
        {
            get { return this._regionName; }
            set { this._regionName = value; }
        }

        // Check to see if RegionName property is set
        internal bool IsSetRegionName()
        {
            return this._regionName != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicaGlobalSecondaryIndexUpdates. 
        /// <para>
        /// Represents the auto scaling settings of global secondary indexes that will be modified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReplicaGlobalSecondaryIndexAutoScalingUpdate> ReplicaGlobalSecondaryIndexUpdates
        {
            get { return this._replicaGlobalSecondaryIndexUpdates; }
            set { this._replicaGlobalSecondaryIndexUpdates = value; }
        }

        // Check to see if ReplicaGlobalSecondaryIndexUpdates property is set
        internal bool IsSetReplicaGlobalSecondaryIndexUpdates()
        {
            return this._replicaGlobalSecondaryIndexUpdates != null && (this._replicaGlobalSecondaryIndexUpdates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReplicaProvisionedReadCapacityAutoScalingUpdate.
        /// </summary>
        public AutoScalingSettingsUpdate ReplicaProvisionedReadCapacityAutoScalingUpdate
        {
            get { return this._replicaProvisionedReadCapacityAutoScalingUpdate; }
            set { this._replicaProvisionedReadCapacityAutoScalingUpdate = value; }
        }

        // Check to see if ReplicaProvisionedReadCapacityAutoScalingUpdate property is set
        internal bool IsSetReplicaProvisionedReadCapacityAutoScalingUpdate()
        {
            return this._replicaProvisionedReadCapacityAutoScalingUpdate != null;
        }

    }
}