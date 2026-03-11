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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
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
namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Specifies the map tile style selected from an available provider.
    /// </summary>
    public partial class MapConfiguration
    {
        private List<string> _customLayers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _politicalView;
        private string _style;

        /// <summary>
        /// Gets and sets the property CustomLayers. 
        /// <para>
        /// Specifies the custom layers for the style. Leave unset to not enable any custom layer,
        /// or, for styles that support custom layers, you can enable layer(s), such as POI layer
        /// for the VectorEsriNavigation style. Default is <c>unset</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Not all map resources or styles support custom layers. See Custom Layers for more
        /// information.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> CustomLayers
        {
            get { return this._customLayers; }
            set { this._customLayers = value; }
        }

        // Check to see if CustomLayers property is set
        internal bool IsSetCustomLayers()
        {
            return this._customLayers != null && (this._customLayers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PoliticalView. 
        /// <para>
        /// Specifies the political view for the style. Leave unset to not use a political view,
        /// or, for styles that support specific political views, you can choose a view, such
        /// as <c>IND</c> for the Indian view.
        /// </para>
        ///  
        /// <para>
        /// Default is unset.
        /// </para>
        ///  <note> 
        /// <para>
        /// Not all map resources or styles support political view styles. See <a href="https://docs.aws.amazon.com/location/previous/developerguide/map-concepts.html#political-views">Political
        /// views</a> for more information.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=3, Max=3)]
        public string PoliticalView
        {
            get { return this._politicalView; }
            set { this._politicalView = value; }
        }

        // Check to see if PoliticalView property is set
        internal bool IsSetPoliticalView()
        {
            return this._politicalView != null;
        }

        /// <summary>
        /// Gets and sets the property Style. 
        /// <para>
        /// Specifies the map style selected from an available data provider.
        /// </para>
        ///  
        /// <para>
        /// Valid <a href="https://docs.aws.amazon.com/location/previous/developerguide/esri.html">Esri
        /// map styles</a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>VectorEsriDarkGrayCanvas</c> – The Esri Dark Gray Canvas map style. A vector basemap
        /// with a dark gray, neutral background with minimal colors, labels, and features that's
        /// designed to draw attention to your thematic content. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RasterEsriImagery</c> – The Esri Imagery map style. A raster basemap that provides
        /// one meter or better satellite and aerial imagery in many parts of the world and lower
        /// resolution satellite imagery worldwide. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VectorEsriLightGrayCanvas</c> – The Esri Light Gray Canvas map style, which provides
        /// a detailed vector basemap with a light gray, neutral background style with minimal
        /// colors, labels, and features that's designed to draw attention to your thematic content.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VectorEsriTopographic</c> – The Esri Light map style, which provides a detailed
        /// vector basemap with a classic Esri map style.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VectorEsriStreets</c> – The Esri Street Map style, which provides a detailed vector
        /// basemap for the world symbolized with a classic Esri street map style. The vector
        /// tile layer is similar in content and style to the World Street Map raster map.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VectorEsriNavigation</c> – The Esri Navigation map style, which provides a detailed
        /// basemap for the world symbolized with a custom navigation map style that's designed
        /// for use during the day in mobile devices.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Valid <a href="https://docs.aws.amazon.com/location/previous/developerguide/HERE.html">HERE
        /// Technologies map styles</a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>VectorHereContrast</c> – The HERE Contrast (Berlin) map style is a high contrast
        /// detailed base map of the world that blends 3D and 2D rendering.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>VectorHereContrast</c> style has been renamed from <c>VectorHereBerlin</c>.
        /// <c>VectorHereBerlin</c> has been deprecated, but will continue to work in applications
        /// that use it.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <c>VectorHereExplore</c> – A default HERE map style containing a neutral, global
        /// map and its features including roads, buildings, landmarks, and water features. It
        /// also now includes a fully designed map of Japan.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VectorHereExploreTruck</c> – A global map containing truck restrictions and attributes
        /// (e.g. width / height / HAZMAT) symbolized with highlighted segments and icons on top
        /// of HERE Explore to support use cases within transport and logistics.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RasterHereExploreSatellite</c> – A global map containing high resolution satellite
        /// imagery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HybridHereExploreSatellite</c> – A global map displaying the road network, street
        /// names, and city labels over satellite imagery. This style will automatically retrieve
        /// both raster and vector tiles, and your charges will be based on total tiles retrieved.
        /// </para>
        ///  <note> 
        /// <para>
        /// Hybrid styles use both vector and raster tiles when rendering the map that you see.
        /// This means that more tiles are retrieved than when using either vector or raster tiles
        /// alone. Your charges will include all tiles retrieved.
        /// </para>
        ///  </note> </li> </ul> 
        /// <para>
        /// Valid <a href="https://docs.aws.amazon.com/location/previous/developerguide/grab.html">GrabMaps
        /// map styles</a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>VectorGrabStandardLight</c> – The Grab Standard Light map style provides a basemap
        /// with detailed land use coloring, area names, roads, landmarks, and points of interest
        /// covering Southeast Asia.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VectorGrabStandardDark</c> – The Grab Standard Dark map style provides a dark
        /// variation of the standard basemap covering Southeast Asia.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Grab provides maps only for countries in Southeast Asia, and is only available in
        /// the Asia Pacific (Singapore) Region (<c>ap-southeast-1</c>). For more information,
        /// see <a href="https://docs.aws.amazon.com/location/previous/developerguide/grab.html#grab-coverage-area">GrabMaps
        /// countries and area covered</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid <a href="https://docs.aws.amazon.com/location/previous/developerguide/open-data.html">Open
        /// Data map styles</a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>VectorOpenDataStandardLight</c> – The Open Data Standard Light map style provides
        /// a detailed basemap for the world suitable for website and mobile application use.
        /// The map includes highways major roads, minor roads, railways, water features, cities,
        /// parks, landmarks, building footprints, and administrative boundaries.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VectorOpenDataStandardDark</c> – Open Data Standard Dark is a dark-themed map
        /// style that provides a detailed basemap for the world suitable for website and mobile
        /// application use. The map includes highways major roads, minor roads, railways, water
        /// features, cities, parks, landmarks, building footprints, and administrative boundaries.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VectorOpenDataVisualizationLight</c> – The Open Data Visualization Light map style
        /// is a light-themed style with muted colors and fewer features that aids in understanding
        /// overlaid data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VectorOpenDataVisualizationDark</c> – The Open Data Visualization Dark map style
        /// is a dark-themed style with muted colors and fewer features that aids in understanding
        /// overlaid data.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Style
        {
            get { return this._style; }
            set { this._style = value; }
        }

        // Check to see if Style property is set
        internal bool IsSetStyle()
        {
            return this._style != null;
        }

    }
}