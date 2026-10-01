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

namespace Amazon.GeoMaps.Model
{
    /// <summary>
    /// Container for the parameters to the GetStyleDescriptor operation. <c>GetStyleDescriptor</c>
    /// returns information about the style. <para> For more information, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/styling-dynamic-maps.html">Style
    /// dynamic maps</a> in the <i>Amazon Location Service Developer Guide</i>. </para>
    /// </summary>
    public partial class GetStyleDescriptorRequest : AmazonGeoMapsRequest
    {
        /// <summary>
        /// Gets and sets the property Buildings. 
        /// <para>
        /// Adjusts how building details are rendered on the map.
        /// </para>
        ///  
        /// <para>
        /// The following building styles are currently supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Buildings3D</c>: Displays buildings as three-dimensional extrusions on the map.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>Buildings3D</c> is valid only for the <c>Standard</c> and <c>Monochrome</c> map
        /// styles.
        /// </para>
        /// </summary>
        public Buildings Buildings { get; set; }

        /// <summary>
        /// Checks to see if the Buildings property is set.
        /// </summary>
        internal bool IsSetBuildings() => this.Buildings != null;

        /// <summary>
        /// Gets and sets the property ColorScheme. 
        /// <para>
        /// Sets the color tone for the map, such as dark and light.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>Light</c> 
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>Light</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// Valid values for ColorScheme are case sensitive.
        /// </para>
        ///  </note>
        /// </summary>
        public ColorScheme ColorScheme { get; set; }

        /// <summary>
        /// Checks to see if the ColorScheme property is set.
        /// </summary>
        internal bool IsSetColorScheme() => this.ColorScheme != null;

        /// <summary>
        /// Gets and sets the property ContourDensity. 
        /// <para>
        /// Displays the shape and steepness of terrain features using elevation lines. The density
        /// value controls how densely the available contour line information is rendered on the
        /// map. Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions for
        /// <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers.
        /// </para>
        ///  
        /// <para>
        /// This parameter is valid for all map styles except <c>Satellite</c>.
        /// </para>
        /// </summary>
        public ContourDensity ContourDensity { get; set; }

        /// <summary>
        /// Checks to see if the ContourDensity property is set.
        /// </summary>
        internal bool IsSetContourDensity() => this.ContourDensity != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Optional: The API key to be used for authorization. Either an API key or valid SigV4
        /// signature must be provided when making a request. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 1000)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property PoiCategories. 
        /// <para>
        /// Renders only the specified categories of points of interest. When you omit this parameter,
        /// the map renders all categories.
        /// </para>
        ///  
        /// <para>
        /// The following categories are currently supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FoodAndDrink</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Entertainment</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SightsAndMuseums</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Transportation</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Accommodations</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LeisureAndOutdoor</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Shopping</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BusinessAndServices</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FacilitiesAndBuildings</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Specify each category as a separate <c>poi-categories</c> query parameter. Duplicate
        /// values are rejected.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter has no effect when <c>poi-density</c> is set to <c>Off</c>, which hides
        /// all points of interest regardless of category.
        /// </para>
        ///  </note> 
        /// <para>
        /// This parameter is valid only for the <c>Standard</c> and <c>Hybrid</c> map styles.
        /// In <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers, this parameter is valid only for the <c>Standard</c> map style.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 9)]
        public List<string> PoiCategories { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PoiCategories property is set.
        /// </summary>
        internal bool IsSetPoiCategories() => this.PoiCategories != null && (this.PoiCategories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PoiDensity. 
        /// <para>
        /// Controls how densely points of interest are rendered on the map. The density value
        /// controls the zoom level at which each category of points of interest appears, and
        /// how quickly less prominent points of interest are revealed as you zoom in. Denser
        /// values display more points of interest at lower zoom levels.
        /// </para>
        ///  
        /// <para>
        /// Use <c>Off</c> to hide all points of interest. When you omit this parameter, the map
        /// renders at <c>Default</c> density.
        /// </para>
        ///  <note> 
        /// <para>
        /// The difference between density values is most noticeable at mid-range zoom levels.
        /// At high zoom levels, all density values converge on displaying every available point
        /// of interest.
        /// </para>
        ///  </note> 
        /// <para>
        /// This parameter is valid only for the <c>Standard</c> and <c>Hybrid</c> map styles.
        /// In <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers, this parameter is valid only for the <c>Standard</c> map style.
        /// </para>
        /// </summary>
        public PoiDensity PoiDensity { get; set; }

        /// <summary>
        /// Checks to see if the PoiDensity property is set.
        /// </summary>
        internal bool IsSetPoiDensity() => this.PoiDensity != null;

        /// <summary>
        /// Gets and sets the property PoliticalView. 
        /// <para>
        /// Specifies the political view using ISO 3166-2 or ISO 3166-3 country code format. Not
        /// supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers.
        /// </para>
        ///  
        /// <para>
        /// The following political views are currently supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ARG</c>: Argentina's view on the Southern Patagonian Ice Field and Tierra Del
        /// Fuego, including the Falkland Islands, South Georgia, and South Sandwich Islands
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EGY</c>: Egypt's view on Bir Tawil
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IND</c>: India's view on Gilgit-Baltistan
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KEN</c>: Kenya's view on the Ilemi Triangle
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MAR</c>: Morocco's view on Western Sahara
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RUS</c>: Russia's view on Crimea
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SDN</c>: Sudan's view on the Halaib Triangle
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SRB</c>: Serbia's view on Kosovo, Vukovar, and Sarengrad Islands
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUR</c>: Suriname's view on the Courantyne Headwaters and Lawa Headwaters
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SYR</c>: Syria's view on the Golan Heights
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TUR</c>: Turkey's view on Cyprus and Northern Cyprus
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TZA</c>: Tanzania's view on Lake Malawi
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>URY</c>: Uruguay's view on Rincon de Artigas
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VNM</c>: Vietnam's view on the Paracel Islands and Spratly Islands
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 2, Max = 3)]
        public string PoliticalView { get; set; }

        /// <summary>
        /// Checks to see if the PoliticalView property is set.
        /// </summary>
        internal bool IsSetPoliticalView() => this.PoliticalView != null;

        /// <summary>
        /// Gets and sets the property Style. 
        /// <para>
        /// Style specifies the desired map style. For <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers, <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions support only the
        /// <c>Standard</c> and <c>Monochrome</c> values.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MapStyle Style { get; set; }

        /// <summary>
        /// Checks to see if the Style property is set.
        /// </summary>
        internal bool IsSetStyle() => this.Style != null;

        /// <summary>
        /// Gets and sets the property Terrain. 
        /// <para>
        /// Adjusts how physical terrain details are rendered on the map. Not supported in <c>ap-southeast-1</c>
        /// and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers.
        /// </para>
        ///  
        /// <para>
        /// The following terrain styles are currently supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Hillshade</c>: Displays the physical terrain details through shading and highlighting
        /// of elevation change and geographic features.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Terrain3D</c>: Displays physical terrain details and elevations as a three-dimensional
        /// model.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>Hillshade</c> is valid only for the <c>Standard</c> and <c>Monochrome</c> map
        /// styles.
        /// </para>
        /// </summary>
        public Terrain Terrain { get; set; }

        /// <summary>
        /// Checks to see if the Terrain property is set.
        /// </summary>
        internal bool IsSetTerrain() => this.Terrain != null;

        /// <summary>
        /// Gets and sets the property Traffic. 
        /// <para>
        /// Displays real-time traffic information overlay on map, such as incident events and
        /// flow events. Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions
        /// for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers.
        /// </para>
        ///  
        /// <para>
        /// This parameter is valid for all map styles except <c>Satellite</c>.
        /// </para>
        /// </summary>
        public Traffic Traffic { get; set; }

        /// <summary>
        /// Checks to see if the Traffic property is set.
        /// </summary>
        internal bool IsSetTraffic() => this.Traffic != null;

        /// <summary>
        /// Gets and sets the property TravelModes. 
        /// <para>
        /// Renders additional map information relevant to selected travel modes. Information
        /// for multiple travel modes can be displayed simultaneously, although this increases
        /// the overall information density rendered on the map. Not supported in <c>ap-southeast-1</c>
        /// and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers.
        /// </para>
        ///  
        /// <para>
        /// This parameter is valid for all map styles except <c>Satellite</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 2)]
        public List<string> TravelModes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TravelModes property is set.
        /// </summary>
        internal bool IsSetTravelModes() => this.TravelModes != null && (this.TravelModes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
