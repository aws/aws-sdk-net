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
    /// Provides high-quality static map images with customizable options. You can modify
    /// the map's appearance and overlay additional information. It's an ideal solution for
    /// applications requiring tailored static map snapshots.
    /// </summary>
    public partial class GetStaticMapRequest : AmazonGeoMapsRequest
    {
        private string _boundedPositions;
        private string _boundingBox;
        private string _center;
        private string _compactOverlay;
        private string _fileName;
        private string _geoJsonOverlay;
        private int? _height;
        private string _key;
        private int? _padding;
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
        [AWSProperty(Min=7)]
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
        [AWSProperty(Min=7)]
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
        [AWSProperty(Min=3, Max=36)]
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
        [AWSProperty(Min=1, Max=7000)]
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
        [AWSProperty(Min=1, Max=7000)]
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
        [AWSProperty(Required=true, Min=64, Max=1400)]
        public int Height
        {
            get { return this._height.GetValueOrDefault(); }
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
        public int Padding
        {
            get { return this._padding.GetValueOrDefault(); }
            set { this._padding = value; }
        }

        // Check to see if Padding property is set
        internal bool IsSetPadding()
        {
            return this._padding.HasValue; 
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
        [AWSProperty(Min=0, Max=4294967295)]
        public long Radius
        {
            get { return this._radius.GetValueOrDefault(); }
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
        /// Style specifies the desired map style for the <c>Style</c> APIs.
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
        [AWSProperty(Required=true, Min=64, Max=1400)]
        public int Width
        {
            get { return this._width.GetValueOrDefault(); }
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
        [AWSProperty(Min=0, Max=20)]
        public float Zoom
        {
            get { return this._zoom.GetValueOrDefault(); }
            set { this._zoom = value; }
        }

        // Check to see if Zoom property is set
        internal bool IsSetZoom()
        {
            return this._zoom.HasValue; 
        }

    }
}