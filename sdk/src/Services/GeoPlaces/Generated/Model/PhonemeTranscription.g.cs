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
    /// How to pronounce the various components of the address or place.
    /// </summary>
    public partial class PhonemeTranscription
    {
        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// A list of <a href="https://www.iana.org/assignments/language-subtag-registry/language-subtag-registry">BCP
        /// 47</a> compliant language codes for the results to be rendered in. If there is no
        /// data for the result in the requested language, data will be returned in the default
        /// language for the entry.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 35)]
        public string Language { get; set; }

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null;

        /// <summary>
        /// Gets and sets the property Preferred. 
        /// <para>
        /// Boolean which indicates if it the preferred pronunciation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? Preferred { get; set; }

        /// <summary>
        /// Checks to see if the Preferred property is set.
        /// </summary>
        internal bool IsSetPreferred() => this.Preferred.HasValue;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Value which indicates how to pronounce the value.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 50)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
