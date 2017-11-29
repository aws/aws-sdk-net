/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Container for the parameters to the DetectSentiment operation.
    /// Inspects text and returns an inference of the prevailing sentiment (<code>POSITIVE</code>,
    /// <code>NEUTRAL</code>, <code>MIXED</code>, or <code>NEGATIVE</code>).
    /// </summary>
    public partial class DetectSentimentRequest : AmazonComprehendRequest
    {
        private LanguageCode _languageCode;
        private string _text;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The RFC 5646 language code for the input text. If you don't specify a language code,
        /// Amazon Comprehend detects the dominant language. If you specify the code for a language
        /// that Amazon Comprehend does not support, it returns and <code>UnsupportedLanguageException</code>.
        /// For more information about RFC 5646, see <a href="https://tools.ietf.org/html/rfc5646">Tags
        /// for Identifying Languages</a> on the <i>IETF Tools</i> web site.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Text. 
        /// <para>
        /// A UTF-8 text string. Each string must contain fewer that 5,000 bytes of UTF-8 encoded
        /// characters.
        /// </para>
        /// </summary>
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

    }
}