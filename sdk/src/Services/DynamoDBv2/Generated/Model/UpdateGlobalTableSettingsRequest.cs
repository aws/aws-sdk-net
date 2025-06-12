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
    /// Container for the parameters to the UpdateGlobalTableSettings operation.
    /// Updates settings for a global table.
    /// 
    ///  <important> 
    /// <para>
    /// This documentation is for version 2017.11.29 (Legacy) of global tables, which should
    /// be avoided for new global tables. Customers should use <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/GlobalTables.html">Global
    /// Tables version 2019.11.21 (Current)</a> when possible, because it provides greater
    /// flexibility, higher efficiency, and consumes less write capacity than 2017.11.29 (Legacy).
    /// </para>
    ///  
    /// <para>
    /// To determine which version you're using, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/globaltables.DetermineVersion.html">Determining
    /// the global table version you are using</a>. To update existing global tables from
    /// version 2017.11.29 (Legacy) to version 2019.11.21 (Current), see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/V2globaltables_upgrade.html">Upgrading
    /// global tables</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UpdateGlobalTableSettingsRequest : AmazonDynamoDBRequest
    {
        private BillingMode _globalTableBillingMode;
        private List<GlobalTableGlobalSecondaryIndexSettingsUpdate> _globalTableGlobalSecondaryIndexSettingsUpdate = AWSConfigs.InitializeCollections ? new List<GlobalTableGlobalSecondaryIndexSettingsUpdate>() : null;
        private string _globalTableName;
        private AutoScalingSettingsUpdate _globalTableProvisionedWriteCapacityAutoScalingSettingsUpdate;
        private long? _globalTableProvisionedWriteCapacityUnits;
        private List<ReplicaSettingsUpdate> _replicaSettingsUpdate = AWSConfigs.InitializeCollections ? new List<ReplicaSettingsUpdate>() : null;

        /// <summary>
        /// Gets and sets the property GlobalTableBillingMode. 
        /// <para>
        /// The billing mode of the global table. If <c>GlobalTableBillingMode</c> is not specified,
        /// the global table defaults to <c>PROVISIONED</c> capacity billing mode.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PROVISIONED</c> - We recommend using <c>PROVISIONED</c> for predictable workloads.
        /// <c>PROVISIONED</c> sets the billing mode to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/provisioned-capacity-mode.html">Provisioned
        /// capacity mode</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PAY_PER_REQUEST</c> - We recommend using <c>PAY_PER_REQUEST</c> for unpredictable
        /// workloads. <c>PAY_PER_REQUEST</c> sets the billing mode to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/on-demand-capacity-mode.html">On-demand
        /// capacity mode</a>. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BillingMode GlobalTableBillingMode
        {
            get { return this._globalTableBillingMode; }
            set { this._globalTableBillingMode = value; }
        }

        // Check to see if GlobalTableBillingMode property is set
        internal bool IsSetGlobalTableBillingMode()
        {
            return this._globalTableBillingMode != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalTableGlobalSecondaryIndexSettingsUpdate. 
        /// <para>
        /// Represents the settings of a global secondary index for a global table that will be
        /// modified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<GlobalTableGlobalSecondaryIndexSettingsUpdate> GlobalTableGlobalSecondaryIndexSettingsUpdate
        {
            get { return this._globalTableGlobalSecondaryIndexSettingsUpdate; }
            set { this._globalTableGlobalSecondaryIndexSettingsUpdate = value; }
        }

        // Check to see if GlobalTableGlobalSecondaryIndexSettingsUpdate property is set
        internal bool IsSetGlobalTableGlobalSecondaryIndexSettingsUpdate()
        {
            return this._globalTableGlobalSecondaryIndexSettingsUpdate != null && (this._globalTableGlobalSecondaryIndexSettingsUpdate.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GlobalTableName. 
        /// <para>
        /// The name of the global table
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
        public string GlobalTableName
        {
            get { return this._globalTableName; }
            set { this._globalTableName = value; }
        }

        // Check to see if GlobalTableName property is set
        internal bool IsSetGlobalTableName()
        {
            return this._globalTableName != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalTableProvisionedWriteCapacityAutoScalingSettingsUpdate.
        /// 
        /// <para>
        /// Auto scaling settings for managing provisioned write capacity for the global table.
        /// </para>
        /// </summary>
        public AutoScalingSettingsUpdate GlobalTableProvisionedWriteCapacityAutoScalingSettingsUpdate
        {
            get { return this._globalTableProvisionedWriteCapacityAutoScalingSettingsUpdate; }
            set { this._globalTableProvisionedWriteCapacityAutoScalingSettingsUpdate = value; }
        }

        // Check to see if GlobalTableProvisionedWriteCapacityAutoScalingSettingsUpdate property is set
        internal bool IsSetGlobalTableProvisionedWriteCapacityAutoScalingSettingsUpdate()
        {
            return this._globalTableProvisionedWriteCapacityAutoScalingSettingsUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalTableProvisionedWriteCapacityUnits. 
        /// <para>
        /// The maximum number of writes consumed per second before DynamoDB returns a <c>ThrottlingException.</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? GlobalTableProvisionedWriteCapacityUnits
        {
            get { return this._globalTableProvisionedWriteCapacityUnits; }
            set { this._globalTableProvisionedWriteCapacityUnits = value; }
        }

        // Check to see if GlobalTableProvisionedWriteCapacityUnits property is set
        internal bool IsSetGlobalTableProvisionedWriteCapacityUnits()
        {
            return this._globalTableProvisionedWriteCapacityUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicaSettingsUpdate. 
        /// <para>
        /// Represents the settings for a global table in a Region that will be modified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<ReplicaSettingsUpdate> ReplicaSettingsUpdate
        {
            get { return this._replicaSettingsUpdate; }
            set { this._replicaSettingsUpdate = value; }
        }

        // Check to see if ReplicaSettingsUpdate property is set
        internal bool IsSetReplicaSettingsUpdate()
        {
            return this._replicaSettingsUpdate != null && (this._replicaSettingsUpdate.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}