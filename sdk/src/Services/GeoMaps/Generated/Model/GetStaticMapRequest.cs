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
    /// Container for the parameters to the GetStaticMap operation.
    /// <c>GetStaticMap</c> provides high-quality static map images with customizable options.
    /// You can modify the map's appearance and overlay additional information. It's an ideal
    /// solution for applications requiring tailored static map snapshots.
    /// </summary>
    public partial class GetStaticMapRequest : AmazonGeoMapsRequest
    {
        private string _boundedPositions;
        private string _boundingBox;
        private string _center;
        private ColorScheme _colorScheme;
        private string _compactOverlay;
        private bool? _cropLabels;
        private string _fileName;
        private string _geoJsonOverlay;
        private int? _height;
        private string _key;
        private LabelSize _labelSize;
        private string _language;
        private int? _padding;
        private MapFeatureMode _pointsOfInterests;
        private string _politicalView;
        private long? _radius;
        private ScaleBarUnit _scaleBarUnit;
        private StaticMapStyle _style;
        private int? _width;
        private float? _zoom;

        /// <summary>
        /// Gets and sets the property BoundedPositions. 
        /// <para>
        /// Takes in two or more pair of coordinates, [Lon, Lat], with each coordinate separated
        /// by a comma. The API will generate an image to encompass all of the provided coordinates.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// Cannot be used with <c>Zoom</c> and or <c>Radius</c> 
        /// </para>
        ///  </note> 
        /// <para>
        /// Example: 97.170451,78.039098,99.045536,27.176178
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=7)]
        public string BoundedPositions
        {
            get { return this._boundedPositions; }
            set { this._boundedPositions = value; }
        }

        // Check to see if BoundedPositions property is set
        internal bool IsSetBoundedPositions()
        {
            return this._boundedPositions != null;
        }

        /// <summary>
        /// Gets and sets the property BoundingBox. 
        /// <para>
        /// Takes in two pairs of coordinates, [Lon, Lat], denoting south-westerly and north-easterly
        /// edges of the image. The underlying area becomes the view of the image. 
        /// </para>
        ///  
        /// <para>
        /// Example: -123.17075,49.26959,-123.08125,49.31429
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=7)]
        public string BoundingBox
        {
            get { return this._boundingBox; }
            set { this._boundingBox = value; }
        }

        // Check to see if BoundingBox property is set
        internal bool IsSetBoundingBox()
        {
            return this._boundingBox != null;
        }

        /// <summary>
        /// Gets and sets the property Center. 
        /// <para>
        /// Takes in a pair of coordinates, [Lon, Lat], which becomes the center point of the
        /// image. This parameter requires that either zoom or radius is set.
        /// </para>
        ///  <note> 
        /// <para>
        /// Cannot be used with <c>Zoom</c> and or <c>Radius</c> 
        /// </para>
        ///  </note> 
        /// <para>
        /// Example: 49.295,-123.108
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=3, Max=36)]
        public string Center
        {
            get { return this._center; }
            set { this._center = value; }
        }

        // Check to see if Center property is set
        internal bool IsSetCenter()
        {
            return this._center != null;
        }

        /// <summary>
        /// Gets and sets the property ColorScheme. 
        /// <para>
        /// Sets color tone for map, such as dark and light for specific map styles. It only applies
        /// to vector map styles, such as Standard.
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
        /// Valid values for <c>ColorScheme</c> are case sensitive.
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
        /// Gets and sets the property CompactOverlay. 
        /// <para>
        /// Takes in a string to draw geometries on the image. The input is a comma separated
        /// format as follows format: <c>[Lon, Lat]</c> 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>line:-122.407653,37.798557,-122.413291,37.802443;color=%23DD0000;width=7;outline-color=#00DD00;outline-width=5yd|point:-122.40572,37.80004;label=Fog
        /// Hill Market;size=large;text-color=%23DD0000;color=#EE4B2B</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently it supports the following geometry types: point, line and polygon. It does
        /// not support multiPoint , multiLine and multiPolgyon.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=7000)]
        public string CompactOverlay
        {
            get { return this._compactOverlay; }
            set { this._compactOverlay = value; }
        }

        // Check to see if CompactOverlay property is set
        internal bool IsSetCompactOverlay()
        {
            return this._compactOverlay != null;
        }

        /// <summary>
        /// Gets and sets the property CropLabels. 
        /// <para>
        /// It is a flag that takes in true or false. It prevents the labels that are on the edge
        /// of the image from being cut or obscured.
        /// </para>
        /// </summary>
        public bool? CropLabels
        {
            get { return this._cropLabels; }
            set { this._cropLabels = value; }
        }

        // Check to see if CropLabels property is set
        internal bool IsSetCropLabels()
        {
            return this._cropLabels.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FileName. 
        /// <para>
        /// The map scaling parameter to size the image, icons, and labels. It follows the pattern
        /// of <c>^map(@2x)?$</c>.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>map, map@2x</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FileName
        {
            get { return this._fileName; }
            set { this._fileName = value; }
        }

        // Check to see if FileName property is set
        internal bool IsSetFileName()
        {
            return this._fileName != null;
        }

        /// <summary>
        /// Gets and sets the property GeoJsonOverlay. 
        /// <para>
        /// Takes in a string to draw geometries on the image. The input is a valid GeoJSON collection
        /// object. 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>{"type":"FeatureCollection","features": [{"type":"Feature","geometry":{"type":"MultiPoint","coordinates":
        /// [[-90.076345,51.504107],[-0.074451,51.506892]]},"properties": {"color":"#00DD00"}}]}</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=7000)]
        public string GeoJsonOverlay
        {
            get { return this._geoJsonOverlay; }
            set { this._geoJsonOverlay = value; }
        }

        // Check to see if GeoJsonOverlay property is set
        internal bool IsSetGeoJsonOverlay()
        {
            return this._geoJsonOverlay != null;
        }

        /// <summary>
        /// Gets and sets the property Height. 
        /// <para>
        /// Specifies the height of the map image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=64, Max=1400)]
        public int? Height
        {
            get { return this._height; }
            set { this._height = value; }
        }

        // Check to see if Height property is set
        internal bool IsSetHeight()
        {
            return this._height.HasValue; 
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
        /// Gets and sets the property LabelSize. 
        /// <para>
        /// Overrides the label size auto-calculated by <c>FileName</c>. Takes in one of the values
        /// - <c>Small</c> or <c>Large</c>.
        /// </para>
        /// </summary>
        public LabelSize LabelSize
        {
            get { return this._labelSize; }
            set { this._labelSize = value; }
        }

        // Check to see if LabelSize property is set
        internal bool IsSetLabelSize()
        {
            return this._labelSize != null;
        }

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// Specifies the language on the map labels using the BCP 47 language tag, limited to
        /// ISO 639-1 two-letter language codes. If the specified language data isn't available
        /// for the map image, the labels will default to the regional primary language.
        /// </para>
        ///  
        /// <para>
        /// Supported codes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ar</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>as</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>az</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>be</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>bg</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>bn</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>bs</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ca</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cs</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cy</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>da</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>de</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>el</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>en</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>es</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>et</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>eu</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>fi</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>fo</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>fr</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ga</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>gl</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>gn</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>gu</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>he</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>hi</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>hr</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>hu</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>hy</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>id</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>is</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>it</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ja</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ka</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>kk</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>km</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>kn</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ko</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ky</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>lt</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>lv</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mk</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ml</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mr</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ms</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mt</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>my</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>nl</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>no</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>or</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pa</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pl</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pt</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ro</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ru</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sk</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sl</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sq</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sr</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sv</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ta</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>te</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>th</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tr</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>uk</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>uz</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>vi</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>zh</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=2, Max=35)]
        public string Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

        /// <summary>
        /// Gets and sets the property Padding. 
        /// <para>
        /// Applies additional space (in pixels) around overlay feature to prevent them from being
        /// cut or obscured.
        /// </para>
        ///  <note> 
        /// <para>
        /// Value for max and min is determined by:
        /// </para>
        ///  
        /// <para>
        /// Min: <c>1</c> 
        /// </para>
        ///  
        /// <para>
        /// Max: <c>min(height, width)/4</c> 
        /// </para>
        ///  </note> 
        /// <para>
        /// Example: <c>100</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public int? Padding
        {
            get { return this._padding; }
            set { this._padding = value; }
        }

        // Check to see if Padding property is set
        internal bool IsSetPadding()
        {
            return this._padding.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PointsOfInterests. 
        /// <para>
        /// Determines if the result image will display icons representing points of interest
        /// on the map.
        /// </para>
        /// </summary>
        public MapFeatureMode PointsOfInterests
        {
            get { return this._pointsOfInterests; }
            set { this._pointsOfInterests = value; }
        }

        // Check to see if PointsOfInterests property is set
        internal bool IsSetPointsOfInterests()
        {
            return this._pointsOfInterests != null;
        }

        /// <summary>
        /// Gets and sets the property PoliticalView. 
        /// <para>
        /// Specifies the political view, using ISO 3166-2 or ISO 3166-3 country code format.
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
        /// Gets and sets the property Radius. 
        /// <para>
        /// Used with center parameter, it specifies the zoom of the image where you can control
        /// it on a granular level. Takes in any value <c>&gt;= 1</c>. 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>1500</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// Cannot be used with <c>Zoom</c>.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Unit</b>: <c>Meters</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? Radius
        {
            get { return this._radius; }
            set { this._radius = value; }
        }

        // Check to see if Radius property is set
        internal bool IsSetRadius()
        {
            return this._radius.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScaleBarUnit. 
        /// <para>
        /// Displays a scale on the bottom right of the map image with the unit specified in the
        /// input. 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>KilometersMiles, Miles, Kilometers, MilesKilometers</c> 
        /// </para>
        /// </summary>
        public ScaleBarUnit ScaleBarUnit
        {
            get { return this._scaleBarUnit; }
            set { this._scaleBarUnit = value; }
        }

        // Check to see if ScaleBarUnit property is set
        internal bool IsSetScaleBarUnit()
        {
            return this._scaleBarUnit != null;
        }

        /// <summary>
        /// Gets and sets the property Style. 
        /// <para>
        ///  <c>Style</c> specifies the desired map style.
        /// </para>
        /// </summary>
        public StaticMapStyle Style
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
        /// Gets and sets the property Width. 
        /// <para>
        /// Specifies the width of the map image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=64, Max=1400)]
        public int? Width
        {
            get { return this._width; }
            set { this._width = value; }
        }

        // Check to see if Width property is set
        internal bool IsSetWidth()
        {
            return this._width.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Zoom. 
        /// <para>
        /// Specifies the zoom level of the map image.
        /// </para>
        ///  <note> 
        /// <para>
        /// Cannot be used with <c>Radius</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=20)]
        public float? Zoom
        {
            get { return this._zoom; }
            set { this._zoom = value; }
        }

        // Check to see if Zoom property is set
        internal bool IsSetZoom()
        {
            return this._zoom.HasValue; 
        }

    }
}