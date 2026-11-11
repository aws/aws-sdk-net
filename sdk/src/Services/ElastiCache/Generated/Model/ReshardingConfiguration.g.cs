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
    /// A list of <c>PreferredAvailabilityZones</c> objects that specifies the configuration
    /// of a node group in the resharded cluster.
    /// </summary>
    public partial class ReshardingConfiguration
    {
        /// <summary>
        /// Gets and sets the property NodeGroupId. 
        /// <para>
        /// Either the ElastiCache supplied 4-digit id or a user supplied id for the node group
        /// these configuration values apply to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// Checks to see if the NodeGroupId property is set.
        /// </summary>
        internal bool IsSetNodeGroupId() => this.NodeGroupId != null;

        /// <summary>
        /// Gets and sets the property PreferredAvailabilityZones. 
        /// <para>
        /// A list of preferred availability zones for the nodes in this cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PreferredAvailabilityZones { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PreferredAvailabilityZones property is set.
        /// </summary>
        internal bool IsSetPreferredAvailabilityZones() => this.PreferredAvailabilityZones != null && (this.PreferredAvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
