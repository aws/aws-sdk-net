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
    /// Container for the parameters to the GetMapTile operation.
    /// <important> 
    /// <para>
    /// This operation is no longer current and may be deprecated in the future. We recommend
    /// upgrading to <a href="https://docs.aws.amazon.com/location/latest/APIReference/API_geomaps_GetTile.html">
    /// <c>GetTile</c> </a> unless you require <c>Grab</c> data.
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>GetMapTile</c> is part of a previous Amazon Location Service Maps API (version
    /// 1) which has been superseded by a more intuitive, powerful, and complete API (version
    /// 2).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The version 2 <c>GetTile</c> operation gives a better user experience and is compatible
    /// with the remainder of the V2 Maps API.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you are using an AWS SDK or the AWS CLI, note that the Maps API version 2 is found
    /// under <c>geo-maps</c> or <c>geo_maps</c>, not under <c>location</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Since <c>Grab</c> is not yet fully supported in Maps API version 2, we recommend you
    /// continue using API version 1 when using <c>Grab</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Start your version 2 API journey with the <a href="https://docs.aws.amazon.com/location/latest/APIReference/API_Operations_Amazon_Location_Service_Maps_V2.html">Maps
    /// V2 API Reference</a> or the <a href="https://docs.aws.amazon.com/location/latest/developerguide/maps.html">Developer
    /// Guide</a>.
    /// </para>
    ///  </li> </ul> </important> 
    /// <para>
    /// Retrieves a vector data tile from the map resource. Map tiles are used by clients
    /// to render a map. they're addressed using a grid arrangement with an X coordinate,
    /// Y coordinate, and Z (zoom) level. 
    /// </para>
    ///  
    /// <para>
    /// The origin (0, 0) is the top left of the map. Increasing the zoom level by 1 doubles
    /// both the X and Y dimensions, so a tile containing data for the entire world at (0/0/0)
    /// will be split into 4 tiles at zoom 1 (1/0/0, 1/0/1, 1/1/0, 1/1/1).
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial class GetMapTileRequest : AmazonLocationServiceRequest
    {
        private string _key;
        private string _mapName;
        private string _x;
        private string _y;
        private string _z;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The optional <a href="https://docs.aws.amazon.com/location/previous/developerguide/using-apikeys.html">API
        /// key</a> to authorize the request.
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
        /// Gets and sets the property MapName. 
        /// <para>
        /// The map resource to retrieve the map tiles from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string MapName
        {
            get { return this._mapName; }
            set { this._mapName = value; }
        }

        // Check to see if MapName property is set
        internal bool IsSetMapName()
        {
            return this._mapName != null;
        }

        /// <summary>
        /// Gets and sets the property X. 
        /// <para>
        /// The X axis value for the map tile.
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