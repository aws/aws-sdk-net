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
    /// Container for the parameters to the GetMapGlyphs operation.
    /// Retrieves glyphs used to display labels on a map.
    /// </summary>
    public partial class GetMapGlyphsRequest : AmazonLocationServiceRequest
    {
        private string _fontStack;
        private string _fontUnicodeRange;
        private string _mapName;

        /// <summary>
        /// Gets and sets the property FontStack. 
        /// <para>
        /// A comma-separated list of fonts to load glyphs from in order of preference.. For example,
        /// <code>Noto Sans, Arial Unicode</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FontStack
        {
            get { return this._fontStack; }
            set { this._fontStack = value; }
        }

        // Check to see if FontStack property is set
        internal bool IsSetFontStack()
        {
            return this._fontStack != null;
        }

        /// <summary>
        /// Gets and sets the property FontUnicodeRange. 
        /// <para>
        /// A Unicode range of characters to download glyphs for. Each response will contain 256
        /// characters. For example, 0-255 includes all characters from range <code>U+0000</code>
        /// to <code>00FF</code>. Must be aligned to multiples of 256.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FontUnicodeRange
        {
            get { return this._fontUnicodeRange; }
            set { this._fontUnicodeRange = value; }
        }

        // Check to see if FontUnicodeRange property is set
        internal bool IsSetFontUnicodeRange()
        {
            return this._fontUnicodeRange != null;
        }

        /// <summary>
        /// Gets and sets the property MapName. 
        /// <para>
        /// The map resource associated with the glyph ﬁle.
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