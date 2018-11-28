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
    /// Translates input text from the source language to the target language. It is not necessary
    /// to use English (en) as either the source or the target language but not all language
    /// combinations are supported by Amazon Translate. For more information, see <a href="http://docs.aws.amazon.com/translate/latest/dg/pairs.html">Supported
    /// Language Pairs</a>.
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
    /// Chinese (Traditional) (zh-TW)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Czech (cs)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Danish (da)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Dutch (nl)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// English (en)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Finnish (fi)
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
    /// Hebrew (he)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Indonesian (id)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Italian (it)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Japanese (ja)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Korean (ko)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Polish (pl)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Portuguese (pt)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Russian (ru)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Spanish (es)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Swedish (sv)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Turkish (tr)
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
        private List<string> _terminologyNames = new List<string>();
        private string _text;

        /// <summary>
        /// Gets and sets the property SourceLanguageCode. 
        /// <para>
        /// The language code for the language of the source text. The language must be a language
        /// supported by Amazon Translate. 
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
        /// The language code requested for the language of the target text. The language must
        /// be a language supported by Amazon Translate.
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
        /// Gets and sets the property TerminologyNames. 
        /// <para>
        /// The TerminologyNames list that is taken as input to the TranslateText request. This
        /// has a minimum length of 0 and a maximum length of 1.
        /// </para>
        /// </summary>
        public List<string> TerminologyNames
        {
            get { return this._terminologyNames; }
            set { this._terminologyNames = value; }
        }

        // Check to see if TerminologyNames property is set
        internal bool IsSetTerminologyNames()
        {
            return this._terminologyNames != null && this._terminologyNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The text to translate. The text string can be a maximum of 5,000 bytes long. Depending
        /// on your character set, this may be fewer than 5,000 characters.
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