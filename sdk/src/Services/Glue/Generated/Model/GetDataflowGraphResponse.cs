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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
        private List<CodeGenEdge> _dagEdges = AWSConfigs.InitializeCollections ? new List<CodeGenEdge>() : null;
        private List<CodeGenNode> _dagNodes = AWSConfigs.InitializeCollections ? new List<CodeGenNode>() : null;

        /// <summary>
        /// Gets and sets the property DagEdges. 
        /// <para>
        /// A list of the edges in the resulting DAG.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CodeGenEdge> DagEdges
        {
            get { return this._dagEdges; }
            set { this._dagEdges = value; }
        }

        // Check to see if DagEdges property is set
        internal bool IsSetDagEdges()
        {
            return this._dagEdges != null && (this._dagEdges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DagNodes. 
        /// <para>
        /// A list of the nodes in the resulting DAG.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CodeGenNode> DagNodes
        {
            get { return this._dagNodes; }
            set { this._dagNodes = value; }
        }

        // Check to see if DagNodes property is set
        internal bool IsSetDagNodes()
        {
            return this._dagNodes != null && (this._dagNodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}