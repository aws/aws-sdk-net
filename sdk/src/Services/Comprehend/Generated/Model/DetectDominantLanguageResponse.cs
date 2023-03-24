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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// This is the response object from the DetectDominantLanguage operation.
    /// </summary>
    public partial class DetectDominantLanguageResponse : AmazonWebServiceResponse
    {
        private List<DominantLanguage> _languages = new List<DominantLanguage>();

        /// <summary>
        /// Gets and sets the property Languages. 
        /// <para>
        /// Array of languages that Amazon Comprehend detected in the input text. The array is
        /// sorted in descending order of the score (the dominant language is always the first
        /// element in the array).
        /// </para>
        ///  
        /// <para>
        /// For each language, the response returns the RFC 5646 language code and the level of
        /// confidence that Amazon Comprehend has in the accuracy of its inference. For more information
        /// about RFC 5646, see <a href="https://tools.ietf.org/html/rfc5646">Tags for Identifying
        /// Languages</a> on the <i>IETF Tools</i> web site.
        /// </para>
        /// </summary>
        public List<DominantLanguage> Languages
        {
            get { return this._languages; }
            set { this._languages = value; }
        }

        // Check to see if Languages property is set
        internal bool IsSetLanguages()
        {
            return this._languages != null && this._languages.Count > 0; 
        }

    }
}