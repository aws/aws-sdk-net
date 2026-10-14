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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The Slurm configuration for an instance group in a SageMaker HyperPod cluster.
    /// </summary>
    public partial class ClusterSlurmConfig
    {
        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The type of Slurm node for the instance group. Valid values are <c>Controller</c>,
        /// <c>Worker</c>, and <c>Login</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ClusterSlurmNodeType NodeType { get; set; }

        /// <summary>
        /// Checks to see if the NodeType property is set.
        /// </summary>
        internal bool IsSetNodeType() => this.NodeType != null;

        /// <summary>
        /// Gets and sets the property PartitionNames. 
        /// <para>
        /// The list of Slurm partition names that the instance group belongs to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1)]
        public List<string> PartitionNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PartitionNames property is set.
        /// </summary>
        internal bool IsSetPartitionNames() => this.PartitionNames != null && (this.PartitionNames.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
