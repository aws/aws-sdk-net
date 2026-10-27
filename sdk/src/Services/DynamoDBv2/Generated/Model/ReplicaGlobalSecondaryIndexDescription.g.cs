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
    /// Represents the properties of a replica global secondary index.
    /// </summary>
    public partial class ReplicaGlobalSecondaryIndexDescription
    {
        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the global secondary index.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string IndexName { get; set; }

        /// <summary>
        /// Checks to see if the IndexName property is set.
        /// </summary>
        internal bool IsSetIndexName() => this.IndexName != null;

        /// <summary>
        /// Gets and sets the property OnDemandThroughputOverride. 
        /// <para>
        /// Overrides the maximum on-demand throughput for the specified global secondary index
        /// in the specified replica table.
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
        /// If not described, uses the source table GSI's read capacity settings.
        /// </para>
        /// </summary>
        public ProvisionedThroughputOverride ProvisionedThroughputOverride { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedThroughputOverride property is set.
        /// </summary>
        internal bool IsSetProvisionedThroughputOverride() => this.ProvisionedThroughputOverride != null;

        /// <summary>
        /// Gets and sets the property WarmThroughput. 
        /// <para>
        /// Represents the warm throughput of the global secondary index for this replica.
        /// </para>
        /// </summary>
        public GlobalSecondaryIndexWarmThroughputDescription WarmThroughput { get; set; }

        /// <summary>
        /// Checks to see if the WarmThroughput property is set.
        /// </summary>
        internal bool IsSetWarmThroughput() => this.WarmThroughput != null;
    }
}
