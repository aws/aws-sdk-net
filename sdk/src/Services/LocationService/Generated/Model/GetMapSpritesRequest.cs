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
    /// Container for the parameters to the GetMapSprites operation.
    /// Retrieves the sprite sheet corresponding to a map resource. The sprite sheet is a
    /// PNG image paired with a JSON document describing the offsets of individual icons that
    /// will be displayed on a rendered map.
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
        ///  <code>sprites.png</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sprites@2x.png</code> for high pixel density displays
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For the JSON document containing image offsets. Use the following ﬁle names:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>sprites.json</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sprites@2x.json</code> for high pixel density displays
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
        /// The optional <a href="https://docs.aws.amazon.com/location/latest/developerguide/using-apikeys.html">API
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