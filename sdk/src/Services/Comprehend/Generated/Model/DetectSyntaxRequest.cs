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
    /// Container for the parameters to the DetectSyntax operation.
    /// Inspects text for syntax and the part of speech of words in the document. For more
    /// information, <a>how-syntax</a>.
    /// </summary>
    public partial class DetectSyntaxRequest : AmazonComprehendRequest
    {
        private SyntaxLanguageCode _languageCode;
        private string _text;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code of the input documents. You can specify English ("en") or Spanish
        /// ("es").
        /// </para>
        /// </summary>
        public SyntaxLanguageCode LanguageCode
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
        /// A UTF-8 string. Each string must contain fewer that 5,000 bytes of UTF encoded characters.
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