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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// A workflow graph represents the complete workflow containing all the Glue components
    /// present in the workflow and all the directed connections between them.
    /// </summary>
    public partial class WorkflowGraph
    {
        /// <summary>
        /// Gets and sets the property Edges. 
        /// <para>
        /// A list of all the directed connections between the nodes belonging to the workflow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Edge> Edges { get; set; } = AWSConfigs.InitializeCollections ? new List<Edge>() : null;

        /// <summary>
        /// Checks to see if the Edges property is set.
        /// </summary>
        internal bool IsSetEdges() => this.Edges != null && (this.Edges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Nodes. 
        /// <para>
        /// A list of the the Glue components belong to the workflow represented as nodes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Node> Nodes { get; set; } = AWSConfigs.InitializeCollections ? new List<Node>() : null;

        /// <summary>
        /// Checks to see if the Nodes property is set.
        /// </summary>
        internal bool IsSetNodes() => this.Nodes != null && (this.Nodes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
