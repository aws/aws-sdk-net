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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// A list of the replication groups
    /// </summary>
    public partial class RegionalConfiguration
    {
        /// <summary>
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// The name of the secondary cluster
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReplicationGroupId { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationGroupId property is set.
        /// </summary>
        internal bool IsSetReplicationGroupId() => this.ReplicationGroupId != null;

        /// <summary>
        /// Gets and sets the property ReplicationGroupRegion. 
        /// <para>
        /// The Amazon region where the cluster is stored
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReplicationGroupRegion { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationGroupRegion property is set.
        /// </summary>
        internal bool IsSetReplicationGroupRegion() => this.ReplicationGroupRegion != null;

        /// <summary>
        /// Gets and sets the property ReshardingConfiguration. 
        /// <para>
        /// A list of <c>PreferredAvailabilityZones</c> objects that specifies the configuration
        /// of a node group in the resharded cluster. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<ReshardingConfiguration> ReshardingConfiguration { get; set; } = AWSConfigs.InitializeCollections ? new List<ReshardingConfiguration>() : null;

        /// <summary>
        /// Checks to see if the ReshardingConfiguration property is set.
        /// </summary>
        internal bool IsSetReshardingConfiguration() => this.ReshardingConfiguration != null && (this.ReshardingConfiguration.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
