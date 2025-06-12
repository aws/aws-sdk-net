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

#pragma warning disable CS0612,CS0618,CS1570
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
        private List<string> _terminologyNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _text;

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// Settings to configure your translation output. You can configure the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Brevity: reduces the length of the translated output for most translations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Formality: sets the formality level of the output text.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Profanity: masks profane words and phrases in your translation output.
        /// </para>
        ///  </li> </ul>
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
        /// The language code for the language of the source text. For a list of language codes,
        /// see <a href="https://docs.aws.amazon.com/translate/latest/dg/what-is-languages.html">Supported
        /// languages</a>.
        /// </para>
        ///  
        /// <para>
        /// To have Amazon Translate determine the source language of your text, you can specify
        /// <c>auto</c> in the <c>SourceLanguageCode</c> field. If you specify <c>auto</c>, Amazon
        /// Translate will call <a href="https://docs.aws.amazon.com/comprehend/latest/dg/comprehend-general.html">Amazon
        /// Comprehend</a> to determine the source language.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify <c>auto</c>, you must send the <c>TranslateText</c> request in a region
        /// that supports Amazon Comprehend. Otherwise, the request returns an error indicating
        /// that autodetect is not supported. 
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
        /// The language code requested for the language of the target text. For a list of language
        /// codes, see <a href="https://docs.aws.amazon.com/translate/latest/dg/what-is-languages.html">Supported
        /// languages</a>.
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
        /// The name of a terminology list file to add to the translation job. This file provides
        /// source terms and the desired translation for each term. A terminology list can contain
        /// a maximum of 256 terms. You can use one custom terminology resource in your translation
        /// request.
        /// </para>
        ///  
        /// <para>
        /// Use the <a>ListTerminologies</a> operation to get the available terminology lists.
        /// </para>
        ///  
        /// <para>
        /// For more information about custom terminology lists, see <a href="https://docs.aws.amazon.com/translate/latest/dg/how-custom-terminology.html">Custom
        /// terminology</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TerminologyNames
        {
            get { return this._terminologyNames; }
            set { this._terminologyNames = value; }
        }

        // Check to see if TerminologyNames property is set
        internal bool IsSetTerminologyNames()
        {
            return this._terminologyNames != null && (this._terminologyNames.Count > 0 || !AWSConfigs.InitializeCollections); 
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