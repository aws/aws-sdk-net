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
 * Do not modify this file. This file is generated from the bcm-dashboards-2025-08-18.normal.json service model.
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
namespace Amazon.BCMDashboards.Model
{
    /// <summary>
    /// Defines how the widget's data should be visualized, including chart type, color schemes,
    /// axis configurations, and other display preferences.
    /// </summary>
    public partial class DisplayConfig
    {
        private Dictionary<string, GraphDisplayConfig> _graph = AWSConfigs.InitializeCollections ? new Dictionary<string, GraphDisplayConfig>() : null;
        private TableDisplayConfigStruct _table;

        /// <summary>
        /// Gets and sets the property Graph. 
        /// <para>
        /// The configuration for graphical display of the widget data, including chart type and
        /// visual options.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, GraphDisplayConfig> Graph
        {
            get { return this._graph; }
            set { this._graph = value; }
        }

        // Check to see if Graph property is set
        internal bool IsSetGraph()
        {
            return this._graph != null && (this._graph.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Table. 
        /// <para>
        /// The configuration for tabular display of the widget data.
        /// </para>
        /// </summary>
        public TableDisplayConfigStruct Table
        {
            get { return this._table; }
            set { this._table = value; }
        }

        // Check to see if Table property is set
        internal bool IsSetTable()
        {
            return this._table != null;
        }

    }
}