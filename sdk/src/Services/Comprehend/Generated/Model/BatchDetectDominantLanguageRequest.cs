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
    /// Container for the parameters to the BatchDetectDominantLanguage operation.
    /// Determines the dominant language of the input text for a batch of documents. For a
    /// list of languages that Amazon Comprehend can detect, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-languages.html">Amazon
    /// Comprehend Supported Languages</a>.
    /// </summary>
    public partial class BatchDetectDominantLanguageRequest : AmazonComprehendRequest
    {
        private List<string> _textList = new List<string>();

        /// <summary>
        /// Gets and sets the property TextList. 
        /// <para>
        /// A list containing the UTF-8 encoded text of the input documents. The list can contain
        /// a maximum of 25 documents. Each document should contain at least 20 characters. The
        /// maximum size of each document is 5 KB.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1)]
        public List<string> TextList
        {
            get { return this._textList; }
            set { this._textList = value; }
        }

        // Check to see if TextList property is set
        internal bool IsSetTextList()
        {
            return this._textList != null && this._textList.Count > 0; 
        }

    }
}