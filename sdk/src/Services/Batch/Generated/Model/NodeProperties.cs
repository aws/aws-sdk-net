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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object that represents the node properties of a multi-node parallel job.
    /// 
    ///  <note> 
    /// <para>
    /// Node properties can't be specified for Amazon EKS based job definitions.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class NodeProperties
    {
        private int? _mainNode;
        private List<NodeRangeProperty> _nodeRangeProperties = AWSConfigs.InitializeCollections ? new List<NodeRangeProperty>() : null;
        private int? _numNodes;

        /// <summary>
        /// Gets and sets the property MainNode. 
        /// <para>
        /// Specifies the node index for the main node of a multi-node parallel job. This node
        /// index value must be fewer than the number of nodes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? MainNode
        {
            get { return this._mainNode; }
            set { this._mainNode = value; }
        }

        // Check to see if MainNode property is set
        internal bool IsSetMainNode()
        {
            return this._mainNode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NodeRangeProperties. 
        /// <para>
        /// A list of node ranges and their properties that are associated with a multi-node parallel
        /// job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<NodeRangeProperty> NodeRangeProperties
        {
            get { return this._nodeRangeProperties; }
            set { this._nodeRangeProperties = value; }
        }

        // Check to see if NodeRangeProperties property is set
        internal bool IsSetNodeRangeProperties()
        {
            return this._nodeRangeProperties != null && (this._nodeRangeProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NumNodes. 
        /// <para>
        /// The number of nodes that are associated with a multi-node parallel job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? NumNodes
        {
            get { return this._numNodes; }
            set { this._numNodes = value; }
        }

        // Check to see if NumNodes property is set
        internal bool IsSetNumNodes()
        {
            return this._numNodes.HasValue; 
        }

    }
}