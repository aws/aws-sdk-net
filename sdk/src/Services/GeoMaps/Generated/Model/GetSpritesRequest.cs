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
    /// Container for the parameters to the GetSprites operation.
    /// <c>GetSprites</c> returns the map's sprites.
    /// </summary>
    public partial class GetSpritesRequest : AmazonGeoMapsRequest
    {
        private ColorScheme _colorScheme;
        private string _fileName;
        private MapStyle _style;
        private Variant _variant;

        /// <summary>
        /// Gets and sets the property ColorScheme. 
        /// <para>
        /// Sets color tone for map such as dark and light for specific map styles. It applies
        /// to only vector map styles such as Standard and Monochrome.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>Light</c> 
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>Light</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// Valid values for ColorScheme are case sensitive.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public ColorScheme ColorScheme
        {
            get { return this._colorScheme; }
            set { this._colorScheme = value; }
        }

        // Check to see if ColorScheme property is set
        internal bool IsSetColorScheme()
        {
            return this._colorScheme != null;
        }

        /// <summary>
        /// Gets and sets the property FileName. 
        /// <para>
        ///  <c>Sprites</c> API: The name of the sprite ﬁle to retrieve, following pattern <c>sprites(@2x)?\.(png|json)</c>.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>sprites.png</c> 
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
        /// Gets and sets the property Style. 
        /// <para>
        /// Style specifies the desired map style for the <c>Sprites</c> APIs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MapStyle Style
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
        /// Gets and sets the property Variant. 
        /// <para>
        /// Optimizes map styles for specific use case or industry. You can choose allowed variant
        /// only with Standard map style.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>Default</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// Valid values for Variant are case sensitive.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public Variant Variant
        {
            get { return this._variant; }
            set { this._variant = value; }
        }

        // Check to see if Variant property is set
        internal bool IsSetVariant()
        {
            return this._variant != null;
        }

    }
}