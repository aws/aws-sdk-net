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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
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
namespace Amazon.GeoPlaces.Model
{
    /// <summary>
    /// Components of a street.
    /// </summary>
    public partial class StreetComponents
    {
        private string _baseName;
        private string _direction;
        private string _language;
        private string _prefix;
        private string _suffix;
        private string _type;
        private TypePlacement _typePlacement;
        private string _typeSeparator;

        /// <summary>
        /// Gets and sets the property BaseName. 
        /// <para>
        /// Base name part of the street name. 
        /// </para>
        ///  
        /// <para>
        /// Example: Younge from the "Younge street".
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=200)]
        public string BaseName
        {
            get { return this._baseName; }
            set { this._baseName = value; }
        }

        // Check to see if BaseName property is set
        internal bool IsSetBaseName()
        {
            return this._baseName != null;
        }

        /// <summary>
        /// Gets and sets the property Direction. 
        /// <para>
        /// Indicates the official directional identifiers assigned to highways.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=50)]
        public string Direction
        {
            get { return this._direction; }
            set { this._direction = value; }
        }

        // Check to see if Direction property is set
        internal bool IsSetDirection()
        {
            return this._direction != null;
        }

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// A <a href="https://en.wikipedia.org/wiki/IETF_language_tag">BCP 47</a> compliant language
        /// codes for the results to be rendered in. If there is no data for the result in the
        /// requested language, data will be returned in the default language for the entry.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=35)]
        public string Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// A prefix is a directional identifier that precedes, but is not included in, the base
        /// name of a road. 
        /// </para>
        ///  
        /// <para>
        /// Example: E for East.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=50)]
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

        /// <summary>
        /// Gets and sets the property Suffix. 
        /// <para>
        /// A suffix is a directional identifier that follows, but is not included in, the base
        /// name of a road. 
        /// </para>
        ///  
        /// <para>
        /// Example W for West.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=50)]
        public string Suffix
        {
            get { return this._suffix; }
            set { this._suffix = value; }
        }

        // Check to see if Suffix property is set
        internal bool IsSetSuffix()
        {
            return this._suffix != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Street type part of the street name. 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>"avenue"</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=50)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property TypePlacement. 
        /// <para>
        /// Defines if the street type is before or after the base name.
        /// </para>
        /// </summary>
        public TypePlacement TypePlacement
        {
            get { return this._typePlacement; }
            set { this._typePlacement = value; }
        }

        // Check to see if TypePlacement property is set
        internal bool IsSetTypePlacement()
        {
            return this._typePlacement != null;
        }

        /// <summary>
        /// Gets and sets the property TypeSeparator. 
        /// <para>
        /// Defines a separator character such as <c>""</c> or <c>" "</c> between the base name
        /// and type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public string TypeSeparator
        {
            get { return this._typeSeparator; }
            set { this._typeSeparator = value; }
        }

        // Check to see if TypeSeparator property is set
        internal bool IsSetTypeSeparator()
        {
            return this._typeSeparator != null;
        }

    }
}