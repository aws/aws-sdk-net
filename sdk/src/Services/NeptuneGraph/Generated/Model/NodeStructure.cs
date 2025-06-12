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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
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
namespace Amazon.NeptuneGraph.Model
{
    /// <summary>
    /// Information about a node.
    /// </summary>
    public partial class NodeStructure
    {
        private long? _count;
        private List<string> _distinctOutgoingEdgeLabels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _nodeProperties = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of instances of this node.
        /// </para>
        /// </summary>
        public long? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DistinctOutgoingEdgeLabels. 
        /// <para>
        /// The outgoing edge labels associated with this node.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DistinctOutgoingEdgeLabels
        {
            get { return this._distinctOutgoingEdgeLabels; }
            set { this._distinctOutgoingEdgeLabels = value; }
        }

        // Check to see if DistinctOutgoingEdgeLabels property is set
        internal bool IsSetDistinctOutgoingEdgeLabels()
        {
            return this._distinctOutgoingEdgeLabels != null && (this._distinctOutgoingEdgeLabels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NodeProperties. 
        /// <para>
        /// Properties associated with this node.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NodeProperties
        {
            get { return this._nodeProperties; }
            set { this._nodeProperties = value; }
        }

        // Check to see if NodeProperties property is set
        internal bool IsSetNodeProperties()
        {
            return this._nodeProperties != null && (this._nodeProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}