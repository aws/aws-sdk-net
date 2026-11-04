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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// A list of node configurations.
    /// </summary>
    public partial class NodeConfigurationOption
    {
        /// <summary>
        /// Gets and sets the property EstimatedDiskUtilizationPercent. 
        /// <para>
        /// The estimated disk utilizaton percentage.
        /// </para>
        /// </summary>
        public double? EstimatedDiskUtilizationPercent { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedDiskUtilizationPercent property is set.
        /// </summary>
        internal bool IsSetEstimatedDiskUtilizationPercent() => this.EstimatedDiskUtilizationPercent.HasValue;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The category of the node configuration recommendation.
        /// </para>
        /// </summary>
        public Mode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The node type, such as, "ra3.4xlarge".
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string NodeType { get; set; }

        /// <summary>
        /// Checks to see if the NodeType property is set.
        /// </summary>
        internal bool IsSetNodeType() => this.NodeType != null;

        /// <summary>
        /// Gets and sets the property NumberOfNodes. 
        /// <para>
        /// The number of nodes.
        /// </para>
        /// </summary>
        public int? NumberOfNodes { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfNodes property is set.
        /// </summary>
        internal bool IsSetNumberOfNodes() => this.NumberOfNodes.HasValue;
    }
}
