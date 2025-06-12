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
    /// Represents a replica to be modified.
    /// </summary>
    public partial class UpdateReplicationGroupMemberAction
    {
        private List<ReplicaGlobalSecondaryIndex> _globalSecondaryIndexes = AWSConfigs.InitializeCollections ? new List<ReplicaGlobalSecondaryIndex>() : null;
        private string _kmsMasterKeyId;
        private OnDemandThroughputOverride _onDemandThroughputOverride;
        private ProvisionedThroughputOverride _provisionedThroughputOverride;
        private string _regionName;
        private TableClass _tableClassOverride;

        /// <summary>
        /// Gets and sets the property GlobalSecondaryIndexes. 
        /// <para>
        /// Replica-specific global secondary index settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<ReplicaGlobalSecondaryIndex> GlobalSecondaryIndexes
        {
            get { return this._globalSecondaryIndexes; }
            set { this._globalSecondaryIndexes = value; }
        }

        // Check to see if GlobalSecondaryIndexes property is set
        internal bool IsSetGlobalSecondaryIndexes()
        {
            return this._globalSecondaryIndexes != null && (this._globalSecondaryIndexes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KMSMasterKeyId. 
        /// <para>
        /// The KMS key of the replica that should be used for KMS encryption. To specify a key,
        /// use its key ID, Amazon Resource Name (ARN), alias name, or alias ARN. Note that you
        /// should only provide this parameter if the key is different from the default DynamoDB
        /// KMS key <c>alias/aws/dynamodb</c>.
        /// </para>
        /// </summary>
        public string KMSMasterKeyId
        {
            get { return this._kmsMasterKeyId; }
            set { this._kmsMasterKeyId = value; }
        }

        // Check to see if KMSMasterKeyId property is set
        internal bool IsSetKMSMasterKeyId()
        {
            return this._kmsMasterKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property OnDemandThroughputOverride. 
        /// <para>
        /// Overrides the maximum on-demand throughput for the replica table.
        /// </para>
        /// </summary>
        public OnDemandThroughputOverride OnDemandThroughputOverride
        {
            get { return this._onDemandThroughputOverride; }
            set { this._onDemandThroughputOverride = value; }
        }

        // Check to see if OnDemandThroughputOverride property is set
        internal bool IsSetOnDemandThroughputOverride()
        {
            return this._onDemandThroughputOverride != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedThroughputOverride. 
        /// <para>
        /// Replica-specific provisioned throughput. If not specified, uses the source table's
        /// provisioned throughput settings.
        /// </para>
        /// </summary>
        public ProvisionedThroughputOverride ProvisionedThroughputOverride
        {
            get { return this._provisionedThroughputOverride; }
            set { this._provisionedThroughputOverride = value; }
        }

        // Check to see if ProvisionedThroughputOverride property is set
        internal bool IsSetProvisionedThroughputOverride()
        {
            return this._provisionedThroughputOverride != null;
        }

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
        /// Gets and sets the property TableClassOverride. 
        /// <para>
        /// Replica-specific table class. If not specified, uses the source table's table class.
        /// </para>
        /// </summary>
        public TableClass TableClassOverride
        {
            get { return this._tableClassOverride; }
            set { this._tableClassOverride = value; }
        }

        // Check to see if TableClassOverride property is set
        internal bool IsSetTableClassOverride()
        {
            return this._tableClassOverride != null;
        }

    }
}