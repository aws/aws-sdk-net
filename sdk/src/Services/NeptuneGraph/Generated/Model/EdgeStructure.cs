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

namespace Amazon.NeptuneGraph.Model
{
    /// <summary>
    /// Contains information about an edge in a Neptune Analytics graph.
    /// </summary>
    public partial class EdgeStructure
    {
        private long? _count;
        private List<string> _edgeProperties = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of instances of the edge in the graph.
        /// </para>
        /// </summary>
        public long Count
        {
            get { return this._count.GetValueOrDefault(); }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EdgeProperties. 
        /// <para>
        /// A list of the properties associated with the edge.
        /// </para>
        /// </summary>
        public List<string> EdgeProperties
        {
            get { return this._edgeProperties; }
            set { this._edgeProperties = value; }
        }

        // Check to see if EdgeProperties property is set
        internal bool IsSetEdgeProperties()
        {
            return this._edgeProperties != null && (this._edgeProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}