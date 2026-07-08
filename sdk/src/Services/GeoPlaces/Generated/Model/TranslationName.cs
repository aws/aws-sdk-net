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
    /// A translation or alternative name for an address component.
    /// </summary>
    public partial class TranslationName
    {
        private string _language;
        private bool? _primary;
        private bool? _transliterated;
        private TranslationNameType _type;
        private string _value;

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// A <a href="https://www.iana.org/assignments/language-subtag-registry/language-subtag-registry">BCP
        /// 47</a> compliant language code for the translation name.
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
        /// Gets and sets the property Primary. 
        /// <para>
        /// If <c>true</c>, indicates this is the primary name variant for the given language.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public bool? Primary
        {
            get { return this._primary; }
            set { this._primary = value; }
        }

        // Check to see if Primary property is set
        internal bool IsSetPrimary()
        {
            return this._primary.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Transliterated. 
        /// <para>
        /// If <c>true</c>, indicates this name is a transliterated version rather than a native
        /// script translation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public bool? Transliterated
        {
            get { return this._transliterated; }
            set { this._transliterated = value; }
        }

        // Check to see if Transliterated property is set
        internal bool IsSetTransliterated()
        {
            return this._transliterated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of translation name. Valid values are <c>Abbreviation</c>, <c>AreaCode</c>,
        /// <c>BaseName</c>, <c>Exonym</c>, <c>Shortened</c>, and <c>Synonym</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TranslationNameType Type
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
        /// Gets and sets the property Value. 
        /// <para>
        /// The translated or alternative name value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=200)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}