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
    /// How to pronounce the various components of the address or place.
    /// </summary>
    public partial class PhonemeTranscription
    {
        private string _language;
        private bool? _preferred;
        private string _value;

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// A list of <a href="https://en.wikipedia.org/wiki/IETF_language_tag">BCP 47</a> compliant
        /// language codes for the results to be rendered in. If there is no data for the result
        /// in the requested language, data will be returned in the default language for the entry.
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
        /// Gets and sets the property Preferred. 
        /// <para>
        /// Boolean which indicates if it the preferred pronunciation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public bool? Preferred
        {
            get { return this._preferred; }
            set { this._preferred = value; }
        }

        // Check to see if Preferred property is set
        internal bool IsSetPreferred()
        {
            return this._preferred.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Value which indicates how to pronounce the value.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=50)]
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