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
    /// Container for the parameters to the GetMapSprites operation.
    /// <important> 
    /// <para>
    /// This operation is no longer current and may be deprecated in the future. We recommend
    /// upgrading to <a href="https://docs.aws.amazon.com/location/latest/APIReference/API_geomaps_GetSprites.html">
    /// <c>GetSprites</c> </a> unless you require <c>Grab</c> data.
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>GetMapSprites</c> is part of a previous Amazon Location Service Maps API (version
    /// 1) which has been superseded by a more intuitive, powerful, and complete API (version
    /// 2).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The version 2 <c>GetSprites</c> operation gives a better user experience and is compatible
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
    /// Retrieves the sprite sheet corresponding to a map resource. The sprite sheet is a
    /// PNG image paired with a JSON document describing the offsets of individual icons that
    /// will be displayed on a rendered map.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial class GetMapSpritesRequest : AmazonLocationServiceRequest
    {
        private string _fileName;
        private string _key;
        private string _mapName;

        /// <summary>
        /// Gets and sets the property FileName. 
        /// <para>
        /// The name of the sprite ﬁle. Use the following ﬁle names for the sprite sheet:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>sprites.png</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sprites@2x.png</c> for high pixel density displays
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For the JSON document containing image offsets. Use the following ﬁle names:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>sprites.json</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sprites@2x.json</c> for high pixel density displays
        /// </para>
        ///  </li> </ul>
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
        /// The map resource associated with the sprite ﬁle.
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

    }
}