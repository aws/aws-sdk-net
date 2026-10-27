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
    /// Container for the parameters to the UpdateGlobalTableSettings operation. Updates settings
    /// for a global table. <important> <para> This documentation is for version 2017.11.29
    /// (Legacy) of global tables, which should be avoided for new global tables. Customers
    /// should use <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/GlobalTables.html">Global
    /// Tables version 2019.11.21 (Current)</a> when possible, because it provides greater
    /// flexibility, higher efficiency, and consumes less write capacity than 2017.11.29 (Legacy).
    /// </para> <para> To determine which version you're using, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/globaltables.DetermineVersion.html">Determining
    /// the global table version you are using</a>. To update existing global tables from
    /// version 2017.11.29 (Legacy) to version 2019.11.21 (Current), see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/V2globaltables_upgrade.html">Upgrading
    /// global tables</a>. </para> </important>
    /// </summary>
    public partial class UpdateGlobalTableSettingsRequest : AmazonDynamoDBRequest
    {
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
        public BillingMode GlobalTableBillingMode { get; set; }

        /// <summary>
        /// Checks to see if the GlobalTableBillingMode property is set.
        /// </summary>
        internal bool IsSetGlobalTableBillingMode() => this.GlobalTableBillingMode != null;

        /// <summary>
        /// Gets and sets the property GlobalTableGlobalSecondaryIndexSettingsUpdate. 
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
        public List<GlobalTableGlobalSecondaryIndexSettingsUpdate> GlobalTableGlobalSecondaryIndexSettingsUpdate { get; set; } = AWSConfigs.InitializeCollections ? new List<GlobalTableGlobalSecondaryIndexSettingsUpdate>() : null;

        /// <summary>
        /// Checks to see if the GlobalTableGlobalSecondaryIndexSettingsUpdate property is set.
        /// </summary>
        internal bool IsSetGlobalTableGlobalSecondaryIndexSettingsUpdate() => this.GlobalTableGlobalSecondaryIndexSettingsUpdate != null && (this.GlobalTableGlobalSecondaryIndexSettingsUpdate.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GlobalTableName. 
        /// <para>
        /// The name of the global table
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 255)]
        public string GlobalTableName { get; set; }

        /// <summary>
        /// Checks to see if the GlobalTableName property is set.
        /// </summary>
        internal bool IsSetGlobalTableName() => this.GlobalTableName != null;

        /// <summary>
        /// Gets and sets the property GlobalTableProvisionedWriteCapacityAutoScalingSettingsUpdate.
        /// 
        /// <para>
        /// Auto scaling settings for managing provisioned write capacity for the global table.
        /// </para>
        /// </summary>
        public AutoScalingSettingsUpdate GlobalTableProvisionedWriteCapacityAutoScalingSettingsUpdate { get; set; }

        /// <summary>
        /// Checks to see if the GlobalTableProvisionedWriteCapacityAutoScalingSettingsUpdate property is set.
        /// </summary>
        internal bool IsSetGlobalTableProvisionedWriteCapacityAutoScalingSettingsUpdate() => this.GlobalTableProvisionedWriteCapacityAutoScalingSettingsUpdate != null;

        /// <summary>
        /// Gets and sets the property GlobalTableProvisionedWriteCapacityUnits. 
        /// <para>
        /// The maximum number of writes consumed per second before DynamoDB returns a <c>ThrottlingException.</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? GlobalTableProvisionedWriteCapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the GlobalTableProvisionedWriteCapacityUnits property is set.
        /// </summary>
        internal bool IsSetGlobalTableProvisionedWriteCapacityUnits() => this.GlobalTableProvisionedWriteCapacityUnits.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicaSettingsUpdate. 
        /// <para>
        /// Represents the settings for a global table in a Region that will be modified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<ReplicaSettingsUpdate> ReplicaSettingsUpdate { get; set; } = AWSConfigs.InitializeCollections ? new List<ReplicaSettingsUpdate>() : null;

        /// <summary>
        /// Checks to see if the ReplicaSettingsUpdate property is set.
        /// </summary>
        internal bool IsSetReplicaSettingsUpdate() => this.ReplicaSettingsUpdate != null && (this.ReplicaSettingsUpdate.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
