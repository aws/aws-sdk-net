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
    /// This is the top-level field for specifying vertex or edge filters. If the ExportFilter
    /// is not provided, then all properties for all labels will be exported. If the ExportFilter
    /// is provided but is an empty object, then no data will be exported.
    /// </summary>
    public partial class ExportFilter
    {
        private Dictionary<string, ExportFilterElement> _edgeFilter = AWSConfigs.InitializeCollections ? new Dictionary<string, ExportFilterElement>() : null;
        private Dictionary<string, ExportFilterElement> _vertexFilter = AWSConfigs.InitializeCollections ? new Dictionary<string, ExportFilterElement>() : null;

        /// <summary>
        /// Gets and sets the property EdgeFilter. 
        /// <para>
        /// Used to specify filters on a per-label basis for edges. This allows you to control
        /// which edge labels and properties are included in the export.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ExportFilterElement> EdgeFilter
        {
            get { return this._edgeFilter; }
            set { this._edgeFilter = value; }
        }

        // Check to see if EdgeFilter property is set
        internal bool IsSetEdgeFilter()
        {
            return this._edgeFilter != null && (this._edgeFilter.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VertexFilter. 
        /// <para>
        /// Used to specify filters on a per-label basis for vertices. This allows you to control
        /// which vertex labels and properties are included in the export.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ExportFilterElement> VertexFilter
        {
            get { return this._vertexFilter; }
            set { this._vertexFilter = value; }
        }

        // Check to see if VertexFilter property is set
        internal bool IsSetVertexFilter()
        {
            return this._vertexFilter != null && (this._vertexFilter.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}