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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The properties for a single geospatial layer.
    /// </summary>
    public partial class GeospatialLayerItem
    {
        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// A list of custom actions for a layer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<LayerCustomAction> Actions { get; set; } = AWSConfigs.InitializeCollections ? new List<LayerCustomAction>() : null;

        /// <summary>
        /// Checks to see if the Actions property is set.
        /// </summary>
        internal bool IsSetActions() => this.Actions != null && (this.Actions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The data source for the layer.
        /// </para>
        /// </summary>
        public GeospatialDataSourceItem DataSource { get; set; }

        /// <summary>
        /// Checks to see if the DataSource property is set.
        /// </summary>
        internal bool IsSetDataSource() => this.DataSource != null;

        /// <summary>
        /// Gets and sets the property JoinDefinition. 
        /// <para>
        /// The join definition properties for a layer.
        /// </para>
        /// </summary>
        public GeospatialLayerJoinDefinition JoinDefinition { get; set; }

        /// <summary>
        /// Checks to see if the JoinDefinition property is set.
        /// </summary>
        internal bool IsSetJoinDefinition() => this.JoinDefinition != null;

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The label that is displayed for the layer.
        /// </para>
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Checks to see if the Label property is set.
        /// </summary>
        internal bool IsSetLabel() => this.Label != null;

        /// <summary>
        /// Gets and sets the property LayerDefinition. 
        /// <para>
        /// The definition properties for a layer.
        /// </para>
        /// </summary>
        public GeospatialLayerDefinition LayerDefinition { get; set; }

        /// <summary>
        /// Checks to see if the LayerDefinition property is set.
        /// </summary>
        internal bool IsSetLayerDefinition() => this.LayerDefinition != null;

        /// <summary>
        /// Gets and sets the property LayerId. 
        /// <para>
        /// The ID of the layer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LayerId { get; set; }

        /// <summary>
        /// Checks to see if the LayerId property is set.
        /// </summary>
        internal bool IsSetLayerId() => this.LayerId != null;

        /// <summary>
        /// Gets and sets the property LayerType. 
        /// <para>
        /// The layer type.
        /// </para>
        /// </summary>
        public GeospatialLayerType LayerType { get; set; }

        /// <summary>
        /// Checks to see if the LayerType property is set.
        /// </summary>
        internal bool IsSetLayerType() => this.LayerType != null;

        /// <summary>
        /// Gets and sets the property Tooltip.
        /// </summary>
        public TooltipOptions Tooltip { get; set; }

        /// <summary>
        /// Checks to see if the Tooltip property is set.
        /// </summary>
        internal bool IsSetTooltip() => this.Tooltip != null;

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The state of visibility for the layer.
        /// </para>
        /// </summary>
        public Visibility Visibility { get; set; }

        /// <summary>
        /// Checks to see if the Visibility property is set.
        /// </summary>
        internal bool IsSetVisibility() => this.Visibility != null;
    }
}
