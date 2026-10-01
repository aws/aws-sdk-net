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

namespace Amazon.GeoPlaces.Model
{
    /// <summary>
    /// A translation or alternative name for an address component.
    /// </summary>
    public partial class TranslationName
    {
        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// A <a href="https://www.iana.org/assignments/language-subtag-registry/language-subtag-registry">BCP
        /// 47</a> compliant language code for the translation name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 35)]
        public string Language { get; set; }

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null;

        /// <summary>
        /// Gets and sets the property Primary. 
        /// <para>
        /// If <c>true</c>, indicates this is the primary name variant for the given language.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? Primary { get; set; }

        /// <summary>
        /// Checks to see if the Primary property is set.
        /// </summary>
        internal bool IsSetPrimary() => this.Primary.HasValue;

        /// <summary>
        /// Gets and sets the property Transliterated. 
        /// <para>
        /// If <c>true</c>, indicates this name is a transliterated version rather than a native
        /// script translation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? Transliterated { get; set; }

        /// <summary>
        /// Checks to see if the Transliterated property is set.
        /// </summary>
        internal bool IsSetTransliterated() => this.Transliterated.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of translation name. Valid values are <c>Abbreviation</c>, <c>AreaCode</c>,
        /// <c>BaseName</c>, <c>Exonym</c>, <c>Shortened</c>, and <c>Synonym</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TranslationNameType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The translated or alternative name value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 200)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
