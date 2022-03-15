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

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Specifies the map tile style selected from an available provider.
    /// </summary>
    public partial class MapConfiguration
    {
        private string _style;

        /// <summary>
        /// Gets and sets the property Style. 
        /// <para>
        /// Specifies the map style selected from an available data provider.
        /// </para>
        ///  
        /// <para>
        /// Valid <a href="https://docs.aws.amazon.com/location/latest/developerguide/esri.html">Esri
        /// map styles</a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>VectorEsriDarkGrayCanvas</code> – The Esri Dark Gray Canvas map style. A vector
        /// basemap with a dark gray, neutral background with minimal colors, labels, and features
        /// that's designed to draw attention to your thematic content. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RasterEsriImagery</code> – The Esri Imagery map style. A raster basemap that
        /// provides one meter or better satellite and aerial imagery in many parts of the world
        /// and lower resolution satellite imagery worldwide. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VectorEsriLightGrayCanvas</code> – The Esri Light Gray Canvas map style, which
        /// provides a detailed vector basemap with a light gray, neutral background style with
        /// minimal colors, labels, and features that's designed to draw attention to your thematic
        /// content. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VectorEsriTopographic</code> – The Esri Light map style, which provides a detailed
        /// vector basemap with a classic Esri map style.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VectorEsriStreets</code> – The Esri World Streets map style, which provides
        /// a detailed vector basemap for the world symbolized with a classic Esri street map
        /// style. The vector tile layer is similar in content and style to the World Street Map
        /// raster map.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VectorEsriNavigation</code> – The Esri World Navigation map style, which provides
        /// a detailed basemap for the world symbolized with a custom navigation map style that's
        /// designed for use during the day in mobile devices.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Valid <a href="https://docs.aws.amazon.com/location/latest/developerguide/HERE.html">HERE
        /// Technologies map styles</a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>VectorHereBerlin</code> – The HERE Berlin map style is a high contrast detailed
        /// base map of the world that blends 3D and 2D rendering.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VectorHereExplore</code> – A default HERE map style containing a neutral, global
        /// map and its features including roads, buildings, landmarks, and water features. It
        /// also now includes a fully designed map of Japan.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VectorHereExploreTruck</code> – A global map containing truck restrictions
        /// and attributes (e.g. width / height / HAZMAT) symbolized with highlighted segments
        /// and icons on top of HERE Explore to support use cases within transport and logistics.
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