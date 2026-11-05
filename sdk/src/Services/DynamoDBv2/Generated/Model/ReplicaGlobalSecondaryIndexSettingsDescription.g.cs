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
    /// Represents the properties of a global secondary index.
    /// </summary>
    public partial class ReplicaGlobalSecondaryIndexSettingsDescription
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
        /// Gets and sets the property IndexStatus. 
        /// <para>
        ///  The current status of the global secondary index:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> - The global secondary index is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> - The global secondary index is being updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> - The global secondary index is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - The global secondary index is ready for use.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IndexStatus IndexStatus { get; set; }

        /// <summary>
        /// Checks to see if the IndexStatus property is set.
        /// </summary>
        internal bool IsSetIndexStatus() => this.IndexStatus != null;

        /// <summary>
        /// Gets and sets the property ProvisionedReadCapacityAutoScalingSettings. 
        /// <para>
        /// Auto scaling settings for a global secondary index replica's read capacity units.
        /// </para>
        /// </summary>
        public AutoScalingSettingsDescription ProvisionedReadCapacityAutoScalingSettings { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedReadCapacityAutoScalingSettings property is set.
        /// </summary>
        internal bool IsSetProvisionedReadCapacityAutoScalingSettings() => this.ProvisionedReadCapacityAutoScalingSettings != null;

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

        /// <summary>
        /// Gets and sets the property ProvisionedWriteCapacityAutoScalingSettings. 
        /// <para>
        /// Auto scaling settings for a global secondary index replica's write capacity units.
        /// </para>
        /// </summary>
        public AutoScalingSettingsDescription ProvisionedWriteCapacityAutoScalingSettings { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedWriteCapacityAutoScalingSettings property is set.
        /// </summary>
        internal bool IsSetProvisionedWriteCapacityAutoScalingSettings() => this.ProvisionedWriteCapacityAutoScalingSettings != null;

        /// <summary>
        /// Gets and sets the property ProvisionedWriteCapacityUnits. 
        /// <para>
        /// The maximum number of writes consumed per second before DynamoDB returns a <c>ThrottlingException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? ProvisionedWriteCapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedWriteCapacityUnits property is set.
        /// </summary>
        internal bool IsSetProvisionedWriteCapacityUnits() => this.ProvisionedWriteCapacityUnits.HasValue;
    }
}
