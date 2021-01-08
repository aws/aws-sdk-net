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
    /// The result of calling the operation. The operation returns one object for each document
    /// that is successfully processed by the operation.
    /// </summary>
    public partial class BatchDetectKeyPhrasesItemResult
    {
        private int? _index;
        private List<KeyPhrase> _keyPhrases = new List<KeyPhrase>();

        /// <summary>
        /// Gets and sets the property Index. 
        /// <para>
        /// The zero-based index of the document in the input list.
        /// </para>
        /// </summary>
        public int Index
        {
            get { return this._index.GetValueOrDefault(); }
            set { this._index = value; }
        }

        // Check to see if Index property is set
        internal bool IsSetIndex()
        {
            return this._index.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeyPhrases. 
        /// <para>
        /// One or more <a>KeyPhrase</a> objects, one for each key phrase detected in the document.
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