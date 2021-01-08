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
    /// This is the response object from the DetectKeyPhrases operation.
    /// </summary>
    public partial class DetectKeyPhrasesResponse : AmazonWebServiceResponse
    {
        private List<KeyPhrase> _keyPhrases = new List<KeyPhrase>();

        /// <summary>
        /// Gets and sets the property KeyPhrases. 
        /// <para>
        /// A collection of key phrases that Amazon Comprehend identified in the input text. For
        /// each key phrase, the response provides the text of the key phrase, where the key phrase
        /// begins and ends, and the level of confidence that Amazon Comprehend has in the accuracy
        /// of the detection. 
        /// </para>
        /// </summary>
        public List<KeyPhrase> KeyPhrases
        {
            get { return this._keyPhrases; }
            set { this._keyPhrases = value; }
        }

        // Check to see if KeyPhrases property is set
        internal bool IsSetKeyPhrases()
        {
            return this._keyPhrases != null && this._keyPhrases.Count > 0; 
        }

    }
}