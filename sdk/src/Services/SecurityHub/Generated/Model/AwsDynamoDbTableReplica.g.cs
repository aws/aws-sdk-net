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
    /// Information about a replica of a DynamoDB table.
    /// </summary>
    public partial class AwsDynamoDbTableReplica
    {
        /// <summary>
        /// Gets and sets the property GlobalSecondaryIndexes. 
        /// <para>
        /// List of global secondary indexes for the replica.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsDynamoDbTableReplicaGlobalSecondaryIndex> GlobalSecondaryIndexes { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsDynamoDbTableReplicaGlobalSecondaryIndex>() : null;

        /// <summary>
        /// Checks to see if the GlobalSecondaryIndexes property is set.
        /// </summary>
        internal bool IsSetGlobalSecondaryIndexes() => this.GlobalSecondaryIndexes != null && (this.GlobalSecondaryIndexes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KmsMasterKeyId. 
        /// <para>
        /// The identifier of the KMS key that will be used for KMS encryption for the replica.
        /// </para>
        /// </summary>
        public string KmsMasterKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsMasterKeyId property is set.
        /// </summary>
        internal bool IsSetKmsMasterKeyId() => this.KmsMasterKeyId != null;

        /// <summary>
        /// Gets and sets the property ProvisionedThroughputOverride. 
        /// <para>
        /// Replica-specific configuration for the provisioned throughput.
        /// </para>
        /// </summary>
        public AwsDynamoDbTableProvisionedThroughputOverride ProvisionedThroughputOverride { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedThroughputOverride property is set.
        /// </summary>
        internal bool IsSetProvisionedThroughputOverride() => this.ProvisionedThroughputOverride != null;

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The name of the Region where the replica is located.
        /// </para>
        /// </summary>
        public string RegionName { get; set; }

        /// <summary>
        /// Checks to see if the RegionName property is set.
        /// </summary>
        internal bool IsSetRegionName() => this.RegionName != null;

        /// <summary>
        /// Gets and sets the property ReplicaStatus. 
        /// <para>
        /// The current status of the replica. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATING</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATION_FAILED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ReplicaStatus { get; set; }

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
    }
}
