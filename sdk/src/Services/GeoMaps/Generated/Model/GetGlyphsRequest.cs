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
    /// Container for the parameters to the GetGlyphs operation.
    /// <c>GetGlyphs</c> returns the map's glyphs.
    /// </summary>
    public partial class GetGlyphsRequest : AmazonGeoMapsRequest
    {
        private string _fontStack;
        private string _fontUnicodeRange;

        /// <summary>
        /// Gets and sets the property FontStack. 
        /// <para>
        /// Name of the <c>FontStack</c> to retrieve. 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>Amazon Ember Bold,Noto Sans Bold</c>.
        /// </para>
        ///  
        /// <para>
        /// The supported font stacks are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Ember Bold
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Bold Italic
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Bold,Noto Sans Bold
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Bold,Noto Sans Bold,Noto Sans Arabic Bold
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Condensed RC BdItalic
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Condensed RC Bold
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Condensed RC Bold Italic
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Condensed RC Bold,Noto Sans Bold
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Condensed RC Bold,Noto Sans Bold,Noto Sans Arabic Condensed Bold
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Condensed RC Light
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Condensed RC Light Italic
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Condensed RC LtItalic
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Condensed RC Regular
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Condensed RC Regular Italic
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Condensed RC Regular,Noto Sans Regular
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Condensed RC Regular,Noto Sans Regular,Noto Sans Arabic Condensed Regular
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Condensed RC RgItalic
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Condensed RC ThItalic
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Condensed RC Thin
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Condensed RC Thin Italic
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Heavy
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Heavy Italic
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Light
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Light Italic
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Medium
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Medium Italic
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Medium,Noto Sans Medium
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Medium,Noto Sans Medium,Noto Sans Arabic Medium
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Regular
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Regular Italic
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Regular Italic,Noto Sans Italic
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Regular Italic,Noto Sans Italic,Noto Sans Arabic Regular
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Regular,Noto Sans Regular
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Regular,Noto Sans Regular,Noto Sans Arabic Regular
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Thin
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Ember Thin Italic
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AmazonEmberCdRC_Bd
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AmazonEmberCdRC_BdIt
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AmazonEmberCdRC_Lt
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AmazonEmberCdRC_LtIt
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AmazonEmberCdRC_Rg
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AmazonEmberCdRC_RgIt
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AmazonEmberCdRC_Th
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AmazonEmberCdRC_ThIt
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AmazonEmber_Bd
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AmazonEmber_BdIt
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AmazonEmber_He
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AmazonEmber_HeIt
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AmazonEmber_Lt
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AmazonEmber_LtIt
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AmazonEmber_Md
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AmazonEmber_MdIt
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AmazonEmber_Rg
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AmazonEmber_RgIt
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AmazonEmber_Th
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AmazonEmber_ThIt
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Noto Sans Black
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Noto Sans Black Italic
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Noto Sans Bold
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Noto Sans Bold Italic
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Noto Sans Extra Bold
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Noto Sans Extra Bold Italic
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Noto Sans Extra Light
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Noto Sans Extra Light Italic
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Noto Sans Italic
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Noto Sans Light
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Noto Sans Light Italic
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Noto Sans Medium
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Noto Sans Medium Italic
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Noto Sans Regular
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Noto Sans Semi Bold
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Noto Sans Semi Bold Italic
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Noto Sans Thin
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Noto Sans Thin Italic
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NotoSans-Bold
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NotoSans-Italic
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NotoSans-Medium
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NotoSans-Regular
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Open Sans Regular,Arial Unicode MS Regular
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
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
        /// A Unicode range of characters to download glyphs for. This must be aligned to multiples
        /// of 256. 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>0-255.pdf</c> 
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

    }
}