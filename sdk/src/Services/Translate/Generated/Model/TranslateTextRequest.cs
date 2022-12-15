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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Translate.Model
{
    /// <summary>
    /// Container for the parameters to the TranslateText operation.
    /// Translates input text from the source language to the target language. For a list
    /// of available languages and language codes, see <a href="https://docs.aws.amazon.com/translate/latest/dg/what-is-languages.html">Supported
    /// languages</a>.
    /// </summary>
    public partial class TranslateTextRequest : AmazonTranslateRequest
    {
        private TranslationSettings _settings;
        private string _sourceLanguageCode;
        private string _targetLanguageCode;
        private List<string> _terminologyNames = new List<string>();
        private string _text;

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// Settings to configure your translation output, including the option to set the formality
        /// level of the output text and the option to mask profane words and phrases.
        /// </para>
        /// </summary>
        public TranslationSettings Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return this._settings != null;
        }

        /// <summary>
        /// Gets and sets the property SourceLanguageCode. 
        /// <para>
        /// The language code for the language of the source text. The language must be a language
        /// supported by Amazon Translate. For a list of language codes, see <a href="https://docs.aws.amazon.com/translate/latest/dg/what-is-languages.html">Supported
        /// languages</a>.
        /// </para>
        ///  
        /// <para>
        /// To have Amazon Translate determine the source language of your text, you can specify
        /// <code>auto</code> in the <code>SourceLanguageCode</code> field. If you specify <code>auto</code>,
        /// Amazon Translate will call <a href="https://docs.aws.amazon.com/comprehend/latest/dg/comprehend-general.html">Amazon
        /// Comprehend</a> to determine the source language.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify <code>auto</code>, you must send the <code>TranslateText</code> request
        /// in a region that supports Amazon Comprehend. Otherwise, the request returns an error
        /// indicating that autodetect is not supported. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=5)]
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
        [AWSProperty(Required=true, Min=2, Max=5)]
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
        /// The name of the terminology list file to be used in the TranslateText request. You
        /// can use 1 terminology list at most in a <code>TranslateText</code> request. Terminology
        /// lists can contain a maximum of 256 terms.
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
        /// The text to translate. The text string can be a maximum of 10,000 bytes long. Depending
        /// on your character set, this may be fewer than 10,000 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10000)]
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