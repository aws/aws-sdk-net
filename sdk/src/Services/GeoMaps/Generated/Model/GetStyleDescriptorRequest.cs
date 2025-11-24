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
 * Do not modify this file. This file is generated from the geo-maps-2020-11-19.normal.json service model.
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
    /// Container for the parameters to the GetStyleDescriptor operation.
    /// <c>GetStyleDescriptor</c> returns information about the style.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/styling-dynamic-maps.html">Style
    /// dynamic maps</a> in the <i>Amazon Location Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetStyleDescriptorRequest : AmazonGeoMapsRequest
    {
        private ColorScheme _colorScheme;
        private ContourDensity _contourDensity;
        private string _key;
        private string _politicalView;
        private MapStyle _style;
        private Terrain _terrain;
        private Traffic _traffic;
        private List<string> _travelModes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ColorScheme. 
        /// <para>
        /// Sets color tone for map such as dark and light for specific map styles. It applies
        /// to only vector map styles such as Standard and Monochrome.
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
        public ColorScheme ColorScheme
        {
            get { return this._colorScheme; }
            set { this._colorScheme = value; }
        }

        // Check to see if ColorScheme property is set
        internal bool IsSetColorScheme()
        {
            return this._colorScheme != null;
        }

        /// <summary>
        /// Gets and sets the property ContourDensity. 
        /// <para>
        /// Displays the shape and steepness of terrain features using elevation lines. The density
        /// value controls how densely the available contour line information is rendered on the
        /// map.
        /// </para>
        ///  
        /// <para>
        /// This parameter is valid only for the <c>Standard</c> map style.
        /// </para>
        /// </summary>
        public ContourDensity ContourDensity
        {
            get { return this._contourDensity; }
            set { this._contourDensity = value; }
        }

        // Check to see if ContourDensity property is set
        internal bool IsSetContourDensity()
        {
            return this._contourDensity != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Optional: The API key to be used for authorization. Either an API key or valid SigV4
        /// signature must be provided when making a request. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1000)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property PoliticalView. 
        /// <para>
        /// Specifies the political view using ISO 3166-2 or ISO 3166-3 country code format.
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
        [AWSProperty(Sensitive=true, Min=2, Max=3)]
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
        /// Style specifies the desired map style.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MapStyle Style
        {
            get { return this._style; }
            set { this._style = value; }
        }

        // Check to see if Style property is set
        internal bool IsSetStyle()
        {
            return this._style != null;
        }

        /// <summary>
        /// Gets and sets the property Terrain. 
        /// <para>
        /// Adjusts how physical terrain details are rendered on the map.
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
        ///  </li> </ul> 
        /// <para>
        /// This parameter is valid only for the <c>Standard</c> map style.
        /// </para>
        /// </summary>
        public Terrain Terrain
        {
            get { return this._terrain; }
            set { this._terrain = value; }
        }

        // Check to see if Terrain property is set
        internal bool IsSetTerrain()
        {
            return this._terrain != null;
        }

        /// <summary>
        /// Gets and sets the property Traffic. 
        /// <para>
        /// Displays real-time traffic information overlay on map, such as incident events and
        /// flow events.
        /// </para>
        ///  
        /// <para>
        /// This parameter is valid only for the <c>Standard</c> map style.
        /// </para>
        /// </summary>
        public Traffic Traffic
        {
            get { return this._traffic; }
            set { this._traffic = value; }
        }

        // Check to see if Traffic property is set
        internal bool IsSetTraffic()
        {
            return this._traffic != null;
        }

        /// <summary>
        /// Gets and sets the property TravelModes. 
        /// <para>
        /// Renders additional map information relevant to selected travel modes. Information
        /// for multiple travel modes can be displayed simultaneously, although this increases
        /// the overall information density rendered on the map.
        /// </para>
        ///  
        /// <para>
        /// This parameter is valid only for the <c>Standard</c> map style.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<string> TravelModes
        {
            get { return this._travelModes; }
            set { this._travelModes = value; }
        }

        // Check to see if TravelModes property is set
        internal bool IsSetTravelModes()
        {
            return this._travelModes != null && (this._travelModes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}