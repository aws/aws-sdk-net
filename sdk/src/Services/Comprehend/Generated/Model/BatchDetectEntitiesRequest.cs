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
    /// Container for the parameters to the BatchDetectEntities operation.
    /// Inspects the text of a batch of documents for named entities and returns information
    /// about them. For more information about named entities, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-entities.html">Entities</a>
    /// in the Comprehend Developer Guide.
    /// </summary>
    public partial class BatchDetectEntitiesRequest : AmazonComprehendRequest
    {
        private LanguageCode _languageCode;
        private List<string> _textList = new List<string>();

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language of the input documents. You can specify any of the primary languages
        /// supported by Amazon Comprehend. All documents must be in the same language.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LanguageCode LanguageCode
        {
            get { return this._languageCode; }
            set { this._languageCode = value; }
        }

        // Check to see if LanguageCode property is set
        internal bool IsSetLanguageCode()
        {
            return this._languageCode != null;
        }

        /// <summary>
        /// Gets and sets the property TextList. 
        /// <para>
        /// A list containing the UTF-8 encoded text of the input documents. The list can contain
        /// a maximum of 25 documents. The maximum size of each document is 5 KB.
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