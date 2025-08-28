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
    /// Container for the parameters to the GetTile operation.
    /// <c>GetTile</c> returns a tile. Map tiles are used by clients to render a map. they're
    /// addressed using a grid arrangement with an X coordinate, Y coordinate, and Z (zoom)
    /// level.
    /// </summary>
    public partial class GetTileRequest : AmazonGeoMapsRequest
    {
        private string _key;
        private string _tileset;
        private string _x;
        private string _y;
        private string _z;

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
        /// Gets and sets the property Tileset. 
        /// <para>
        /// Specifies the desired tile set.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>raster.satellite | vector.basemap</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Tileset
        {
            get { return this._tileset; }
            set { this._tileset = value; }
        }

        // Check to see if Tileset property is set
        internal bool IsSetTileset()
        {
            return this._tileset != null;
        }

        /// <summary>
        /// Gets and sets the property X. 
        /// <para>
        /// The X axis value for the map tile. Must be between 0 and 19.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string X
        {
            get { return this._x; }
            set { this._x = value; }
        }

        // Check to see if X property is set
        internal bool IsSetX()
        {
            return this._x != null;
        }

        /// <summary>
        /// Gets and sets the property Y. 
        /// <para>
        /// The Y axis value for the map tile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string Y
        {
            get { return this._y; }
            set { this._y = value; }
        }

        // Check to see if Y property is set
        internal bool IsSetY()
        {
            return this._y != null;
        }

        /// <summary>
        /// Gets and sets the property Z. 
        /// <para>
        /// The zoom value for the map tile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string Z
        {
            get { return this._z; }
            set { this._z = value; }
        }

        // Check to see if Z property is set
        internal bool IsSetZ()
        {
            return this._z != null;
        }

    }
}