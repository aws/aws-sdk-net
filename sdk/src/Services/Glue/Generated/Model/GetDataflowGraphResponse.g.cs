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
    /// This is the response object from the GetDataflowGraph operation.
    /// </summary>
    public partial class GetDataflowGraphResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DagEdges. 
        /// <para>
        /// A list of the edges in the resulting DAG.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CodeGenEdge> DagEdges { get; set; } = AWSConfigs.InitializeCollections ? new List<CodeGenEdge>() : null;

        /// <summary>
        /// Checks to see if the DagEdges property is set.
        /// </summary>
        internal bool IsSetDagEdges() => this.DagEdges != null && (this.DagEdges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DagNodes. 
        /// <para>
        /// A list of the nodes in the resulting DAG.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CodeGenNode> DagNodes { get; set; } = AWSConfigs.InitializeCollections ? new List<CodeGenNode>() : null;

        /// <summary>
        /// Checks to see if the DagNodes property is set.
        /// </summary>
        internal bool IsSetDagNodes() => this.DagNodes != null && (this.DagNodes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
