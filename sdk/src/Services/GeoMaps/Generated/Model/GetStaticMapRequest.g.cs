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
    /// Container for the parameters to the GetStaticMap operation. <c>GetStaticMap</c> provides
    /// high-quality static map images with customizable options. You can modify the map's
    /// appearance and overlay additional information. It's an ideal solution for applications
    /// requiring tailored static map snapshots. Not supported in <c>ap-southeast-1</c> and
    /// <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
    /// customers. <para> For more information, see the following topics in the <i>Amazon
    /// Location Service Developer Guide</i>: </para> <ul> <li> <para> <a href="https://docs.aws.amazon.com/location/latest/developerguide/static-maps.html">Static
    /// maps</a> </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/location/latest/developerguide/customizing-static-maps.html">Customize
    /// static maps</a> </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/location/latest/developerguide/overlaying-static-map.html">Overlay
    /// on the static map</a> </para> </li> </ul>
    /// </summary>
    public partial class GetStaticMapRequest : AmazonGeoMapsRequest
    {
        /// <summary>
        /// Gets and sets the property BoundedPositions. 
        /// <para>
        /// Takes in two or more pair of coordinates in World Geodetic System (WGS 84) format:
        /// [longitude, latitude], with each coordinate separated by a comma. The API will generate
        /// an image to encompass all of the provided coordinates. 
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
        [AWSProperty(Sensitive = true, Max = 5000)]
        public string BoundedPositions { get; set; }

        /// <summary>
        /// Checks to see if the BoundedPositions property is set.
        /// </summary>
        internal bool IsSetBoundedPositions() => this.BoundedPositions != null;

        /// <summary>
        /// Gets and sets the property BoundingBox. 
        /// <para>
        /// Takes in two pairs of coordinates in World Geodetic System (WGS 84) format: [longitude,
        /// latitude], denoting south-westerly and north-easterly edges of the image. The underlying
        /// area becomes the view of the image. 
        /// </para>
        ///  
        /// <para>
        /// Example: -123.17075,49.26959,-123.08125,49.31429
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 100)]
        public string BoundingBox { get; set; }

        /// <summary>
        /// Checks to see if the BoundingBox property is set.
        /// </summary>
        internal bool IsSetBoundingBox() => this.BoundingBox != null;

        /// <summary>
        /// Gets and sets the property Center. 
        /// <para>
        /// Takes in a pair of coordinates in World Geodetic System (WGS 84) format: [longitude,
        /// latitude], which becomes the center point of the image. This parameter requires that
        /// either zoom or radius is set.
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
        [AWSProperty(Sensitive = true, Min = 3, Max = 36)]
        public string Center { get; set; }

        /// <summary>
        /// Checks to see if the Center property is set.
        /// </summary>
        internal bool IsSetCenter() => this.Center != null;

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
        /// Valid values for <c>ColorScheme</c> are case sensitive.
        /// </para>
        ///  </note>
        /// </summary>
        public ColorScheme ColorScheme { get; set; }

        /// <summary>
        /// Checks to see if the ColorScheme property is set.
        /// </summary>
        internal bool IsSetColorScheme() => this.ColorScheme != null;

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
        [AWSProperty(Sensitive = true, Min = 1, Max = 5000)]
        public string CompactOverlay { get; set; }

        /// <summary>
        /// Checks to see if the CompactOverlay property is set.
        /// </summary>
        internal bool IsSetCompactOverlay() => this.CompactOverlay != null;

        /// <summary>
        /// Gets and sets the property CropLabels. 
        /// <para>
        /// It is a flag that takes in true or false. It prevents the labels that are on the edge
        /// of the image from being cut or obscured.
        /// </para>
        /// </summary>
        public bool? CropLabels { get; set; }

        /// <summary>
        /// Checks to see if the CropLabels property is set.
        /// </summary>
        internal bool IsSetCropLabels() => this.CropLabels.HasValue;

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
        [AWSProperty(Required = true)]
        public string FileName { get; set; }

        /// <summary>
        /// Checks to see if the FileName property is set.
        /// </summary>
        internal bool IsSetFileName() => this.FileName != null;

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
        [AWSProperty(Sensitive = true, Min = 1, Max = 4200)]
        public string GeoJsonOverlay { get; set; }

        /// <summary>
        /// Checks to see if the GeoJsonOverlay property is set.
        /// </summary>
        internal bool IsSetGeoJsonOverlay() => this.GeoJsonOverlay != null;

        /// <summary>
        /// Gets and sets the property Height. 
        /// <para>
        /// Specifies the height of the map image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 64, Max = 1400)]
        public int? Height { get; set; }

        /// <summary>
        /// Checks to see if the Height property is set.
        /// </summary>
        internal bool IsSetHeight() => this.Height.HasValue;

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
        /// Gets and sets the property LabelSize. 
        /// <para>
        /// Overrides the label size auto-calculated by <c>FileName</c>. Takes in one of the values
        /// - <c>Small</c> or <c>Large</c>.
        /// </para>
        /// </summary>
        public LabelSize LabelSize { get; set; }

        /// <summary>
        /// Checks to see if the LabelSize property is set.
        /// </summary>
        internal bool IsSetLabelSize() => this.LabelSize != null;

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
        [AWSProperty(Min = 2, Max = 35)]
        public string Language { get; set; }

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null;

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
        [AWSProperty(Sensitive = true, Min = 0, Max = 350)]
        public int? Padding { get; set; }

        /// <summary>
        /// Checks to see if the Padding property is set.
        /// </summary>
        internal bool IsSetPadding() => this.Padding.HasValue;

        /// <summary>
        /// Gets and sets the property PointsOfInterests. 
        /// <para>
        /// Determines if the result image will display icons representing points of interest
        /// on the map.
        /// </para>
        /// </summary>
        public MapFeatureMode PointsOfInterests { get; set; }

        /// <summary>
        /// Checks to see if the PointsOfInterests property is set.
        /// </summary>
        internal bool IsSetPointsOfInterests() => this.PointsOfInterests != null;

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
        [AWSProperty(Sensitive = true, Min = 2, Max = 3)]
        public string PoliticalView { get; set; }

        /// <summary>
        /// Checks to see if the PoliticalView property is set.
        /// </summary>
        internal bool IsSetPoliticalView() => this.PoliticalView != null;

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
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? Radius { get; set; }

        /// <summary>
        /// Checks to see if the Radius property is set.
        /// </summary>
        internal bool IsSetRadius() => this.Radius.HasValue;

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
        public ScaleBarUnit ScaleBarUnit { get; set; }

        /// <summary>
        /// Checks to see if the ScaleBarUnit property is set.
        /// </summary>
        internal bool IsSetScaleBarUnit() => this.ScaleBarUnit != null;

        /// <summary>
        /// Gets and sets the property Style. 
        /// <para>
        ///  <c>Style</c> specifies the desired map style.
        /// </para>
        /// </summary>
        public StaticMapStyle Style { get; set; }

        /// <summary>
        /// Checks to see if the Style property is set.
        /// </summary>
        internal bool IsSetStyle() => this.Style != null;

        /// <summary>
        /// Gets and sets the property Width. 
        /// <para>
        /// Specifies the width of the map image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 64, Max = 1400)]
        public int? Width { get; set; }

        /// <summary>
        /// Checks to see if the Width property is set.
        /// </summary>
        internal bool IsSetWidth() => this.Width.HasValue;

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
        [AWSProperty(Sensitive = true, Min = 0, Max = 20)]
        public float? Zoom { get; set; }

        /// <summary>
        /// Checks to see if the Zoom property is set.
        /// </summary>
        internal bool IsSetZoom() => this.Zoom.HasValue;
    }
}
