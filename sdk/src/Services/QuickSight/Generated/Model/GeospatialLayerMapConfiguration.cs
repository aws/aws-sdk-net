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
    /// The map definition that defines map state, map style, and geospatial layers.
    /// </summary>
    public partial class GeospatialLayerMapConfiguration
    {
        private VisualInteractionOptions _interactions;
        private LegendOptions _legend;
        private List<GeospatialLayerItem> _mapLayers = AWSConfigs.InitializeCollections ? new List<GeospatialLayerItem>() : null;
        private GeospatialMapState _mapState;
        private GeospatialMapStyle _mapStyle;

        /// <summary>
        /// Gets and sets the property Interactions.
        /// </summary>
        public VisualInteractionOptions Interactions
        {
            get { return this._interactions; }
            set { this._interactions = value; }
        }

        // Check to see if Interactions property is set
        internal bool IsSetInteractions()
        {
            return this._interactions != null;
        }

        /// <summary>
        /// Gets and sets the property Legend.
        /// </summary>
        public LegendOptions Legend
        {
            get { return this._legend; }
            set { this._legend = value; }
        }

        // Check to see if Legend property is set
        internal bool IsSetLegend()
        {
            return this._legend != null;
        }

        /// <summary>
        /// Gets and sets the property MapLayers. 
        /// <para>
        /// The geospatial layers to visualize on the map.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GeospatialLayerItem> MapLayers
        {
            get { return this._mapLayers; }
            set { this._mapLayers = value; }
        }

        // Check to see if MapLayers property is set
        internal bool IsSetMapLayers()
        {
            return this._mapLayers != null && (this._mapLayers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MapState. 
        /// <para>
        /// The map state properties for the map.
        /// </para>
        /// </summary>
        public GeospatialMapState MapState
        {
            get { return this._mapState; }
            set { this._mapState = value; }
        }

        // Check to see if MapState property is set
        internal bool IsSetMapState()
        {
            return this._mapState != null;
        }

        /// <summary>
        /// Gets and sets the property MapStyle. 
        /// <para>
        /// The map style properties for the map.
        /// </para>
        /// </summary>
        public GeospatialMapStyle MapStyle
        {
            get { return this._mapStyle; }
            set { this._mapStyle = value; }
        }

        // Check to see if MapStyle property is set
        internal bool IsSetMapStyle()
        {
            return this._mapStyle != null;
        }

    }
}