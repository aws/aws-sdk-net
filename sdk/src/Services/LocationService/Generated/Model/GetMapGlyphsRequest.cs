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
    /// Container for the parameters to the GetMapGlyphs operation.
    /// Retrieves glyphs used to display labels on a map.
    /// </summary>
    public partial class GetMapGlyphsRequest : AmazonLocationServiceRequest
    {
        private string _fontStack;
        private string _fontUnicodeRange;
        private string _key;
        private string _mapName;

        /// <summary>
        /// Gets and sets the property FontStack. 
        /// <para>
        /// A comma-separated list of fonts to load glyphs from in order of preference. For example,
        /// <c>Noto Sans Regular, Arial Unicode</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid font stacks for <a href="https://docs.aws.amazon.com/location/previous/developerguide/esri.html">Esri</a>
        /// styles: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// VectorEsriDarkGrayCanvas – <c>Ubuntu Medium Italic</c> | <c>Ubuntu Medium</c> | <c>Ubuntu
        /// Italic</c> | <c>Ubuntu Regular</c> | <c>Ubuntu Bold</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// VectorEsriLightGrayCanvas – <c>Ubuntu Italic</c> | <c>Ubuntu Regular</c> | <c>Ubuntu
        /// Light</c> | <c>Ubuntu Bold</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// VectorEsriTopographic – <c>Noto Sans Italic</c> | <c>Noto Sans Regular</c> | <c>Noto
        /// Sans Bold</c> | <c>Noto Serif Regular</c> | <c>Roboto Condensed Light Italic</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// VectorEsriStreets – <c>Arial Regular</c> | <c>Arial Italic</c> | <c>Arial Bold</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// VectorEsriNavigation – <c>Arial Regular</c> | <c>Arial Italic</c> | <c>Arial Bold</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Valid font stacks for <a href="https://docs.aws.amazon.com/location/previous/developerguide/HERE.html">HERE
        /// Technologies</a> styles:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// VectorHereContrast – <c>Fira GO Regular</c> | <c>Fira GO Bold</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// VectorHereExplore, VectorHereExploreTruck, HybridHereExploreSatellite – <c>Fira GO
        /// Italic</c> | <c>Fira GO Map</c> | <c>Fira GO Map Bold</c> | <c>Noto Sans CJK JP Bold</c>
        /// | <c>Noto Sans CJK JP Light</c> | <c>Noto Sans CJK JP Regular</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Valid font stacks for <a href="https://docs.aws.amazon.com/location/previous/developerguide/grab.html">GrabMaps</a>
        /// styles:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// VectorGrabStandardLight, VectorGrabStandardDark – <c>Noto Sans Regular</c> | <c>Noto
        /// Sans Medium</c> | <c>Noto Sans Bold</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Valid font stacks for <a href="https://docs.aws.amazon.com/location/previous/developerguide/open-data.html">Open
        /// Data</a> styles:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// VectorOpenDataStandardLight, VectorOpenDataStandardDark, VectorOpenDataVisualizationLight,
        /// VectorOpenDataVisualizationDark – <c>Amazon Ember Regular,Noto Sans Regular</c> |
        /// <c>Amazon Ember Bold,Noto Sans Bold</c> | <c>Amazon Ember Medium,Noto Sans Medium</c>
        /// | <c>Amazon Ember Regular Italic,Noto Sans Italic</c> | <c>Amazon Ember Condensed
        /// RC Regular,Noto Sans Regular</c> | <c>Amazon Ember Condensed RC Bold,Noto Sans Bold</c>
        /// | <c>Amazon Ember Regular,Noto Sans Regular,Noto Sans Arabic Regular</c> | <c>Amazon
        /// Ember Condensed RC Bold,Noto Sans Bold,Noto Sans Arabic Condensed Bold</c> | <c>Amazon
        /// Ember Bold,Noto Sans Bold,Noto Sans Arabic Bold</c> | <c>Amazon Ember Regular Italic,Noto
        /// Sans Italic,Noto Sans Arabic Regular</c> | <c>Amazon Ember Condensed RC Regular,Noto
        /// Sans Regular,Noto Sans Arabic Condensed Regular</c> | <c>Amazon Ember Medium,Noto
        /// Sans Medium,Noto Sans Arabic Medium</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The fonts used by the Open Data map styles are combined fonts that use <c>Amazon Ember</c>
        /// for most glyphs but <c>Noto Sans</c> for glyphs unsupported by <c>Amazon Ember</c>.
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
        /// characters. For example, 0–255 includes all characters from range <c>U+0000</c> to
        /// <c>00FF</c>. Must be aligned to multiples of 256.
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