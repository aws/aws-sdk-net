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
        /// A comma-separated list of fonts to load glyphs from in order of preference. For example,
        /// <code>Noto Sans Regular, Arial Unicode</code>.
        /// </para>
        ///  
        /// <para>
        /// Valid fonts stacks for <a href="https://docs.aws.amazon.com/location/latest/developerguide/esri.html">Esri</a>
        /// styles: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// VectorEsriDarkGrayCanvas – <code>Ubuntu Medium Italic</code> | <code>Ubuntu Medium</code>
        /// | <code>Ubuntu Italic</code> | <code>Ubuntu Regular</code> | <code>Ubuntu Bold</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// VectorEsriLightGrayCanvas – <code>Ubuntu Italic</code> | <code>Ubuntu Regular</code>
        /// | <code>Ubuntu Light</code> | <code>Ubuntu Bold</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// VectorEsriTopographic – <code>Noto Sans Italic</code> | <code>Noto Sans Regular</code>
        /// | <code>Noto Sans Bold</code> | <code>Noto Serif Regular</code> | <code>Roboto Condensed
        /// Light Italic</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// VectorEsriStreets – <code>Arial Regular</code> | <code>Arial Italic</code> | <code>Arial
        /// Bold</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// VectorEsriNavigation – <code>Arial Regular</code> | <code>Arial Italic</code> | <code>Arial
        /// Bold</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Valid font stacks for <a href="https://docs.aws.amazon.com/location/latest/developerguide/HERE.html">HERE
        /// Technologies</a> styles:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// VectorHereContrast – <code>Fira GO Regular</code> | <code>Fira GO Bold</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// VectorHereExplore, VectorHereExploreTruck, HybridHereExploreSatellite – <code>Fira
        /// GO Italic</code> | <code>Fira GO Map</code> | <code>Fira GO Map Bold</code> | <code>Noto
        /// Sans CJK JP Bold</code> | <code>Noto Sans CJK JP Light</code> | <code>Noto Sans CJK
        /// JP Regular</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Valid font stacks for <a href="https://docs.aws.amazon.com/location/latest/developerguide/grab.html">GrabMaps</a>
        /// styles:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// VectorGrabStandardLight, VectorGrabStandardDark – <code>Noto Sans Regular</code> |
        /// <code>Noto Sans Medium</code> | <code>Noto Sans Bold</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Valid font stacks for <a href="https://docs.aws.amazon.com/location/latest/developerguide/open-data.html">Open
        /// Data (Preview)</a> styles:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// VectorOpenDataStandardLight – <code>Amazon Ember Regular,Noto Sans Regular</code>
        /// | <code>Amazon Ember Bold,Noto Sans Bold</code> | <code>Amazon Ember Medium,Noto Sans
        /// Medium</code> | <code>Amazon Ember Regular Italic,Noto Sans Italic</code> | <code>Amazon
        /// Ember Condensed RC Regular,Noto Sans Regular</code> | <code>Amazon Ember Condensed
        /// RC Bold,Noto Sans Bold</code> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The fonts used by <code>VectorOpenDataStandardLight</code> are combined fonts that
        /// use <code>Amazon Ember</code> for most glyphs but <code>Noto Sans</code> for glyphs
        /// unsupported by <code>Amazon Ember</code>.
        /// </para>
        ///  </note>
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
        /// characters. For example, 0–255 includes all characters from range <code>U+0000</code>
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