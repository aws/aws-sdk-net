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
    /// Container for the parameters to the GetTile operation. <c>GetTile</c> returns a tile.
    /// Map tiles are used by clients to render a map. They're addressed using a grid arrangement
    /// with an X coordinate, Y coordinate, and Z (zoom) level. <para> For more information,
    /// see <a href="https://docs.aws.amazon.com/location/latest/developerguide/tiles.html">Tiles</a>
    /// in the <i>Amazon Location Service Developer Guide</i>. </para>
    /// </summary>
    public partial class GetTileRequest : AmazonGeoMapsRequest
    {
        /// <summary>
        /// Gets and sets the property AdditionalFeatures. 
        /// <para>
        /// A list of optional additional parameters such as map styles that can be requested
        /// for each result. Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c>
        /// regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 4)]
        public List<string> AdditionalFeatures { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalFeatures property is set.
        /// </summary>
        internal bool IsSetAdditionalFeatures() => this.AdditionalFeatures != null && (this.AdditionalFeatures.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property Tileset. 
        /// <para>
        /// Specifies the desired tile set. For <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers, <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions support only the
        /// <c>vector.basemap</c> value.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>raster.satellite | vector.basemap | vector.traffic | raster.dem</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Tileset { get; set; }

        /// <summary>
        /// Checks to see if the Tileset property is set.
        /// </summary>
        internal bool IsSetTileset() => this.Tileset != null;

        /// <summary>
        /// Gets and sets the property X. 
        /// <para>
        /// The X axis value for the map tile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Max = 7)]
        public string X { get; set; }

        /// <summary>
        /// Checks to see if the X property is set.
        /// </summary>
        internal bool IsSetX() => this.X != null;

        /// <summary>
        /// Gets and sets the property Y. 
        /// <para>
        /// The Y axis value for the map tile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Max = 7)]
        public string Y { get; set; }

        /// <summary>
        /// Checks to see if the Y property is set.
        /// </summary>
        internal bool IsSetY() => this.Y != null;

        /// <summary>
        /// Gets and sets the property Z. 
        /// <para>
        /// The zoom value for the map tile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Max = 2)]
        public string Z { get; set; }

        /// <summary>
        /// Checks to see if the Z property is set.
        /// </summary>
        internal bool IsSetZ() => this.Z != null;
    }
}
