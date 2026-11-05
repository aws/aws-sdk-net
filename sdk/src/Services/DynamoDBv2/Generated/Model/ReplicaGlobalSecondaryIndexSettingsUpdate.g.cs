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
    /// Represents the settings of a global secondary index for a global table that will be
    /// modified.
    /// </summary>
    public partial class ReplicaGlobalSecondaryIndexSettingsUpdate
    {
        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the global secondary index. The name must be unique among all other indexes
        /// on this table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 255)]
        public string IndexName { get; set; }

        /// <summary>
        /// Checks to see if the IndexName property is set.
        /// </summary>
        internal bool IsSetIndexName() => this.IndexName != null;

        /// <summary>
        /// Gets and sets the property ProvisionedReadCapacityAutoScalingSettingsUpdate. 
        /// <para>
        /// Auto scaling settings for managing a global secondary index replica's read capacity
        /// units.
        /// </para>
        /// </summary>
        public AutoScalingSettingsUpdate ProvisionedReadCapacityAutoScalingSettingsUpdate { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedReadCapacityAutoScalingSettingsUpdate property is set.
        /// </summary>
        internal bool IsSetProvisionedReadCapacityAutoScalingSettingsUpdate() => this.ProvisionedReadCapacityAutoScalingSettingsUpdate != null;

        /// <summary>
        /// Gets and sets the property ProvisionedReadCapacityUnits. 
        /// <para>
        /// The maximum number of strongly consistent reads consumed per second before DynamoDB
        /// returns a <c>ThrottlingException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? ProvisionedReadCapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedReadCapacityUnits property is set.
        /// </summary>
        internal bool IsSetProvisionedReadCapacityUnits() => this.ProvisionedReadCapacityUnits.HasValue;
    }
}
