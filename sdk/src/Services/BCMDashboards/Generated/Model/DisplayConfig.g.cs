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

namespace Amazon.BCMDashboards.Model
{
    /// <summary>
    /// Defines how the widget's data should be visualized, including chart type, color schemes,
    /// axis configurations, and other display preferences.
    /// </summary>
    public partial class DisplayConfig
    {
        /// <summary>
        /// Gets and sets the property Graph. 
        /// <para>
        /// The configuration for graphical display of the widget data, including chart type and
        /// visual options.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, GraphDisplayConfig> Graph { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, GraphDisplayConfig>() : null;

        /// <summary>
        /// Checks to see if the Graph property is set.
        /// </summary>
        internal bool IsSetGraph() => this.Graph != null && (this.Graph.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Table. 
        /// <para>
        /// The configuration for tabular display of the widget data.
        /// </para>
        /// </summary>
        public TableDisplayConfigStruct Table { get; set; }

        /// <summary>
        /// Checks to see if the Table property is set.
        /// </summary>
        internal bool IsSetTable() => this.Table != null;
    }
}
