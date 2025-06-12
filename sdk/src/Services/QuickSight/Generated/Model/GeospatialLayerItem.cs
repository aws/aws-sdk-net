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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
        private List<LayerCustomAction> _actions = AWSConfigs.InitializeCollections ? new List<LayerCustomAction>() : null;
        private GeospatialDataSourceItem _dataSource;
        private GeospatialLayerJoinDefinition _joinDefinition;
        private string _label;
        private GeospatialLayerDefinition _layerDefinition;
        private string _layerId;
        private GeospatialLayerType _layerType;
        private TooltipOptions _tooltip;
        private Visibility _visibility;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// A list of custom actions for a layer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=10)]
        public List<LayerCustomAction> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && (this._actions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The data source for the layer.
        /// </para>
        /// </summary>
        public GeospatialDataSourceItem DataSource
        {
            get { return this._dataSource; }
            set { this._dataSource = value; }
        }

        // Check to see if DataSource property is set
        internal bool IsSetDataSource()
        {
            return this._dataSource != null;
        }

        /// <summary>
        /// Gets and sets the property JoinDefinition. 
        /// <para>
        /// The join definition properties for a layer.
        /// </para>
        /// </summary>
        public GeospatialLayerJoinDefinition JoinDefinition
        {
            get { return this._joinDefinition; }
            set { this._joinDefinition = value; }
        }

        // Check to see if JoinDefinition property is set
        internal bool IsSetJoinDefinition()
        {
            return this._joinDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The label that is displayed for the layer.
        /// </para>
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

        /// <summary>
        /// Gets and sets the property LayerDefinition. 
        /// <para>
        /// The definition properties for a layer.
        /// </para>
        /// </summary>
        public GeospatialLayerDefinition LayerDefinition
        {
            get { return this._layerDefinition; }
            set { this._layerDefinition = value; }
        }

        // Check to see if LayerDefinition property is set
        internal bool IsSetLayerDefinition()
        {
            return this._layerDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property LayerId. 
        /// <para>
        /// The ID of the layer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LayerId
        {
            get { return this._layerId; }
            set { this._layerId = value; }
        }

        // Check to see if LayerId property is set
        internal bool IsSetLayerId()
        {
            return this._layerId != null;
        }

        /// <summary>
        /// Gets and sets the property LayerType. 
        /// <para>
        /// The layer type.
        /// </para>
        /// </summary>
        public GeospatialLayerType LayerType
        {
            get { return this._layerType; }
            set { this._layerType = value; }
        }

        // Check to see if LayerType property is set
        internal bool IsSetLayerType()
        {
            return this._layerType != null;
        }

        /// <summary>
        /// Gets and sets the property Tooltip.
        /// </summary>
        public TooltipOptions Tooltip
        {
            get { return this._tooltip; }
            set { this._tooltip = value; }
        }

        // Check to see if Tooltip property is set
        internal bool IsSetTooltip()
        {
            return this._tooltip != null;
        }

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The state of visibility for the layer.
        /// </para>
        /// </summary>
        public Visibility Visibility
        {
            get { return this._visibility; }
            set { this._visibility = value; }
        }

        // Check to see if Visibility property is set
        internal bool IsSetVisibility()
        {
            return this._visibility != null;
        }

    }
}