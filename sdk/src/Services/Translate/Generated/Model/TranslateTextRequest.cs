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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Translate.Model
{
    /// <summary>
    /// Container for the parameters to the TranslateText operation.
    /// Translates input text from the source language to the target language. You can translate
    /// between English (en) and one of the following languages, or between one of the following
    /// languages and English.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Arabic (ar)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Chinese (Simplified) (zh)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// French (fr)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// German (de)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Portuguese (pt)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Spanish (es)
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To have Amazon Translate determine the source language of your text, you can specify
    /// <code>auto</code> in the <code>SourceLanguageCode</code> field. If you specify <code>auto</code>,
    /// Amazon Translate will call Amazon Comprehend to determine the source language.
    /// </para>
    /// </summary>
    public partial class TranslateTextRequest : AmazonTranslateRequest
    {
        private string _sourceLanguageCode;
        private string _targetLanguageCode;
        private string _text;

        /// <summary>
        /// Gets and sets the property SourceLanguageCode. 
        /// <para>
        /// One of the supported language codes for the source text. If the <code>TargetLanguageCode</code>
        /// is not "en", the <code>SourceLanguageCode</code> must be "en".
        /// </para>
        ///  
        /// <para>
        /// To have Amazon Translate determine the source language of your text, you can specify
        /// <code>auto</code> in the <code>SourceLanguageCode</code> field. If you specify <code>auto</code>,
        /// Amazon Translate will call Amazon Comprehend to determine the source language.
        /// </para>
        /// </summary>
        public string SourceLanguageCode
        {
            get { return this._sourceLanguageCode; }
            set { this._sourceLanguageCode = value; }
        }

        // Check to see if SourceLanguageCode property is set
        internal bool IsSetSourceLanguageCode()
        {
            return this._sourceLanguageCode != null;
        }

        /// <summary>
        /// Gets and sets the property TargetLanguageCode. 
        /// <para>
        /// One of the supported language codes for the target text. If the <code>SourceLanguageCode</code>
        /// is not "en", the <code>TargetLanguageCode</code> must be "en".
        /// </para>
        /// </summary>
        public string TargetLanguageCode
        {
            get { return this._targetLanguageCode; }
            set { this._targetLanguageCode = value; }
        }

        // Check to see if TargetLanguageCode property is set
        internal bool IsSetTargetLanguageCode()
        {
            return this._targetLanguageCode != null;
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The text to translate.
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